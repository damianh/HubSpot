# HubSpot.Crm.LineItems.Api.PublicObjectApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostCrmV3ObjectsLineItemsMergeMerge**](PublicObjectApi.md#postcrmv3objectslineitemsmergemerge) | **POST** /crm/v3/objects/line_items/merge | Merge two line items with same type |

<a id="postcrmv3objectslineitemsmergemerge"></a>
# **PostCrmV3ObjectsLineItemsMergeMerge**
> SimplePublicObject PostCrmV3ObjectsLineItemsMergeMerge (PublicMergeInput publicMergeInput)

Merge two line items with same type

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.LineItems.Api;
using HubSpot.Crm.LineItems.Client;
using HubSpot.Crm.LineItems.Model;

namespace Example
{
    public class PostCrmV3ObjectsLineItemsMergeMergeExample
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

            var apiInstance = new PublicObjectApi(config);
            var publicMergeInput = new PublicMergeInput(); // PublicMergeInput | 

            try
            {
                // Merge two line items with same type
                SimplePublicObject result = apiInstance.PostCrmV3ObjectsLineItemsMergeMerge(publicMergeInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicObjectApi.PostCrmV3ObjectsLineItemsMergeMerge: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsLineItemsMergeMergeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Merge two line items with same type
    ApiResponse<SimplePublicObject> response = apiInstance.PostCrmV3ObjectsLineItemsMergeMergeWithHttpInfo(publicMergeInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicObjectApi.PostCrmV3ObjectsLineItemsMergeMergeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publicMergeInput** | [**PublicMergeInput**](PublicMergeInput.md) |  |  |

### Return type

[**SimplePublicObject**](SimplePublicObject.md)

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

