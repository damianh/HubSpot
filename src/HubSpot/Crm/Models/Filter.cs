using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace HubSpot.Crm.Models {
    public class Filter : IParsable {
        /// <summary>The highValue property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HighValue { get; set; }
#nullable restore
#else
        public string HighValue { get; set; }
#endif
        /// <summary>null</summary>
        public Filter_operator? Operator { get; set; }
        /// <summary>The propertyName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PropertyName { get; set; }
#nullable restore
#else
        public string PropertyName { get; set; }
#endif
        /// <summary>The value property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Value { get; set; }
#nullable restore
#else
        public string Value { get; set; }
#endif
        /// <summary>The values property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Values { get; set; }
#nullable restore
#else
        public List<string> Values { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Filter CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Filter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"highValue", n => { HighValue = n.GetStringValue(); } },
                {"operator", n => { Operator = n.GetEnumValue<Filter_operator>(); } },
                {"propertyName", n => { PropertyName = n.GetStringValue(); } },
                {"value", n => { Value = n.GetStringValue(); } },
                {"values", n => { Values = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("highValue", HighValue);
            writer.WriteEnumValue<Filter_operator>("operator", Operator);
            writer.WriteStringValue("propertyName", PropertyName);
            writer.WriteStringValue("value", Value);
            writer.WriteCollectionOfPrimitiveValues<string>("values", Values);
        }
    }
}
