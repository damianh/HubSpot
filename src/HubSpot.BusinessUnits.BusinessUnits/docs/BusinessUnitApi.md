# HubSpot.BusinessUnits.BusinessUnits.Api.BusinessUnitApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetBusinessUnitsV3BusinessUnitsUserUserId**](BusinessUnitApi.md#getbusinessunitsv3businessunitsuseruserid) | **GET** /business-units/v3/business-units/user/{userId} | Get Business Units for a user |

<a id="getbusinessunitsv3businessunitsuseruserid"></a>
# **GetBusinessUnitsV3BusinessUnitsUserUserId**
> CollectionResponsePublicBusinessUnitNoPaging GetBusinessUnitsV3BusinessUnitsUserUserId (string userId, List<string> properties = null, List<string> name = null)

Get Business Units for a user

Get Business Units identified by `userId`. The `userId` refers to the user’s ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.BusinessUnits.BusinessUnits.Api;
using HubSpot.BusinessUnits.BusinessUnits.Client;
using HubSpot.BusinessUnits.BusinessUnits.Model;

namespace Example
{
    public class GetBusinessUnitsV3BusinessUnitsUserUserIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure OAuth2 access token for authorization: oauth2_legacy
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: private_apps_legacy
            config.AddApiKey("private-app-legacy", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app-legacy", "Bearer");

            var apiInstance = new BusinessUnitApi(config);
            var userId = "userId_example";  // string | Identifier of user to retrieve.
            var properties = new List<string>(); // List<string> | The names of properties to optionally include in the response body. The only valid value is `logoMetadata`. (optional) 
            var name = new List<string>(); // List<string> | The names of Business Units to retrieve. If empty or not provided, then all associated Business Units will be returned. (optional) 

            try
            {
                // Get Business Units for a user
                CollectionResponsePublicBusinessUnitNoPaging result = apiInstance.GetBusinessUnitsV3BusinessUnitsUserUserId(userId, properties, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BusinessUnitApi.GetBusinessUnitsV3BusinessUnitsUserUserId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBusinessUnitsV3BusinessUnitsUserUserIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Business Units for a user
    ApiResponse<CollectionResponsePublicBusinessUnitNoPaging> response = apiInstance.GetBusinessUnitsV3BusinessUnitsUserUserIdWithHttpInfo(userId, properties, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BusinessUnitApi.GetBusinessUnitsV3BusinessUnitsUserUserIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | Identifier of user to retrieve. |  |
| **properties** | [**List&lt;string&gt;**](string.md) | The names of properties to optionally include in the response body. The only valid value is &#x60;logoMetadata&#x60;. | [optional]  |
| **name** | [**List&lt;string&gt;**](string.md) | The names of Business Units to retrieve. If empty or not provided, then all associated Business Units will be returned. | [optional]  |

### Return type

[**CollectionResponsePublicBusinessUnitNoPaging**](CollectionResponsePublicBusinessUnitNoPaging.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

