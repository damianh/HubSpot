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
    /// CollectionResponseAssociationSpecWithLabelNoPaging
    /// </summary>
    [DataContract(Name = "CollectionResponseAssociationSpecWithLabelNoPaging")]
    public partial class CollectionResponseAssociationSpecWithLabelNoPaging : IEquatable<CollectionResponseAssociationSpecWithLabelNoPaging>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionResponseAssociationSpecWithLabelNoPaging" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CollectionResponseAssociationSpecWithLabelNoPaging() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionResponseAssociationSpecWithLabelNoPaging" /> class.
        /// </summary>
        /// <param name="results">results (required).</param>
        public CollectionResponseAssociationSpecWithLabelNoPaging(List<AssociationSpecWithLabel> results = default(List<AssociationSpecWithLabel>))
        {
            // to ensure "results" is required (not null)
            if (results == null)
            {
                throw new ArgumentNullException("results is a required property for CollectionResponseAssociationSpecWithLabelNoPaging and cannot be null");
            }
            this.Results = results;
        }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name = "results", IsRequired = true, EmitDefaultValue = true)]
        public List<AssociationSpecWithLabel> Results { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CollectionResponseAssociationSpecWithLabelNoPaging {\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return this.Equals(input as CollectionResponseAssociationSpecWithLabelNoPaging);
        }

        /// <summary>
        /// Returns true if CollectionResponseAssociationSpecWithLabelNoPaging instances are equal
        /// </summary>
        /// <param name="input">Instance of CollectionResponseAssociationSpecWithLabelNoPaging to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CollectionResponseAssociationSpecWithLabelNoPaging input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    input.Results != null &&
                    this.Results.SequenceEqual(input.Results)
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
                if (this.Results != null)
                {
                    hashCode = (hashCode * 59) + this.Results.GetHashCode();
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
