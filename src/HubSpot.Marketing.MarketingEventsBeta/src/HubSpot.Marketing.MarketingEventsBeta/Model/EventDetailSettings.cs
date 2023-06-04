/*
 * Marketing Events Extension
 *
 * These APIs allow you to interact with HubSpot's Marketing Events Extension. It allows you to: * Create, Read or update Marketing Event information in HubSpot * Specify whether a HubSpot contact has registered, attended or cancelled a registration to a Marketing Event. * Specify a URL that can be called to get the details of a Marketing Event. 
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
using OpenAPIDateConverter = HubSpot.Marketing.MarketingEventsBeta.Client.OpenAPIDateConverter;

namespace HubSpot.Marketing.MarketingEventsBeta.Model
{
    /// <summary>
    /// EventDetailSettings
    /// </summary>
    [DataContract(Name = "EventDetailSettings")]
    public partial class EventDetailSettings : IEquatable<EventDetailSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventDetailSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EventDetailSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EventDetailSettings" /> class.
        /// </summary>
        /// <param name="appId">The id of the application the settings are for (required).</param>
        /// <param name="eventDetailsUrl">The url that will be used to fetch marketing event details by id (required).</param>
        public EventDetailSettings(int appId = default(int), string eventDetailsUrl = default(string))
        {
            this.AppId = appId;
            // to ensure "eventDetailsUrl" is required (not null)
            if (eventDetailsUrl == null)
            {
                throw new ArgumentNullException("eventDetailsUrl is a required property for EventDetailSettings and cannot be null");
            }
            this.EventDetailsUrl = eventDetailsUrl;
        }

        /// <summary>
        /// The id of the application the settings are for
        /// </summary>
        /// <value>The id of the application the settings are for</value>
        [DataMember(Name = "appId", IsRequired = true, EmitDefaultValue = true)]
        public int AppId { get; set; }

        /// <summary>
        /// The url that will be used to fetch marketing event details by id
        /// </summary>
        /// <value>The url that will be used to fetch marketing event details by id</value>
        [DataMember(Name = "eventDetailsUrl", IsRequired = true, EmitDefaultValue = true)]
        public string EventDetailsUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EventDetailSettings {\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  EventDetailsUrl: ").Append(EventDetailsUrl).Append("\n");
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
            return this.Equals(input as EventDetailSettings);
        }

        /// <summary>
        /// Returns true if EventDetailSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of EventDetailSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventDetailSettings input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppId == input.AppId ||
                    this.AppId.Equals(input.AppId)
                ) && 
                (
                    this.EventDetailsUrl == input.EventDetailsUrl ||
                    (this.EventDetailsUrl != null &&
                    this.EventDetailsUrl.Equals(input.EventDetailsUrl))
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
                hashCode = (hashCode * 59) + this.AppId.GetHashCode();
                if (this.EventDetailsUrl != null)
                {
                    hashCode = (hashCode * 59) + this.EventDetailsUrl.GetHashCode();
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
