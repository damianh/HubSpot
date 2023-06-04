# HubSpot.Cms.Hubdb.Api.RowsBatchApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostCmsV3HubdbTablesTableIdOrNameRowsBatchReadReadTableRows**](RowsBatchApi.md#postcmsv3hubdbtablestableidornamerowsbatchreadreadtablerows) | **POST** /cms/v3/hubdb/tables/{tableIdOrName}/rows/batch/read | Get a set of rows |
| [**PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCloneCloneDraftTableRows**](RowsBatchApi.md#postcmsv3hubdbtablestableidornamerowsdraftbatchcloneclonedrafttablerows) | **POST** /cms/v3/hubdb/tables/{tableIdOrName}/rows/draft/batch/clone | Clone rows in batch |
| [**PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCreateCreateDraftTableRows**](RowsBatchApi.md#postcmsv3hubdbtablestableidornamerowsdraftbatchcreatecreatedrafttablerows) | **POST** /cms/v3/hubdb/tables/{tableIdOrName}/rows/draft/batch/create | Create rows in batch |
| [**PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchPurgePurgeDraftTableRows**](RowsBatchApi.md#postcmsv3hubdbtablestableidornamerowsdraftbatchpurgepurgedrafttablerows) | **POST** /cms/v3/hubdb/tables/{tableIdOrName}/rows/draft/batch/purge | Permanently deletes rows |
| [**PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReadReadDraftTableRows**](RowsBatchApi.md#postcmsv3hubdbtablestableidornamerowsdraftbatchreadreaddrafttablerows) | **POST** /cms/v3/hubdb/tables/{tableIdOrName}/rows/draft/batch/read | Get a set of rows from draft table |
| [**PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReplaceReplaceDraftTableRows**](RowsBatchApi.md#postcmsv3hubdbtablestableidornamerowsdraftbatchreplacereplacedrafttablerows) | **POST** /cms/v3/hubdb/tables/{tableIdOrName}/rows/draft/batch/replace | Replace rows in batch in draft table |
| [**PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchUpdateUpdateDraftTableRows**](RowsBatchApi.md#postcmsv3hubdbtablestableidornamerowsdraftbatchupdateupdatedrafttablerows) | **POST** /cms/v3/hubdb/tables/{tableIdOrName}/rows/draft/batch/update | Update rows in batch in draft table |

<a id="postcmsv3hubdbtablestableidornamerowsbatchreadreadtablerows"></a>
# **PostCmsV3HubdbTablesTableIdOrNameRowsBatchReadReadTableRows**
> BatchResponseHubDbTableRowV3 PostCmsV3HubdbTablesTableIdOrNameRowsBatchReadReadTableRows (string tableIdOrName, BatchInputString batchInputString)

Get a set of rows

Returns rows in the `published` version of the specified table, given a set of row ids. **Note:** This endpoint can be accessed without any authentication if the table is set to be allowed for public access.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Hubdb.Api;
using HubSpot.Cms.Hubdb.Client;
using HubSpot.Cms.Hubdb.Model;

namespace Example
{
    public class PostCmsV3HubdbTablesTableIdOrNameRowsBatchReadReadTableRowsExample
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

            var apiInstance = new RowsBatchApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table to query.
            var batchInputString = new BatchInputString(); // BatchInputString | The JSON array of row ids

            try
            {
                // Get a set of rows
                BatchResponseHubDbTableRowV3 result = apiInstance.PostCmsV3HubdbTablesTableIdOrNameRowsBatchReadReadTableRows(tableIdOrName, batchInputString);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RowsBatchApi.PostCmsV3HubdbTablesTableIdOrNameRowsBatchReadReadTableRows: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3HubdbTablesTableIdOrNameRowsBatchReadReadTableRowsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a set of rows
    ApiResponse<BatchResponseHubDbTableRowV3> response = apiInstance.PostCmsV3HubdbTablesTableIdOrNameRowsBatchReadReadTableRowsWithHttpInfo(tableIdOrName, batchInputString);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RowsBatchApi.PostCmsV3HubdbTablesTableIdOrNameRowsBatchReadReadTableRowsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tableIdOrName** | **string** | The ID or name of the table to query. |  |
| **batchInputString** | [**BatchInputString**](BatchInputString.md) | The JSON array of row ids |  |

### Return type

[**BatchResponseHubDbTableRowV3**](BatchResponseHubDbTableRowV3.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

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

<a id="postcmsv3hubdbtablestableidornamerowsdraftbatchcloneclonedrafttablerows"></a>
# **PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCloneCloneDraftTableRows**
> BatchResponseHubDbTableRowV3 PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCloneCloneDraftTableRows (string tableIdOrName, BatchInputString batchInputString)

Clone rows in batch

Clones rows in the `draft` version of the specified table, given a set of row ids.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Hubdb.Api;
using HubSpot.Cms.Hubdb.Client;
using HubSpot.Cms.Hubdb.Model;

namespace Example
{
    public class PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCloneCloneDraftTableRowsExample
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

            var apiInstance = new RowsBatchApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table
            var batchInputString = new BatchInputString(); // BatchInputString | The JSON array of row ids

            try
            {
                // Clone rows in batch
                BatchResponseHubDbTableRowV3 result = apiInstance.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCloneCloneDraftTableRows(tableIdOrName, batchInputString);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RowsBatchApi.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCloneCloneDraftTableRows: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCloneCloneDraftTableRowsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Clone rows in batch
    ApiResponse<BatchResponseHubDbTableRowV3> response = apiInstance.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCloneCloneDraftTableRowsWithHttpInfo(tableIdOrName, batchInputString);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RowsBatchApi.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCloneCloneDraftTableRowsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tableIdOrName** | **string** | The ID or name of the table |  |
| **batchInputString** | [**BatchInputString**](BatchInputString.md) | The JSON array of row ids |  |

### Return type

[**BatchResponseHubDbTableRowV3**](BatchResponseHubDbTableRowV3.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcmsv3hubdbtablestableidornamerowsdraftbatchcreatecreatedrafttablerows"></a>
# **PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCreateCreateDraftTableRows**
> BatchResponseHubDbTableRowV3 PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCreateCreateDraftTableRows (string tableIdOrName, BatchInputHubDbTableRowV3Request batchInputHubDbTableRowV3Request)

Create rows in batch

Creates rows in the `draft` version of the specified table, given an array of row objects. See the overview section for more details with an example.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Hubdb.Api;
using HubSpot.Cms.Hubdb.Client;
using HubSpot.Cms.Hubdb.Model;

namespace Example
{
    public class PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCreateCreateDraftTableRowsExample
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

            var apiInstance = new RowsBatchApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table
            var batchInputHubDbTableRowV3Request = new BatchInputHubDbTableRowV3Request(); // BatchInputHubDbTableRowV3Request | JSON array of row objects

            try
            {
                // Create rows in batch
                BatchResponseHubDbTableRowV3 result = apiInstance.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCreateCreateDraftTableRows(tableIdOrName, batchInputHubDbTableRowV3Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RowsBatchApi.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCreateCreateDraftTableRows: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCreateCreateDraftTableRowsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create rows in batch
    ApiResponse<BatchResponseHubDbTableRowV3> response = apiInstance.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCreateCreateDraftTableRowsWithHttpInfo(tableIdOrName, batchInputHubDbTableRowV3Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RowsBatchApi.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchCreateCreateDraftTableRowsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tableIdOrName** | **string** | The ID or name of the table |  |
| **batchInputHubDbTableRowV3Request** | [**BatchInputHubDbTableRowV3Request**](BatchInputHubDbTableRowV3Request.md) | JSON array of row objects |  |

### Return type

[**BatchResponseHubDbTableRowV3**](BatchResponseHubDbTableRowV3.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

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

<a id="postcmsv3hubdbtablestableidornamerowsdraftbatchpurgepurgedrafttablerows"></a>
# **PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchPurgePurgeDraftTableRows**
> void PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchPurgePurgeDraftTableRows (string tableIdOrName, BatchInputString batchInputString)

Permanently deletes rows

Permanently deletes rows from the `draft` version of the table, given a set of row ids.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Hubdb.Api;
using HubSpot.Cms.Hubdb.Client;
using HubSpot.Cms.Hubdb.Model;

namespace Example
{
    public class PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchPurgePurgeDraftTableRowsExample
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

            var apiInstance = new RowsBatchApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table
            var batchInputString = new BatchInputString(); // BatchInputString | JSON array of row ids.

            try
            {
                // Permanently deletes rows
                apiInstance.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchPurgePurgeDraftTableRows(tableIdOrName, batchInputString);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RowsBatchApi.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchPurgePurgeDraftTableRows: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchPurgePurgeDraftTableRowsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Permanently deletes rows
    apiInstance.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchPurgePurgeDraftTableRowsWithHttpInfo(tableIdOrName, batchInputString);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RowsBatchApi.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchPurgePurgeDraftTableRowsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tableIdOrName** | **string** | The ID or name of the table |  |
| **batchInputString** | [**BatchInputString**](BatchInputString.md) | JSON array of row ids. |  |

### Return type

void (empty response body)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcmsv3hubdbtablestableidornamerowsdraftbatchreadreaddrafttablerows"></a>
# **PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReadReadDraftTableRows**
> BatchResponseHubDbTableRowV3 PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReadReadDraftTableRows (string tableIdOrName, BatchInputString batchInputString)

Get a set of rows from draft table

Returns rows in the `draft` version of the specified table, given a set of row ids.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Hubdb.Api;
using HubSpot.Cms.Hubdb.Client;
using HubSpot.Cms.Hubdb.Model;

namespace Example
{
    public class PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReadReadDraftTableRowsExample
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

            var apiInstance = new RowsBatchApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table
            var batchInputString = new BatchInputString(); // BatchInputString | JSON array of row ids.

            try
            {
                // Get a set of rows from draft table
                BatchResponseHubDbTableRowV3 result = apiInstance.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReadReadDraftTableRows(tableIdOrName, batchInputString);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RowsBatchApi.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReadReadDraftTableRows: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReadReadDraftTableRowsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a set of rows from draft table
    ApiResponse<BatchResponseHubDbTableRowV3> response = apiInstance.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReadReadDraftTableRowsWithHttpInfo(tableIdOrName, batchInputString);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RowsBatchApi.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReadReadDraftTableRowsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tableIdOrName** | **string** | The ID or name of the table |  |
| **batchInputString** | [**BatchInputString**](BatchInputString.md) | JSON array of row ids. |  |

### Return type

[**BatchResponseHubDbTableRowV3**](BatchResponseHubDbTableRowV3.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

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

<a id="postcmsv3hubdbtablestableidornamerowsdraftbatchreplacereplacedrafttablerows"></a>
# **PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReplaceReplaceDraftTableRows**
> BatchResponseHubDbTableRowV3 PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReplaceReplaceDraftTableRows (string tableIdOrName, BatchInputHubDbTableRowV3BatchUpdateRequest batchInputHubDbTableRowV3BatchUpdateRequest)

Replace rows in batch in draft table

Replaces multiple rows as a batch in the `draft` version of the table. See the endpoint `PUT /tables/{tableIdOrName}/rows/{rowId}/draft` for details on updating a single row.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Hubdb.Api;
using HubSpot.Cms.Hubdb.Client;
using HubSpot.Cms.Hubdb.Model;

namespace Example
{
    public class PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReplaceReplaceDraftTableRowsExample
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

            var apiInstance = new RowsBatchApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table
            var batchInputHubDbTableRowV3BatchUpdateRequest = new BatchInputHubDbTableRowV3BatchUpdateRequest(); // BatchInputHubDbTableRowV3BatchUpdateRequest | JSON array of row objects.

            try
            {
                // Replace rows in batch in draft table
                BatchResponseHubDbTableRowV3 result = apiInstance.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReplaceReplaceDraftTableRows(tableIdOrName, batchInputHubDbTableRowV3BatchUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RowsBatchApi.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReplaceReplaceDraftTableRows: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReplaceReplaceDraftTableRowsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Replace rows in batch in draft table
    ApiResponse<BatchResponseHubDbTableRowV3> response = apiInstance.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReplaceReplaceDraftTableRowsWithHttpInfo(tableIdOrName, batchInputHubDbTableRowV3BatchUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RowsBatchApi.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchReplaceReplaceDraftTableRowsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tableIdOrName** | **string** | The ID or name of the table |  |
| **batchInputHubDbTableRowV3BatchUpdateRequest** | [**BatchInputHubDbTableRowV3BatchUpdateRequest**](BatchInputHubDbTableRowV3BatchUpdateRequest.md) | JSON array of row objects. |  |

### Return type

[**BatchResponseHubDbTableRowV3**](BatchResponseHubDbTableRowV3.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

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

<a id="postcmsv3hubdbtablestableidornamerowsdraftbatchupdateupdatedrafttablerows"></a>
# **PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchUpdateUpdateDraftTableRows**
> BatchResponseHubDbTableRowV3 PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchUpdateUpdateDraftTableRows (string tableIdOrName, BatchInputHubDbTableRowV3BatchUpdateRequest batchInputHubDbTableRowV3BatchUpdateRequest)

Update rows in batch in draft table

Updates multiple rows as a batch in the `draft` version of the table. See the endpoint `PATCH /tables/{tableIdOrName}/rows/{rowId}/draft` for details on updating a single row.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Hubdb.Api;
using HubSpot.Cms.Hubdb.Client;
using HubSpot.Cms.Hubdb.Model;

namespace Example
{
    public class PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchUpdateUpdateDraftTableRowsExample
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

            var apiInstance = new RowsBatchApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table
            var batchInputHubDbTableRowV3BatchUpdateRequest = new BatchInputHubDbTableRowV3BatchUpdateRequest(); // BatchInputHubDbTableRowV3BatchUpdateRequest | JSON array of row objects.

            try
            {
                // Update rows in batch in draft table
                BatchResponseHubDbTableRowV3 result = apiInstance.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchUpdateUpdateDraftTableRows(tableIdOrName, batchInputHubDbTableRowV3BatchUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RowsBatchApi.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchUpdateUpdateDraftTableRows: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchUpdateUpdateDraftTableRowsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update rows in batch in draft table
    ApiResponse<BatchResponseHubDbTableRowV3> response = apiInstance.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchUpdateUpdateDraftTableRowsWithHttpInfo(tableIdOrName, batchInputHubDbTableRowV3BatchUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RowsBatchApi.PostCmsV3HubdbTablesTableIdOrNameRowsDraftBatchUpdateUpdateDraftTableRowsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tableIdOrName** | **string** | The ID or name of the table |  |
| **batchInputHubDbTableRowV3BatchUpdateRequest** | [**BatchInputHubDbTableRowV3BatchUpdateRequest**](BatchInputHubDbTableRowV3BatchUpdateRequest.md) | JSON array of row objects. |  |

### Return type

[**BatchResponseHubDbTableRowV3**](BatchResponseHubDbTableRowV3.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

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

