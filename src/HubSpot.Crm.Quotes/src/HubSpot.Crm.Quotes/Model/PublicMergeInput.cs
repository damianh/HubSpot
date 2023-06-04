/*
 * Quotes
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
using OpenAPIDateConverter = HubSpot.Crm.Quotes.Client.OpenAPIDateConverter;

namespace HubSpot.Crm.Quotes.Model
{
    /// <summary>
    /// PublicMergeInput
    /// </summary>
    [DataContract(Name = "PublicMergeInput")]
    public partial class PublicMergeInput : IEquatable<PublicMergeInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicMergeInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PublicMergeInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicMergeInput" /> class.
        /// </summary>
        /// <param name="primaryObjectId">primaryObjectId (required).</param>
        /// <param name="objectIdToMerge">objectIdToMerge (required).</param>
        public PublicMergeInput(string primaryObjectId = default(string), string objectIdToMerge = default(string))
        {
            // to ensure "primaryObjectId" is required (not null)
            if (primaryObjectId == null)
            {
                throw new ArgumentNullException("primaryObjectId is a required property for PublicMergeInput and cannot be null");
            }
            this.PrimaryObjectId = primaryObjectId;
            // to ensure "objectIdToMerge" is required (not null)
            if (objectIdToMerge == null)
            {
                throw new ArgumentNullException("objectIdToMerge is a required property for PublicMergeInput and cannot be null");
            }
            this.ObjectIdToMerge = objectIdToMerge;
        }

        /// <summary>
        /// Gets or Sets PrimaryObjectId
        /// </summary>
        [DataMember(Name = "primaryObjectId", IsRequired = true, EmitDefaultValue = true)]
        public string PrimaryObjectId { get; set; }

        /// <summary>
        /// Gets or Sets ObjectIdToMerge
        /// </summary>
        [DataMember(Name = "objectIdToMerge", IsRequired = true, EmitDefaultValue = true)]
        public string ObjectIdToMerge { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PublicMergeInput {\n");
            sb.Append("  PrimaryObjectId: ").Append(PrimaryObjectId).Append("\n");
            sb.Append("  ObjectIdToMerge: ").Append(ObjectIdToMerge).Append("\n");
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
            return this.Equals(input as PublicMergeInput);
        }

        /// <summary>
        /// Returns true if PublicMergeInput instances are equal
        /// </summary>
        /// <param name="input">Instance of PublicMergeInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublicMergeInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PrimaryObjectId == input.PrimaryObjectId ||
                    (this.PrimaryObjectId != null &&
                    this.PrimaryObjectId.Equals(input.PrimaryObjectId))
                ) && 
                (
                    this.ObjectIdToMerge == input.ObjectIdToMerge ||
                    (this.ObjectIdToMerge != null &&
                    this.ObjectIdToMerge.Equals(input.ObjectIdToMerge))
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
                if (this.PrimaryObjectId != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryObjectId.GetHashCode();
                }
                if (this.ObjectIdToMerge != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectIdToMerge.GetHashCode();
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
