﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RazorLight.src.Host {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal Resources() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RazorLight.src.Host.Resources", typeof(Resources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
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
        ///    Looks up a localized string similar to Value cannot be null or empty..
        /// </summary>
        public static string ArgumentCannotBeNullOrEmpy {
            get {
                return ResourceManager.GetString("ArgumentCannotBeNullOrEmpy", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The &apos;inherits&apos; keyword is not allowed when a &apos;{0}&apos; keyword is used..
        /// </summary>
        public static string MvcRazorCodeParser_CannotHaveModelAndInheritsKeyword {
            get {
                return ResourceManager.GetString("MvcRazorCodeParser_CannotHaveModelAndInheritsKeyword", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to A property name must be specified when using the &apos;{0}&apos; statement. Format for a &apos;{0}&apos; statement is &apos;@{0} &lt;Type Name&gt; &lt;Property Name&gt;&apos;..
        /// </summary>
        public static string MvcRazorCodeParser_InjectDirectivePropertyNameRequired {
            get {
                return ResourceManager.GetString("MvcRazorCodeParser_InjectDirectivePropertyNameRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The &apos;{0}&apos; keyword must be followed by a type name on the same line..
        /// </summary>
        public static string MvcRazorCodeParser_KeywordMustBeFollowedByTypeName {
            get {
                return ResourceManager.GetString("MvcRazorCodeParser_KeywordMustBeFollowedByTypeName", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Only one &apos;{0}&apos; statement is allowed in a file..
        /// </summary>
        public static string MvcRazorCodeParser_OnlyOneModelStatementIsAllowed {
            get {
                return ResourceManager.GetString("MvcRazorCodeParser_OnlyOneModelStatementIsAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Invalid tag helper property &apos;{0}.{1}&apos;. Dictionary values must not be of type &apos;{2}&apos;..
        /// </summary>
        public static string MvcRazorParser_InvalidPropertyType {
            get {
                return ResourceManager.GetString("MvcRazorParser_InvalidPropertyType", resourceCulture);
            }
        }
    }
}
