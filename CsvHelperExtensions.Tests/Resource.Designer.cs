//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CsvHelperExtensions.Tests {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CsvHelperExtensions.Tests.Resource", typeof(Resource).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PIZ,LastFractionDate,BaselineGrade,BaselineEndpoint,SixWeeksAfterRTGrade,SixWeeksAfterRTEndpoint,DateOfEvent
        ///1,05.07.2013,Grade I,Urinary frequency,Grade II,Cystitis noninfective,19.07.2013
        ///2,27.03.2013,,,Grade II,Urinary urgency,10.04.2013
        ///3,27.03.2013,,,Grade I,Hematuria,10.04.2013
        ///4,01.12.2015,Grade I,Urinary frequency,Grade II,Urinary frequency,15.12.2015
        ///5,01.03.2013,,,Grade I,Urinary frequency,15.03.2013
        ///6,12.02.2013,,,Grade II,Urinary urgency,26.02.2013
        ///7,30.01.2013,,,Grade I,Cystitis noninfec [rest of string was truncated]&quot;;.
        /// </summary>
        public static string CTC_Prostata_GU_Early_v1 {
            get {
                return ResourceManager.GetString("CTC_Prostata_GU_Early_v1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Patient Id,Study,FollowUpTime(Months),Fractions,TotalPhysicalDose(Gy),Local Control Probability
        ///1,high dose,12,1,30,0.88
        ///2,high dose,13,1,22,0.87
        ///3,high dose,14,1,28,0.86
        ///4,high dose,18,1,36,0.95
        ///5,high dose,25,1,24,0.78
        ///6,low dose,11,5,10,0.66
        ///7,low dose,7,6,12,0.67
        ///8,low dose,6,8,16,0.69.
        /// </summary>
        public static string testdata_multi_records {
            get {
                return ResourceManager.GetString("testdata_multi_records", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Patient Id;Study;FollowUpTime(Months);Fractions;TotalPhysicalDose(Gy);Local Control Probability
        ///1;high dose;12;1;30;0.88
        ///.
        /// </summary>
        public static string testdata_semicolon {
            get {
                return ResourceManager.GetString("testdata_semicolon", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Patient Id,Study,FollowUpTime(Months),Fractions,TotalPhysicalDose(Gy),Local Control Probability
        ///1,high dose,12,1,30,0.88
        ///.
        /// </summary>
        public static string treatment_data {
            get {
                return ResourceManager.GetString("treatment_data", resourceCulture);
            }
        }
    }
}
