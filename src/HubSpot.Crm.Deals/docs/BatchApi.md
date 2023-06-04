# HubSpot.Crm.Deals.Api.BatchApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostCrmV3ObjectsDealsBatchArchiveArchive**](BatchApi.md#postcrmv3objectsdealsbatcharchivearchive) | **POST** /crm/v3/objects/deals/batch/archive | Archive a batch of deals by ID |
| [**PostCrmV3ObjectsDealsBatchCreateCreate**](BatchApi.md#postcrmv3objectsdealsbatchcreatecreate) | **POST** /crm/v3/objects/deals/batch/create | Create a batch of deals |
| [**PostCrmV3ObjectsDealsBatchReadRead**](BatchApi.md#postcrmv3objectsdealsbatchreadread) | **POST** /crm/v3/objects/deals/batch/read | Read a batch of deals by internal ID, or unique property values |
| [**PostCrmV3ObjectsDealsBatchUpdateUpdate**](BatchApi.md#postcrmv3objectsdealsbatchupdateupdate) | **POST** /crm/v3/objects/deals/batch/update | Update a batch of deals |

<a id="postcrmv3objectsdealsbatcharchivearchive"></a>
# **PostCrmV3ObjectsDealsBatchArchiveArchive**
> void PostCrmV3ObjectsDealsBatchArchiveArchive (BatchInputSimplePublicObjectId batchInputSimplePublicObjectId)

Archive a batch of deals by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Deals.Api;
using HubSpot.Crm.Deals.Client;
using HubSpot.Crm.Deals.Model;

namespace Example
{
    public class PostCrmV3ObjectsDealsBatchArchiveArchiveExample
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

            var apiInstance = new BatchApi(config);
            var batchInputSimplePublicObjectId = new BatchInputSimplePublicObjectId(); // BatchInputSimplePublicObjectId | 

            try
            {
                // Archive a batch of deals by ID
                apiInstance.PostCrmV3ObjectsDealsBatchArchiveArchive(batchInputSimplePublicObjectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsDealsBatchArchiveArchive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsDealsBatchArchiveArchiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Archive a batch of deals by ID
    apiInstance.PostCrmV3ObjectsDealsBatchArchiveArchiveWithHttpInfo(batchInputSimplePublicObjectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsDealsBatchArchiveArchiveWithHttpInfo: " + e.Message);
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

[hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps_legacy](../README.md#private_apps_legacy), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcrmv3objectsdealsbatchcreatecreate"></a>
# **PostCrmV3ObjectsDealsBatchCreateCreate**
> BatchResponseSimplePublicObject PostCrmV3ObjectsDealsBatchCreateCreate (BatchInputSimplePublicObjectInputForCreate batchInputSimplePublicObjectInputForCreate)

Create a batch of deals

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Deals.Api;
using HubSpot.Crm.Deals.Client;
using HubSpot.Crm.Deals.Model;

namespace Example
{
    public class PostCrmV3ObjectsDealsBatchCreateCreateExample
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

            var apiInstance = new BatchApi(config);
            var batchInputSimplePublicObjectInputForCreate = new BatchInputSimplePublicObjectInputForCreate(); // BatchInputSimplePublicObjectInputForCreate | 

            try
            {
                // Create a batch of deals
                BatchResponseSimplePublicObject result = apiInstance.PostCrmV3ObjectsDealsBatchCreateCreate(batchInputSimplePublicObjectInputForCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsDealsBatchCreateCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsDealsBatchCreateCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a batch of deals
    ApiResponse<BatchResponseSimplePublicObject> response = apiInstance.PostCrmV3ObjectsDealsBatchCreateCreateWithHttpInfo(batchInputSimplePublicObjectInputForCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsDealsBatchCreateCreateWithHttpInfo: " + e.Message);
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

[hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps_legacy](../README.md#private_apps_legacy), [private_apps](../README.md#private_apps)

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

<a id="postcrmv3objectsdealsbatchreadread"></a>
# **PostCrmV3ObjectsDealsBatchReadRead**
> BatchResponseSimplePublicObject PostCrmV3ObjectsDealsBatchReadRead (BatchReadInputSimplePublicObjectId batchReadInputSimplePublicObjectId, bool? archived = null)

Read a batch of deals by internal ID, or unique property values

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Deals.Api;
using HubSpot.Crm.Deals.Client;
using HubSpot.Crm.Deals.Model;

namespace Example
{
    public class PostCrmV3ObjectsDealsBatchReadReadExample
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

            var apiInstance = new BatchApi(config);
            var batchReadInputSimplePublicObjectId = new BatchReadInputSimplePublicObjectId(); // BatchReadInputSimplePublicObjectId | 
            var archived = false;  // bool? | Whether to return only results that have been archived. (optional)  (default to false)

            try
            {
                // Read a batch of deals by internal ID, or unique property values
                BatchResponseSimplePublicObject result = apiInstance.PostCrmV3ObjectsDealsBatchReadRead(batchReadInputSimplePublicObjectId, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsDealsBatchReadRead: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsDealsBatchReadReadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read a batch of deals by internal ID, or unique property values
    ApiResponse<BatchResponseSimplePublicObject> response = apiInstance.PostCrmV3ObjectsDealsBatchReadReadWithHttpInfo(batchReadInputSimplePublicObjectId, archived);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsDealsBatchReadReadWithHttpInfo: " + e.Message);
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

[hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps_legacy](../README.md#private_apps_legacy), [private_apps](../README.md#private_apps)

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

<a id="postcrmv3objectsdealsbatchupdateupdate"></a>
# **PostCrmV3ObjectsDealsBatchUpdateUpdate**
> BatchResponseSimplePublicObject PostCrmV3ObjectsDealsBatchUpdateUpdate (BatchInputSimplePublicObjectBatchInput batchInputSimplePublicObjectBatchInput)

Update a batch of deals

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Deals.Api;
using HubSpot.Crm.Deals.Client;
using HubSpot.Crm.Deals.Model;

namespace Example
{
    public class PostCrmV3ObjectsDealsBatchUpdateUpdateExample
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

            var apiInstance = new BatchApi(config);
            var batchInputSimplePublicObjectBatchInput = new BatchInputSimplePublicObjectBatchInput(); // BatchInputSimplePublicObjectBatchInput | 

            try
            {
                // Update a batch of deals
                BatchResponseSimplePublicObject result = apiInstance.PostCrmV3ObjectsDealsBatchUpdateUpdate(batchInputSimplePublicObjectBatchInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsDealsBatchUpdateUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsDealsBatchUpdateUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a batch of deals
    ApiResponse<BatchResponseSimplePublicObject> response = apiInstance.PostCrmV3ObjectsDealsBatchUpdateUpdateWithHttpInfo(batchInputSimplePublicObjectBatchInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsDealsBatchUpdateUpdateWithHttpInfo: " + e.Message);
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

[hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps_legacy](../README.md#private_apps_legacy), [private_apps](../README.md#private_apps)

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

