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
using OpenAPIDateConverter = HubSpot.Cms.Authors.Client.OpenAPIDateConverter;

namespace HubSpot.Cms.Authors.Model
{
    /// <summary>
    /// Wrapper for providing an array of JSON nodes as inputs.
    /// </summary>
    [DataContract(Name = "BatchInputJsonNode")]
    public partial class BatchInputJsonNode : IEquatable<BatchInputJsonNode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchInputJsonNode" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BatchInputJsonNode() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchInputJsonNode" /> class.
        /// </summary>
        /// <param name="inputs">JSON nodes to input. (required).</param>
        public BatchInputJsonNode(List<Object> inputs = default(List<Object>))
        {
            // to ensure "inputs" is required (not null)
            if (inputs == null)
            {
                throw new ArgumentNullException("inputs is a required property for BatchInputJsonNode and cannot be null");
            }
            this.Inputs = inputs;
        }

        /// <summary>
        /// JSON nodes to input.
        /// </summary>
        /// <value>JSON nodes to input.</value>
        [DataMember(Name = "inputs", IsRequired = true, EmitDefaultValue = true)]
        public List<Object> Inputs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BatchInputJsonNode {\n");
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
            return this.Equals(input as BatchInputJsonNode);
        }

        /// <summary>
        /// Returns true if BatchInputJsonNode instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchInputJsonNode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchInputJsonNode input)
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
