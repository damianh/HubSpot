# HubSpot.Marketing.Transactional.Model.EmailSendStatusView
Describes the status of an email send request.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StatusId** | **string** | Identifier used to query the status of the send. | 
**SendResult** | **string** | Result of the send. | [optional] 
**RequestedAt** | **DateTime** | Time when the send was requested. | [optional] 
**StartedAt** | **DateTime** | Time when the send began processing. | [optional] 
**CompletedAt** | **DateTime** | Time when the send was completed. | [optional] 
**Status** | **string** | Status of the send request. | 
**EventId** | [**EventIdView**](EventIdView.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

