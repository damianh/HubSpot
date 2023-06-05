using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace HubSpot.Companies.Models {
    public class BatchResponseSimplePublicObject : IParsable {
        /// <summary>The completedAt property</summary>
        public DateTimeOffset? CompletedAt { get; set; }
        /// <summary>The links property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BatchResponseSimplePublicObject_links? Links { get; set; }
#nullable restore
#else
        public BatchResponseSimplePublicObject_links Links { get; set; }
#endif
        /// <summary>The requestedAt property</summary>
        public DateTimeOffset? RequestedAt { get; set; }
        /// <summary>The results property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SimplePublicObject>? Results { get; set; }
#nullable restore
#else
        public List<SimplePublicObject> Results { get; set; }
#endif
        /// <summary>The startedAt property</summary>
        public DateTimeOffset? StartedAt { get; set; }
        /// <summary>The status property</summary>
        public BatchResponseSimplePublicObject_status? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BatchResponseSimplePublicObject CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BatchResponseSimplePublicObject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"completedAt", n => { CompletedAt = n.GetDateTimeOffsetValue(); } },
                {"links", n => { Links = n.GetObjectValue<BatchResponseSimplePublicObject_links>(BatchResponseSimplePublicObject_links.CreateFromDiscriminatorValue); } },
                {"requestedAt", n => { RequestedAt = n.GetDateTimeOffsetValue(); } },
                {"results", n => { Results = n.GetCollectionOfObjectValues<SimplePublicObject>(SimplePublicObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"startedAt", n => { StartedAt = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetEnumValue<BatchResponseSimplePublicObject_status>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("completedAt", CompletedAt);
            writer.WriteObjectValue<BatchResponseSimplePublicObject_links>("links", Links);
            writer.WriteDateTimeOffsetValue("requestedAt", RequestedAt);
            writer.WriteCollectionOfObjectValues<SimplePublicObject>("results", Results);
            writer.WriteDateTimeOffsetValue("startedAt", StartedAt);
            writer.WriteEnumValue<BatchResponseSimplePublicObject_status>("status", Status);
        }
    }
}
