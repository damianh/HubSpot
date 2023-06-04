# HubSpot.Events.Events.Api.EventsApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetEventsV3EventsGetPage**](EventsApi.md#geteventsv3eventsgetpage) | **GET** /events/v3/events | Returns a collection of events matching a query. |

<a id="geteventsv3eventsgetpage"></a>
# **GetEventsV3EventsGetPage**
> CollectionResponseExternalUnifiedEvent GetEventsV3EventsGetPage (DateTime? occurredAfter = null, DateTime? occurredBefore = null, string objectType = null, long? objectId = null, string eventType = null, string after = null, string before = null, int? limit = null, List<string> sort = null)

Returns a collection of events matching a query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Events.Events.Api;
using HubSpot.Events.Events.Client;
using HubSpot.Events.Events.Model;

namespace Example
{
    public class GetEventsV3EventsGetPageExample
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

            var apiInstance = new EventsApi(config);
            var occurredAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | The starting time as an ISO 8601 timestamp. (optional) 
            var occurredBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | The ending time as an ISO 8601 timestamp. (optional) 
            var objectType = "objectType_example";  // string | The type of object being selected. Valid values are hubspot named object types (e.g. `contact`). (optional) 
            var objectId = 789L;  // long? | The id of the selected object. If not present, then the `objectProperty` parameter is required. (optional) 
            var eventType = "eventType_example";  // string | Limits the response to the specified event type.  For example `&eventType=e_visited_page` returns only `e_visited_page` events.  If not present all event types are returned. (optional) 
            var after = "after_example";  // string | An additional parameter that may be used to get the next `limit` set of results. (optional) 
            var before = "before_example";  // string |  (optional) 
            var limit = 56;  // int? | The maximum number of events to return, defaults to 20. (optional) 
            var sort = new List<string>(); // List<string> | Selects the sort field and order. Defaults to ascending, prefix with `-` for descending order. `occurredAt` is the only field supported for sorting. (optional) 

            try
            {
                // Returns a collection of events matching a query.
                CollectionResponseExternalUnifiedEvent result = apiInstance.GetEventsV3EventsGetPage(occurredAfter, occurredBefore, objectType, objectId, eventType, after, before, limit, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.GetEventsV3EventsGetPage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEventsV3EventsGetPageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns a collection of events matching a query.
    ApiResponse<CollectionResponseExternalUnifiedEvent> response = apiInstance.GetEventsV3EventsGetPageWithHttpInfo(occurredAfter, occurredBefore, objectType, objectId, eventType, after, before, limit, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.GetEventsV3EventsGetPageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **occurredAfter** | **DateTime?** | The starting time as an ISO 8601 timestamp. | [optional]  |
| **occurredBefore** | **DateTime?** | The ending time as an ISO 8601 timestamp. | [optional]  |
| **objectType** | **string** | The type of object being selected. Valid values are hubspot named object types (e.g. &#x60;contact&#x60;). | [optional]  |
| **objectId** | **long?** | The id of the selected object. If not present, then the &#x60;objectProperty&#x60; parameter is required. | [optional]  |
| **eventType** | **string** | Limits the response to the specified event type.  For example &#x60;&amp;eventType&#x3D;e_visited_page&#x60; returns only &#x60;e_visited_page&#x60; events.  If not present all event types are returned. | [optional]  |
| **after** | **string** | An additional parameter that may be used to get the next &#x60;limit&#x60; set of results. | [optional]  |
| **before** | **string** |  | [optional]  |
| **limit** | **int?** | The maximum number of events to return, defaults to 20. | [optional]  |
| **sort** | [**List&lt;string&gt;**](string.md) | Selects the sort field and order. Defaults to ascending, prefix with &#x60;-&#x60; for descending order. &#x60;occurredAt&#x60; is the only field supported for sorting. | [optional]  |

### Return type

[**CollectionResponseExternalUnifiedEvent**](CollectionResponseExternalUnifiedEvent.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

