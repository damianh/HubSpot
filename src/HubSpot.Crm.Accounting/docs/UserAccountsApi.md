# HubSpot.Crm.Accounting.Api.UserAccountsApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteCrmV3ExtensionsAccountingUserAccountsAccountIdArchive**](UserAccountsApi.md#deletecrmv3extensionsaccountinguseraccountsaccountidarchive) | **DELETE** /crm/v3/extensions/accounting/user-accounts/{accountId} | Delete user account |
| [**PutCrmV3ExtensionsAccountingUserAccountsReplace**](UserAccountsApi.md#putcrmv3extensionsaccountinguseraccountsreplace) | **PUT** /crm/v3/extensions/accounting/user-accounts | Create a user account |

<a id="deletecrmv3extensionsaccountinguseraccountsaccountidarchive"></a>
# **DeleteCrmV3ExtensionsAccountingUserAccountsAccountIdArchive**
> void DeleteCrmV3ExtensionsAccountingUserAccountsAccountIdArchive (string accountId)

Delete user account

Deletes a user account from HubSpot, meaning that HubSpot will no longer send requests to the external accounting system for this user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Accounting.Api;
using HubSpot.Crm.Accounting.Client;
using HubSpot.Crm.Accounting.Model;

namespace Example
{
    public class DeleteCrmV3ExtensionsAccountingUserAccountsAccountIdArchiveExample
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

            var apiInstance = new UserAccountsApi(config);
            var accountId = "accountId_example";  // string | The ID of the user account to delete.

            try
            {
                // Delete user account
                apiInstance.DeleteCrmV3ExtensionsAccountingUserAccountsAccountIdArchive(accountId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserAccountsApi.DeleteCrmV3ExtensionsAccountingUserAccountsAccountIdArchive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCrmV3ExtensionsAccountingUserAccountsAccountIdArchiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete user account
    apiInstance.DeleteCrmV3ExtensionsAccountingUserAccountsAccountIdArchiveWithHttpInfo(accountId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserAccountsApi.DeleteCrmV3ExtensionsAccountingUserAccountsAccountIdArchiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | The ID of the user account to delete. |  |

### Return type

void (empty response body)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putcrmv3extensionsaccountinguseraccountsreplace"></a>
# **PutCrmV3ExtensionsAccountingUserAccountsReplace**
> void PutCrmV3ExtensionsAccountingUserAccountsReplace (CreateUserAccountRequestExternal createUserAccountRequestExternal)

Create a user account

Creates an account which contains the information about the account in the external accounting system.  This *must* be called after a user connects their HubSpot account to the external accounting system, as there is no other way for HubSpot to obtain the external account details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Accounting.Api;
using HubSpot.Crm.Accounting.Client;
using HubSpot.Crm.Accounting.Model;

namespace Example
{
    public class PutCrmV3ExtensionsAccountingUserAccountsReplaceExample
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

            var apiInstance = new UserAccountsApi(config);
            var createUserAccountRequestExternal = new CreateUserAccountRequestExternal(); // CreateUserAccountRequestExternal | The external accounting system user account information.

            try
            {
                // Create a user account
                apiInstance.PutCrmV3ExtensionsAccountingUserAccountsReplace(createUserAccountRequestExternal);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserAccountsApi.PutCrmV3ExtensionsAccountingUserAccountsReplace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutCrmV3ExtensionsAccountingUserAccountsReplaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a user account
    apiInstance.PutCrmV3ExtensionsAccountingUserAccountsReplaceWithHttpInfo(createUserAccountRequestExternal);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserAccountsApi.PutCrmV3ExtensionsAccountingUserAccountsReplaceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createUserAccountRequestExternal** | [**CreateUserAccountRequestExternal**](CreateUserAccountRequestExternal.md) | The external accounting system user account information. |  |

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

