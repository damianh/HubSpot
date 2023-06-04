# HubSpot.Cms.Performance.Api.PublicPerformanceApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCmsV3PerformanceGetPage**](PublicPerformanceApi.md#getcmsv3performancegetpage) | **GET** /cms/v3/performance/ | View your website&#39;s performance. |
| [**GetCmsV3PerformanceUptimeGetUptime**](PublicPerformanceApi.md#getcmsv3performanceuptimegetuptime) | **GET** /cms/v3/performance/uptime | View your website&#39;s uptime. |

<a id="getcmsv3performancegetpage"></a>
# **GetCmsV3PerformanceGetPage**
> PublicPerformanceResponse GetCmsV3PerformanceGetPage (string domain = null, string path = null, bool? pad = null, bool? sum = null, string period = null, string interval = null, long? start = null, long? end = null)

View your website's performance.

Returns time series data website performance data for the given domain and/or path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Performance.Api;
using HubSpot.Cms.Performance.Client;
using HubSpot.Cms.Performance.Model;

namespace Example
{
    public class GetCmsV3PerformanceGetPageExample
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

            var apiInstance = new PublicPerformanceApi(config);
            var domain = "domain_example";  // string | The domain to search return data for. (optional) 
            var path = "path_example";  // string | The url path of the domain to return data for. (optional) 
            var pad = true;  // bool? | Specifies whether the time series data should have empty intervals if performance data is not present to create a continuous set. (optional) 
            var sum = true;  // bool? | Specifies whether the time series data should be summated for the given period. Defaults to false. (optional) 
            var period = "period_example";  // string | A relative period to return time series data for. This value is ignored if start and/or end are provided. Valid periods: [15m, 30m, 1h, 4h, 12h, 1d, 1w] (optional) 
            var interval = "interval_example";  // string | The time series interval to group data by. Valid intervals: [1m, 5m, 15m, 30m, 1h, 4h, 12h, 1d, 1w] (optional) 
            var start = 789L;  // long? | A timestamp in milliseconds that indicates the start of the time period. (optional) 
            var end = 789L;  // long? | A timestamp in milliseconds that indicates the end of the time period. (optional) 

            try
            {
                // View your website's performance.
                PublicPerformanceResponse result = apiInstance.GetCmsV3PerformanceGetPage(domain, path, pad, sum, period, interval, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicPerformanceApi.GetCmsV3PerformanceGetPage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCmsV3PerformanceGetPageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // View your website's performance.
    ApiResponse<PublicPerformanceResponse> response = apiInstance.GetCmsV3PerformanceGetPageWithHttpInfo(domain, path, pad, sum, period, interval, start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicPerformanceApi.GetCmsV3PerformanceGetPageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domain** | **string** | The domain to search return data for. | [optional]  |
| **path** | **string** | The url path of the domain to return data for. | [optional]  |
| **pad** | **bool?** | Specifies whether the time series data should have empty intervals if performance data is not present to create a continuous set. | [optional]  |
| **sum** | **bool?** | Specifies whether the time series data should be summated for the given period. Defaults to false. | [optional]  |
| **period** | **string** | A relative period to return time series data for. This value is ignored if start and/or end are provided. Valid periods: [15m, 30m, 1h, 4h, 12h, 1d, 1w] | [optional]  |
| **interval** | **string** | The time series interval to group data by. Valid intervals: [1m, 5m, 15m, 30m, 1h, 4h, 12h, 1d, 1w] | [optional]  |
| **start** | **long?** | A timestamp in milliseconds that indicates the start of the time period. | [optional]  |
| **end** | **long?** | A timestamp in milliseconds that indicates the end of the time period. | [optional]  |

### Return type

[**PublicPerformanceResponse**](PublicPerformanceResponse.md)

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

<a id="getcmsv3performanceuptimegetuptime"></a>
# **GetCmsV3PerformanceUptimeGetUptime**
> PublicPerformanceResponse GetCmsV3PerformanceUptimeGetUptime (string domain = null, string path = null, bool? pad = null, bool? sum = null, string period = null, string interval = null, long? start = null, long? end = null)

View your website's uptime.

Returns uptime time series website performance data for the given domain.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Performance.Api;
using HubSpot.Cms.Performance.Client;
using HubSpot.Cms.Performance.Model;

namespace Example
{
    public class GetCmsV3PerformanceUptimeGetUptimeExample
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

            var apiInstance = new PublicPerformanceApi(config);
            var domain = "domain_example";  // string | The domain to search return data for. (optional) 
            var path = "path_example";  // string |  (optional) 
            var pad = true;  // bool? | Specifies whether the time series data should have empty intervals if performance data is not present to create a continuous set. (optional) 
            var sum = true;  // bool? | Specifies whether the time series data should be summated for the given period. Defaults to false. (optional) 
            var period = "period_example";  // string | A relative period to return time series data for. This value is ignored if start and/or end are provided. Valid periods: [15m, 30m, 1h, 4h, 12h, 1d, 1w] (optional) 
            var interval = "interval_example";  // string | The time series interval to group data by. Valid intervals: [1m, 5m, 15m, 30m, 1h, 4h, 12h, 1d, 1w] (optional) 
            var start = 789L;  // long? | A timestamp in milliseconds that indicates the start of the time period. (optional) 
            var end = 789L;  // long? | A timestamp in milliseconds that indicates the end of the time period. (optional) 

            try
            {
                // View your website's uptime.
                PublicPerformanceResponse result = apiInstance.GetCmsV3PerformanceUptimeGetUptime(domain, path, pad, sum, period, interval, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicPerformanceApi.GetCmsV3PerformanceUptimeGetUptime: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCmsV3PerformanceUptimeGetUptimeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // View your website's uptime.
    ApiResponse<PublicPerformanceResponse> response = apiInstance.GetCmsV3PerformanceUptimeGetUptimeWithHttpInfo(domain, path, pad, sum, period, interval, start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicPerformanceApi.GetCmsV3PerformanceUptimeGetUptimeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domain** | **string** | The domain to search return data for. | [optional]  |
| **path** | **string** |  | [optional]  |
| **pad** | **bool?** | Specifies whether the time series data should have empty intervals if performance data is not present to create a continuous set. | [optional]  |
| **sum** | **bool?** | Specifies whether the time series data should be summated for the given period. Defaults to false. | [optional]  |
| **period** | **string** | A relative period to return time series data for. This value is ignored if start and/or end are provided. Valid periods: [15m, 30m, 1h, 4h, 12h, 1d, 1w] | [optional]  |
| **interval** | **string** | The time series interval to group data by. Valid intervals: [1m, 5m, 15m, 30m, 1h, 4h, 12h, 1d, 1w] | [optional]  |
| **start** | **long?** | A timestamp in milliseconds that indicates the start of the time period. | [optional]  |
| **end** | **long?** | A timestamp in milliseconds that indicates the end of the time period. | [optional]  |

### Return type

[**PublicPerformanceResponse**](PublicPerformanceResponse.md)

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

