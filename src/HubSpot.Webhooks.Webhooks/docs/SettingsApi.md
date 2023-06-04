# HubSpot.Webhooks.Webhooks.Api.SettingsApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteWebhooksV3AppIdSettingsClear**](SettingsApi.md#deletewebhooksv3appidsettingsclear) | **DELETE** /webhooks/v3/{appId}/settings |  |
| [**GetWebhooksV3AppIdSettingsGetAll**](SettingsApi.md#getwebhooksv3appidsettingsgetall) | **GET** /webhooks/v3/{appId}/settings |  |
| [**PutWebhooksV3AppIdSettingsConfigure**](SettingsApi.md#putwebhooksv3appidsettingsconfigure) | **PUT** /webhooks/v3/{appId}/settings |  |

<a id="deletewebhooksv3appidsettingsclear"></a>
# **DeleteWebhooksV3AppIdSettingsClear**
> void DeleteWebhooksV3AppIdSettingsClear (int appId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Webhooks.Webhooks.Api;
using HubSpot.Webhooks.Webhooks.Client;
using HubSpot.Webhooks.Webhooks.Model;

namespace Example
{
    public class DeleteWebhooksV3AppIdSettingsClearExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new SettingsApi(config);
            var appId = 56;  // int | 

            try
            {
                apiInstance.DeleteWebhooksV3AppIdSettingsClear(appId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.DeleteWebhooksV3AppIdSettingsClear: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWebhooksV3AppIdSettingsClearWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeleteWebhooksV3AppIdSettingsClearWithHttpInfo(appId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.DeleteWebhooksV3AppIdSettingsClearWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appId** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

[developer_hapikey](../README.md#developer_hapikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getwebhooksv3appidsettingsgetall"></a>
# **GetWebhooksV3AppIdSettingsGetAll**
> SettingsResponse GetWebhooksV3AppIdSettingsGetAll (int appId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Webhooks.Webhooks.Api;
using HubSpot.Webhooks.Webhooks.Client;
using HubSpot.Webhooks.Webhooks.Model;

namespace Example
{
    public class GetWebhooksV3AppIdSettingsGetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new SettingsApi(config);
            var appId = 56;  // int | 

            try
            {
                SettingsResponse result = apiInstance.GetWebhooksV3AppIdSettingsGetAll(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetWebhooksV3AppIdSettingsGetAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWebhooksV3AppIdSettingsGetAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SettingsResponse> response = apiInstance.GetWebhooksV3AppIdSettingsGetAllWithHttpInfo(appId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.GetWebhooksV3AppIdSettingsGetAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appId** | **int** |  |  |

### Return type

[**SettingsResponse**](SettingsResponse.md)

### Authorization

[developer_hapikey](../README.md#developer_hapikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putwebhooksv3appidsettingsconfigure"></a>
# **PutWebhooksV3AppIdSettingsConfigure**
> SettingsResponse PutWebhooksV3AppIdSettingsConfigure (int appId, SettingsChangeRequest settingsChangeRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Webhooks.Webhooks.Api;
using HubSpot.Webhooks.Webhooks.Client;
using HubSpot.Webhooks.Webhooks.Model;

namespace Example
{
    public class PutWebhooksV3AppIdSettingsConfigureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: developer_hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new SettingsApi(config);
            var appId = 56;  // int | 
            var settingsChangeRequest = new SettingsChangeRequest(); // SettingsChangeRequest | 

            try
            {
                SettingsResponse result = apiInstance.PutWebhooksV3AppIdSettingsConfigure(appId, settingsChangeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.PutWebhooksV3AppIdSettingsConfigure: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutWebhooksV3AppIdSettingsConfigureWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SettingsResponse> response = apiInstance.PutWebhooksV3AppIdSettingsConfigureWithHttpInfo(appId, settingsChangeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.PutWebhooksV3AppIdSettingsConfigureWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appId** | **int** |  |  |
| **settingsChangeRequest** | [**SettingsChangeRequest**](SettingsChangeRequest.md) |  |  |

### Return type

[**SettingsResponse**](SettingsResponse.md)

### Authorization

[developer_hapikey](../README.md#developer_hapikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

