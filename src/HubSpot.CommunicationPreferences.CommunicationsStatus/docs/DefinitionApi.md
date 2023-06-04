# HubSpot.CommunicationPreferences.CommunicationsStatus.Api.DefinitionApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCommunicationPreferencesV3DefinitionsGetPage**](DefinitionApi.md#getcommunicationpreferencesv3definitionsgetpage) | **GET** /communication-preferences/v3/definitions | Get subscription definitions |

<a id="getcommunicationpreferencesv3definitionsgetpage"></a>
# **GetCommunicationPreferencesV3DefinitionsGetPage**
> SubscriptionDefinitionsResponse GetCommunicationPreferencesV3DefinitionsGetPage ()

Get subscription definitions

Get a list of all subscription definitions for the portal

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.CommunicationPreferences.CommunicationsStatus.Api;
using HubSpot.CommunicationPreferences.CommunicationsStatus.Client;
using HubSpot.CommunicationPreferences.CommunicationsStatus.Model;

namespace Example
{
    public class GetCommunicationPreferencesV3DefinitionsGetPageExample
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

            var apiInstance = new DefinitionApi(config);

            try
            {
                // Get subscription definitions
                SubscriptionDefinitionsResponse result = apiInstance.GetCommunicationPreferencesV3DefinitionsGetPage();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefinitionApi.GetCommunicationPreferencesV3DefinitionsGetPage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCommunicationPreferencesV3DefinitionsGetPageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get subscription definitions
    ApiResponse<SubscriptionDefinitionsResponse> response = apiInstance.GetCommunicationPreferencesV3DefinitionsGetPageWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefinitionApi.GetCommunicationPreferencesV3DefinitionsGetPageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SubscriptionDefinitionsResponse**](SubscriptionDefinitionsResponse.md)

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

