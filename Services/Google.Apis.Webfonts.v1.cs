//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5466
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.Webfonts.v1.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class Webfont {
        
        private string _family;
        
        private string _kind;
        
        private string _subsets;
        
        private string _variants;
        
        /// <summary>The name of the font.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("family")]
        public virtual string Family {
            get {
                return this._family;
            }
            set {
                this._family = value;
            }
        }
        
        /// <summary>This kind represents a webfont object in the webfonts service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this._kind;
            }
            set {
                this._kind = value;
            }
        }
        
        /// <summary>The scripts supported by the font.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subsets")]
        public virtual string Subsets {
            get {
                return this._subsets;
            }
            set {
                this._subsets = value;
            }
        }
        
        /// <summary>The available variants for the font.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variants")]
        public virtual string Variants {
            get {
                return this._variants;
            }
            set {
                this._variants = value;
            }
        }
    }
    
    public class WebfontList : Google.Apis.Requests.IDirectResponseSchema {
        
        private System.Collections.Generic.IList<Webfont> _items;
        
        private string _kind;
        
        private string _ETag;
        
        /// <summary>The list of fonts currently served by the Google Fonts API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Webfont> Items {
            get {
                return this._items;
            }
            set {
                this._items = value;
            }
        }
        
        /// <summary>This kind represents a list of webfont objects in the webfonts service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this._kind;
            }
            set {
                this._kind = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this._ETag;
            }
            set {
                this._ETag = value;
            }
        }
    }
}
namespace Google.Apis.Webfonts.v1 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public partial class WebfontsService : Google.Apis.Discovery.BaseClientService {
        
        public const string Version = "v1";
        
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private System.Collections.Generic.IDictionary<string, Google.Apis.Discovery.IParameter> _serviceParameters;
        
        public WebfontsService(Google.Apis.Discovery.BaseClientService.Initializer initializer) : 
                base(initializer) {
            this._webfonts = new WebfontsResource(this, Authenticator);
            this.InitParameters();
        }
        
        public WebfontsService() : 
                this(new Google.Apis.Discovery.BaseClientService.Initializer()) {
        }
        
        public override System.Collections.Generic.IList<string> Features {
            get {
                return new string[0];
            }
        }
        
        public override string Name {
            get {
                return "webfonts";
            }
        }
        
        public override string BaseUri {
            get {
                return "https://www.googleapis.com/webfonts/v1/";
            }
        }
        
        public override System.Collections.Generic.IDictionary<string, Google.Apis.Discovery.IParameter> ServiceParameters {
            get {
                return this._serviceParameters;
            }
        }
        
        public override Google.Apis.Requests.IRequest CreateRequest(Google.Apis.Requests.IClientServiceRequest serviceRequest) {
            Google.Apis.Requests.IRequest request = Google.Apis.Requests.Request.CreateRequest(this, serviceRequest);
            if ((string.IsNullOrEmpty(ApiKey) == false)) {
                request = request.WithKey(this.ApiKey);
            }
            return request.WithAuthentication(Authenticator);
        }
        
