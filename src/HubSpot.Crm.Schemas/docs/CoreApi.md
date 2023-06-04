# HubSpot.Crm.Schemas.Api.CoreApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteCrmObjectSchemasV3SchemasObjectTypeArchive**](CoreApi.md#deletecrmobjectschemasv3schemasobjecttypearchive) | **DELETE** /crm/v3/schemas/{objectType} | Delete a schema |
| [**DeleteCrmObjectSchemasV3SchemasObjectTypeAssociationsAssociationIdentifierArchiveAssociation**](CoreApi.md#deletecrmobjectschemasv3schemasobjecttypeassociationsassociationidentifierarchiveassociation) | **DELETE** /crm/v3/schemas/{objectType}/associations/{associationIdentifier} | Remove an association |
| [**GetCrmObjectSchemasV3SchemasGetAll**](CoreApi.md#getcrmobjectschemasv3schemasgetall) | **GET** /crm/v3/schemas | Get all schemas |
| [**GetCrmObjectSchemasV3SchemasObjectTypeGetById**](CoreApi.md#getcrmobjectschemasv3schemasobjecttypegetbyid) | **GET** /crm/v3/schemas/{objectType} | Get an existing schema |
| [**PatchCrmObjectSchemasV3SchemasObjectTypeUpdate**](CoreApi.md#patchcrmobjectschemasv3schemasobjecttypeupdate) | **PATCH** /crm/v3/schemas/{objectType} | Update a schema |
| [**PostCrmObjectSchemasV3SchemasCreate**](CoreApi.md#postcrmobjectschemasv3schemascreate) | **POST** /crm/v3/schemas | Create a new schema |
| [**PostCrmObjectSchemasV3SchemasObjectTypeAssociationsCreateAssociation**](CoreApi.md#postcrmobjectschemasv3schemasobjecttypeassociationscreateassociation) | **POST** /crm/v3/schemas/{objectType}/associations | Create an association |

<a id="deletecrmobjectschemasv3schemasobjecttypearchive"></a>
# **DeleteCrmObjectSchemasV3SchemasObjectTypeArchive**
> void DeleteCrmObjectSchemasV3SchemasObjectTypeArchive (string objectType, bool? archived = null)

Delete a schema

Deletes a schema. Any existing records of this schema must be deleted **first**. Otherwise this call will fail.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Schemas.Api;
using HubSpot.Crm.Schemas.Client;
using HubSpot.Crm.Schemas.Model;

namespace Example
{
    public class DeleteCrmObjectSchemasV3SchemasObjectTypeArchiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");
            // Configure API key authorization: private_apps_legacy
            config.AddApiKey("private-app-legacy", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app-legacy", "Bearer");

            var apiInstance = new CoreApi(config);
            var objectType = "objectType_example";  // string | Fully qualified name or object type ID of your schema.
            var archived = false;  // bool? | Whether to return only results that have been archived. (optional)  (default to false)

            try
            {
                // Delete a schema
                apiInstance.DeleteCrmObjectSchemasV3SchemasObjectTypeArchive(objectType, archived);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.DeleteCrmObjectSchemasV3SchemasObjectTypeArchive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCrmObjectSchemasV3SchemasObjectTypeArchiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a schema
    apiInstance.DeleteCrmObjectSchemasV3SchemasObjectTypeArchiveWithHttpInfo(objectType, archived);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoreApi.DeleteCrmObjectSchemasV3SchemasObjectTypeArchiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectType** | **string** | Fully qualified name or object type ID of your schema. |  |
| **archived** | **bool?** | Whether to return only results that have been archived. | [optional] [default to false] |

### Return type

void (empty response body)

### Authorization

[hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecrmobjectschemasv3schemasobjecttypeassociationsassociationidentifierarchiveassociation"></a>
# **DeleteCrmObjectSchemasV3SchemasObjectTypeAssociationsAssociationIdentifierArchiveAssociation**
> void DeleteCrmObjectSchemasV3SchemasObjectTypeAssociationsAssociationIdentifierArchiveAssociation (string objectType, string associationIdentifier)

Remove an association

Removes an existing association from a schema.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Schemas.Api;
using HubSpot.Crm.Schemas.Client;
using HubSpot.Crm.Schemas.Model;

namespace Example
{
    public class DeleteCrmObjectSchemasV3SchemasObjectTypeAssociationsAssociationIdentifierArchiveAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");
            // Configure API key authorization: private_apps_legacy
            config.AddApiKey("private-app-legacy", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app-legacy", "Bearer");

            var apiInstance = new CoreApi(config);
            var objectType = "objectType_example";  // string | Fully qualified name or object type ID of your schema.
            var associationIdentifier = "associationIdentifier_example";  // string | Unique ID of the association to remove.

            try
            {
                // Remove an association
                apiInstance.DeleteCrmObjectSchemasV3SchemasObjectTypeAssociationsAssociationIdentifierArchiveAssociation(objectType, associationIdentifier);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.DeleteCrmObjectSchemasV3SchemasObjectTypeAssociationsAssociationIdentifierArchiveAssociation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCrmObjectSchemasV3SchemasObjectTypeAssociationsAssociationIdentifierArchiveAssociationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove an association
    apiInstance.DeleteCrmObjectSchemasV3SchemasObjectTypeAssociationsAssociationIdentifierArchiveAssociationWithHttpInfo(objectType, associationIdentifier);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoreApi.DeleteCrmObjectSchemasV3SchemasObjectTypeAssociationsAssociationIdentifierArchiveAssociationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectType** | **string** | Fully qualified name or object type ID of your schema. |  |
| **associationIdentifier** | **string** | Unique ID of the association to remove. |  |

### Return type

void (empty response body)

### Authorization

[hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcrmobjectschemasv3schemasgetall"></a>
# **GetCrmObjectSchemasV3SchemasGetAll**
> CollectionResponseObjectSchemaNoPaging GetCrmObjectSchemasV3SchemasGetAll (bool? archived = null)

Get all schemas

Returns all object schemas that have been defined for your account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Schemas.Api;
using HubSpot.Crm.Schemas.Client;
using HubSpot.Crm.Schemas.Model;

namespace Example
{
    public class GetCrmObjectSchemasV3SchemasGetAllExample
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

            var apiInstance = new CoreApi(config);
            var archived = false;  // bool? | Whether to return only results that have been archived. (optional)  (default to false)

            try
            {
                // Get all schemas
                CollectionResponseObjectSchemaNoPaging result = apiInstance.GetCrmObjectSchemasV3SchemasGetAll(archived);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.GetCrmObjectSchemasV3SchemasGetAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCrmObjectSchemasV3SchemasGetAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all schemas
    ApiResponse<CollectionResponseObjectSchemaNoPaging> response = apiInstance.GetCrmObjectSchemasV3SchemasGetAllWithHttpInfo(archived);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoreApi.GetCrmObjectSchemasV3SchemasGetAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **archived** | **bool?** | Whether to return only results that have been archived. | [optional] [default to false] |

### Return type

[**CollectionResponseObjectSchemaNoPaging**](CollectionResponseObjectSchemaNoPaging.md)

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

<a id="getcrmobjectschemasv3schemasobjecttypegetbyid"></a>
# **GetCrmObjectSchemasV3SchemasObjectTypeGetById**
> ObjectSchema GetCrmObjectSchemasV3SchemasObjectTypeGetById (string objectType)

Get an existing schema

Returns an existing object schema.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Schemas.Api;
using HubSpot.Crm.Schemas.Client;
using HubSpot.Crm.Schemas.Model;

namespace Example
{
    public class GetCrmObjectSchemasV3SchemasObjectTypeGetByIdExample
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

            var apiInstance = new CoreApi(config);
            var objectType = "objectType_example";  // string | Fully qualified name or object type ID of your schema.

            try
            {
                // Get an existing schema
                ObjectSchema result = apiInstance.GetCrmObjectSchemasV3SchemasObjectTypeGetById(objectType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.GetCrmObjectSchemasV3SchemasObjectTypeGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCrmObjectSchemasV3SchemasObjectTypeGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an existing schema
    ApiResponse<ObjectSchema> response = apiInstance.GetCrmObjectSchemasV3SchemasObjectTypeGetByIdWithHttpInfo(objectType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoreApi.GetCrmObjectSchemasV3SchemasObjectTypeGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectType** | **string** | Fully qualified name or object type ID of your schema. |  |

### Return type

[**ObjectSchema**](ObjectSchema.md)

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

<a id="patchcrmobjectschemasv3schemasobjecttypeupdate"></a>
# **PatchCrmObjectSchemasV3SchemasObjectTypeUpdate**
> ObjectTypeDefinition PatchCrmObjectSchemasV3SchemasObjectTypeUpdate (string objectType, ObjectTypeDefinitionPatch objectTypeDefinitionPatch)

Update a schema

Update the details for an existing object schema.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Schemas.Api;
using HubSpot.Crm.Schemas.Client;
using HubSpot.Crm.Schemas.Model;

namespace Example
{
    public class PatchCrmObjectSchemasV3SchemasObjectTypeUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");
            // Configure API key authorization: private_apps_legacy
            config.AddApiKey("private-app-legacy", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app-legacy", "Bearer");

            var apiInstance = new CoreApi(config);
            var objectType = "objectType_example";  // string | Fully qualified name or object type ID of your schema.
            var objectTypeDefinitionPatch = new ObjectTypeDefinitionPatch(); // ObjectTypeDefinitionPatch | Attributes to update in your schema.

            try
            {
                // Update a schema
                ObjectTypeDefinition result = apiInstance.PatchCrmObjectSchemasV3SchemasObjectTypeUpdate(objectType, objectTypeDefinitionPatch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.PatchCrmObjectSchemasV3SchemasObjectTypeUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchCrmObjectSchemasV3SchemasObjectTypeUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a schema
    ApiResponse<ObjectTypeDefinition> response = apiInstance.PatchCrmObjectSchemasV3SchemasObjectTypeUpdateWithHttpInfo(objectType, objectTypeDefinitionPatch);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoreApi.PatchCrmObjectSchemasV3SchemasObjectTypeUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectType** | **string** | Fully qualified name or object type ID of your schema. |  |
| **objectTypeDefinitionPatch** | [**ObjectTypeDefinitionPatch**](ObjectTypeDefinitionPatch.md) | Attributes to update in your schema. |  |

### Return type

[**ObjectTypeDefinition**](ObjectTypeDefinition.md)

### Authorization

[hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcrmobjectschemasv3schemascreate"></a>
# **PostCrmObjectSchemasV3SchemasCreate**
> ObjectSchema PostCrmObjectSchemasV3SchemasCreate (ObjectSchemaEgg objectSchemaEgg)

Create a new schema

Define a new object schema, along with custom properties and associations. The entire object schema, including its object type ID, properties, and associations will be returned in the response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Schemas.Api;
using HubSpot.Crm.Schemas.Client;
using HubSpot.Crm.Schemas.Model;

namespace Example
{
    public class PostCrmObjectSchemasV3SchemasCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");
            // Configure API key authorization: private_apps_legacy
            config.AddApiKey("private-app-legacy", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app-legacy", "Bearer");

            var apiInstance = new CoreApi(config);
            var objectSchemaEgg = new ObjectSchemaEgg(); // ObjectSchemaEgg | Object schema definition, including properties and associations.

            try
            {
                // Create a new schema
                ObjectSchema result = apiInstance.PostCrmObjectSchemasV3SchemasCreate(objectSchemaEgg);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.PostCrmObjectSchemasV3SchemasCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmObjectSchemasV3SchemasCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new schema
    ApiResponse<ObjectSchema> response = apiInstance.PostCrmObjectSchemasV3SchemasCreateWithHttpInfo(objectSchemaEgg);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoreApi.PostCrmObjectSchemasV3SchemasCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectSchemaEgg** | [**ObjectSchemaEgg**](ObjectSchemaEgg.md) | Object schema definition, including properties and associations. |  |

### Return type

[**ObjectSchema**](ObjectSchema.md)

### Authorization

[hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcrmobjectschemasv3schemasobjecttypeassociationscreateassociation"></a>
# **PostCrmObjectSchemasV3SchemasObjectTypeAssociationsCreateAssociation**
> AssociationDefinition PostCrmObjectSchemasV3SchemasObjectTypeAssociationsCreateAssociation (string objectType, AssociationDefinitionEgg associationDefinitionEgg)

Create an association

Defines a new association between the primary schema's object type and other object types.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubSpot.Crm.Schemas.Api;
using HubSpot.Crm.Schemas.Client;
using HubSpot.Crm.Schemas.Model;

namespace Example
{
    public class PostCrmObjectSchemasV3SchemasObjectTypeAssociationsCreateAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure API key authorization: hapikey
            config.AddApiKey("hapikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hapikey", "Bearer");
            // Configure API key authorization: private_apps_legacy
            config.AddApiKey("private-app-legacy", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app-legacy", "Bearer");

            var apiInstance = new CoreApi(config);
            var objectType = "objectType_example";  // string | Fully qualified name or object type ID of your schema.
            var associationDefinitionEgg = new AssociationDefinitionEgg(); // AssociationDefinitionEgg | Attributes that define the association.

            try
            {
                // Create an association
                AssociationDefinition result = apiInstance.PostCrmObjectSchemasV3SchemasObjectTypeAssociationsCreateAssociation(objectType, associationDefinitionEgg);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreApi.PostCrmObjectSchemasV3SchemasObjectTypeAssociationsCreateAssociation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmObjectSchemasV3SchemasObjectTypeAssociationsCreateAssociationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an association
    ApiResponse<AssociationDefinition> response = apiInstance.PostCrmObjectSchemasV3SchemasObjectTypeAssociationsCreateAssociationWithHttpInfo(objectType, associationDefinitionEgg);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoreApi.PostCrmObjectSchemasV3SchemasObjectTypeAssociationsCreateAssociationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectType** | **string** | Fully qualified name or object type ID of your schema. |  |
| **associationDefinitionEgg** | [**AssociationDefinitionEgg**](AssociationDefinitionEgg.md) | Attributes that define the association. |  |

### Return type

[**AssociationDefinition**](AssociationDefinition.md)

### Authorization

[hapikey](../README.md#hapikey), [private_apps_legacy](../README.md#private_apps_legacy)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

