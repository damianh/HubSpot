// <auto-generated>
//     This code was generated by Refitter.
// </auto-generated>

using Refit;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HubSpot.Crm.Calling
{
    public interface ICallingExtensionsAPI
    {

        /// <summary>
        /// Returns the calling extension settings configured for your app.
        /// </summary>
        [Get("/crm/v3/extensions/calling/{appId}/settings")]
        Task<SettingsResponse> GetById(int appId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Used to set the menu label, target iframe URL, and dimensions for your calling extension.
        /// </summary>
        [Post("/crm/v3/extensions/calling/{appId}/settings")]
        Task<SettingsResponse> Create(int appId, [Body] SettingsRequest body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes this calling extension. This will remove your service as an option for all connected accounts.
        /// </summary>
        [Delete("/crm/v3/extensions/calling/{appId}/settings")]
        Task Archive(int appId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates existing calling extension settings.
        /// </summary>
        [Patch("/crm/v3/extensions/calling/{appId}/settings")]
        Task<SettingsResponse> Update(int appId, [Body] SettingsPatchRequest body, CancellationToken cancellationToken = default);

    }


}


//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.19.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v10.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 612 // Disable "CS0612 '...' is obsolete"
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"
#pragma warning disable 3016 // Disable "CS3016 Arrays as attribute arguments is not CLS-compliant"
#pragma warning disable 8603 // Disable "CS8603 Possible null reference return"

namespace HubSpot.Crm.Calling
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.19.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v10.0.0.0))")]
    public partial class ErrorDetail
    {
        /// <summary>
        /// A human readable message describing the error along with remediation steps where appropriate
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("message")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Message { get; set; }

        /// <summary>
        /// The name of the field or parameter in which the error was found.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("in")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string In { get; set; }

        /// <summary>
        /// The status code associated with the error detail
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("code")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string Code { get; set; }

        /// <summary>
        /// A specific category that contains more specific detail about the error
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("subCategory")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string SubCategory { get; set; }

        /// <summary>
        /// Context about the error condition
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("context")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.ICollection<string>> Context { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [System.Text.Json.Serialization.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.19.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v10.0.0.0))")]
    public partial class Error
    {
        /// <summary>
        /// A human readable message describing the error along with remediation steps where appropriate
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("message")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Message { get; set; }

        /// <summary>
        /// A unique identifier for the request. Include this value with any error reports or support tickets
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("correlationId")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.Guid CorrelationId { get; set; }

        /// <summary>
        /// The error category
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("category")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Category { get; set; }

        /// <summary>
        /// A specific category that contains more specific detail about the error
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("subCategory")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string SubCategory { get; set; }

        /// <summary>
        /// further information about the error
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("errors")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public System.Collections.Generic.ICollection<ErrorDetail> Errors { get; set; }

        /// <summary>
        /// Context about the error condition
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("context")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.ICollection<string>> Context { get; set; }

        /// <summary>
        /// A map of link names to associated URIs containing documentation about the error or recommended remediation steps
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("links")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public System.Collections.Generic.IDictionary<string, string> Links { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [System.Text.Json.Serialization.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Settings update request
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.19.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v10.0.0.0))")]
    public partial class SettingsPatchRequest
    {
        /// <summary>
        /// The name of your calling service to display to users.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string Name { get; set; }

        /// <summary>
        /// The URL to your phone/calling UI, built with the [Calling SDK](#).
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("url")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string Url { get; set; }

        /// <summary>
        /// The target height of the iframe that will contain your phone/calling UI.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("height")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public int Height { get; set; }

        /// <summary>
        /// The target width of the iframe that will contain your phone/calling UI.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("width")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public int Width { get; set; }

        /// <summary>
        /// When true, your service will appear as an option under the *Call* action in contact records of connected accounts.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("isReady")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public bool IsReady { get; set; }

        /// <summary>
        /// When true, you are indicating that your service is compatible with engagement v2 service and can be used with custom objects.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("supportsCustomObjects")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public bool SupportsCustomObjects { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [System.Text.Json.Serialization.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Settings create request
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.19.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v10.0.0.0))")]
    public partial class SettingsRequest
    {
        /// <summary>
        /// The name of your calling service to display to users.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; }

        /// <summary>
        /// The URL to your phone/calling UI, built with the [Calling SDK](#).
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("url")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Url { get; set; }

        /// <summary>
        /// The target height of the iframe that will contain your phone/calling UI.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("height")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public int Height { get; set; }

        /// <summary>
        /// The target width of the iframe that will contain your phone/calling UI.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("width")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public int Width { get; set; }

        /// <summary>
        /// When true, your service will appear as an option under the *Call* action in contact records of connected accounts.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("isReady")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public bool IsReady { get; set; }

        /// <summary>
        /// When true, you are indicating that your service is compatible with engagement v2 service and can be used with custom objects.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("supportsCustomObjects")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public bool SupportsCustomObjects { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [System.Text.Json.Serialization.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Current settings state
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.19.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v10.0.0.0))")]
    public partial class SettingsResponse
    {
        /// <summary>
        /// The name of your calling service to display to users.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; }

        /// <summary>
        /// The URL to your phone/calling UI, built with the [Calling SDK](#).
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("url")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Url { get; set; }

        /// <summary>
        /// The target height of the iframe that will contain your phone/calling UI.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("height")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
        public int Height { get; set; }

        /// <summary>
        /// The target width of the iframe that will contain your phone/calling UI.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("width")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
        public int Width { get; set; }

        /// <summary>
        /// When true, your service will appear as an option under the *Call* action in contact records of connected accounts.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("isReady")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
        public bool IsReady { get; set; }

        /// <summary>
        /// When true, you are indicating that your service is compatible with engagement v2 service and can be used with custom objects.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("supportsCustomObjects")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
        public bool SupportsCustomObjects { get; set; }

        /// <summary>
        /// When this calling extension was created.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("createdAt")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The last time the settings for this calling extension were modified.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("updatedAt")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.Never)]   
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset UpdatedAt { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [System.Text.Json.Serialization.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }


}

#pragma warning restore  108
#pragma warning restore  114
#pragma warning restore  472
#pragma warning restore  612
#pragma warning restore 1573
#pragma warning restore 1591
#pragma warning restore 8073
#pragma warning restore 3016
#pragma warning restore 8603
