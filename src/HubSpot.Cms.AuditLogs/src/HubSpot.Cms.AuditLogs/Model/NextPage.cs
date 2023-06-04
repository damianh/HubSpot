/*
 * CMS Audit Logs
 *
 * Use this endpoint to query audit logs of CMS changes that occurred on your HubSpot account.
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
using OpenAPIDateConverter = HubSpot.Cms.AuditLogs.Client.OpenAPIDateConverter;

namespace HubSpot.Cms.AuditLogs.Model
{
    /// <summary>
    /// NextPage
    /// </summary>
    [DataContract(Name = "NextPage")]
    public partial class NextPage : IEquatable<NextPage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NextPage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NextPage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NextPage" /> class.
        /// </summary>
        /// <param name="after">after (required).</param>
        /// <param name="link">link.</param>
        public NextPage(string after = default(string), string link = default(string))
        {
            // to ensure "after" is required (not null)
            if (after == null)
            {
                throw new ArgumentNullException("after is a required property for NextPage and cannot be null");
            }
            this.After = after;
            this.Link = link;
        }

        /// <summary>
        /// Gets or Sets After
        /// </summary>
        [DataMember(Name = "after", IsRequired = true, EmitDefaultValue = true)]
        public string After { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        public string Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NextPage {\n");
            sb.Append("  After: ").Append(After).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
            return this.Equals(input as NextPage);
        }

        /// <summary>
        /// Returns true if NextPage instances are equal
        /// </summary>
        /// <param name="input">Instance of NextPage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NextPage input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.After == input.After ||
                    (this.After != null &&
                    this.After.Equals(input.After))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
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
                if (this.After != null)
                {
                    hashCode = (hashCode * 59) + this.After.GetHashCode();
                }
                if (this.Link != null)
                {
                    hashCode = (hashCode * 59) + this.Link.GetHashCode();
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
