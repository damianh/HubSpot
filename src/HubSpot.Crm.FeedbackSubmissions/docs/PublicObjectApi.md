# HubSpot.Crm.FeedbackSubmissions.Api.PublicObjectApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostCrmV3ObjectsFeedbackSubmissionsMergeMerge**](PublicObjectApi.md#postcrmv3objectsfeedbacksubmissionsmergemerge) | **POST** /crm/v3/objects/feedback_submissions/merge | Merge two feedback submissions with same type |

<a id="postcrmv3objectsfeedbacksubmissionsmergemerge"></a>
# **PostCrmV3ObjectsFeedbackSubmissionsMergeMerge**
> SimplePublicObject PostCrmV3ObjectsFeedbackSubmissionsMergeMerge (PublicMergeInput publicMergeInput)

Merge two feedback submissions with same type

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.FeedbackSubmissions.Api;
using HubSpot.Crm.FeedbackSubmissions.Client;
using HubSpot.Crm.FeedbackSubmissions.Model;

namespace Example
{
    public class PostCrmV3ObjectsFeedbackSubmissionsMergeMergeExample
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

            var apiInstance = new PublicObjectApi(config);
            var publicMergeInput = new PublicMergeInput(); // PublicMergeInput | 

            try
            {
                // Merge two feedback submissions with same type
                SimplePublicObject result = apiInstance.PostCrmV3ObjectsFeedbackSubmissionsMergeMerge(publicMergeInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicObjectApi.PostCrmV3ObjectsFeedbackSubmissionsMergeMerge: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsFeedbackSubmissionsMergeMergeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Merge two feedback submissions with same type
    ApiResponse<SimplePublicObject> response = apiInstance.PostCrmV3ObjectsFeedbackSubmissionsMergeMergeWithHttpInfo(publicMergeInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicObjectApi.PostCrmV3ObjectsFeedbackSubmissionsMergeMergeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publicMergeInput** | [**PublicMergeInput**](PublicMergeInput.md) |  |  |

### Return type

[**SimplePublicObject**](SimplePublicObject.md)

### Authorization

[hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

