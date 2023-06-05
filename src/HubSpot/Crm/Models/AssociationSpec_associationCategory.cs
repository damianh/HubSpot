using System.Runtime.Serialization;
using System;
namespace HubSpot.Crm.Models {
    public enum AssociationSpec_associationCategory {
        [EnumMember(Value = "HUBSPOT_DEFINED")]
        HUBSPOT_DEFINED,
        [EnumMember(Value = "USER_DEFINED")]
        USER_DEFINED,
        [EnumMember(Value = "INTEGRATOR_DEFINED")]
        INTEGRATOR_DEFINED,
    }
}
