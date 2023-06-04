# HubSpot.Marketing.MarketingEventsBeta.Api.AttendanceSubscriberStateChangesApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostMarketingV3MarketingEventsAttendanceExternalEventIdSubscriberStateCreateCreate**](AttendanceSubscriberStateChangesApi.md#postmarketingv3marketingeventsattendanceexternaleventidsubscriberstatecreatecreate) | **POST** /marketing/v3/marketing-events/attendance/{externalEventId}/{subscriberState}/create | Record |
| [**PostMarketingV3MarketingEventsAttendanceExternalEventIdSubscriberStateEmailCreateCreateByEmail**](AttendanceSubscriberStateChangesApi.md#postmarketingv3marketingeventsattendanceexternaleventidsubscriberstateemailcreatecreatebyemail) | **POST** /marketing/v3/marketing-events/attendance/{externalEventId}/{subscriberState}/email-create | Record |

<a id="postmarketingv3marketingeventsattendanceexternaleventidsubscriberstatecreatecreate"></a>
# **PostMarketingV3MarketingEventsAttendanceExternalEventIdSubscriberStateCreateCreate**
> BatchResponseSubscriberVidResponse PostMarketingV3MarketingEventsAttendanceExternalEventIdSubscriberStateCreateCreate (string externalEventId, string subscriberState, BatchInputMarketingEventSubscriber batchInputMarketingEventSubscriber, string externalAccountId = null)

Record

Record a subscription state between multiple HubSpot contacts and a marketing event, using HubSpot contact ids.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Marketing.MarketingEventsBeta.Api;
using HubSpot.Marketing.MarketingEventsBeta.Client;
using HubSpot.Marketing.MarketingEventsBeta.Model;

namespace Example
{
    public class PostMarketingV3MarketingEventsAttendanceExternalEventIdSubscriberStateCreateCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure OAuth2 access token for authorization: oauth2_legacy
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: private_apps_legacy
            config.AddApiKey("private-app-legacy", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app-legacy", "Bearer");

            var apiInstance = new AttendanceSubscriberStateChangesApi(config);
            var externalEventId = "externalEventId_example";  // string | The id of the marketing event
            var subscriberState = "subscriberState_example";  // string | The new subscriber state for the HubSpot contacts and the specified marketing event. For example: 'register', 'attend' or 'cancel'.
            var batchInputMarketingEventSubscriber = new BatchInputMarketingEventSubscriber(); // BatchInputMarketingEventSubscriber | The details of the contacts to subscribe to the event. Parameters of join and left time if state is Attended.
            var externalAccountId = "externalAccountId_example";  // string | The account id associated with the marketing event (optional) 

            try
            {
                // Record
                BatchResponseSubscriberVidResponse result = apiInstance.PostMarketingV3MarketingEventsAttendanceExternalEventIdSubscriberStateCreateCreate(externalEventId, subscriberState, batchInputMarketingEventSubscriber, externalAccountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttendanceSubscriberStateChangesApi.PostMarketingV3MarketingEventsAttendanceExternalEventIdSubscriberStateCreateCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostMarketingV3MarketingEventsAttendanceExternalEventIdSubscriberStateCreateCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Record
    ApiResponse<BatchResponseSubscriberVidResponse> response = apiInstance.PostMarketingV3MarketingEventsAttendanceExternalEventIdSubscriberStateCreateCreateWithHttpInfo(externalEventId, subscriberState, batchInputMarketingEventSubscriber, externalAccountId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttendanceSubscriberStateChangesApi.PostMarketingV3MarketingEventsAttendanceExternalEventIdSubscriberStateCreateCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **externalEventId** | **string** | The id of the marketing event |  |
| **subscriberState** | **string** | The new subscriber state for the HubSpot contacts and the specified marketing event. For example: &#39;register&#39;, &#39;attend&#39; or &#39;cancel&#39;. |  |
| **batchInputMarketingEventSubscriber** | [**BatchInputMarketingEventSubscriber**](BatchInputMarketingEventSubscriber.md) | The details of the contacts to subscribe to the event. Parameters of join and left time if state is Attended. |  |
| **externalAccountId** | **string** | The account id associated with the marketing event | [optional]  |

### Return type

[**BatchResponseSubscriberVidResponse**](BatchResponseSubscriberVidResponse.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postmarketingv3marketingeventsattendanceexternaleventidsubscriberstateemailcreatecreatebyemail"></a>
# **PostMarketingV3MarketingEventsAttendanceExternalEventIdSubscriberStateEmailCreateCreateByEmail**
> BatchResponseSubscriberEmailResponse PostMarketingV3MarketingEventsAttendanceExternalEventIdSubscriberStateEmailCreateCreateByEmail (string externalEventId, string subscriberState, BatchInputMarketingEventEmailSubscriber batchInputMarketingEventEmailSubscriber, string externalAccountId = null)

Record

Record a subscription state between multiple HubSpot contacts and a marketing event, using contact email addresses. If contact is not present it will be automatically created. If you set params 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Marketing.MarketingEventsBeta.Api;
using HubSpot.Marketing.MarketingEventsBeta.Client;
using HubSpot.Marketing.MarketingEventsBeta.Model;

namespace Example
{
    public class PostMarketingV3MarketingEventsAttendanceExternalEventIdSubscriberStateEmailCreateCreateByEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure OAuth2 access token for authorization: oauth2_legacy
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: private_apps_legacy
            config.AddApiKey("private-app-legacy", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app-legacy", "Bearer");

            var apiInstance = new AttendanceSubscriberStateChangesApi(config);
            var externalEventId = "externalEventId_example";  // string | The id of the marketing event
            var subscriberState = "subscriberState_example";  // string | The new subscriber state for the HubSpot contacts and the specified marketing event. For example: 'register', 'attend' or 'cancel'.
            var batchInputMarketingEventEmailSubscriber = new BatchInputMarketingEventEmailSubscriber(); // BatchInputMarketingEventEmailSubscriber | The details of the contacts to subscribe to the event. Parameters of join and left time if state is Attended.
            var externalAccountId = "externalAccountId_example";  // string | The account id associated with the marketing event (optional) 

            try
            {
                // Record
                BatchResponseSubscriberEmailResponse result = apiInstance.PostMarketingV3MarketingEventsAttendanceExternalEventIdSubscriberStateEmailCreateCreateByEmail(externalEventId, subscriberState, batchInputMarketingEventEmailSubscriber, externalAccountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttendanceSubscriberStateChangesApi.PostMarketingV3MarketingEventsAttendanceExternalEventIdSubscriberStateEmailCreateCreateByEmail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostMarketingV3MarketingEventsAttendanceExternalEventIdSubscriberStateEmailCreateCreateByEmailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Record
    ApiResponse<BatchResponseSubscriberEmailResponse> response = apiInstance.PostMarketingV3MarketingEventsAttendanceExternalEventIdSubscriberStateEmailCreateCreateByEmailWithHttpInfo(externalEventId, subscriberState, batchInputMarketingEventEmailSubscriber, externalAccountId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttendanceSubscriberStateChangesApi.PostMarketingV3MarketingEventsAttendanceExternalEventIdSubscriberStateEmailCreateCreateByEmailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **externalEventId** | **string** | The id of the marketing event |  |
| **subscriberState** | **string** | The new subscriber state for the HubSpot contacts and the specified marketing event. For example: &#39;register&#39;, &#39;attend&#39; or &#39;cancel&#39;. |  |
| **batchInputMarketingEventEmailSubscriber** | [**BatchInputMarketingEventEmailSubscriber**](BatchInputMarketingEventEmailSubscriber.md) | The details of the contacts to subscribe to the event. Parameters of join and left time if state is Attended. |  |
| **externalAccountId** | **string** | The account id associated with the marketing event | [optional]  |

### Return type

[**BatchResponseSubscriberEmailResponse**](BatchResponseSubscriberEmailResponse.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

