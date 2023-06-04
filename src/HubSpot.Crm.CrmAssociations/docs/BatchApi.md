# HubSpot.Crm.CrmAssociations.Api.BatchApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchArchiveArchive**](BatchApi.md#postcrmv4associationsfromobjecttypetoobjecttypebatcharchivearchive) | **POST** /crm/v4/associations/{fromObjectType}/{toObjectType}/batch/archive | Delete |
| [**PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchAssociateDefaultCreateDefault**](BatchApi.md#postcrmv4associationsfromobjecttypetoobjecttypebatchassociatedefaultcreatedefault) | **POST** /crm/v4/associations/{fromObjectType}/{toObjectType}/batch/associate/default |  Create Default Associations |
| [**PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchCreateCreate**](BatchApi.md#postcrmv4associationsfromobjecttypetoobjecttypebatchcreatecreate) | **POST** /crm/v4/associations/{fromObjectType}/{toObjectType}/batch/create | Create |
| [**PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchLabelsArchiveArchiveLabels**](BatchApi.md#postcrmv4associationsfromobjecttypetoobjecttypebatchlabelsarchivearchivelabels) | **POST** /crm/v4/associations/{fromObjectType}/{toObjectType}/batch/labels/archive | Delete Specific Labels |
| [**PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchReadGetPage**](BatchApi.md#postcrmv4associationsfromobjecttypetoobjecttypebatchreadgetpage) | **POST** /crm/v4/associations/{fromObjectType}/{toObjectType}/batch/read | Read |

<a id="postcrmv4associationsfromobjecttypetoobjecttypebatcharchivearchive"></a>
# **PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchArchiveArchive**
> void PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchArchiveArchive (string fromObjectType, string toObjectType, BatchInputPublicAssociationMultiArchive batchInputPublicAssociationMultiArchive)

Delete

Batch delete associations for objects

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.CrmAssociations.Api;
using HubSpot.Crm.CrmAssociations.Client;
using HubSpot.Crm.CrmAssociations.Model;

namespace Example
{
    public class PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchArchiveArchiveExample
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
            var batchInputPublicAssociationMultiArchive = new BatchInputPublicAssociationMultiArchive(); // BatchInputPublicAssociationMultiArchive | 

            try
            {
                // Delete
                apiInstance.PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchArchiveArchive(fromObjectType, toObjectType, batchInputPublicAssociationMultiArchive);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchArchiveArchive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchArchiveArchiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete
    apiInstance.PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchArchiveArchiveWithHttpInfo(fromObjectType, toObjectType, batchInputPublicAssociationMultiArchive);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchArchiveArchiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fromObjectType** | **string** |  |  |
| **toObjectType** | **string** |  |  |
| **batchInputPublicAssociationMultiArchive** | [**BatchInputPublicAssociationMultiArchive**](BatchInputPublicAssociationMultiArchive.md) |  |  |

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

<a id="postcrmv4associationsfromobjecttypetoobjecttypebatchassociatedefaultcreatedefault"></a>
# **PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchAssociateDefaultCreateDefault**
> BatchResponsePublicDefaultAssociation PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchAssociateDefaultCreateDefault (string fromObjectType, string toObjectType, BatchInputPublicDefaultAssociationMultiPost batchInputPublicDefaultAssociationMultiPost)

 Create Default Associations

Create the default (most generic) association type between two object types

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.CrmAssociations.Api;
using HubSpot.Crm.CrmAssociations.Client;
using HubSpot.Crm.CrmAssociations.Model;

namespace Example
{
    public class PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchAssociateDefaultCreateDefaultExample
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
            var batchInputPublicDefaultAssociationMultiPost = new BatchInputPublicDefaultAssociationMultiPost(); // BatchInputPublicDefaultAssociationMultiPost | 

            try
            {
                //  Create Default Associations
                BatchResponsePublicDefaultAssociation result = apiInstance.PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchAssociateDefaultCreateDefault(fromObjectType, toObjectType, batchInputPublicDefaultAssociationMultiPost);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchAssociateDefaultCreateDefault: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchAssociateDefaultCreateDefaultWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    //  Create Default Associations
    ApiResponse<BatchResponsePublicDefaultAssociation> response = apiInstance.PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchAssociateDefaultCreateDefaultWithHttpInfo(fromObjectType, toObjectType, batchInputPublicDefaultAssociationMultiPost);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchAssociateDefaultCreateDefaultWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fromObjectType** | **string** |  |  |
| **toObjectType** | **string** |  |  |
| **batchInputPublicDefaultAssociationMultiPost** | [**BatchInputPublicDefaultAssociationMultiPost**](BatchInputPublicDefaultAssociationMultiPost.md) |  |  |

### Return type

[**BatchResponsePublicDefaultAssociation**](BatchResponsePublicDefaultAssociation.md)

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

<a id="postcrmv4associationsfromobjecttypetoobjecttypebatchcreatecreate"></a>
# **PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchCreateCreate**
> BatchResponseLabelsBetweenObjectPair PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchCreateCreate (string fromObjectType, string toObjectType, BatchInputPublicAssociationMultiPost batchInputPublicAssociationMultiPost)

Create

Batch create associations for objects

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.CrmAssociations.Api;
using HubSpot.Crm.CrmAssociations.Client;
using HubSpot.Crm.CrmAssociations.Model;

namespace Example
{
    public class PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchCreateCreateExample
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
            var batchInputPublicAssociationMultiPost = new BatchInputPublicAssociationMultiPost(); // BatchInputPublicAssociationMultiPost | 

            try
            {
                // Create
                BatchResponseLabelsBetweenObjectPair result = apiInstance.PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchCreateCreate(fromObjectType, toObjectType, batchInputPublicAssociationMultiPost);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchCreateCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchCreateCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create
    ApiResponse<BatchResponseLabelsBetweenObjectPair> response = apiInstance.PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchCreateCreateWithHttpInfo(fromObjectType, toObjectType, batchInputPublicAssociationMultiPost);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchCreateCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fromObjectType** | **string** |  |  |
| **toObjectType** | **string** |  |  |
| **batchInputPublicAssociationMultiPost** | [**BatchInputPublicAssociationMultiPost**](BatchInputPublicAssociationMultiPost.md) |  |  |

### Return type

[**BatchResponseLabelsBetweenObjectPair**](BatchResponseLabelsBetweenObjectPair.md)

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

<a id="postcrmv4associationsfromobjecttypetoobjecttypebatchlabelsarchivearchivelabels"></a>
# **PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchLabelsArchiveArchiveLabels**
> void PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchLabelsArchiveArchiveLabels (string fromObjectType, string toObjectType, BatchInputPublicAssociationMultiPost batchInputPublicAssociationMultiPost)

Delete Specific Labels

Batch delete specific association labels for objects. Deleting an unlabeled association will also delete all labeled associations between those two objects

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.CrmAssociations.Api;
using HubSpot.Crm.CrmAssociations.Client;
using HubSpot.Crm.CrmAssociations.Model;

namespace Example
{
    public class PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchLabelsArchiveArchiveLabelsExample
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
            var batchInputPublicAssociationMultiPost = new BatchInputPublicAssociationMultiPost(); // BatchInputPublicAssociationMultiPost | 

            try
            {
                // Delete Specific Labels
                apiInstance.PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchLabelsArchiveArchiveLabels(fromObjectType, toObjectType, batchInputPublicAssociationMultiPost);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchLabelsArchiveArchiveLabels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchLabelsArchiveArchiveLabelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Specific Labels
    apiInstance.PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchLabelsArchiveArchiveLabelsWithHttpInfo(fromObjectType, toObjectType, batchInputPublicAssociationMultiPost);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchLabelsArchiveArchiveLabelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fromObjectType** | **string** |  |  |
| **toObjectType** | **string** |  |  |
| **batchInputPublicAssociationMultiPost** | [**BatchInputPublicAssociationMultiPost**](BatchInputPublicAssociationMultiPost.md) |  |  |

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

<a id="postcrmv4associationsfromobjecttypetoobjecttypebatchreadgetpage"></a>
# **PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchReadGetPage**
> BatchResponsePublicAssociationMultiWithLabel PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchReadGetPage (string fromObjectType, string toObjectType, BatchInputPublicFetchAssociationsBatchRequest batchInputPublicFetchAssociationsBatchRequest)

Read

Batch read associations for objects to specific object type. The 'after' field in a returned paging object  can be added alongside the 'id' to retrieve the next page of associations from that objectId. The 'link' field is deprecated and should be ignored. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.CrmAssociations.Api;
using HubSpot.Crm.CrmAssociations.Client;
using HubSpot.Crm.CrmAssociations.Model;

namespace Example
{
    public class PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchReadGetPageExample
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
            var batchInputPublicFetchAssociationsBatchRequest = new BatchInputPublicFetchAssociationsBatchRequest(); // BatchInputPublicFetchAssociationsBatchRequest | 

            try
            {
                // Read
                BatchResponsePublicAssociationMultiWithLabel result = apiInstance.PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchReadGetPage(fromObjectType, toObjectType, batchInputPublicFetchAssociationsBatchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchReadGetPage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchReadGetPageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read
    ApiResponse<BatchResponsePublicAssociationMultiWithLabel> response = apiInstance.PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchReadGetPageWithHttpInfo(fromObjectType, toObjectType, batchInputPublicFetchAssociationsBatchRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV4AssociationsFromObjectTypeToObjectTypeBatchReadGetPageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fromObjectType** | **string** |  |  |
| **toObjectType** | **string** |  |  |
| **batchInputPublicFetchAssociationsBatchRequest** | [**BatchInputPublicFetchAssociationsBatchRequest**](BatchInputPublicFetchAssociationsBatchRequest.md) |  |  |

### Return type

[**BatchResponsePublicAssociationMultiWithLabel**](BatchResponsePublicAssociationMultiWithLabel.md)

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

