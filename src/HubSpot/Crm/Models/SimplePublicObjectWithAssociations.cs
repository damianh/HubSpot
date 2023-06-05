using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace HubSpot.Crm.Models {
    public class SimplePublicObjectWithAssociations : IParsable {
        /// <summary>The archived property</summary>
        public bool? Archived { get; set; }
        /// <summary>The archivedAt property</summary>
        public DateTimeOffset? ArchivedAt { get; set; }
        /// <summary>The associations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SimplePublicObjectWithAssociations_associations? Associations { get; set; }
#nullable restore
#else
        public SimplePublicObjectWithAssociations_associations Associations { get; set; }
#endif
        /// <summary>The createdAt property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The properties property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SimplePublicObjectWithAssociations_properties? Properties { get; set; }
#nullable restore
#else
        public SimplePublicObjectWithAssociations_properties Properties { get; set; }
#endif
        /// <summary>The propertiesWithHistory property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SimplePublicObjectWithAssociations_propertiesWithHistory? PropertiesWithHistory { get; set; }
#nullable restore
#else
        public SimplePublicObjectWithAssociations_propertiesWithHistory PropertiesWithHistory { get; set; }
#endif
        /// <summary>The updatedAt property</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SimplePublicObjectWithAssociations CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SimplePublicObjectWithAssociations();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"archived", n => { Archived = n.GetBoolValue(); } },
                {"archivedAt", n => { ArchivedAt = n.GetDateTimeOffsetValue(); } },
                {"associations", n => { Associations = n.GetObjectValue<SimplePublicObjectWithAssociations_associations>(SimplePublicObjectWithAssociations_associations.CreateFromDiscriminatorValue); } },
                {"createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"properties", n => { Properties = n.GetObjectValue<SimplePublicObjectWithAssociations_properties>(SimplePublicObjectWithAssociations_properties.CreateFromDiscriminatorValue); } },
                {"propertiesWithHistory", n => { PropertiesWithHistory = n.GetObjectValue<SimplePublicObjectWithAssociations_propertiesWithHistory>(SimplePublicObjectWithAssociations_propertiesWithHistory.CreateFromDiscriminatorValue); } },
                {"updatedAt", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("archived", Archived);
            writer.WriteDateTimeOffsetValue("archivedAt", ArchivedAt);
            writer.WriteObjectValue<SimplePublicObjectWithAssociations_associations>("associations", Associations);
            writer.WriteDateTimeOffsetValue("createdAt", CreatedAt);
            writer.WriteStringValue("id", Id);
            writer.WriteObjectValue<SimplePublicObjectWithAssociations_properties>("properties", Properties);
            writer.WriteObjectValue<SimplePublicObjectWithAssociations_propertiesWithHistory>("propertiesWithHistory", PropertiesWithHistory);
            writer.WriteDateTimeOffsetValue("updatedAt", UpdatedAt);
        }
    }
}
