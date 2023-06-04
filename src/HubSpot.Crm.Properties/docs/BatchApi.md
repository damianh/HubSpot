# HubSpot.Crm.Properties.Api.BatchApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostCrmV3PropertiesObjectTypeBatchArchiveArchive**](BatchApi.md#postcrmv3propertiesobjecttypebatcharchivearchive) | **POST** /crm/v3/properties/{objectType}/batch/archive | Archive a batch of properties |
| [**PostCrmV3PropertiesObjectTypeBatchCreateCreate**](BatchApi.md#postcrmv3propertiesobjecttypebatchcreatecreate) | **POST** /crm/v3/properties/{objectType}/batch/create | Create a batch of properties |
| [**PostCrmV3PropertiesObjectTypeBatchReadRead**](BatchApi.md#postcrmv3propertiesobjecttypebatchreadread) | **POST** /crm/v3/properties/{objectType}/batch/read | Read a batch of properties |

<a id="postcrmv3propertiesobjecttypebatcharchivearchive"></a>
# **PostCrmV3PropertiesObjectTypeBatchArchiveArchive**
> void PostCrmV3PropertiesObjectTypeBatchArchiveArchive (string objectType, BatchInputPropertyName batchInputPropertyName)

Archive a batch of properties

Archive a provided list of properties. This method will return a 204 No Content response on success regardless of the initial state of the property (e.g. active, already archived, non-existent).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Properties.Api;
using HubSpot.Crm.Properties.Client;
using HubSpot.Crm.Properties.Model;

namespace Example
{
    public class PostCrmV3PropertiesObjectTypeBatchArchiveArchiveExample
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

            var apiInstance = new BatchApi(config);
            var objectType = "objectType_example";  // string | 
            var batchInputPropertyName = new BatchInputPropertyName(); // BatchInputPropertyName | 

            try
            {
                // Archive a batch of properties
                apiInstance.PostCrmV3PropertiesObjectTypeBatchArchiveArchive(objectType, batchInputPropertyName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV3PropertiesObjectTypeBatchArchiveArchive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3PropertiesObjectTypeBatchArchiveArchiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Archive a batch of properties
    apiInstance.PostCrmV3PropertiesObjectTypeBatchArchiveArchiveWithHttpInfo(objectType, batchInputPropertyName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV3PropertiesObjectTypeBatchArchiveArchiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectType** | **string** |  |  |
| **batchInputPropertyName** | [**BatchInputPropertyName**](BatchInputPropertyName.md) |  |  |

### Return type

void (empty response body)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps_legacy](../README.md#private_apps_legacy), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcrmv3propertiesobjecttypebatchcreatecreate"></a>
# **PostCrmV3PropertiesObjectTypeBatchCreateCreate**
> BatchResponseProperty PostCrmV3PropertiesObjectTypeBatchCreateCreate (string objectType, BatchInputPropertyCreate batchInputPropertyCreate)

Create a batch of properties

Create a batch of properties using the same rules as when creating an individual property.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Properties.Api;
using HubSpot.Crm.Properties.Client;
using HubSpot.Crm.Properties.Model;

namespace Example
{
    public class PostCrmV3PropertiesObjectTypeBatchCreateCreateExample
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

            var apiInstance = new BatchApi(config);
            var objectType = "objectType_example";  // string | 
            var batchInputPropertyCreate = new BatchInputPropertyCreate(); // BatchInputPropertyCreate | 

            try
            {
                // Create a batch of properties
                BatchResponseProperty result = apiInstance.PostCrmV3PropertiesObjectTypeBatchCreateCreate(objectType, batchInputPropertyCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV3PropertiesObjectTypeBatchCreateCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3PropertiesObjectTypeBatchCreateCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a batch of properties
    ApiResponse<BatchResponseProperty> response = apiInstance.PostCrmV3PropertiesObjectTypeBatchCreateCreateWithHttpInfo(objectType, batchInputPropertyCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV3PropertiesObjectTypeBatchCreateCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectType** | **string** |  |  |
| **batchInputPropertyCreate** | [**BatchInputPropertyCreate**](BatchInputPropertyCreate.md) |  |  |

### Return type

[**BatchResponseProperty**](BatchResponseProperty.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps_legacy](../README.md#private_apps_legacy), [private_apps](../README.md#private_apps)

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

<a id="postcrmv3propertiesobjecttypebatchreadread"></a>
# **PostCrmV3PropertiesObjectTypeBatchReadRead**
> BatchResponseProperty PostCrmV3PropertiesObjectTypeBatchReadRead (string objectType, BatchReadInputPropertyName batchReadInputPropertyName)

Read a batch of properties

Read a provided list of properties.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Properties.Api;
using HubSpot.Crm.Properties.Client;
using HubSpot.Crm.Properties.Model;

namespace Example
{
    public class PostCrmV3PropertiesObjectTypeBatchReadReadExample
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

            var apiInstance = new BatchApi(config);
            var objectType = "objectType_example";  // string | 
            var batchReadInputPropertyName = new BatchReadInputPropertyName(); // BatchReadInputPropertyName | 

            try
            {
                // Read a batch of properties
                BatchResponseProperty result = apiInstance.PostCrmV3PropertiesObjectTypeBatchReadRead(objectType, batchReadInputPropertyName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV3PropertiesObjectTypeBatchReadRead: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3PropertiesObjectTypeBatchReadReadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read a batch of properties
    ApiResponse<BatchResponseProperty> response = apiInstance.PostCrmV3PropertiesObjectTypeBatchReadReadWithHttpInfo(objectType, batchReadInputPropertyName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV3PropertiesObjectTypeBatchReadReadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectType** | **string** |  |  |
| **batchReadInputPropertyName** | [**BatchReadInputPropertyName**](BatchReadInputPropertyName.md) |  |  |

### Return type

[**BatchResponseProperty**](BatchResponseProperty.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps_legacy](../README.md#private_apps_legacy), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **207** | multiple statuses |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

