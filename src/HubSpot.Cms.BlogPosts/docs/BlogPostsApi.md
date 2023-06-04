# HubSpot.Cms.BlogPosts.Api.BlogPostsApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteCmsV3BlogsPostsObjectIdArchive**](BlogPostsApi.md#deletecmsv3blogspostsobjectidarchive) | **DELETE** /cms/v3/blogs/posts/{objectId} | Delete a Blog Post |
| [**GetCmsV3BlogsPostsGetPage**](BlogPostsApi.md#getcmsv3blogspostsgetpage) | **GET** /cms/v3/blogs/posts | Get all Blog Posts |
| [**GetCmsV3BlogsPostsObjectIdDraftGetDraftById**](BlogPostsApi.md#getcmsv3blogspostsobjectiddraftgetdraftbyid) | **GET** /cms/v3/blogs/posts/{objectId}/draft | Retrieve the full draft version of the Blog Post |
| [**GetCmsV3BlogsPostsObjectIdGetById**](BlogPostsApi.md#getcmsv3blogspostsobjectidgetbyid) | **GET** /cms/v3/blogs/posts/{objectId} | Retrieve a Blog Post |
| [**GetCmsV3BlogsPostsObjectIdRevisionsGetPreviousVersions**](BlogPostsApi.md#getcmsv3blogspostsobjectidrevisionsgetpreviousversions) | **GET** /cms/v3/blogs/posts/{objectId}/revisions | Retrieves all the previous versions of a blog post |
| [**GetCmsV3BlogsPostsObjectIdRevisionsRevisionIdGetPreviousVersion**](BlogPostsApi.md#getcmsv3blogspostsobjectidrevisionsrevisionidgetpreviousversion) | **GET** /cms/v3/blogs/posts/{objectId}/revisions/{revisionId} | Retrieves a previous version of a blog post |
| [**PatchCmsV3BlogsPostsObjectIdDraftUpdateDraft**](BlogPostsApi.md#patchcmsv3blogspostsobjectiddraftupdatedraft) | **PATCH** /cms/v3/blogs/posts/{objectId}/draft | Update a Blog Post draft |
| [**PatchCmsV3BlogsPostsObjectIdUpdate**](BlogPostsApi.md#patchcmsv3blogspostsobjectidupdate) | **PATCH** /cms/v3/blogs/posts/{objectId} | Update a Blog Post |
| [**PostCmsV3BlogsPostsBatchArchiveArchiveBatch**](BlogPostsApi.md#postcmsv3blogspostsbatcharchivearchivebatch) | **POST** /cms/v3/blogs/posts/batch/archive | Delete a batch of Blog Posts |
| [**PostCmsV3BlogsPostsBatchCreateCreateBatch**](BlogPostsApi.md#postcmsv3blogspostsbatchcreatecreatebatch) | **POST** /cms/v3/blogs/posts/batch/create | Create a batch of Blog Posts |
| [**PostCmsV3BlogsPostsBatchReadReadBatch**](BlogPostsApi.md#postcmsv3blogspostsbatchreadreadbatch) | **POST** /cms/v3/blogs/posts/batch/read | Retrieve a batch of Blog Posts |
| [**PostCmsV3BlogsPostsBatchUpdateUpdateBatch**](BlogPostsApi.md#postcmsv3blogspostsbatchupdateupdatebatch) | **POST** /cms/v3/blogs/posts/batch/update | Update a batch of Blog Posts |
| [**PostCmsV3BlogsPostsCloneClone**](BlogPostsApi.md#postcmsv3blogspostscloneclone) | **POST** /cms/v3/blogs/posts/clone | Clone a Blog Post |
| [**PostCmsV3BlogsPostsCreate**](BlogPostsApi.md#postcmsv3blogspostscreate) | **POST** /cms/v3/blogs/posts | Create a new Blog Post |
| [**PostCmsV3BlogsPostsMultiLanguageAttachToLangGroupAttachToLangGroup**](BlogPostsApi.md#postcmsv3blogspostsmultilanguageattachtolanggroupattachtolanggroup) | **POST** /cms/v3/blogs/posts/multi-language/attach-to-lang-group | Attach a Blog Post to a multi-language group |
| [**PostCmsV3BlogsPostsMultiLanguageCreateLanguageVariationCreateLangVariation**](BlogPostsApi.md#postcmsv3blogspostsmultilanguagecreatelanguagevariationcreatelangvariation) | **POST** /cms/v3/blogs/posts/multi-language/create-language-variation | Create a new language variation |
| [**PostCmsV3BlogsPostsMultiLanguageDetachFromLangGroupDetachFromLangGroup**](BlogPostsApi.md#postcmsv3blogspostsmultilanguagedetachfromlanggroupdetachfromlanggroup) | **POST** /cms/v3/blogs/posts/multi-language/detach-from-lang-group | Detach a Blog Post from a multi-language group |
| [**PostCmsV3BlogsPostsMultiLanguageUpdateLanguagesUpdateLangs**](BlogPostsApi.md#postcmsv3blogspostsmultilanguageupdatelanguagesupdatelangs) | **POST** /cms/v3/blogs/posts/multi-language/update-languages | Update languages of multi-language group |
| [**PostCmsV3BlogsPostsObjectIdDraftPushLivePushLive**](BlogPostsApi.md#postcmsv3blogspostsobjectiddraftpushlivepushlive) | **POST** /cms/v3/blogs/posts/{objectId}/draft/push-live | Push Blog Post draft edits live |
| [**PostCmsV3BlogsPostsObjectIdDraftResetResetDraft**](BlogPostsApi.md#postcmsv3blogspostsobjectiddraftresetresetdraft) | **POST** /cms/v3/blogs/posts/{objectId}/draft/reset | Reset the Blog Post draft to the live version |
| [**PostCmsV3BlogsPostsObjectIdRevisionsRevisionIdRestoreRestorePreviousVersion**](BlogPostsApi.md#postcmsv3blogspostsobjectidrevisionsrevisionidrestorerestorepreviousversion) | **POST** /cms/v3/blogs/posts/{objectId}/revisions/{revisionId}/restore | Restore a previous version of a blog post |
| [**PostCmsV3BlogsPostsObjectIdRevisionsRevisionIdRestoreToDraftRestorePreviousVersionToDraft**](BlogPostsApi.md#postcmsv3blogspostsobjectidrevisionsrevisionidrestoretodraftrestorepreviousversiontodraft) | **POST** /cms/v3/blogs/posts/{objectId}/revisions/{revisionId}/restore-to-draft | Restore a previous version of a blog post, to the draft version of the blog post |
| [**PostCmsV3BlogsPostsScheduleSchedule**](BlogPostsApi.md#postcmsv3blogspostsscheduleschedule) | **POST** /cms/v3/blogs/posts/schedule | Schedule a Blog Post to be Published |
| [**PutCmsV3BlogsPostsMultiLanguageSetNewLangPrimarySetLangPrimary**](BlogPostsApi.md#putcmsv3blogspostsmultilanguagesetnewlangprimarysetlangprimary) | **PUT** /cms/v3/blogs/posts/multi-language/set-new-lang-primary | Set a new primary language |

<a id="deletecmsv3blogspostsobjectidarchive"></a>
# **DeleteCmsV3BlogsPostsObjectIdArchive**
> void DeleteCmsV3BlogsPostsObjectIdArchive (string objectId, bool? archived = null)

Delete a Blog Post

Delete the Blog Post object identified by the id in the path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.BlogPosts.Api;
using HubSpot.Cms.BlogPosts.Client;
using HubSpot.Cms.BlogPosts.Model;

namespace Example
{
    public class DeleteCmsV3BlogsPostsObjectIdArchiveExample
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

            var apiInstance = new BlogPostsApi(config);
            var objectId = "objectId_example";  // string | The Blog Post id.
            var archived = true;  // bool? | Whether to return only results that have been archived. (optional) 

            try
            {
                // Delete a Blog Post
                apiInstance.DeleteCmsV3BlogsPostsObjectIdArchive(objectId, archived);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogPostsApi.DeleteCmsV3BlogsPostsObjectIdArchive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCmsV3BlogsPostsObjectIdArchiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a Blog Post
    apiInstance.DeleteCmsV3BlogsPostsObjectIdArchiveWithHttpInfo(objectId, archived);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogPostsApi.DeleteCmsV3BlogsPostsObjectIdArchiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectId** | **string** | The Blog Post id. |  |
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

<a id="getcmsv3blogspostsgetpage"></a>
# **GetCmsV3BlogsPostsGetPage**
> CollectionResponseWithTotalBlogPostForwardPaging GetCmsV3BlogsPostsGetPage (DateTime? createdAt = null, DateTime? createdAfter = null, DateTime? createdBefore = null, DateTime? updatedAt = null, DateTime? updatedAfter = null, DateTime? updatedBefore = null, List<string> sort = null, string after = null, int? limit = null, bool? archived = null)

Get all Blog Posts

Get the list of blog posts. Supports paging and filtering. This method would be useful for an integration that examined these models and used an external service to suggest edits. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.BlogPosts.Api;
using HubSpot.Cms.BlogPosts.Client;
using HubSpot.Cms.BlogPosts.Model;

namespace Example
{
    public class GetCmsV3BlogsPostsGetPageExample
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

            var apiInstance = new BlogPostsApi(config);
            var createdAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only return Blog Posts created at exactly the specified time. (optional) 
            var createdAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only return Blog Posts created after the specified time. (optional) 
            var createdBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only return Blog Posts created before the specified time. (optional) 
            var updatedAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only return Blog Posts last updated at exactly the specified time. (optional) 
            var updatedAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only return Blog Posts last updated after the specified time. (optional) 
            var updatedBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only return Blog Posts last updated before the specified time. (optional) 
            var sort = new List<string>(); // List<string> | Specifies which fields to use for sorting results. Valid fields are `name`, `createdAt`, `updatedAt`, `createdBy`, `updatedBy`. `createdAt` will be used by default. (optional) 
            var after = "after_example";  // string | The cursor token value to get the next set of results. You can get this from the `paging.next.after` JSON property of a paged response containing more results. (optional) 
            var limit = 56;  // int? | The maximum number of results to return. Default is 20. (optional) 
            var archived = true;  // bool? | Specifies whether to return deleted Blog Posts. Defaults to `false`. (optional) 

            try
            {
                // Get all Blog Posts
                CollectionResponseWithTotalBlogPostForwardPaging result = apiInstance.GetCmsV3BlogsPostsGetPage(createdAt, createdAfter, createdBefore, updatedAt, updatedAfter, updatedBefore, sort, after, limit, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogPostsApi.GetCmsV3BlogsPostsGetPage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCmsV3BlogsPostsGetPageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all Blog Posts
    ApiResponse<CollectionResponseWithTotalBlogPostForwardPaging> response = apiInstance.GetCmsV3BlogsPostsGetPageWithHttpInfo(createdAt, createdAfter, createdBefore, updatedAt, updatedAfter, updatedBefore, sort, after, limit, archived);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogPostsApi.GetCmsV3BlogsPostsGetPageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createdAt** | **DateTime?** | Only return Blog Posts created at exactly the specified time. | [optional]  |
| **createdAfter** | **DateTime?** | Only return Blog Posts created after the specified time. | [optional]  |
| **createdBefore** | **DateTime?** | Only return Blog Posts created before the specified time. | [optional]  |
| **updatedAt** | **DateTime?** | Only return Blog Posts last updated at exactly the specified time. | [optional]  |
| **updatedAfter** | **DateTime?** | Only return Blog Posts last updated after the specified time. | [optional]  |
| **updatedBefore** | **DateTime?** | Only return Blog Posts last updated before the specified time. | [optional]  |
| **sort** | [**List&lt;string&gt;**](string.md) | Specifies which fields to use for sorting results. Valid fields are &#x60;name&#x60;, &#x60;createdAt&#x60;, &#x60;updatedAt&#x60;, &#x60;createdBy&#x60;, &#x60;updatedBy&#x60;. &#x60;createdAt&#x60; will be used by default. | [optional]  |
| **after** | **string** | The cursor token value to get the next set of results. You can get this from the &#x60;paging.next.after&#x60; JSON property of a paged response containing more results. | [optional]  |
| **limit** | **int?** | The maximum number of results to return. Default is 20. | [optional]  |
| **archived** | **bool?** | Specifies whether to return deleted Blog Posts. Defaults to &#x60;false&#x60;. | [optional]  |

### Return type

[**CollectionResponseWithTotalBlogPostForwardPaging**](CollectionResponseWithTotalBlogPostForwardPaging.md)

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

<a id="getcmsv3blogspostsobjectiddraftgetdraftbyid"></a>
# **GetCmsV3BlogsPostsObjectIdDraftGetDraftById**
> BlogPost GetCmsV3BlogsPostsObjectIdDraftGetDraftById (string objectId)

Retrieve the full draft version of the Blog Post

Retrieve the full draft version of the Blog Post.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.BlogPosts.Api;
using HubSpot.Cms.BlogPosts.Client;
using HubSpot.Cms.BlogPosts.Model;

namespace Example
{
    public class GetCmsV3BlogsPostsObjectIdDraftGetDraftByIdExample
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

            var apiInstance = new BlogPostsApi(config);
            var objectId = "objectId_example";  // string | The Blog Post id.

            try
            {
                // Retrieve the full draft version of the Blog Post
                BlogPost result = apiInstance.GetCmsV3BlogsPostsObjectIdDraftGetDraftById(objectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogPostsApi.GetCmsV3BlogsPostsObjectIdDraftGetDraftById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCmsV3BlogsPostsObjectIdDraftGetDraftByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve the full draft version of the Blog Post
    ApiResponse<BlogPost> response = apiInstance.GetCmsV3BlogsPostsObjectIdDraftGetDraftByIdWithHttpInfo(objectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogPostsApi.GetCmsV3BlogsPostsObjectIdDraftGetDraftByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectId** | **string** | The Blog Post id. |  |

### Return type

[**BlogPost**](BlogPost.md)

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

<a id="getcmsv3blogspostsobjectidgetbyid"></a>
# **GetCmsV3BlogsPostsObjectIdGetById**
> BlogPost GetCmsV3BlogsPostsObjectIdGetById (string objectId, bool? archived = null)

Retrieve a Blog Post

Retrieve the Blog Post object identified by the id in the path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.BlogPosts.Api;
using HubSpot.Cms.BlogPosts.Client;
using HubSpot.Cms.BlogPosts.Model;

namespace Example
{
    public class GetCmsV3BlogsPostsObjectIdGetByIdExample
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

            var apiInstance = new BlogPostsApi(config);
            var objectId = "objectId_example";  // string | The Blog Post id.
            var archived = true;  // bool? | Specifies whether to return deleted Blog Posts. Defaults to `false`. (optional) 

            try
            {
                // Retrieve a Blog Post
                BlogPost result = apiInstance.GetCmsV3BlogsPostsObjectIdGetById(objectId, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogPostsApi.GetCmsV3BlogsPostsObjectIdGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCmsV3BlogsPostsObjectIdGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a Blog Post
    ApiResponse<BlogPost> response = apiInstance.GetCmsV3BlogsPostsObjectIdGetByIdWithHttpInfo(objectId, archived);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogPostsApi.GetCmsV3BlogsPostsObjectIdGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectId** | **string** | The Blog Post id. |  |
| **archived** | **bool?** | Specifies whether to return deleted Blog Posts. Defaults to &#x60;false&#x60;. | [optional]  |

### Return type

[**BlogPost**](BlogPost.md)

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

<a id="getcmsv3blogspostsobjectidrevisionsgetpreviousversions"></a>
# **GetCmsV3BlogsPostsObjectIdRevisionsGetPreviousVersions**
> CollectionResponseWithTotalVersionBlogPost GetCmsV3BlogsPostsObjectIdRevisionsGetPreviousVersions (string objectId, string after = null, string before = null, int? limit = null)

Retrieves all the previous versions of a blog post

Retrieves all the previous versions of a blog post.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.BlogPosts.Api;
using HubSpot.Cms.BlogPosts.Client;
using HubSpot.Cms.BlogPosts.Model;

namespace Example
{
    public class GetCmsV3BlogsPostsObjectIdRevisionsGetPreviousVersionsExample
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

            var apiInstance = new BlogPostsApi(config);
            var objectId = "objectId_example";  // string | The Blog Post id.
            var after = "after_example";  // string | The cursor token value to get the next set of results. You can get this from the `paging.next.after` JSON property of a paged response containing more results. (optional) 
            var before = "before_example";  // string |  (optional) 
            var limit = 56;  // int? | The maximum number of results to return. Default is 100. (optional) 

            try
            {
                // Retrieves all the previous versions of a blog post
                CollectionResponseWithTotalVersionBlogPost result = apiInstance.GetCmsV3BlogsPostsObjectIdRevisionsGetPreviousVersions(objectId, after, before, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogPostsApi.GetCmsV3BlogsPostsObjectIdRevisionsGetPreviousVersions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCmsV3BlogsPostsObjectIdRevisionsGetPreviousVersionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves all the previous versions of a blog post
    ApiResponse<CollectionResponseWithTotalVersionBlogPost> response = apiInstance.GetCmsV3BlogsPostsObjectIdRevisionsGetPreviousVersionsWithHttpInfo(objectId, after, before, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogPostsApi.GetCmsV3BlogsPostsObjectIdRevisionsGetPreviousVersionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectId** | **string** | The Blog Post id. |  |
| **after** | **string** | The cursor token value to get the next set of results. You can get this from the &#x60;paging.next.after&#x60; JSON property of a paged response containing more results. | [optional]  |
| **before** | **string** |  | [optional]  |
| **limit** | **int?** | The maximum number of results to return. Default is 100. | [optional]  |

### Return type

[**CollectionResponseWithTotalVersionBlogPost**](CollectionResponseWithTotalVersionBlogPost.md)

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

<a id="getcmsv3blogspostsobjectidrevisionsrevisionidgetpreviousversion"></a>
# **GetCmsV3BlogsPostsObjectIdRevisionsRevisionIdGetPreviousVersion**
> VersionBlogPost GetCmsV3BlogsPostsObjectIdRevisionsRevisionIdGetPreviousVersion (string objectId, string revisionId)

Retrieves a previous version of a blog post

Retrieves a previous version of a blog post.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.BlogPosts.Api;
using HubSpot.Cms.BlogPosts.Client;
using HubSpot.Cms.BlogPosts.Model;

namespace Example
{
    public class GetCmsV3BlogsPostsObjectIdRevisionsRevisionIdGetPreviousVersionExample
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

            var apiInstance = new BlogPostsApi(config);
            var objectId = "objectId_example";  // string | The Blog Post id.
            var revisionId = "revisionId_example";  // string | The Blog Post version id.

            try
            {
                // Retrieves a previous version of a blog post
                VersionBlogPost result = apiInstance.GetCmsV3BlogsPostsObjectIdRevisionsRevisionIdGetPreviousVersion(objectId, revisionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogPostsApi.GetCmsV3BlogsPostsObjectIdRevisionsRevisionIdGetPreviousVersion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCmsV3BlogsPostsObjectIdRevisionsRevisionIdGetPreviousVersionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a previous version of a blog post
    ApiResponse<VersionBlogPost> response = apiInstance.GetCmsV3BlogsPostsObjectIdRevisionsRevisionIdGetPreviousVersionWithHttpInfo(objectId, revisionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogPostsApi.GetCmsV3BlogsPostsObjectIdRevisionsRevisionIdGetPreviousVersionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectId** | **string** | The Blog Post id. |  |
| **revisionId** | **string** | The Blog Post version id. |  |

### Return type

[**VersionBlogPost**](VersionBlogPost.md)

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

<a id="patchcmsv3blogspostsobjectiddraftupdatedraft"></a>
# **PatchCmsV3BlogsPostsObjectIdDraftUpdateDraft**
> BlogPost PatchCmsV3BlogsPostsObjectIdDraftUpdateDraft (string objectId, BlogPost blogPost)

Update a Blog Post draft

Sparse updates the draft version of a single Blog Post object identified by the id in the path. All the column values need not be specified. Only the that need to be modified can be specified. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.BlogPosts.Api;
using HubSpot.Cms.BlogPosts.Client;
using HubSpot.Cms.BlogPosts.Model;

namespace Example
{
    public class PatchCmsV3BlogsPostsObjectIdDraftUpdateDraftExample
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

            var apiInstance = new BlogPostsApi(config);
            var objectId = "objectId_example";  // string | The Blog Post id.
            var blogPost = new BlogPost(); // BlogPost | The JSON representation of the updated Blog Post to be applied to the draft.

            try
            {
                // Update a Blog Post draft
                BlogPost result = apiInstance.PatchCmsV3BlogsPostsObjectIdDraftUpdateDraft(objectId, blogPost);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogPostsApi.PatchCmsV3BlogsPostsObjectIdDraftUpdateDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchCmsV3BlogsPostsObjectIdDraftUpdateDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a Blog Post draft
    ApiResponse<BlogPost> response = apiInstance.PatchCmsV3BlogsPostsObjectIdDraftUpdateDraftWithHttpInfo(objectId, blogPost);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogPostsApi.PatchCmsV3BlogsPostsObjectIdDraftUpdateDraftWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectId** | **string** | The Blog Post id. |  |
| **blogPost** | [**BlogPost**](BlogPost.md) | The JSON representation of the updated Blog Post to be applied to the draft. |  |

### Return type

[**BlogPost**](BlogPost.md)

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

<a id="patchcmsv3blogspostsobjectidupdate"></a>
# **PatchCmsV3BlogsPostsObjectIdUpdate**
> BlogPost PatchCmsV3BlogsPostsObjectIdUpdate (string objectId, BlogPost blogPost, bool? archived = null)

Update a Blog Post

Sparse updates a single Blog Post object identified by the id in the path. All the column values need not be specified. Only the that need to be modified can be specified. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.BlogPosts.Api;
using HubSpot.Cms.BlogPosts.Client;
using HubSpot.Cms.BlogPosts.Model;

namespace Example
{
    public class PatchCmsV3BlogsPostsObjectIdUpdateExample
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

            var apiInstance = new BlogPostsApi(config);
            var objectId = "objectId_example";  // string | The Blog Post id.
            var blogPost = new BlogPost(); // BlogPost | The JSON representation of the updated Blog Post.
            var archived = true;  // bool? | Specifies whether to update deleted Blog Posts. Defaults to `false`. (optional) 

            try
            {
                // Update a Blog Post
                BlogPost result = apiInstance.PatchCmsV3BlogsPostsObjectIdUpdate(objectId, blogPost, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogPostsApi.PatchCmsV3BlogsPostsObjectIdUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchCmsV3BlogsPostsObjectIdUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a Blog Post
    ApiResponse<BlogPost> response = apiInstance.PatchCmsV3BlogsPostsObjectIdUpdateWithHttpInfo(objectId, blogPost, archived);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogPostsApi.PatchCmsV3BlogsPostsObjectIdUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectId** | **string** | The Blog Post id. |  |
| **blogPost** | [**BlogPost**](BlogPost.md) | The JSON representation of the updated Blog Post. |  |
| **archived** | **bool?** | Specifies whether to update deleted Blog Posts. Defaults to &#x60;false&#x60;. | [optional]  |

### Return type

[**BlogPost**](BlogPost.md)

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

<a id="postcmsv3blogspostsbatcharchivearchivebatch"></a>
# **PostCmsV3BlogsPostsBatchArchiveArchiveBatch**
> void PostCmsV3BlogsPostsBatchArchiveArchiveBatch (BatchInputString batchInputString)

Delete a batch of Blog Posts

Delete the Blog Post objects identified in the request body. Note: This is not the same as the in-app `archive` function. To perform a dashboard `archive` send an normal update with the `archivedInDashboard` field set to true.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.BlogPosts.Api;
using HubSpot.Cms.BlogPosts.Client;
using HubSpot.Cms.BlogPosts.Model;

namespace Example
{
    public class PostCmsV3BlogsPostsBatchArchiveArchiveBatchExample
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

            var apiInstance = new BlogPostsApi(config);
            var batchInputString = new BatchInputString(); // BatchInputString | The JSON array of Blog Post ids.

            try
            {
                // Delete a batch of Blog Posts
                apiInstance.PostCmsV3BlogsPostsBatchArchiveArchiveBatch(batchInputString);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsBatchArchiveArchiveBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3BlogsPostsBatchArchiveArchiveBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a batch of Blog Posts
    apiInstance.PostCmsV3BlogsPostsBatchArchiveArchiveBatchWithHttpInfo(batchInputString);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsBatchArchiveArchiveBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchInputString** | [**BatchInputString**](BatchInputString.md) | The JSON array of Blog Post ids. |  |

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

<a id="postcmsv3blogspostsbatchcreatecreatebatch"></a>
# **PostCmsV3BlogsPostsBatchCreateCreateBatch**
> BatchResponseBlogPost PostCmsV3BlogsPostsBatchCreateCreateBatch (BatchInputBlogPost batchInputBlogPost)

Create a batch of Blog Posts

Create the Blog Post objects detailed in the request body.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.BlogPosts.Api;
using HubSpot.Cms.BlogPosts.Client;
using HubSpot.Cms.BlogPosts.Model;

namespace Example
{
    public class PostCmsV3BlogsPostsBatchCreateCreateBatchExample
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

            var apiInstance = new BlogPostsApi(config);
            var batchInputBlogPost = new BatchInputBlogPost(); // BatchInputBlogPost | The JSON array of new Blog Posts to create.

            try
            {
                // Create a batch of Blog Posts
                BatchResponseBlogPost result = apiInstance.PostCmsV3BlogsPostsBatchCreateCreateBatch(batchInputBlogPost);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsBatchCreateCreateBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3BlogsPostsBatchCreateCreateBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a batch of Blog Posts
    ApiResponse<BatchResponseBlogPost> response = apiInstance.PostCmsV3BlogsPostsBatchCreateCreateBatchWithHttpInfo(batchInputBlogPost);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsBatchCreateCreateBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchInputBlogPost** | [**BatchInputBlogPost**](BatchInputBlogPost.md) | The JSON array of new Blog Posts to create. |  |

### Return type

[**BatchResponseBlogPost**](BatchResponseBlogPost.md)

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

<a id="postcmsv3blogspostsbatchreadreadbatch"></a>
# **PostCmsV3BlogsPostsBatchReadReadBatch**
> BatchResponseBlogPost PostCmsV3BlogsPostsBatchReadReadBatch (BatchInputString batchInputString, bool? archived = null)

Retrieve a batch of Blog Posts

Retrieve the Blog Post objects identified in the request body.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.BlogPosts.Api;
using HubSpot.Cms.BlogPosts.Client;
using HubSpot.Cms.BlogPosts.Model;

namespace Example
{
    public class PostCmsV3BlogsPostsBatchReadReadBatchExample
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

            var apiInstance = new BlogPostsApi(config);
            var batchInputString = new BatchInputString(); // BatchInputString | The JSON array of Blog Post ids.
            var archived = true;  // bool? | Specifies whether to return deleted Blog Posts. Defaults to `false`. (optional) 

            try
            {
                // Retrieve a batch of Blog Posts
                BatchResponseBlogPost result = apiInstance.PostCmsV3BlogsPostsBatchReadReadBatch(batchInputString, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsBatchReadReadBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3BlogsPostsBatchReadReadBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a batch of Blog Posts
    ApiResponse<BatchResponseBlogPost> response = apiInstance.PostCmsV3BlogsPostsBatchReadReadBatchWithHttpInfo(batchInputString, archived);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsBatchReadReadBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchInputString** | [**BatchInputString**](BatchInputString.md) | The JSON array of Blog Post ids. |  |
| **archived** | **bool?** | Specifies whether to return deleted Blog Posts. Defaults to &#x60;false&#x60;. | [optional]  |

### Return type

[**BatchResponseBlogPost**](BatchResponseBlogPost.md)

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

<a id="postcmsv3blogspostsbatchupdateupdatebatch"></a>
# **PostCmsV3BlogsPostsBatchUpdateUpdateBatch**
> BatchResponseBlogPost PostCmsV3BlogsPostsBatchUpdateUpdateBatch (BatchInputJsonNode batchInputJsonNode, bool? archived = null)

Update a batch of Blog Posts

Update the Blog Post objects identified in the request body.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.BlogPosts.Api;
using HubSpot.Cms.BlogPosts.Client;
using HubSpot.Cms.BlogPosts.Model;

namespace Example
{
    public class PostCmsV3BlogsPostsBatchUpdateUpdateBatchExample
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

            var apiInstance = new BlogPostsApi(config);
            var batchInputJsonNode = new BatchInputJsonNode(); // BatchInputJsonNode | A JSON array of the JSON representations of the updated Blog Posts.
            var archived = true;  // bool? | Specifies whether to update deleted Blog Posts. Defaults to `false`. (optional) 

            try
            {
                // Update a batch of Blog Posts
                BatchResponseBlogPost result = apiInstance.PostCmsV3BlogsPostsBatchUpdateUpdateBatch(batchInputJsonNode, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsBatchUpdateUpdateBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3BlogsPostsBatchUpdateUpdateBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a batch of Blog Posts
    ApiResponse<BatchResponseBlogPost> response = apiInstance.PostCmsV3BlogsPostsBatchUpdateUpdateBatchWithHttpInfo(batchInputJsonNode, archived);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsBatchUpdateUpdateBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchInputJsonNode** | [**BatchInputJsonNode**](BatchInputJsonNode.md) | A JSON array of the JSON representations of the updated Blog Posts. |  |
| **archived** | **bool?** | Specifies whether to update deleted Blog Posts. Defaults to &#x60;false&#x60;. | [optional]  |

### Return type

[**BatchResponseBlogPost**](BatchResponseBlogPost.md)

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

<a id="postcmsv3blogspostscloneclone"></a>
# **PostCmsV3BlogsPostsCloneClone**
> BlogPost PostCmsV3BlogsPostsCloneClone (ContentCloneRequestVNext contentCloneRequestVNext)

Clone a Blog Post

Clone a Blog Post.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.BlogPosts.Api;
using HubSpot.Cms.BlogPosts.Client;
using HubSpot.Cms.BlogPosts.Model;

namespace Example
{
    public class PostCmsV3BlogsPostsCloneCloneExample
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

            var apiInstance = new BlogPostsApi(config);
            var contentCloneRequestVNext = new ContentCloneRequestVNext(); // ContentCloneRequestVNext | The JSON representation of the ContentCloneRequest object.

            try
            {
                // Clone a Blog Post
                BlogPost result = apiInstance.PostCmsV3BlogsPostsCloneClone(contentCloneRequestVNext);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsCloneClone: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3BlogsPostsCloneCloneWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Clone a Blog Post
    ApiResponse<BlogPost> response = apiInstance.PostCmsV3BlogsPostsCloneCloneWithHttpInfo(contentCloneRequestVNext);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsCloneCloneWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentCloneRequestVNext** | [**ContentCloneRequestVNext**](ContentCloneRequestVNext.md) | The JSON representation of the ContentCloneRequest object. |  |

### Return type

[**BlogPost**](BlogPost.md)

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

<a id="postcmsv3blogspostscreate"></a>
# **PostCmsV3BlogsPostsCreate**
> BlogPost PostCmsV3BlogsPostsCreate (BlogPost blogPost)

Create a new Blog Post

Create a new Blog Post.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.BlogPosts.Api;
using HubSpot.Cms.BlogPosts.Client;
using HubSpot.Cms.BlogPosts.Model;

namespace Example
{
    public class PostCmsV3BlogsPostsCreateExample
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

            var apiInstance = new BlogPostsApi(config);
            var blogPost = new BlogPost(); // BlogPost | The JSON representation of a new Blog Post.

            try
            {
                // Create a new Blog Post
                BlogPost result = apiInstance.PostCmsV3BlogsPostsCreate(blogPost);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3BlogsPostsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Blog Post
    ApiResponse<BlogPost> response = apiInstance.PostCmsV3BlogsPostsCreateWithHttpInfo(blogPost);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blogPost** | [**BlogPost**](BlogPost.md) | The JSON representation of a new Blog Post. |  |

### Return type

[**BlogPost**](BlogPost.md)

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

<a id="postcmsv3blogspostsmultilanguageattachtolanggroupattachtolanggroup"></a>
# **PostCmsV3BlogsPostsMultiLanguageAttachToLangGroupAttachToLangGroup**
> Error PostCmsV3BlogsPostsMultiLanguageAttachToLangGroupAttachToLangGroup (AttachToLangPrimaryRequestVNext attachToLangPrimaryRequestVNext)

Attach a Blog Post to a multi-language group

Attach a Blog Post to a multi-language group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.BlogPosts.Api;
using HubSpot.Cms.BlogPosts.Client;
using HubSpot.Cms.BlogPosts.Model;

namespace Example
{
    public class PostCmsV3BlogsPostsMultiLanguageAttachToLangGroupAttachToLangGroupExample
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

            var apiInstance = new BlogPostsApi(config);
            var attachToLangPrimaryRequestVNext = new AttachToLangPrimaryRequestVNext(); // AttachToLangPrimaryRequestVNext | The JSON representation of the AttachToLangPrimaryRequest object.

            try
            {
                // Attach a Blog Post to a multi-language group
                Error result = apiInstance.PostCmsV3BlogsPostsMultiLanguageAttachToLangGroupAttachToLangGroup(attachToLangPrimaryRequestVNext);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsMultiLanguageAttachToLangGroupAttachToLangGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3BlogsPostsMultiLanguageAttachToLangGroupAttachToLangGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Attach a Blog Post to a multi-language group
    ApiResponse<Error> response = apiInstance.PostCmsV3BlogsPostsMultiLanguageAttachToLangGroupAttachToLangGroupWithHttpInfo(attachToLangPrimaryRequestVNext);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsMultiLanguageAttachToLangGroupAttachToLangGroupWithHttpInfo: " + e.Message);
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

<a id="postcmsv3blogspostsmultilanguagecreatelanguagevariationcreatelangvariation"></a>
# **PostCmsV3BlogsPostsMultiLanguageCreateLanguageVariationCreateLangVariation**
> BlogPost PostCmsV3BlogsPostsMultiLanguageCreateLanguageVariationCreateLangVariation (BlogPostLanguageCloneRequestVNext blogPostLanguageCloneRequestVNext)

Create a new language variation

Create a new language variation from an existing Blog Post

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.BlogPosts.Api;
using HubSpot.Cms.BlogPosts.Client;
using HubSpot.Cms.BlogPosts.Model;

namespace Example
{
    public class PostCmsV3BlogsPostsMultiLanguageCreateLanguageVariationCreateLangVariationExample
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

            var apiInstance = new BlogPostsApi(config);
            var blogPostLanguageCloneRequestVNext = new BlogPostLanguageCloneRequestVNext(); // BlogPostLanguageCloneRequestVNext | The JSON representation of the BlogPostLanguageCloneRequestVNext object.

            try
            {
                // Create a new language variation
                BlogPost result = apiInstance.PostCmsV3BlogsPostsMultiLanguageCreateLanguageVariationCreateLangVariation(blogPostLanguageCloneRequestVNext);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsMultiLanguageCreateLanguageVariationCreateLangVariation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3BlogsPostsMultiLanguageCreateLanguageVariationCreateLangVariationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new language variation
    ApiResponse<BlogPost> response = apiInstance.PostCmsV3BlogsPostsMultiLanguageCreateLanguageVariationCreateLangVariationWithHttpInfo(blogPostLanguageCloneRequestVNext);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsMultiLanguageCreateLanguageVariationCreateLangVariationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blogPostLanguageCloneRequestVNext** | [**BlogPostLanguageCloneRequestVNext**](BlogPostLanguageCloneRequestVNext.md) | The JSON representation of the BlogPostLanguageCloneRequestVNext object. |  |

### Return type

[**BlogPost**](BlogPost.md)

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

<a id="postcmsv3blogspostsmultilanguagedetachfromlanggroupdetachfromlanggroup"></a>
# **PostCmsV3BlogsPostsMultiLanguageDetachFromLangGroupDetachFromLangGroup**
> Error PostCmsV3BlogsPostsMultiLanguageDetachFromLangGroupDetachFromLangGroup (DetachFromLangGroupRequestVNext detachFromLangGroupRequestVNext)

Detach a Blog Post from a multi-language group

Detach a Blog Post from a multi-language group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.BlogPosts.Api;
using HubSpot.Cms.BlogPosts.Client;
using HubSpot.Cms.BlogPosts.Model;

namespace Example
{
    public class PostCmsV3BlogsPostsMultiLanguageDetachFromLangGroupDetachFromLangGroupExample
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

            var apiInstance = new BlogPostsApi(config);
            var detachFromLangGroupRequestVNext = new DetachFromLangGroupRequestVNext(); // DetachFromLangGroupRequestVNext | The JSON representation of the DetachFromLangGroupRequest object.

            try
            {
                // Detach a Blog Post from a multi-language group
                Error result = apiInstance.PostCmsV3BlogsPostsMultiLanguageDetachFromLangGroupDetachFromLangGroup(detachFromLangGroupRequestVNext);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsMultiLanguageDetachFromLangGroupDetachFromLangGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3BlogsPostsMultiLanguageDetachFromLangGroupDetachFromLangGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Detach a Blog Post from a multi-language group
    ApiResponse<Error> response = apiInstance.PostCmsV3BlogsPostsMultiLanguageDetachFromLangGroupDetachFromLangGroupWithHttpInfo(detachFromLangGroupRequestVNext);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsMultiLanguageDetachFromLangGroupDetachFromLangGroupWithHttpInfo: " + e.Message);
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

<a id="postcmsv3blogspostsmultilanguageupdatelanguagesupdatelangs"></a>
# **PostCmsV3BlogsPostsMultiLanguageUpdateLanguagesUpdateLangs**
> Error PostCmsV3BlogsPostsMultiLanguageUpdateLanguagesUpdateLangs (UpdateLanguagesRequestVNext updateLanguagesRequestVNext)

Update languages of multi-language group

Explicitly set new languages for each Blog Post in a multi-language group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.BlogPosts.Api;
using HubSpot.Cms.BlogPosts.Client;
using HubSpot.Cms.BlogPosts.Model;

namespace Example
{
    public class PostCmsV3BlogsPostsMultiLanguageUpdateLanguagesUpdateLangsExample
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

            var apiInstance = new BlogPostsApi(config);
            var updateLanguagesRequestVNext = new UpdateLanguagesRequestVNext(); // UpdateLanguagesRequestVNext | The JSON representation of the SetNewLanguagePrimaryRequest object.

            try
            {
                // Update languages of multi-language group
                Error result = apiInstance.PostCmsV3BlogsPostsMultiLanguageUpdateLanguagesUpdateLangs(updateLanguagesRequestVNext);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsMultiLanguageUpdateLanguagesUpdateLangs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3BlogsPostsMultiLanguageUpdateLanguagesUpdateLangsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update languages of multi-language group
    ApiResponse<Error> response = apiInstance.PostCmsV3BlogsPostsMultiLanguageUpdateLanguagesUpdateLangsWithHttpInfo(updateLanguagesRequestVNext);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsMultiLanguageUpdateLanguagesUpdateLangsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateLanguagesRequestVNext** | [**UpdateLanguagesRequestVNext**](UpdateLanguagesRequestVNext.md) | The JSON representation of the SetNewLanguagePrimaryRequest object. |  |

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

<a id="postcmsv3blogspostsobjectiddraftpushlivepushlive"></a>
# **PostCmsV3BlogsPostsObjectIdDraftPushLivePushLive**
> void PostCmsV3BlogsPostsObjectIdDraftPushLivePushLive (string objectId)

Push Blog Post draft edits live

Take any changes from the draft version of the Blog Post and apply them to the live version.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.BlogPosts.Api;
using HubSpot.Cms.BlogPosts.Client;
using HubSpot.Cms.BlogPosts.Model;

namespace Example
{
    public class PostCmsV3BlogsPostsObjectIdDraftPushLivePushLiveExample
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

            var apiInstance = new BlogPostsApi(config);
            var objectId = "objectId_example";  // string | The id of the Blog Post for which it's draft will be pushed live.

            try
            {
                // Push Blog Post draft edits live
                apiInstance.PostCmsV3BlogsPostsObjectIdDraftPushLivePushLive(objectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsObjectIdDraftPushLivePushLive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3BlogsPostsObjectIdDraftPushLivePushLiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Push Blog Post draft edits live
    apiInstance.PostCmsV3BlogsPostsObjectIdDraftPushLivePushLiveWithHttpInfo(objectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsObjectIdDraftPushLivePushLiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectId** | **string** | The id of the Blog Post for which it&#39;s draft will be pushed live. |  |

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

<a id="postcmsv3blogspostsobjectiddraftresetresetdraft"></a>
# **PostCmsV3BlogsPostsObjectIdDraftResetResetDraft**
> void PostCmsV3BlogsPostsObjectIdDraftResetResetDraft (string objectId)

Reset the Blog Post draft to the live version

Discards any edits and resets the draft to the live version.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.BlogPosts.Api;
using HubSpot.Cms.BlogPosts.Client;
using HubSpot.Cms.BlogPosts.Model;

namespace Example
{
    public class PostCmsV3BlogsPostsObjectIdDraftResetResetDraftExample
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

            var apiInstance = new BlogPostsApi(config);
            var objectId = "objectId_example";  // string | The id of the Blog Post for which it's draft will be reset.

            try
            {
                // Reset the Blog Post draft to the live version
                apiInstance.PostCmsV3BlogsPostsObjectIdDraftResetResetDraft(objectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsObjectIdDraftResetResetDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3BlogsPostsObjectIdDraftResetResetDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reset the Blog Post draft to the live version
    apiInstance.PostCmsV3BlogsPostsObjectIdDraftResetResetDraftWithHttpInfo(objectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsObjectIdDraftResetResetDraftWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectId** | **string** | The id of the Blog Post for which it&#39;s draft will be reset. |  |

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

<a id="postcmsv3blogspostsobjectidrevisionsrevisionidrestorerestorepreviousversion"></a>
# **PostCmsV3BlogsPostsObjectIdRevisionsRevisionIdRestoreRestorePreviousVersion**
> BlogPost PostCmsV3BlogsPostsObjectIdRevisionsRevisionIdRestoreRestorePreviousVersion (string objectId, string revisionId)

Restore a previous version of a blog post

Takes a specified version of a blog post and restores it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.BlogPosts.Api;
using HubSpot.Cms.BlogPosts.Client;
using HubSpot.Cms.BlogPosts.Model;

namespace Example
{
    public class PostCmsV3BlogsPostsObjectIdRevisionsRevisionIdRestoreRestorePreviousVersionExample
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

            var apiInstance = new BlogPostsApi(config);
            var objectId = "objectId_example";  // string | The Blog Post id.
            var revisionId = "revisionId_example";  // string | The Blog Post version id to restore.

            try
            {
                // Restore a previous version of a blog post
                BlogPost result = apiInstance.PostCmsV3BlogsPostsObjectIdRevisionsRevisionIdRestoreRestorePreviousVersion(objectId, revisionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsObjectIdRevisionsRevisionIdRestoreRestorePreviousVersion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3BlogsPostsObjectIdRevisionsRevisionIdRestoreRestorePreviousVersionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Restore a previous version of a blog post
    ApiResponse<BlogPost> response = apiInstance.PostCmsV3BlogsPostsObjectIdRevisionsRevisionIdRestoreRestorePreviousVersionWithHttpInfo(objectId, revisionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsObjectIdRevisionsRevisionIdRestoreRestorePreviousVersionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectId** | **string** | The Blog Post id. |  |
| **revisionId** | **string** | The Blog Post version id to restore. |  |

### Return type

[**BlogPost**](BlogPost.md)

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

<a id="postcmsv3blogspostsobjectidrevisionsrevisionidrestoretodraftrestorepreviousversiontodraft"></a>
# **PostCmsV3BlogsPostsObjectIdRevisionsRevisionIdRestoreToDraftRestorePreviousVersionToDraft**
> BlogPost PostCmsV3BlogsPostsObjectIdRevisionsRevisionIdRestoreToDraftRestorePreviousVersionToDraft (string objectId, long revisionId)

Restore a previous version of a blog post, to the draft version of the blog post

Takes a specified version of a blog post, sets it as the new draft version of the blog post.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.BlogPosts.Api;
using HubSpot.Cms.BlogPosts.Client;
using HubSpot.Cms.BlogPosts.Model;

namespace Example
{
    public class PostCmsV3BlogsPostsObjectIdRevisionsRevisionIdRestoreToDraftRestorePreviousVersionToDraftExample
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

            var apiInstance = new BlogPostsApi(config);
            var objectId = "objectId_example";  // string | The Blog Post id.
            var revisionId = 789L;  // long | The Blog Post version id to restore.

            try
            {
                // Restore a previous version of a blog post, to the draft version of the blog post
                BlogPost result = apiInstance.PostCmsV3BlogsPostsObjectIdRevisionsRevisionIdRestoreToDraftRestorePreviousVersionToDraft(objectId, revisionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsObjectIdRevisionsRevisionIdRestoreToDraftRestorePreviousVersionToDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3BlogsPostsObjectIdRevisionsRevisionIdRestoreToDraftRestorePreviousVersionToDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Restore a previous version of a blog post, to the draft version of the blog post
    ApiResponse<BlogPost> response = apiInstance.PostCmsV3BlogsPostsObjectIdRevisionsRevisionIdRestoreToDraftRestorePreviousVersionToDraftWithHttpInfo(objectId, revisionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsObjectIdRevisionsRevisionIdRestoreToDraftRestorePreviousVersionToDraftWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectId** | **string** | The Blog Post id. |  |
| **revisionId** | **long** | The Blog Post version id to restore. |  |

### Return type

[**BlogPost**](BlogPost.md)

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

<a id="postcmsv3blogspostsscheduleschedule"></a>
# **PostCmsV3BlogsPostsScheduleSchedule**
> void PostCmsV3BlogsPostsScheduleSchedule (ContentScheduleRequestVNext contentScheduleRequestVNext)

Schedule a Blog Post to be Published

Schedule a Blog Post to be Published.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.BlogPosts.Api;
using HubSpot.Cms.BlogPosts.Client;
using HubSpot.Cms.BlogPosts.Model;

namespace Example
{
    public class PostCmsV3BlogsPostsScheduleScheduleExample
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

            var apiInstance = new BlogPostsApi(config);
            var contentScheduleRequestVNext = new ContentScheduleRequestVNext(); // ContentScheduleRequestVNext | The JSON representation of the ContentScheduleRequestVNext object.

            try
            {
                // Schedule a Blog Post to be Published
                apiInstance.PostCmsV3BlogsPostsScheduleSchedule(contentScheduleRequestVNext);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsScheduleSchedule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3BlogsPostsScheduleScheduleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Schedule a Blog Post to be Published
    apiInstance.PostCmsV3BlogsPostsScheduleScheduleWithHttpInfo(contentScheduleRequestVNext);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogPostsApi.PostCmsV3BlogsPostsScheduleScheduleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentScheduleRequestVNext** | [**ContentScheduleRequestVNext**](ContentScheduleRequestVNext.md) | The JSON representation of the ContentScheduleRequestVNext object. |  |

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

<a id="putcmsv3blogspostsmultilanguagesetnewlangprimarysetlangprimary"></a>
# **PutCmsV3BlogsPostsMultiLanguageSetNewLangPrimarySetLangPrimary**
> void PutCmsV3BlogsPostsMultiLanguageSetNewLangPrimarySetLangPrimary (SetNewLanguagePrimaryRequestVNext setNewLanguagePrimaryRequestVNext)

Set a new primary language

Set a Blog Post as the primary language of a multi-language group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.BlogPosts.Api;
using HubSpot.Cms.BlogPosts.Client;
using HubSpot.Cms.BlogPosts.Model;

namespace Example
{
    public class PutCmsV3BlogsPostsMultiLanguageSetNewLangPrimarySetLangPrimaryExample
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

            var apiInstance = new BlogPostsApi(config);
            var setNewLanguagePrimaryRequestVNext = new SetNewLanguagePrimaryRequestVNext(); // SetNewLanguagePrimaryRequestVNext | The JSON representation of the SetNewLanguagePrimaryRequest object.

            try
            {
                // Set a new primary language
                apiInstance.PutCmsV3BlogsPostsMultiLanguageSetNewLangPrimarySetLangPrimary(setNewLanguagePrimaryRequestVNext);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlogPostsApi.PutCmsV3BlogsPostsMultiLanguageSetNewLangPrimarySetLangPrimary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutCmsV3BlogsPostsMultiLanguageSetNewLangPrimarySetLangPrimaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set a new primary language
    apiInstance.PutCmsV3BlogsPostsMultiLanguageSetNewLangPrimarySetLangPrimaryWithHttpInfo(setNewLanguagePrimaryRequestVNext);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlogPostsApi.PutCmsV3BlogsPostsMultiLanguageSetNewLangPrimarySetLangPrimaryWithHttpInfo: " + e.Message);
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

