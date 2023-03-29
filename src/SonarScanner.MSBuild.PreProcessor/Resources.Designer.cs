﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SonarScanner.MSBuild.PreProcessor {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SonarScanner.MSBuild.PreProcessor.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SonarScanner for MSBuild Begin Step.
        /// </summary>
        internal static string AssemblyDescription {
            get {
                return ResourceManager.GetString("AssemblyDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /install:[true|false] - install standard MSBuild targets required for analysis (default true).
        /// </summary>
        internal static string CmdLine_ArgDescription_InstallTargets {
            get {
                return ResourceManager.GetString("CmdLine_ArgDescription_InstallTargets", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /organization:[Organization to which the project belongs].
        /// </summary>
        internal static string CmdLine_ArgDescription_Organization {
            get {
                return ResourceManager.GetString("CmdLine_ArgDescription_Organization", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /key:[SonarQube/SonarCloud project key].
        /// </summary>
        internal static string CmdLine_ArgDescription_ProjectKey {
            get {
                return ResourceManager.GetString("CmdLine_ArgDescription_ProjectKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /name:[SonarQube/SonarCloud project name] - required for SonarQube &lt; 6.1.
        /// </summary>
        internal static string CmdLine_ArgDescription_ProjectName {
            get {
                return ResourceManager.GetString("CmdLine_ArgDescription_ProjectName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /version:[SonarQube/SonarCloud project version] - required for SonarQube &lt; 6.1.
        /// </summary>
        internal static string CmdLine_ArgDescription_ProjectVersion {
            get {
                return ResourceManager.GetString("CmdLine_ArgDescription_ProjectVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured when calling &apos;{0}&apos;: {1}.
        /// </summary>
        internal static string ERR_ErrorDuringWebCall {
            get {
                return ResourceManager.GetString("ERR_ErrorDuringWebCall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unauthorized: Access is denied due to invalid credentials. Please check the authentication parameters..
        /// </summary>
        internal static string ERR_InvalidCredentials {
            get {
                return ResourceManager.GetString("ERR_InvalidCredentials", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to connect to server. Please check if the server is running and if the address is correct. Url: &apos;{0}&apos;..
        /// </summary>
        internal static string ERR_UnableToConnectToServer {
            get {
                return ResourceManager.GetString("ERR_UnableToConnectToServer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your SonarQube instance seems to have an invalid license. Please check it. Server url: {0}.
        /// </summary>
        internal static string ERR_UnlicensedServer {
            get {
                return ResourceManager.GetString("ERR_UnlicensedServer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid value for /install: {0}. Valid values are &quot;true&quot; or &quot;false&quot;..
        /// </summary>
        internal static string ERROR_CmdLine_InvalidInstallTargetsValue {
            get {
                return ResourceManager.GetString("ERROR_CmdLine_InvalidInstallTargetsValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot download quality profile. Check scanner arguments and the reported URL for more information..
        /// </summary>
        internal static string ERROR_DownloadingQualityProfileFailed {
            get {
                return ResourceManager.GetString("ERROR_DownloadingQualityProfileFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following CheckId should not appear multiple times: {0}.
        /// </summary>
        internal static string ERROR_DuplicateCheckId {
            get {
                return ResourceManager.GetString("ERROR_DuplicateCheckId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expecting at least the following command line argument:
        ///- SonarQube/SonarCloud project key
        ///The full path to a settings file can also be supplied. If it is not supplied, the exe will attempt to locate a default settings file in the same directory as the SonarQube Scanner for MSBuild.
        ///Use &apos;/?&apos; or &apos;/h&apos; to see the help message..
        /// </summary>
        internal static string ERROR_InvalidCommandLineArgs {
            get {
                return ResourceManager.GetString("ERROR_InvalidCommandLineArgs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid project key. Allowed characters are alphanumeric, &apos;-&apos;, &apos;_&apos;, &apos;.&apos; and &apos;:&apos;, with at least one non-digit..
        /// </summary>
        internal static string ERROR_InvalidProjectKeyArg {
            get {
                return ResourceManager.GetString("ERROR_InvalidProjectKeyArg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing analysis setting: {0}.
        /// </summary>
        internal static string ERROR_MissingSetting {
            get {
                return ResourceManager.GetString("ERROR_MissingSetting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to sonar.organization parameter has been detected in the provided SonarQube.Analysis.xml config file. Please pass it in the command line instead, using /o: flag..
        /// </summary>
        internal static string ERROR_Organization_Provided_In_SonarQubeAnalysis_file {
            get {
                return ResourceManager.GetString("ERROR_Organization_Provided_In_SonarQubeAnalysis_file", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It seems that you are using an old version of SonarQube which is not supported anymore. Please update to at least 6.7..
        /// </summary>
        internal static string ERROR_UnsupportedSonarQubeVersion {
            get {
                return ResourceManager.GetString("ERROR_UnsupportedSonarQubeVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SonarQube Community Edition detected, license is valid..
        /// </summary>
        internal static string MSG_CE_Detected_LicenseValid {
            get {
                return ResourceManager.GetString("MSG_CE_Detected_LicenseValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Checking validity of server license.
        /// </summary>
        internal static string MSG_CheckingLicenseValidity {
            get {
                return ResourceManager.GetString("MSG_CheckingLicenseValidity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating config and output folders....
        /// </summary>
        internal static string MSG_CreatingFolders {
            get {
                return ResourceManager.GetString("MSG_CreatingFolders", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Downloading from {0} failed. Http status code is {1}..
        /// </summary>
        internal static string MSG_DownloadFailed {
            get {
                return ResourceManager.GetString("MSG_DownloadFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Downloading from {0}....
        /// </summary>
        internal static string MSG_Downloading {
            get {
                return ResourceManager.GetString("MSG_Downloading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Downloading cache. Project key: {0}, branch: {1}..
        /// </summary>
        internal static string MSG_DownloadingCache {
            get {
                return ResourceManager.GetString("MSG_DownloadingCache", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Downloading file to {0}....
        /// </summary>
        internal static string MSG_DownloadingFile {
            get {
                return ResourceManager.GetString("MSG_DownloadingFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Downloading {0} to {1}.
        /// </summary>
        internal static string MSG_DownloadingZip {
            get {
                return ResourceManager.GetString("MSG_DownloadingZip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Extracting files to {0}....
        /// </summary>
        internal static string MSG_ExtractingFiles {
            get {
                return ResourceManager.GetString("MSG_ExtractingFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fetching analysis configuration settings....
        /// </summary>
        internal static string MSG_FetchingAnalysisConfiguration {
            get {
                return ResourceManager.GetString("MSG_FetchingAnalysisConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fetching properties for project &apos;{0}&apos;....
        /// </summary>
        internal static string MSG_FetchingProjectProperties {
            get {
                return ResourceManager.GetString("MSG_FetchingProjectProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fetching quality profile for project &apos;{0}&apos;....
        /// </summary>
        internal static string MSG_FetchingQualityProfile {
            get {
                return ResourceManager.GetString("MSG_FetchingQualityProfile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fetching rules for quality profile &apos;{0}&apos;....
        /// </summary>
        internal static string MSG_FetchingRules {
            get {
                return ResourceManager.GetString("MSG_FetchingRules", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fetching server version....
        /// </summary>
        internal static string MSG_FetchingVersion {
            get {
                return ResourceManager.GetString("MSG_FetchingVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To analyze private projects make sure the scanner user has &apos;Browse&apos; permission..
        /// </summary>
        internal static string MSG_Forbidden_BrowsePermission {
            get {
                return ResourceManager.GetString("MSG_Forbidden_BrowsePermission", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generating rulesets....
        /// </summary>
        internal static string MSG_GeneratingRulesets {
            get {
                return ResourceManager.GetString("MSG_GeneratingRulesets", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Incremental PR analysis is available starting with SonarQube 9.9 or later..
        /// </summary>
        internal static string MSG_IncrementalPRAnalysisUpdateSonarQube {
            get {
                return ResourceManager.GetString("MSG_IncrementalPRAnalysisUpdateSonarQube", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Installed {0} to {1}.
        /// </summary>
        internal static string MSG_InstallTargets_Copy {
            get {
                return ResourceManager.GetString("MSG_InstallTargets_Copy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error occurred when installing the loader targets to &apos;{0}&apos;. &apos;{1}&apos;.
        /// </summary>
        internal static string MSG_InstallTargets_Error {
            get {
                return ResourceManager.GetString("MSG_InstallTargets_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file {0} was overwritten at {1}.
        /// </summary>
        internal static string MSG_InstallTargets_Overwrite {
            get {
                return ResourceManager.GetString("MSG_InstallTargets_Overwrite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file {0} is up to date at {1}.
        /// </summary>
        internal static string MSG_InstallTargets_UpToDate {
            get {
                return ResourceManager.GetString("MSG_InstallTargets_UpToDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Running the Scanner for MSBuild under Local System or Network Service account is not supported. Please, use a local or domain user account instead..
        /// </summary>
        internal static string MSG_InstallTargetsLocalSystem {
            get {
                return ResourceManager.GetString("MSG_InstallTargetsLocalSystem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cache data is empty. A full analysis will be performed..
        /// </summary>
        internal static string MSG_NoCacheData {
            get {
                return ResourceManager.GetString("MSG_NoCacheData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot determine project base path. Incremental PR analysis is disabled..
        /// </summary>
        internal static string MSG_NoPullRequestCacheBasePath {
            get {
                return ResourceManager.GetString("MSG_NoPullRequestCacheBasePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Skipping installing the ImportsBefore targets file..
        /// </summary>
        internal static string MSG_NotCopyingTargets {
            get {
                return ResourceManager.GetString("MSG_NotCopyingTargets", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Incremental PR analysis: Base branch parameter was not provided..
        /// </summary>
        internal static string MSG_Processing_PullRequest_NoBranch {
            get {
                return ResourceManager.GetString("MSG_Processing_PullRequest_NoBranch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Incremental PR analysis: CacheBaseUrl was not successfully retrieved..
        /// </summary>
        internal static string MSG_Processing_PullRequest_NoCacheBaseUrl {
            get {
                return ResourceManager.GetString("MSG_Processing_PullRequest_NoCacheBaseUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Incremental PR analysis: Organization parameter was not provided..
        /// </summary>
        internal static string MSG_Processing_PullRequest_NoOrganization {
            get {
                return ResourceManager.GetString("MSG_Processing_PullRequest_NoOrganization", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Incremental PR analysis: ProjectKey parameter was not provided..
        /// </summary>
        internal static string MSG_Processing_PullRequest_NoProjectKey {
            get {
                return ResourceManager.GetString("MSG_Processing_PullRequest_NoProjectKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Incremental PR analysis: Token parameter was not provided..
        /// </summary>
        internal static string MSG_Processing_PullRequest_NoToken {
            get {
                return ResourceManager.GetString("MSG_Processing_PullRequest_NoToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SonarCloud detected, skipping license check..
        /// </summary>
        internal static string MSG_SonarCloudDetected_SkipLicenseCheck {
            get {
                return ResourceManager.GetString("MSG_SonarCloudDetected_SkipLicenseCheck", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Incremental PR analysis: {0} files out of {1} are unchanged..
        /// </summary>
        internal static string MSG_UnchangedFilesStats {
            get {
                return ResourceManager.GetString("MSG_UnchangedFilesStats", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating build integration targets....
        /// </summary>
        internal static string MSG_UpdatingMSBuildTargets {
            get {
                return ResourceManager.GetString("MSG_UpdatingMSBuildTargets", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A Roslyn analyzer &quot;additional file&quot; named &quot;{0}&quot; already exists at {1}. The existing file will not be overwritten..
        /// </summary>
        internal static string RAP_AdditionalFileAlreadyExists {
            get {
                return ResourceManager.GetString("RAP_AdditionalFileAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Roslyn profile exporter returned an AdditionalFile that does not specify a file name. The AdditionalFile will be ignored..
        /// </summary>
        internal static string RAP_AdditionalFileNameMustBeSpecified {
            get {
                return ResourceManager.GetString("RAP_AdditionalFileNameMustBeSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No active rules for {0}.
        /// </summary>
        internal static string RAP_NoActiveRules {
            get {
                return ResourceManager.GetString("RAP_NoActiveRules", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No Roslyn analyzer plugins were specified so no Roslyn analyzers will be run for {0}.
        /// </summary>
        internal static string RAP_NoAnalyzerPluginsSpecified {
            get {
                return ResourceManager.GetString("RAP_NoAnalyzerPluginsSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No analyzer assemblies were specified for rule repository {0} in language {1}.
        /// </summary>
        internal static string RAP_NoAssembliesForRepo {
            get {
                return ResourceManager.GetString("RAP_NoAssembliesForRepo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No plugins found for language {0} with rulesets for Roslyn analyzer.
        /// </summary>
        internal static string RAP_NoPluginInstalled {
            get {
                return ResourceManager.GetString("RAP_NoPluginInstalled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not obtain a {0} profile for project &apos;{1}&apos;.
        /// </summary>
        internal static string RAP_NoProfileForProject {
            get {
                return ResourceManager.GetString("RAP_NoProfileForProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No quality profile defined for language {0} and project {1}.
        /// </summary>
        internal static string RAP_NoQualityProfile {
            get {
                return ResourceManager.GetString("RAP_NoQualityProfile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The exported profile does not contain a ruleset.
        /// </summary>
        internal static string RAP_ProfileDoesNotContainRuleset {
            get {
                return ResourceManager.GetString("RAP_ProfileDoesNotContainRuleset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Found profile export &apos;{0}&apos; for project &apos;{1}&apos;.
        /// </summary>
        internal static string RAP_ProfileExportFound {
            get {
                return ResourceManager.GetString("RAP_ProfileExportFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find profile export &apos;{0}&apos; for project &apos;{1}&apos;.
        /// </summary>
        internal static string RAP_ProfileExportNotFound {
            get {
                return ResourceManager.GetString("RAP_ProfileExportNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provisioning analyzer assemblies for {0}....
        /// </summary>
        internal static string RAP_ProvisioningAnalyzerAssemblies {
            get {
                return ResourceManager.GetString("RAP_ProvisioningAnalyzerAssemblies", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Writing Roslyn generated ruleset to {0}....
        /// </summary>
        internal static string RAP_UnpackingRuleset {
            get {
                return ResourceManager.GetString("RAP_UnpackingRuleset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Writing Roslyn analyzer additional file to {0}....
        /// </summary>
        internal static string RAP_WritingAdditionalFile {
            get {
                return ResourceManager.GetString("RAP_WritingAdditionalFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This version of the SonarScanner for MSBuild automatically deploys {0}, however a copy has been found in {1}. Please remove it if it is not intentional..
        /// </summary>
        internal static string WARN_ExistingGlobalTargets {
            get {
                return ResourceManager.GetString("WARN_ExistingGlobalTargets", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Incremental PR analysis: an error occurred while retrieving the cache entries! {0}.
        /// </summary>
        internal static string WARN_IncrementalPRCacheEntryRetrieval_Error {
            get {
                return ResourceManager.GetString("WARN_IncrementalPRCacheEntryRetrieval_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The version of SonarQube you are using is deprecated. Analyses will fail starting 6.0 release of the Scanner for .NET.
        /// </summary>
        internal static string WARN_SonarQubeDeprecated {
            get {
                return ResourceManager.GetString("WARN_SonarQubeDeprecated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property &apos;{0}&apos; defined in SonarQube is deprecated. Set the property &apos;sonar.msbuild.testProjectPattern&apos; in the scanner instead..
        /// </summary>
        internal static string WARN_TestProjectPattern {
            get {
                return ResourceManager.GetString("WARN_TestProjectPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to username cannot contain the &apos;:&apos; character due to basic authentication limitations.
        /// </summary>
        internal static string WCD_UserNameCannotContainColon {
            get {
                return ResourceManager.GetString("WCD_UserNameCannotContainColon", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to username and password should contain only ASCII characters due to basic authentication limitations.
        /// </summary>
        internal static string WCD_UserNameMustBeAscii {
            get {
                return ResourceManager.GetString("WCD_UserNameMustBeAscii", resourceCulture);
            }
        }
    }
}
