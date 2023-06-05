using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace HubSpot.Crm.Models {
    public class SimplePublicObjectInputForCreate : IParsable {
        /// <summary>The associations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PublicAssociationsForObject>? Associations { get; set; }
#nullable restore
#else
        public List<PublicAssociationsForObject> Associations { get; set; }
#endif
        /// <summary>The properties property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SimplePublicObjectInputForCreate_properties? Properties { get; set; }
#nullable restore
#else
        public SimplePublicObjectInputForCreate_properties Properties { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SimplePublicObjectInputForCreate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SimplePublicObjectInputForCreate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"associations", n => { Associations = n.GetCollectionOfObjectValues<PublicAssociationsForObject>(PublicAssociationsForObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"properties", n => { Properties = n.GetObjectValue<SimplePublicObjectInputForCreate_properties>(SimplePublicObjectInputForCreate_properties.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<PublicAssociationsForObject>("associations", Associations);
            writer.WriteObjectValue<SimplePublicObjectInputForCreate_properties>("properties", Properties);
        }
    }
}
