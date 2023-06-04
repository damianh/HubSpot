# HubSpot.Crm.Associations.Api.TypesApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAll**](TypesApi.md#getcrmv3associationsfromobjecttypetoobjecttypetypesgetall) | **GET** /crm/v3/associations/{fromObjectType}/{toObjectType}/types | List association types |

<a id="getcrmv3associationsfromobjecttypetoobjecttypetypesgetall"></a>
# **GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAll**
> CollectionResponsePublicAssociationDefinitionNoPaging GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAll (string fromObjectType, string toObjectType)

List association types

List all the valid association types available between two object types

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Associations.Api;
using HubSpot.Crm.Associations.Client;
using HubSpot.Crm.Associations.Model;

namespace Example
{
    public class GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAllExample
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

            var apiInstance = new TypesApi(config);
            var fromObjectType = "fromObjectType_example";  // string | 
            var toObjectType = "toObjectType_example";  // string | 

            try
            {
                // List association types
                CollectionResponsePublicAssociationDefinitionNoPaging result = apiInstance.GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAll(fromObjectType, toObjectType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TypesApi.GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List association types
    ApiResponse<CollectionResponsePublicAssociationDefinitionNoPaging> response = apiInstance.GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAllWithHttpInfo(fromObjectType, toObjectType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TypesApi.GetCrmV3AssociationsFromObjectTypeToObjectTypeTypesGetAllWithHttpInfo: " + e.Message);
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

[**CollectionResponsePublicAssociationDefinitionNoPaging**](CollectionResponsePublicAssociationDefinitionNoPaging.md)

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

