using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace HubSpot.Crm.Models {
    public class BatchInputSimplePublicObjectBatchInput : IParsable {
        /// <summary>The inputs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SimplePublicObjectBatchInput>? Inputs { get; set; }
#nullable restore
#else
        public List<SimplePublicObjectBatchInput> Inputs { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BatchInputSimplePublicObjectBatchInput CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BatchInputSimplePublicObjectBatchInput();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"inputs", n => { Inputs = n.GetCollectionOfObjectValues<SimplePublicObjectBatchInput>(SimplePublicObjectBatchInput.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<SimplePublicObjectBatchInput>("inputs", Inputs);
        }
    }
}
