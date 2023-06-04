# HubSpot.Crm.Contacts.Api.GDPRApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostCrmV3ObjectsContactsGdprDeletePurge**](GDPRApi.md#postcrmv3objectscontactsgdprdeletepurge) | **POST** /crm/v3/objects/contacts/gdpr-delete | GDPR DELETE |

<a id="postcrmv3objectscontactsgdprdeletepurge"></a>
# **PostCrmV3ObjectsContactsGdprDeletePurge**
> void PostCrmV3ObjectsContactsGdprDeletePurge (PublicGdprDeleteInput publicGdprDeleteInput)

GDPR DELETE

Permanently delete a contact and all associated content to follow GDPR. Use optional property 'idProperty' set to 'email' to identify contact by email address. If email address is not found, the email address will be added to a blocklist and prevent it from being used in the future.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Contacts.Api;
using HubSpot.Crm.Contacts.Client;
using HubSpot.Crm.Contacts.Model;

namespace Example
{
    public class PostCrmV3ObjectsContactsGdprDeletePurgeExample
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

            var apiInstance = new GDPRApi(config);
            var publicGdprDeleteInput = new PublicGdprDeleteInput(); // PublicGdprDeleteInput | 

            try
            {
                // GDPR DELETE
                apiInstance.PostCrmV3ObjectsContactsGdprDeletePurge(publicGdprDeleteInput);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GDPRApi.PostCrmV3ObjectsContactsGdprDeletePurge: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsContactsGdprDeletePurgeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GDPR DELETE
    apiInstance.PostCrmV3ObjectsContactsGdprDeletePurgeWithHttpInfo(publicGdprDeleteInput);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GDPRApi.PostCrmV3ObjectsContactsGdprDeletePurgeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publicGdprDeleteInput** | [**PublicGdprDeleteInput**](PublicGdprDeleteInput.md) |  |  |

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

