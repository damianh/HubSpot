# HubSpot.Conversations.VisitorIdentification.Api.GenerateApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostVisitorIdentificationV3TokensCreateGenerateToken**](GenerateApi.md#postvisitoridentificationv3tokenscreategeneratetoken) | **POST** /conversations/v3/visitor-identification/tokens/create | Generate a token |

<a id="postvisitoridentificationv3tokenscreategeneratetoken"></a>
# **PostVisitorIdentificationV3TokensCreateGenerateToken**
> IdentificationTokenResponse PostVisitorIdentificationV3TokensCreateGenerateToken (IdentificationTokenGenerationRequest identificationTokenGenerationRequest)

Generate a token

Generates a new visitor identification token. This token will be unique every time this endpoint is called, even if called with the same email address. This token is temporary and will expire after 12 hours

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Conversations.VisitorIdentification.Api;
using HubSpot.Conversations.VisitorIdentification.Client;
using HubSpot.Conversations.VisitorIdentification.Model;

namespace Example
{
    public class PostVisitorIdentificationV3TokensCreateGenerateTokenExample
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

            var apiInstance = new GenerateApi(config);
            var identificationTokenGenerationRequest = new IdentificationTokenGenerationRequest(); // IdentificationTokenGenerationRequest | 

            try
            {
                // Generate a token
                IdentificationTokenResponse result = apiInstance.PostVisitorIdentificationV3TokensCreateGenerateToken(identificationTokenGenerationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GenerateApi.PostVisitorIdentificationV3TokensCreateGenerateToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostVisitorIdentificationV3TokensCreateGenerateTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Generate a token
    ApiResponse<IdentificationTokenResponse> response = apiInstance.PostVisitorIdentificationV3TokensCreateGenerateTokenWithHttpInfo(identificationTokenGenerationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GenerateApi.PostVisitorIdentificationV3TokensCreateGenerateTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identificationTokenGenerationRequest** | [**IdentificationTokenGenerationRequest**](IdentificationTokenGenerationRequest.md) |  |  |

### Return type

[**IdentificationTokenResponse**](IdentificationTokenResponse.md)

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

