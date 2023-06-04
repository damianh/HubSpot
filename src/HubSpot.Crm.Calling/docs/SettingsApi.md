# HubSpot.Crm.Calling.Api.SettingsApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteCrmV3ExtensionsCallingAppIdSettingsArchive**](SettingsApi.md#deletecrmv3extensionscallingappidsettingsarchive) | **DELETE** /crm/v3/extensions/calling/{appId}/settings | Delete calling settings |
| [**GetCrmV3ExtensionsCallingAppIdSettingsGetById**](SettingsApi.md#getcrmv3extensionscallingappidsettingsgetbyid) | **GET** /crm/v3/extensions/calling/{appId}/settings | Get calling settings |
| [**PatchCrmV3ExtensionsCallingAppIdSettingsUpdate**](SettingsApi.md#patchcrmv3extensionscallingappidsettingsupdate) | **PATCH** /crm/v3/extensions/calling/{appId}/settings | Update settings |
| [**PostCrmV3ExtensionsCallingAppIdSettingsCreate**](SettingsApi.md#postcrmv3extensionscallingappidsettingscreate) | **POST** /crm/v3/extensions/calling/{appId}/settings | Configure a calling extension |

<a id="deletecrmv3extensionscallingappidsettingsarchive"></a>
# **DeleteCrmV3ExtensionsCallingAppIdSettingsArchive**
> void DeleteCrmV3ExtensionsCallingAppIdSettingsArchive (int appId)

Delete calling settings

Deletes this calling extension. This will remove your service as an option for all connected accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Calling.Api;
using HubSpot.Crm.Calling.Client;
using HubSpot.Crm.Calling.Model;

namespace Example
{
    public class DeleteCrmV3ExtensionsCallingAppIdSettingsArchiveExample
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
            var appId = 56;  // int | The ID of the target app.

            try
            {
                // Delete calling settings
                apiInstance.DeleteCrmV3ExtensionsCallingAppIdSettingsArchive(appId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.DeleteCrmV3ExtensionsCallingAppIdSettingsArchive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCrmV3ExtensionsCallingAppIdSettingsArchiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete calling settings
    apiInstance.DeleteCrmV3ExtensionsCallingAppIdSettingsArchiveWithHttpInfo(appId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.DeleteCrmV3ExtensionsCallingAppIdSettingsArchiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appId** | **int** | The ID of the target app. |  |

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

<a id="getcrmv3extensionscallingappidsettingsgetbyid"></a>
# **GetCrmV3ExtensionsCallingAppIdSettingsGetById**
> SettingsResponse GetCrmV3ExtensionsCallingAppIdSettingsGetById (int appId)

Get calling settings

Returns the calling extension settings configured for your app.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Calling.Api;
using HubSpot.Crm.Calling.Client;
using HubSpot.Crm.Calling.Model;

namespace Example
{
    public class GetCrmV3ExtensionsCallingAppIdSettingsGetByIdExample
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
            var appId = 56;  // int | The ID of the target app.

            try
            {
                // Get calling settings
                SettingsResponse result = apiInstance.GetCrmV3ExtensionsCallingAppIdSettingsGetById(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetCrmV3ExtensionsCallingAppIdSettingsGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCrmV3ExtensionsCallingAppIdSettingsGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get calling settings
    ApiResponse<SettingsResponse> response = apiInstance.GetCrmV3ExtensionsCallingAppIdSettingsGetByIdWithHttpInfo(appId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.GetCrmV3ExtensionsCallingAppIdSettingsGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appId** | **int** | The ID of the target app. |  |

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

<a id="patchcrmv3extensionscallingappidsettingsupdate"></a>
# **PatchCrmV3ExtensionsCallingAppIdSettingsUpdate**
> SettingsResponse PatchCrmV3ExtensionsCallingAppIdSettingsUpdate (int appId, SettingsPatchRequest settingsPatchRequest)

Update settings

Updates existing calling extension settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Calling.Api;
using HubSpot.Crm.Calling.Client;
using HubSpot.Crm.Calling.Model;

namespace Example
{
    public class PatchCrmV3ExtensionsCallingAppIdSettingsUpdateExample
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
            var appId = 56;  // int | The ID of the target app.
            var settingsPatchRequest = new SettingsPatchRequest(); // SettingsPatchRequest | Updated details for the settings.

            try
            {
                // Update settings
                SettingsResponse result = apiInstance.PatchCrmV3ExtensionsCallingAppIdSettingsUpdate(appId, settingsPatchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.PatchCrmV3ExtensionsCallingAppIdSettingsUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchCrmV3ExtensionsCallingAppIdSettingsUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update settings
    ApiResponse<SettingsResponse> response = apiInstance.PatchCrmV3ExtensionsCallingAppIdSettingsUpdateWithHttpInfo(appId, settingsPatchRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.PatchCrmV3ExtensionsCallingAppIdSettingsUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appId** | **int** | The ID of the target app. |  |
| **settingsPatchRequest** | [**SettingsPatchRequest**](SettingsPatchRequest.md) | Updated details for the settings. |  |

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

<a id="postcrmv3extensionscallingappidsettingscreate"></a>
# **PostCrmV3ExtensionsCallingAppIdSettingsCreate**
> SettingsResponse PostCrmV3ExtensionsCallingAppIdSettingsCreate (int appId, SettingsRequest settingsRequest)

Configure a calling extension

Used to set the menu label, target iframe URL, and dimensions for your calling extension.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Calling.Api;
using HubSpot.Crm.Calling.Client;
using HubSpot.Crm.Calling.Model;

namespace Example
{
    public class PostCrmV3ExtensionsCallingAppIdSettingsCreateExample
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
            var appId = 56;  // int | The ID of the target app.
            var settingsRequest = new SettingsRequest(); // SettingsRequest | Settings state to create with.

            try
            {
                // Configure a calling extension
                SettingsResponse result = apiInstance.PostCrmV3ExtensionsCallingAppIdSettingsCreate(appId, settingsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.PostCrmV3ExtensionsCallingAppIdSettingsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ExtensionsCallingAppIdSettingsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Configure a calling extension
    ApiResponse<SettingsResponse> response = apiInstance.PostCrmV3ExtensionsCallingAppIdSettingsCreateWithHttpInfo(appId, settingsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.PostCrmV3ExtensionsCallingAppIdSettingsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appId** | **int** | The ID of the target app. |  |
| **settingsRequest** | [**SettingsRequest**](SettingsRequest.md) | Settings state to create with. |  |

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

