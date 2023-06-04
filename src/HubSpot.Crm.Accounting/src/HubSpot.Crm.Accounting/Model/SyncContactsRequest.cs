/*
 * Accounting Extension
 *
 * These APIs allow you to interact with HubSpot's Accounting Extension. It allows you to: * Specify the URLs that HubSpot will use when making webhook requests to your external accounting system. * Respond to webhook calls made to your external accounting system by HubSpot 
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
using OpenAPIDateConverter = HubSpot.Crm.Accounting.Client.OpenAPIDateConverter;

namespace HubSpot.Crm.Accounting.Model
{
    /// <summary>
    /// A request to import external accounting contact properties in HubSpot
    /// </summary>
    [DataContract(Name = "SyncContactsRequest")]
    public partial class SyncContactsRequest : IEquatable<SyncContactsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SyncContactsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SyncContactsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SyncContactsRequest" /> class.
        /// </summary>
        /// <param name="accountId">The ID of the account in the external accounting system. This is the value that will be passed as &#x60;accountId&#x60; for all outbound calls for the user from HubSpot to the external accounting system. (required).</param>
        /// <param name="contacts">A list of contacts to be imported. (required).</param>
        public SyncContactsRequest(string accountId = default(string), List<UpdatedContact> contacts = default(List<UpdatedContact>))
        {
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new ArgumentNullException("accountId is a required property for SyncContactsRequest and cannot be null");
            }
            this.AccountId = accountId;
            // to ensure "contacts" is required (not null)
            if (contacts == null)
            {
                throw new ArgumentNullException("contacts is a required property for SyncContactsRequest and cannot be null");
            }
            this.Contacts = contacts;
        }

        /// <summary>
        /// The ID of the account in the external accounting system. This is the value that will be passed as &#x60;accountId&#x60; for all outbound calls for the user from HubSpot to the external accounting system.
        /// </summary>
        /// <value>The ID of the account in the external accounting system. This is the value that will be passed as &#x60;accountId&#x60; for all outbound calls for the user from HubSpot to the external accounting system.</value>
        /// <example>&quot;acct-app-123&quot;</example>
        [DataMember(Name = "accountId", IsRequired = true, EmitDefaultValue = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// A list of contacts to be imported.
        /// </summary>
        /// <value>A list of contacts to be imported.</value>
        [DataMember(Name = "contacts", IsRequired = true, EmitDefaultValue = true)]
        public List<UpdatedContact> Contacts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SyncContactsRequest {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
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
            return this.Equals(input as SyncContactsRequest);
        }

        /// <summary>
        /// Returns true if SyncContactsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SyncContactsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SyncContactsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.Contacts == input.Contacts ||
                    this.Contacts != null &&
                    input.Contacts != null &&
                    this.Contacts.SequenceEqual(input.Contacts)
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
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.Contacts != null)
                {
                    hashCode = (hashCode * 59) + this.Contacts.GetHashCode();
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
