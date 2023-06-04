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
    /// A response to the request for an exchange rate value. It represents the exchange rate from the source currency to the target currency.
    /// </summary>
    [DataContract(Name = "ExchangeRateResponse")]
    public partial class ExchangeRateResponse : IEquatable<ExchangeRateResponse>, IValidatableObject
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
        [DataMember(Name = "@result", IsRequired = true, EmitDefaultValue = true)]
        public ResultEnum Result { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeRateResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExchangeRateResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeRateResponse" /> class.
        /// </summary>
        /// <param name="result">Designates if the response is a success (&#39;OK&#39;) or failure (&#39;ERR&#39;). (required).</param>
        /// <param name="exchangeRate">The exchange rate between the 2 currencies (required).</param>
        /// <param name="sourceCurrencyCode">The ISO 4217 currency code that represents the source currency of the exchange rate. (required).</param>
        /// <param name="targetCurrencyCode">The ISO 4217 currency code that represents the target currency of the exchange rate. (required).</param>
        public ExchangeRateResponse(ResultEnum result = default(ResultEnum), decimal exchangeRate = default(decimal), string sourceCurrencyCode = default(string), string targetCurrencyCode = default(string))
        {
            this.Result = result;
            this.ExchangeRate = exchangeRate;
            // to ensure "sourceCurrencyCode" is required (not null)
            if (sourceCurrencyCode == null)
            {
                throw new ArgumentNullException("sourceCurrencyCode is a required property for ExchangeRateResponse and cannot be null");
            }
            this.SourceCurrencyCode = sourceCurrencyCode;
            // to ensure "targetCurrencyCode" is required (not null)
            if (targetCurrencyCode == null)
            {
                throw new ArgumentNullException("targetCurrencyCode is a required property for ExchangeRateResponse and cannot be null");
            }
            this.TargetCurrencyCode = targetCurrencyCode;
        }

        /// <summary>
        /// The exchange rate between the 2 currencies
        /// </summary>
        /// <value>The exchange rate between the 2 currencies</value>
        /// <example>1.003</example>
        [DataMember(Name = "exchangeRate", IsRequired = true, EmitDefaultValue = true)]
        public decimal ExchangeRate { get; set; }

        /// <summary>
        /// The ISO 4217 currency code that represents the source currency of the exchange rate.
        /// </summary>
        /// <value>The ISO 4217 currency code that represents the source currency of the exchange rate.</value>
        /// <example>&quot;JPY&quot;</example>
        [DataMember(Name = "sourceCurrencyCode", IsRequired = true, EmitDefaultValue = true)]
        public string SourceCurrencyCode { get; set; }

        /// <summary>
        /// The ISO 4217 currency code that represents the target currency of the exchange rate.
        /// </summary>
        /// <value>The ISO 4217 currency code that represents the target currency of the exchange rate.</value>
        /// <example>&quot;USD&quot;</example>
        [DataMember(Name = "targetCurrencyCode", IsRequired = true, EmitDefaultValue = true)]
        public string TargetCurrencyCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExchangeRateResponse {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
            sb.Append("  SourceCurrencyCode: ").Append(SourceCurrencyCode).Append("\n");
            sb.Append("  TargetCurrencyCode: ").Append(TargetCurrencyCode).Append("\n");
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
            return this.Equals(input as ExchangeRateResponse);
        }

        /// <summary>
        /// Returns true if ExchangeRateResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ExchangeRateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExchangeRateResponse input)
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
                    this.ExchangeRate == input.ExchangeRate ||
                    this.ExchangeRate.Equals(input.ExchangeRate)
                ) && 
                (
                    this.SourceCurrencyCode == input.SourceCurrencyCode ||
                    (this.SourceCurrencyCode != null &&
                    this.SourceCurrencyCode.Equals(input.SourceCurrencyCode))
                ) && 
                (
                    this.TargetCurrencyCode == input.TargetCurrencyCode ||
                    (this.TargetCurrencyCode != null &&
                    this.TargetCurrencyCode.Equals(input.TargetCurrencyCode))
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
                hashCode = (hashCode * 59) + this.ExchangeRate.GetHashCode();
                if (this.SourceCurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.SourceCurrencyCode.GetHashCode();
                }
                if (this.TargetCurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.TargetCurrencyCode.GetHashCode();
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
