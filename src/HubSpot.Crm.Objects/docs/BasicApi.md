# HubSpot.Crm.Objects.Api.BasicApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteCrmV3ObjectsObjectTypeObjectIdArchive**](BasicApi.md#deletecrmv3objectsobjecttypeobjectidarchive) | **DELETE** /crm/v3/objects/{objectType}/{objectId} | Archive |
| [**GetCrmV3ObjectsObjectTypeGetPage**](BasicApi.md#getcrmv3objectsobjecttypegetpage) | **GET** /crm/v3/objects/{objectType} | List |
| [**GetCrmV3ObjectsObjectTypeObjectIdGetById**](BasicApi.md#getcrmv3objectsobjecttypeobjectidgetbyid) | **GET** /crm/v3/objects/{objectType}/{objectId} | Read |
| [**PatchCrmV3ObjectsObjectTypeObjectIdUpdate**](BasicApi.md#patchcrmv3objectsobjecttypeobjectidupdate) | **PATCH** /crm/v3/objects/{objectType}/{objectId} | Update |
| [**PostCrmV3ObjectsObjectTypeCreate**](BasicApi.md#postcrmv3objectsobjecttypecreate) | **POST** /crm/v3/objects/{objectType} | Create |

<a id="deletecrmv3objectsobjecttypeobjectidarchive"></a>
# **DeleteCrmV3ObjectsObjectTypeObjectIdArchive**
> void DeleteCrmV3ObjectsObjectTypeObjectIdArchive (string objectType, string objectId)

Archive

Move an Object identified by `{objectId}` to the recycling bin.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Objects.Api;
using HubSpot.Crm.Objects.Client;
using HubSpot.Crm.Objects.Model;

namespace Example
{
    public class DeleteCrmV3ObjectsObjectTypeObjectIdArchiveExample
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

            var apiInstance = new BasicApi(config);
            var objectType = "objectType_example";  // string | 
            var objectId = "objectId_example";  // string | 

            try
            {
                // Archive
                apiInstance.DeleteCrmV3ObjectsObjectTypeObjectIdArchive(objectType, objectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicApi.DeleteCrmV3ObjectsObjectTypeObjectIdArchive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCrmV3ObjectsObjectTypeObjectIdArchiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Archive
    apiInstance.DeleteCrmV3ObjectsObjectTypeObjectIdArchiveWithHttpInfo(objectType, objectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicApi.DeleteCrmV3ObjectsObjectTypeObjectIdArchiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectType** | **string** |  |  |
| **objectId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps_legacy](../README.md#private_apps_legacy), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcrmv3objectsobjecttypegetpage"></a>
# **GetCrmV3ObjectsObjectTypeGetPage**
> CollectionResponseSimplePublicObjectWithAssociationsForwardPaging GetCrmV3ObjectsObjectTypeGetPage (string objectType, int? limit = null, string after = null, List<string> properties = null, List<string> propertiesWithHistory = null, List<string> associations = null, bool? archived = null)

List

Read a page of objects. Control what is returned via the `properties` query param.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Objects.Api;
using HubSpot.Crm.Objects.Client;
using HubSpot.Crm.Objects.Model;

namespace Example
{
    public class GetCrmV3ObjectsObjectTypeGetPageExample
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

            var apiInstance = new BasicApi(config);
            var objectType = "objectType_example";  // string | 
            var limit = 10;  // int? | The maximum number of results to display per page. (optional)  (default to 10)
            var after = "after_example";  // string | The paging cursor token of the last successfully read resource will be returned as the `paging.next.after` JSON property of a paged response containing more results. (optional) 
            var properties = new List<string>(); // List<string> | A comma separated list of the properties to be returned in the response. If any of the specified properties are not present on the requested object(s), they will be ignored. (optional) 
            var propertiesWithHistory = new List<string>(); // List<string> | A comma separated list of the properties to be returned along with their history of previous values. If any of the specified properties are not present on the requested object(s), they will be ignored. Usage of this parameter will reduce the maximum number of objects that can be read by a single request. (optional) 
            var associations = new List<string>(); // List<string> | A comma separated list of object types to retrieve associated IDs for. If any of the specified associations do not exist, they will be ignored. (optional) 
            var archived = false;  // bool? | Whether to return only results that have been archived. (optional)  (default to false)

            try
            {
                // List
                CollectionResponseSimplePublicObjectWithAssociationsForwardPaging result = apiInstance.GetCrmV3ObjectsObjectTypeGetPage(objectType, limit, after, properties, propertiesWithHistory, associations, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicApi.GetCrmV3ObjectsObjectTypeGetPage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCrmV3ObjectsObjectTypeGetPageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List
    ApiResponse<CollectionResponseSimplePublicObjectWithAssociationsForwardPaging> response = apiInstance.GetCrmV3ObjectsObjectTypeGetPageWithHttpInfo(objectType, limit, after, properties, propertiesWithHistory, associations, archived);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicApi.GetCrmV3ObjectsObjectTypeGetPageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectType** | **string** |  |  |
| **limit** | **int?** | The maximum number of results to display per page. | [optional] [default to 10] |
| **after** | **string** | The paging cursor token of the last successfully read resource will be returned as the &#x60;paging.next.after&#x60; JSON property of a paged response containing more results. | [optional]  |
| **properties** | [**List&lt;string&gt;**](string.md) | A comma separated list of the properties to be returned in the response. If any of the specified properties are not present on the requested object(s), they will be ignored. | [optional]  |
| **propertiesWithHistory** | [**List&lt;string&gt;**](string.md) | A comma separated list of the properties to be returned along with their history of previous values. If any of the specified properties are not present on the requested object(s), they will be ignored. Usage of this parameter will reduce the maximum number of objects that can be read by a single request. | [optional]  |
| **associations** | [**List&lt;string&gt;**](string.md) | A comma separated list of object types to retrieve associated IDs for. If any of the specified associations do not exist, they will be ignored. | [optional]  |
| **archived** | **bool?** | Whether to return only results that have been archived. | [optional] [default to false] |

### Return type

[**CollectionResponseSimplePublicObjectWithAssociationsForwardPaging**](CollectionResponseSimplePublicObjectWithAssociationsForwardPaging.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps_legacy](../README.md#private_apps_legacy), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcrmv3objectsobjecttypeobjectidgetbyid"></a>
# **GetCrmV3ObjectsObjectTypeObjectIdGetById**
> SimplePublicObjectWithAssociations GetCrmV3ObjectsObjectTypeObjectIdGetById (string objectType, string objectId, List<string> properties = null, List<string> propertiesWithHistory = null, List<string> associations = null, bool? archived = null, string idProperty = null)

Read

Read an Object identified by `{objectId}`. `{objectId}` refers to the internal object ID by default, or optionally any unique property value as specified by the `idProperty` query param.  Control what is returned via the `properties` query param.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Objects.Api;
using HubSpot.Crm.Objects.Client;
using HubSpot.Crm.Objects.Model;

namespace Example
{
    public class GetCrmV3ObjectsObjectTypeObjectIdGetByIdExample
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

            var apiInstance = new BasicApi(config);
            var objectType = "objectType_example";  // string | 
            var objectId = "objectId_example";  // string | 
            var properties = new List<string>(); // List<string> | A comma separated list of the properties to be returned in the response. If any of the specified properties are not present on the requested object(s), they will be ignored. (optional) 
            var propertiesWithHistory = new List<string>(); // List<string> | A comma separated list of the properties to be returned along with their history of previous values. If any of the specified properties are not present on the requested object(s), they will be ignored. (optional) 
            var associations = new List<string>(); // List<string> | A comma separated list of object types to retrieve associated IDs for. If any of the specified associations do not exist, they will be ignored. (optional) 
            var archived = false;  // bool? | Whether to return only results that have been archived. (optional)  (default to false)
            var idProperty = "idProperty_example";  // string | The name of a property whose values are unique for this object type (optional) 

            try
            {
                // Read
                SimplePublicObjectWithAssociations result = apiInstance.GetCrmV3ObjectsObjectTypeObjectIdGetById(objectType, objectId, properties, propertiesWithHistory, associations, archived, idProperty);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicApi.GetCrmV3ObjectsObjectTypeObjectIdGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCrmV3ObjectsObjectTypeObjectIdGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read
    ApiResponse<SimplePublicObjectWithAssociations> response = apiInstance.GetCrmV3ObjectsObjectTypeObjectIdGetByIdWithHttpInfo(objectType, objectId, properties, propertiesWithHistory, associations, archived, idProperty);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicApi.GetCrmV3ObjectsObjectTypeObjectIdGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectType** | **string** |  |  |
| **objectId** | **string** |  |  |
| **properties** | [**List&lt;string&gt;**](string.md) | A comma separated list of the properties to be returned in the response. If any of the specified properties are not present on the requested object(s), they will be ignored. | [optional]  |
| **propertiesWithHistory** | [**List&lt;string&gt;**](string.md) | A comma separated list of the properties to be returned along with their history of previous values. If any of the specified properties are not present on the requested object(s), they will be ignored. | [optional]  |
| **associations** | [**List&lt;string&gt;**](string.md) | A comma separated list of object types to retrieve associated IDs for. If any of the specified associations do not exist, they will be ignored. | [optional]  |
| **archived** | **bool?** | Whether to return only results that have been archived. | [optional] [default to false] |
| **idProperty** | **string** | The name of a property whose values are unique for this object type | [optional]  |

### Return type

[**SimplePublicObjectWithAssociations**](SimplePublicObjectWithAssociations.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps_legacy](../README.md#private_apps_legacy), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="patchcrmv3objectsobjecttypeobjectidupdate"></a>
# **PatchCrmV3ObjectsObjectTypeObjectIdUpdate**
> SimplePublicObject PatchCrmV3ObjectsObjectTypeObjectIdUpdate (string objectType, string objectId, SimplePublicObjectInput simplePublicObjectInput, string idProperty = null)

Update

Perform a partial update of an Object identified by `{objectId}`. `{objectId}` refers to the internal object ID by default, or optionally any unique property value as specified by the `idProperty` query param. Provided property values will be overwritten. Read-only and non-existent properties will be ignored. Properties values can be cleared by passing an empty string.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Objects.Api;
using HubSpot.Crm.Objects.Client;
using HubSpot.Crm.Objects.Model;

namespace Example
{
    public class PatchCrmV3ObjectsObjectTypeObjectIdUpdateExample
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

            var apiInstance = new BasicApi(config);
            var objectType = "objectType_example";  // string | 
            var objectId = "objectId_example";  // string | 
            var simplePublicObjectInput = new SimplePublicObjectInput(); // SimplePublicObjectInput | 
            var idProperty = "idProperty_example";  // string | The name of a property whose values are unique for this object type (optional) 

            try
            {
                // Update
                SimplePublicObject result = apiInstance.PatchCrmV3ObjectsObjectTypeObjectIdUpdate(objectType, objectId, simplePublicObjectInput, idProperty);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicApi.PatchCrmV3ObjectsObjectTypeObjectIdUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchCrmV3ObjectsObjectTypeObjectIdUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update
    ApiResponse<SimplePublicObject> response = apiInstance.PatchCrmV3ObjectsObjectTypeObjectIdUpdateWithHttpInfo(objectType, objectId, simplePublicObjectInput, idProperty);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicApi.PatchCrmV3ObjectsObjectTypeObjectIdUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectType** | **string** |  |  |
| **objectId** | **string** |  |  |
| **simplePublicObjectInput** | [**SimplePublicObjectInput**](SimplePublicObjectInput.md) |  |  |
| **idProperty** | **string** | The name of a property whose values are unique for this object type | [optional]  |

### Return type

[**SimplePublicObject**](SimplePublicObject.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps_legacy](../README.md#private_apps_legacy), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcrmv3objectsobjecttypecreate"></a>
# **PostCrmV3ObjectsObjectTypeCreate**
> SimplePublicObject PostCrmV3ObjectsObjectTypeCreate (string objectType, SimplePublicObjectInputForCreate simplePublicObjectInputForCreate)

Create

Create a CRM object with the given properties and return a copy of the object, including the ID. Documentation and examples for creating standard objects is provided.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Objects.Api;
using HubSpot.Crm.Objects.Client;
using HubSpot.Crm.Objects.Model;

namespace Example
{
    public class PostCrmV3ObjectsObjectTypeCreateExample
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

            var apiInstance = new BasicApi(config);
            var objectType = "objectType_example";  // string | 
            var simplePublicObjectInputForCreate = new SimplePublicObjectInputForCreate(); // SimplePublicObjectInputForCreate | 

            try
            {
                // Create
                SimplePublicObject result = apiInstance.PostCrmV3ObjectsObjectTypeCreate(objectType, simplePublicObjectInputForCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicApi.PostCrmV3ObjectsObjectTypeCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsObjectTypeCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create
    ApiResponse<SimplePublicObject> response = apiInstance.PostCrmV3ObjectsObjectTypeCreateWithHttpInfo(objectType, simplePublicObjectInputForCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicApi.PostCrmV3ObjectsObjectTypeCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectType** | **string** |  |  |
| **simplePublicObjectInputForCreate** | [**SimplePublicObjectInputForCreate**](SimplePublicObjectInputForCreate.md) |  |  |

### Return type

[**SimplePublicObject**](SimplePublicObject.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps_legacy](../README.md#private_apps_legacy), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

