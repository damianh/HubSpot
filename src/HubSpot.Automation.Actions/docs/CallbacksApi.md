# HubSpot.Automation.Actions.Api.CallbacksApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostAutomationV4ActionsCallbacksCallbackIdCompleteComplete**](CallbacksApi.md#postautomationv4actionscallbackscallbackidcompletecomplete) | **POST** /automation/v4/actions/callbacks/{callbackId}/complete | Complete a callback |
| [**PostAutomationV4ActionsCallbacksCompleteCompleteBatch**](CallbacksApi.md#postautomationv4actionscallbackscompletecompletebatch) | **POST** /automation/v4/actions/callbacks/complete | Complete a batch of callbacks |

<a id="postautomationv4actionscallbackscallbackidcompletecomplete"></a>
# **PostAutomationV4ActionsCallbacksCallbackIdCompleteComplete**
> void PostAutomationV4ActionsCallbacksCallbackIdCompleteComplete (string callbackId, CallbackCompletionRequest callbackCompletionRequest)

Complete a callback

Completes the given action callback.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Automation.Actions.Api;
using HubSpot.Automation.Actions.Client;
using HubSpot.Automation.Actions.Model;

namespace Example
{
    public class PostAutomationV4ActionsCallbacksCallbackIdCompleteCompleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure OAuth2 access token for authorization: oauth2_legacy
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");
            // Configure API key authorization: private_apps_legacy
            config.AddApiKey("private-app-legacy", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app-legacy", "Bearer");

            var apiInstance = new CallbacksApi(config);
            var callbackId = "callbackId_example";  // string | The ID of the target app.
            var callbackCompletionRequest = new CallbackCompletionRequest(); // CallbackCompletionRequest | The result of the completed action.

            try
            {
                // Complete a callback
                apiInstance.PostAutomationV4ActionsCallbacksCallbackIdCompleteComplete(callbackId, callbackCompletionRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallbacksApi.PostAutomationV4ActionsCallbacksCallbackIdCompleteComplete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostAutomationV4ActionsCallbacksCallbackIdCompleteCompleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Complete a callback
    apiInstance.PostAutomationV4ActionsCallbacksCallbackIdCompleteCompleteWithHttpInfo(callbackId, callbackCompletionRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallbacksApi.PostAutomationV4ActionsCallbacksCallbackIdCompleteCompleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **callbackId** | **string** | The ID of the target app. |  |
| **callbackCompletionRequest** | [**CallbackCompletionRequest**](CallbackCompletionRequest.md) | The result of the completed action. |  |

### Return type

void (empty response body)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postautomationv4actionscallbackscompletecompletebatch"></a>
# **PostAutomationV4ActionsCallbacksCompleteCompleteBatch**
> void PostAutomationV4ActionsCallbacksCompleteCompleteBatch (BatchInputCallbackCompletionBatchRequest batchInputCallbackCompletionBatchRequest)

Complete a batch of callbacks

Completes the given action callbacks.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Automation.Actions.Api;
using HubSpot.Automation.Actions.Client;
using HubSpot.Automation.Actions.Model;

namespace Example
{
    public class PostAutomationV4ActionsCallbacksCompleteCompleteBatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure OAuth2 access token for authorization: oauth2_legacy
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");
            // Configure API key authorization: private_apps_legacy
            config.AddApiKey("private-app-legacy", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app-legacy", "Bearer");

            var apiInstance = new CallbacksApi(config);
            var batchInputCallbackCompletionBatchRequest = new BatchInputCallbackCompletionBatchRequest(); // BatchInputCallbackCompletionBatchRequest | The result of the completed action.

            try
            {
                // Complete a batch of callbacks
                apiInstance.PostAutomationV4ActionsCallbacksCompleteCompleteBatch(batchInputCallbackCompletionBatchRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallbacksApi.PostAutomationV4ActionsCallbacksCompleteCompleteBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostAutomationV4ActionsCallbacksCompleteCompleteBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Complete a batch of callbacks
    apiInstance.PostAutomationV4ActionsCallbacksCompleteCompleteBatchWithHttpInfo(batchInputCallbackCompletionBatchRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallbacksApi.PostAutomationV4ActionsCallbacksCompleteCompleteBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchInputCallbackCompletionBatchRequest** | [**BatchInputCallbackCompletionBatchRequest**](BatchInputCallbackCompletionBatchRequest.md) | The result of the completed action. |  |

### Return type

void (empty response body)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

