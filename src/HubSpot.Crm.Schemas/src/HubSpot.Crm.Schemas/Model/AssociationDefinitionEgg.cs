/*
 * Schemas
 *
 * The CRM uses schemas to define how custom objects should store and represent information in the HubSpot CRM. Schemas define details about an object's type, properties, and associations. The schema can be uniquely identified by its **object type ID**.
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
using OpenAPIDateConverter = HubSpot.Crm.Schemas.Client.OpenAPIDateConverter;

namespace HubSpot.Crm.Schemas.Model
{
    /// <summary>
    /// Defines an association between two object types.
    /// </summary>
    [DataContract(Name = "AssociationDefinitionEgg")]
    public partial class AssociationDefinitionEgg : IEquatable<AssociationDefinitionEgg>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociationDefinitionEgg" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssociationDefinitionEgg() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociationDefinitionEgg" /> class.
        /// </summary>
        /// <param name="fromObjectTypeId">ID of the primary object type to link from. (required).</param>
        /// <param name="toObjectTypeId">ID of the target object type ID to link to. (required).</param>
        /// <param name="name">A unique name for this association..</param>
        public AssociationDefinitionEgg(string fromObjectTypeId = default(string), string toObjectTypeId = default(string), string name = default(string))
        {
            // to ensure "fromObjectTypeId" is required (not null)
            if (fromObjectTypeId == null)
            {
                throw new ArgumentNullException("fromObjectTypeId is a required property for AssociationDefinitionEgg and cannot be null");
            }
            this.FromObjectTypeId = fromObjectTypeId;
            // to ensure "toObjectTypeId" is required (not null)
            if (toObjectTypeId == null)
            {
                throw new ArgumentNullException("toObjectTypeId is a required property for AssociationDefinitionEgg and cannot be null");
            }
            this.ToObjectTypeId = toObjectTypeId;
            this.Name = name;
        }

        /// <summary>
        /// ID of the primary object type to link from.
        /// </summary>
        /// <value>ID of the primary object type to link from.</value>
        [DataMember(Name = "fromObjectTypeId", IsRequired = true, EmitDefaultValue = true)]
        public string FromObjectTypeId { get; set; }

        /// <summary>
        /// ID of the target object type ID to link to.
        /// </summary>
        /// <value>ID of the target object type ID to link to.</value>
        [DataMember(Name = "toObjectTypeId", IsRequired = true, EmitDefaultValue = true)]
        public string ToObjectTypeId { get; set; }

        /// <summary>
        /// A unique name for this association.
        /// </summary>
        /// <value>A unique name for this association.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AssociationDefinitionEgg {\n");
            sb.Append("  FromObjectTypeId: ").Append(FromObjectTypeId).Append("\n");
            sb.Append("  ToObjectTypeId: ").Append(ToObjectTypeId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as AssociationDefinitionEgg);
        }

        /// <summary>
        /// Returns true if AssociationDefinitionEgg instances are equal
        /// </summary>
        /// <param name="input">Instance of AssociationDefinitionEgg to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssociationDefinitionEgg input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FromObjectTypeId == input.FromObjectTypeId ||
                    (this.FromObjectTypeId != null &&
                    this.FromObjectTypeId.Equals(input.FromObjectTypeId))
                ) && 
                (
                    this.ToObjectTypeId == input.ToObjectTypeId ||
                    (this.ToObjectTypeId != null &&
                    this.ToObjectTypeId.Equals(input.ToObjectTypeId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.FromObjectTypeId != null)
                {
                    hashCode = (hashCode * 59) + this.FromObjectTypeId.GetHashCode();
                }
                if (this.ToObjectTypeId != null)
                {
                    hashCode = (hashCode * 59) + this.ToObjectTypeId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
