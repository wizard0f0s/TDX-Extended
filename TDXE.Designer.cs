﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TDX_Extended {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.2.0.0")]
    internal sealed partial class TDXE : global::System.Configuration.ApplicationSettingsBase {
        
        private static TDXE defaultInstance = ((TDXE)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new TDXE())));
        
        public static TDXE Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int addressBookSelection {
            get {
                return ((int)(this["addressBookSelection"]));
            }
            set {
                this["addressBookSelection"] = value;
            }
        }
    }
}
