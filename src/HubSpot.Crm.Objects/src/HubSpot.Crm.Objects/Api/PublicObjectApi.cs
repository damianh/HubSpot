/*
 * CRM Objects
 *
 * CRM objects such as companies, contacts, deals, line items, products, tickets, and quotes are standard objects in HubSpot’s CRM. These core building blocks support custom properties, store critical information, and play a central role in the HubSpot application.  ## Supported Object Types  This API provides access to collections of CRM objects, which return a map of property names to values. Each object type has its own set of default properties, which can be found by exploring the [CRM Object Properties API](https://developers.hubspot.com/docs/methods/crm-properties/crm-properties-overview).  |Object Type |Properties returned by default | |- -|- -| | `companies` | `name`, `domain` | | `contacts` | `firstname`, `lastname`, `email` | | `deals` | `dealname`, `amount`, `closedate`, `pipeline`, `dealstage` | | `products` | `name`, `description`, `price` | | `tickets` | `content`, `hs_pipeline`, `hs_pipeline_stage`, `hs_ticket_category`, `hs_ticket_priority`, `subject` |  Find a list of all properties for an object type using the [CRM Object Properties](https://developers.hubspot.com/docs/methods/crm-properties/get-properties) API. e.g. `GET https://api.hubapi.com/properties/v2/companies/properties`. Change the properties returned in the response using the `properties` array in the request body.
 *
 * The version of the OpenAPI document: v3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using HubSpot.Crm.Objects.Client;
using HubSpot.Crm.Objects.Client.Auth;
using HubSpot.Crm.Objects.Model;

namespace HubSpot.Crm.Objects.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicObjectApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Merge two objects with same type
        /// </summary>
        /// <exception cref="HubSpot.Crm.Objects.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectType"></param>
        /// <param name="publicMergeInput"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SimplePublicObject</returns>
        SimplePublicObject PostCrmV3ObjectsObjectTypeMergeMerge(string objectType, PublicMergeInput publicMergeInput, int operationIndex = 0);

        /// <summary>
        /// Merge two objects with same type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HubSpot.Crm.Objects.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectType"></param>
        /// <param name="publicMergeInput"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SimplePublicObject</returns>
        ApiResponse<SimplePublicObject> PostCrmV3ObjectsObjectTypeMergeMergeWithHttpInfo(string objectType, PublicMergeInput publicMergeInput, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicObjectApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Merge two objects with same type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HubSpot.Crm.Objects.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectType"></param>
        /// <param name="publicMergeInput"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SimplePublicObject</returns>
        System.Threading.Tasks.Task<SimplePublicObject> PostCrmV3ObjectsObjectTypeMergeMergeAsync(string objectType, PublicMergeInput publicMergeInput, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Merge two objects with same type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HubSpot.Crm.Objects.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectType"></param>
        /// <param name="publicMergeInput"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SimplePublicObject)</returns>
        System.Threading.Tasks.Task<ApiResponse<SimplePublicObject>> PostCrmV3ObjectsObjectTypeMergeMergeWithHttpInfoAsync(string objectType, PublicMergeInput publicMergeInput, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicObjectApi : IPublicObjectApiSync, IPublicObjectApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PublicObjectApi : IPublicObjectApi
    {
        private HubSpot.Crm.Objects.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicObjectApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicObjectApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicObjectApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicObjectApi(string basePath)
        {
            this.Configuration = HubSpot.Crm.Objects.Client.Configuration.MergeConfigurations(
                HubSpot.Crm.Objects.Client.GlobalConfiguration.Instance,
                new HubSpot.Crm.Objects.Client.Configuration { BasePath = basePath }
            );
            this.Client = new HubSpot.Crm.Objects.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new HubSpot.Crm.Objects.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = HubSpot.Crm.Objects.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicObjectApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PublicObjectApi(HubSpot.Crm.Objects.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = HubSpot.Crm.Objects.Client.Configuration.MergeConfigurations(
                HubSpot.Crm.Objects.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new HubSpot.Crm.Objects.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new HubSpot.Crm.Objects.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = HubSpot.Crm.Objects.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicObjectApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PublicObjectApi(HubSpot.Crm.Objects.Client.ISynchronousClient client, HubSpot.Crm.Objects.Client.IAsynchronousClient asyncClient, HubSpot.Crm.Objects.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = HubSpot.Crm.Objects.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public HubSpot.Crm.Objects.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public HubSpot.Crm.Objects.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public HubSpot.Crm.Objects.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public HubSpot.Crm.Objects.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Merge two objects with same type 
        /// </summary>
        /// <exception cref="HubSpot.Crm.Objects.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectType"></param>
        /// <param name="publicMergeInput"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SimplePublicObject</returns>
        public SimplePublicObject PostCrmV3ObjectsObjectTypeMergeMerge(string objectType, PublicMergeInput publicMergeInput, int operationIndex = 0)
        {
            HubSpot.Crm.Objects.Client.ApiResponse<SimplePublicObject> localVarResponse = PostCrmV3ObjectsObjectTypeMergeMergeWithHttpInfo(objectType, publicMergeInput);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Merge two objects with same type 
        /// </summary>
        /// <exception cref="HubSpot.Crm.Objects.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectType"></param>
        /// <param name="publicMergeInput"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SimplePublicObject</returns>
        public HubSpot.Crm.Objects.Client.ApiResponse<SimplePublicObject> PostCrmV3ObjectsObjectTypeMergeMergeWithHttpInfo(string objectType, PublicMergeInput publicMergeInput, int operationIndex = 0)
        {
            // verify the required parameter 'objectType' is set
            if (objectType == null)
            {
                throw new HubSpot.Crm.Objects.Client.ApiException(400, "Missing required parameter 'objectType' when calling PublicObjectApi->PostCrmV3ObjectsObjectTypeMergeMerge");
            }

            // verify the required parameter 'publicMergeInput' is set
            if (publicMergeInput == null)
            {
                throw new HubSpot.Crm.Objects.Client.ApiException(400, "Missing required parameter 'publicMergeInput' when calling PublicObjectApi->PostCrmV3ObjectsObjectTypeMergeMerge");
            }

            HubSpot.Crm.Objects.Client.RequestOptions localVarRequestOptions = new HubSpot.Crm.Objects.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "*/*"
            };

            var localVarContentType = HubSpot.Crm.Objects.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = HubSpot.Crm.Objects.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("objectType", HubSpot.Crm.Objects.Client.ClientUtils.ParameterToString(objectType)); // path parameter
            localVarRequestOptions.Data = publicMergeInput;

            localVarRequestOptions.Operation = "PublicObjectApi.PostCrmV3ObjectsObjectTypeMergeMerge";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (oauth2_legacy) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }
            // authentication (hapikey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("hapikey")))
            {
                localVarRequestOptions.QueryParameters.Add(HubSpot.Crm.Objects.Client.ClientUtils.ParameterToMultiMap("", "hapikey", this.Configuration.GetApiKeyWithPrefix("hapikey")));
            }
            // authentication (oauth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }
            // authentication (private_apps_legacy) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("private-app-legacy")))
            {
                localVarRequestOptions.HeaderParameters.Add("private-app-legacy", this.Configuration.GetApiKeyWithPrefix("private-app-legacy"));
            }
            // authentication (private_apps) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("private-app")))
            {
                localVarRequestOptions.HeaderParameters.Add("private-app", this.Configuration.GetApiKeyWithPrefix("private-app"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<SimplePublicObject>("/crm/v3/objects/{objectType}/merge", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostCrmV3ObjectsObjectTypeMergeMerge", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Merge two objects with same type 
        /// </summary>
        /// <exception cref="HubSpot.Crm.Objects.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectType"></param>
        /// <param name="publicMergeInput"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SimplePublicObject</returns>
        public async System.Threading.Tasks.Task<SimplePublicObject> PostCrmV3ObjectsObjectTypeMergeMergeAsync(string objectType, PublicMergeInput publicMergeInput, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            HubSpot.Crm.Objects.Client.ApiResponse<SimplePublicObject> localVarResponse = await PostCrmV3ObjectsObjectTypeMergeMergeWithHttpInfoAsync(objectType, publicMergeInput, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Merge two objects with same type 
        /// </summary>
        /// <exception cref="HubSpot.Crm.Objects.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="objectType"></param>
        /// <param name="publicMergeInput"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SimplePublicObject)</returns>
        public async System.Threading.Tasks.Task<HubSpot.Crm.Objects.Client.ApiResponse<SimplePublicObject>> PostCrmV3ObjectsObjectTypeMergeMergeWithHttpInfoAsync(string objectType, PublicMergeInput publicMergeInput, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'objectType' is set
            if (objectType == null)
            {
                throw new HubSpot.Crm.Objects.Client.ApiException(400, "Missing required parameter 'objectType' when calling PublicObjectApi->PostCrmV3ObjectsObjectTypeMergeMerge");
            }

            // verify the required parameter 'publicMergeInput' is set
            if (publicMergeInput == null)
            {
                throw new HubSpot.Crm.Objects.Client.ApiException(400, "Missing required parameter 'publicMergeInput' when calling PublicObjectApi->PostCrmV3ObjectsObjectTypeMergeMerge");
            }


            HubSpot.Crm.Objects.Client.RequestOptions localVarRequestOptions = new HubSpot.Crm.Objects.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "*/*"
            };

            var localVarContentType = HubSpot.Crm.Objects.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = HubSpot.Crm.Objects.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("objectType", HubSpot.Crm.Objects.Client.ClientUtils.ParameterToString(objectType)); // path parameter
            localVarRequestOptions.Data = publicMergeInput;

            localVarRequestOptions.Operation = "PublicObjectApi.PostCrmV3ObjectsObjectTypeMergeMerge";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (oauth2_legacy) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }
            // authentication (hapikey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("hapikey")))
            {
                localVarRequestOptions.QueryParameters.Add(HubSpot.Crm.Objects.Client.ClientUtils.ParameterToMultiMap("", "hapikey", this.Configuration.GetApiKeyWithPrefix("hapikey")));
            }
            // authentication (oauth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }
            // authentication (private_apps_legacy) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("private-app-legacy")))
            {
                localVarRequestOptions.HeaderParameters.Add("private-app-legacy", this.Configuration.GetApiKeyWithPrefix("private-app-legacy"));
            }
            // authentication (private_apps) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("private-app")))
            {
                localVarRequestOptions.HeaderParameters.Add("private-app", this.Configuration.GetApiKeyWithPrefix("private-app"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<SimplePublicObject>("/crm/v3/objects/{objectType}/merge", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostCrmV3ObjectsObjectTypeMergeMerge", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
