using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace HubSpot.Companies.Models {
    public class AssociationSpec : IParsable {
        /// <summary>The associationCategory property</summary>
        public AssociationSpec_associationCategory? AssociationCategory { get; set; }
        /// <summary>The associationTypeId property</summary>
        public int? AssociationTypeId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AssociationSpec CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssociationSpec();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"associationCategory", n => { AssociationCategory = n.GetEnumValue<AssociationSpec_associationCategory>(); } },
                {"associationTypeId", n => { AssociationTypeId = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AssociationSpec_associationCategory>("associationCategory", AssociationCategory);
            writer.WriteIntValue("associationTypeId", AssociationTypeId);
        }
    }
}
