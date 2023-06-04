# HubSpot.Crm.Objects.Api.AssociationsApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteCrmV3ObjectsObjectTypeObjectIdAssociationsToObjectTypeToObjectIdAssociationTypeArchive**](AssociationsApi.md#deletecrmv3objectsobjecttypeobjectidassociationstoobjecttypetoobjectidassociationtypearchive) | **DELETE** /crm/v3/objects/{objectType}/{objectId}/associations/{toObjectType}/{toObjectId}/{associationType} | Remove an association between two objects |
| [**GetCrmV3ObjectsObjectTypeObjectIdAssociationsToObjectTypeGetAll**](AssociationsApi.md#getcrmv3objectsobjecttypeobjectidassociationstoobjecttypegetall) | **GET** /crm/v3/objects/{objectType}/{objectId}/associations/{toObjectType} | List associations of an object by type |
| [**PutCrmV3ObjectsObjectTypeObjectIdAssociationsToObjectTypeToObjectIdAssociationTypeCreate**](AssociationsApi.md#putcrmv3objectsobjecttypeobjectidassociationstoobjecttypetoobjectidassociationtypecreate) | **PUT** /crm/v3/objects/{objectType}/{objectId}/associations/{toObjectType}/{toObjectId}/{associationType} | Associate an object with another object |

<a id="deletecrmv3objectsobjecttypeobjectidassociationstoobjecttypetoobjectidassociationtypearchive"></a>
# **DeleteCrmV3ObjectsObjectTypeObjectIdAssociationsToObjectTypeToObjectIdAssociationTypeArchive**
> void DeleteCrmV3ObjectsObjectTypeObjectIdAssociationsToObjectTypeToObjectIdAssociationTypeArchive (string objectType, string objectId, string toObjectType, string toObjectId, string associationType)

Remove an association between two objects

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Objects.Api;
using HubSpot.Crm.Objects.Client;
using HubSpot.Crm.Objects.Model;

namespace Example
{
    public class DeleteCrmV3ObjectsObjectTypeObjectIdAssociationsToObjectTypeToObjectIdAssociationTypeArchiveExample
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

            var apiInstance = new AssociationsApi(config);
            var objectType = "objectType_example";  // string | 
            var objectId = "objectId_example";  // string | 
            var toObjectType = "toObjectType_example";  // string | 
            var toObjectId = "toObjectId_example";  // string | 
            var associationType = "associationType_example";  // string | 

            try
            {
                // Remove an association between two objects
                apiInstance.DeleteCrmV3ObjectsObjectTypeObjectIdAssociationsToObjectTypeToObjectIdAssociationTypeArchive(objectType, objectId, toObjectType, toObjectId, associationType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssociationsApi.DeleteCrmV3ObjectsObjectTypeObjectIdAssociationsToObjectTypeToObjectIdAssociationTypeArchive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCrmV3ObjectsObjectTypeObjectIdAssociationsToObjectTypeToObjectIdAssociationTypeArchiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove an association between two objects
    apiInstance.DeleteCrmV3ObjectsObjectTypeObjectIdAssociationsToObjectTypeToObjectIdAssociationTypeArchiveWithHttpInfo(objectType, objectId, toObjectType, toObjectId, associationType);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssociationsApi.DeleteCrmV3ObjectsObjectTypeObjectIdAssociationsToObjectTypeToObjectIdAssociationTypeArchiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectType** | **string** |  |  |
| **objectId** | **string** |  |  |
| **toObjectType** | **string** |  |  |
| **toObjectId** | **string** |  |  |
| **associationType** | **string** |  |  |

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

<a id="getcrmv3objectsobjecttypeobjectidassociationstoobjecttypegetall"></a>
# **GetCrmV3ObjectsObjectTypeObjectIdAssociationsToObjectTypeGetAll**
> CollectionResponseAssociatedIdForwardPaging GetCrmV3ObjectsObjectTypeObjectIdAssociationsToObjectTypeGetAll (string objectType, string objectId, string toObjectType, string after = null, int? limit = null)

List associations of an object by type

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Objects.Api;
using HubSpot.Crm.Objects.Client;
using HubSpot.Crm.Objects.Model;

namespace Example
{
    public class GetCrmV3ObjectsObjectTypeObjectIdAssociationsToObjectTypeGetAllExample
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

            var apiInstance = new AssociationsApi(config);
            var objectType = "objectType_example";  // string | 
            var objectId = "objectId_example";  // string | 
            var toObjectType = "toObjectType_example";  // string | 
            var after = "after_example";  // string | The paging cursor token of the last successfully read resource will be returned as the `paging.next.after` JSON property of a paged response containing more results. (optional) 
            var limit = 500;  // int? | The maximum number of results to display per page. (optional)  (default to 500)

            try
            {
                // List associations of an object by type
                CollectionResponseAssociatedIdForwardPaging result = apiInstance.GetCrmV3ObjectsObjectTypeObjectIdAssociationsToObjectTypeGetAll(objectType, objectId, toObjectType, after, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssociationsApi.GetCrmV3ObjectsObjectTypeObjectIdAssociationsToObjectTypeGetAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCrmV3ObjectsObjectTypeObjectIdAssociationsToObjectTypeGetAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List associations of an object by type
    ApiResponse<CollectionResponseAssociatedIdForwardPaging> response = apiInstance.GetCrmV3ObjectsObjectTypeObjectIdAssociationsToObjectTypeGetAllWithHttpInfo(objectType, objectId, toObjectType, after, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssociationsApi.GetCrmV3ObjectsObjectTypeObjectIdAssociationsToObjectTypeGetAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectType** | **string** |  |  |
| **objectId** | **string** |  |  |
| **toObjectType** | **string** |  |  |
| **after** | **string** | The paging cursor token of the last successfully read resource will be returned as the &#x60;paging.next.after&#x60; JSON property of a paged response containing more results. | [optional]  |
| **limit** | **int?** | The maximum number of results to display per page. | [optional] [default to 500] |

### Return type

[**CollectionResponseAssociatedIdForwardPaging**](CollectionResponseAssociatedIdForwardPaging.md)

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

<a id="putcrmv3objectsobjecttypeobjectidassociationstoobjecttypetoobjectidassociationtypecreate"></a>
# **PutCrmV3ObjectsObjectTypeObjectIdAssociationsToObjectTypeToObjectIdAssociationTypeCreate**
> SimplePublicObjectWithAssociations PutCrmV3ObjectsObjectTypeObjectIdAssociationsToObjectTypeToObjectIdAssociationTypeCreate (string objectType, string objectId, string toObjectType, string toObjectId, string associationType)

Associate an object with another object

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Objects.Api;
using HubSpot.Crm.Objects.Client;
using HubSpot.Crm.Objects.Model;

namespace Example
{
    public class PutCrmV3ObjectsObjectTypeObjectIdAssociationsToObjectTypeToObjectIdAssociationTypeCreateExample
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

            var apiInstance = new AssociationsApi(config);
            var objectType = "objectType_example";  // string | 
            var objectId = "objectId_example";  // string | 
            var toObjectType = "toObjectType_example";  // string | 
            var toObjectId = "toObjectId_example";  // string | 
            var associationType = "associationType_example";  // string | 

            try
            {
                // Associate an object with another object
                SimplePublicObjectWithAssociations result = apiInstance.PutCrmV3ObjectsObjectTypeObjectIdAssociationsToObjectTypeToObjectIdAssociationTypeCreate(objectType, objectId, toObjectType, toObjectId, associationType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssociationsApi.PutCrmV3ObjectsObjectTypeObjectIdAssociationsToObjectTypeToObjectIdAssociationTypeCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutCrmV3ObjectsObjectTypeObjectIdAssociationsToObjectTypeToObjectIdAssociationTypeCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Associate an object with another object
    ApiResponse<SimplePublicObjectWithAssociations> response = apiInstance.PutCrmV3ObjectsObjectTypeObjectIdAssociationsToObjectTypeToObjectIdAssociationTypeCreateWithHttpInfo(objectType, objectId, toObjectType, toObjectId, associationType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssociationsApi.PutCrmV3ObjectsObjectTypeObjectIdAssociationsToObjectTypeToObjectIdAssociationTypeCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectType** | **string** |  |  |
| **objectId** | **string** |  |  |
| **toObjectType** | **string** |  |  |
| **toObjectId** | **string** |  |  |
| **associationType** | **string** |  |  |

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

