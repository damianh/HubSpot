# HubSpot.CommunicationPreferences.CommunicationsStatus.Api.StatusApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCommunicationPreferencesV3StatusEmailEmailAddressGetEmailStatus**](StatusApi.md#getcommunicationpreferencesv3statusemailemailaddressgetemailstatus) | **GET** /communication-preferences/v3/status/email/{emailAddress} | Get subscription statuses for a contact |
| [**PostCommunicationPreferencesV3SubscribeSubscribe**](StatusApi.md#postcommunicationpreferencesv3subscribesubscribe) | **POST** /communication-preferences/v3/subscribe | Subscribe a contact |
| [**PostCommunicationPreferencesV3UnsubscribeUnsubscribe**](StatusApi.md#postcommunicationpreferencesv3unsubscribeunsubscribe) | **POST** /communication-preferences/v3/unsubscribe | Unsubscribe a contact |

<a id="getcommunicationpreferencesv3statusemailemailaddressgetemailstatus"></a>
# **GetCommunicationPreferencesV3StatusEmailEmailAddressGetEmailStatus**
> PublicSubscriptionStatusesResponse GetCommunicationPreferencesV3StatusEmailEmailAddressGetEmailStatus (string emailAddress)

Get subscription statuses for a contact

Returns a list of subscriptions and their status for a given contact.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.CommunicationPreferences.CommunicationsStatus.Api;
using HubSpot.CommunicationPreferences.CommunicationsStatus.Client;
using HubSpot.CommunicationPreferences.CommunicationsStatus.Model;

namespace Example
{
    public class GetCommunicationPreferencesV3StatusEmailEmailAddressGetEmailStatusExample
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

            var apiInstance = new StatusApi(config);
            var emailAddress = "emailAddress_example";  // string | 

            try
            {
                // Get subscription statuses for a contact
                PublicSubscriptionStatusesResponse result = apiInstance.GetCommunicationPreferencesV3StatusEmailEmailAddressGetEmailStatus(emailAddress);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatusApi.GetCommunicationPreferencesV3StatusEmailEmailAddressGetEmailStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCommunicationPreferencesV3StatusEmailEmailAddressGetEmailStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get subscription statuses for a contact
    ApiResponse<PublicSubscriptionStatusesResponse> response = apiInstance.GetCommunicationPreferencesV3StatusEmailEmailAddressGetEmailStatusWithHttpInfo(emailAddress);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StatusApi.GetCommunicationPreferencesV3StatusEmailEmailAddressGetEmailStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailAddress** | **string** |  |  |

### Return type

[**PublicSubscriptionStatusesResponse**](PublicSubscriptionStatusesResponse.md)

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

<a id="postcommunicationpreferencesv3subscribesubscribe"></a>
# **PostCommunicationPreferencesV3SubscribeSubscribe**
> PublicSubscriptionStatus PostCommunicationPreferencesV3SubscribeSubscribe (PublicUpdateSubscriptionStatusRequest publicUpdateSubscriptionStatusRequest)

Subscribe a contact

Subscribes a contact to the given subscription type. This API is not valid to use for subscribing a contact at a brand or portal level and will return an error.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.CommunicationPreferences.CommunicationsStatus.Api;
using HubSpot.CommunicationPreferences.CommunicationsStatus.Client;
using HubSpot.CommunicationPreferences.CommunicationsStatus.Model;

namespace Example
{
    public class PostCommunicationPreferencesV3SubscribeSubscribeExample
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

            var apiInstance = new StatusApi(config);
            var publicUpdateSubscriptionStatusRequest = new PublicUpdateSubscriptionStatusRequest(); // PublicUpdateSubscriptionStatusRequest | 

            try
            {
                // Subscribe a contact
                PublicSubscriptionStatus result = apiInstance.PostCommunicationPreferencesV3SubscribeSubscribe(publicUpdateSubscriptionStatusRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatusApi.PostCommunicationPreferencesV3SubscribeSubscribe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCommunicationPreferencesV3SubscribeSubscribeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Subscribe a contact
    ApiResponse<PublicSubscriptionStatus> response = apiInstance.PostCommunicationPreferencesV3SubscribeSubscribeWithHttpInfo(publicUpdateSubscriptionStatusRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StatusApi.PostCommunicationPreferencesV3SubscribeSubscribeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publicUpdateSubscriptionStatusRequest** | [**PublicUpdateSubscriptionStatusRequest**](PublicUpdateSubscriptionStatusRequest.md) |  |  |

### Return type

[**PublicSubscriptionStatus**](PublicSubscriptionStatus.md)

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

<a id="postcommunicationpreferencesv3unsubscribeunsubscribe"></a>
# **PostCommunicationPreferencesV3UnsubscribeUnsubscribe**
> PublicSubscriptionStatus PostCommunicationPreferencesV3UnsubscribeUnsubscribe (PublicUpdateSubscriptionStatusRequest publicUpdateSubscriptionStatusRequest)

Unsubscribe a contact

Unsubscribes a contact from the given subscription type. This API is not valid to use for unsubscribing a contact at a brand or portal level and will return an error.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.CommunicationPreferences.CommunicationsStatus.Api;
using HubSpot.CommunicationPreferences.CommunicationsStatus.Client;
using HubSpot.CommunicationPreferences.CommunicationsStatus.Model;

namespace Example
{
    public class PostCommunicationPreferencesV3UnsubscribeUnsubscribeExample
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

            var apiInstance = new StatusApi(config);
            var publicUpdateSubscriptionStatusRequest = new PublicUpdateSubscriptionStatusRequest(); // PublicUpdateSubscriptionStatusRequest | 

            try
            {
                // Unsubscribe a contact
                PublicSubscriptionStatus result = apiInstance.PostCommunicationPreferencesV3UnsubscribeUnsubscribe(publicUpdateSubscriptionStatusRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatusApi.PostCommunicationPreferencesV3UnsubscribeUnsubscribe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCommunicationPreferencesV3UnsubscribeUnsubscribeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unsubscribe a contact
    ApiResponse<PublicSubscriptionStatus> response = apiInstance.PostCommunicationPreferencesV3UnsubscribeUnsubscribeWithHttpInfo(publicUpdateSubscriptionStatusRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StatusApi.PostCommunicationPreferencesV3UnsubscribeUnsubscribeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publicUpdateSubscriptionStatusRequest** | [**PublicUpdateSubscriptionStatusRequest**](PublicUpdateSubscriptionStatusRequest.md) |  |  |

### Return type

[**PublicSubscriptionStatus**](PublicSubscriptionStatus.md)

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

