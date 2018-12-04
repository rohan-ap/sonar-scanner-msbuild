﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SonarScanner.MSBuild {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SonarScanner.MSBuild.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to SonarScanner for MSBuild.
        /// </summary>
        internal static string AssemblyDescription {
            get {
                return ResourceManager.GetString("AssemblyDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to begin - perform pre-MSBuild analysis steps.
        /// </summary>
        internal static string CmdLine_ArgDescription_Begin {
            get {
                return ResourceManager.GetString("CmdLine_ArgDescription_Begin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to end - perform post-MSBuild/post-test steps.
        /// </summary>
        internal static string CmdLine_ArgDescription_End {
            get {
                return ResourceManager.GetString("CmdLine_ArgDescription_End", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid command line parameters. Please specify either &apos;begin&apos; or &apos;end&apos;, not both..
        /// </summary>
        internal static string ERROR_CmdLine_BothBeginAndEndSupplied {
            get {
                return ResourceManager.GetString("ERROR_CmdLine_BothBeginAndEndSupplied", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SonarQube analysis could not be completed because the analysis configuration file could not be found: {0}..
        /// </summary>
        internal static string ERROR_ConfigFileNotFound {
            get {
                return ResourceManager.GetString("ERROR_ConfigFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot copy a different version of the SonarScanner for MSBuild assemblies because they are used by a running MSBuild/.Net Core process. To resolve this problem try one of the following:
        ///- Analyze this project using the same version of SonarScanner for MSBuild
        ///- Build your project with the &apos;/nr:false&apos; switch.
        /// </summary>
        internal static string ERROR_DllLockedMultipleScanners {
            get {
                return ResourceManager.GetString("ERROR_DllLockedMultipleScanners", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} failed. Exit code: {1}.
        /// </summary>
        internal static string ERROR_ProcessingFailed {
            get {
                return ResourceManager.GetString("ERROR_ProcessingFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Temporary analysis directory (usually .sonarqube) doesn&apos;t exist. The &quot;begin&quot; step was probably not executed..
        /// </summary>
        internal static string ERROR_TempDirDoesNotExist {
            get {
                return ResourceManager.GetString("ERROR_TempDirDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Preparing working directories....
        /// </summary>
        internal static string MSG_PreparingDirectories {
            get {
                return ResourceManager.GetString("MSG_PreparingDirectories", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} started..
        /// </summary>
        internal static string MSG_ProcessingStarted {
            get {
                return ResourceManager.GetString("MSG_ProcessingStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} succeeded..
        /// </summary>
        internal static string MSG_ProcessingSucceeded {
            get {
                return ResourceManager.GetString("MSG_ProcessingSucceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using environment variable &apos;{0}&apos;, value &apos;{1}&apos;.
        /// </summary>
        internal static string MSG_UsingBuildEnvironmentVariable {
            get {
                return ResourceManager.GetString("MSG_UsingBuildEnvironmentVariable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using environment variables to determine the download directory....
        /// </summary>
        internal static string MSG_UsingEnvVarToGetDirectory {
            get {
                return ResourceManager.GetString("MSG_UsingEnvVarToGetDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Post-processing.
        /// </summary>
        internal static string PhaseLabel_PostProcessing {
            get {
                return ResourceManager.GetString("PhaseLabel_PostProcessing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pre-processing.
        /// </summary>
        internal static string PhaseLabel_PreProcessing {
            get {
                return ResourceManager.GetString("PhaseLabel_PreProcessing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please specify the command &apos;begin&apos; or &apos;end&apos; to indicate whether pre- or post-processing is required. These parameters will become mandatory in a later release..
        /// </summary>
        internal static string WARN_CmdLine_v09_Compat {
            get {
                return ResourceManager.GetString("WARN_CmdLine_v09_Compat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ------------------------------------------------------------------------
        ///This executable is deprecated and may be removed in next major version of the SonarScanner for MSBuild. Please use &apos;SonarScanner.MSBuild.exe&apos; instead.
        ///------------------------------------------------------------------------.
        /// </summary>
        internal static string WARN_Deprecated_Entry_Point {
            get {
                return ResourceManager.GetString("WARN_Deprecated_Entry_Point", resourceCulture);
            }
        }
    }
}
