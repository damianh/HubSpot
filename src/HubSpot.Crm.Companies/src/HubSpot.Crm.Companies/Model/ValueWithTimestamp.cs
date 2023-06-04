/*
 * Companies
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
using OpenAPIDateConverter = HubSpot.Crm.Companies.Client.OpenAPIDateConverter;

namespace HubSpot.Crm.Companies.Model
{
    /// <summary>
    /// ValueWithTimestamp
    /// </summary>
    [DataContract(Name = "ValueWithTimestamp")]
    public partial class ValueWithTimestamp : IEquatable<ValueWithTimestamp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueWithTimestamp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ValueWithTimestamp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueWithTimestamp" /> class.
        /// </summary>
        /// <param name="value">value (required).</param>
        /// <param name="timestamp">timestamp (required).</param>
        /// <param name="sourceType">sourceType (required).</param>
        /// <param name="sourceId">sourceId.</param>
        /// <param name="sourceLabel">sourceLabel.</param>
        /// <param name="updatedByUserId">updatedByUserId.</param>
        public ValueWithTimestamp(string value = default(string), DateTime timestamp = default(DateTime), string sourceType = default(string), string sourceId = default(string), string sourceLabel = default(string), int updatedByUserId = default(int))
        {
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for ValueWithTimestamp and cannot be null");
            }
            this.Value = value;
            this.Timestamp = timestamp;
            // to ensure "sourceType" is required (not null)
            if (sourceType == null)
            {
                throw new ArgumentNullException("sourceType is a required property for ValueWithTimestamp and cannot be null");
            }
            this.SourceType = sourceType;
            this.SourceId = sourceId;
            this.SourceLabel = sourceLabel;
            this.UpdatedByUserId = updatedByUserId;
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = true)]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets SourceType
        /// </summary>
        [DataMember(Name = "sourceType", IsRequired = true, EmitDefaultValue = true)]
        public string SourceType { get; set; }

        /// <summary>
        /// Gets or Sets SourceId
        /// </summary>
        [DataMember(Name = "sourceId", EmitDefaultValue = false)]
        public string SourceId { get; set; }

        /// <summary>
        /// Gets or Sets SourceLabel
        /// </summary>
        [DataMember(Name = "sourceLabel", EmitDefaultValue = false)]
        public string SourceLabel { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedByUserId
        /// </summary>
        [DataMember(Name = "updatedByUserId", EmitDefaultValue = false)]
        public int UpdatedByUserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ValueWithTimestamp {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  SourceType: ").Append(SourceType).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  SourceLabel: ").Append(SourceLabel).Append("\n");
            sb.Append("  UpdatedByUserId: ").Append(UpdatedByUserId).Append("\n");
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
            return this.Equals(input as ValueWithTimestamp);
        }

        /// <summary>
        /// Returns true if ValueWithTimestamp instances are equal
        /// </summary>
        /// <param name="input">Instance of ValueWithTimestamp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValueWithTimestamp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.SourceType == input.SourceType ||
                    (this.SourceType != null &&
                    this.SourceType.Equals(input.SourceType))
                ) && 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
                ) && 
                (
                    this.SourceLabel == input.SourceLabel ||
                    (this.SourceLabel != null &&
                    this.SourceLabel.Equals(input.SourceLabel))
                ) && 
                (
                    this.UpdatedByUserId == input.UpdatedByUserId ||
                    this.UpdatedByUserId.Equals(input.UpdatedByUserId)
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
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                }
                if (this.SourceType != null)
                {
                    hashCode = (hashCode * 59) + this.SourceType.GetHashCode();
                }
                if (this.SourceId != null)
                {
                    hashCode = (hashCode * 59) + this.SourceId.GetHashCode();
                }
                if (this.SourceLabel != null)
                {
                    hashCode = (hashCode * 59) + this.SourceLabel.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UpdatedByUserId.GetHashCode();
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
