/*
 * Custom Workflow Actions
 *
 * Create custom workflow actions
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
using OpenAPIDateConverter = HubSpot.Automation.Actions.Client.OpenAPIDateConverter;

namespace HubSpot.Automation.Actions.Model
{
    /// <summary>
    /// Any information to send back to Workflows when completing an action callback.
    /// </summary>
    [DataContract(Name = "CallbackCompletionRequest")]
    public partial class CallbackCompletionRequest : IEquatable<CallbackCompletionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackCompletionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CallbackCompletionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackCompletionRequest" /> class.
        /// </summary>
        /// <param name="outputFields">A map of action output names and values. (required).</param>
        public CallbackCompletionRequest(Dictionary<string, string> outputFields = default(Dictionary<string, string>))
        {
            // to ensure "outputFields" is required (not null)
            if (outputFields == null)
            {
                throw new ArgumentNullException("outputFields is a required property for CallbackCompletionRequest and cannot be null");
            }
            this.OutputFields = outputFields;
        }

        /// <summary>
        /// A map of action output names and values.
        /// </summary>
        /// <value>A map of action output names and values.</value>
        [DataMember(Name = "outputFields", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, string> OutputFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CallbackCompletionRequest {\n");
            sb.Append("  OutputFields: ").Append(OutputFields).Append("\n");
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
            return this.Equals(input as CallbackCompletionRequest);
        }

        /// <summary>
        /// Returns true if CallbackCompletionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CallbackCompletionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallbackCompletionRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OutputFields == input.OutputFields ||
                    this.OutputFields != null &&
                    input.OutputFields != null &&
                    this.OutputFields.SequenceEqual(input.OutputFields)
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
                if (this.OutputFields != null)
                {
                    hashCode = (hashCode * 59) + this.OutputFields.GetHashCode();
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