        private void InitParameters() {
            System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter> parameters = new System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter>();
            parameters.Add("alt", Google.Apis.Util.Utilities.CreateRuntimeParameter("alt", false, "query", "json", null, new string[] {
                            "json"}));
            parameters.Add("fields", Google.Apis.Util.Utilities.CreateRuntimeParameter("fields", false, "query", null, null, new string[0]));
            parameters.Add("key", Google.Apis.Util.Utilities.CreateRuntimeParameter("key", false, "query", null, null, new string[0]));
            parameters.Add("oauth_token", Google.Apis.Util.Utilities.CreateRuntimeParameter("oauth_token", false, "query", null, null, new string[0]));
            parameters.Add("prettyPrint", Google.Apis.Util.Utilities.CreateRuntimeParameter("prettyPrint", false, "query", "true", null, new string[0]));
            parameters.Add("quotaUser", Google.Apis.Util.Utilities.CreateRuntimeParameter("quotaUser", false, "query", null, null, new string[0]));
            parameters.Add("userIp", Google.Apis.Util.Utilities.CreateRuntimeParameter("userIp", false, "query", null, null, new string[0]));
            this._serviceParameters = new Google.Apis.Util.ReadOnlyDictionary<string, Google.Apis.Discovery.IParameter>(parameters);
        }
    }
    
    public class WebfontsResource {
        
        private WebfontsService service;
        
        private Google.Apis.Authentication.IAuthenticator authenticator;
        
        private const string Resource = "webfonts";
        
        public WebfontsResource(WebfontsService service, Google.Apis.Authentication.IAuthenticator authenticator) {
            this.service = service;
            this.authenticator = authenticator;
        }
        
        /// <summary>Retrieves the list of fonts currently served by the Google Web Fonts Developer API</summary>
        public virtual ListRequest List() {
            return new ListRequest(service);
        }
        
        /// <summary>Enables sorting of the list</summary>
        [System.ComponentModel.TypeConverterAttribute(typeof(Google.Apis.Util.EnumStringValueTypeConverter))]
        public enum Sort {
            
            /// <summary>Sort alphabetically</summary>
            [Google.Apis.Util.StringValueAttribute("alpha")]
            Alpha,
            
            /// <summary>Sort by date added</summary>
            [Google.Apis.Util.StringValueAttribute("date")]
            Date,
            
            /// <summary>Sort by popularity</summary>
            [Google.Apis.Util.StringValueAttribute("popularity")]
            Popularity,
            
            /// <summary>Sort by number of styles</summary>
            [Google.Apis.Util.StringValueAttribute("style")]
            Style,
            
            /// <summary>Sort by trending</summary>
            [Google.Apis.Util.StringValueAttribute("trending")]
            Trending,
        }
        
        public class ListRequest : Google.Apis.Requests.ClientServiceRequest<Google.Apis.Webfonts.v1.Data.WebfontList> {
            
            private string _alt;
            
            private string _fields;
            
            private string _oauth_token;
            
            private System.Nullable<bool> _prettyPrint;
            
            private string _quotaUser;
            
            private string _userIp;
            
            private System.Nullable<Sort> _sort;
            
            public ListRequest(Google.Apis.Discovery.IClientService service) : 
                    base(service) {
                this.InitParameters();
            }
            
            /// <summary>Data format for the response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Alt {
                get {
                    return this._alt;
                }
                set {
                    this._alt = value;
                }
            }
            
            /// <summary>Selector specifying which fields to include in a partial response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Fields {
                get {
                    return this._fields;
                }
                set {
                    this._fields = value;
                }
            }
            
            /// <summary>OAuth 2.0 token for the current user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Oauth_token {
                get {
                    return this._oauth_token;
                }
                set {
                    this._oauth_token = value;
                }
            }
            
            /// <summary>Returns response with indentations and line breaks.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> PrettyPrint {
                get {
                    return this._prettyPrint;
                }
                set {
                    this._prettyPrint = value;
                }
            }
            
            /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string QuotaUser {
                get {
                    return this._quotaUser;
                }
                set {
                    this._quotaUser = value;
                }
            }
            
            /// <summary>IP address of the site where the request originates. Use this if you want to enforce per-user limits.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserIp {
                get {
                    return this._userIp;
                }
                set {
                    this._userIp = value;
                }
            }
            
            /// <summary>Enables sorting of the list</summary>
            [Google.Apis.Util.RequestParameterAttribute("sort", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<Sort> Sort {
                get {
                    return this._sort;
                }
                set {
                    this._sort = value;
                }
            }
            
            public override string ResourcePath {
                get {
                    return "webfonts";
                }
            }
            
            public override string MethodName {
                get {
                    return "list";
                }
            }
            
            public override string HttpMethod {
                get {
                    return "GET";
                }
            }
            
            public override string RestPath {
                get {
                    return "webfonts";
                }
            }
            
            private void InitParameters() {
                System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter> parameters = new System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter>();
                parameters.Add("sort", Google.Apis.Util.Utilities.CreateRuntimeParameter("sort", false, "query", null, null, new string[] {
                                "alpha",
                                "date",
                                "popularity",
                                "style",
                                "trending"}));
                this._requestParameters = new Google.Apis.Util.ReadOnlyDictionary<string, Google.Apis.Discovery.IParameter>(parameters);
            }
        }
    }
    
    public partial class WebfontsService {
        
        private const string Resource = "";
        
        private WebfontsResource _webfonts;
        
        private Google.Apis.Discovery.IClientService service {
            get {
                return this;
            }
        }
        
        public virtual WebfontsResource Webfonts {
            get {
                return this._webfonts;
            }
        }
    }
}
