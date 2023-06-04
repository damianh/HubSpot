/*
 * Line Items
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
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
using OpenAPIDateConverter = HubSpot.Crm.LineItems.Client.OpenAPIDateConverter;

namespace HubSpot.Crm.LineItems.Model
{
    /// <summary>
    /// PreviousPage
    /// </summary>
    [DataContract(Name = "PreviousPage")]
    public partial class PreviousPage : IEquatable<PreviousPage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PreviousPage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PreviousPage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PreviousPage" /> class.
        /// </summary>
        /// <param name="before">before (required).</param>
        /// <param name="link">link.</param>
        public PreviousPage(string before = default(string), string link = default(string))
        {
            // to ensure "before" is required (not null)
            if (before == null)
            {
                throw new ArgumentNullException("before is a required property for PreviousPage and cannot be null");
            }
            this.Before = before;
            this.Link = link;
        }

        /// <summary>
        /// Gets or Sets Before
        /// </summary>
        [DataMember(Name = "before", IsRequired = true, EmitDefaultValue = true)]
        public string Before { get; set; }

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
            sb.Append("class PreviousPage {\n");
            sb.Append("  Before: ").Append(Before).Append("\n");
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
            return this.Equals(input as PreviousPage);
        }

        /// <summary>
        /// Returns true if PreviousPage instances are equal
        /// </summary>
        /// <param name="input">Instance of PreviousPage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PreviousPage input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Before == input.Before ||
                    (this.Before != null &&
                    this.Before.Equals(input.Before))
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
                if (this.Before != null)
                {
                    hashCode = (hashCode * 59) + this.Before.GetHashCode();
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
