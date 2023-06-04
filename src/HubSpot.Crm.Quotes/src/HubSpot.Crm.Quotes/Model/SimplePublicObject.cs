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
    /// SimplePublicObject
    /// </summary>
    [DataContract(Name = "SimplePublicObject")]
    public partial class SimplePublicObject : IEquatable<SimplePublicObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimplePublicObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SimplePublicObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SimplePublicObject" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="properties">properties (required).</param>
        /// <param name="propertiesWithHistory">propertiesWithHistory.</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        /// <param name="archived">archived.</param>
        /// <param name="archivedAt">archivedAt.</param>
        public SimplePublicObject(string id = default(string), Dictionary<string, string> properties = default(Dictionary<string, string>), Dictionary<string, List<ValueWithTimestamp>> propertiesWithHistory = default(Dictionary<string, List<ValueWithTimestamp>>), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), bool archived = default(bool), DateTime archivedAt = default(DateTime))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for SimplePublicObject and cannot be null");
            }
            this.Id = id;
            // to ensure "properties" is required (not null)
            if (properties == null)
            {
                throw new ArgumentNullException("properties is a required property for SimplePublicObject and cannot be null");
            }
            this.Properties = properties;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.PropertiesWithHistory = propertiesWithHistory;
            this.Archived = archived;
            this.ArchivedAt = archivedAt;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "properties", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Gets or Sets PropertiesWithHistory
        /// </summary>
        [DataMember(Name = "propertiesWithHistory", EmitDefaultValue = false)]
        public Dictionary<string, List<ValueWithTimestamp>> PropertiesWithHistory { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Archived
        /// </summary>
        [DataMember(Name = "archived", EmitDefaultValue = true)]
        public bool Archived { get; set; }

        /// <summary>
        /// Gets or Sets ArchivedAt
        /// </summary>
        [DataMember(Name = "archivedAt", EmitDefaultValue = false)]
        public DateTime ArchivedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SimplePublicObject {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  PropertiesWithHistory: ").Append(PropertiesWithHistory).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Archived: ").Append(Archived).Append("\n");
            sb.Append("  ArchivedAt: ").Append(ArchivedAt).Append("\n");
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
            return this.Equals(input as SimplePublicObject);
        }

        /// <summary>
        /// Returns true if SimplePublicObject instances are equal
        /// </summary>
        /// <param name="input">Instance of SimplePublicObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimplePublicObject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.PropertiesWithHistory == input.PropertiesWithHistory ||
                    this.PropertiesWithHistory != null &&
                    input.PropertiesWithHistory != null &&
                    this.PropertiesWithHistory.SequenceEqual(input.PropertiesWithHistory)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Archived == input.Archived ||
                    this.Archived.Equals(input.Archived)
                ) && 
                (
                    this.ArchivedAt == input.ArchivedAt ||
                    (this.ArchivedAt != null &&
                    this.ArchivedAt.Equals(input.ArchivedAt))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
                }
                if (this.PropertiesWithHistory != null)
                {
                    hashCode = (hashCode * 59) + this.PropertiesWithHistory.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Archived.GetHashCode();
                if (this.ArchivedAt != null)
                {
                    hashCode = (hashCode * 59) + this.ArchivedAt.GetHashCode();
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
