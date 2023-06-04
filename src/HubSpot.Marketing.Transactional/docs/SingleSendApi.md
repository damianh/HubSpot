# HubSpot.Marketing.Transactional.Api.SingleSendApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostMarketingV3TransactionalSingleEmailSendSendEmail**](SingleSendApi.md#postmarketingv3transactionalsingleemailsendsendemail) | **POST** /marketing/v3/transactional/single-email/send | Send a single transactional email asynchronously. |

<a id="postmarketingv3transactionalsingleemailsendsendemail"></a>
# **PostMarketingV3TransactionalSingleEmailSendSendEmail**
> EmailSendStatusView PostMarketingV3TransactionalSingleEmailSendSendEmail (PublicSingleSendRequestEgg publicSingleSendRequestEgg)

Send a single transactional email asynchronously.

Asynchronously send a transactional email. Returns the status of the email send with a statusId that can be used to continuously query for the status using the Email Send Status API.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Marketing.Transactional.Api;
using HubSpot.Marketing.Transactional.Client;
using HubSpot.Marketing.Transactional.Model;

namespace Example
{
    public class PostMarketingV3TransactionalSingleEmailSendSendEmailExample
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

            var apiInstance = new SingleSendApi(config);
            var publicSingleSendRequestEgg = new PublicSingleSendRequestEgg(); // PublicSingleSendRequestEgg | A request object describing the email to send.

            try
            {
                // Send a single transactional email asynchronously.
                EmailSendStatusView result = apiInstance.PostMarketingV3TransactionalSingleEmailSendSendEmail(publicSingleSendRequestEgg);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SingleSendApi.PostMarketingV3TransactionalSingleEmailSendSendEmail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostMarketingV3TransactionalSingleEmailSendSendEmailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send a single transactional email asynchronously.
    ApiResponse<EmailSendStatusView> response = apiInstance.PostMarketingV3TransactionalSingleEmailSendSendEmailWithHttpInfo(publicSingleSendRequestEgg);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SingleSendApi.PostMarketingV3TransactionalSingleEmailSendSendEmailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publicSingleSendRequestEgg** | [**PublicSingleSendRequestEgg**](PublicSingleSendRequestEgg.md) | A request object describing the email to send. |  |

### Return type

[**EmailSendStatusView**](EmailSendStatusView.md)

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

