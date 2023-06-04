# HubSpot.Crm.Objects.Api.GDPRApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostCrmV3ObjectsObjectTypeGdprDeletePurge**](GDPRApi.md#postcrmv3objectsobjecttypegdprdeletepurge) | **POST** /crm/v3/objects/{objectType}/gdpr-delete | GDPR DELETE |

<a id="postcrmv3objectsobjecttypegdprdeletepurge"></a>
# **PostCrmV3ObjectsObjectTypeGdprDeletePurge**
> void PostCrmV3ObjectsObjectTypeGdprDeletePurge (string objectType, PublicGdprDeleteInput publicGdprDeleteInput)

GDPR DELETE

Permanently delete a contact and all associated content to follow GDPR. Use optional property 'idProperty' set to 'email' to identify contact by email address. If email address is not found, the email address will be added to a blocklist and prevent it from being used in the future.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Objects.Api;
using HubSpot.Crm.Objects.Client;
using HubSpot.Crm.Objects.Model;

namespace Example
{
    public class PostCrmV3ObjectsObjectTypeGdprDeletePurgeExample
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

            var apiInstance = new GDPRApi(config);
            var objectType = "objectType_example";  // string | 
            var publicGdprDeleteInput = new PublicGdprDeleteInput(); // PublicGdprDeleteInput | 

            try
            {
                // GDPR DELETE
                apiInstance.PostCrmV3ObjectsObjectTypeGdprDeletePurge(objectType, publicGdprDeleteInput);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GDPRApi.PostCrmV3ObjectsObjectTypeGdprDeletePurge: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsObjectTypeGdprDeletePurgeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GDPR DELETE
    apiInstance.PostCrmV3ObjectsObjectTypeGdprDeletePurgeWithHttpInfo(objectType, publicGdprDeleteInput);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GDPRApi.PostCrmV3ObjectsObjectTypeGdprDeletePurgeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectType** | **string** |  |  |
| **publicGdprDeleteInput** | [**PublicGdprDeleteInput**](PublicGdprDeleteInput.md) |  |  |

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

