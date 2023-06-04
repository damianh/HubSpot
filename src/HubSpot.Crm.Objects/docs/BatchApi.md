# HubSpot.Crm.Objects.Api.BatchApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostCrmV3ObjectsObjectTypeBatchArchiveArchive**](BatchApi.md#postcrmv3objectsobjecttypebatcharchivearchive) | **POST** /crm/v3/objects/{objectType}/batch/archive | Archive a batch of objects by ID |
| [**PostCrmV3ObjectsObjectTypeBatchCreateCreate**](BatchApi.md#postcrmv3objectsobjecttypebatchcreatecreate) | **POST** /crm/v3/objects/{objectType}/batch/create | Create a batch of objects |
| [**PostCrmV3ObjectsObjectTypeBatchReadRead**](BatchApi.md#postcrmv3objectsobjecttypebatchreadread) | **POST** /crm/v3/objects/{objectType}/batch/read | Read a batch of objects by internal ID, or unique property values |
| [**PostCrmV3ObjectsObjectTypeBatchUpdateUpdate**](BatchApi.md#postcrmv3objectsobjecttypebatchupdateupdate) | **POST** /crm/v3/objects/{objectType}/batch/update | Update a batch of objects |

<a id="postcrmv3objectsobjecttypebatcharchivearchive"></a>
# **PostCrmV3ObjectsObjectTypeBatchArchiveArchive**
> void PostCrmV3ObjectsObjectTypeBatchArchiveArchive (string objectType, BatchInputSimplePublicObjectId batchInputSimplePublicObjectId)

Archive a batch of objects by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Objects.Api;
using HubSpot.Crm.Objects.Client;
using HubSpot.Crm.Objects.Model;

namespace Example
{
    public class PostCrmV3ObjectsObjectTypeBatchArchiveArchiveExample
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
            var objectType = "objectType_example";  // string | 
            var batchInputSimplePublicObjectId = new BatchInputSimplePublicObjectId(); // BatchInputSimplePublicObjectId | 

            try
            {
                // Archive a batch of objects by ID
                apiInstance.PostCrmV3ObjectsObjectTypeBatchArchiveArchive(objectType, batchInputSimplePublicObjectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsObjectTypeBatchArchiveArchive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsObjectTypeBatchArchiveArchiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Archive a batch of objects by ID
    apiInstance.PostCrmV3ObjectsObjectTypeBatchArchiveArchiveWithHttpInfo(objectType, batchInputSimplePublicObjectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsObjectTypeBatchArchiveArchiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectType** | **string** |  |  |
| **batchInputSimplePublicObjectId** | [**BatchInputSimplePublicObjectId**](BatchInputSimplePublicObjectId.md) |  |  |

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

<a id="postcrmv3objectsobjecttypebatchcreatecreate"></a>
# **PostCrmV3ObjectsObjectTypeBatchCreateCreate**
> BatchResponseSimplePublicObject PostCrmV3ObjectsObjectTypeBatchCreateCreate (string objectType, BatchInputSimplePublicObjectInputForCreate batchInputSimplePublicObjectInputForCreate)

Create a batch of objects

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Objects.Api;
using HubSpot.Crm.Objects.Client;
using HubSpot.Crm.Objects.Model;

namespace Example
{
    public class PostCrmV3ObjectsObjectTypeBatchCreateCreateExample
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
            var objectType = "objectType_example";  // string | 
            var batchInputSimplePublicObjectInputForCreate = new BatchInputSimplePublicObjectInputForCreate(); // BatchInputSimplePublicObjectInputForCreate | 

            try
            {
                // Create a batch of objects
                BatchResponseSimplePublicObject result = apiInstance.PostCrmV3ObjectsObjectTypeBatchCreateCreate(objectType, batchInputSimplePublicObjectInputForCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsObjectTypeBatchCreateCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsObjectTypeBatchCreateCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a batch of objects
    ApiResponse<BatchResponseSimplePublicObject> response = apiInstance.PostCrmV3ObjectsObjectTypeBatchCreateCreateWithHttpInfo(objectType, batchInputSimplePublicObjectInputForCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsObjectTypeBatchCreateCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectType** | **string** |  |  |
| **batchInputSimplePublicObjectInputForCreate** | [**BatchInputSimplePublicObjectInputForCreate**](BatchInputSimplePublicObjectInputForCreate.md) |  |  |

### Return type

[**BatchResponseSimplePublicObject**](BatchResponseSimplePublicObject.md)

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

<a id="postcrmv3objectsobjecttypebatchreadread"></a>
# **PostCrmV3ObjectsObjectTypeBatchReadRead**
> BatchResponseSimplePublicObject PostCrmV3ObjectsObjectTypeBatchReadRead (string objectType, BatchReadInputSimplePublicObjectId batchReadInputSimplePublicObjectId, bool? archived = null)

Read a batch of objects by internal ID, or unique property values

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Objects.Api;
using HubSpot.Crm.Objects.Client;
using HubSpot.Crm.Objects.Model;

namespace Example
{
    public class PostCrmV3ObjectsObjectTypeBatchReadReadExample
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
            var objectType = "objectType_example";  // string | 
            var batchReadInputSimplePublicObjectId = new BatchReadInputSimplePublicObjectId(); // BatchReadInputSimplePublicObjectId | 
            var archived = false;  // bool? | Whether to return only results that have been archived. (optional)  (default to false)

            try
            {
                // Read a batch of objects by internal ID, or unique property values
                BatchResponseSimplePublicObject result = apiInstance.PostCrmV3ObjectsObjectTypeBatchReadRead(objectType, batchReadInputSimplePublicObjectId, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsObjectTypeBatchReadRead: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsObjectTypeBatchReadReadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read a batch of objects by internal ID, or unique property values
    ApiResponse<BatchResponseSimplePublicObject> response = apiInstance.PostCrmV3ObjectsObjectTypeBatchReadReadWithHttpInfo(objectType, batchReadInputSimplePublicObjectId, archived);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsObjectTypeBatchReadReadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectType** | **string** |  |  |
| **batchReadInputSimplePublicObjectId** | [**BatchReadInputSimplePublicObjectId**](BatchReadInputSimplePublicObjectId.md) |  |  |
| **archived** | **bool?** | Whether to return only results that have been archived. | [optional] [default to false] |

### Return type

[**BatchResponseSimplePublicObject**](BatchResponseSimplePublicObject.md)

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

<a id="postcrmv3objectsobjecttypebatchupdateupdate"></a>
# **PostCrmV3ObjectsObjectTypeBatchUpdateUpdate**
> BatchResponseSimplePublicObject PostCrmV3ObjectsObjectTypeBatchUpdateUpdate (string objectType, BatchInputSimplePublicObjectBatchInput batchInputSimplePublicObjectBatchInput)

Update a batch of objects

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Objects.Api;
using HubSpot.Crm.Objects.Client;
using HubSpot.Crm.Objects.Model;

namespace Example
{
    public class PostCrmV3ObjectsObjectTypeBatchUpdateUpdateExample
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
            var objectType = "objectType_example";  // string | 
            var batchInputSimplePublicObjectBatchInput = new BatchInputSimplePublicObjectBatchInput(); // BatchInputSimplePublicObjectBatchInput | 

            try
            {
                // Update a batch of objects
                BatchResponseSimplePublicObject result = apiInstance.PostCrmV3ObjectsObjectTypeBatchUpdateUpdate(objectType, batchInputSimplePublicObjectBatchInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsObjectTypeBatchUpdateUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsObjectTypeBatchUpdateUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a batch of objects
    ApiResponse<BatchResponseSimplePublicObject> response = apiInstance.PostCrmV3ObjectsObjectTypeBatchUpdateUpdateWithHttpInfo(objectType, batchInputSimplePublicObjectBatchInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsObjectTypeBatchUpdateUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectType** | **string** |  |  |
| **batchInputSimplePublicObjectBatchInput** | [**BatchInputSimplePublicObjectBatchInput**](BatchInputSimplePublicObjectBatchInput.md) |  |  |

### Return type

[**BatchResponseSimplePublicObject**](BatchResponseSimplePublicObject.md)

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

