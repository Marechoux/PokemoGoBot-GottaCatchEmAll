﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PokemonGo.RocketAPI.Console {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class UserSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static UserSettings defaultInstance = ((UserSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new UserSettings())));
        
        public static UserSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public double DefaultAltitude {
            get {
                return ((double)(this["DefaultAltitude"]));
            }
            set {
                this["DefaultAltitude"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("99")]
        public float TransferPokemonKeepAboveIVPercentage {
            get {
                return ((float)(this["TransferPokemonKeepAboveIVPercentage"]));
            }
            set {
                this["TransferPokemonKeepAboveIVPercentage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2000")]
        public int TransferPokemonKeepAboveCP {
            get {
                return ((int)(this["TransferPokemonKeepAboveCP"]));
            }
            set {
                this["TransferPokemonKeepAboveCP"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("150")]
        public double WalkingSpeedInKilometerPerHour {
            get {
                return ((double)(this["WalkingSpeedInKilometerPerHour"]));
            }
            set {
                this["WalkingSpeedInKilometerPerHour"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("40.758838")]
        public double DefaultLatitude {
            get {
                return ((double)(this["DefaultLatitude"]));
            }
            set {
                this["DefaultLatitude"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-73.98527")]
        public double DefaultLongitude {
            get {
                return ((double)(this["DefaultLongitude"]));
            }
            set {
                this["DefaultLongitude"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UsePokemonToNotCatchList {
            get {
                return ((bool)(this["UsePokemonToNotCatchList"]));
            }
            set {
                this["UsePokemonToNotCatchList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Google")]
        public string AuthType {
            get {
                return ((string)(this["AuthType"]));
            }
            set {
                this["AuthType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("JizzMaster2000")]
        public string PtcUsername {
            get {
                return ((string)(this["PtcUsername"]));
            }
            set {
                this["PtcUsername"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("MUgzN8Kb")]
        public string PtcPassword {
            get {
                return ((string)(this["PtcPassword"]));
            }
            set {
                this["PtcPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool PrioritizeIVOverCP {
            get {
                return ((bool)(this["PrioritizeIVOverCP"]));
            }
            set {
                this["PrioritizeIVOverCP"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1000")]
        public int MaxTravelDistanceInMeters {
            get {
                return ((int)(this["MaxTravelDistanceInMeters"]));
            }
            set {
                this["MaxTravelDistanceInMeters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseGPXPathing {
            get {
                return ((bool)(this["UseGPXPathing"]));
            }
            set {
                this["UseGPXPathing"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("central_park_loop.gpx")]
        public string GPXFile {
            get {
                return ((string)(this["GPXFile"]));
            }
            set {
                this["GPXFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseLuckyEggs {
            get {
                return ((bool)(this["UseLuckyEggs"]));
            }
            set {
                this["UseLuckyEggs"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool NotTransferPokemonsThatCanEvolve {
            get {
                return ((bool)(this["NotTransferPokemonsThatCanEvolve"]));
            }
            set {
                this["NotTransferPokemonsThatCanEvolve"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EvolveOnlyPokemonAboveIV {
            get {
                return ((bool)(this["EvolveOnlyPokemonAboveIV"]));
            }
            set {
                this["EvolveOnlyPokemonAboveIV"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EvolvePokemon {
            get {
                return ((bool)(this["EvolvePokemon"]));
            }
            set {
                this["EvolvePokemon"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("95")]
        public float EvolveOnlyPokemonAboveIVValue {
            get {
                return ((float)(this["EvolveOnlyPokemonAboveIVValue"]));
            }
            set {
                this["EvolveOnlyPokemonAboveIVValue"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool TransferPokemon {
            get {
                return ((bool)(this["TransferPokemon"]));
            }
            set {
                this["TransferPokemon"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int TransferPokemonKeepDuplicateAmount {
            get {
                return ((int)(this["TransferPokemonKeepDuplicateAmount"]));
            }
            set {
                this["TransferPokemonKeepDuplicateAmount"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseTransferPokemonKeepAboveCP {
            get {
                return ((bool)(this["UseTransferPokemonKeepAboveCP"]));
            }
            set {
                this["UseTransferPokemonKeepAboveCP"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseTransferPokemonKeepAboveIV {
            get {
                return ((bool)(this["UseTransferPokemonKeepAboveIV"]));
            }
            set {
                this["UseTransferPokemonKeepAboveIV"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UsePokemonToNotTransferList {
            get {
                return ((bool)(this["UsePokemonToNotTransferList"]));
            }
            set {
                this["UsePokemonToNotTransferList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseIncense {
            get {
                return ((bool)(this["UseIncense"]));
            }
            set {
                this["UseIncense"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("andreas.spegel@gmail.com")]
        public string GoogleEmail {
            get {
                return ((string)(this["GoogleEmail"]));
            }
            set {
                this["GoogleEmail"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Spegeli0311")]
        public string GooglePassword {
            get {
                return ((string)(this["GooglePassword"]));
            }
            set {
                this["GooglePassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool GPXIgnorePokemon {
            get {
                return ((bool)(this["GPXIgnorePokemon"]));
            }
            set {
                this["GPXIgnorePokemon"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool GPXIgnorePokestops {
            get {
                return ((bool)(this["GPXIgnorePokestops"]));
            }
            set {
                this["GPXIgnorePokestops"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool DebugMode {
            get {
                return ((bool)(this["DebugMode"]));
            }
            set {
                this["DebugMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("200")]
        public int EvolveKeepCandiesValue {
            get {
                return ((int)(this["EvolveKeepCandiesValue"]));
            }
            set {
                this["EvolveKeepCandiesValue"] = value;
            }
        }
    }
}
