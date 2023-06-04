# HubSpot.Crm.Properties.Model.PropertyCreate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The internal property name, which must be used when referencing the property via the API. | 
**Label** | **string** | A human-readable property label that will be shown in HubSpot. | 
**Type** | **string** | The data type of the property. | 
**FieldType** | **string** | Controls how the property appears in HubSpot. | 
**GroupName** | **string** | The name of the property group the property belongs to. | 
**Description** | **string** | A description of the property that will be shown as help text in HubSpot. | [optional] 
**Options** | [**List&lt;OptionInput&gt;**](OptionInput.md) | A list of valid options for the property. This field is required for enumerated properties. | [optional] 
**DisplayOrder** | **int** | Properties are displayed in order starting with the lowest positive integer value. Values of -1 will cause the property to be displayed after any positive values. | [optional] 
**HasUniqueValue** | **bool** | Whether or not the property&#39;s value must be unique. Once set, this can&#39;t be changed. | [optional] 
**Hidden** | **bool** | If true, the property won&#39;t be visible and can&#39;t be used in HubSpot. | [optional] 
**FormField** | **bool** | Whether or not the property can be used in a HubSpot form. | [optional] 
**ExternalOptions** | **bool** | Applicable only for &#39;enumeration&#39; type properties.  Should be set to true in conjunction with a &#39;referencedObjectType&#39; of &#39;OWNER&#39;.  Otherwise false. | [optional] 
**ReferencedObjectType** | **string** | Should be set to &#39;OWNER&#39; when &#39;externalOptions&#39; is true, which causes the property to dynamically pull option values from the current HubSpot users. | [optional] 
**CalculationFormula** | **string** | Represents a formula that is used to compute a calculated property. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

