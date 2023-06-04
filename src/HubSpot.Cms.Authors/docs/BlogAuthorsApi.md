# HubSpot.Cms.Authors.Api.BlogAuthorsApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteCmsV3BlogsAuthorsObjectIdArchive**](BlogAuthorsApi.md#deletecmsv3blogsauthorsobjectidarchive) | **DELETE** /cms/v3/blogs/authors/{objectId} | Delete a Blog Author |
| [**GetCmsV3BlogsAuthorsGetPage**](BlogAuthorsApi.md#getcmsv3blogsauthorsgetpage) | **GET** /cms/v3/blogs/authors | Get all Blog Authors |
| [**GetCmsV3BlogsAuthorsObjectIdGetById**](BlogAuthorsApi.md#getcmsv3blogsauthorsobjectidgetbyid) | **GET** /cms/v3/blogs/authors/{objectId} | Retrieve a Blog Author |
| [**PatchCmsV3BlogsAuthorsObjectIdUpdate**](BlogAuthorsApi.md#patchcmsv3blogsauthorsobjectidupdate) | **PATCH** /cms/v3/blogs/authors/{objectId} | Update a Blog Author |
| [**PostCmsV3BlogsAuthorsBatchArchiveArchiveBatch**](BlogAuthorsApi.md#postcmsv3blogsauthorsbatcharchivearchivebatch) | **POST** /cms/v3/blogs/authors/batch/archive | Delete a batch of Blog Authors |
| [**PostCmsV3BlogsAuthorsBatchCreateCreateBatch**](BlogAuthorsApi.md#postcmsv3blogsauthorsbatchcreatecreatebatch) | **POST** /cms/v3/blogs/authors/batch/create | Create a batch of Blog Authors |
| [**PostCmsV3BlogsAuthorsBatchReadReadBatch**](BlogAuthorsApi.md#postcmsv3blogsauthorsbatchreadreadbatch) | **POST** /cms/v3/blogs/authors/batch/read | Retrieve a batch of Blog Authors |
| [**PostCmsV3BlogsAuthorsBatchUpdateUpdateBatch**](BlogAuthorsApi.md#postcmsv3blogsauthorsbatchupdateupdatebatch) | **POST** /cms/v3/blogs/authors/batch/update | Update a batch of Blog Authors |
| [**PostCmsV3BlogsAuthorsCreate**](BlogAuthorsApi.md#postcmsv3blogsauthorscreate) | **POST** /cms/v3/blogs/authors | Create a new Blog Author |
| [**PostCmsV3BlogsAuthorsMultiLanguageAttachToLangGroupAttachToLangGroup**](BlogAuthorsApi.md#postcmsv3blogsauthorsmultilanguageattachtolanggroupattachtolanggroup) | **POST** /cms/v3/blogs/authors/multi-language/attach-to-lang-group | Attach a Blog Author to a multi-language group |
| [**PostCmsV3BlogsAuthorsMultiLanguageCreateLanguageVariationCreateLangVariation**](BlogAuthorsApi.md#postcmsv3blogsauthorsmultilanguagecreatelanguagevariationcreatelangvariation) | **POST** /cms/v3/blogs/authors/multi-language/create-language-variation | Create a new language variation |
| [**PostCmsV3BlogsAuthorsMultiLanguageDetachFromLangGroupDetachFromLangGroup**](BlogAuthorsApi.md#postcmsv3blogsauthorsmultilanguagedetachfromlanggroupdetachfromlanggroup) | **POST** /cms/v3/blogs/authors/multi-language/detach-from-lang-group | Detach a Blog Author from a multi-language group |
| [**PostCmsV3BlogsAuthorsMultiLanguageUpdateLanguagesUpdateLangs**](BlogAuthorsApi.md#postcmsv3blogsauthorsmultilanguageupdatelanguagesupdatelangs) | **POST** /cms/v3/blogs/authors/multi-language/update-languages | Update languages of multi-language group |
| [**PutCmsV3BlogsAuthorsMultiLanguageSetNewLangPrimarySetLangPrimary**](BlogAuthorsApi.md#putcmsv3blogsauthorsmultilanguagesetnewlangprimarysetlangprimary) | **PUT** /cms/v3/blogs/authors/multi-language/set-new-lang-primary | Set a new primary language |

<a id="deletecmsv3blogsauthorsobjectidarchive"></a>
# **DeleteCmsV3BlogsAuthorsObjectIdArchive**
> void DeleteCmsV3BlogsAuthorsObjectIdArchive (string objectId, bool? archived = null)

Delete a Blog Author

Delete the Blog Author object identified by the id in the path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Authors.Api;
using HubSpot.Cms.Authors.Client;
using HubSpot.Cms.Authors.Model;

namespace Example
{
    public class DeleteCmsV3BlogsAuthorsObjectIdArchiveExample
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

            var apiInstance = new BlogAuthorsApi(config);
            var objectId = "objectId_example";  // string | The Blog Author id.
            var archived = true;  // bool? | Whether to return only results that have been archived. (optional) 

            try
            {
                // Delete a Blog Author
                apiInstance.DeleteCmsV3BlogsAuthorsObjectIdArchive(objectId, archived);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogAuthorsApi.DeleteCmsV3BlogsAuthorsObjectIdArchive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCmsV3BlogsAuthorsObjectIdArchiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a Blog Author
    apiInstance.DeleteCmsV3BlogsAuthorsObjectIdArchiveWithHttpInfo(objectId, archived);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogAuthorsApi.DeleteCmsV3BlogsAuthorsObjectIdArchiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectId** | **string** | The Blog Author id. |  |
| **archived** | **bool?** | Whether to return only results that have been archived. | [optional]  |

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
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcmsv3blogsauthorsgetpage"></a>
# **GetCmsV3BlogsAuthorsGetPage**
> CollectionResponseWithTotalBlogAuthorForwardPaging GetCmsV3BlogsAuthorsGetPage (DateTime? createdAt = null, DateTime? createdAfter = null, DateTime? createdBefore = null, DateTime? updatedAt = null, DateTime? updatedAfter = null, DateTime? updatedBefore = null, List<string> sort = null, string after = null, int? limit = null, bool? archived = null)

Get all Blog Authors

Get the list of blog authors. Supports paging and filtering. This method would be useful for an integration that examined these models and used an external service to suggest edits. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Authors.Api;
using HubSpot.Cms.Authors.Client;
using HubSpot.Cms.Authors.Model;

namespace Example
{
    public class GetCmsV3BlogsAuthorsGetPageExample
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

            var apiInstance = new BlogAuthorsApi(config);
            var createdAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only return Blog Authors created at exactly the specified time. (optional) 
            var createdAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only return Blog Authors created after the specified time. (optional) 
            var createdBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only return Blog Authors created before the specified time. (optional) 
            var updatedAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only return Blog Authors last updated at exactly the specified time. (optional) 
            var updatedAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only return Blog Authors last updated after the specified time. (optional) 
            var updatedBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only return Blog Authors last updated before the specified time. (optional) 
            var sort = new List<string>(); // List<string> | Specifies which fields to use for sorting results. Valid fields are `name`, `createdAt`, `updatedAt`, `createdBy`, `updatedBy`. `createdAt` will be used by default. (optional) 
            var after = "after_example";  // string | The cursor token value to get the next set of results. You can get this from the `paging.next.after` JSON property of a paged response containing more results. (optional) 
            var limit = 56;  // int? | The maximum number of results to return. Default is 100. (optional) 
            var archived = true;  // bool? | Specifies whether to return deleted Blog Authors. Defaults to `false`. (optional) 

            try
            {
                // Get all Blog Authors
                CollectionResponseWithTotalBlogAuthorForwardPaging result = apiInstance.GetCmsV3BlogsAuthorsGetPage(createdAt, createdAfter, createdBefore, updatedAt, updatedAfter, updatedBefore, sort, after, limit, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogAuthorsApi.GetCmsV3BlogsAuthorsGetPage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCmsV3BlogsAuthorsGetPageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all Blog Authors
    ApiResponse<CollectionResponseWithTotalBlogAuthorForwardPaging> response = apiInstance.GetCmsV3BlogsAuthorsGetPageWithHttpInfo(createdAt, createdAfter, createdBefore, updatedAt, updatedAfter, updatedBefore, sort, after, limit, archived);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogAuthorsApi.GetCmsV3BlogsAuthorsGetPageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createdAt** | **DateTime?** | Only return Blog Authors created at exactly the specified time. | [optional]  |
| **createdAfter** | **DateTime?** | Only return Blog Authors created after the specified time. | [optional]  |
| **createdBefore** | **DateTime?** | Only return Blog Authors created before the specified time. | [optional]  |
| **updatedAt** | **DateTime?** | Only return Blog Authors last updated at exactly the specified time. | [optional]  |
| **updatedAfter** | **DateTime?** | Only return Blog Authors last updated after the specified time. | [optional]  |
| **updatedBefore** | **DateTime?** | Only return Blog Authors last updated before the specified time. | [optional]  |
| **sort** | [**List&lt;string&gt;**](string.md) | Specifies which fields to use for sorting results. Valid fields are &#x60;name&#x60;, &#x60;createdAt&#x60;, &#x60;updatedAt&#x60;, &#x60;createdBy&#x60;, &#x60;updatedBy&#x60;. &#x60;createdAt&#x60; will be used by default. | [optional]  |
| **after** | **string** | The cursor token value to get the next set of results. You can get this from the &#x60;paging.next.after&#x60; JSON property of a paged response containing more results. | [optional]  |
| **limit** | **int?** | The maximum number of results to return. Default is 100. | [optional]  |
| **archived** | **bool?** | Specifies whether to return deleted Blog Authors. Defaults to &#x60;false&#x60;. | [optional]  |

### Return type

[**CollectionResponseWithTotalBlogAuthorForwardPaging**](CollectionResponseWithTotalBlogAuthorForwardPaging.md)

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

<a id="getcmsv3blogsauthorsobjectidgetbyid"></a>
# **GetCmsV3BlogsAuthorsObjectIdGetById**
> BlogAuthor GetCmsV3BlogsAuthorsObjectIdGetById (string objectId, bool? archived = null)

Retrieve a Blog Author

Retrieve the Blog Author object identified by the id in the path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Authors.Api;
using HubSpot.Cms.Authors.Client;
using HubSpot.Cms.Authors.Model;

namespace Example
{
    public class GetCmsV3BlogsAuthorsObjectIdGetByIdExample
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

            var apiInstance = new BlogAuthorsApi(config);
            var objectId = "objectId_example";  // string | The Blog Author id.
            var archived = true;  // bool? | Specifies whether to return deleted Blog Authors. Defaults to `false`. (optional) 

            try
            {
                // Retrieve a Blog Author
                BlogAuthor result = apiInstance.GetCmsV3BlogsAuthorsObjectIdGetById(objectId, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogAuthorsApi.GetCmsV3BlogsAuthorsObjectIdGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCmsV3BlogsAuthorsObjectIdGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a Blog Author
    ApiResponse<BlogAuthor> response = apiInstance.GetCmsV3BlogsAuthorsObjectIdGetByIdWithHttpInfo(objectId, archived);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogAuthorsApi.GetCmsV3BlogsAuthorsObjectIdGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectId** | **string** | The Blog Author id. |  |
| **archived** | **bool?** | Specifies whether to return deleted Blog Authors. Defaults to &#x60;false&#x60;. | [optional]  |

### Return type

[**BlogAuthor**](BlogAuthor.md)

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

<a id="patchcmsv3blogsauthorsobjectidupdate"></a>
# **PatchCmsV3BlogsAuthorsObjectIdUpdate**
> BlogAuthor PatchCmsV3BlogsAuthorsObjectIdUpdate (string objectId, BlogAuthor blogAuthor, bool? archived = null)

Update a Blog Author

Sparse updates a single Blog Author object identified by the id in the path. All the column values need not be specified. Only the that need to be modified can be specified. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Authors.Api;
using HubSpot.Cms.Authors.Client;
using HubSpot.Cms.Authors.Model;

namespace Example
{
    public class PatchCmsV3BlogsAuthorsObjectIdUpdateExample
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

            var apiInstance = new BlogAuthorsApi(config);
            var objectId = "objectId_example";  // string | The Blog Author id.
            var blogAuthor = new BlogAuthor(); // BlogAuthor | The JSON representation of the updated Blog Author.
            var archived = true;  // bool? | Specifies whether to update deleted Blog Authors. Defaults to `false`. (optional) 

            try
            {
                // Update a Blog Author
                BlogAuthor result = apiInstance.PatchCmsV3BlogsAuthorsObjectIdUpdate(objectId, blogAuthor, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogAuthorsApi.PatchCmsV3BlogsAuthorsObjectIdUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchCmsV3BlogsAuthorsObjectIdUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a Blog Author
    ApiResponse<BlogAuthor> response = apiInstance.PatchCmsV3BlogsAuthorsObjectIdUpdateWithHttpInfo(objectId, blogAuthor, archived);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogAuthorsApi.PatchCmsV3BlogsAuthorsObjectIdUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectId** | **string** | The Blog Author id. |  |
| **blogAuthor** | [**BlogAuthor**](BlogAuthor.md) | The JSON representation of the updated Blog Author. |  |
| **archived** | **bool?** | Specifies whether to update deleted Blog Authors. Defaults to &#x60;false&#x60;. | [optional]  |

### Return type

[**BlogAuthor**](BlogAuthor.md)

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

<a id="postcmsv3blogsauthorsbatcharchivearchivebatch"></a>
# **PostCmsV3BlogsAuthorsBatchArchiveArchiveBatch**
> void PostCmsV3BlogsAuthorsBatchArchiveArchiveBatch (BatchInputString batchInputString)

Delete a batch of Blog Authors

Delete the Blog Author objects identified in the request body.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Authors.Api;
using HubSpot.Cms.Authors.Client;
using HubSpot.Cms.Authors.Model;

namespace Example
{
    public class PostCmsV3BlogsAuthorsBatchArchiveArchiveBatchExample
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

            var apiInstance = new BlogAuthorsApi(config);
            var batchInputString = new BatchInputString(); // BatchInputString | The JSON array of Blog Author ids.

            try
            {
                // Delete a batch of Blog Authors
                apiInstance.PostCmsV3BlogsAuthorsBatchArchiveArchiveBatch(batchInputString);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogAuthorsApi.PostCmsV3BlogsAuthorsBatchArchiveArchiveBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3BlogsAuthorsBatchArchiveArchiveBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a batch of Blog Authors
    apiInstance.PostCmsV3BlogsAuthorsBatchArchiveArchiveBatchWithHttpInfo(batchInputString);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogAuthorsApi.PostCmsV3BlogsAuthorsBatchArchiveArchiveBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchInputString** | [**BatchInputString**](BatchInputString.md) | The JSON array of Blog Author ids. |  |

### Return type

void (empty response body)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcmsv3blogsauthorsbatchcreatecreatebatch"></a>
# **PostCmsV3BlogsAuthorsBatchCreateCreateBatch**
> BatchResponseBlogAuthor PostCmsV3BlogsAuthorsBatchCreateCreateBatch (BatchInputBlogAuthor batchInputBlogAuthor)

Create a batch of Blog Authors

Create the Blog Author objects detailed in the request body.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Authors.Api;
using HubSpot.Cms.Authors.Client;
using HubSpot.Cms.Authors.Model;

namespace Example
{
    public class PostCmsV3BlogsAuthorsBatchCreateCreateBatchExample
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

            var apiInstance = new BlogAuthorsApi(config);
            var batchInputBlogAuthor = new BatchInputBlogAuthor(); // BatchInputBlogAuthor | The JSON array of new Blog Authors to create.

            try
            {
                // Create a batch of Blog Authors
                BatchResponseBlogAuthor result = apiInstance.PostCmsV3BlogsAuthorsBatchCreateCreateBatch(batchInputBlogAuthor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogAuthorsApi.PostCmsV3BlogsAuthorsBatchCreateCreateBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3BlogsAuthorsBatchCreateCreateBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a batch of Blog Authors
    ApiResponse<BatchResponseBlogAuthor> response = apiInstance.PostCmsV3BlogsAuthorsBatchCreateCreateBatchWithHttpInfo(batchInputBlogAuthor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogAuthorsApi.PostCmsV3BlogsAuthorsBatchCreateCreateBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchInputBlogAuthor** | [**BatchInputBlogAuthor**](BatchInputBlogAuthor.md) | The JSON array of new Blog Authors to create. |  |

### Return type

[**BatchResponseBlogAuthor**](BatchResponseBlogAuthor.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

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

<a id="postcmsv3blogsauthorsbatchreadreadbatch"></a>
# **PostCmsV3BlogsAuthorsBatchReadReadBatch**
> BatchResponseBlogAuthor PostCmsV3BlogsAuthorsBatchReadReadBatch (BatchInputString batchInputString, bool? archived = null)

Retrieve a batch of Blog Authors

Retrieve the Blog Author objects identified in the request body.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Authors.Api;
using HubSpot.Cms.Authors.Client;
using HubSpot.Cms.Authors.Model;

namespace Example
{
    public class PostCmsV3BlogsAuthorsBatchReadReadBatchExample
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

            var apiInstance = new BlogAuthorsApi(config);
            var batchInputString = new BatchInputString(); // BatchInputString | The JSON array of Blog Author ids.
            var archived = true;  // bool? | Specifies whether to return deleted Blog Authors. Defaults to `false`. (optional) 

            try
            {
                // Retrieve a batch of Blog Authors
                BatchResponseBlogAuthor result = apiInstance.PostCmsV3BlogsAuthorsBatchReadReadBatch(batchInputString, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogAuthorsApi.PostCmsV3BlogsAuthorsBatchReadReadBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3BlogsAuthorsBatchReadReadBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a batch of Blog Authors
    ApiResponse<BatchResponseBlogAuthor> response = apiInstance.PostCmsV3BlogsAuthorsBatchReadReadBatchWithHttpInfo(batchInputString, archived);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogAuthorsApi.PostCmsV3BlogsAuthorsBatchReadReadBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchInputString** | [**BatchInputString**](BatchInputString.md) | The JSON array of Blog Author ids. |  |
| **archived** | **bool?** | Specifies whether to return deleted Blog Authors. Defaults to &#x60;false&#x60;. | [optional]  |

### Return type

[**BatchResponseBlogAuthor**](BatchResponseBlogAuthor.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

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

<a id="postcmsv3blogsauthorsbatchupdateupdatebatch"></a>
# **PostCmsV3BlogsAuthorsBatchUpdateUpdateBatch**
> BatchResponseBlogAuthor PostCmsV3BlogsAuthorsBatchUpdateUpdateBatch (BatchInputJsonNode batchInputJsonNode, bool? archived = null)

Update a batch of Blog Authors

Update the Blog Author objects identified in the request body.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Authors.Api;
using HubSpot.Cms.Authors.Client;
using HubSpot.Cms.Authors.Model;

namespace Example
{
    public class PostCmsV3BlogsAuthorsBatchUpdateUpdateBatchExample
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

            var apiInstance = new BlogAuthorsApi(config);
            var batchInputJsonNode = new BatchInputJsonNode(); // BatchInputJsonNode | A JSON array of the JSON representations of the updated Blog Authors.
            var archived = true;  // bool? | Specifies whether to update deleted Blog Authors. Defaults to `false`. (optional) 

            try
            {
                // Update a batch of Blog Authors
                BatchResponseBlogAuthor result = apiInstance.PostCmsV3BlogsAuthorsBatchUpdateUpdateBatch(batchInputJsonNode, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogAuthorsApi.PostCmsV3BlogsAuthorsBatchUpdateUpdateBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3BlogsAuthorsBatchUpdateUpdateBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a batch of Blog Authors
    ApiResponse<BatchResponseBlogAuthor> response = apiInstance.PostCmsV3BlogsAuthorsBatchUpdateUpdateBatchWithHttpInfo(batchInputJsonNode, archived);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogAuthorsApi.PostCmsV3BlogsAuthorsBatchUpdateUpdateBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchInputJsonNode** | [**BatchInputJsonNode**](BatchInputJsonNode.md) | A JSON array of the JSON representations of the updated Blog Authors. |  |
| **archived** | **bool?** | Specifies whether to update deleted Blog Authors. Defaults to &#x60;false&#x60;. | [optional]  |

### Return type

[**BatchResponseBlogAuthor**](BatchResponseBlogAuthor.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

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

<a id="postcmsv3blogsauthorscreate"></a>
# **PostCmsV3BlogsAuthorsCreate**
> BlogAuthor PostCmsV3BlogsAuthorsCreate (BlogAuthor blogAuthor)

Create a new Blog Author

Create a new Blog Author.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Authors.Api;
using HubSpot.Cms.Authors.Client;
using HubSpot.Cms.Authors.Model;

namespace Example
{
    public class PostCmsV3BlogsAuthorsCreateExample
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

            var apiInstance = new BlogAuthorsApi(config);
            var blogAuthor = new BlogAuthor(); // BlogAuthor | The JSON representation of a new Blog Author.

            try
            {
                // Create a new Blog Author
                BlogAuthor result = apiInstance.PostCmsV3BlogsAuthorsCreate(blogAuthor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogAuthorsApi.PostCmsV3BlogsAuthorsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3BlogsAuthorsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Blog Author
    ApiResponse<BlogAuthor> response = apiInstance.PostCmsV3BlogsAuthorsCreateWithHttpInfo(blogAuthor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogAuthorsApi.PostCmsV3BlogsAuthorsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blogAuthor** | [**BlogAuthor**](BlogAuthor.md) | The JSON representation of a new Blog Author. |  |

### Return type

[**BlogAuthor**](BlogAuthor.md)

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

<a id="postcmsv3blogsauthorsmultilanguageattachtolanggroupattachtolanggroup"></a>
# **PostCmsV3BlogsAuthorsMultiLanguageAttachToLangGroupAttachToLangGroup**
> Error PostCmsV3BlogsAuthorsMultiLanguageAttachToLangGroupAttachToLangGroup (AttachToLangPrimaryRequestVNext attachToLangPrimaryRequestVNext)

Attach a Blog Author to a multi-language group

Attach a Blog Author to a multi-language group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Authors.Api;
using HubSpot.Cms.Authors.Client;
using HubSpot.Cms.Authors.Model;

namespace Example
{
    public class PostCmsV3BlogsAuthorsMultiLanguageAttachToLangGroupAttachToLangGroupExample
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

            var apiInstance = new BlogAuthorsApi(config);
            var attachToLangPrimaryRequestVNext = new AttachToLangPrimaryRequestVNext(); // AttachToLangPrimaryRequestVNext | The JSON representation of the AttachToLangPrimaryRequest object.

            try
            {
                // Attach a Blog Author to a multi-language group
                Error result = apiInstance.PostCmsV3BlogsAuthorsMultiLanguageAttachToLangGroupAttachToLangGroup(attachToLangPrimaryRequestVNext);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogAuthorsApi.PostCmsV3BlogsAuthorsMultiLanguageAttachToLangGroupAttachToLangGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3BlogsAuthorsMultiLanguageAttachToLangGroupAttachToLangGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Attach a Blog Author to a multi-language group
    ApiResponse<Error> response = apiInstance.PostCmsV3BlogsAuthorsMultiLanguageAttachToLangGroupAttachToLangGroupWithHttpInfo(attachToLangPrimaryRequestVNext);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogAuthorsApi.PostCmsV3BlogsAuthorsMultiLanguageAttachToLangGroupAttachToLangGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **attachToLangPrimaryRequestVNext** | [**AttachToLangPrimaryRequestVNext**](AttachToLangPrimaryRequestVNext.md) | The JSON representation of the AttachToLangPrimaryRequest object. |  |

### Return type

[**Error**](Error.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcmsv3blogsauthorsmultilanguagecreatelanguagevariationcreatelangvariation"></a>
# **PostCmsV3BlogsAuthorsMultiLanguageCreateLanguageVariationCreateLangVariation**
> BlogAuthor PostCmsV3BlogsAuthorsMultiLanguageCreateLanguageVariationCreateLangVariation (BlogAuthorCloneRequestVNext blogAuthorCloneRequestVNext)

Create a new language variation

Create a new language variation from an existing Blog Author.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Authors.Api;
using HubSpot.Cms.Authors.Client;
using HubSpot.Cms.Authors.Model;

namespace Example
{
    public class PostCmsV3BlogsAuthorsMultiLanguageCreateLanguageVariationCreateLangVariationExample
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

            var apiInstance = new BlogAuthorsApi(config);
            var blogAuthorCloneRequestVNext = new BlogAuthorCloneRequestVNext(); // BlogAuthorCloneRequestVNext | The JSON representation of the ContentLanguageCloneRequest object.

            try
            {
                // Create a new language variation
                BlogAuthor result = apiInstance.PostCmsV3BlogsAuthorsMultiLanguageCreateLanguageVariationCreateLangVariation(blogAuthorCloneRequestVNext);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogAuthorsApi.PostCmsV3BlogsAuthorsMultiLanguageCreateLanguageVariationCreateLangVariation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3BlogsAuthorsMultiLanguageCreateLanguageVariationCreateLangVariationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new language variation
    ApiResponse<BlogAuthor> response = apiInstance.PostCmsV3BlogsAuthorsMultiLanguageCreateLanguageVariationCreateLangVariationWithHttpInfo(blogAuthorCloneRequestVNext);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogAuthorsApi.PostCmsV3BlogsAuthorsMultiLanguageCreateLanguageVariationCreateLangVariationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blogAuthorCloneRequestVNext** | [**BlogAuthorCloneRequestVNext**](BlogAuthorCloneRequestVNext.md) | The JSON representation of the ContentLanguageCloneRequest object. |  |

### Return type

[**BlogAuthor**](BlogAuthor.md)

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

<a id="postcmsv3blogsauthorsmultilanguagedetachfromlanggroupdetachfromlanggroup"></a>
# **PostCmsV3BlogsAuthorsMultiLanguageDetachFromLangGroupDetachFromLangGroup**
> Error PostCmsV3BlogsAuthorsMultiLanguageDetachFromLangGroupDetachFromLangGroup (DetachFromLangGroupRequestVNext detachFromLangGroupRequestVNext)

Detach a Blog Author from a multi-language group

Detach a Blog Author from a multi-language group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Authors.Api;
using HubSpot.Cms.Authors.Client;
using HubSpot.Cms.Authors.Model;

namespace Example
{
    public class PostCmsV3BlogsAuthorsMultiLanguageDetachFromLangGroupDetachFromLangGroupExample
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

            var apiInstance = new BlogAuthorsApi(config);
            var detachFromLangGroupRequestVNext = new DetachFromLangGroupRequestVNext(); // DetachFromLangGroupRequestVNext | The JSON representation of the DetachFromLangGroupRequest object.

            try
            {
                // Detach a Blog Author from a multi-language group
                Error result = apiInstance.PostCmsV3BlogsAuthorsMultiLanguageDetachFromLangGroupDetachFromLangGroup(detachFromLangGroupRequestVNext);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogAuthorsApi.PostCmsV3BlogsAuthorsMultiLanguageDetachFromLangGroupDetachFromLangGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3BlogsAuthorsMultiLanguageDetachFromLangGroupDetachFromLangGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Detach a Blog Author from a multi-language group
    ApiResponse<Error> response = apiInstance.PostCmsV3BlogsAuthorsMultiLanguageDetachFromLangGroupDetachFromLangGroupWithHttpInfo(detachFromLangGroupRequestVNext);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogAuthorsApi.PostCmsV3BlogsAuthorsMultiLanguageDetachFromLangGroupDetachFromLangGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **detachFromLangGroupRequestVNext** | [**DetachFromLangGroupRequestVNext**](DetachFromLangGroupRequestVNext.md) | The JSON representation of the DetachFromLangGroupRequest object. |  |

### Return type

[**Error**](Error.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcmsv3blogsauthorsmultilanguageupdatelanguagesupdatelangs"></a>
# **PostCmsV3BlogsAuthorsMultiLanguageUpdateLanguagesUpdateLangs**
> Error PostCmsV3BlogsAuthorsMultiLanguageUpdateLanguagesUpdateLangs (UpdateLanguagesRequestVNext updateLanguagesRequestVNext)

Update languages of multi-language group

Explicitly set new languages for each Blog Author in a multi-language group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Authors.Api;
using HubSpot.Cms.Authors.Client;
using HubSpot.Cms.Authors.Model;

namespace Example
{
    public class PostCmsV3BlogsAuthorsMultiLanguageUpdateLanguagesUpdateLangsExample
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

            var apiInstance = new BlogAuthorsApi(config);
            var updateLanguagesRequestVNext = new UpdateLanguagesRequestVNext(); // UpdateLanguagesRequestVNext | The JSON representation of the UpdateLanguagesRequest object.

            try
            {
                // Update languages of multi-language group
                Error result = apiInstance.PostCmsV3BlogsAuthorsMultiLanguageUpdateLanguagesUpdateLangs(updateLanguagesRequestVNext);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogAuthorsApi.PostCmsV3BlogsAuthorsMultiLanguageUpdateLanguagesUpdateLangs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3BlogsAuthorsMultiLanguageUpdateLanguagesUpdateLangsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update languages of multi-language group
    ApiResponse<Error> response = apiInstance.PostCmsV3BlogsAuthorsMultiLanguageUpdateLanguagesUpdateLangsWithHttpInfo(updateLanguagesRequestVNext);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogAuthorsApi.PostCmsV3BlogsAuthorsMultiLanguageUpdateLanguagesUpdateLangsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateLanguagesRequestVNext** | [**UpdateLanguagesRequestVNext**](UpdateLanguagesRequestVNext.md) | The JSON representation of the UpdateLanguagesRequest object. |  |

### Return type

[**Error**](Error.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putcmsv3blogsauthorsmultilanguagesetnewlangprimarysetlangprimary"></a>
# **PutCmsV3BlogsAuthorsMultiLanguageSetNewLangPrimarySetLangPrimary**
> void PutCmsV3BlogsAuthorsMultiLanguageSetNewLangPrimarySetLangPrimary (SetNewLanguagePrimaryRequestVNext setNewLanguagePrimaryRequestVNext)

Set a new primary language

Set a Blog Author as the primary language of a multi-language group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Authors.Api;
using HubSpot.Cms.Authors.Client;
using HubSpot.Cms.Authors.Model;

namespace Example
{
    public class PutCmsV3BlogsAuthorsMultiLanguageSetNewLangPrimarySetLangPrimaryExample
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

            var apiInstance = new BlogAuthorsApi(config);
            var setNewLanguagePrimaryRequestVNext = new SetNewLanguagePrimaryRequestVNext(); // SetNewLanguagePrimaryRequestVNext | The JSON representation of the SetNewLanguagePrimaryRequest object.

            try
            {
                // Set a new primary language
                apiInstance.PutCmsV3BlogsAuthorsMultiLanguageSetNewLangPrimarySetLangPrimary(setNewLanguagePrimaryRequestVNext);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogAuthorsApi.PutCmsV3BlogsAuthorsMultiLanguageSetNewLangPrimarySetLangPrimary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutCmsV3BlogsAuthorsMultiLanguageSetNewLangPrimarySetLangPrimaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set a new primary language
    apiInstance.PutCmsV3BlogsAuthorsMultiLanguageSetNewLangPrimarySetLangPrimaryWithHttpInfo(setNewLanguagePrimaryRequestVNext);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogAuthorsApi.PutCmsV3BlogsAuthorsMultiLanguageSetNewLangPrimarySetLangPrimaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **setNewLanguagePrimaryRequestVNext** | [**SetNewLanguagePrimaryRequestVNext**](SetNewLanguagePrimaryRequestVNext.md) | The JSON representation of the SetNewLanguagePrimaryRequest object. |  |

### Return type

void (empty response body)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

