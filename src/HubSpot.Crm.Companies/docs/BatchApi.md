# HubSpot.Crm.Companies.Api.BatchApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostCrmV3ObjectsCompaniesBatchArchiveArchive**](BatchApi.md#postcrmv3objectscompaniesbatcharchivearchive) | **POST** /crm/v3/objects/companies/batch/archive | Archive a batch of companies by ID |
| [**PostCrmV3ObjectsCompaniesBatchCreateCreate**](BatchApi.md#postcrmv3objectscompaniesbatchcreatecreate) | **POST** /crm/v3/objects/companies/batch/create | Create a batch of companies |
| [**PostCrmV3ObjectsCompaniesBatchReadRead**](BatchApi.md#postcrmv3objectscompaniesbatchreadread) | **POST** /crm/v3/objects/companies/batch/read | Read a batch of companies by internal ID, or unique property values |
| [**PostCrmV3ObjectsCompaniesBatchUpdateUpdate**](BatchApi.md#postcrmv3objectscompaniesbatchupdateupdate) | **POST** /crm/v3/objects/companies/batch/update | Update a batch of companies |

<a id="postcrmv3objectscompaniesbatcharchivearchive"></a>
# **PostCrmV3ObjectsCompaniesBatchArchiveArchive**
> void PostCrmV3ObjectsCompaniesBatchArchiveArchive (BatchInputSimplePublicObjectId batchInputSimplePublicObjectId)

Archive a batch of companies by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Companies.Api;
using HubSpot.Crm.Companies.Client;
using HubSpot.Crm.Companies.Model;

namespace Example
{
    public class PostCrmV3ObjectsCompaniesBatchArchiveArchiveExample
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

            var apiInstance = new BatchApi(config);
            var batchInputSimplePublicObjectId = new BatchInputSimplePublicObjectId(); // BatchInputSimplePublicObjectId | 

            try
            {
                // Archive a batch of companies by ID
                apiInstance.PostCrmV3ObjectsCompaniesBatchArchiveArchive(batchInputSimplePublicObjectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsCompaniesBatchArchiveArchive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsCompaniesBatchArchiveArchiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Archive a batch of companies by ID
    apiInstance.PostCrmV3ObjectsCompaniesBatchArchiveArchiveWithHttpInfo(batchInputSimplePublicObjectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsCompaniesBatchArchiveArchiveWithHttpInfo: " + e.Message);
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

[hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy), [oauth2](../README.md#oauth2), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcrmv3objectscompaniesbatchcreatecreate"></a>
# **PostCrmV3ObjectsCompaniesBatchCreateCreate**
> BatchResponseSimplePublicObject PostCrmV3ObjectsCompaniesBatchCreateCreate (BatchInputSimplePublicObjectInputForCreate batchInputSimplePublicObjectInputForCreate)

Create a batch of companies

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Companies.Api;
using HubSpot.Crm.Companies.Client;
using HubSpot.Crm.Companies.Model;

namespace Example
{
    public class PostCrmV3ObjectsCompaniesBatchCreateCreateExample
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

            var apiInstance = new BatchApi(config);
            var batchInputSimplePublicObjectInputForCreate = new BatchInputSimplePublicObjectInputForCreate(); // BatchInputSimplePublicObjectInputForCreate | 

            try
            {
                // Create a batch of companies
                BatchResponseSimplePublicObject result = apiInstance.PostCrmV3ObjectsCompaniesBatchCreateCreate(batchInputSimplePublicObjectInputForCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsCompaniesBatchCreateCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsCompaniesBatchCreateCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a batch of companies
    ApiResponse<BatchResponseSimplePublicObject> response = apiInstance.PostCrmV3ObjectsCompaniesBatchCreateCreateWithHttpInfo(batchInputSimplePublicObjectInputForCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsCompaniesBatchCreateCreateWithHttpInfo: " + e.Message);
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

[hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy), [oauth2](../README.md#oauth2), [private_apps](../README.md#private_apps)

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

<a id="postcrmv3objectscompaniesbatchreadread"></a>
# **PostCrmV3ObjectsCompaniesBatchReadRead**
> BatchResponseSimplePublicObject PostCrmV3ObjectsCompaniesBatchReadRead (BatchReadInputSimplePublicObjectId batchReadInputSimplePublicObjectId, bool? archived = null)

Read a batch of companies by internal ID, or unique property values

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Companies.Api;
using HubSpot.Crm.Companies.Client;
using HubSpot.Crm.Companies.Model;

namespace Example
{
    public class PostCrmV3ObjectsCompaniesBatchReadReadExample
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
                // Read a batch of companies by internal ID, or unique property values
                BatchResponseSimplePublicObject result = apiInstance.PostCrmV3ObjectsCompaniesBatchReadRead(batchReadInputSimplePublicObjectId, archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsCompaniesBatchReadRead: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsCompaniesBatchReadReadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read a batch of companies by internal ID, or unique property values
    ApiResponse<BatchResponseSimplePublicObject> response = apiInstance.PostCrmV3ObjectsCompaniesBatchReadReadWithHttpInfo(batchReadInputSimplePublicObjectId, archived);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsCompaniesBatchReadReadWithHttpInfo: " + e.Message);
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

<a id="postcrmv3objectscompaniesbatchupdateupdate"></a>
# **PostCrmV3ObjectsCompaniesBatchUpdateUpdate**
> BatchResponseSimplePublicObject PostCrmV3ObjectsCompaniesBatchUpdateUpdate (BatchInputSimplePublicObjectBatchInput batchInputSimplePublicObjectBatchInput)

Update a batch of companies

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Companies.Api;
using HubSpot.Crm.Companies.Client;
using HubSpot.Crm.Companies.Model;

namespace Example
{
    public class PostCrmV3ObjectsCompaniesBatchUpdateUpdateExample
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

            var apiInstance = new BatchApi(config);
            var batchInputSimplePublicObjectBatchInput = new BatchInputSimplePublicObjectBatchInput(); // BatchInputSimplePublicObjectBatchInput | 

            try
            {
                // Update a batch of companies
                BatchResponseSimplePublicObject result = apiInstance.PostCrmV3ObjectsCompaniesBatchUpdateUpdate(batchInputSimplePublicObjectBatchInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsCompaniesBatchUpdateUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsCompaniesBatchUpdateUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a batch of companies
    ApiResponse<BatchResponseSimplePublicObject> response = apiInstance.PostCrmV3ObjectsCompaniesBatchUpdateUpdateWithHttpInfo(batchInputSimplePublicObjectBatchInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.PostCrmV3ObjectsCompaniesBatchUpdateUpdateWithHttpInfo: " + e.Message);
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

[hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy), [oauth2](../README.md#oauth2), [private_apps](../README.md#private_apps)

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

