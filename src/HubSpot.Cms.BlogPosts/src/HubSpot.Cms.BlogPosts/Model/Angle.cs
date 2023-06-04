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
using OpenAPIDateConverter = HubSpot.Cms.BlogPosts.Client.OpenAPIDateConverter;

namespace HubSpot.Cms.BlogPosts.Model
{
    /// <summary>
    /// Angle
    /// </summary>
    [DataContract(Name = "Angle")]
    public partial class Angle : IEquatable<Angle>, IValidatableObject
    {
        /// <summary>
        /// Defines Units
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitsEnum
        {
            /// <summary>
            /// Enum Deg for value: deg
            /// </summary>
            [EnumMember(Value = "deg")]
            Deg = 1,

            /// <summary>
            /// Enum Grad for value: grad
            /// </summary>
            [EnumMember(Value = "grad")]
            Grad = 2,

            /// <summary>
            /// Enum Rad for value: rad
            /// </summary>
            [EnumMember(Value = "rad")]
            Rad = 3,

            /// <summary>
            /// Enum Turn for value: turn
            /// </summary>
            [EnumMember(Value = "turn")]
            Turn = 4
        }


        /// <summary>
        /// Gets or Sets Units
        /// </summary>
        [DataMember(Name = "units", IsRequired = true, EmitDefaultValue = true)]
        public UnitsEnum Units { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Angle" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Angle() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Angle" /> class.
        /// </summary>
        /// <param name="value">value (required).</param>
        /// <param name="units">units (required).</param>
        public Angle(decimal value = default(decimal), UnitsEnum units = default(UnitsEnum))
        {
            this.Value = value;
            this.Units = units;
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public decimal Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Angle {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
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
            return this.Equals(input as Angle);
        }

        /// <summary>
        /// Returns true if Angle instances are equal
        /// </summary>
        /// <param name="input">Instance of Angle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Angle input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.Units == input.Units ||
                    this.Units.Equals(input.Units)
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
                hashCode = (hashCode * 59) + this.Value.GetHashCode();
                hashCode = (hashCode * 59) + this.Units.GetHashCode();
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
