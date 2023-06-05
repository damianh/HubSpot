using System.Runtime.Serialization;
using System;
namespace HubSpot.Associations.Models {
    public enum BatchResponsePublicAssociationMulti_status {
        [EnumMember(Value = "PENDING")]
        PENDING,
        [EnumMember(Value = "PROCESSING")]
        PROCESSING,
        [EnumMember(Value = "CANCELED")]
        CANCELED,
        [EnumMember(Value = "COMPLETE")]
        COMPLETE,
    }
}
