/*
 * Timeline events
 *
 * This feature allows an app to create and configure custom events that can show up in the timelines of certain CRM objects like contacts, companies, tickets, or deals. You'll find multiple use cases for this API in the sections below.
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
using OpenAPIDateConverter = HubSpot.Crm.Timeline.Client.OpenAPIDateConverter;

namespace HubSpot.Crm.Timeline.Model
{
    /// <summary>
    /// CollectionResponseTimelineEventTemplateNoPaging
    /// </summary>
    [DataContract(Name = "CollectionResponseTimelineEventTemplateNoPaging")]
    public partial class CollectionResponseTimelineEventTemplateNoPaging : IEquatable<CollectionResponseTimelineEventTemplateNoPaging>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionResponseTimelineEventTemplateNoPaging" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CollectionResponseTimelineEventTemplateNoPaging() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionResponseTimelineEventTemplateNoPaging" /> class.
        /// </summary>
        /// <param name="results">results (required).</param>
        public CollectionResponseTimelineEventTemplateNoPaging(List<TimelineEventTemplate> results = default(List<TimelineEventTemplate>))
        {
            // to ensure "results" is required (not null)
            if (results == null)
            {
                throw new ArgumentNullException("results is a required property for CollectionResponseTimelineEventTemplateNoPaging and cannot be null");
            }
            this.Results = results;
        }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name = "results", IsRequired = true, EmitDefaultValue = true)]
        public List<TimelineEventTemplate> Results { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CollectionResponseTimelineEventTemplateNoPaging {\n");
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
            return this.Equals(input as CollectionResponseTimelineEventTemplateNoPaging);
        }

        /// <summary>
        /// Returns true if CollectionResponseTimelineEventTemplateNoPaging instances are equal
        /// </summary>
        /// <param name="input">Instance of CollectionResponseTimelineEventTemplateNoPaging to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CollectionResponseTimelineEventTemplateNoPaging input)
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
