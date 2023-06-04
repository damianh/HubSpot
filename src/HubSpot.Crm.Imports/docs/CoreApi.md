# HubSpot.Crm.Imports.Api.CoreApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCrmV3ImportsGetPage**](CoreApi.md#getcrmv3importsgetpage) | **GET** /crm/v3/imports/ | Get active imports |
| [**GetCrmV3ImportsImportIdGetById**](CoreApi.md#getcrmv3importsimportidgetbyid) | **GET** /crm/v3/imports/{importId} | Get the information on any import |
| [**PostCrmV3ImportsCreate**](CoreApi.md#postcrmv3importscreate) | **POST** /crm/v3/imports/ | Start a new import |
| [**PostCrmV3ImportsImportIdCancelCancel**](CoreApi.md#postcrmv3importsimportidcancelcancel) | **POST** /crm/v3/imports/{importId}/cancel | Cancel an active import |

<a id="getcrmv3importsgetpage"></a>
# **GetCrmV3ImportsGetPage**
> CollectionResponsePublicImportResponse GetCrmV3ImportsGetPage (string after = null, string before = null, int? limit = null)

Get active imports

Returns a paged list of active imports for this account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Imports.Api;
using HubSpot.Crm.Imports.Client;
using HubSpot.Crm.Imports.Model;

namespace Example
{
    public class GetCrmV3ImportsGetPageExample
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

            var apiInstance = new CoreApi(config);
            var after = "after_example";  // string | The paging cursor token of the last successfully read resource will be returned as the `paging.next.after` JSON property of a paged response containing more results. (optional) 
            var before = "before_example";  // string |  (optional) 
            var limit = 56;  // int? | The maximum number of results to display per page. (optional) 

            try
            {
                // Get active imports
                CollectionResponsePublicImportResponse result = apiInstance.GetCrmV3ImportsGetPage(after, before, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.GetCrmV3ImportsGetPage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCrmV3ImportsGetPageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get active imports
    ApiResponse<CollectionResponsePublicImportResponse> response = apiInstance.GetCrmV3ImportsGetPageWithHttpInfo(after, before, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoreApi.GetCrmV3ImportsGetPageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **after** | **string** | The paging cursor token of the last successfully read resource will be returned as the &#x60;paging.next.after&#x60; JSON property of a paged response containing more results. | [optional]  |
| **before** | **string** |  | [optional]  |
| **limit** | **int?** | The maximum number of results to display per page. | [optional]  |

### Return type

[**CollectionResponsePublicImportResponse**](CollectionResponsePublicImportResponse.md)

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

<a id="getcrmv3importsimportidgetbyid"></a>
# **GetCrmV3ImportsImportIdGetById**
> PublicImportResponse GetCrmV3ImportsImportIdGetById (long importId)

Get the information on any import

A complete summary of an import record, including any updates.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Imports.Api;
using HubSpot.Crm.Imports.Client;
using HubSpot.Crm.Imports.Model;

namespace Example
{
    public class GetCrmV3ImportsImportIdGetByIdExample
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

            var apiInstance = new CoreApi(config);
            var importId = 789L;  // long | 

            try
            {
                // Get the information on any import
                PublicImportResponse result = apiInstance.GetCrmV3ImportsImportIdGetById(importId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.GetCrmV3ImportsImportIdGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCrmV3ImportsImportIdGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the information on any import
    ApiResponse<PublicImportResponse> response = apiInstance.GetCrmV3ImportsImportIdGetByIdWithHttpInfo(importId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoreApi.GetCrmV3ImportsImportIdGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **importId** | **long** |  |  |

### Return type

[**PublicImportResponse**](PublicImportResponse.md)

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

<a id="postcrmv3importscreate"></a>
# **PostCrmV3ImportsCreate**
> PublicImportResponse PostCrmV3ImportsCreate (System.IO.Stream files = null, string importRequest = null)

Start a new import

Begins importing data from the specified file resources. This uploads the corresponding file and uses the import request object to convert rows in the files to objects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Imports.Api;
using HubSpot.Crm.Imports.Client;
using HubSpot.Crm.Imports.Model;

namespace Example
{
    public class PostCrmV3ImportsCreateExample
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

            var apiInstance = new CoreApi(config);
            var files = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | A list of files containing the data to import (optional) 
            var importRequest = "importRequest_example";  // string | JSON formatted metadata about the import. This includes a name for the import and the column mappings for each file. See the overview tab for more on the required format. (optional) 

            try
            {
                // Start a new import
                PublicImportResponse result = apiInstance.PostCrmV3ImportsCreate(files, importRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.PostCrmV3ImportsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ImportsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Start a new import
    ApiResponse<PublicImportResponse> response = apiInstance.PostCrmV3ImportsCreateWithHttpInfo(files, importRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoreApi.PostCrmV3ImportsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **files** | **System.IO.Stream****System.IO.Stream** | A list of files containing the data to import | [optional]  |
| **importRequest** | **string** | JSON formatted metadata about the import. This includes a name for the import and the column mappings for each file. See the overview tab for more on the required format. | [optional]  |

### Return type

[**PublicImportResponse**](PublicImportResponse.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcrmv3importsimportidcancelcancel"></a>
# **PostCrmV3ImportsImportIdCancelCancel**
> ActionResponse PostCrmV3ImportsImportIdCancelCancel (long importId)

Cancel an active import

This allows a developer to cancel an active import.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Imports.Api;
using HubSpot.Crm.Imports.Client;
using HubSpot.Crm.Imports.Model;

namespace Example
{
    public class PostCrmV3ImportsImportIdCancelCancelExample
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

            var apiInstance = new CoreApi(config);
            var importId = 789L;  // long | 

            try
            {
                // Cancel an active import
                ActionResponse result = apiInstance.PostCrmV3ImportsImportIdCancelCancel(importId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.PostCrmV3ImportsImportIdCancelCancel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ImportsImportIdCancelCancelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel an active import
    ApiResponse<ActionResponse> response = apiInstance.PostCrmV3ImportsImportIdCancelCancelWithHttpInfo(importId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoreApi.PostCrmV3ImportsImportIdCancelCancelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **importId** | **long** |  |  |

### Return type

[**ActionResponse**](ActionResponse.md)

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

