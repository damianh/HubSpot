/*
 * CRM Objects
 *
 * CRM objects such as companies, contacts, deals, line items, products, tickets, and quotes are standard objects in HubSpot’s CRM. These core building blocks support custom properties, store critical information, and play a central role in the HubSpot application.  ## Supported Object Types  This API provides access to collections of CRM objects, which return a map of property names to values. Each object type has its own set of default properties, which can be found by exploring the [CRM Object Properties API](https://developers.hubspot.com/docs/methods/crm-properties/crm-properties-overview).  |Object Type |Properties returned by default | |- -|- -| | `companies` | `name`, `domain` | | `contacts` | `firstname`, `lastname`, `email` | | `deals` | `dealname`, `amount`, `closedate`, `pipeline`, `dealstage` | | `products` | `name`, `description`, `price` | | `tickets` | `content`, `hs_pipeline`, `hs_pipeline_stage`, `hs_ticket_category`, `hs_ticket_priority`, `subject` |  Find a list of all properties for an object type using the [CRM Object Properties](https://developers.hubspot.com/docs/methods/crm-properties/get-properties) API. e.g. `GET https://api.hubapi.com/properties/v2/companies/properties`. Change the properties returned in the response using the `properties` array in the request body.
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
using OpenAPIDateConverter = HubSpot.Crm.Objects.Client.OpenAPIDateConverter;

namespace HubSpot.Crm.Objects.Model
{
    /// <summary>
    /// BatchResponseSimplePublicObject
    /// </summary>
    [DataContract(Name = "BatchResponseSimplePublicObject")]
    public partial class BatchResponseSimplePublicObject : IEquatable<BatchResponseSimplePublicObject>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum PENDING for value: PENDING
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING = 1,

            /// <summary>
            /// Enum PROCESSING for value: PROCESSING
            /// </summary>
            [EnumMember(Value = "PROCESSING")]
            PROCESSING = 2,

            /// <summary>
            /// Enum CANCELED for value: CANCELED
            /// </summary>
            [EnumMember(Value = "CANCELED")]
            CANCELED = 3,

            /// <summary>
            /// Enum COMPLETE for value: COMPLETE
            /// </summary>
            [EnumMember(Value = "COMPLETE")]
            COMPLETE = 4
        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchResponseSimplePublicObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BatchResponseSimplePublicObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchResponseSimplePublicObject" /> class.
        /// </summary>
        /// <param name="status">status (required).</param>
        /// <param name="results">results (required).</param>
        /// <param name="requestedAt">requestedAt.</param>
        /// <param name="startedAt">startedAt (required).</param>
        /// <param name="completedAt">completedAt (required).</param>
        /// <param name="links">links.</param>
        public BatchResponseSimplePublicObject(StatusEnum status = default(StatusEnum), List<SimplePublicObject> results = default(List<SimplePublicObject>), DateTime requestedAt = default(DateTime), DateTime startedAt = default(DateTime), DateTime completedAt = default(DateTime), Dictionary<string, string> links = default(Dictionary<string, string>))
        {
            this.Status = status;
            // to ensure "results" is required (not null)
            if (results == null)
            {
                throw new ArgumentNullException("results is a required property for BatchResponseSimplePublicObject and cannot be null");
            }
            this.Results = results;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.RequestedAt = requestedAt;
            this.Links = links;
        }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name = "results", IsRequired = true, EmitDefaultValue = true)]
        public List<SimplePublicObject> Results { get; set; }

        /// <summary>
        /// Gets or Sets RequestedAt
        /// </summary>
        [DataMember(Name = "requestedAt", EmitDefaultValue = false)]
        public DateTime RequestedAt { get; set; }

        /// <summary>
        /// Gets or Sets StartedAt
        /// </summary>
        [DataMember(Name = "startedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime StartedAt { get; set; }

        /// <summary>
        /// Gets or Sets CompletedAt
        /// </summary>
        [DataMember(Name = "completedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CompletedAt { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public Dictionary<string, string> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BatchResponseSimplePublicObject {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  RequestedAt: ").Append(RequestedAt).Append("\n");
            sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
            sb.Append("  CompletedAt: ").Append(CompletedAt).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as BatchResponseSimplePublicObject);
        }

        /// <summary>
        /// Returns true if BatchResponseSimplePublicObject instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchResponseSimplePublicObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchResponseSimplePublicObject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    input.Results != null &&
                    this.Results.SequenceEqual(input.Results)
                ) && 
                (
                    this.RequestedAt == input.RequestedAt ||
                    (this.RequestedAt != null &&
                    this.RequestedAt.Equals(input.RequestedAt))
                ) && 
                (
                    this.StartedAt == input.StartedAt ||
                    (this.StartedAt != null &&
                    this.StartedAt.Equals(input.StartedAt))
                ) && 
                (
                    this.CompletedAt == input.CompletedAt ||
                    (this.CompletedAt != null &&
                    this.CompletedAt.Equals(input.CompletedAt))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Results != null)
                {
                    hashCode = (hashCode * 59) + this.Results.GetHashCode();
                }
                if (this.RequestedAt != null)
                {
                    hashCode = (hashCode * 59) + this.RequestedAt.GetHashCode();
                }
                if (this.StartedAt != null)
                {
                    hashCode = (hashCode * 59) + this.StartedAt.GetHashCode();
                }
                if (this.CompletedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CompletedAt.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
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
