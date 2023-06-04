# HubSpot.Marketing.MarketingEventsBeta.Api.MarketingEventsExternalApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteMarketingV3MarketingEventsEventsExternalEventIdArchive**](MarketingEventsExternalApi.md#deletemarketingv3marketingeventseventsexternaleventidarchive) | **DELETE** /marketing/v3/marketing-events/events/{externalEventId} |  |
| [**GetMarketingV3MarketingEventsEventsExternalEventIdGetById**](MarketingEventsExternalApi.md#getmarketingv3marketingeventseventsexternaleventidgetbyid) | **GET** /marketing/v3/marketing-events/events/{externalEventId} |  |
| [**PatchMarketingV3MarketingEventsEventsExternalEventIdUpdate**](MarketingEventsExternalApi.md#patchmarketingv3marketingeventseventsexternaleventidupdate) | **PATCH** /marketing/v3/marketing-events/events/{externalEventId} |  |
| [**PostMarketingV3MarketingEventsEventsCreate**](MarketingEventsExternalApi.md#postmarketingv3marketingeventseventscreate) | **POST** /marketing/v3/marketing-events/events |  |
| [**PostMarketingV3MarketingEventsEventsDeleteArchiveBatch**](MarketingEventsExternalApi.md#postmarketingv3marketingeventseventsdeletearchivebatch) | **POST** /marketing/v3/marketing-events/events/delete |  |
| [**PostMarketingV3MarketingEventsEventsExternalEventIdCancelDoCancel**](MarketingEventsExternalApi.md#postmarketingv3marketingeventseventsexternaleventidcanceldocancel) | **POST** /marketing/v3/marketing-events/events/{externalEventId}/cancel |  |
| [**PostMarketingV3MarketingEventsEventsExternalEventIdCompleteComplete**](MarketingEventsExternalApi.md#postmarketingv3marketingeventseventsexternaleventidcompletecomplete) | **POST** /marketing/v3/marketing-events/events/{externalEventId}/complete |  |
| [**PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateEmailUpsertDoEmailUpsertById**](MarketingEventsExternalApi.md#postmarketingv3marketingeventseventsexternaleventidsubscriberstateemailupsertdoemailupsertbyid) | **POST** /marketing/v3/marketing-events/events/{externalEventId}/{subscriberState}/email-upsert |  |
| [**PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateUpsertDoUpsertById**](MarketingEventsExternalApi.md#postmarketingv3marketingeventseventsexternaleventidsubscriberstateupsertdoupsertbyid) | **POST** /marketing/v3/marketing-events/events/{externalEventId}/{subscriberState}/upsert |  |
| [**PostMarketingV3MarketingEventsEventsUpsertDoUpsert**](MarketingEventsExternalApi.md#postmarketingv3marketingeventseventsupsertdoupsert) | **POST** /marketing/v3/marketing-events/events/upsert |  |
| [**PutMarketingV3MarketingEventsEventsExternalEventIdReplace**](MarketingEventsExternalApi.md#putmarketingv3marketingeventseventsexternaleventidreplace) | **PUT** /marketing/v3/marketing-events/events/{externalEventId} |  |

<a id="deletemarketingv3marketingeventseventsexternaleventidarchive"></a>
# **DeleteMarketingV3MarketingEventsEventsExternalEventIdArchive**
> void DeleteMarketingV3MarketingEventsEventsExternalEventIdArchive (string externalEventId, string externalAccountId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Marketing.MarketingEventsBeta.Api;
using HubSpot.Marketing.MarketingEventsBeta.Client;
using HubSpot.Marketing.MarketingEventsBeta.Model;

namespace Example
{
    public class DeleteMarketingV3MarketingEventsEventsExternalEventIdArchiveExample
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

            var apiInstance = new MarketingEventsExternalApi(config);
            var externalEventId = "externalEventId_example";  // string | 
            var externalAccountId = "externalAccountId_example";  // string | 

            try
            {
                apiInstance.DeleteMarketingV3MarketingEventsEventsExternalEventIdArchive(externalEventId, externalAccountId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketingEventsExternalApi.DeleteMarketingV3MarketingEventsEventsExternalEventIdArchive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMarketingV3MarketingEventsEventsExternalEventIdArchiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeleteMarketingV3MarketingEventsEventsExternalEventIdArchiveWithHttpInfo(externalEventId, externalAccountId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarketingEventsExternalApi.DeleteMarketingV3MarketingEventsEventsExternalEventIdArchiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **externalEventId** | **string** |  |  |
| **externalAccountId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmarketingv3marketingeventseventsexternaleventidgetbyid"></a>
# **GetMarketingV3MarketingEventsEventsExternalEventIdGetById**
> MarketingEventPublicReadResponse GetMarketingV3MarketingEventsEventsExternalEventIdGetById (string externalEventId, string externalAccountId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Marketing.MarketingEventsBeta.Api;
using HubSpot.Marketing.MarketingEventsBeta.Client;
using HubSpot.Marketing.MarketingEventsBeta.Model;

namespace Example
{
    public class GetMarketingV3MarketingEventsEventsExternalEventIdGetByIdExample
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

            var apiInstance = new MarketingEventsExternalApi(config);
            var externalEventId = "externalEventId_example";  // string | 
            var externalAccountId = "externalAccountId_example";  // string | 

            try
            {
                MarketingEventPublicReadResponse result = apiInstance.GetMarketingV3MarketingEventsEventsExternalEventIdGetById(externalEventId, externalAccountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketingEventsExternalApi.GetMarketingV3MarketingEventsEventsExternalEventIdGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMarketingV3MarketingEventsEventsExternalEventIdGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MarketingEventPublicReadResponse> response = apiInstance.GetMarketingV3MarketingEventsEventsExternalEventIdGetByIdWithHttpInfo(externalEventId, externalAccountId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarketingEventsExternalApi.GetMarketingV3MarketingEventsEventsExternalEventIdGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **externalEventId** | **string** |  |  |
| **externalAccountId** | **string** |  |  |

### Return type

[**MarketingEventPublicReadResponse**](MarketingEventPublicReadResponse.md)

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

<a id="patchmarketingv3marketingeventseventsexternaleventidupdate"></a>
# **PatchMarketingV3MarketingEventsEventsExternalEventIdUpdate**
> MarketingEventPublicDefaultResponse PatchMarketingV3MarketingEventsEventsExternalEventIdUpdate (string externalEventId, string externalAccountId, MarketingEventUpdateRequestParams marketingEventUpdateRequestParams)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Marketing.MarketingEventsBeta.Api;
using HubSpot.Marketing.MarketingEventsBeta.Client;
using HubSpot.Marketing.MarketingEventsBeta.Model;

namespace Example
{
    public class PatchMarketingV3MarketingEventsEventsExternalEventIdUpdateExample
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

            var apiInstance = new MarketingEventsExternalApi(config);
            var externalEventId = "externalEventId_example";  // string | 
            var externalAccountId = "externalAccountId_example";  // string | 
            var marketingEventUpdateRequestParams = new MarketingEventUpdateRequestParams(); // MarketingEventUpdateRequestParams | 

            try
            {
                MarketingEventPublicDefaultResponse result = apiInstance.PatchMarketingV3MarketingEventsEventsExternalEventIdUpdate(externalEventId, externalAccountId, marketingEventUpdateRequestParams);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketingEventsExternalApi.PatchMarketingV3MarketingEventsEventsExternalEventIdUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchMarketingV3MarketingEventsEventsExternalEventIdUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MarketingEventPublicDefaultResponse> response = apiInstance.PatchMarketingV3MarketingEventsEventsExternalEventIdUpdateWithHttpInfo(externalEventId, externalAccountId, marketingEventUpdateRequestParams);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarketingEventsExternalApi.PatchMarketingV3MarketingEventsEventsExternalEventIdUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **externalEventId** | **string** |  |  |
| **externalAccountId** | **string** |  |  |
| **marketingEventUpdateRequestParams** | [**MarketingEventUpdateRequestParams**](MarketingEventUpdateRequestParams.md) |  |  |

### Return type

[**MarketingEventPublicDefaultResponse**](MarketingEventPublicDefaultResponse.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postmarketingv3marketingeventseventscreate"></a>
# **PostMarketingV3MarketingEventsEventsCreate**
> MarketingEventDefaultResponse PostMarketingV3MarketingEventsEventsCreate (MarketingEventCreateRequestParams marketingEventCreateRequestParams)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Marketing.MarketingEventsBeta.Api;
using HubSpot.Marketing.MarketingEventsBeta.Client;
using HubSpot.Marketing.MarketingEventsBeta.Model;

namespace Example
{
    public class PostMarketingV3MarketingEventsEventsCreateExample
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

            var apiInstance = new MarketingEventsExternalApi(config);
            var marketingEventCreateRequestParams = new MarketingEventCreateRequestParams(); // MarketingEventCreateRequestParams | 

            try
            {
                MarketingEventDefaultResponse result = apiInstance.PostMarketingV3MarketingEventsEventsCreate(marketingEventCreateRequestParams);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketingEventsExternalApi.PostMarketingV3MarketingEventsEventsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostMarketingV3MarketingEventsEventsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MarketingEventDefaultResponse> response = apiInstance.PostMarketingV3MarketingEventsEventsCreateWithHttpInfo(marketingEventCreateRequestParams);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarketingEventsExternalApi.PostMarketingV3MarketingEventsEventsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **marketingEventCreateRequestParams** | [**MarketingEventCreateRequestParams**](MarketingEventCreateRequestParams.md) |  |  |

### Return type

[**MarketingEventDefaultResponse**](MarketingEventDefaultResponse.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postmarketingv3marketingeventseventsdeletearchivebatch"></a>
# **PostMarketingV3MarketingEventsEventsDeleteArchiveBatch**
> Error PostMarketingV3MarketingEventsEventsDeleteArchiveBatch (BatchInputMarketingEventExternalUniqueIdentifier batchInputMarketingEventExternalUniqueIdentifier)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Marketing.MarketingEventsBeta.Api;
using HubSpot.Marketing.MarketingEventsBeta.Client;
using HubSpot.Marketing.MarketingEventsBeta.Model;

namespace Example
{
    public class PostMarketingV3MarketingEventsEventsDeleteArchiveBatchExample
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

            var apiInstance = new MarketingEventsExternalApi(config);
            var batchInputMarketingEventExternalUniqueIdentifier = new BatchInputMarketingEventExternalUniqueIdentifier(); // BatchInputMarketingEventExternalUniqueIdentifier | 

            try
            {
                Error result = apiInstance.PostMarketingV3MarketingEventsEventsDeleteArchiveBatch(batchInputMarketingEventExternalUniqueIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketingEventsExternalApi.PostMarketingV3MarketingEventsEventsDeleteArchiveBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostMarketingV3MarketingEventsEventsDeleteArchiveBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Error> response = apiInstance.PostMarketingV3MarketingEventsEventsDeleteArchiveBatchWithHttpInfo(batchInputMarketingEventExternalUniqueIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarketingEventsExternalApi.PostMarketingV3MarketingEventsEventsDeleteArchiveBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchInputMarketingEventExternalUniqueIdentifier** | [**BatchInputMarketingEventExternalUniqueIdentifier**](BatchInputMarketingEventExternalUniqueIdentifier.md) |  |  |

### Return type

[**Error**](Error.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postmarketingv3marketingeventseventsexternaleventidcanceldocancel"></a>
# **PostMarketingV3MarketingEventsEventsExternalEventIdCancelDoCancel**
> MarketingEventDefaultResponse PostMarketingV3MarketingEventsEventsExternalEventIdCancelDoCancel (string externalEventId, string externalAccountId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Marketing.MarketingEventsBeta.Api;
using HubSpot.Marketing.MarketingEventsBeta.Client;
using HubSpot.Marketing.MarketingEventsBeta.Model;

namespace Example
{
    public class PostMarketingV3MarketingEventsEventsExternalEventIdCancelDoCancelExample
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

            var apiInstance = new MarketingEventsExternalApi(config);
            var externalEventId = "externalEventId_example";  // string | 
            var externalAccountId = "externalAccountId_example";  // string | 

            try
            {
                MarketingEventDefaultResponse result = apiInstance.PostMarketingV3MarketingEventsEventsExternalEventIdCancelDoCancel(externalEventId, externalAccountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketingEventsExternalApi.PostMarketingV3MarketingEventsEventsExternalEventIdCancelDoCancel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostMarketingV3MarketingEventsEventsExternalEventIdCancelDoCancelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MarketingEventDefaultResponse> response = apiInstance.PostMarketingV3MarketingEventsEventsExternalEventIdCancelDoCancelWithHttpInfo(externalEventId, externalAccountId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarketingEventsExternalApi.PostMarketingV3MarketingEventsEventsExternalEventIdCancelDoCancelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **externalEventId** | **string** |  |  |
| **externalAccountId** | **string** |  |  |

### Return type

[**MarketingEventDefaultResponse**](MarketingEventDefaultResponse.md)

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

<a id="postmarketingv3marketingeventseventsexternaleventidcompletecomplete"></a>
# **PostMarketingV3MarketingEventsEventsExternalEventIdCompleteComplete**
> MarketingEventDefaultResponse PostMarketingV3MarketingEventsEventsExternalEventIdCompleteComplete (string externalEventId, string externalAccountId, MarketingEventCompleteRequestParams marketingEventCompleteRequestParams)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Marketing.MarketingEventsBeta.Api;
using HubSpot.Marketing.MarketingEventsBeta.Client;
using HubSpot.Marketing.MarketingEventsBeta.Model;

namespace Example
{
    public class PostMarketingV3MarketingEventsEventsExternalEventIdCompleteCompleteExample
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

            var apiInstance = new MarketingEventsExternalApi(config);
            var externalEventId = "externalEventId_example";  // string | 
            var externalAccountId = "externalAccountId_example";  // string | 
            var marketingEventCompleteRequestParams = new MarketingEventCompleteRequestParams(); // MarketingEventCompleteRequestParams | 

            try
            {
                MarketingEventDefaultResponse result = apiInstance.PostMarketingV3MarketingEventsEventsExternalEventIdCompleteComplete(externalEventId, externalAccountId, marketingEventCompleteRequestParams);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketingEventsExternalApi.PostMarketingV3MarketingEventsEventsExternalEventIdCompleteComplete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostMarketingV3MarketingEventsEventsExternalEventIdCompleteCompleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MarketingEventDefaultResponse> response = apiInstance.PostMarketingV3MarketingEventsEventsExternalEventIdCompleteCompleteWithHttpInfo(externalEventId, externalAccountId, marketingEventCompleteRequestParams);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarketingEventsExternalApi.PostMarketingV3MarketingEventsEventsExternalEventIdCompleteCompleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **externalEventId** | **string** |  |  |
| **externalAccountId** | **string** |  |  |
| **marketingEventCompleteRequestParams** | [**MarketingEventCompleteRequestParams**](MarketingEventCompleteRequestParams.md) |  |  |

### Return type

[**MarketingEventDefaultResponse**](MarketingEventDefaultResponse.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postmarketingv3marketingeventseventsexternaleventidsubscriberstateemailupsertdoemailupsertbyid"></a>
# **PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateEmailUpsertDoEmailUpsertById**
> Error PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateEmailUpsertDoEmailUpsertById (string externalEventId, string subscriberState, string externalAccountId, BatchInputMarketingEventEmailSubscriber batchInputMarketingEventEmailSubscriber)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Marketing.MarketingEventsBeta.Api;
using HubSpot.Marketing.MarketingEventsBeta.Client;
using HubSpot.Marketing.MarketingEventsBeta.Model;

namespace Example
{
    public class PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateEmailUpsertDoEmailUpsertByIdExample
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

            var apiInstance = new MarketingEventsExternalApi(config);
            var externalEventId = "externalEventId_example";  // string | 
            var subscriberState = "subscriberState_example";  // string | 
            var externalAccountId = "externalAccountId_example";  // string | 
            var batchInputMarketingEventEmailSubscriber = new BatchInputMarketingEventEmailSubscriber(); // BatchInputMarketingEventEmailSubscriber | 

            try
            {
                Error result = apiInstance.PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateEmailUpsertDoEmailUpsertById(externalEventId, subscriberState, externalAccountId, batchInputMarketingEventEmailSubscriber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketingEventsExternalApi.PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateEmailUpsertDoEmailUpsertById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateEmailUpsertDoEmailUpsertByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Error> response = apiInstance.PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateEmailUpsertDoEmailUpsertByIdWithHttpInfo(externalEventId, subscriberState, externalAccountId, batchInputMarketingEventEmailSubscriber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarketingEventsExternalApi.PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateEmailUpsertDoEmailUpsertByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **externalEventId** | **string** |  |  |
| **subscriberState** | **string** |  |  |
| **externalAccountId** | **string** |  |  |
| **batchInputMarketingEventEmailSubscriber** | [**BatchInputMarketingEventEmailSubscriber**](BatchInputMarketingEventEmailSubscriber.md) |  |  |

### Return type

[**Error**](Error.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postmarketingv3marketingeventseventsexternaleventidsubscriberstateupsertdoupsertbyid"></a>
# **PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateUpsertDoUpsertById**
> Error PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateUpsertDoUpsertById (string externalEventId, string subscriberState, string externalAccountId, BatchInputMarketingEventSubscriber batchInputMarketingEventSubscriber)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Marketing.MarketingEventsBeta.Api;
using HubSpot.Marketing.MarketingEventsBeta.Client;
using HubSpot.Marketing.MarketingEventsBeta.Model;

namespace Example
{
    public class PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateUpsertDoUpsertByIdExample
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

            var apiInstance = new MarketingEventsExternalApi(config);
            var externalEventId = "externalEventId_example";  // string | 
            var subscriberState = "subscriberState_example";  // string | 
            var externalAccountId = "externalAccountId_example";  // string | 
            var batchInputMarketingEventSubscriber = new BatchInputMarketingEventSubscriber(); // BatchInputMarketingEventSubscriber | 

            try
            {
                Error result = apiInstance.PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateUpsertDoUpsertById(externalEventId, subscriberState, externalAccountId, batchInputMarketingEventSubscriber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketingEventsExternalApi.PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateUpsertDoUpsertById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateUpsertDoUpsertByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Error> response = apiInstance.PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateUpsertDoUpsertByIdWithHttpInfo(externalEventId, subscriberState, externalAccountId, batchInputMarketingEventSubscriber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarketingEventsExternalApi.PostMarketingV3MarketingEventsEventsExternalEventIdSubscriberStateUpsertDoUpsertByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **externalEventId** | **string** |  |  |
| **subscriberState** | **string** |  |  |
| **externalAccountId** | **string** |  |  |
| **batchInputMarketingEventSubscriber** | [**BatchInputMarketingEventSubscriber**](BatchInputMarketingEventSubscriber.md) |  |  |

### Return type

[**Error**](Error.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postmarketingv3marketingeventseventsupsertdoupsert"></a>
# **PostMarketingV3MarketingEventsEventsUpsertDoUpsert**
> BatchResponseMarketingEventPublicDefaultResponse PostMarketingV3MarketingEventsEventsUpsertDoUpsert (BatchInputMarketingEventCreateRequestParams batchInputMarketingEventCreateRequestParams)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Marketing.MarketingEventsBeta.Api;
using HubSpot.Marketing.MarketingEventsBeta.Client;
using HubSpot.Marketing.MarketingEventsBeta.Model;

namespace Example
{
    public class PostMarketingV3MarketingEventsEventsUpsertDoUpsertExample
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

            var apiInstance = new MarketingEventsExternalApi(config);
            var batchInputMarketingEventCreateRequestParams = new BatchInputMarketingEventCreateRequestParams(); // BatchInputMarketingEventCreateRequestParams | 

            try
            {
                BatchResponseMarketingEventPublicDefaultResponse result = apiInstance.PostMarketingV3MarketingEventsEventsUpsertDoUpsert(batchInputMarketingEventCreateRequestParams);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketingEventsExternalApi.PostMarketingV3MarketingEventsEventsUpsertDoUpsert: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostMarketingV3MarketingEventsEventsUpsertDoUpsertWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BatchResponseMarketingEventPublicDefaultResponse> response = apiInstance.PostMarketingV3MarketingEventsEventsUpsertDoUpsertWithHttpInfo(batchInputMarketingEventCreateRequestParams);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarketingEventsExternalApi.PostMarketingV3MarketingEventsEventsUpsertDoUpsertWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchInputMarketingEventCreateRequestParams** | [**BatchInputMarketingEventCreateRequestParams**](BatchInputMarketingEventCreateRequestParams.md) |  |  |

### Return type

[**BatchResponseMarketingEventPublicDefaultResponse**](BatchResponseMarketingEventPublicDefaultResponse.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putmarketingv3marketingeventseventsexternaleventidreplace"></a>
# **PutMarketingV3MarketingEventsEventsExternalEventIdReplace**
> MarketingEventPublicDefaultResponse PutMarketingV3MarketingEventsEventsExternalEventIdReplace (string externalEventId, MarketingEventCreateRequestParams marketingEventCreateRequestParams)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Marketing.MarketingEventsBeta.Api;
using HubSpot.Marketing.MarketingEventsBeta.Client;
using HubSpot.Marketing.MarketingEventsBeta.Model;

namespace Example
{
    public class PutMarketingV3MarketingEventsEventsExternalEventIdReplaceExample
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

            var apiInstance = new MarketingEventsExternalApi(config);
            var externalEventId = "externalEventId_example";  // string | 
            var marketingEventCreateRequestParams = new MarketingEventCreateRequestParams(); // MarketingEventCreateRequestParams | 

            try
            {
                MarketingEventPublicDefaultResponse result = apiInstance.PutMarketingV3MarketingEventsEventsExternalEventIdReplace(externalEventId, marketingEventCreateRequestParams);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketingEventsExternalApi.PutMarketingV3MarketingEventsEventsExternalEventIdReplace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutMarketingV3MarketingEventsEventsExternalEventIdReplaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MarketingEventPublicDefaultResponse> response = apiInstance.PutMarketingV3MarketingEventsEventsExternalEventIdReplaceWithHttpInfo(externalEventId, marketingEventCreateRequestParams);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarketingEventsExternalApi.PutMarketingV3MarketingEventsEventsExternalEventIdReplaceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **externalEventId** | **string** |  |  |
| **marketingEventCreateRequestParams** | [**MarketingEventCreateRequestParams**](MarketingEventCreateRequestParams.md) |  |  |

### Return type

[**MarketingEventPublicDefaultResponse**](MarketingEventPublicDefaultResponse.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

