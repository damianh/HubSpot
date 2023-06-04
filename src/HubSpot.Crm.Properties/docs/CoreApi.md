# HubSpot.Crm.Properties.Api.CoreApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteCrmV3PropertiesObjectTypePropertyNameArchive**](CoreApi.md#deletecrmv3propertiesobjecttypepropertynamearchive) | **DELETE** /crm/v3/properties/{objectType}/{propertyName} | Archive a property |
| [**GetCrmV3PropertiesObjectTypeGetAll**](CoreApi.md#getcrmv3propertiesobjecttypegetall) | **GET** /crm/v3/properties/{objectType} | Read all properties |
| [**GetCrmV3PropertiesObjectTypePropertyNameGetByName**](CoreApi.md#getcrmv3propertiesobjecttypepropertynamegetbyname) | **GET** /crm/v3/properties/{objectType}/{propertyName} | Read a property |
| [**PatchCrmV3PropertiesObjectTypePropertyNameUpdate**](CoreApi.md#patchcrmv3propertiesobjecttypepropertynameupdate) | **PATCH** /crm/v3/properties/{objectType}/{propertyName} | Update a property |
| [**PostCrmV3PropertiesObjectTypeCreate**](CoreApi.md#postcrmv3propertiesobjecttypecreate) | **POST** /crm/v3/properties/{objectType} | Create a property |

<a id="deletecrmv3propertiesobjecttypepropertynamearchive"></a>
# **DeleteCrmV3PropertiesObjectTypePropertyNameArchive**
> void DeleteCrmV3PropertiesObjectTypePropertyNameArchive (string objectType, string propertyName)

Archive a property

Move a property identified by {propertyName} to the recycling bin.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Properties.Api;
using HubSpot.Crm.Properties.Client;
using HubSpot.Crm.Properties.Model;

namespace Example
{
    public class DeleteCrmV3PropertiesObjectTypePropertyNameArchiveExample
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

            var apiInstance = new CoreApi(config);
            var objectType = "objectType_example";  // string | 
            var propertyName = "propertyName_example";  // string | 

            try
            {
                // Archive a property
                apiInstance.DeleteCrmV3PropertiesObjectTypePropertyNameArchive(objectType, propertyName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.DeleteCrmV3PropertiesObjectTypePropertyNameArchive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCrmV3PropertiesObjectTypePropertyNameArchiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Archive a property
    apiInstance.DeleteCrmV3PropertiesObjectTypePropertyNameArchiveWithHttpInfo(objectType, propertyName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoreApi.DeleteCrmV3PropertiesObjectTypePropertyNameArchiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectType** | **string** |  |  |
| **propertyName** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps_legacy](../README.md#private_apps_legacy), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcrmv3propertiesobjecttypegetall"></a>
# **GetCrmV3PropertiesObjectTypeGetAll**
> CollectionResponsePropertyNoPaging GetCrmV3PropertiesObjectTypeGetAll (string objectType, bool? archived = null, string properties = null)

Read all properties

Read all existing properties for the specified object type and HubSpot account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Properties.Api;
using HubSpot.Crm.Properties.Client;
using HubSpot.Crm.Properties.Model;

namespace Example
{
    public class GetCrmV3PropertiesObjectTypeGetAllExample
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

            var apiInstance = new CoreApi(config);
            var objectType = "objectType_example";  // string | 
            var archived = false;  // bool? | Whether to return only results that have been archived. (optional)  (default to false)
            var properties = "properties_example";  // string |  (optional) 

            try
            {
                // Read all properties
                CollectionResponsePropertyNoPaging result = apiInstance.GetCrmV3PropertiesObjectTypeGetAll(objectType, archived, properties);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.GetCrmV3PropertiesObjectTypeGetAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCrmV3PropertiesObjectTypeGetAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read all properties
    ApiResponse<CollectionResponsePropertyNoPaging> response = apiInstance.GetCrmV3PropertiesObjectTypeGetAllWithHttpInfo(objectType, archived, properties);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoreApi.GetCrmV3PropertiesObjectTypeGetAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectType** | **string** |  |  |
| **archived** | **bool?** | Whether to return only results that have been archived. | [optional] [default to false] |
| **properties** | **string** |  | [optional]  |

### Return type

[**CollectionResponsePropertyNoPaging**](CollectionResponsePropertyNoPaging.md)

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

<a id="getcrmv3propertiesobjecttypepropertynamegetbyname"></a>
# **GetCrmV3PropertiesObjectTypePropertyNameGetByName**
> Property GetCrmV3PropertiesObjectTypePropertyNameGetByName (string objectType, string propertyName, bool? archived = null, string properties = null)

Read a property

Read a property identified by {propertyName}.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Properties.Api;
using HubSpot.Crm.Properties.Client;
using HubSpot.Crm.Properties.Model;

namespace Example
{
    public class GetCrmV3PropertiesObjectTypePropertyNameGetByNameExample
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

            var apiInstance = new CoreApi(config);
            var objectType = "objectType_example";  // string | 
            var propertyName = "propertyName_example";  // string | 
            var archived = false;  // bool? | Whether to return only results that have been archived. (optional)  (default to false)
            var properties = "properties_example";  // string |  (optional) 

            try
            {
                // Read a property
                Property result = apiInstance.GetCrmV3PropertiesObjectTypePropertyNameGetByName(objectType, propertyName, archived, properties);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.GetCrmV3PropertiesObjectTypePropertyNameGetByName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCrmV3PropertiesObjectTypePropertyNameGetByNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read a property
    ApiResponse<Property> response = apiInstance.GetCrmV3PropertiesObjectTypePropertyNameGetByNameWithHttpInfo(objectType, propertyName, archived, properties);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoreApi.GetCrmV3PropertiesObjectTypePropertyNameGetByNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectType** | **string** |  |  |
| **propertyName** | **string** |  |  |
| **archived** | **bool?** | Whether to return only results that have been archived. | [optional] [default to false] |
| **properties** | **string** |  | [optional]  |

### Return type

[**Property**](Property.md)

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

<a id="patchcrmv3propertiesobjecttypepropertynameupdate"></a>
# **PatchCrmV3PropertiesObjectTypePropertyNameUpdate**
> Property PatchCrmV3PropertiesObjectTypePropertyNameUpdate (string objectType, string propertyName, PropertyUpdate propertyUpdate)

Update a property

Perform a partial update of a property identified by {propertyName}. Provided fields will be overwritten.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Properties.Api;
using HubSpot.Crm.Properties.Client;
using HubSpot.Crm.Properties.Model;

namespace Example
{
    public class PatchCrmV3PropertiesObjectTypePropertyNameUpdateExample
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

            var apiInstance = new CoreApi(config);
            var objectType = "objectType_example";  // string | 
            var propertyName = "propertyName_example";  // string | 
            var propertyUpdate = new PropertyUpdate(); // PropertyUpdate | 

            try
            {
                // Update a property
                Property result = apiInstance.PatchCrmV3PropertiesObjectTypePropertyNameUpdate(objectType, propertyName, propertyUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.PatchCrmV3PropertiesObjectTypePropertyNameUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchCrmV3PropertiesObjectTypePropertyNameUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a property
    ApiResponse<Property> response = apiInstance.PatchCrmV3PropertiesObjectTypePropertyNameUpdateWithHttpInfo(objectType, propertyName, propertyUpdate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoreApi.PatchCrmV3PropertiesObjectTypePropertyNameUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectType** | **string** |  |  |
| **propertyName** | **string** |  |  |
| **propertyUpdate** | [**PropertyUpdate**](PropertyUpdate.md) |  |  |

### Return type

[**Property**](Property.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps_legacy](../README.md#private_apps_legacy), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcrmv3propertiesobjecttypecreate"></a>
# **PostCrmV3PropertiesObjectTypeCreate**
> Property PostCrmV3PropertiesObjectTypeCreate (string objectType, PropertyCreate propertyCreate)

Create a property

Create and return a copy of a new property for the specified object type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Properties.Api;
using HubSpot.Crm.Properties.Client;
using HubSpot.Crm.Properties.Model;

namespace Example
{
    public class PostCrmV3PropertiesObjectTypeCreateExample
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

            var apiInstance = new CoreApi(config);
            var objectType = "objectType_example";  // string | 
            var propertyCreate = new PropertyCreate(); // PropertyCreate | 

            try
            {
                // Create a property
                Property result = apiInstance.PostCrmV3PropertiesObjectTypeCreate(objectType, propertyCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.PostCrmV3PropertiesObjectTypeCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3PropertiesObjectTypeCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a property
    ApiResponse<Property> response = apiInstance.PostCrmV3PropertiesObjectTypeCreateWithHttpInfo(objectType, propertyCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoreApi.PostCrmV3PropertiesObjectTypeCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectType** | **string** |  |  |
| **propertyCreate** | [**PropertyCreate**](PropertyCreate.md) |  |  |

### Return type

[**Property**](Property.md)

### Authorization

[oauth2_legacy](../README.md#oauth2_legacy), [hapikey](../README.md#hapikey), [oauth2](../README.md#oauth2), [private_apps_legacy](../README.md#private_apps_legacy), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

