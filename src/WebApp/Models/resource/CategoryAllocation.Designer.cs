﻿namespace WebApp.Models.resource {
  using System;
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  public class CategoryAllocation {
        private static global::System.Resources.ResourceManager resourceMan;
        private static global::System.Globalization.CultureInfo resourceCulture;
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CategoryAllocation() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WebApp.Models.resource.CategoryAllocation", typeof(CategoryAllocation).Assembly);
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
    public static string Id {
            get {
                return ResourceManager.GetString("Id", resourceCulture);
            }
    }
    public static string CategoryId {
            get {
                return ResourceManager.GetString("CategoryId", resourceCulture);
            }
    }
    public static string CategoryName {
            get {
                return ResourceManager.GetString("CategoryName", resourceCulture);
            }
    }
    public static string CompanyId {
            get {
                return ResourceManager.GetString("CompanyId", resourceCulture);
            }
    }
    public static string CompanyName {
            get {
                return ResourceManager.GetString("CompanyName", resourceCulture);
            }
    }
    public static string Remark {
            get {
                return ResourceManager.GetString("Remark", resourceCulture);
            }
    }
    public static string IsDisabled {
            get {
                return ResourceManager.GetString("IsDisabled", resourceCulture);
            }
    }
 }
}