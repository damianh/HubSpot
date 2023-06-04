# HubSpot.Crm.CrmAssociations.Api.DefinitionsApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteCrmV4AssociationsFromObjectTypeToObjectTypeLabelsAssociationTypeIdArchive**](DefinitionsApi.md#deletecrmv4associationsfromobjecttypetoobjecttypelabelsassociationtypeidarchive) | **DELETE** /crm/v4/associations/{fromObjectType}/{toObjectType}/labels/{associationTypeId} | Delete |
| [**GetCrmV4AssociationsFromObjectTypeToObjectTypeLabelsGetAll**](DefinitionsApi.md#getcrmv4associationsfromobjecttypetoobjecttypelabelsgetall) | **GET** /crm/v4/associations/{fromObjectType}/{toObjectType}/labels | Read |
| [**PostCrmV4AssociationsFromObjectTypeToObjectTypeLabelsCreate**](DefinitionsApi.md#postcrmv4associationsfromobjecttypetoobjecttypelabelscreate) | **POST** /crm/v4/associations/{fromObjectType}/{toObjectType}/labels | Create |
| [**PutCrmV4AssociationsFromObjectTypeToObjectTypeLabelsUpdate**](DefinitionsApi.md#putcrmv4associationsfromobjecttypetoobjecttypelabelsupdate) | **PUT** /crm/v4/associations/{fromObjectType}/{toObjectType}/labels | Update |

<a id="deletecrmv4associationsfromobjecttypetoobjecttypelabelsassociationtypeidarchive"></a>
# **DeleteCrmV4AssociationsFromObjectTypeToObjectTypeLabelsAssociationTypeIdArchive**
> void DeleteCrmV4AssociationsFromObjectTypeToObjectTypeLabelsAssociationTypeIdArchive (string fromObjectType, string toObjectType, int associationTypeId)

Delete

Deletes an association definition

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.CrmAssociations.Api;
using HubSpot.Crm.CrmAssociations.Client;
using HubSpot.Crm.CrmAssociations.Model;

namespace Example
{
    public class DeleteCrmV4AssociationsFromObjectTypeToObjectTypeLabelsAssociationTypeIdArchiveExample
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

            var apiInstance = new DefinitionsApi(config);
            var fromObjectType = "fromObjectType_example";  // string | 
            var toObjectType = "toObjectType_example";  // string | 
            var associationTypeId = 56;  // int | 

            try
            {
                // Delete
                apiInstance.DeleteCrmV4AssociationsFromObjectTypeToObjectTypeLabelsAssociationTypeIdArchive(fromObjectType, toObjectType, associationTypeId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefinitionsApi.DeleteCrmV4AssociationsFromObjectTypeToObjectTypeLabelsAssociationTypeIdArchive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCrmV4AssociationsFromObjectTypeToObjectTypeLabelsAssociationTypeIdArchiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete
    apiInstance.DeleteCrmV4AssociationsFromObjectTypeToObjectTypeLabelsAssociationTypeIdArchiveWithHttpInfo(fromObjectType, toObjectType, associationTypeId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefinitionsApi.DeleteCrmV4AssociationsFromObjectTypeToObjectTypeLabelsAssociationTypeIdArchiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fromObjectType** | **string** |  |  |
| **toObjectType** | **string** |  |  |
| **associationTypeId** | **int** |  |  |

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

<a id="getcrmv4associationsfromobjecttypetoobjecttypelabelsgetall"></a>
# **GetCrmV4AssociationsFromObjectTypeToObjectTypeLabelsGetAll**
> CollectionResponseAssociationSpecWithLabelNoPaging GetCrmV4AssociationsFromObjectTypeToObjectTypeLabelsGetAll (string fromObjectType, string toObjectType)

Read

Returns all association types between two object types

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.CrmAssociations.Api;
using HubSpot.Crm.CrmAssociations.Client;
using HubSpot.Crm.CrmAssociations.Model;

namespace Example
{
    public class GetCrmV4AssociationsFromObjectTypeToObjectTypeLabelsGetAllExample
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

            var apiInstance = new DefinitionsApi(config);
            var fromObjectType = "fromObjectType_example";  // string | 
            var toObjectType = "toObjectType_example";  // string | 

            try
            {
                // Read
                CollectionResponseAssociationSpecWithLabelNoPaging result = apiInstance.GetCrmV4AssociationsFromObjectTypeToObjectTypeLabelsGetAll(fromObjectType, toObjectType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefinitionsApi.GetCrmV4AssociationsFromObjectTypeToObjectTypeLabelsGetAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCrmV4AssociationsFromObjectTypeToObjectTypeLabelsGetAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read
    ApiResponse<CollectionResponseAssociationSpecWithLabelNoPaging> response = apiInstance.GetCrmV4AssociationsFromObjectTypeToObjectTypeLabelsGetAllWithHttpInfo(fromObjectType, toObjectType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefinitionsApi.GetCrmV4AssociationsFromObjectTypeToObjectTypeLabelsGetAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fromObjectType** | **string** |  |  |
| **toObjectType** | **string** |  |  |

### Return type

[**CollectionResponseAssociationSpecWithLabelNoPaging**](CollectionResponseAssociationSpecWithLabelNoPaging.md)

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

<a id="postcrmv4associationsfromobjecttypetoobjecttypelabelscreate"></a>
# **PostCrmV4AssociationsFromObjectTypeToObjectTypeLabelsCreate**
> CollectionResponseAssociationSpecWithLabelNoPaging PostCrmV4AssociationsFromObjectTypeToObjectTypeLabelsCreate (string fromObjectType, string toObjectType, PublicAssociationDefinitionCreateRequest publicAssociationDefinitionCreateRequest)

Create

Create a user defined association definition

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.CrmAssociations.Api;
using HubSpot.Crm.CrmAssociations.Client;
using HubSpot.Crm.CrmAssociations.Model;

namespace Example
{
    public class PostCrmV4AssociationsFromObjectTypeToObjectTypeLabelsCreateExample
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

            var apiInstance = new DefinitionsApi(config);
            var fromObjectType = "fromObjectType_example";  // string | 
            var toObjectType = "toObjectType_example";  // string | 
            var publicAssociationDefinitionCreateRequest = new PublicAssociationDefinitionCreateRequest(); // PublicAssociationDefinitionCreateRequest | 

            try
            {
                // Create
                CollectionResponseAssociationSpecWithLabelNoPaging result = apiInstance.PostCrmV4AssociationsFromObjectTypeToObjectTypeLabelsCreate(fromObjectType, toObjectType, publicAssociationDefinitionCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefinitionsApi.PostCrmV4AssociationsFromObjectTypeToObjectTypeLabelsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV4AssociationsFromObjectTypeToObjectTypeLabelsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create
    ApiResponse<CollectionResponseAssociationSpecWithLabelNoPaging> response = apiInstance.PostCrmV4AssociationsFromObjectTypeToObjectTypeLabelsCreateWithHttpInfo(fromObjectType, toObjectType, publicAssociationDefinitionCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefinitionsApi.PostCrmV4AssociationsFromObjectTypeToObjectTypeLabelsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fromObjectType** | **string** |  |  |
| **toObjectType** | **string** |  |  |
| **publicAssociationDefinitionCreateRequest** | [**PublicAssociationDefinitionCreateRequest**](PublicAssociationDefinitionCreateRequest.md) |  |  |

### Return type

[**CollectionResponseAssociationSpecWithLabelNoPaging**](CollectionResponseAssociationSpecWithLabelNoPaging.md)

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

<a id="putcrmv4associationsfromobjecttypetoobjecttypelabelsupdate"></a>
# **PutCrmV4AssociationsFromObjectTypeToObjectTypeLabelsUpdate**
> void PutCrmV4AssociationsFromObjectTypeToObjectTypeLabelsUpdate (string fromObjectType, string toObjectType, PublicAssociationDefinitionUpdateRequest publicAssociationDefinitionUpdateRequest)

Update

Update a user defined association definition

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.CrmAssociations.Api;
using HubSpot.Crm.CrmAssociations.Client;
using HubSpot.Crm.CrmAssociations.Model;

namespace Example
{
    public class PutCrmV4AssociationsFromObjectTypeToObjectTypeLabelsUpdateExample
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

            var apiInstance = new DefinitionsApi(config);
            var fromObjectType = "fromObjectType_example";  // string | 
            var toObjectType = "toObjectType_example";  // string | 
            var publicAssociationDefinitionUpdateRequest = new PublicAssociationDefinitionUpdateRequest(); // PublicAssociationDefinitionUpdateRequest | 

            try
            {
                // Update
                apiInstance.PutCrmV4AssociationsFromObjectTypeToObjectTypeLabelsUpdate(fromObjectType, toObjectType, publicAssociationDefinitionUpdateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefinitionsApi.PutCrmV4AssociationsFromObjectTypeToObjectTypeLabelsUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutCrmV4AssociationsFromObjectTypeToObjectTypeLabelsUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update
    apiInstance.PutCrmV4AssociationsFromObjectTypeToObjectTypeLabelsUpdateWithHttpInfo(fromObjectType, toObjectType, publicAssociationDefinitionUpdateRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefinitionsApi.PutCrmV4AssociationsFromObjectTypeToObjectTypeLabelsUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fromObjectType** | **string** |  |  |
| **toObjectType** | **string** |  |  |
| **publicAssociationDefinitionUpdateRequest** | [**PublicAssociationDefinitionUpdateRequest**](PublicAssociationDefinitionUpdateRequest.md) |  |  |

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

