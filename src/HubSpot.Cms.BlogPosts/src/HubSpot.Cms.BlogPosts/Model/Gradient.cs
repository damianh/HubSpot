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
    /// Gradient
    /// </summary>
    [DataContract(Name = "Gradient")]
    public partial class Gradient : IEquatable<Gradient>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Gradient" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Gradient() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Gradient" /> class.
        /// </summary>
        /// <param name="sideOrCorner">sideOrCorner (required).</param>
        /// <param name="angle">angle (required).</param>
        /// <param name="colors">colors (required).</param>
        public Gradient(SideOrCorner sideOrCorner = default(SideOrCorner), Angle angle = default(Angle), List<ColorStop> colors = default(List<ColorStop>))
        {
            // to ensure "sideOrCorner" is required (not null)
            if (sideOrCorner == null)
            {
                throw new ArgumentNullException("sideOrCorner is a required property for Gradient and cannot be null");
            }
            this.SideOrCorner = sideOrCorner;
            // to ensure "angle" is required (not null)
            if (angle == null)
            {
                throw new ArgumentNullException("angle is a required property for Gradient and cannot be null");
            }
            this.Angle = angle;
            // to ensure "colors" is required (not null)
            if (colors == null)
            {
                throw new ArgumentNullException("colors is a required property for Gradient and cannot be null");
            }
            this.Colors = colors;
        }

        /// <summary>
        /// Gets or Sets SideOrCorner
        /// </summary>
        [DataMember(Name = "sideOrCorner", IsRequired = true, EmitDefaultValue = true)]
        public SideOrCorner SideOrCorner { get; set; }

        /// <summary>
        /// Gets or Sets Angle
        /// </summary>
        [DataMember(Name = "angle", IsRequired = true, EmitDefaultValue = true)]
        public Angle Angle { get; set; }

        /// <summary>
        /// Gets or Sets Colors
        /// </summary>
        [DataMember(Name = "colors", IsRequired = true, EmitDefaultValue = true)]
        public List<ColorStop> Colors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Gradient {\n");
            sb.Append("  SideOrCorner: ").Append(SideOrCorner).Append("\n");
            sb.Append("  Angle: ").Append(Angle).Append("\n");
            sb.Append("  Colors: ").Append(Colors).Append("\n");
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
            return this.Equals(input as Gradient);
        }

        /// <summary>
        /// Returns true if Gradient instances are equal
        /// </summary>
        /// <param name="input">Instance of Gradient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Gradient input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SideOrCorner == input.SideOrCorner ||
                    (this.SideOrCorner != null &&
                    this.SideOrCorner.Equals(input.SideOrCorner))
                ) && 
                (
                    this.Angle == input.Angle ||
                    (this.Angle != null &&
                    this.Angle.Equals(input.Angle))
                ) && 
                (
                    this.Colors == input.Colors ||
                    this.Colors != null &&
                    input.Colors != null &&
                    this.Colors.SequenceEqual(input.Colors)
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
                if (this.SideOrCorner != null)
                {
                    hashCode = (hashCode * 59) + this.SideOrCorner.GetHashCode();
                }
                if (this.Angle != null)
                {
                    hashCode = (hashCode * 59) + this.Angle.GetHashCode();
                }
                if (this.Colors != null)
                {
                    hashCode = (hashCode * 59) + this.Colors.GetHashCode();
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
