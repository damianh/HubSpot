# HubSpot.Crm.Videoconferencing.Api.SettingsApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteCrmV3ExtensionsVideoconferencingSettingsAppIdArchive**](SettingsApi.md#deletecrmv3extensionsvideoconferencingsettingsappidarchive) | **DELETE** /crm/v3/extensions/videoconferencing/settings/{appId} | Delete settings |
| [**GetCrmV3ExtensionsVideoconferencingSettingsAppIdGetById**](SettingsApi.md#getcrmv3extensionsvideoconferencingsettingsappidgetbyid) | **GET** /crm/v3/extensions/videoconferencing/settings/{appId} | Get settings |
| [**PutCrmV3ExtensionsVideoconferencingSettingsAppIdReplace**](SettingsApi.md#putcrmv3extensionsvideoconferencingsettingsappidreplace) | **PUT** /crm/v3/extensions/videoconferencing/settings/{appId} | Update settings |

<a id="deletecrmv3extensionsvideoconferencingsettingsappidarchive"></a>
# **DeleteCrmV3ExtensionsVideoconferencingSettingsAppIdArchive**
> void DeleteCrmV3ExtensionsVideoconferencingSettingsAppIdArchive (int appId)

Delete settings

Deletes the settings for a video conference application with the specified ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Videoconferencing.Api;
using HubSpot.Crm.Videoconferencing.Client;
using HubSpot.Crm.Videoconferencing.Model;

namespace Example
{
    public class DeleteCrmV3ExtensionsVideoconferencingSettingsAppIdArchiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new SettingsApi(config);
            var appId = 56;  // int | The ID of the video conference application. This is the identifier of the application created in your HubSpot developer portal.

            try
            {
                // Delete settings
                apiInstance.DeleteCrmV3ExtensionsVideoconferencingSettingsAppIdArchive(appId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.DeleteCrmV3ExtensionsVideoconferencingSettingsAppIdArchive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCrmV3ExtensionsVideoconferencingSettingsAppIdArchiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete settings
    apiInstance.DeleteCrmV3ExtensionsVideoconferencingSettingsAppIdArchiveWithHttpInfo(appId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.DeleteCrmV3ExtensionsVideoconferencingSettingsAppIdArchiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appId** | **int** | The ID of the video conference application. This is the identifier of the application created in your HubSpot developer portal. |  |

### Return type

void (empty response body)

### Authorization

[hapikey](../README.md#hapikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcrmv3extensionsvideoconferencingsettingsappidgetbyid"></a>
# **GetCrmV3ExtensionsVideoconferencingSettingsAppIdGetById**
> ExternalSettings GetCrmV3ExtensionsVideoconferencingSettingsAppIdGetById (int appId)

Get settings

Return the settings for a video conference application with the specified ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Videoconferencing.Api;
using HubSpot.Crm.Videoconferencing.Client;
using HubSpot.Crm.Videoconferencing.Model;

namespace Example
{
    public class GetCrmV3ExtensionsVideoconferencingSettingsAppIdGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new SettingsApi(config);
            var appId = 56;  // int | The ID of the video conference application. This is the identifier of the application created in your HubSpot developer portal.

            try
            {
                // Get settings
                ExternalSettings result = apiInstance.GetCrmV3ExtensionsVideoconferencingSettingsAppIdGetById(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetCrmV3ExtensionsVideoconferencingSettingsAppIdGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCrmV3ExtensionsVideoconferencingSettingsAppIdGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get settings
    ApiResponse<ExternalSettings> response = apiInstance.GetCrmV3ExtensionsVideoconferencingSettingsAppIdGetByIdWithHttpInfo(appId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.GetCrmV3ExtensionsVideoconferencingSettingsAppIdGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appId** | **int** | The ID of the video conference application. This is the identifier of the application created in your HubSpot developer portal. |  |

### Return type

[**ExternalSettings**](ExternalSettings.md)

### Authorization

[hapikey](../README.md#hapikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putcrmv3extensionsvideoconferencingsettingsappidreplace"></a>
# **PutCrmV3ExtensionsVideoconferencingSettingsAppIdReplace**
> ExternalSettings PutCrmV3ExtensionsVideoconferencingSettingsAppIdReplace (int appId, ExternalSettings externalSettings)

Update settings

Updates the settings for a video conference application with the specified ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Videoconferencing.Api;
using HubSpot.Crm.Videoconferencing.Client;
using HubSpot.Crm.Videoconferencing.Model;

namespace Example
{
    public class PutCrmV3ExtensionsVideoconferencingSettingsAppIdReplaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");

            var apiInstance = new SettingsApi(config);
            var appId = 56;  // int | The ID of the video conference application. This is the identifier of the application created in your HubSpot developer portal.
            var externalSettings = new ExternalSettings(); // ExternalSettings | 

            try
            {
                // Update settings
                ExternalSettings result = apiInstance.PutCrmV3ExtensionsVideoconferencingSettingsAppIdReplace(appId, externalSettings);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.PutCrmV3ExtensionsVideoconferencingSettingsAppIdReplace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutCrmV3ExtensionsVideoconferencingSettingsAppIdReplaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update settings
    ApiResponse<ExternalSettings> response = apiInstance.PutCrmV3ExtensionsVideoconferencingSettingsAppIdReplaceWithHttpInfo(appId, externalSettings);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.PutCrmV3ExtensionsVideoconferencingSettingsAppIdReplaceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appId** | **int** | The ID of the video conference application. This is the identifier of the application created in your HubSpot developer portal. |  |
| **externalSettings** | [**ExternalSettings**](ExternalSettings.md) |  |  |

### Return type

[**ExternalSettings**](ExternalSettings.md)

### Authorization

[hapikey](../README.md#hapikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

