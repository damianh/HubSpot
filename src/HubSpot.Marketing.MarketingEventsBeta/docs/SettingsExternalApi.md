# HubSpot.Marketing.MarketingEventsBeta.Api.SettingsExternalApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetMarketingV3MarketingEventsAppIdSettingsGetAll**](SettingsExternalApi.md#getmarketingv3marketingeventsappidsettingsgetall) | **GET** /marketing/v3/marketing-events/{appId}/settings |  |
| [**PostMarketingV3MarketingEventsAppIdSettingsCreate**](SettingsExternalApi.md#postmarketingv3marketingeventsappidsettingscreate) | **POST** /marketing/v3/marketing-events/{appId}/settings |  |

<a id="getmarketingv3marketingeventsappidsettingsgetall"></a>
# **GetMarketingV3MarketingEventsAppIdSettingsGetAll**
> EventDetailSettings GetMarketingV3MarketingEventsAppIdSettingsGetAll (int appId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Marketing.MarketingEventsBeta.Api;
using HubSpot.Marketing.MarketingEventsBeta.Client;
using HubSpot.Marketing.MarketingEventsBeta.Model;

namespace Example
{
    public class GetMarketingV3MarketingEventsAppIdSettingsGetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new SettingsExternalApi(config);
            var appId = 56;  // int | 

            try
            {
                EventDetailSettings result = apiInstance.GetMarketingV3MarketingEventsAppIdSettingsGetAll(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsExternalApi.GetMarketingV3MarketingEventsAppIdSettingsGetAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMarketingV3MarketingEventsAppIdSettingsGetAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EventDetailSettings> response = apiInstance.GetMarketingV3MarketingEventsAppIdSettingsGetAllWithHttpInfo(appId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsExternalApi.GetMarketingV3MarketingEventsAppIdSettingsGetAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appId** | **int** |  |  |

### Return type

[**EventDetailSettings**](EventDetailSettings.md)

### Authorization

[hapikey](../README.md#hapikey), [developer_hapikey](../README.md#developer_hapikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postmarketingv3marketingeventsappidsettingscreate"></a>
# **PostMarketingV3MarketingEventsAppIdSettingsCreate**
> EventDetailSettings PostMarketingV3MarketingEventsAppIdSettingsCreate (int appId, EventDetailSettingsUrl eventDetailSettingsUrl)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Marketing.MarketingEventsBeta.Api;
using HubSpot.Marketing.MarketingEventsBeta.Client;
using HubSpot.Marketing.MarketingEventsBeta.Model;

namespace Example
{
    public class PostMarketingV3MarketingEventsAppIdSettingsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new SettingsExternalApi(config);
            var appId = 56;  // int | 
            var eventDetailSettingsUrl = new EventDetailSettingsUrl(); // EventDetailSettingsUrl | 

            try
            {
                EventDetailSettings result = apiInstance.PostMarketingV3MarketingEventsAppIdSettingsCreate(appId, eventDetailSettingsUrl);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsExternalApi.PostMarketingV3MarketingEventsAppIdSettingsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostMarketingV3MarketingEventsAppIdSettingsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EventDetailSettings> response = apiInstance.PostMarketingV3MarketingEventsAppIdSettingsCreateWithHttpInfo(appId, eventDetailSettingsUrl);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsExternalApi.PostMarketingV3MarketingEventsAppIdSettingsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appId** | **int** |  |  |
| **eventDetailSettingsUrl** | [**EventDetailSettingsUrl**](EventDetailSettingsUrl.md) |  |  |

### Return type

[**EventDetailSettings**](EventDetailSettings.md)

### Authorization

[hapikey](../README.md#hapikey), [developer_hapikey](../README.md#developer_hapikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

