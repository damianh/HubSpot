# HubSpot.Crm.LineItems.Api.BatchApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostCrmV3ObjectsLineItemsBatchArchiveArchive**](BatchApi.md#postcrmv3objectslineitemsbatcharchivearchive) | **POST** /crm/v3/objects/line_items/batch/archive | Archive a batch of line items by ID |
| [**PostCrmV3ObjectsLineItemsBatchCreateCreate**](BatchApi.md#postcrmv3objectslineitemsbatchcreatecreate) | **POST** /crm/v3/objects/line_items/batch/create | Create a batch of line items |
| [**PostCrmV3ObjectsLineItemsBatchReadRead**](BatchApi.md#postcrmv3objectslineitemsbatchreadread) | **POST** /crm/v3/objects/line_items/batch/read | Read a batch of line items by internal ID, or unique property values |
| [**PostCrmV3ObjectsLineItemsBatchUpdateUpdate**](BatchApi.md#postcrmv3objectslineitemsbatchupdateupdate) | **POST** /crm/v3/objects/line_items/batch/update | Update a batch of line items |

<a id="postcrmv3objectslineitemsbatcharchivearchive"></a>
# **PostCrmV3ObjectsLineItemsBatchArchiveArchive**
> void PostCrmV3ObjectsLineItemsBatchArchiveArchive (BatchInputSimplePublicObjectId batchInputSimplePublicObjectId)

Archive a batch of line items by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.LineItems.Api;
using HubSpot.Crm.LineItems.Client;
using HubSpot.Crm.LineItems.Model;

namespace Example
{
    public class PostCrmV3ObjectsLineItemsBatchArchiveArchiveExample
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
            var batchInputSimplePublicObjectId = new BatchInputSimplePublicObjectId(); // BatchInputSimplePublicObjectId | 

            try
            {
                // Archive a batch of line items by ID
                apiInstance.PostCrmV3ObjectsLineItemsBatchArchiveArchive(batchInputSimplePublicObjectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsLineItemsBatchArchiveArchive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsLineItemsBatchArchiveArchiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Archive a batch of line items by ID
    apiInstance.PostCrmV3ObjectsLineItemsBatchArchiveArchiveWithHttpInfo(batchInputSimplePublicObjectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsLineItemsBatchArchiveArchiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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

<a id="postcrmv3objectslineitemsbatchcreatecreate"></a>
# **PostCrmV3ObjectsLineItemsBatchCreateCreate**
> BatchResponseSimplePublicObject PostCrmV3ObjectsLineItemsBatchCreateCreate (BatchInputSimplePublicObjectInputForCreate batchInputSimplePublicObjectInputForCreate)

Create a batch of line items

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.LineItems.Api;
using HubSpot.Crm.LineItems.Client;
using HubSpot.Crm.LineItems.Model;

namespace Example
{
    public class PostCrmV3ObjectsLineItemsBatchCreateCreateExample
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
            var batchInputSimplePublicObjectInputForCreate = new BatchInputSimplePublicObjectInputForCreate(); // BatchInputSimplePublicObjectInputForCreate | 

            try
            {
                // Create a batch of line items
                BatchResponseSimplePublicObject result = apiInstance.PostCrmV3ObjectsLineItemsBatchCreateCreate(batchInputSimplePublicObjectInputForCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsLineItemsBatchCreateCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsLineItemsBatchCreateCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a batch of line items
    ApiResponse<BatchResponseSimplePublicObject> response = apiInstance.PostCrmV3ObjectsLineItemsBatchCreateCreateWithHttpInfo(batchInputSimplePublicObjectInputForCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsLineItemsBatchCreateCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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

<a id="postcrmv3objectslineitemsbatchreadread"></a>
# **PostCrmV3ObjectsLineItemsBatchReadRead**
> BatchResponseSimplePublicObject PostCrmV3ObjectsLineItemsBatchReadRead (BatchReadInputSimplePublicObjectId batchReadInputSimplePublicObjectId, bool? archived = null)

Read a batch of line items by internal ID, or unique property values

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.LineItems.Api;
using HubSpot.Crm.LineItems.Client;
using HubSpot.Crm.LineItems.Model;

namespace Example
{
    public class PostCrmV3ObjectsLineItemsBatchReadReadExample
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
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: private_apps
            config.AddApiKey("private-app", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app", "Bearer");

            var apiInstance = new BatchApi(config);
            var batchReadInputSimplePublicObjectId = new BatchReadInputSimplePublicObjectId(); // BatchReadInputSimplePublicObjectId | 
            var archived = false;  // bool? | Whether to return only results that have been archived. (optional)  (default to false)

            try
            {
                // Read a batch of line items by internal ID, or unique property values
                BatchResponseSimplePublicObject result = apiInstance.PostCrmV3ObjectsLineItemsBatchReadRead(batchReadInputSimplePublicObjectId, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsLineItemsBatchReadRead: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsLineItemsBatchReadReadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read a batch of line items by internal ID, or unique property values
    ApiResponse<BatchResponseSimplePublicObject> response = apiInstance.PostCrmV3ObjectsLineItemsBatchReadReadWithHttpInfo(batchReadInputSimplePublicObjectId, archived);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsLineItemsBatchReadReadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchReadInputSimplePublicObjectId** | [**BatchReadInputSimplePublicObjectId**](BatchReadInputSimplePublicObjectId.md) |  |  |
| **archived** | **bool?** | Whether to return only results that have been archived. | [optional] [default to false] |

### Return type

[**BatchResponseSimplePublicObject**](BatchResponseSimplePublicObject.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy), [oauth2](../README.md#oauth2), [private_apps](../README.md#private_apps)

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

<a id="postcrmv3objectslineitemsbatchupdateupdate"></a>
# **PostCrmV3ObjectsLineItemsBatchUpdateUpdate**
> BatchResponseSimplePublicObject PostCrmV3ObjectsLineItemsBatchUpdateUpdate (BatchInputSimplePublicObjectBatchInput batchInputSimplePublicObjectBatchInput)

Update a batch of line items

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.LineItems.Api;
using HubSpot.Crm.LineItems.Client;
using HubSpot.Crm.LineItems.Model;

namespace Example
{
    public class PostCrmV3ObjectsLineItemsBatchUpdateUpdateExample
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
            var batchInputSimplePublicObjectBatchInput = new BatchInputSimplePublicObjectBatchInput(); // BatchInputSimplePublicObjectBatchInput | 

            try
            {
                // Update a batch of line items
                BatchResponseSimplePublicObject result = apiInstance.PostCrmV3ObjectsLineItemsBatchUpdateUpdate(batchInputSimplePublicObjectBatchInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsLineItemsBatchUpdateUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsLineItemsBatchUpdateUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a batch of line items
    ApiResponse<BatchResponseSimplePublicObject> response = apiInstance.PostCrmV3ObjectsLineItemsBatchUpdateUpdateWithHttpInfo(batchInputSimplePublicObjectBatchInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsLineItemsBatchUpdateUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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

