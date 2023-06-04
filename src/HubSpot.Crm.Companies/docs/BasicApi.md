# HubSpot.Crm.Companies.Api.BasicApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteCrmV3ObjectsCompaniesCompanyIdArchive**](BasicApi.md#deletecrmv3objectscompaniescompanyidarchive) | **DELETE** /crm/v3/objects/companies/{companyId} | Archive |
| [**GetCrmV3ObjectsCompaniesCompanyIdGetById**](BasicApi.md#getcrmv3objectscompaniescompanyidgetbyid) | **GET** /crm/v3/objects/companies/{companyId} | Read |
| [**GetCrmV3ObjectsCompaniesGetPage**](BasicApi.md#getcrmv3objectscompaniesgetpage) | **GET** /crm/v3/objects/companies | List |
| [**PatchCrmV3ObjectsCompaniesCompanyIdUpdate**](BasicApi.md#patchcrmv3objectscompaniescompanyidupdate) | **PATCH** /crm/v3/objects/companies/{companyId} | Update |
| [**PostCrmV3ObjectsCompaniesCreate**](BasicApi.md#postcrmv3objectscompaniescreate) | **POST** /crm/v3/objects/companies | Create |

<a id="deletecrmv3objectscompaniescompanyidarchive"></a>
# **DeleteCrmV3ObjectsCompaniesCompanyIdArchive**
> void DeleteCrmV3ObjectsCompaniesCompanyIdArchive (string companyId)

Archive

Move an Object identified by `{companyId}` to the recycling bin.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Companies.Api;
using HubSpot.Crm.Companies.Client;
using HubSpot.Crm.Companies.Model;

namespace Example
{
    public class DeleteCrmV3ObjectsCompaniesCompanyIdArchiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
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

            var apiInstance = new BasicApi(config);
            var companyId = "companyId_example";  // string | 

            try
            {
                // Archive
                apiInstance.DeleteCrmV3ObjectsCompaniesCompanyIdArchive(companyId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicApi.DeleteCrmV3ObjectsCompaniesCompanyIdArchive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCrmV3ObjectsCompaniesCompanyIdArchiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Archive
    apiInstance.DeleteCrmV3ObjectsCompaniesCompanyIdArchiveWithHttpInfo(companyId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicApi.DeleteCrmV3ObjectsCompaniesCompanyIdArchiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy), [oauth2](../README.md#oauth2), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcrmv3objectscompaniescompanyidgetbyid"></a>
# **GetCrmV3ObjectsCompaniesCompanyIdGetById**
> SimplePublicObjectWithAssociations GetCrmV3ObjectsCompaniesCompanyIdGetById (string companyId, List<string> properties = null, List<string> propertiesWithHistory = null, List<string> associations = null, bool? archived = null, string idProperty = null)

Read

Read an Object identified by `{companyId}`. `{companyId}` refers to the internal object ID by default, or optionally any unique property value as specified by the `idProperty` query param.  Control what is returned via the `properties` query param.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Companies.Api;
using HubSpot.Crm.Companies.Client;
using HubSpot.Crm.Companies.Model;

namespace Example
{
    public class GetCrmV3ObjectsCompaniesCompanyIdGetByIdExample
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
            var companyId = "companyId_example";  // string | 
            var properties = new List<string>(); // List<string> | A comma separated list of the properties to be returned in the response. If any of the specified properties are not present on the requested object(s), they will be ignored. (optional) 
            var propertiesWithHistory = new List<string>(); // List<string> | A comma separated list of the properties to be returned along with their history of previous values. If any of the specified properties are not present on the requested object(s), they will be ignored. (optional) 
            var associations = new List<string>(); // List<string> | A comma separated list of object types to retrieve associated IDs for. If any of the specified associations do not exist, they will be ignored. (optional) 
            var archived = false;  // bool? | Whether to return only results that have been archived. (optional)  (default to false)
            var idProperty = "idProperty_example";  // string | The name of a property whose values are unique for this object type (optional) 

            try
            {
                // Read
                SimplePublicObjectWithAssociations result = apiInstance.GetCrmV3ObjectsCompaniesCompanyIdGetById(companyId, properties, propertiesWithHistory, associations, archived, idProperty);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicApi.GetCrmV3ObjectsCompaniesCompanyIdGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCrmV3ObjectsCompaniesCompanyIdGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read
    ApiResponse<SimplePublicObjectWithAssociations> response = apiInstance.GetCrmV3ObjectsCompaniesCompanyIdGetByIdWithHttpInfo(companyId, properties, propertiesWithHistory, associations, archived, idProperty);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicApi.GetCrmV3ObjectsCompaniesCompanyIdGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **string** |  |  |
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

<a id="getcrmv3objectscompaniesgetpage"></a>
# **GetCrmV3ObjectsCompaniesGetPage**
> CollectionResponseSimplePublicObjectWithAssociationsForwardPaging GetCrmV3ObjectsCompaniesGetPage (int? limit = null, string after = null, List<string> properties = null, List<string> propertiesWithHistory = null, List<string> associations = null, bool? archived = null)

List

Read a page of companies. Control what is returned via the `properties` query param.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Companies.Api;
using HubSpot.Crm.Companies.Client;
using HubSpot.Crm.Companies.Model;

namespace Example
{
    public class GetCrmV3ObjectsCompaniesGetPageExample
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
                CollectionResponseSimplePublicObjectWithAssociationsForwardPaging result = apiInstance.GetCrmV3ObjectsCompaniesGetPage(limit, after, properties, propertiesWithHistory, associations, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicApi.GetCrmV3ObjectsCompaniesGetPage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCrmV3ObjectsCompaniesGetPageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List
    ApiResponse<CollectionResponseSimplePublicObjectWithAssociationsForwardPaging> response = apiInstance.GetCrmV3ObjectsCompaniesGetPageWithHttpInfo(limit, after, properties, propertiesWithHistory, associations, archived);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicApi.GetCrmV3ObjectsCompaniesGetPageWithHttpInfo: " + e.Message);
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

<a id="patchcrmv3objectscompaniescompanyidupdate"></a>
# **PatchCrmV3ObjectsCompaniesCompanyIdUpdate**
> SimplePublicObject PatchCrmV3ObjectsCompaniesCompanyIdUpdate (string companyId, SimplePublicObjectInput simplePublicObjectInput, string idProperty = null)

Update

Perform a partial update of an Object identified by `{companyId}`. `{companyId}` refers to the internal object ID by default, or optionally any unique property value as specified by the `idProperty` query param. Provided property values will be overwritten. Read-only and non-existent properties will be ignored. Properties values can be cleared by passing an empty string.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Companies.Api;
using HubSpot.Crm.Companies.Client;
using HubSpot.Crm.Companies.Model;

namespace Example
{
    public class PatchCrmV3ObjectsCompaniesCompanyIdUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
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

            var apiInstance = new BasicApi(config);
            var companyId = "companyId_example";  // string | 
            var simplePublicObjectInput = new SimplePublicObjectInput(); // SimplePublicObjectInput | 
            var idProperty = "idProperty_example";  // string | The name of a property whose values are unique for this object type (optional) 

            try
            {
                // Update
                SimplePublicObject result = apiInstance.PatchCrmV3ObjectsCompaniesCompanyIdUpdate(companyId, simplePublicObjectInput, idProperty);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicApi.PatchCrmV3ObjectsCompaniesCompanyIdUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchCrmV3ObjectsCompaniesCompanyIdUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update
    ApiResponse<SimplePublicObject> response = apiInstance.PatchCrmV3ObjectsCompaniesCompanyIdUpdateWithHttpInfo(companyId, simplePublicObjectInput, idProperty);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicApi.PatchCrmV3ObjectsCompaniesCompanyIdUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companyId** | **string** |  |  |
| **simplePublicObjectInput** | [**SimplePublicObjectInput**](SimplePublicObjectInput.md) |  |  |
| **idProperty** | **string** | The name of a property whose values are unique for this object type | [optional]  |

### Return type

[**SimplePublicObject**](SimplePublicObject.md)

### Authorization

[hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy), [oauth2](../README.md#oauth2), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcrmv3objectscompaniescreate"></a>
# **PostCrmV3ObjectsCompaniesCreate**
> SimplePublicObject PostCrmV3ObjectsCompaniesCreate (SimplePublicObjectInputForCreate simplePublicObjectInputForCreate)

Create

Create a company with the given properties and return a copy of the object, including the ID. Documentation and examples for creating standard companies is provided.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Companies.Api;
using HubSpot.Crm.Companies.Client;
using HubSpot.Crm.Companies.Model;

namespace Example
{
    public class PostCrmV3ObjectsCompaniesCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
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

            var apiInstance = new BasicApi(config);
            var simplePublicObjectInputForCreate = new SimplePublicObjectInputForCreate(); // SimplePublicObjectInputForCreate | 

            try
            {
                // Create
                SimplePublicObject result = apiInstance.PostCrmV3ObjectsCompaniesCreate(simplePublicObjectInputForCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicApi.PostCrmV3ObjectsCompaniesCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsCompaniesCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create
    ApiResponse<SimplePublicObject> response = apiInstance.PostCrmV3ObjectsCompaniesCreateWithHttpInfo(simplePublicObjectInputForCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicApi.PostCrmV3ObjectsCompaniesCreateWithHttpInfo: " + e.Message);
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

[hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy), [oauth2](../README.md#oauth2), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

