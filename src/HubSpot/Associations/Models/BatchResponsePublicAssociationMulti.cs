using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace HubSpot.Associations.Models {
    public class BatchResponsePublicAssociationMulti : IParsable {
        /// <summary>The completedAt property</summary>
        public DateTimeOffset? CompletedAt { get; set; }
        /// <summary>The links property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BatchResponsePublicAssociationMulti_links? Links { get; set; }
#nullable restore
#else
        public BatchResponsePublicAssociationMulti_links Links { get; set; }
#endif
        /// <summary>The requestedAt property</summary>
        public DateTimeOffset? RequestedAt { get; set; }
        /// <summary>The results property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PublicAssociationMulti>? Results { get; set; }
#nullable restore
#else
        public List<PublicAssociationMulti> Results { get; set; }
#endif
        /// <summary>The startedAt property</summary>
        public DateTimeOffset? StartedAt { get; set; }
        /// <summary>The status property</summary>
        public BatchResponsePublicAssociationMulti_status? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BatchResponsePublicAssociationMulti CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BatchResponsePublicAssociationMulti();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"completedAt", n => { CompletedAt = n.GetDateTimeOffsetValue(); } },
                {"links", n => { Links = n.GetObjectValue<BatchResponsePublicAssociationMulti_links>(BatchResponsePublicAssociationMulti_links.CreateFromDiscriminatorValue); } },
                {"requestedAt", n => { RequestedAt = n.GetDateTimeOffsetValue(); } },
                {"results", n => { Results = n.GetCollectionOfObjectValues<PublicAssociationMulti>(PublicAssociationMulti.CreateFromDiscriminatorValue)?.ToList(); } },
                {"startedAt", n => { StartedAt = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetEnumValue<BatchResponsePublicAssociationMulti_status>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("completedAt", CompletedAt);
            writer.WriteObjectValue<BatchResponsePublicAssociationMulti_links>("links", Links);
            writer.WriteDateTimeOffsetValue("requestedAt", RequestedAt);
            writer.WriteCollectionOfObjectValues<PublicAssociationMulti>("results", Results);
            writer.WriteDateTimeOffsetValue("startedAt", StartedAt);
            writer.WriteEnumValue<BatchResponsePublicAssociationMulti_status>("status", Status);
        }
    }
}
