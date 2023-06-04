# HubSpot.Marketing.MarketingEventsBeta.Api.SearchApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetMarketingV3MarketingEventsEventsSearchDoSearch**](SearchApi.md#getmarketingv3marketingeventseventssearchdosearch) | **GET** /marketing/v3/marketing-events/events/search | Search for marketing events |

<a id="getmarketingv3marketingeventseventssearchdosearch"></a>
# **GetMarketingV3MarketingEventsEventsSearchDoSearch**
> CollectionResponseMarketingEventExternalUniqueIdentifierNoPaging GetMarketingV3MarketingEventsEventsSearchDoSearch (string q)

Search for marketing events

Search for marketing events that have an event id that starts with the query string

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Marketing.MarketingEventsBeta.Api;
using HubSpot.Marketing.MarketingEventsBeta.Client;
using HubSpot.Marketing.MarketingEventsBeta.Model;

namespace Example
{
    public class GetMarketingV3MarketingEventsEventsSearchDoSearchExample
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

            var apiInstance = new SearchApi(config);
            var q = "q_example";  // string | The id of the marketing event in the external event application

            try
            {
                // Search for marketing events
                CollectionResponseMarketingEventExternalUniqueIdentifierNoPaging result = apiInstance.GetMarketingV3MarketingEventsEventsSearchDoSearch(q);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.GetMarketingV3MarketingEventsEventsSearchDoSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMarketingV3MarketingEventsEventsSearchDoSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for marketing events
    ApiResponse<CollectionResponseMarketingEventExternalUniqueIdentifierNoPaging> response = apiInstance.GetMarketingV3MarketingEventsEventsSearchDoSearchWithHttpInfo(q);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.GetMarketingV3MarketingEventsEventsSearchDoSearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **q** | **string** | The id of the marketing event in the external event application |  |

### Return type

[**CollectionResponseMarketingEventExternalUniqueIdentifierNoPaging**](CollectionResponseMarketingEventExternalUniqueIdentifierNoPaging.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

