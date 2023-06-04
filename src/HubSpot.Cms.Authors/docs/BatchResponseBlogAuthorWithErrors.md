# HubSpot.Cms.Authors.Model.BatchResponseBlogAuthorWithErrors
Response object for batch operations on blog authors with errors.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Status of batch operation. | 
**Results** | [**List&lt;BlogAuthor&gt;**](BlogAuthor.md) | Results of batch operation. | 
**NumErrors** | **int** | Number of errors. | [optional] 
**Errors** | [**List&lt;StandardError&gt;**](StandardError.md) | Errors in batch operation. | [optional] 
**RequestedAt** | **DateTime** | Time of batch operation request. | [optional] 
**StartedAt** | **DateTime** | Time of batch operation start. | 
**CompletedAt** | **DateTime** | Time of batch operation completion. | 
**Links** | **Dictionary&lt;string, string&gt;** | Links associated with batch operation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

