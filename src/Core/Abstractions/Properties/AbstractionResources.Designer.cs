﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotChocolate.Properties {
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
    internal class AbstractionResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AbstractionResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HotChocolate.Properties.AbstractionResources", typeof(AbstractionResources).Assembly);
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
        ///   Looks up a localized string similar to The DataLoader key mustn&apos;t null or empty..
        /// </summary>
        internal static string DataLoader_KeyMustNotBeNullOrEmpty {
            get {
                return ResourceManager.GetString("DataLoader_KeyMustNotBeNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The directive argument name be mustn&apos;t null or empty..
        /// </summary>
        internal static string DirectiveArgument_NameMustNotBeNullOrempty {
            get {
                return ResourceManager.GetString("DirectiveArgument_NameMustNotBeNullOrempty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified name mustn&apos;t be empty..
        /// </summary>
        internal static string Name_MustNotBeEmpty {
            get {
                return ResourceManager.GetString("Name_MustNotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must specify a query before creating a query request..
        /// </summary>
        internal static string QueryRequestBuilder_QueryIsNull {
            get {
                return ResourceManager.GetString("QueryRequestBuilder_QueryIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The query mustn&apos;t be null or empty..
        /// </summary>
        internal static string QueryRequestBuilder_QueryIsNullOrEmpty {
            get {
                return ResourceManager.GetString("QueryRequestBuilder_QueryIsNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The state key mustn&apos;t null or empty..
        /// </summary>
        internal static string State_KeyMustNotBeNullOrEmpty {
            get {
                return ResourceManager.GetString("State_KeyMustNotBeNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to `{0}` is not a valid GraphQL type name..
        /// </summary>
        internal static string Type_NameIsNotValid {
            get {
                return ResourceManager.GetString("Type_NameIsNotValid", resourceCulture);
            }
        }
    }
}
