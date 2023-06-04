# HubSpot.Analytics.CustomBehavioralEvents.Api.BehavioralEventsTrackingApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostEventsV3Send**](BehavioralEventsTrackingApi.md#posteventsv3send) | **POST** /events/v3/send | Sends Custom Behavioral Event |

<a id="posteventsv3send"></a>
# **PostEventsV3Send**
> void PostEventsV3Send (BehavioralEventHttpCompletionRequest behavioralEventHttpCompletionRequest)

Sends Custom Behavioral Event

Endpoint to send an instance of a behavioral event

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Analytics.CustomBehavioralEvents.Api;
using HubSpot.Analytics.CustomBehavioralEvents.Client;
using HubSpot.Analytics.CustomBehavioralEvents.Model;

namespace Example
{
    public class PostEventsV3SendExample
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

            var apiInstance = new BehavioralEventsTrackingApi(config);
            var behavioralEventHttpCompletionRequest = new BehavioralEventHttpCompletionRequest(); // BehavioralEventHttpCompletionRequest | 

            try
            {
                // Sends Custom Behavioral Event
                apiInstance.PostEventsV3Send(behavioralEventHttpCompletionRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BehavioralEventsTrackingApi.PostEventsV3Send: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostEventsV3SendWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sends Custom Behavioral Event
    apiInstance.PostEventsV3SendWithHttpInfo(behavioralEventHttpCompletionRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BehavioralEventsTrackingApi.PostEventsV3SendWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **behavioralEventHttpCompletionRequest** | [**BehavioralEventHttpCompletionRequest**](BehavioralEventHttpCompletionRequest.md) |  |  |

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

