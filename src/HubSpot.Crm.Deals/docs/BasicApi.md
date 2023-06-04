# HubSpot.Crm.Deals.Api.BasicApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteCrmV3ObjectsDealsDealIdArchive**](BasicApi.md#deletecrmv3objectsdealsdealidarchive) | **DELETE** /crm/v3/objects/deals/{dealId} | Archive |
| [**GetCrmV3ObjectsDealsDealIdGetById**](BasicApi.md#getcrmv3objectsdealsdealidgetbyid) | **GET** /crm/v3/objects/deals/{dealId} | Read |
| [**GetCrmV3ObjectsDealsGetPage**](BasicApi.md#getcrmv3objectsdealsgetpage) | **GET** /crm/v3/objects/deals | List |
| [**PatchCrmV3ObjectsDealsDealIdUpdate**](BasicApi.md#patchcrmv3objectsdealsdealidupdate) | **PATCH** /crm/v3/objects/deals/{dealId} | Update |
| [**PostCrmV3ObjectsDealsCreate**](BasicApi.md#postcrmv3objectsdealscreate) | **POST** /crm/v3/objects/deals | Create |

<a id="deletecrmv3objectsdealsdealidarchive"></a>
# **DeleteCrmV3ObjectsDealsDealIdArchive**
> void DeleteCrmV3ObjectsDealsDealIdArchive (string dealId)

Archive

Move an Object identified by `{dealId}` to the recycling bin.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Deals.Api;
using HubSpot.Crm.Deals.Client;
using HubSpot.Crm.Deals.Model;

namespace Example
{
    public class DeleteCrmV3ObjectsDealsDealIdArchiveExample
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
            // Configure API key authorization: private_apps_legacy
            config.AddApiKey("private-app-legacy", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app-legacy", "Bearer");
            // Configure API key authorization: private_apps
            config.AddApiKey("private-app", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app", "Bearer");

            var apiInstance = new BasicApi(config);
            var dealId = "dealId_example";  // string | 

            try
            {
                // Archive
                apiInstance.DeleteCrmV3ObjectsDealsDealIdArchive(dealId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicApi.DeleteCrmV3ObjectsDealsDealIdArchive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCrmV3ObjectsDealsDealIdArchiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Archive
    apiInstance.DeleteCrmV3ObjectsDealsDealIdArchiveWithHttpInfo(dealId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicApi.DeleteCrmV3ObjectsDealsDealIdArchiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dealId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps_legacy](../README.md#private_apps_legacy), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcrmv3objectsdealsdealidgetbyid"></a>
# **GetCrmV3ObjectsDealsDealIdGetById**
> SimplePublicObjectWithAssociations GetCrmV3ObjectsDealsDealIdGetById (string dealId, List<string> properties = null, List<string> propertiesWithHistory = null, List<string> associations = null, bool? archived = null, string idProperty = null)

Read

Read an Object identified by `{dealId}`. `{dealId}` refers to the internal object ID by default, or optionally any unique property value as specified by the `idProperty` query param.  Control what is returned via the `properties` query param.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Deals.Api;
using HubSpot.Crm.Deals.Client;
using HubSpot.Crm.Deals.Model;

namespace Example
{
    public class GetCrmV3ObjectsDealsDealIdGetByIdExample
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
            // Configure API key authorization: private_apps_legacy
            config.AddApiKey("private-app-legacy", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app-legacy", "Bearer");
            // Configure API key authorization: private_apps
            config.AddApiKey("private-app", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app", "Bearer");

            var apiInstance = new BasicApi(config);
            var dealId = "dealId_example";  // string | 
            var properties = new List<string>(); // List<string> | A comma separated list of the properties to be returned in the response. If any of the specified properties are not present on the requested object(s), they will be ignored. (optional) 
            var propertiesWithHistory = new List<string>(); // List<string> | A comma separated list of the properties to be returned along with their history of previous values. If any of the specified properties are not present on the requested object(s), they will be ignored. (optional) 
            var associations = new List<string>(); // List<string> | A comma separated list of object types to retrieve associated IDs for. If any of the specified associations do not exist, they will be ignored. (optional) 
            var archived = false;  // bool? | Whether to return only results that have been archived. (optional)  (default to false)
            var idProperty = "idProperty_example";  // string | The name of a property whose values are unique for this object type (optional) 

            try
            {
                // Read
                SimplePublicObjectWithAssociations result = apiInstance.GetCrmV3ObjectsDealsDealIdGetById(dealId, properties, propertiesWithHistory, associations, archived, idProperty);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicApi.GetCrmV3ObjectsDealsDealIdGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCrmV3ObjectsDealsDealIdGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read
    ApiResponse<SimplePublicObjectWithAssociations> response = apiInstance.GetCrmV3ObjectsDealsDealIdGetByIdWithHttpInfo(dealId, properties, propertiesWithHistory, associations, archived, idProperty);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicApi.GetCrmV3ObjectsDealsDealIdGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dealId** | **string** |  |  |
| **properties** | [**List&lt;string&gt;**](string.md) | A comma separated list of the properties to be returned in the response. If any of the specified properties are not present on the requested object(s), they will be ignored. | [optional]  |
| **propertiesWithHistory** | [**List&lt;string&gt;**](string.md) | A comma separated list of the properties to be returned along with their history of previous values. If any of the specified properties are not present on the requested object(s), they will be ignored. | [optional]  |
| **associations** | [**List&lt;string&gt;**](string.md) | A comma separated list of object types to retrieve associated IDs for. If any of the specified associations do not exist, they will be ignored. | [optional]  |
| **archived** | **bool?** | Whether to return only results that have been archived. | [optional] [default to false] |
| **idProperty** | **string** | The name of a property whose values are unique for this object type | [optional]  |

### Return type

[**SimplePublicObjectWithAssociations**](SimplePublicObjectWithAssociations.md)

### Authorization

[hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps_legacy](../README.md#private_apps_legacy), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcrmv3objectsdealsgetpage"></a>
# **GetCrmV3ObjectsDealsGetPage**
> CollectionResponseSimplePublicObjectWithAssociationsForwardPaging GetCrmV3ObjectsDealsGetPage (int? limit = null, string after = null, List<string> properties = null, List<string> propertiesWithHistory = null, List<string> associations = null, bool? archived = null)

List

Read a page of deals. Control what is returned via the `properties` query param.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Deals.Api;
using HubSpot.Crm.Deals.Client;
using HubSpot.Crm.Deals.Model;

namespace Example
{
    public class GetCrmV3ObjectsDealsGetPageExample
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
            // Configure API key authorization: private_apps_legacy
            config.AddApiKey("private-app-legacy", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app-legacy", "Bearer");
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
                CollectionResponseSimplePublicObjectWithAssociationsForwardPaging result = apiInstance.GetCrmV3ObjectsDealsGetPage(limit, after, properties, propertiesWithHistory, associations, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicApi.GetCrmV3ObjectsDealsGetPage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCrmV3ObjectsDealsGetPageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List
    ApiResponse<CollectionResponseSimplePublicObjectWithAssociationsForwardPaging> response = apiInstance.GetCrmV3ObjectsDealsGetPageWithHttpInfo(limit, after, properties, propertiesWithHistory, associations, archived);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicApi.GetCrmV3ObjectsDealsGetPageWithHttpInfo: " + e.Message);
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

[hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps_legacy](../README.md#private_apps_legacy), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="patchcrmv3objectsdealsdealidupdate"></a>
# **PatchCrmV3ObjectsDealsDealIdUpdate**
> SimplePublicObject PatchCrmV3ObjectsDealsDealIdUpdate (string dealId, SimplePublicObjectInput simplePublicObjectInput, string idProperty = null)

Update

Perform a partial update of an Object identified by `{dealId}`. `{dealId}` refers to the internal object ID by default, or optionally any unique property value as specified by the `idProperty` query param. Provided property values will be overwritten. Read-only and non-existent properties will be ignored. Properties values can be cleared by passing an empty string.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Deals.Api;
using HubSpot.Crm.Deals.Client;
using HubSpot.Crm.Deals.Model;

namespace Example
{
    public class PatchCrmV3ObjectsDealsDealIdUpdateExample
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
            // Configure API key authorization: private_apps_legacy
            config.AddApiKey("private-app-legacy", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app-legacy", "Bearer");
            // Configure API key authorization: private_apps
            config.AddApiKey("private-app", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app", "Bearer");

            var apiInstance = new BasicApi(config);
            var dealId = "dealId_example";  // string | 
            var simplePublicObjectInput = new SimplePublicObjectInput(); // SimplePublicObjectInput | 
            var idProperty = "idProperty_example";  // string | The name of a property whose values are unique for this object type (optional) 

            try
            {
                // Update
                SimplePublicObject result = apiInstance.PatchCrmV3ObjectsDealsDealIdUpdate(dealId, simplePublicObjectInput, idProperty);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicApi.PatchCrmV3ObjectsDealsDealIdUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchCrmV3ObjectsDealsDealIdUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update
    ApiResponse<SimplePublicObject> response = apiInstance.PatchCrmV3ObjectsDealsDealIdUpdateWithHttpInfo(dealId, simplePublicObjectInput, idProperty);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicApi.PatchCrmV3ObjectsDealsDealIdUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dealId** | **string** |  |  |
| **simplePublicObjectInput** | [**SimplePublicObjectInput**](SimplePublicObjectInput.md) |  |  |
| **idProperty** | **string** | The name of a property whose values are unique for this object type | [optional]  |

### Return type

[**SimplePublicObject**](SimplePublicObject.md)

### Authorization

[hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps_legacy](../README.md#private_apps_legacy), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcrmv3objectsdealscreate"></a>
# **PostCrmV3ObjectsDealsCreate**
> SimplePublicObject PostCrmV3ObjectsDealsCreate (SimplePublicObjectInputForCreate simplePublicObjectInputForCreate)

Create

Create a deal with the given properties and return a copy of the object, including the ID. Documentation and examples for creating standard deals is provided.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Deals.Api;
using HubSpot.Crm.Deals.Client;
using HubSpot.Crm.Deals.Model;

namespace Example
{
    public class PostCrmV3ObjectsDealsCreateExample
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
            // Configure API key authorization: private_apps_legacy
            config.AddApiKey("private-app-legacy", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app-legacy", "Bearer");
            // Configure API key authorization: private_apps
            config.AddApiKey("private-app", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app", "Bearer");

            var apiInstance = new BasicApi(config);
            var simplePublicObjectInputForCreate = new SimplePublicObjectInputForCreate(); // SimplePublicObjectInputForCreate | 

            try
            {
                // Create
                SimplePublicObject result = apiInstance.PostCrmV3ObjectsDealsCreate(simplePublicObjectInputForCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicApi.PostCrmV3ObjectsDealsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsDealsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create
    ApiResponse<SimplePublicObject> response = apiInstance.PostCrmV3ObjectsDealsCreateWithHttpInfo(simplePublicObjectInputForCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicApi.PostCrmV3ObjectsDealsCreateWithHttpInfo: " + e.Message);
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

[hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps_legacy](../README.md#private_apps_legacy), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

