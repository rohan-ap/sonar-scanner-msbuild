﻿/*
 * SonarScanner for .NET
 * Copyright (C) 2016-2023 SonarSource SA
 * mailto: info AT sonarsource DOT com
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 3 of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * along with this program; if not, write to the Free Software Foundation,
 * Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using FluentAssertions;
using SonarScanner.MSBuild.PreProcessor.Protobuf;
using SonarScanner.MSBuild.PreProcessor.Roslyn.Model;

namespace SonarScanner.MSBuild.PreProcessor.Test
{
    internal class MockSonarWebServer : ISonarWebServer
    {
        private readonly string organization;
        private readonly List<string> calledMethods = new();

        public ServerDataModel Data { get; } = new();
        public IList<SensorCacheEntry> Cache { get; set; }
        public Func<Task<bool>> IsServerLicenseValidImplementation { get; set; } = () => Task.FromResult(true);
        public Action TryDownloadQualityProfilePreprocessing { get; set; } = () => { };

        public Version ServerVersion
        {
            get
            {
                LogMethodCalled();
                return Data.SonarQubeVersion;
            }
        }

        public MockSonarWebServer(string organization = null)
        {
            this.organization = organization;
        }

        public void AssertMethodCalled(string methodName, int callCount)
        {
            var actualCalls = calledMethods.Count(n => string.Equals(methodName, n));
            actualCalls.Should().Be(callCount, "Method was not called the expected number of times");
        }

        Task<bool> ISonarWebServer.IsServerLicenseValid()
        {
            LogMethodCalled();
            return IsServerLicenseValidImplementation();
        }

        Task<IList<SonarRule>> ISonarWebServer.DownloadRules(string qProfile)
        {
            LogMethodCalled();
            qProfile.Should().NotBeNullOrEmpty("Quality profile is required");
            var profile = Data.QualityProfiles.FirstOrDefault(qp => string.Equals(qp.Id, qProfile));
            return Task.FromResult(profile?.Rules);
        }

        Task<IEnumerable<string>> ISonarWebServer.DownloadAllLanguages()
        {
            LogMethodCalled();
            return Task.FromResult(Data.Languages.AsEnumerable());
        }

        Task<IDictionary<string, string>> ISonarWebServer.DownloadProperties(string projectKey, string projectBranch)
        {
            LogMethodCalled();
            projectKey.Should().NotBeNullOrEmpty("Project key is required");
            return Task.FromResult(Data.ServerProperties);
        }

        Task<string> ISonarWebServer.DownloadQualityProfile(string projectKey, string projectBranch, string language)
        {
            LogMethodCalled();
            TryDownloadQualityProfilePreprocessing();
            projectKey.Should().NotBeNullOrEmpty("Project key is required");
            language.Should().NotBeNullOrEmpty("Language is required");

            var projectId = projectKey;
            if (!string.IsNullOrWhiteSpace(projectBranch))
            {
                projectId = projectKey + ":" + projectBranch;
            }

            var profile = Data.QualityProfiles.FirstOrDefault(qp => qp.Language == language && qp.Projects.Contains(projectId) && qp.Organization == organization);
            return Task.FromResult(profile?.Id);
        }

        Task<bool> ISonarWebServer.TryDownloadEmbeddedFile(string pluginKey, string embeddedFileName, string targetDirectory)
        {
            LogMethodCalled();

            pluginKey.Should().NotBeNullOrEmpty("plugin key is required");
            embeddedFileName.Should().NotBeNullOrEmpty("embeddedFileName is required");
            targetDirectory.Should().NotBeNullOrEmpty("targetDirectory is required");

            var data = Data.FindEmbeddedFile(pluginKey, embeddedFileName);
            if (data == null)
            {
                return Task.FromResult(false);
            }
            else
            {
                var targetFilePath = Path.Combine(targetDirectory, embeddedFileName);
                File.WriteAllBytes(targetFilePath, data);
                return Task.FromResult(true);
            }
        }

        Task<IList<SensorCacheEntry>> ISonarWebServer.DownloadCache(ProcessedArgs localSettings) =>
            Task.FromResult(localSettings.ProjectKey == "key-no-cache" ? Array.Empty<SensorCacheEntry>() : Cache);

        private void LogMethodCalled([CallerMemberName] string methodName = null) =>
            calledMethods.Add(methodName);

        public void Dispose()
        {
            // Nothing needed
        }
    }
}
