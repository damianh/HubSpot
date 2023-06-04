# HubSpot.Crm.Associations.Api.BatchApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostCrmV3AssociationsFromObjectTypeToObjectTypeBatchArchiveArchive**](BatchApi.md#postcrmv3associationsfromobjecttypetoobjecttypebatcharchivearchive) | **POST** /crm/v3/associations/{fromObjectType}/{toObjectType}/batch/archive | Archive a batch of associations |
| [**PostCrmV3AssociationsFromObjectTypeToObjectTypeBatchCreateCreate**](BatchApi.md#postcrmv3associationsfromobjecttypetoobjecttypebatchcreatecreate) | **POST** /crm/v3/associations/{fromObjectType}/{toObjectType}/batch/create | Create a batch of associations |
| [**PostCrmV3AssociationsFromObjectTypeToObjectTypeBatchReadRead**](BatchApi.md#postcrmv3associationsfromobjecttypetoobjecttypebatchreadread) | **POST** /crm/v3/associations/{fromObjectType}/{toObjectType}/batch/read | Read a batch of associations |

<a id="postcrmv3associationsfromobjecttypetoobjecttypebatcharchivearchive"></a>
# **PostCrmV3AssociationsFromObjectTypeToObjectTypeBatchArchiveArchive**
> void PostCrmV3AssociationsFromObjectTypeToObjectTypeBatchArchiveArchive (string fromObjectType, string toObjectType, BatchInputPublicAssociation batchInputPublicAssociation)

Archive a batch of associations

Remove the associations between all pairs of objects identified in the request body.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Associations.Api;
using HubSpot.Crm.Associations.Client;
using HubSpot.Crm.Associations.Model;

namespace Example
{
    public class PostCrmV3AssociationsFromObjectTypeToObjectTypeBatchArchiveArchiveExample
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

            var apiInstance = new BatchApi(config);
            var fromObjectType = "fromObjectType_example";  // string | 
            var toObjectType = "toObjectType_example";  // string | 
            var batchInputPublicAssociation = new BatchInputPublicAssociation(); // BatchInputPublicAssociation | 

            try
            {
                // Archive a batch of associations
                apiInstance.PostCrmV3AssociationsFromObjectTypeToObjectTypeBatchArchiveArchive(fromObjectType, toObjectType, batchInputPublicAssociation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV3AssociationsFromObjectTypeToObjectTypeBatchArchiveArchive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3AssociationsFromObjectTypeToObjectTypeBatchArchiveArchiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Archive a batch of associations
    apiInstance.PostCrmV3AssociationsFromObjectTypeToObjectTypeBatchArchiveArchiveWithHttpInfo(fromObjectType, toObjectType, batchInputPublicAssociation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV3AssociationsFromObjectTypeToObjectTypeBatchArchiveArchiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fromObjectType** | **string** |  |  |
| **toObjectType** | **string** |  |  |
| **batchInputPublicAssociation** | [**BatchInputPublicAssociation**](BatchInputPublicAssociation.md) |  |  |

### Return type

void (empty response body)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps_legacy](../README.md#private_apps_legacy), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcrmv3associationsfromobjecttypetoobjecttypebatchcreatecreate"></a>
# **PostCrmV3AssociationsFromObjectTypeToObjectTypeBatchCreateCreate**
> BatchResponsePublicAssociation PostCrmV3AssociationsFromObjectTypeToObjectTypeBatchCreateCreate (string fromObjectType, string toObjectType, BatchInputPublicAssociation batchInputPublicAssociation)

Create a batch of associations

Associate all pairs of objects identified in the request body.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Associations.Api;
using HubSpot.Crm.Associations.Client;
using HubSpot.Crm.Associations.Model;

namespace Example
{
    public class PostCrmV3AssociationsFromObjectTypeToObjectTypeBatchCreateCreateExample
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

            var apiInstance = new BatchApi(config);
            var fromObjectType = "fromObjectType_example";  // string | 
            var toObjectType = "toObjectType_example";  // string | 
            var batchInputPublicAssociation = new BatchInputPublicAssociation(); // BatchInputPublicAssociation | 

            try
            {
                // Create a batch of associations
                BatchResponsePublicAssociation result = apiInstance.PostCrmV3AssociationsFromObjectTypeToObjectTypeBatchCreateCreate(fromObjectType, toObjectType, batchInputPublicAssociation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV3AssociationsFromObjectTypeToObjectTypeBatchCreateCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3AssociationsFromObjectTypeToObjectTypeBatchCreateCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a batch of associations
    ApiResponse<BatchResponsePublicAssociation> response = apiInstance.PostCrmV3AssociationsFromObjectTypeToObjectTypeBatchCreateCreateWithHttpInfo(fromObjectType, toObjectType, batchInputPublicAssociation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV3AssociationsFromObjectTypeToObjectTypeBatchCreateCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fromObjectType** | **string** |  |  |
| **toObjectType** | **string** |  |  |
| **batchInputPublicAssociation** | [**BatchInputPublicAssociation**](BatchInputPublicAssociation.md) |  |  |

### Return type

[**BatchResponsePublicAssociation**](BatchResponsePublicAssociation.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps_legacy](../README.md#private_apps_legacy), [private_apps](../README.md#private_apps)

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

<a id="postcrmv3associationsfromobjecttypetoobjecttypebatchreadread"></a>
# **PostCrmV3AssociationsFromObjectTypeToObjectTypeBatchReadRead**
> BatchResponsePublicAssociationMulti PostCrmV3AssociationsFromObjectTypeToObjectTypeBatchReadRead (string fromObjectType, string toObjectType, BatchInputPublicObjectId batchInputPublicObjectId)

Read a batch of associations

Get the IDs of all `{toObjectType}` objects associated with those specified in the request body.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Associations.Api;
using HubSpot.Crm.Associations.Client;
using HubSpot.Crm.Associations.Model;

namespace Example
{
    public class PostCrmV3AssociationsFromObjectTypeToObjectTypeBatchReadReadExample
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

            var apiInstance = new BatchApi(config);
            var fromObjectType = "fromObjectType_example";  // string | 
            var toObjectType = "toObjectType_example";  // string | 
            var batchInputPublicObjectId = new BatchInputPublicObjectId(); // BatchInputPublicObjectId | 

            try
            {
                // Read a batch of associations
                BatchResponsePublicAssociationMulti result = apiInstance.PostCrmV3AssociationsFromObjectTypeToObjectTypeBatchReadRead(fromObjectType, toObjectType, batchInputPublicObjectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV3AssociationsFromObjectTypeToObjectTypeBatchReadRead: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3AssociationsFromObjectTypeToObjectTypeBatchReadReadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read a batch of associations
    ApiResponse<BatchResponsePublicAssociationMulti> response = apiInstance.PostCrmV3AssociationsFromObjectTypeToObjectTypeBatchReadReadWithHttpInfo(fromObjectType, toObjectType, batchInputPublicObjectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV3AssociationsFromObjectTypeToObjectTypeBatchReadReadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fromObjectType** | **string** |  |  |
| **toObjectType** | **string** |  |  |
| **batchInputPublicObjectId** | [**BatchInputPublicObjectId**](BatchInputPublicObjectId.md) |  |  |

### Return type

[**BatchResponsePublicAssociationMulti**](BatchResponsePublicAssociationMulti.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps_legacy](../README.md#private_apps_legacy), [private_apps](../README.md#private_apps)

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

