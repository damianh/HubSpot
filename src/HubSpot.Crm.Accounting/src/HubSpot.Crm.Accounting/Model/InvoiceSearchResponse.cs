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
    /// A response to a search for invoices.
    /// </summary>
    [DataContract(Name = "InvoiceSearchResponse")]
    public partial class InvoiceSearchResponse : IEquatable<InvoiceSearchResponse>, IValidatableObject
    {
        /// <summary>
        /// Designates if the response is a success (&#39;OK&#39;) or failure (&#39;ERR&#39;).
        /// </summary>
        /// <value>Designates if the response is a success (&#39;OK&#39;) or failure (&#39;ERR&#39;).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResultEnum
        {
            /// <summary>
            /// Enum OK for value: OK
            /// </summary>
            [EnumMember(Value = "OK")]
            OK = 1,

            /// <summary>
            /// Enum ERR for value: ERR
            /// </summary>
            [EnumMember(Value = "ERR")]
            ERR = 2
        }


        /// <summary>
        /// Designates if the response is a success (&#39;OK&#39;) or failure (&#39;ERR&#39;).
        /// </summary>
        /// <value>Designates if the response is a success (&#39;OK&#39;) or failure (&#39;ERR&#39;).</value>
        /// <example>&quot;OK&quot;</example>
        [DataMember(Name = "@result", EmitDefaultValue = false)]
        public ResultEnum? Result { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceSearchResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvoiceSearchResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceSearchResponse" /> class.
        /// </summary>
        /// <param name="result">Designates if the response is a success (&#39;OK&#39;) or failure (&#39;ERR&#39;)..</param>
        /// <param name="invoices">The list of invoices that matched the search criteria. (required).</param>
        public InvoiceSearchResponse(ResultEnum? result = default(ResultEnum?), List<AccountingExtensionInvoice> invoices = default(List<AccountingExtensionInvoice>))
        {
            // to ensure "invoices" is required (not null)
            if (invoices == null)
            {
                throw new ArgumentNullException("invoices is a required property for InvoiceSearchResponse and cannot be null");
            }
            this.Invoices = invoices;
            this.Result = result;
        }

        /// <summary>
        /// The list of invoices that matched the search criteria.
        /// </summary>
        /// <value>The list of invoices that matched the search criteria.</value>
        [DataMember(Name = "invoices", IsRequired = true, EmitDefaultValue = true)]
        public List<AccountingExtensionInvoice> Invoices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceSearchResponse {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Invoices: ").Append(Invoices).Append("\n");
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
            return this.Equals(input as InvoiceSearchResponse);
        }

        /// <summary>
        /// Returns true if InvoiceSearchResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceSearchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceSearchResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Result == input.Result ||
                    this.Result.Equals(input.Result)
                ) && 
                (
                    this.Invoices == input.Invoices ||
                    this.Invoices != null &&
                    input.Invoices != null &&
                    this.Invoices.SequenceEqual(input.Invoices)
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
                hashCode = (hashCode * 59) + this.Result.GetHashCode();
                if (this.Invoices != null)
                {
                    hashCode = (hashCode * 59) + this.Invoices.GetHashCode();
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
