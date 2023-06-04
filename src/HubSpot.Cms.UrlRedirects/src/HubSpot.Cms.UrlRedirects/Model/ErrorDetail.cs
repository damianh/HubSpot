/*
 * URL redirects
 *
 * URL redirect operations
 *
 * The version of the OpenAPI document: v3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = HubSpot.Cms.UrlRedirects.Client.OpenAPIDateConverter;

namespace HubSpot.Cms.UrlRedirects.Model
{
    /// <summary>
    /// ErrorDetail
    /// </summary>
    [DataContract(Name = "ErrorDetail")]
    public partial class ErrorDetail : IEquatable<ErrorDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ErrorDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorDetail" /> class.
        /// </summary>
        /// <param name="message">A human readable message describing the error along with remediation steps where appropriate (required).</param>
        /// <param name="_in">The name of the field or parameter in which the error was found..</param>
        /// <param name="code">The status code associated with the error detail.</param>
        /// <param name="subCategory">A specific category that contains more specific detail about the error.</param>
        /// <param name="context">Context about the error condition.</param>
        public ErrorDetail(string message = default(string), string _in = default(string), string code = default(string), string subCategory = default(string), Dictionary<string, List<string>> context = default(Dictionary<string, List<string>>))
        {
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for ErrorDetail and cannot be null");
            }
            this.Message = message;
            this.In = _in;
            this.Code = code;
            this.SubCategory = subCategory;
            this.Context = context;
        }

        /// <summary>
        /// A human readable message describing the error along with remediation steps where appropriate
        /// </summary>
        /// <value>A human readable message describing the error along with remediation steps where appropriate</value>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// The name of the field or parameter in which the error was found.
        /// </summary>
        /// <value>The name of the field or parameter in which the error was found.</value>
        [DataMember(Name = "in", EmitDefaultValue = false)]
        public string In { get; set; }

        /// <summary>
        /// The status code associated with the error detail
        /// </summary>
        /// <value>The status code associated with the error detail</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// A specific category that contains more specific detail about the error
        /// </summary>
        /// <value>A specific category that contains more specific detail about the error</value>
        [DataMember(Name = "subCategory", EmitDefaultValue = false)]
        public string SubCategory { get; set; }

        /// <summary>
        /// Context about the error condition
        /// </summary>
        /// <value>Context about the error condition</value>
        [DataMember(Name = "context", EmitDefaultValue = false)]
        public Dictionary<string, List<string>> Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ErrorDetail {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  In: ").Append(In).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  SubCategory: ").Append(SubCategory).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ErrorDetail);
        }

        /// <summary>
        /// Returns true if ErrorDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.In == input.In ||
                    (this.In != null &&
                    this.In.Equals(input.In))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.SubCategory == input.SubCategory ||
                    (this.SubCategory != null &&
                    this.SubCategory.Equals(input.SubCategory))
                ) && 
                (
                    this.Context == input.Context ||
                    this.Context != null &&
                    input.Context != null &&
                    this.Context.SequenceEqual(input.Context)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.In != null)
                {
                    hashCode = (hashCode * 59) + this.In.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.SubCategory != null)
                {
                    hashCode = (hashCode * 59) + this.SubCategory.GetHashCode();
                }
                if (this.Context != null)
                {
                    hashCode = (hashCode * 59) + this.Context.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
