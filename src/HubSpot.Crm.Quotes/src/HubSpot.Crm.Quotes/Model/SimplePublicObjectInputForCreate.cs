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
    /// SimplePublicObjectInputForCreate
    /// </summary>
    [DataContract(Name = "SimplePublicObjectInputForCreate")]
    public partial class SimplePublicObjectInputForCreate : IEquatable<SimplePublicObjectInputForCreate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimplePublicObjectInputForCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SimplePublicObjectInputForCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SimplePublicObjectInputForCreate" /> class.
        /// </summary>
        /// <param name="properties">properties (required).</param>
        /// <param name="associations">associations (required).</param>
        public SimplePublicObjectInputForCreate(Dictionary<string, string> properties = default(Dictionary<string, string>), List<PublicAssociationsForObject> associations = default(List<PublicAssociationsForObject>))
        {
            // to ensure "properties" is required (not null)
            if (properties == null)
            {
                throw new ArgumentNullException("properties is a required property for SimplePublicObjectInputForCreate and cannot be null");
            }
            this.Properties = properties;
            // to ensure "associations" is required (not null)
            if (associations == null)
            {
                throw new ArgumentNullException("associations is a required property for SimplePublicObjectInputForCreate and cannot be null");
            }
            this.Associations = associations;
        }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "properties", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Gets or Sets Associations
        /// </summary>
        [DataMember(Name = "associations", IsRequired = true, EmitDefaultValue = true)]
        public List<PublicAssociationsForObject> Associations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SimplePublicObjectInputForCreate {\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Associations: ").Append(Associations).Append("\n");
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
            return this.Equals(input as SimplePublicObjectInputForCreate);
        }

        /// <summary>
        /// Returns true if SimplePublicObjectInputForCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of SimplePublicObjectInputForCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimplePublicObjectInputForCreate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.Associations == input.Associations ||
                    this.Associations != null &&
                    input.Associations != null &&
                    this.Associations.SequenceEqual(input.Associations)
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
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
                }
                if (this.Associations != null)
                {
                    hashCode = (hashCode * 59) + this.Associations.GetHashCode();
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
