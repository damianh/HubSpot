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
    /// Represents a unit price
    /// </summary>
    [DataContract(Name = "UnitPrice")]
    public partial class UnitPrice : IEquatable<UnitPrice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitPrice" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnitPrice() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitPrice" /> class.
        /// </summary>
        /// <param name="amount">The actual unit price amount..</param>
        /// <param name="taxIncluded">Indicates if the unit price amount already includes taxes. (required).</param>
        public UnitPrice(decimal amount = default(decimal), bool taxIncluded = default(bool))
        {
            this.TaxIncluded = taxIncluded;
            this.Amount = amount;
        }

        /// <summary>
        /// The actual unit price amount.
        /// </summary>
        /// <value>The actual unit price amount.</value>
        /// <example>10.99</example>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Indicates if the unit price amount already includes taxes.
        /// </summary>
        /// <value>Indicates if the unit price amount already includes taxes.</value>
        [DataMember(Name = "taxIncluded", IsRequired = true, EmitDefaultValue = true)]
        public bool TaxIncluded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UnitPrice {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  TaxIncluded: ").Append(TaxIncluded).Append("\n");
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
            return this.Equals(input as UnitPrice);
        }

        /// <summary>
        /// Returns true if UnitPrice instances are equal
        /// </summary>
        /// <param name="input">Instance of UnitPrice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnitPrice input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.TaxIncluded == input.TaxIncluded ||
                    this.TaxIncluded.Equals(input.TaxIncluded)
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
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                hashCode = (hashCode * 59) + this.TaxIncluded.GetHashCode();
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
