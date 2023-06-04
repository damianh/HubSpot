# HubSpot.Crm.Accounting.Api.CallbacksApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostCrmV3ExtensionsAccountingCallbackCustomerCreateRequestIdCreateCustomer**](CallbacksApi.md#postcrmv3extensionsaccountingcallbackcustomercreaterequestidcreatecustomer) | **POST** /crm/v3/extensions/accounting/callback/customer-create/{requestId} | Endpoint for customer creation response |
| [**PostCrmV3ExtensionsAccountingCallbackCustomerSearchRequestIdDoCustomerSearch**](CallbacksApi.md#postcrmv3extensionsaccountingcallbackcustomersearchrequestiddocustomersearch) | **POST** /crm/v3/extensions/accounting/callback/customer-search/{requestId} | Endpoint for customer search response |
| [**PostCrmV3ExtensionsAccountingCallbackExchangeRateRequestIdCreateExchangeRate**](CallbacksApi.md#postcrmv3extensionsaccountingcallbackexchangeraterequestidcreateexchangerate) | **POST** /crm/v3/extensions/accounting/callback/exchange-rate/{requestId} | Endpoint for exchange rate response |
| [**PostCrmV3ExtensionsAccountingCallbackInvoiceCreateRequestIdCreateInvoice**](CallbacksApi.md#postcrmv3extensionsaccountingcallbackinvoicecreaterequestidcreateinvoice) | **POST** /crm/v3/extensions/accounting/callback/invoice-create/{requestId} | Endpoint for invoice creation response |
| [**PostCrmV3ExtensionsAccountingCallbackInvoicePdfRequestIdInvoicePdf**](CallbacksApi.md#postcrmv3extensionsaccountingcallbackinvoicepdfrequestidinvoicepdf) | **POST** /crm/v3/extensions/accounting/callback/invoice-pdf/{requestId} | Endpoint for PDF content of invoice |
| [**PostCrmV3ExtensionsAccountingCallbackInvoiceSearchRequestIdDoInvoiceSearch**](CallbacksApi.md#postcrmv3extensionsaccountingcallbackinvoicesearchrequestiddoinvoicesearch) | **POST** /crm/v3/extensions/accounting/callback/invoice-search/{requestId} | Endpoint for invoice search response |
| [**PostCrmV3ExtensionsAccountingCallbackInvoicesRequestIdGetById**](CallbacksApi.md#postcrmv3extensionsaccountingcallbackinvoicesrequestidgetbyid) | **POST** /crm/v3/extensions/accounting/callback/invoices/{requestId} | Endpoint for invoice get-by-id response |
| [**PostCrmV3ExtensionsAccountingCallbackProductSearchRequestIdDoProductSearch**](CallbacksApi.md#postcrmv3extensionsaccountingcallbackproductsearchrequestiddoproductsearch) | **POST** /crm/v3/extensions/accounting/callback/product-search/{requestId} | Endpoint for product search response |
| [**PostCrmV3ExtensionsAccountingCallbackTaxSearchRequestIdDoTaxSearch**](CallbacksApi.md#postcrmv3extensionsaccountingcallbacktaxsearchrequestiddotaxsearch) | **POST** /crm/v3/extensions/accounting/callback/tax-search/{requestId} | Endpoint for taxes search response |
| [**PostCrmV3ExtensionsAccountingCallbackTermsRequestIdCreateTerm**](CallbacksApi.md#postcrmv3extensionsaccountingcallbacktermsrequestidcreateterm) | **POST** /crm/v3/extensions/accounting/callback/terms/{requestId} | Endpoint for terms search response |

<a id="postcrmv3extensionsaccountingcallbackcustomercreaterequestidcreatecustomer"></a>
# **PostCrmV3ExtensionsAccountingCallbackCustomerCreateRequestIdCreateCustomer**
> void PostCrmV3ExtensionsAccountingCallbackCustomerCreateRequestIdCreateCustomer (string requestId, ResultIdAccountingResponse resultIdAccountingResponse)

Endpoint for customer creation response

Call this endpoint with the response to a customer creation request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Accounting.Api;
using HubSpot.Crm.Accounting.Client;
using HubSpot.Crm.Accounting.Model;

namespace Example
{
    public class PostCrmV3ExtensionsAccountingCallbackCustomerCreateRequestIdCreateCustomerExample
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

            var apiInstance = new CallbacksApi(config);
            var requestId = "requestId_example";  // string | The ID of the request that this response is for
            var resultIdAccountingResponse = new ResultIdAccountingResponse(); // ResultIdAccountingResponse | The ID of the created customer.

            try
            {
                // Endpoint for customer creation response
                apiInstance.PostCrmV3ExtensionsAccountingCallbackCustomerCreateRequestIdCreateCustomer(requestId, resultIdAccountingResponse);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallbacksApi.PostCrmV3ExtensionsAccountingCallbackCustomerCreateRequestIdCreateCustomer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ExtensionsAccountingCallbackCustomerCreateRequestIdCreateCustomerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Endpoint for customer creation response
    apiInstance.PostCrmV3ExtensionsAccountingCallbackCustomerCreateRequestIdCreateCustomerWithHttpInfo(requestId, resultIdAccountingResponse);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallbacksApi.PostCrmV3ExtensionsAccountingCallbackCustomerCreateRequestIdCreateCustomerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | The ID of the request that this response is for |  |
| **resultIdAccountingResponse** | [**ResultIdAccountingResponse**](ResultIdAccountingResponse.md) | The ID of the created customer. |  |

### Return type

void (empty response body)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcrmv3extensionsaccountingcallbackcustomersearchrequestiddocustomersearch"></a>
# **PostCrmV3ExtensionsAccountingCallbackCustomerSearchRequestIdDoCustomerSearch**
> void PostCrmV3ExtensionsAccountingCallbackCustomerSearchRequestIdDoCustomerSearch (string requestId, CustomerSearchResponseExternal customerSearchResponseExternal)

Endpoint for customer search response

Call this endpoint with the response to a customer search request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Accounting.Api;
using HubSpot.Crm.Accounting.Client;
using HubSpot.Crm.Accounting.Model;

namespace Example
{
    public class PostCrmV3ExtensionsAccountingCallbackCustomerSearchRequestIdDoCustomerSearchExample
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

            var apiInstance = new CallbacksApi(config);
            var requestId = "requestId_example";  // string | The ID of the request that this response is for
            var customerSearchResponseExternal = new CustomerSearchResponseExternal(); // CustomerSearchResponseExternal | The result of the customer search request.

            try
            {
                // Endpoint for customer search response
                apiInstance.PostCrmV3ExtensionsAccountingCallbackCustomerSearchRequestIdDoCustomerSearch(requestId, customerSearchResponseExternal);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallbacksApi.PostCrmV3ExtensionsAccountingCallbackCustomerSearchRequestIdDoCustomerSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ExtensionsAccountingCallbackCustomerSearchRequestIdDoCustomerSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Endpoint for customer search response
    apiInstance.PostCrmV3ExtensionsAccountingCallbackCustomerSearchRequestIdDoCustomerSearchWithHttpInfo(requestId, customerSearchResponseExternal);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallbacksApi.PostCrmV3ExtensionsAccountingCallbackCustomerSearchRequestIdDoCustomerSearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | The ID of the request that this response is for |  |
| **customerSearchResponseExternal** | [**CustomerSearchResponseExternal**](CustomerSearchResponseExternal.md) | The result of the customer search request. |  |

### Return type

void (empty response body)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcrmv3extensionsaccountingcallbackexchangeraterequestidcreateexchangerate"></a>
# **PostCrmV3ExtensionsAccountingCallbackExchangeRateRequestIdCreateExchangeRate**
> void PostCrmV3ExtensionsAccountingCallbackExchangeRateRequestIdCreateExchangeRate (string requestId, ExchangeRateResponse exchangeRateResponse)

Endpoint for exchange rate response

Call this endpoint with the response to an exchange rate request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Accounting.Api;
using HubSpot.Crm.Accounting.Client;
using HubSpot.Crm.Accounting.Model;

namespace Example
{
    public class PostCrmV3ExtensionsAccountingCallbackExchangeRateRequestIdCreateExchangeRateExample
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

            var apiInstance = new CallbacksApi(config);
            var requestId = "requestId_example";  // string | The ID of the request that this response is for
            var exchangeRateResponse = new ExchangeRateResponse(); // ExchangeRateResponse | The result of the exchange rate request.

            try
            {
                // Endpoint for exchange rate response
                apiInstance.PostCrmV3ExtensionsAccountingCallbackExchangeRateRequestIdCreateExchangeRate(requestId, exchangeRateResponse);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallbacksApi.PostCrmV3ExtensionsAccountingCallbackExchangeRateRequestIdCreateExchangeRate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ExtensionsAccountingCallbackExchangeRateRequestIdCreateExchangeRateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Endpoint for exchange rate response
    apiInstance.PostCrmV3ExtensionsAccountingCallbackExchangeRateRequestIdCreateExchangeRateWithHttpInfo(requestId, exchangeRateResponse);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallbacksApi.PostCrmV3ExtensionsAccountingCallbackExchangeRateRequestIdCreateExchangeRateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | The ID of the request that this response is for |  |
| **exchangeRateResponse** | [**ExchangeRateResponse**](ExchangeRateResponse.md) | The result of the exchange rate request. |  |

### Return type

void (empty response body)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcrmv3extensionsaccountingcallbackinvoicecreaterequestidcreateinvoice"></a>
# **PostCrmV3ExtensionsAccountingCallbackInvoiceCreateRequestIdCreateInvoice**
> void PostCrmV3ExtensionsAccountingCallbackInvoiceCreateRequestIdCreateInvoice (string requestId, ResultIdAccountingResponse resultIdAccountingResponse)

Endpoint for invoice creation response

Call this endpoint with the response to a invoice creation request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Accounting.Api;
using HubSpot.Crm.Accounting.Client;
using HubSpot.Crm.Accounting.Model;

namespace Example
{
    public class PostCrmV3ExtensionsAccountingCallbackInvoiceCreateRequestIdCreateInvoiceExample
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

            var apiInstance = new CallbacksApi(config);
            var requestId = "requestId_example";  // string | The ID of the request that this response is for
            var resultIdAccountingResponse = new ResultIdAccountingResponse(); // ResultIdAccountingResponse | The ID of the created invoice.

            try
            {
                // Endpoint for invoice creation response
                apiInstance.PostCrmV3ExtensionsAccountingCallbackInvoiceCreateRequestIdCreateInvoice(requestId, resultIdAccountingResponse);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallbacksApi.PostCrmV3ExtensionsAccountingCallbackInvoiceCreateRequestIdCreateInvoice: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ExtensionsAccountingCallbackInvoiceCreateRequestIdCreateInvoiceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Endpoint for invoice creation response
    apiInstance.PostCrmV3ExtensionsAccountingCallbackInvoiceCreateRequestIdCreateInvoiceWithHttpInfo(requestId, resultIdAccountingResponse);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallbacksApi.PostCrmV3ExtensionsAccountingCallbackInvoiceCreateRequestIdCreateInvoiceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | The ID of the request that this response is for |  |
| **resultIdAccountingResponse** | [**ResultIdAccountingResponse**](ResultIdAccountingResponse.md) | The ID of the created invoice. |  |

### Return type

void (empty response body)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcrmv3extensionsaccountingcallbackinvoicepdfrequestidinvoicepdf"></a>
# **PostCrmV3ExtensionsAccountingCallbackInvoicePdfRequestIdInvoicePdf**
> void PostCrmV3ExtensionsAccountingCallbackInvoicePdfRequestIdInvoicePdf (string requestId, InvoicePdfResponse invoicePdfResponse)

Endpoint for PDF content of invoice

Call this endpoint with the PDF content of a requested invoice.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Accounting.Api;
using HubSpot.Crm.Accounting.Client;
using HubSpot.Crm.Accounting.Model;

namespace Example
{
    public class PostCrmV3ExtensionsAccountingCallbackInvoicePdfRequestIdInvoicePdfExample
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

            var apiInstance = new CallbacksApi(config);
            var requestId = "requestId_example";  // string | The ID of the request that this response is for
            var invoicePdfResponse = new InvoicePdfResponse(); // InvoicePdfResponse | The bytes of the invoice PDF.

            try
            {
                // Endpoint for PDF content of invoice
                apiInstance.PostCrmV3ExtensionsAccountingCallbackInvoicePdfRequestIdInvoicePdf(requestId, invoicePdfResponse);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallbacksApi.PostCrmV3ExtensionsAccountingCallbackInvoicePdfRequestIdInvoicePdf: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ExtensionsAccountingCallbackInvoicePdfRequestIdInvoicePdfWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Endpoint for PDF content of invoice
    apiInstance.PostCrmV3ExtensionsAccountingCallbackInvoicePdfRequestIdInvoicePdfWithHttpInfo(requestId, invoicePdfResponse);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallbacksApi.PostCrmV3ExtensionsAccountingCallbackInvoicePdfRequestIdInvoicePdfWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | The ID of the request that this response is for |  |
| **invoicePdfResponse** | [**InvoicePdfResponse**](InvoicePdfResponse.md) | The bytes of the invoice PDF. |  |

### Return type

void (empty response body)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcrmv3extensionsaccountingcallbackinvoicesearchrequestiddoinvoicesearch"></a>
# **PostCrmV3ExtensionsAccountingCallbackInvoiceSearchRequestIdDoInvoiceSearch**
> void PostCrmV3ExtensionsAccountingCallbackInvoiceSearchRequestIdDoInvoiceSearch (string requestId, InvoiceSearchResponse invoiceSearchResponse)

Endpoint for invoice search response

Call this endpoint with the response to a invoice search request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Accounting.Api;
using HubSpot.Crm.Accounting.Client;
using HubSpot.Crm.Accounting.Model;

namespace Example
{
    public class PostCrmV3ExtensionsAccountingCallbackInvoiceSearchRequestIdDoInvoiceSearchExample
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

            var apiInstance = new CallbacksApi(config);
            var requestId = "requestId_example";  // string | The ID of the request that this response is for
            var invoiceSearchResponse = new InvoiceSearchResponse(); // InvoiceSearchResponse | The result of the invoice search request.

            try
            {
                // Endpoint for invoice search response
                apiInstance.PostCrmV3ExtensionsAccountingCallbackInvoiceSearchRequestIdDoInvoiceSearch(requestId, invoiceSearchResponse);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallbacksApi.PostCrmV3ExtensionsAccountingCallbackInvoiceSearchRequestIdDoInvoiceSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ExtensionsAccountingCallbackInvoiceSearchRequestIdDoInvoiceSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Endpoint for invoice search response
    apiInstance.PostCrmV3ExtensionsAccountingCallbackInvoiceSearchRequestIdDoInvoiceSearchWithHttpInfo(requestId, invoiceSearchResponse);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallbacksApi.PostCrmV3ExtensionsAccountingCallbackInvoiceSearchRequestIdDoInvoiceSearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | The ID of the request that this response is for |  |
| **invoiceSearchResponse** | [**InvoiceSearchResponse**](InvoiceSearchResponse.md) | The result of the invoice search request. |  |

### Return type

void (empty response body)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcrmv3extensionsaccountingcallbackinvoicesrequestidgetbyid"></a>
# **PostCrmV3ExtensionsAccountingCallbackInvoicesRequestIdGetById**
> void PostCrmV3ExtensionsAccountingCallbackInvoicesRequestIdGetById (string requestId, InvoicesResponseExternal invoicesResponseExternal)

Endpoint for invoice get-by-id response

Call this endpoint with the response to a invoice get-by-id request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Accounting.Api;
using HubSpot.Crm.Accounting.Client;
using HubSpot.Crm.Accounting.Model;

namespace Example
{
    public class PostCrmV3ExtensionsAccountingCallbackInvoicesRequestIdGetByIdExample
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

            var apiInstance = new CallbacksApi(config);
            var requestId = "requestId_example";  // string | The ID of the request that this response is for
            var invoicesResponseExternal = new InvoicesResponseExternal(); // InvoicesResponseExternal | The result of the invoice request.

            try
            {
                // Endpoint for invoice get-by-id response
                apiInstance.PostCrmV3ExtensionsAccountingCallbackInvoicesRequestIdGetById(requestId, invoicesResponseExternal);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallbacksApi.PostCrmV3ExtensionsAccountingCallbackInvoicesRequestIdGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ExtensionsAccountingCallbackInvoicesRequestIdGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Endpoint for invoice get-by-id response
    apiInstance.PostCrmV3ExtensionsAccountingCallbackInvoicesRequestIdGetByIdWithHttpInfo(requestId, invoicesResponseExternal);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallbacksApi.PostCrmV3ExtensionsAccountingCallbackInvoicesRequestIdGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | The ID of the request that this response is for |  |
| **invoicesResponseExternal** | [**InvoicesResponseExternal**](InvoicesResponseExternal.md) | The result of the invoice request. |  |

### Return type

void (empty response body)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcrmv3extensionsaccountingcallbackproductsearchrequestiddoproductsearch"></a>
# **PostCrmV3ExtensionsAccountingCallbackProductSearchRequestIdDoProductSearch**
> void PostCrmV3ExtensionsAccountingCallbackProductSearchRequestIdDoProductSearch (string requestId, ProductSearchResponse productSearchResponse)

Endpoint for product search response

Call this endpoint with the response to a product search request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Accounting.Api;
using HubSpot.Crm.Accounting.Client;
using HubSpot.Crm.Accounting.Model;

namespace Example
{
    public class PostCrmV3ExtensionsAccountingCallbackProductSearchRequestIdDoProductSearchExample
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

            var apiInstance = new CallbacksApi(config);
            var requestId = "requestId_example";  // string | The ID of the request that this response is for
            var productSearchResponse = new ProductSearchResponse(); // ProductSearchResponse | The result of the product search request.

            try
            {
                // Endpoint for product search response
                apiInstance.PostCrmV3ExtensionsAccountingCallbackProductSearchRequestIdDoProductSearch(requestId, productSearchResponse);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallbacksApi.PostCrmV3ExtensionsAccountingCallbackProductSearchRequestIdDoProductSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ExtensionsAccountingCallbackProductSearchRequestIdDoProductSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Endpoint for product search response
    apiInstance.PostCrmV3ExtensionsAccountingCallbackProductSearchRequestIdDoProductSearchWithHttpInfo(requestId, productSearchResponse);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallbacksApi.PostCrmV3ExtensionsAccountingCallbackProductSearchRequestIdDoProductSearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | The ID of the request that this response is for |  |
| **productSearchResponse** | [**ProductSearchResponse**](ProductSearchResponse.md) | The result of the product search request. |  |

### Return type

void (empty response body)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcrmv3extensionsaccountingcallbacktaxsearchrequestiddotaxsearch"></a>
# **PostCrmV3ExtensionsAccountingCallbackTaxSearchRequestIdDoTaxSearch**
> void PostCrmV3ExtensionsAccountingCallbackTaxSearchRequestIdDoTaxSearch (string requestId, TaxSearchResponse taxSearchResponse)

Endpoint for taxes search response

Call this endpoint with the response to a taxes search request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Accounting.Api;
using HubSpot.Crm.Accounting.Client;
using HubSpot.Crm.Accounting.Model;

namespace Example
{
    public class PostCrmV3ExtensionsAccountingCallbackTaxSearchRequestIdDoTaxSearchExample
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

            var apiInstance = new CallbacksApi(config);
            var requestId = "requestId_example";  // string | The ID of the request that this response is for
            var taxSearchResponse = new TaxSearchResponse(); // TaxSearchResponse | The result of the taxes search request.

            try
            {
                // Endpoint for taxes search response
                apiInstance.PostCrmV3ExtensionsAccountingCallbackTaxSearchRequestIdDoTaxSearch(requestId, taxSearchResponse);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallbacksApi.PostCrmV3ExtensionsAccountingCallbackTaxSearchRequestIdDoTaxSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ExtensionsAccountingCallbackTaxSearchRequestIdDoTaxSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Endpoint for taxes search response
    apiInstance.PostCrmV3ExtensionsAccountingCallbackTaxSearchRequestIdDoTaxSearchWithHttpInfo(requestId, taxSearchResponse);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallbacksApi.PostCrmV3ExtensionsAccountingCallbackTaxSearchRequestIdDoTaxSearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | The ID of the request that this response is for |  |
| **taxSearchResponse** | [**TaxSearchResponse**](TaxSearchResponse.md) | The result of the taxes search request. |  |

### Return type

void (empty response body)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcrmv3extensionsaccountingcallbacktermsrequestidcreateterm"></a>
# **PostCrmV3ExtensionsAccountingCallbackTermsRequestIdCreateTerm**
> void PostCrmV3ExtensionsAccountingCallbackTermsRequestIdCreateTerm (string requestId, TermsResponse termsResponse)

Endpoint for terms search response

Call this endpoint with the response to a terms search request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Accounting.Api;
using HubSpot.Crm.Accounting.Client;
using HubSpot.Crm.Accounting.Model;

namespace Example
{
    public class PostCrmV3ExtensionsAccountingCallbackTermsRequestIdCreateTermExample
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

            var apiInstance = new CallbacksApi(config);
            var requestId = "requestId_example";  // string | The ID of the request that this response is for
            var termsResponse = new TermsResponse(); // TermsResponse | The result of the terms search

            try
            {
                // Endpoint for terms search response
                apiInstance.PostCrmV3ExtensionsAccountingCallbackTermsRequestIdCreateTerm(requestId, termsResponse);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallbacksApi.PostCrmV3ExtensionsAccountingCallbackTermsRequestIdCreateTerm: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ExtensionsAccountingCallbackTermsRequestIdCreateTermWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Endpoint for terms search response
    apiInstance.PostCrmV3ExtensionsAccountingCallbackTermsRequestIdCreateTermWithHttpInfo(requestId, termsResponse);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallbacksApi.PostCrmV3ExtensionsAccountingCallbackTermsRequestIdCreateTermWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | The ID of the request that this response is for |  |
| **termsResponse** | [**TermsResponse**](TermsResponse.md) | The result of the terms search |  |

### Return type

void (empty response body)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

