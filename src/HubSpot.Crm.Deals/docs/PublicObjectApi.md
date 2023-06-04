# HubSpot.Crm.Deals.Api.PublicObjectApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostCrmV3ObjectsDealsMergeMerge**](PublicObjectApi.md#postcrmv3objectsdealsmergemerge) | **POST** /crm/v3/objects/deals/merge | Merge two deals with same type |

<a id="postcrmv3objectsdealsmergemerge"></a>
# **PostCrmV3ObjectsDealsMergeMerge**
> SimplePublicObject PostCrmV3ObjectsDealsMergeMerge (PublicMergeInput publicMergeInput)

Merge two deals with same type

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Deals.Api;
using HubSpot.Crm.Deals.Client;
using HubSpot.Crm.Deals.Model;

namespace Example
{
    public class PostCrmV3ObjectsDealsMergeMergeExample
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

            var apiInstance = new PublicObjectApi(config);
            var publicMergeInput = new PublicMergeInput(); // PublicMergeInput | 

            try
            {
                // Merge two deals with same type
                SimplePublicObject result = apiInstance.PostCrmV3ObjectsDealsMergeMerge(publicMergeInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicObjectApi.PostCrmV3ObjectsDealsMergeMerge: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsDealsMergeMergeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Merge two deals with same type
    ApiResponse<SimplePublicObject> response = apiInstance.PostCrmV3ObjectsDealsMergeMergeWithHttpInfo(publicMergeInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicObjectApi.PostCrmV3ObjectsDealsMergeMergeWithHttpInfo: " + e.Message);
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

[hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps_legacy](../README.md#private_apps_legacy), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

