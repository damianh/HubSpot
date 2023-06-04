# HubSpot.Cms.Domains.Api.DomainsApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCmsV3DomainsDomainIdGetById**](DomainsApi.md#getcmsv3domainsdomainidgetbyid) | **GET** /cms/v3/domains/{domainId} | Get a single domain |
| [**GetCmsV3DomainsGetPage**](DomainsApi.md#getcmsv3domainsgetpage) | **GET** /cms/v3/domains/ | Get current domains |

<a id="getcmsv3domainsdomainidgetbyid"></a>
# **GetCmsV3DomainsDomainIdGetById**
> Domain GetCmsV3DomainsDomainIdGetById (string domainId)

Get a single domain

Returns a single domains with the id specified.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Domains.Api;
using HubSpot.Cms.Domains.Client;
using HubSpot.Cms.Domains.Model;

namespace Example
{
    public class GetCmsV3DomainsDomainIdGetByIdExample
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
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: private_apps
            config.AddApiKey("private-app", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app", "Bearer");

            var apiInstance = new DomainsApi(config);
            var domainId = "domainId_example";  // string | The unique ID of the domain.

            try
            {
                // Get a single domain
                Domain result = apiInstance.GetCmsV3DomainsDomainIdGetById(domainId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.GetCmsV3DomainsDomainIdGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCmsV3DomainsDomainIdGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a single domain
    ApiResponse<Domain> response = apiInstance.GetCmsV3DomainsDomainIdGetByIdWithHttpInfo(domainId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainsApi.GetCmsV3DomainsDomainIdGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainId** | **string** | The unique ID of the domain. |  |

### Return type

[**Domain**](Domain.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy), [oauth2](../README.md#oauth2), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcmsv3domainsgetpage"></a>
# **GetCmsV3DomainsGetPage**
> CollectionResponseWithTotalDomainForwardPaging GetCmsV3DomainsGetPage (DateTime? createdAt = null, DateTime? createdAfter = null, DateTime? createdBefore = null, DateTime? updatedAt = null, DateTime? updatedAfter = null, DateTime? updatedBefore = null, List<string> sort = null, string after = null, int? limit = null, bool? archived = null)

Get current domains

Returns all existing domains that have been created. Results can be limited and filtered by creation or updated date.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Domains.Api;
using HubSpot.Cms.Domains.Client;
using HubSpot.Cms.Domains.Model;

namespace Example
{
    public class GetCmsV3DomainsGetPageExample
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
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: private_apps
            config.AddApiKey("private-app", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app", "Bearer");

            var apiInstance = new DomainsApi(config);
            var createdAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only return domains created at this date. (optional) 
            var createdAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only return domains created after this date. (optional) 
            var createdBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only return domains created before this date. (optional) 
            var updatedAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only return domains updated at this date. (optional) 
            var updatedAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only return domains updated after this date. (optional) 
            var updatedBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only return domains updated before this date. (optional) 
            var sort = new List<string>(); // List<string> |  (optional) 
            var after = "after_example";  // string | The paging cursor token of the last successfully read resource will be returned as the `paging.next.after` JSON property of a paged response containing more results. (optional) 
            var limit = 56;  // int? | Maximum number of results per page. (optional) 
            var archived = true;  // bool? | Whether to return only results that have been archived. (optional) 

            try
            {
                // Get current domains
                CollectionResponseWithTotalDomainForwardPaging result = apiInstance.GetCmsV3DomainsGetPage(createdAt, createdAfter, createdBefore, updatedAt, updatedAfter, updatedBefore, sort, after, limit, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.GetCmsV3DomainsGetPage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCmsV3DomainsGetPageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get current domains
    ApiResponse<CollectionResponseWithTotalDomainForwardPaging> response = apiInstance.GetCmsV3DomainsGetPageWithHttpInfo(createdAt, createdAfter, createdBefore, updatedAt, updatedAfter, updatedBefore, sort, after, limit, archived);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainsApi.GetCmsV3DomainsGetPageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createdAt** | **DateTime?** | Only return domains created at this date. | [optional]  |
| **createdAfter** | **DateTime?** | Only return domains created after this date. | [optional]  |
| **createdBefore** | **DateTime?** | Only return domains created before this date. | [optional]  |
| **updatedAt** | **DateTime?** | Only return domains updated at this date. | [optional]  |
| **updatedAfter** | **DateTime?** | Only return domains updated after this date. | [optional]  |
| **updatedBefore** | **DateTime?** | Only return domains updated before this date. | [optional]  |
| **sort** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **after** | **string** | The paging cursor token of the last successfully read resource will be returned as the &#x60;paging.next.after&#x60; JSON property of a paged response containing more results. | [optional]  |
| **limit** | **int?** | Maximum number of results per page. | [optional]  |
| **archived** | **bool?** | Whether to return only results that have been archived. | [optional]  |

### Return type

[**CollectionResponseWithTotalDomainForwardPaging**](CollectionResponseWithTotalDomainForwardPaging.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy), [oauth2](../README.md#oauth2), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

