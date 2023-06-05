using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace HubSpot.Associations.Models {
    public class PublicAssociation : IParsable {
        /// <summary>The from property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PublicObjectId? From { get; set; }
#nullable restore
#else
        public PublicObjectId From { get; set; }
#endif
        /// <summary>The to property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PublicObjectId? To { get; set; }
#nullable restore
#else
        public PublicObjectId To { get; set; }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PublicAssociation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PublicAssociation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"from", n => { From = n.GetObjectValue<PublicObjectId>(PublicObjectId.CreateFromDiscriminatorValue); } },
                {"to", n => { To = n.GetObjectValue<PublicObjectId>(PublicObjectId.CreateFromDiscriminatorValue); } },
                {"type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PublicObjectId>("from", From);
            writer.WriteObjectValue<PublicObjectId>("to", To);
            writer.WriteStringValue("type", Type);
        }
    }
}
