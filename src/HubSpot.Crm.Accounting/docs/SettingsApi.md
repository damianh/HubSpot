# HubSpot.Crm.Accounting.Api.SettingsApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCrmV3ExtensionsAccountingSettingsAppIdGetById**](SettingsApi.md#getcrmv3extensionsaccountingsettingsappidgetbyid) | **GET** /crm/v3/extensions/accounting/settings/{appId} | Get URL settings |
| [**PutCrmV3ExtensionsAccountingSettingsAppIdReplace**](SettingsApi.md#putcrmv3extensionsaccountingsettingsappidreplace) | **PUT** /crm/v3/extensions/accounting/settings/{appId} | Add/Update URL Settings |

<a id="getcrmv3extensionsaccountingsettingsappidgetbyid"></a>
# **GetCrmV3ExtensionsAccountingSettingsAppIdGetById**
> AccountingAppSettings GetCrmV3ExtensionsAccountingSettingsAppIdGetById (int appId)

Get URL settings

Returns the URL settings for an accounting app with the specified ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Accounting.Api;
using HubSpot.Crm.Accounting.Client;
using HubSpot.Crm.Accounting.Model;

namespace Example
{
    public class GetCrmV3ExtensionsAccountingSettingsAppIdGetByIdExample
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
            var appId = 56;  // int | The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.

            try
            {
                // Get URL settings
                AccountingAppSettings result = apiInstance.GetCrmV3ExtensionsAccountingSettingsAppIdGetById(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetCrmV3ExtensionsAccountingSettingsAppIdGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCrmV3ExtensionsAccountingSettingsAppIdGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get URL settings
    ApiResponse<AccountingAppSettings> response = apiInstance.GetCrmV3ExtensionsAccountingSettingsAppIdGetByIdWithHttpInfo(appId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.GetCrmV3ExtensionsAccountingSettingsAppIdGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appId** | **int** | The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal. |  |

### Return type

[**AccountingAppSettings**](AccountingAppSettings.md)

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

<a id="putcrmv3extensionsaccountingsettingsappidreplace"></a>
# **PutCrmV3ExtensionsAccountingSettingsAppIdReplace**
> void PutCrmV3ExtensionsAccountingSettingsAppIdReplace (int appId, AccountingAppSettings accountingAppSettings)

Add/Update URL Settings

Add/Update the URL settings for an accounting app with the specified ID.  All URLs must use the `https` protocol.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Accounting.Api;
using HubSpot.Crm.Accounting.Client;
using HubSpot.Crm.Accounting.Model;

namespace Example
{
    public class PutCrmV3ExtensionsAccountingSettingsAppIdReplaceExample
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
            var appId = 56;  // int | The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.
            var accountingAppSettings = new AccountingAppSettings(); // AccountingAppSettings | 

            try
            {
                // Add/Update URL Settings
                apiInstance.PutCrmV3ExtensionsAccountingSettingsAppIdReplace(appId, accountingAppSettings);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.PutCrmV3ExtensionsAccountingSettingsAppIdReplace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutCrmV3ExtensionsAccountingSettingsAppIdReplaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add/Update URL Settings
    apiInstance.PutCrmV3ExtensionsAccountingSettingsAppIdReplaceWithHttpInfo(appId, accountingAppSettings);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.PutCrmV3ExtensionsAccountingSettingsAppIdReplaceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appId** | **int** | The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal. |  |
| **accountingAppSettings** | [**AccountingAppSettings**](AccountingAppSettings.md) |  |  |

### Return type

void (empty response body)

### Authorization

[hapikey](../README.md#hapikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

