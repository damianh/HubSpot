# HubSpot.Crm.Accounting.Api.SyncApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostCrmV3ExtensionsAccountingSyncAppIdContactsCreateContact**](SyncApi.md#postcrmv3extensionsaccountingsyncappidcontactscreatecontact) | **POST** /crm/v3/extensions/accounting/sync/{appId}/contacts | Import contacts |
| [**PostCrmV3ExtensionsAccountingSyncAppIdProductsCreateProduct**](SyncApi.md#postcrmv3extensionsaccountingsyncappidproductscreateproduct) | **POST** /crm/v3/extensions/accounting/sync/{appId}/products | Import products |

<a id="postcrmv3extensionsaccountingsyncappidcontactscreatecontact"></a>
# **PostCrmV3ExtensionsAccountingSyncAppIdContactsCreateContact**
> ActionResponse PostCrmV3ExtensionsAccountingSyncAppIdContactsCreateContact (int appId, SyncContactsRequest syncContactsRequest)

Import contacts

Imports contacts' properties from an external accounting system to HubSpot. Import details, including property mappings, must be configured previously in HubSpot infrastructure.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Accounting.Api;
using HubSpot.Crm.Accounting.Client;
using HubSpot.Crm.Accounting.Model;

namespace Example
{
    public class PostCrmV3ExtensionsAccountingSyncAppIdContactsCreateContactExample
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

            var apiInstance = new SyncApi(config);
            var appId = 56;  // int | The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.
            var syncContactsRequest = new SyncContactsRequest(); // SyncContactsRequest | 

            try
            {
                // Import contacts
                ActionResponse result = apiInstance.PostCrmV3ExtensionsAccountingSyncAppIdContactsCreateContact(appId, syncContactsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SyncApi.PostCrmV3ExtensionsAccountingSyncAppIdContactsCreateContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ExtensionsAccountingSyncAppIdContactsCreateContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import contacts
    ApiResponse<ActionResponse> response = apiInstance.PostCrmV3ExtensionsAccountingSyncAppIdContactsCreateContactWithHttpInfo(appId, syncContactsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SyncApi.PostCrmV3ExtensionsAccountingSyncAppIdContactsCreateContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appId** | **int** | The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal. |  |
| **syncContactsRequest** | [**SyncContactsRequest**](SyncContactsRequest.md) |  |  |

### Return type

[**ActionResponse**](ActionResponse.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcrmv3extensionsaccountingsyncappidproductscreateproduct"></a>
# **PostCrmV3ExtensionsAccountingSyncAppIdProductsCreateProduct**
> ActionResponse PostCrmV3ExtensionsAccountingSyncAppIdProductsCreateProduct (int appId, SyncProductsRequest syncProductsRequest)

Import products

Imports products' properties from an external accounting system to HubSpot. Import details, including property mappings, must be configured previously in HubSpot infrastructure.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Accounting.Api;
using HubSpot.Crm.Accounting.Client;
using HubSpot.Crm.Accounting.Model;

namespace Example
{
    public class PostCrmV3ExtensionsAccountingSyncAppIdProductsCreateProductExample
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

            var apiInstance = new SyncApi(config);
            var appId = 56;  // int | The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.
            var syncProductsRequest = new SyncProductsRequest(); // SyncProductsRequest | 

            try
            {
                // Import products
                ActionResponse result = apiInstance.PostCrmV3ExtensionsAccountingSyncAppIdProductsCreateProduct(appId, syncProductsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SyncApi.PostCrmV3ExtensionsAccountingSyncAppIdProductsCreateProduct: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ExtensionsAccountingSyncAppIdProductsCreateProductWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import products
    ApiResponse<ActionResponse> response = apiInstance.PostCrmV3ExtensionsAccountingSyncAppIdProductsCreateProductWithHttpInfo(appId, syncProductsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SyncApi.PostCrmV3ExtensionsAccountingSyncAppIdProductsCreateProductWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appId** | **int** | The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal. |  |
| **syncProductsRequest** | [**SyncProductsRequest**](SyncProductsRequest.md) |  |  |

### Return type

[**ActionResponse**](ActionResponse.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

