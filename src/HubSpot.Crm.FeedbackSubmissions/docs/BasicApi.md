# HubSpot.Crm.FeedbackSubmissions.Api.BasicApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdArchive**](BasicApi.md#deletecrmv3objectsfeedbacksubmissionsfeedbacksubmissionidarchive) | **DELETE** /crm/v3/objects/feedback_submissions/{feedbackSubmissionId} | Archive |
| [**GetCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdGetById**](BasicApi.md#getcrmv3objectsfeedbacksubmissionsfeedbacksubmissionidgetbyid) | **GET** /crm/v3/objects/feedback_submissions/{feedbackSubmissionId} | Read |
| [**GetCrmV3ObjectsFeedbackSubmissionsGetPage**](BasicApi.md#getcrmv3objectsfeedbacksubmissionsgetpage) | **GET** /crm/v3/objects/feedback_submissions | List |
| [**PatchCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdUpdate**](BasicApi.md#patchcrmv3objectsfeedbacksubmissionsfeedbacksubmissionidupdate) | **PATCH** /crm/v3/objects/feedback_submissions/{feedbackSubmissionId} | Update |
| [**PostCrmV3ObjectsFeedbackSubmissionsCreate**](BasicApi.md#postcrmv3objectsfeedbacksubmissionscreate) | **POST** /crm/v3/objects/feedback_submissions | Create |

<a id="deletecrmv3objectsfeedbacksubmissionsfeedbacksubmissionidarchive"></a>
# **DeleteCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdArchive**
> void DeleteCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdArchive (string feedbackSubmissionId)

Archive

Move an Object identified by `{feedbackSubmissionId}` to the recycling bin.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.FeedbackSubmissions.Api;
using HubSpot.Crm.FeedbackSubmissions.Client;
using HubSpot.Crm.FeedbackSubmissions.Model;

namespace Example
{
    public class DeleteCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdArchiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: private_apps
            config.AddApiKey("private-app", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app", "Bearer");

            var apiInstance = new BasicApi(config);
            var feedbackSubmissionId = "feedbackSubmissionId_example";  // string | 

            try
            {
                // Archive
                apiInstance.DeleteCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdArchive(feedbackSubmissionId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicApi.DeleteCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdArchive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdArchiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Archive
    apiInstance.DeleteCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdArchiveWithHttpInfo(feedbackSubmissionId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicApi.DeleteCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdArchiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **feedbackSubmissionId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcrmv3objectsfeedbacksubmissionsfeedbacksubmissionidgetbyid"></a>
# **GetCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdGetById**
> SimplePublicObjectWithAssociations GetCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdGetById (string feedbackSubmissionId, List<string> properties = null, List<string> propertiesWithHistory = null, List<string> associations = null, bool? archived = null, string idProperty = null)

Read

Read an Object identified by `{feedbackSubmissionId}`. `{feedbackSubmissionId}` refers to the internal object ID by default, or optionally any unique property value as specified by the `idProperty` query param.  Control what is returned via the `properties` query param.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.FeedbackSubmissions.Api;
using HubSpot.Crm.FeedbackSubmissions.Client;
using HubSpot.Crm.FeedbackSubmissions.Model;

namespace Example
{
    public class GetCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: private_apps
            config.AddApiKey("private-app", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app", "Bearer");

            var apiInstance = new BasicApi(config);
            var feedbackSubmissionId = "feedbackSubmissionId_example";  // string | 
            var properties = new List<string>(); // List<string> | A comma separated list of the properties to be returned in the response. If any of the specified properties are not present on the requested object(s), they will be ignored. (optional) 
            var propertiesWithHistory = new List<string>(); // List<string> | A comma separated list of the properties to be returned along with their history of previous values. If any of the specified properties are not present on the requested object(s), they will be ignored. (optional) 
            var associations = new List<string>(); // List<string> | A comma separated list of object types to retrieve associated IDs for. If any of the specified associations do not exist, they will be ignored. (optional) 
            var archived = false;  // bool? | Whether to return only results that have been archived. (optional)  (default to false)
            var idProperty = "idProperty_example";  // string | The name of a property whose values are unique for this object type (optional) 

            try
            {
                // Read
                SimplePublicObjectWithAssociations result = apiInstance.GetCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdGetById(feedbackSubmissionId, properties, propertiesWithHistory, associations, archived, idProperty);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicApi.GetCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read
    ApiResponse<SimplePublicObjectWithAssociations> response = apiInstance.GetCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdGetByIdWithHttpInfo(feedbackSubmissionId, properties, propertiesWithHistory, associations, archived, idProperty);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicApi.GetCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **feedbackSubmissionId** | **string** |  |  |
| **properties** | [**List&lt;string&gt;**](string.md) | A comma separated list of the properties to be returned in the response. If any of the specified properties are not present on the requested object(s), they will be ignored. | [optional]  |
| **propertiesWithHistory** | [**List&lt;string&gt;**](string.md) | A comma separated list of the properties to be returned along with their history of previous values. If any of the specified properties are not present on the requested object(s), they will be ignored. | [optional]  |
| **associations** | [**List&lt;string&gt;**](string.md) | A comma separated list of object types to retrieve associated IDs for. If any of the specified associations do not exist, they will be ignored. | [optional]  |
| **archived** | **bool?** | Whether to return only results that have been archived. | [optional] [default to false] |
| **idProperty** | **string** | The name of a property whose values are unique for this object type | [optional]  |

### Return type

[**SimplePublicObjectWithAssociations**](SimplePublicObjectWithAssociations.md)

### Authorization

[hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcrmv3objectsfeedbacksubmissionsgetpage"></a>
# **GetCrmV3ObjectsFeedbackSubmissionsGetPage**
> CollectionResponseSimplePublicObjectWithAssociationsForwardPaging GetCrmV3ObjectsFeedbackSubmissionsGetPage (int? limit = null, string after = null, List<string> properties = null, List<string> propertiesWithHistory = null, List<string> associations = null, bool? archived = null)

List

Read a page of feedback submissions. Control what is returned via the `properties` query param.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.FeedbackSubmissions.Api;
using HubSpot.Crm.FeedbackSubmissions.Client;
using HubSpot.Crm.FeedbackSubmissions.Model;

namespace Example
{
    public class GetCrmV3ObjectsFeedbackSubmissionsGetPageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: private_apps
            config.AddApiKey("private-app", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app", "Bearer");

            var apiInstance = new BasicApi(config);
            var limit = 10;  // int? | The maximum number of results to display per page. (optional)  (default to 10)
            var after = "after_example";  // string | The paging cursor token of the last successfully read resource will be returned as the `paging.next.after` JSON property of a paged response containing more results. (optional) 
            var properties = new List<string>(); // List<string> | A comma separated list of the properties to be returned in the response. If any of the specified properties are not present on the requested object(s), they will be ignored. (optional) 
            var propertiesWithHistory = new List<string>(); // List<string> | A comma separated list of the properties to be returned along with their history of previous values. If any of the specified properties are not present on the requested object(s), they will be ignored. Usage of this parameter will reduce the maximum number of objects that can be read by a single request. (optional) 
            var associations = new List<string>(); // List<string> | A comma separated list of object types to retrieve associated IDs for. If any of the specified associations do not exist, they will be ignored. (optional) 
            var archived = false;  // bool? | Whether to return only results that have been archived. (optional)  (default to false)

            try
            {
                // List
                CollectionResponseSimplePublicObjectWithAssociationsForwardPaging result = apiInstance.GetCrmV3ObjectsFeedbackSubmissionsGetPage(limit, after, properties, propertiesWithHistory, associations, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicApi.GetCrmV3ObjectsFeedbackSubmissionsGetPage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCrmV3ObjectsFeedbackSubmissionsGetPageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List
    ApiResponse<CollectionResponseSimplePublicObjectWithAssociationsForwardPaging> response = apiInstance.GetCrmV3ObjectsFeedbackSubmissionsGetPageWithHttpInfo(limit, after, properties, propertiesWithHistory, associations, archived);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicApi.GetCrmV3ObjectsFeedbackSubmissionsGetPageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** | The maximum number of results to display per page. | [optional] [default to 10] |
| **after** | **string** | The paging cursor token of the last successfully read resource will be returned as the &#x60;paging.next.after&#x60; JSON property of a paged response containing more results. | [optional]  |
| **properties** | [**List&lt;string&gt;**](string.md) | A comma separated list of the properties to be returned in the response. If any of the specified properties are not present on the requested object(s), they will be ignored. | [optional]  |
| **propertiesWithHistory** | [**List&lt;string&gt;**](string.md) | A comma separated list of the properties to be returned along with their history of previous values. If any of the specified properties are not present on the requested object(s), they will be ignored. Usage of this parameter will reduce the maximum number of objects that can be read by a single request. | [optional]  |
| **associations** | [**List&lt;string&gt;**](string.md) | A comma separated list of object types to retrieve associated IDs for. If any of the specified associations do not exist, they will be ignored. | [optional]  |
| **archived** | **bool?** | Whether to return only results that have been archived. | [optional] [default to false] |

### Return type

[**CollectionResponseSimplePublicObjectWithAssociationsForwardPaging**](CollectionResponseSimplePublicObjectWithAssociationsForwardPaging.md)

### Authorization

[hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="patchcrmv3objectsfeedbacksubmissionsfeedbacksubmissionidupdate"></a>
# **PatchCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdUpdate**
> SimplePublicObject PatchCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdUpdate (string feedbackSubmissionId, SimplePublicObjectInput simplePublicObjectInput, string idProperty = null)

Update

Perform a partial update of an Object identified by `{feedbackSubmissionId}`. `{feedbackSubmissionId}` refers to the internal object ID by default, or optionally any unique property value as specified by the `idProperty` query param. Provided property values will be overwritten. Read-only and non-existent properties will be ignored. Properties values can be cleared by passing an empty string.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.FeedbackSubmissions.Api;
using HubSpot.Crm.FeedbackSubmissions.Client;
using HubSpot.Crm.FeedbackSubmissions.Model;

namespace Example
{
    public class PatchCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: private_apps
            config.AddApiKey("private-app", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app", "Bearer");

            var apiInstance = new BasicApi(config);
            var feedbackSubmissionId = "feedbackSubmissionId_example";  // string | 
            var simplePublicObjectInput = new SimplePublicObjectInput(); // SimplePublicObjectInput | 
            var idProperty = "idProperty_example";  // string | The name of a property whose values are unique for this object type (optional) 

            try
            {
                // Update
                SimplePublicObject result = apiInstance.PatchCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdUpdate(feedbackSubmissionId, simplePublicObjectInput, idProperty);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicApi.PatchCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update
    ApiResponse<SimplePublicObject> response = apiInstance.PatchCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdUpdateWithHttpInfo(feedbackSubmissionId, simplePublicObjectInput, idProperty);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicApi.PatchCrmV3ObjectsFeedbackSubmissionsFeedbackSubmissionIdUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **feedbackSubmissionId** | **string** |  |  |
| **simplePublicObjectInput** | [**SimplePublicObjectInput**](SimplePublicObjectInput.md) |  |  |
| **idProperty** | **string** | The name of a property whose values are unique for this object type | [optional]  |

### Return type

[**SimplePublicObject**](SimplePublicObject.md)

### Authorization

[hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcrmv3objectsfeedbacksubmissionscreate"></a>
# **PostCrmV3ObjectsFeedbackSubmissionsCreate**
> SimplePublicObject PostCrmV3ObjectsFeedbackSubmissionsCreate (SimplePublicObjectInputForCreate simplePublicObjectInputForCreate)

Create

Create a feedback submission with the given properties and return a copy of the object, including the ID. Documentation and examples for creating standard feedback submissions is provided.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.FeedbackSubmissions.Api;
using HubSpot.Crm.FeedbackSubmissions.Client;
using HubSpot.Crm.FeedbackSubmissions.Model;

namespace Example
{
    public class PostCrmV3ObjectsFeedbackSubmissionsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: private_apps
            config.AddApiKey("private-app", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app", "Bearer");

            var apiInstance = new BasicApi(config);
            var simplePublicObjectInputForCreate = new SimplePublicObjectInputForCreate(); // SimplePublicObjectInputForCreate | 

            try
            {
                // Create
                SimplePublicObject result = apiInstance.PostCrmV3ObjectsFeedbackSubmissionsCreate(simplePublicObjectInputForCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicApi.PostCrmV3ObjectsFeedbackSubmissionsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsFeedbackSubmissionsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create
    ApiResponse<SimplePublicObject> response = apiInstance.PostCrmV3ObjectsFeedbackSubmissionsCreateWithHttpInfo(simplePublicObjectInputForCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicApi.PostCrmV3ObjectsFeedbackSubmissionsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **simplePublicObjectInputForCreate** | [**SimplePublicObjectInputForCreate**](SimplePublicObjectInputForCreate.md) |  |  |

### Return type

[**SimplePublicObject**](SimplePublicObject.md)

### Authorization

[hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

