# HubSpot.Crm.FeedbackSubmissions.Api.BatchApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostCrmV3ObjectsFeedbackSubmissionsBatchArchiveArchive**](BatchApi.md#postcrmv3objectsfeedbacksubmissionsbatcharchivearchive) | **POST** /crm/v3/objects/feedback_submissions/batch/archive | Archive a batch of feedback submissions by ID |
| [**PostCrmV3ObjectsFeedbackSubmissionsBatchCreateCreate**](BatchApi.md#postcrmv3objectsfeedbacksubmissionsbatchcreatecreate) | **POST** /crm/v3/objects/feedback_submissions/batch/create | Create a batch of feedback submissions |
| [**PostCrmV3ObjectsFeedbackSubmissionsBatchReadRead**](BatchApi.md#postcrmv3objectsfeedbacksubmissionsbatchreadread) | **POST** /crm/v3/objects/feedback_submissions/batch/read | Read a batch of feedback submissions by internal ID, or unique property values |
| [**PostCrmV3ObjectsFeedbackSubmissionsBatchUpdateUpdate**](BatchApi.md#postcrmv3objectsfeedbacksubmissionsbatchupdateupdate) | **POST** /crm/v3/objects/feedback_submissions/batch/update | Update a batch of feedback submissions |

<a id="postcrmv3objectsfeedbacksubmissionsbatcharchivearchive"></a>
# **PostCrmV3ObjectsFeedbackSubmissionsBatchArchiveArchive**
> void PostCrmV3ObjectsFeedbackSubmissionsBatchArchiveArchive (BatchInputSimplePublicObjectId batchInputSimplePublicObjectId)

Archive a batch of feedback submissions by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.FeedbackSubmissions.Api;
using HubSpot.Crm.FeedbackSubmissions.Client;
using HubSpot.Crm.FeedbackSubmissions.Model;

namespace Example
{
    public class PostCrmV3ObjectsFeedbackSubmissionsBatchArchiveArchiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: private_apps
            config.AddApiKey("private-app", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app", "Bearer");

            var apiInstance = new BatchApi(config);
            var batchInputSimplePublicObjectId = new BatchInputSimplePublicObjectId(); // BatchInputSimplePublicObjectId | 

            try
            {
                // Archive a batch of feedback submissions by ID
                apiInstance.PostCrmV3ObjectsFeedbackSubmissionsBatchArchiveArchive(batchInputSimplePublicObjectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsFeedbackSubmissionsBatchArchiveArchive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsFeedbackSubmissionsBatchArchiveArchiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Archive a batch of feedback submissions by ID
    apiInstance.PostCrmV3ObjectsFeedbackSubmissionsBatchArchiveArchiveWithHttpInfo(batchInputSimplePublicObjectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsFeedbackSubmissionsBatchArchiveArchiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchInputSimplePublicObjectId** | [**BatchInputSimplePublicObjectId**](BatchInputSimplePublicObjectId.md) |  |  |

### Return type

void (empty response body)

### Authorization

[hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcrmv3objectsfeedbacksubmissionsbatchcreatecreate"></a>
# **PostCrmV3ObjectsFeedbackSubmissionsBatchCreateCreate**
> BatchResponseSimplePublicObject PostCrmV3ObjectsFeedbackSubmissionsBatchCreateCreate (BatchInputSimplePublicObjectInputForCreate batchInputSimplePublicObjectInputForCreate)

Create a batch of feedback submissions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.FeedbackSubmissions.Api;
using HubSpot.Crm.FeedbackSubmissions.Client;
using HubSpot.Crm.FeedbackSubmissions.Model;

namespace Example
{
    public class PostCrmV3ObjectsFeedbackSubmissionsBatchCreateCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: private_apps
            config.AddApiKey("private-app", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app", "Bearer");

            var apiInstance = new BatchApi(config);
            var batchInputSimplePublicObjectInputForCreate = new BatchInputSimplePublicObjectInputForCreate(); // BatchInputSimplePublicObjectInputForCreate | 

            try
            {
                // Create a batch of feedback submissions
                BatchResponseSimplePublicObject result = apiInstance.PostCrmV3ObjectsFeedbackSubmissionsBatchCreateCreate(batchInputSimplePublicObjectInputForCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsFeedbackSubmissionsBatchCreateCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsFeedbackSubmissionsBatchCreateCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a batch of feedback submissions
    ApiResponse<BatchResponseSimplePublicObject> response = apiInstance.PostCrmV3ObjectsFeedbackSubmissionsBatchCreateCreateWithHttpInfo(batchInputSimplePublicObjectInputForCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsFeedbackSubmissionsBatchCreateCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchInputSimplePublicObjectInputForCreate** | [**BatchInputSimplePublicObjectInputForCreate**](BatchInputSimplePublicObjectInputForCreate.md) |  |  |

### Return type

[**BatchResponseSimplePublicObject**](BatchResponseSimplePublicObject.md)

### Authorization

[hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | successful operation |  -  |
| **207** | multiple statuses |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcrmv3objectsfeedbacksubmissionsbatchreadread"></a>
# **PostCrmV3ObjectsFeedbackSubmissionsBatchReadRead**
> BatchResponseSimplePublicObject PostCrmV3ObjectsFeedbackSubmissionsBatchReadRead (BatchReadInputSimplePublicObjectId batchReadInputSimplePublicObjectId, bool? archived = null)

Read a batch of feedback submissions by internal ID, or unique property values

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.FeedbackSubmissions.Api;
using HubSpot.Crm.FeedbackSubmissions.Client;
using HubSpot.Crm.FeedbackSubmissions.Model;

namespace Example
{
    public class PostCrmV3ObjectsFeedbackSubmissionsBatchReadReadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: private_apps
            config.AddApiKey("private-app", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app", "Bearer");

            var apiInstance = new BatchApi(config);
            var batchReadInputSimplePublicObjectId = new BatchReadInputSimplePublicObjectId(); // BatchReadInputSimplePublicObjectId | 
            var archived = false;  // bool? | Whether to return only results that have been archived. (optional)  (default to false)

            try
            {
                // Read a batch of feedback submissions by internal ID, or unique property values
                BatchResponseSimplePublicObject result = apiInstance.PostCrmV3ObjectsFeedbackSubmissionsBatchReadRead(batchReadInputSimplePublicObjectId, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsFeedbackSubmissionsBatchReadRead: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsFeedbackSubmissionsBatchReadReadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read a batch of feedback submissions by internal ID, or unique property values
    ApiResponse<BatchResponseSimplePublicObject> response = apiInstance.PostCrmV3ObjectsFeedbackSubmissionsBatchReadReadWithHttpInfo(batchReadInputSimplePublicObjectId, archived);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsFeedbackSubmissionsBatchReadReadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchReadInputSimplePublicObjectId** | [**BatchReadInputSimplePublicObjectId**](BatchReadInputSimplePublicObjectId.md) |  |  |
| **archived** | **bool?** | Whether to return only results that have been archived. | [optional] [default to false] |

### Return type

[**BatchResponseSimplePublicObject**](BatchResponseSimplePublicObject.md)

### Authorization

[hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **207** | multiple statuses |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcrmv3objectsfeedbacksubmissionsbatchupdateupdate"></a>
# **PostCrmV3ObjectsFeedbackSubmissionsBatchUpdateUpdate**
> BatchResponseSimplePublicObject PostCrmV3ObjectsFeedbackSubmissionsBatchUpdateUpdate (BatchInputSimplePublicObjectBatchInput batchInputSimplePublicObjectBatchInput)

Update a batch of feedback submissions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.FeedbackSubmissions.Api;
using HubSpot.Crm.FeedbackSubmissions.Client;
using HubSpot.Crm.FeedbackSubmissions.Model;

namespace Example
{
    public class PostCrmV3ObjectsFeedbackSubmissionsBatchUpdateUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: private_apps
            config.AddApiKey("private-app", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app", "Bearer");

            var apiInstance = new BatchApi(config);
            var batchInputSimplePublicObjectBatchInput = new BatchInputSimplePublicObjectBatchInput(); // BatchInputSimplePublicObjectBatchInput | 

            try
            {
                // Update a batch of feedback submissions
                BatchResponseSimplePublicObject result = apiInstance.PostCrmV3ObjectsFeedbackSubmissionsBatchUpdateUpdate(batchInputSimplePublicObjectBatchInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsFeedbackSubmissionsBatchUpdateUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsFeedbackSubmissionsBatchUpdateUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a batch of feedback submissions
    ApiResponse<BatchResponseSimplePublicObject> response = apiInstance.PostCrmV3ObjectsFeedbackSubmissionsBatchUpdateUpdateWithHttpInfo(batchInputSimplePublicObjectBatchInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsFeedbackSubmissionsBatchUpdateUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchInputSimplePublicObjectBatchInput** | [**BatchInputSimplePublicObjectBatchInput**](BatchInputSimplePublicObjectBatchInput.md) |  |  |

### Return type

[**BatchResponseSimplePublicObject**](BatchResponseSimplePublicObject.md)

### Authorization

[hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **207** | multiple statuses |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

