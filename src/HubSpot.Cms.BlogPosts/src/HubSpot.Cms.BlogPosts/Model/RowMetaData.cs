/*
 * Blog Post endpoints
 *
 * Use these endpoints for interacting with Blog Posts, Blog Authors, and Blog Tags
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
using OpenAPIDateConverter = HubSpot.Cms.BlogPosts.Client.OpenAPIDateConverter;

namespace HubSpot.Cms.BlogPosts.Model
{
    /// <summary>
    /// RowMetaData
    /// </summary>
    [DataContract(Name = "RowMetaData")]
    public partial class RowMetaData : IEquatable<RowMetaData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RowMetaData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RowMetaData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RowMetaData" /> class.
        /// </summary>
        /// <param name="styles">styles (required).</param>
        /// <param name="cssClass">cssClass (required).</param>
        public RowMetaData(Styles styles = default(Styles), string cssClass = default(string))
        {
            // to ensure "styles" is required (not null)
            if (styles == null)
            {
                throw new ArgumentNullException("styles is a required property for RowMetaData and cannot be null");
            }
            this.Styles = styles;
            // to ensure "cssClass" is required (not null)
            if (cssClass == null)
            {
                throw new ArgumentNullException("cssClass is a required property for RowMetaData and cannot be null");
            }
            this.CssClass = cssClass;
        }

        /// <summary>
        /// Gets or Sets Styles
        /// </summary>
        [DataMember(Name = "styles", IsRequired = true, EmitDefaultValue = true)]
        public Styles Styles { get; set; }

        /// <summary>
        /// Gets or Sets CssClass
        /// </summary>
        [DataMember(Name = "cssClass", IsRequired = true, EmitDefaultValue = true)]
        public string CssClass { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RowMetaData {\n");
            sb.Append("  Styles: ").Append(Styles).Append("\n");
            sb.Append("  CssClass: ").Append(CssClass).Append("\n");
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
            return this.Equals(input as RowMetaData);
        }

        /// <summary>
        /// Returns true if RowMetaData instances are equal
        /// </summary>
        /// <param name="input">Instance of RowMetaData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RowMetaData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Styles == input.Styles ||
                    (this.Styles != null &&
                    this.Styles.Equals(input.Styles))
                ) && 
                (
                    this.CssClass == input.CssClass ||
                    (this.CssClass != null &&
                    this.CssClass.Equals(input.CssClass))
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
                if (this.Styles != null)
                {
                    hashCode = (hashCode * 59) + this.Styles.GetHashCode();
                }
                if (this.CssClass != null)
                {
                    hashCode = (hashCode * 59) + this.CssClass.GetHashCode();
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
