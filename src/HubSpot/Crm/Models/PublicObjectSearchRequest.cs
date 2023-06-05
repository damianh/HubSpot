using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace HubSpot.Crm.Models {
    public class PublicObjectSearchRequest : IParsable {
        /// <summary>The after property</summary>
        public int? After { get; set; }
        /// <summary>The filterGroups property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<FilterGroup>? FilterGroups { get; set; }
#nullable restore
#else
        public List<FilterGroup> FilterGroups { get; set; }
#endif
        /// <summary>The limit property</summary>
        public int? Limit { get; set; }
        /// <summary>The properties property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Properties { get; set; }
#nullable restore
#else
        public List<string> Properties { get; set; }
#endif
        /// <summary>The query property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Query { get; set; }
#nullable restore
#else
        public string Query { get; set; }
#endif
        /// <summary>The sorts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Sorts { get; set; }
#nullable restore
#else
        public List<string> Sorts { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PublicObjectSearchRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PublicObjectSearchRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"after", n => { After = n.GetIntValue(); } },
                {"filterGroups", n => { FilterGroups = n.GetCollectionOfObjectValues<FilterGroup>(FilterGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                {"limit", n => { Limit = n.GetIntValue(); } },
                {"properties", n => { Properties = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"query", n => { Query = n.GetStringValue(); } },
                {"sorts", n => { Sorts = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("after", After);
            writer.WriteCollectionOfObjectValues<FilterGroup>("filterGroups", FilterGroups);
            writer.WriteIntValue("limit", Limit);
            writer.WriteCollectionOfPrimitiveValues<string>("properties", Properties);
            writer.WriteStringValue("query", Query);
            writer.WriteCollectionOfPrimitiveValues<string>("sorts", Sorts);
        }
    }
}
