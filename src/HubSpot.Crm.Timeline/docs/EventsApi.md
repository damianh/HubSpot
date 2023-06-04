# HubSpot.Crm.Timeline.Api.EventsApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetIntegratorsTimelineV3EventsEventTemplateIdEventIdDetailGetDetailById**](EventsApi.md#getintegratorstimelinev3eventseventtemplateideventiddetailgetdetailbyid) | **GET** /crm/v3/timeline/events/{eventTemplateId}/{eventId}/detail | Gets the detailTemplate as rendered |
| [**GetIntegratorsTimelineV3EventsEventTemplateIdEventIdGetById**](EventsApi.md#getintegratorstimelinev3eventseventtemplateideventidgetbyid) | **GET** /crm/v3/timeline/events/{eventTemplateId}/{eventId} | Gets the event |
| [**GetIntegratorsTimelineV3EventsEventTemplateIdEventIdRenderGetRenderById**](EventsApi.md#getintegratorstimelinev3eventseventtemplateideventidrendergetrenderbyid) | **GET** /crm/v3/timeline/events/{eventTemplateId}/{eventId}/render | Renders the header or detail as HTML |
| [**PostIntegratorsTimelineV3EventsBatchCreateCreateBatch**](EventsApi.md#postintegratorstimelinev3eventsbatchcreatecreatebatch) | **POST** /crm/v3/timeline/events/batch/create | Creates multiple events |
| [**PostIntegratorsTimelineV3EventsCreate**](EventsApi.md#postintegratorstimelinev3eventscreate) | **POST** /crm/v3/timeline/events | Create a single event |

<a id="getintegratorstimelinev3eventseventtemplateideventiddetailgetdetailbyid"></a>
# **GetIntegratorsTimelineV3EventsEventTemplateIdEventIdDetailGetDetailById**
> EventDetail GetIntegratorsTimelineV3EventsEventTemplateIdEventIdDetailGetDetailById (string eventTemplateId, string eventId)

Gets the detailTemplate as rendered

This will take the `detailTemplate` from the event template and return an object rendering the specified event. If the template references `extraData` that isn't found in the event, it will be ignored and we'll render without it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Timeline.Api;
using HubSpot.Crm.Timeline.Client;
using HubSpot.Crm.Timeline.Model;

namespace Example
{
    public class GetIntegratorsTimelineV3EventsEventTemplateIdEventIdDetailGetDetailByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure OAuth2 access token for authorization: oauth2_legacy
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: private_apps_legacy
            config.AddApiKey("private-app-legacy", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app-legacy", "Bearer");
            // Configure API key authorization: private_apps
            config.AddApiKey("private-app", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app", "Bearer");

            var apiInstance = new EventsApi(config);
            var eventTemplateId = "eventTemplateId_example";  // string | The event template ID.
            var eventId = "eventId_example";  // string | The event ID.

            try
            {
                // Gets the detailTemplate as rendered
                EventDetail result = apiInstance.GetIntegratorsTimelineV3EventsEventTemplateIdEventIdDetailGetDetailById(eventTemplateId, eventId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.GetIntegratorsTimelineV3EventsEventTemplateIdEventIdDetailGetDetailById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIntegratorsTimelineV3EventsEventTemplateIdEventIdDetailGetDetailByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the detailTemplate as rendered
    ApiResponse<EventDetail> response = apiInstance.GetIntegratorsTimelineV3EventsEventTemplateIdEventIdDetailGetDetailByIdWithHttpInfo(eventTemplateId, eventId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.GetIntegratorsTimelineV3EventsEventTemplateIdEventIdDetailGetDetailByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventTemplateId** | **string** | The event template ID. |  |
| **eventId** | **string** | The event ID. |  |

### Return type

[**EventDetail**](EventDetail.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [oauth2](../README.md#oauth2), [private_apps_legacy](../README.md#private_apps_legacy), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getintegratorstimelinev3eventseventtemplateideventidgetbyid"></a>
# **GetIntegratorsTimelineV3EventsEventTemplateIdEventIdGetById**
> TimelineEventResponse GetIntegratorsTimelineV3EventsEventTemplateIdEventIdGetById (string eventTemplateId, string eventId)

Gets the event

This returns the previously created event. It contains all existing info for the event, but not necessarily the CRM object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Timeline.Api;
using HubSpot.Crm.Timeline.Client;
using HubSpot.Crm.Timeline.Model;

namespace Example
{
    public class GetIntegratorsTimelineV3EventsEventTemplateIdEventIdGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure OAuth2 access token for authorization: oauth2_legacy
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: private_apps_legacy
            config.AddApiKey("private-app-legacy", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app-legacy", "Bearer");
            // Configure API key authorization: private_apps
            config.AddApiKey("private-app", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app", "Bearer");

            var apiInstance = new EventsApi(config);
            var eventTemplateId = "eventTemplateId_example";  // string | The event template ID.
            var eventId = "eventId_example";  // string | The event ID.

            try
            {
                // Gets the event
                TimelineEventResponse result = apiInstance.GetIntegratorsTimelineV3EventsEventTemplateIdEventIdGetById(eventTemplateId, eventId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.GetIntegratorsTimelineV3EventsEventTemplateIdEventIdGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIntegratorsTimelineV3EventsEventTemplateIdEventIdGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the event
    ApiResponse<TimelineEventResponse> response = apiInstance.GetIntegratorsTimelineV3EventsEventTemplateIdEventIdGetByIdWithHttpInfo(eventTemplateId, eventId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.GetIntegratorsTimelineV3EventsEventTemplateIdEventIdGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventTemplateId** | **string** | The event template ID. |  |
| **eventId** | **string** | The event ID. |  |

### Return type

[**TimelineEventResponse**](TimelineEventResponse.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [oauth2](../README.md#oauth2), [private_apps_legacy](../README.md#private_apps_legacy), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getintegratorstimelinev3eventseventtemplateideventidrendergetrenderbyid"></a>
# **GetIntegratorsTimelineV3EventsEventTemplateIdEventIdRenderGetRenderById**
> string GetIntegratorsTimelineV3EventsEventTemplateIdEventIdRenderGetRenderById (string eventTemplateId, string eventId, bool? detail = null)

Renders the header or detail as HTML

This will take either the `headerTemplate` or `detailTemplate` from the event template and render for the specified event as HTML. If the template references `extraData` that isn't found in the event, it will be ignored and we'll render without it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Timeline.Api;
using HubSpot.Crm.Timeline.Client;
using HubSpot.Crm.Timeline.Model;

namespace Example
{
    public class GetIntegratorsTimelineV3EventsEventTemplateIdEventIdRenderGetRenderByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure OAuth2 access token for authorization: oauth2_legacy
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: private_apps_legacy
            config.AddApiKey("private-app-legacy", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app-legacy", "Bearer");
            // Configure API key authorization: private_apps
            config.AddApiKey("private-app", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app", "Bearer");

            var apiInstance = new EventsApi(config);
            var eventTemplateId = "eventTemplateId_example";  // string | The event template ID.
            var eventId = "eventId_example";  // string | The event ID.
            var detail = true;  // bool? | Set to 'true', we want to render the `detailTemplate` instead of the `headerTemplate`. (optional) 

            try
            {
                // Renders the header or detail as HTML
                string result = apiInstance.GetIntegratorsTimelineV3EventsEventTemplateIdEventIdRenderGetRenderById(eventTemplateId, eventId, detail);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.GetIntegratorsTimelineV3EventsEventTemplateIdEventIdRenderGetRenderById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIntegratorsTimelineV3EventsEventTemplateIdEventIdRenderGetRenderByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Renders the header or detail as HTML
    ApiResponse<string> response = apiInstance.GetIntegratorsTimelineV3EventsEventTemplateIdEventIdRenderGetRenderByIdWithHttpInfo(eventTemplateId, eventId, detail);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.GetIntegratorsTimelineV3EventsEventTemplateIdEventIdRenderGetRenderByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventTemplateId** | **string** | The event template ID. |  |
| **eventId** | **string** | The event ID. |  |
| **detail** | **bool?** | Set to &#39;true&#39;, we want to render the &#x60;detailTemplate&#x60; instead of the &#x60;headerTemplate&#x60;. | [optional]  |

### Return type

**string**

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [oauth2](../README.md#oauth2), [private_apps_legacy](../README.md#private_apps_legacy), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/html, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postintegratorstimelinev3eventsbatchcreatecreatebatch"></a>
# **PostIntegratorsTimelineV3EventsBatchCreateCreateBatch**
> BatchResponseTimelineEventResponse PostIntegratorsTimelineV3EventsBatchCreateCreateBatch (BatchInputTimelineEvent batchInputTimelineEvent)

Creates multiple events

Creates multiple instances of timeline events based on an event template. Once created, these event are immutable on the object timeline and cannot be modified. If the event template was configured to update object properties via `objectPropertyName`, this call will also attempt to updates those properties, or add them if they don't exist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Timeline.Api;
using HubSpot.Crm.Timeline.Client;
using HubSpot.Crm.Timeline.Model;

namespace Example
{
    public class PostIntegratorsTimelineV3EventsBatchCreateCreateBatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure OAuth2 access token for authorization: oauth2_legacy
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: private_apps_legacy
            config.AddApiKey("private-app-legacy", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app-legacy", "Bearer");
            // Configure API key authorization: private_apps
            config.AddApiKey("private-app", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app", "Bearer");

            var apiInstance = new EventsApi(config);
            var batchInputTimelineEvent = new BatchInputTimelineEvent(); // BatchInputTimelineEvent | The timeline event definition.

            try
            {
                // Creates multiple events
                BatchResponseTimelineEventResponse result = apiInstance.PostIntegratorsTimelineV3EventsBatchCreateCreateBatch(batchInputTimelineEvent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.PostIntegratorsTimelineV3EventsBatchCreateCreateBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostIntegratorsTimelineV3EventsBatchCreateCreateBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates multiple events
    ApiResponse<BatchResponseTimelineEventResponse> response = apiInstance.PostIntegratorsTimelineV3EventsBatchCreateCreateBatchWithHttpInfo(batchInputTimelineEvent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.PostIntegratorsTimelineV3EventsBatchCreateCreateBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchInputTimelineEvent** | [**BatchInputTimelineEvent**](BatchInputTimelineEvent.md) | The timeline event definition. |  |

### Return type

[**BatchResponseTimelineEventResponse**](BatchResponseTimelineEventResponse.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [oauth2](../README.md#oauth2), [private_apps_legacy](../README.md#private_apps_legacy), [private_apps](../README.md#private_apps)

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

<a id="postintegratorstimelinev3eventscreate"></a>
# **PostIntegratorsTimelineV3EventsCreate**
> TimelineEventResponse PostIntegratorsTimelineV3EventsCreate (TimelineEvent timelineEvent)

Create a single event

Creates an instance of a timeline event based on an event template. Once created, this event is immutable on the object timeline and cannot be modified. If the event template was configured to update object properties via `objectPropertyName`, this call will also attempt to updates those properties, or add them if they don't exist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Timeline.Api;
using HubSpot.Crm.Timeline.Client;
using HubSpot.Crm.Timeline.Model;

namespace Example
{
    public class PostIntegratorsTimelineV3EventsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure OAuth2 access token for authorization: oauth2_legacy
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: private_apps_legacy
            config.AddApiKey("private-app-legacy", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app-legacy", "Bearer");
            // Configure API key authorization: private_apps
            config.AddApiKey("private-app", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app", "Bearer");

            var apiInstance = new EventsApi(config);
            var timelineEvent = new TimelineEvent(); // TimelineEvent | The timeline event definition.

            try
            {
                // Create a single event
                TimelineEventResponse result = apiInstance.PostIntegratorsTimelineV3EventsCreate(timelineEvent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.PostIntegratorsTimelineV3EventsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostIntegratorsTimelineV3EventsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a single event
    ApiResponse<TimelineEventResponse> response = apiInstance.PostIntegratorsTimelineV3EventsCreateWithHttpInfo(timelineEvent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.PostIntegratorsTimelineV3EventsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **timelineEvent** | [**TimelineEvent**](TimelineEvent.md) | The timeline event definition. |  |

### Return type

[**TimelineEventResponse**](TimelineEventResponse.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [oauth2](../README.md#oauth2), [private_apps_legacy](../README.md#private_apps_legacy), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

