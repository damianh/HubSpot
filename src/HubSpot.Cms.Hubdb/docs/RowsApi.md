# HubSpot.Cms.Hubdb.Api.RowsApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftPurgeDraftTableRow**](RowsApi.md#deletecmsv3hubdbtablestableidornamerowsrowiddraftpurgedrafttablerow) | **DELETE** /cms/v3/hubdb/tables/{tableIdOrName}/rows/{rowId}/draft | Permanently deletes a row |
| [**GetCmsV3HubdbTablesTableIdOrNameRowsDraftReadDraftTableRows**](RowsApi.md#getcmsv3hubdbtablestableidornamerowsdraftreaddrafttablerows) | **GET** /cms/v3/hubdb/tables/{tableIdOrName}/rows/draft | Get rows from draft table |
| [**GetCmsV3HubdbTablesTableIdOrNameRowsGetTableRows**](RowsApi.md#getcmsv3hubdbtablestableidornamerowsgettablerows) | **GET** /cms/v3/hubdb/tables/{tableIdOrName}/rows | Get rows for a table |
| [**GetCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftGetDraftTableRowById**](RowsApi.md#getcmsv3hubdbtablestableidornamerowsrowiddraftgetdrafttablerowbyid) | **GET** /cms/v3/hubdb/tables/{tableIdOrName}/rows/{rowId}/draft | Get a row from the draft table |
| [**GetCmsV3HubdbTablesTableIdOrNameRowsRowIdGetTableRow**](RowsApi.md#getcmsv3hubdbtablestableidornamerowsrowidgettablerow) | **GET** /cms/v3/hubdb/tables/{tableIdOrName}/rows/{rowId} | Get a table row |
| [**PatchCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftUpdateDraftTableRow**](RowsApi.md#patchcmsv3hubdbtablestableidornamerowsrowiddraftupdatedrafttablerow) | **PATCH** /cms/v3/hubdb/tables/{tableIdOrName}/rows/{rowId}/draft | Updates an existing row |
| [**PostCmsV3HubdbTablesTableIdOrNameRowsCreateTableRow**](RowsApi.md#postcmsv3hubdbtablestableidornamerowscreatetablerow) | **POST** /cms/v3/hubdb/tables/{tableIdOrName}/rows | Add a new row to a table |
| [**PostCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftCloneCloneDraftTableRow**](RowsApi.md#postcmsv3hubdbtablestableidornamerowsrowiddraftcloneclonedrafttablerow) | **POST** /cms/v3/hubdb/tables/{tableIdOrName}/rows/{rowId}/draft/clone | Clone a row |
| [**PutCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftReplaceDraftTableRow**](RowsApi.md#putcmsv3hubdbtablestableidornamerowsrowiddraftreplacedrafttablerow) | **PUT** /cms/v3/hubdb/tables/{tableIdOrName}/rows/{rowId}/draft | Replaces an existing row |

<a id="deletecmsv3hubdbtablestableidornamerowsrowiddraftpurgedrafttablerow"></a>
# **DeleteCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftPurgeDraftTableRow**
> void DeleteCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftPurgeDraftTableRow (string tableIdOrName, string rowId)

Permanently deletes a row

Permanently deletes a row from a table's `draft` version.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Hubdb.Api;
using HubSpot.Cms.Hubdb.Client;
using HubSpot.Cms.Hubdb.Model;

namespace Example
{
    public class DeleteCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftPurgeDraftTableRowExample
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

            var apiInstance = new RowsApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table
            var rowId = "rowId_example";  // string | The ID of the row

            try
            {
                // Permanently deletes a row
                apiInstance.DeleteCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftPurgeDraftTableRow(tableIdOrName, rowId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RowsApi.DeleteCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftPurgeDraftTableRow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftPurgeDraftTableRowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Permanently deletes a row
    apiInstance.DeleteCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftPurgeDraftTableRowWithHttpInfo(tableIdOrName, rowId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RowsApi.DeleteCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftPurgeDraftTableRowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tableIdOrName** | **string** | The ID or name of the table |  |
| **rowId** | **string** | The ID of the row |  |

### Return type

void (empty response body)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcmsv3hubdbtablestableidornamerowsdraftreaddrafttablerows"></a>
# **GetCmsV3HubdbTablesTableIdOrNameRowsDraftReadDraftTableRows**
> CollectionResponseWithTotalHubDbTableRowV3ForwardPaging GetCmsV3HubdbTablesTableIdOrNameRowsDraftReadDraftTableRows (string tableIdOrName, List<string> sort = null, string after = null, int? limit = null, List<string> properties = null)

Get rows from draft table

Returns rows in the `draft` version of the specified table. Row results can be filtered and sorted. Filtering and sorting options will be sent as query parameters to the API request. For example, by adding the query parameters `column1__gt=5&sort=-column1`, API returns the rows with values for column `column1` greater than 5 and in the descending order of `column1` values. Refer to the [overview section](https://developers.hubspot.com/docs/api/cms/hubdb#filtering-and-sorting-table-rows) for detailed filtering and sorting options.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Hubdb.Api;
using HubSpot.Cms.Hubdb.Client;
using HubSpot.Cms.Hubdb.Model;

namespace Example
{
    public class GetCmsV3HubdbTablesTableIdOrNameRowsDraftReadDraftTableRowsExample
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

            var apiInstance = new RowsApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table to query.
            var sort = new List<string>(); // List<string> | Specifies the column names to sort the results by. (optional) 
            var after = "after_example";  // string | The cursor token value to get the next set of results. You can get this from the `paging.next.after` JSON property of a paged response containing more results. (optional) 
            var limit = 56;  // int? | The maximum number of results to return. Default is `1000`. (optional) 
            var properties = new List<string>(); // List<string> | Specify the column names to get results containing only the required columns instead of all column details. If you want to include multiple columns in the result, use this query param as many times.  (optional) 

            try
            {
                // Get rows from draft table
                CollectionResponseWithTotalHubDbTableRowV3ForwardPaging result = apiInstance.GetCmsV3HubdbTablesTableIdOrNameRowsDraftReadDraftTableRows(tableIdOrName, sort, after, limit, properties);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RowsApi.GetCmsV3HubdbTablesTableIdOrNameRowsDraftReadDraftTableRows: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCmsV3HubdbTablesTableIdOrNameRowsDraftReadDraftTableRowsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get rows from draft table
    ApiResponse<CollectionResponseWithTotalHubDbTableRowV3ForwardPaging> response = apiInstance.GetCmsV3HubdbTablesTableIdOrNameRowsDraftReadDraftTableRowsWithHttpInfo(tableIdOrName, sort, after, limit, properties);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RowsApi.GetCmsV3HubdbTablesTableIdOrNameRowsDraftReadDraftTableRowsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tableIdOrName** | **string** | The ID or name of the table to query. |  |
| **sort** | [**List&lt;string&gt;**](string.md) | Specifies the column names to sort the results by. | [optional]  |
| **after** | **string** | The cursor token value to get the next set of results. You can get this from the &#x60;paging.next.after&#x60; JSON property of a paged response containing more results. | [optional]  |
| **limit** | **int?** | The maximum number of results to return. Default is &#x60;1000&#x60;. | [optional]  |
| **properties** | [**List&lt;string&gt;**](string.md) | Specify the column names to get results containing only the required columns instead of all column details. If you want to include multiple columns in the result, use this query param as many times.  | [optional]  |

### Return type

[**CollectionResponseWithTotalHubDbTableRowV3ForwardPaging**](CollectionResponseWithTotalHubDbTableRowV3ForwardPaging.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcmsv3hubdbtablestableidornamerowsgettablerows"></a>
# **GetCmsV3HubdbTablesTableIdOrNameRowsGetTableRows**
> CollectionResponseWithTotalHubDbTableRowV3ForwardPaging GetCmsV3HubdbTablesTableIdOrNameRowsGetTableRows (string tableIdOrName, List<string> sort = null, string after = null, int? limit = null, List<string> properties = null)

Get rows for a table

Returns a set of rows in the `published` version of the specified table. Row results can be filtered and sorted. Filtering and sorting options will be sent as query parameters to the API request. For example, by adding the query parameters `column1__gt=5&sort=-column1`, API returns the rows with values for column `column1` greater than 5 and in the descending order of `column1` values. Refer to the [overview section](https://developers.hubspot.com/docs/api/cms/hubdb#filtering-and-sorting-table-rows) for detailed filtering and sorting options. **Note:** This endpoint can be accessed without any authentication, if the table is set to be allowed for public access.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Hubdb.Api;
using HubSpot.Cms.Hubdb.Client;
using HubSpot.Cms.Hubdb.Model;

namespace Example
{
    public class GetCmsV3HubdbTablesTableIdOrNameRowsGetTableRowsExample
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

            var apiInstance = new RowsApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table to query.
            var sort = new List<string>(); // List<string> | Specifies the column names to sort the results by. See the above description for more details. (optional) 
            var after = "after_example";  // string | The cursor token value to get the next set of results. You can get this from the `paging.next.after` JSON property of a paged response containing more results. (optional) 
            var limit = 56;  // int? | The maximum number of results to return. Default is `1000`. (optional) 
            var properties = new List<string>(); // List<string> | Specify the column names to get results containing only the required columns instead of all column details. (optional) 

            try
            {
                // Get rows for a table
                CollectionResponseWithTotalHubDbTableRowV3ForwardPaging result = apiInstance.GetCmsV3HubdbTablesTableIdOrNameRowsGetTableRows(tableIdOrName, sort, after, limit, properties);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RowsApi.GetCmsV3HubdbTablesTableIdOrNameRowsGetTableRows: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCmsV3HubdbTablesTableIdOrNameRowsGetTableRowsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get rows for a table
    ApiResponse<CollectionResponseWithTotalHubDbTableRowV3ForwardPaging> response = apiInstance.GetCmsV3HubdbTablesTableIdOrNameRowsGetTableRowsWithHttpInfo(tableIdOrName, sort, after, limit, properties);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RowsApi.GetCmsV3HubdbTablesTableIdOrNameRowsGetTableRowsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tableIdOrName** | **string** | The ID or name of the table to query. |  |
| **sort** | [**List&lt;string&gt;**](string.md) | Specifies the column names to sort the results by. See the above description for more details. | [optional]  |
| **after** | **string** | The cursor token value to get the next set of results. You can get this from the &#x60;paging.next.after&#x60; JSON property of a paged response containing more results. | [optional]  |
| **limit** | **int?** | The maximum number of results to return. Default is &#x60;1000&#x60;. | [optional]  |
| **properties** | [**List&lt;string&gt;**](string.md) | Specify the column names to get results containing only the required columns instead of all column details. | [optional]  |

### Return type

[**CollectionResponseWithTotalHubDbTableRowV3ForwardPaging**](CollectionResponseWithTotalHubDbTableRowV3ForwardPaging.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcmsv3hubdbtablestableidornamerowsrowiddraftgetdrafttablerowbyid"></a>
# **GetCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftGetDraftTableRowById**
> HubDbTableRowV3 GetCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftGetDraftTableRowById (string tableIdOrName, string rowId)

Get a row from the draft table

Get a single row by ID from a table's `draft` version.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Hubdb.Api;
using HubSpot.Cms.Hubdb.Client;
using HubSpot.Cms.Hubdb.Model;

namespace Example
{
    public class GetCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftGetDraftTableRowByIdExample
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

            var apiInstance = new RowsApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table
            var rowId = "rowId_example";  // string | The ID of the row

            try
            {
                // Get a row from the draft table
                HubDbTableRowV3 result = apiInstance.GetCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftGetDraftTableRowById(tableIdOrName, rowId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RowsApi.GetCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftGetDraftTableRowById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftGetDraftTableRowByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a row from the draft table
    ApiResponse<HubDbTableRowV3> response = apiInstance.GetCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftGetDraftTableRowByIdWithHttpInfo(tableIdOrName, rowId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RowsApi.GetCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftGetDraftTableRowByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tableIdOrName** | **string** | The ID or name of the table |  |
| **rowId** | **string** | The ID of the row |  |

### Return type

[**HubDbTableRowV3**](HubDbTableRowV3.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcmsv3hubdbtablestableidornamerowsrowidgettablerow"></a>
# **GetCmsV3HubdbTablesTableIdOrNameRowsRowIdGetTableRow**
> HubDbTableRowV3 GetCmsV3HubdbTablesTableIdOrNameRowsRowIdGetTableRow (string tableIdOrName, string rowId)

Get a table row

Get a single row by ID from a table's `published` version. **Note:** This endpoint can be accessed without any authentication, if the table is set to be allowed for public access.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Hubdb.Api;
using HubSpot.Cms.Hubdb.Client;
using HubSpot.Cms.Hubdb.Model;

namespace Example
{
    public class GetCmsV3HubdbTablesTableIdOrNameRowsRowIdGetTableRowExample
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

            var apiInstance = new RowsApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table
            var rowId = "rowId_example";  // string | The ID of the row

            try
            {
                // Get a table row
                HubDbTableRowV3 result = apiInstance.GetCmsV3HubdbTablesTableIdOrNameRowsRowIdGetTableRow(tableIdOrName, rowId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RowsApi.GetCmsV3HubdbTablesTableIdOrNameRowsRowIdGetTableRow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCmsV3HubdbTablesTableIdOrNameRowsRowIdGetTableRowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a table row
    ApiResponse<HubDbTableRowV3> response = apiInstance.GetCmsV3HubdbTablesTableIdOrNameRowsRowIdGetTableRowWithHttpInfo(tableIdOrName, rowId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RowsApi.GetCmsV3HubdbTablesTableIdOrNameRowsRowIdGetTableRowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tableIdOrName** | **string** | The ID or name of the table |  |
| **rowId** | **string** | The ID of the row |  |

### Return type

[**HubDbTableRowV3**](HubDbTableRowV3.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="patchcmsv3hubdbtablestableidornamerowsrowiddraftupdatedrafttablerow"></a>
# **PatchCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftUpdateDraftTableRow**
> HubDbTableRowV3 PatchCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftUpdateDraftTableRow (string tableIdOrName, string rowId, HubDbTableRowV3Request hubDbTableRowV3Request)

Updates an existing row

Sparse updates a single row in the table's `draft` version. All the column values need not be specified. Only the columns or fields that needs to be modified can be specified. See the `Create a row` endpoint for instructions on how to format the JSON row definitions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Hubdb.Api;
using HubSpot.Cms.Hubdb.Client;
using HubSpot.Cms.Hubdb.Model;

namespace Example
{
    public class PatchCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftUpdateDraftTableRowExample
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

            var apiInstance = new RowsApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table
            var rowId = "rowId_example";  // string | The ID of the row
            var hubDbTableRowV3Request = new HubDbTableRowV3Request(); // HubDbTableRowV3Request | The JSON object of the row with necessary fields that needs to be updated.

            try
            {
                // Updates an existing row
                HubDbTableRowV3 result = apiInstance.PatchCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftUpdateDraftTableRow(tableIdOrName, rowId, hubDbTableRowV3Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RowsApi.PatchCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftUpdateDraftTableRow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftUpdateDraftTableRowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates an existing row
    ApiResponse<HubDbTableRowV3> response = apiInstance.PatchCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftUpdateDraftTableRowWithHttpInfo(tableIdOrName, rowId, hubDbTableRowV3Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RowsApi.PatchCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftUpdateDraftTableRowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tableIdOrName** | **string** | The ID or name of the table |  |
| **rowId** | **string** | The ID of the row |  |
| **hubDbTableRowV3Request** | [**HubDbTableRowV3Request**](HubDbTableRowV3Request.md) | The JSON object of the row with necessary fields that needs to be updated. |  |

### Return type

[**HubDbTableRowV3**](HubDbTableRowV3.md)

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

<a id="postcmsv3hubdbtablestableidornamerowscreatetablerow"></a>
# **PostCmsV3HubdbTablesTableIdOrNameRowsCreateTableRow**
> HubDbTableRowV3 PostCmsV3HubdbTablesTableIdOrNameRowsCreateTableRow (string tableIdOrName, HubDbTableRowV3Request hubDbTableRowV3Request)

Add a new row to a table

Add a new row to a HubDB table. New rows will be added to the `draft` version of the table. Use `publish` endpoint to push these changes to published version.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Hubdb.Api;
using HubSpot.Cms.Hubdb.Client;
using HubSpot.Cms.Hubdb.Model;

namespace Example
{
    public class PostCmsV3HubdbTablesTableIdOrNameRowsCreateTableRowExample
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

            var apiInstance = new RowsApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the target table.
            var hubDbTableRowV3Request = new HubDbTableRowV3Request(); // HubDbTableRowV3Request | The row definition JSON, formatted as described above.

            try
            {
                // Add a new row to a table
                HubDbTableRowV3 result = apiInstance.PostCmsV3HubdbTablesTableIdOrNameRowsCreateTableRow(tableIdOrName, hubDbTableRowV3Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RowsApi.PostCmsV3HubdbTablesTableIdOrNameRowsCreateTableRow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3HubdbTablesTableIdOrNameRowsCreateTableRowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a new row to a table
    ApiResponse<HubDbTableRowV3> response = apiInstance.PostCmsV3HubdbTablesTableIdOrNameRowsCreateTableRowWithHttpInfo(tableIdOrName, hubDbTableRowV3Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RowsApi.PostCmsV3HubdbTablesTableIdOrNameRowsCreateTableRowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tableIdOrName** | **string** | The ID or name of the target table. |  |
| **hubDbTableRowV3Request** | [**HubDbTableRowV3Request**](HubDbTableRowV3Request.md) | The row definition JSON, formatted as described above. |  |

### Return type

[**HubDbTableRowV3**](HubDbTableRowV3.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcmsv3hubdbtablestableidornamerowsrowiddraftcloneclonedrafttablerow"></a>
# **PostCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftCloneCloneDraftTableRow**
> HubDbTableRowV3 PostCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftCloneCloneDraftTableRow (string tableIdOrName, string rowId)

Clone a row

Clones a single row in the `draft` version of the table.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Hubdb.Api;
using HubSpot.Cms.Hubdb.Client;
using HubSpot.Cms.Hubdb.Model;

namespace Example
{
    public class PostCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftCloneCloneDraftTableRowExample
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

            var apiInstance = new RowsApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table
            var rowId = "rowId_example";  // string | The ID of the row

            try
            {
                // Clone a row
                HubDbTableRowV3 result = apiInstance.PostCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftCloneCloneDraftTableRow(tableIdOrName, rowId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RowsApi.PostCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftCloneCloneDraftTableRow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftCloneCloneDraftTableRowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Clone a row
    ApiResponse<HubDbTableRowV3> response = apiInstance.PostCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftCloneCloneDraftTableRowWithHttpInfo(tableIdOrName, rowId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RowsApi.PostCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftCloneCloneDraftTableRowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tableIdOrName** | **string** | The ID or name of the table |  |
| **rowId** | **string** | The ID of the row |  |

### Return type

[**HubDbTableRowV3**](HubDbTableRowV3.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putcmsv3hubdbtablestableidornamerowsrowiddraftreplacedrafttablerow"></a>
# **PutCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftReplaceDraftTableRow**
> HubDbTableRowV3 PutCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftReplaceDraftTableRow (string tableIdOrName, string rowId, HubDbTableRowV3Request hubDbTableRowV3Request)

Replaces an existing row

Replace a single row in the table's `draft` version. All the column values must be specified. If a column has a value in the target table and this request doesn't define that value, it will be deleted. See the `Create a row` endpoint for instructions on how to format the JSON row definitions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Cms.Hubdb.Api;
using HubSpot.Cms.Hubdb.Client;
using HubSpot.Cms.Hubdb.Model;

namespace Example
{
    public class PutCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftReplaceDraftTableRowExample
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

            var apiInstance = new RowsApi(config);
            var tableIdOrName = "tableIdOrName_example";  // string | The ID or name of the table
            var rowId = "rowId_example";  // string | The ID of the row
            var hubDbTableRowV3Request = new HubDbTableRowV3Request(); // HubDbTableRowV3Request | The JSON object of the row

            try
            {
                // Replaces an existing row
                HubDbTableRowV3 result = apiInstance.PutCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftReplaceDraftTableRow(tableIdOrName, rowId, hubDbTableRowV3Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RowsApi.PutCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftReplaceDraftTableRow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftReplaceDraftTableRowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Replaces an existing row
    ApiResponse<HubDbTableRowV3> response = apiInstance.PutCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftReplaceDraftTableRowWithHttpInfo(tableIdOrName, rowId, hubDbTableRowV3Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RowsApi.PutCmsV3HubdbTablesTableIdOrNameRowsRowIdDraftReplaceDraftTableRowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tableIdOrName** | **string** | The ID or name of the table |  |
| **rowId** | **string** | The ID of the row |  |
| **hubDbTableRowV3Request** | [**HubDbTableRowV3Request**](HubDbTableRowV3Request.md) | The JSON object of the row |  |

### Return type

[**HubDbTableRowV3**](HubDbTableRowV3.md)

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

