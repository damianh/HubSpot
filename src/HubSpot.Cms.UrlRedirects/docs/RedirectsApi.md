# HubSpot.Cms.UrlRedirects.Api.RedirectsApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteCmsV3UrlRedirectsUrlRedirectIdArchive**](RedirectsApi.md#deletecmsv3urlredirectsurlredirectidarchive) | **DELETE** /cms/v3/url-redirects/{urlRedirectId} | Delete a redirect |
| [**GetCmsV3UrlRedirectsGetPage**](RedirectsApi.md#getcmsv3urlredirectsgetpage) | **GET** /cms/v3/url-redirects/ | Get current redirects |
| [**GetCmsV3UrlRedirectsUrlRedirectIdGetById**](RedirectsApi.md#getcmsv3urlredirectsurlredirectidgetbyid) | **GET** /cms/v3/url-redirects/{urlRedirectId} | Get details for a redirect |
| [**PatchCmsV3UrlRedirectsUrlRedirectIdUpdate**](RedirectsApi.md#patchcmsv3urlredirectsurlredirectidupdate) | **PATCH** /cms/v3/url-redirects/{urlRedirectId} | Update a redirect |
| [**PostCmsV3UrlRedirectsCreate**](RedirectsApi.md#postcmsv3urlredirectscreate) | **POST** /cms/v3/url-redirects/ | Create a redirect |

<a id="deletecmsv3urlredirectsurlredirectidarchive"></a>
# **DeleteCmsV3UrlRedirectsUrlRedirectIdArchive**
> void DeleteCmsV3UrlRedirectsUrlRedirectIdArchive (string urlRedirectId)

Delete a redirect

Delete one existing redirect, so it is no longer mapped.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.UrlRedirects.Api;
using HubSpot.Cms.UrlRedirects.Client;
using HubSpot.Cms.UrlRedirects.Model;

namespace Example
{
    public class DeleteCmsV3UrlRedirectsUrlRedirectIdArchiveExample
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

            var apiInstance = new RedirectsApi(config);
            var urlRedirectId = "urlRedirectId_example";  // string | The ID of the target redirect.

            try
            {
                // Delete a redirect
                apiInstance.DeleteCmsV3UrlRedirectsUrlRedirectIdArchive(urlRedirectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RedirectsApi.DeleteCmsV3UrlRedirectsUrlRedirectIdArchive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCmsV3UrlRedirectsUrlRedirectIdArchiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a redirect
    apiInstance.DeleteCmsV3UrlRedirectsUrlRedirectIdArchiveWithHttpInfo(urlRedirectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RedirectsApi.DeleteCmsV3UrlRedirectsUrlRedirectIdArchiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **urlRedirectId** | **string** | The ID of the target redirect. |  |

### Return type

void (empty response body)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Delete succeeded |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcmsv3urlredirectsgetpage"></a>
# **GetCmsV3UrlRedirectsGetPage**
> CollectionResponseWithTotalUrlMappingForwardPaging GetCmsV3UrlRedirectsGetPage (DateTime? createdAt = null, DateTime? createdAfter = null, DateTime? createdBefore = null, DateTime? updatedAt = null, DateTime? updatedAfter = null, DateTime? updatedBefore = null, List<string> sort = null, string after = null, int? limit = null, bool? archived = null)

Get current redirects

Returns all existing URL redirects. Results can be limited and filtered by creation or updated date.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.UrlRedirects.Api;
using HubSpot.Cms.UrlRedirects.Client;
using HubSpot.Cms.UrlRedirects.Model;

namespace Example
{
    public class GetCmsV3UrlRedirectsGetPageExample
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

            var apiInstance = new RedirectsApi(config);
            var createdAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only return redirects created on exactly this date. (optional) 
            var createdAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only return redirects created after this date. (optional) 
            var createdBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only return redirects created before this date. (optional) 
            var updatedAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only return redirects last updated on exactly this date. (optional) 
            var updatedAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only return redirects last updated after this date. (optional) 
            var updatedBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only return redirects last updated before this date. (optional) 
            var sort = new List<string>(); // List<string> |  (optional) 
            var after = "after_example";  // string | The paging cursor token of the last successfully read resource will be returned as the `paging.next.after` JSON property of a paged response containing more results. (optional) 
            var limit = 56;  // int? | Maximum number of result per page (optional) 
            var archived = true;  // bool? | Whether to return only results that have been archived. (optional) 

            try
            {
                // Get current redirects
                CollectionResponseWithTotalUrlMappingForwardPaging result = apiInstance.GetCmsV3UrlRedirectsGetPage(createdAt, createdAfter, createdBefore, updatedAt, updatedAfter, updatedBefore, sort, after, limit, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RedirectsApi.GetCmsV3UrlRedirectsGetPage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCmsV3UrlRedirectsGetPageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get current redirects
    ApiResponse<CollectionResponseWithTotalUrlMappingForwardPaging> response = apiInstance.GetCmsV3UrlRedirectsGetPageWithHttpInfo(createdAt, createdAfter, createdBefore, updatedAt, updatedAfter, updatedBefore, sort, after, limit, archived);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RedirectsApi.GetCmsV3UrlRedirectsGetPageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createdAt** | **DateTime?** | Only return redirects created on exactly this date. | [optional]  |
| **createdAfter** | **DateTime?** | Only return redirects created after this date. | [optional]  |
| **createdBefore** | **DateTime?** | Only return redirects created before this date. | [optional]  |
| **updatedAt** | **DateTime?** | Only return redirects last updated on exactly this date. | [optional]  |
| **updatedAfter** | **DateTime?** | Only return redirects last updated after this date. | [optional]  |
| **updatedBefore** | **DateTime?** | Only return redirects last updated before this date. | [optional]  |
| **sort** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **after** | **string** | The paging cursor token of the last successfully read resource will be returned as the &#x60;paging.next.after&#x60; JSON property of a paged response containing more results. | [optional]  |
| **limit** | **int?** | Maximum number of result per page | [optional]  |
| **archived** | **bool?** | Whether to return only results that have been archived. | [optional]  |

### Return type

[**CollectionResponseWithTotalUrlMappingForwardPaging**](CollectionResponseWithTotalUrlMappingForwardPaging.md)

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

<a id="getcmsv3urlredirectsurlredirectidgetbyid"></a>
# **GetCmsV3UrlRedirectsUrlRedirectIdGetById**
> UrlMapping GetCmsV3UrlRedirectsUrlRedirectIdGetById (string urlRedirectId)

Get details for a redirect

Returns the details for a single existing URL redirect by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.UrlRedirects.Api;
using HubSpot.Cms.UrlRedirects.Client;
using HubSpot.Cms.UrlRedirects.Model;

namespace Example
{
    public class GetCmsV3UrlRedirectsUrlRedirectIdGetByIdExample
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

            var apiInstance = new RedirectsApi(config);
            var urlRedirectId = "urlRedirectId_example";  // string | The ID of the target redirect.

            try
            {
                // Get details for a redirect
                UrlMapping result = apiInstance.GetCmsV3UrlRedirectsUrlRedirectIdGetById(urlRedirectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RedirectsApi.GetCmsV3UrlRedirectsUrlRedirectIdGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCmsV3UrlRedirectsUrlRedirectIdGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get details for a redirect
    ApiResponse<UrlMapping> response = apiInstance.GetCmsV3UrlRedirectsUrlRedirectIdGetByIdWithHttpInfo(urlRedirectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RedirectsApi.GetCmsV3UrlRedirectsUrlRedirectIdGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **urlRedirectId** | **string** | The ID of the target redirect. |  |

### Return type

[**UrlMapping**](UrlMapping.md)

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

<a id="patchcmsv3urlredirectsurlredirectidupdate"></a>
# **PatchCmsV3UrlRedirectsUrlRedirectIdUpdate**
> UrlMapping PatchCmsV3UrlRedirectsUrlRedirectIdUpdate (string urlRedirectId, UrlMapping urlMapping)

Update a redirect

Updates the settings for an existing URL redirect.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.UrlRedirects.Api;
using HubSpot.Cms.UrlRedirects.Client;
using HubSpot.Cms.UrlRedirects.Model;

namespace Example
{
    public class PatchCmsV3UrlRedirectsUrlRedirectIdUpdateExample
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

            var apiInstance = new RedirectsApi(config);
            var urlRedirectId = "urlRedirectId_example";  // string | 
            var urlMapping = new UrlMapping(); // UrlMapping | 

            try
            {
                // Update a redirect
                UrlMapping result = apiInstance.PatchCmsV3UrlRedirectsUrlRedirectIdUpdate(urlRedirectId, urlMapping);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RedirectsApi.PatchCmsV3UrlRedirectsUrlRedirectIdUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchCmsV3UrlRedirectsUrlRedirectIdUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a redirect
    ApiResponse<UrlMapping> response = apiInstance.PatchCmsV3UrlRedirectsUrlRedirectIdUpdateWithHttpInfo(urlRedirectId, urlMapping);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RedirectsApi.PatchCmsV3UrlRedirectsUrlRedirectIdUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **urlRedirectId** | **string** |  |  |
| **urlMapping** | [**UrlMapping**](UrlMapping.md) |  |  |

### Return type

[**UrlMapping**](UrlMapping.md)

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

<a id="postcmsv3urlredirectscreate"></a>
# **PostCmsV3UrlRedirectsCreate**
> UrlMapping PostCmsV3UrlRedirectsCreate (UrlMappingCreateRequestBody urlMappingCreateRequestBody)

Create a redirect

Creates and configures a new URL redirect.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.UrlRedirects.Api;
using HubSpot.Cms.UrlRedirects.Client;
using HubSpot.Cms.UrlRedirects.Model;

namespace Example
{
    public class PostCmsV3UrlRedirectsCreateExample
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

            var apiInstance = new RedirectsApi(config);
            var urlMappingCreateRequestBody = new UrlMappingCreateRequestBody(); // UrlMappingCreateRequestBody | 

            try
            {
                // Create a redirect
                UrlMapping result = apiInstance.PostCmsV3UrlRedirectsCreate(urlMappingCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RedirectsApi.PostCmsV3UrlRedirectsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3UrlRedirectsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a redirect
    ApiResponse<UrlMapping> response = apiInstance.PostCmsV3UrlRedirectsCreateWithHttpInfo(urlMappingCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RedirectsApi.PostCmsV3UrlRedirectsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **urlMappingCreateRequestBody** | [**UrlMappingCreateRequestBody**](UrlMappingCreateRequestBody.md) |  |  |

### Return type

[**UrlMapping**](UrlMapping.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

