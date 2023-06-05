using System.Runtime.Serialization;
using System;
namespace HubSpot.Crm.Models {
    public enum BatchResponseSimplePublicObject_status {
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
