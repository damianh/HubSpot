/*
 * CrmPublicAssociationsServiceV4
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v4
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
using OpenAPIDateConverter = HubSpot.Crm.CrmAssociations.Client.OpenAPIDateConverter;

namespace HubSpot.Crm.CrmAssociations.Model
{
    /// <summary>
    /// AssociationSpecWithLabel
    /// </summary>
    [DataContract(Name = "AssociationSpecWithLabel")]
    public partial class AssociationSpecWithLabel : IEquatable<AssociationSpecWithLabel>, IValidatableObject
    {
        /// <summary>
        /// Defines Category
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoryEnum
        {
            /// <summary>
            /// Enum HUBSPOTDEFINED for value: HUBSPOT_DEFINED
            /// </summary>
            [EnumMember(Value = "HUBSPOT_DEFINED")]
            HUBSPOTDEFINED = 1,

            /// <summary>
            /// Enum USERDEFINED for value: USER_DEFINED
            /// </summary>
            [EnumMember(Value = "USER_DEFINED")]
            USERDEFINED = 2,

            /// <summary>
            /// Enum INTEGRATORDEFINED for value: INTEGRATOR_DEFINED
            /// </summary>
            [EnumMember(Value = "INTEGRATOR_DEFINED")]
            INTEGRATORDEFINED = 3
        }


        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", IsRequired = true, EmitDefaultValue = true)]
        public CategoryEnum Category { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociationSpecWithLabel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssociationSpecWithLabel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociationSpecWithLabel" /> class.
        /// </summary>
        /// <param name="category">category (required).</param>
        /// <param name="typeId">typeId (required).</param>
        /// <param name="label">label.</param>
        public AssociationSpecWithLabel(CategoryEnum category = default(CategoryEnum), int typeId = default(int), string label = default(string))
        {
            this.Category = category;
            this.TypeId = typeId;
            this.Label = label;
        }

        /// <summary>
        /// Gets or Sets TypeId
        /// </summary>
        [DataMember(Name = "typeId", IsRequired = true, EmitDefaultValue = true)]
        public int TypeId { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AssociationSpecWithLabel {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
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
            return this.Equals(input as AssociationSpecWithLabel);
        }

        /// <summary>
        /// Returns true if AssociationSpecWithLabel instances are equal
        /// </summary>
        /// <param name="input">Instance of AssociationSpecWithLabel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssociationSpecWithLabel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Category == input.Category ||
                    this.Category.Equals(input.Category)
                ) && 
                (
                    this.TypeId == input.TypeId ||
                    this.TypeId.Equals(input.TypeId)
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
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
                hashCode = (hashCode * 59) + this.Category.GetHashCode();
                hashCode = (hashCode * 59) + this.TypeId.GetHashCode();
                if (this.Label != null)
                {
                    hashCode = (hashCode * 59) + this.Label.GetHashCode();
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
