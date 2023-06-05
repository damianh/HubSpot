using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace HubSpot.Associations.Models {
    public class Paging : IParsable {
        /// <summary>The next property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NextPage? Next { get; set; }
#nullable restore
#else
        public NextPage Next { get; set; }
#endif
        /// <summary>The prev property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PreviousPage? Prev { get; set; }
#nullable restore
#else
        public PreviousPage Prev { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Paging CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Paging();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"next", n => { Next = n.GetObjectValue<NextPage>(NextPage.CreateFromDiscriminatorValue); } },
                {"prev", n => { Prev = n.GetObjectValue<PreviousPage>(PreviousPage.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<NextPage>("next", Next);
            writer.WriteObjectValue<PreviousPage>("prev", Prev);
        }
    }
}
