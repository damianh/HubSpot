using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace HubSpot.Associations.Models {
    public class PublicAssociationMulti : IParsable {
        /// <summary>The from property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PublicObjectId? From { get; set; }
#nullable restore
#else
        public PublicObjectId From { get; set; }
#endif
        /// <summary>The paging property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public HubSpot.Associations.Models.Paging? Paging { get; set; }
#nullable restore
#else
        public HubSpot.Associations.Models.Paging Paging { get; set; }
#endif
        /// <summary>The IDs of objects that are associated with the object identified by the ID in &apos;from&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AssociatedId>? To { get; set; }
#nullable restore
#else
        public List<AssociatedId> To { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PublicAssociationMulti CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PublicAssociationMulti();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"from", n => { From = n.GetObjectValue<PublicObjectId>(PublicObjectId.CreateFromDiscriminatorValue); } },
                {"paging", n => { Paging = n.GetObjectValue<HubSpot.Associations.Models.Paging>(HubSpot.Associations.Models.Paging.CreateFromDiscriminatorValue); } },
                {"to", n => { To = n.GetCollectionOfObjectValues<AssociatedId>(AssociatedId.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PublicObjectId>("from", From);
            writer.WriteObjectValue<HubSpot.Associations.Models.Paging>("paging", Paging);
            writer.WriteCollectionOfObjectValues<AssociatedId>("to", To);
        }
    }
}
