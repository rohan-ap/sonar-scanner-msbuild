﻿//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="SonarSource SA and Microsoft Corporation">
//   (c) SonarSource SA and Microsoft Corporation.  All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using Sonar.Common;
using System;
using System.IO;

namespace SonarRunner.Shim
{
    public class Program
    {
        public static int Main(string[] args)
        {
            ConsoleLogger logger = new ConsoleLogger();

            if (args.Length != 1)
            {
                logger.LogError(Resources.ERR_InvalidCommandLineArgs);
                return 1;
            }

            AnalysisConfig config = TryGetAnalysisConfig(args[0], logger);
            if (config == null)
            {
                return 1;
            }

            ISonarRunner runnerShim = new SonarRunnerWrapper();
            bool success = runnerShim.Execute(config, logger);

            return success ? 0 : 1;
        }

        private static AnalysisConfig TryGetAnalysisConfig(string suppliedPath, ILogger logger)
        {
            suppliedPath = Path.GetFullPath(suppliedPath); // turn relative into absolute paths

            if (!File.Exists(suppliedPath))
            {
                logger.LogError(Resources.ERR_InvalidAnalysisConfigFilePath, suppliedPath);
                return null;
            }

            AnalysisConfig config = null;
            try
            {
                config = AnalysisConfig.Load(suppliedPath);
            }
            catch (InvalidOperationException ex)
            {
                logger.LogError(Resources.ERR_ErrorLoadingConfigFile, ex.Message);
            }
            return config;
        }

    }
}