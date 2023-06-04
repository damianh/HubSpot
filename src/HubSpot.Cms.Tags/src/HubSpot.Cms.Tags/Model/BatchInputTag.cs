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
using OpenAPIDateConverter = HubSpot.Cms.Tags.Client.OpenAPIDateConverter;

namespace HubSpot.Cms.Tags.Model
{
    /// <summary>
    /// Wrapper for providing an array of blog tags as inputs.
    /// </summary>
    [DataContract(Name = "BatchInputTag")]
    public partial class BatchInputTag : IEquatable<BatchInputTag>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchInputTag" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BatchInputTag() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchInputTag" /> class.
        /// </summary>
        /// <param name="inputs">Blog tags to input. (required).</param>
        public BatchInputTag(List<Tag> inputs = default(List<Tag>))
        {
            // to ensure "inputs" is required (not null)
            if (inputs == null)
            {
                throw new ArgumentNullException("inputs is a required property for BatchInputTag and cannot be null");
            }
            this.Inputs = inputs;
        }

        /// <summary>
        /// Blog tags to input.
        /// </summary>
        /// <value>Blog tags to input.</value>
        [DataMember(Name = "inputs", IsRequired = true, EmitDefaultValue = true)]
        public List<Tag> Inputs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BatchInputTag {\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
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
            return this.Equals(input as BatchInputTag);
        }

        /// <summary>
        /// Returns true if BatchInputTag instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchInputTag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchInputTag input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Inputs == input.Inputs ||
                    this.Inputs != null &&
                    input.Inputs != null &&
                    this.Inputs.SequenceEqual(input.Inputs)
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
                if (this.Inputs != null)
                {
                    hashCode = (hashCode * 59) + this.Inputs.GetHashCode();
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
