/*
 * Contacts
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
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
using HubSpot.Crm.Contacts.Client;
using HubSpot.Crm.Contacts.Client.Auth;
using HubSpot.Crm.Contacts.Model;

namespace HubSpot.Crm.Contacts.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISearchApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="HubSpot.Crm.Contacts.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicObjectSearchRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CollectionResponseWithTotalSimplePublicObjectForwardPaging</returns>
        CollectionResponseWithTotalSimplePublicObjectForwardPaging PostCrmV3ObjectsContactsSearchDoSearch(PublicObjectSearchRequest publicObjectSearchRequest, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HubSpot.Crm.Contacts.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicObjectSearchRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CollectionResponseWithTotalSimplePublicObjectForwardPaging</returns>
        ApiResponse<CollectionResponseWithTotalSimplePublicObjectForwardPaging> PostCrmV3ObjectsContactsSearchDoSearchWithHttpInfo(PublicObjectSearchRequest publicObjectSearchRequest, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISearchApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HubSpot.Crm.Contacts.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicObjectSearchRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CollectionResponseWithTotalSimplePublicObjectForwardPaging</returns>
        System.Threading.Tasks.Task<CollectionResponseWithTotalSimplePublicObjectForwardPaging> PostCrmV3ObjectsContactsSearchDoSearchAsync(PublicObjectSearchRequest publicObjectSearchRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HubSpot.Crm.Contacts.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicObjectSearchRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CollectionResponseWithTotalSimplePublicObjectForwardPaging)</returns>
        System.Threading.Tasks.Task<ApiResponse<CollectionResponseWithTotalSimplePublicObjectForwardPaging>> PostCrmV3ObjectsContactsSearchDoSearchWithHttpInfoAsync(PublicObjectSearchRequest publicObjectSearchRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISearchApi : ISearchApiSync, ISearchApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SearchApi : ISearchApi
    {
        private HubSpot.Crm.Contacts.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SearchApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SearchApi(string basePath)
        {
            this.Configuration = HubSpot.Crm.Contacts.Client.Configuration.MergeConfigurations(
                HubSpot.Crm.Contacts.Client.GlobalConfiguration.Instance,
                new HubSpot.Crm.Contacts.Client.Configuration { BasePath = basePath }
            );
            this.Client = new HubSpot.Crm.Contacts.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new HubSpot.Crm.Contacts.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = HubSpot.Crm.Contacts.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SearchApi(HubSpot.Crm.Contacts.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = HubSpot.Crm.Contacts.Client.Configuration.MergeConfigurations(
                HubSpot.Crm.Contacts.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new HubSpot.Crm.Contacts.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new HubSpot.Crm.Contacts.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = HubSpot.Crm.Contacts.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SearchApi(HubSpot.Crm.Contacts.Client.ISynchronousClient client, HubSpot.Crm.Contacts.Client.IAsynchronousClient asyncClient, HubSpot.Crm.Contacts.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = HubSpot.Crm.Contacts.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public HubSpot.Crm.Contacts.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public HubSpot.Crm.Contacts.Client.ISynchronousClient Client { get; set; }

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
        public HubSpot.Crm.Contacts.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public HubSpot.Crm.Contacts.Client.ExceptionFactory ExceptionFactory
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
        ///  
        /// </summary>
        /// <exception cref="HubSpot.Crm.Contacts.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicObjectSearchRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CollectionResponseWithTotalSimplePublicObjectForwardPaging</returns>
        public CollectionResponseWithTotalSimplePublicObjectForwardPaging PostCrmV3ObjectsContactsSearchDoSearch(PublicObjectSearchRequest publicObjectSearchRequest, int operationIndex = 0)
        {
            HubSpot.Crm.Contacts.Client.ApiResponse<CollectionResponseWithTotalSimplePublicObjectForwardPaging> localVarResponse = PostCrmV3ObjectsContactsSearchDoSearchWithHttpInfo(publicObjectSearchRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HubSpot.Crm.Contacts.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicObjectSearchRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CollectionResponseWithTotalSimplePublicObjectForwardPaging</returns>
        public HubSpot.Crm.Contacts.Client.ApiResponse<CollectionResponseWithTotalSimplePublicObjectForwardPaging> PostCrmV3ObjectsContactsSearchDoSearchWithHttpInfo(PublicObjectSearchRequest publicObjectSearchRequest, int operationIndex = 0)
        {
            // verify the required parameter 'publicObjectSearchRequest' is set
            if (publicObjectSearchRequest == null)
            {
                throw new HubSpot.Crm.Contacts.Client.ApiException(400, "Missing required parameter 'publicObjectSearchRequest' when calling SearchApi->PostCrmV3ObjectsContactsSearchDoSearch");
            }

            HubSpot.Crm.Contacts.Client.RequestOptions localVarRequestOptions = new HubSpot.Crm.Contacts.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "*/*"
            };

            var localVarContentType = HubSpot.Crm.Contacts.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = HubSpot.Crm.Contacts.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = publicObjectSearchRequest;

            localVarRequestOptions.Operation = "SearchApi.PostCrmV3ObjectsContactsSearchDoSearch";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (hapikey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("hapikey")))
            {
                localVarRequestOptions.QueryParameters.Add(HubSpot.Crm.Contacts.Client.ClientUtils.ParameterToMultiMap("", "hapikey", this.Configuration.GetApiKeyWithPrefix("hapikey")));
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
            var localVarResponse = this.Client.Post<CollectionResponseWithTotalSimplePublicObjectForwardPaging>("/crm/v3/objects/contacts/search", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostCrmV3ObjectsContactsSearchDoSearch", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HubSpot.Crm.Contacts.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicObjectSearchRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CollectionResponseWithTotalSimplePublicObjectForwardPaging</returns>
        public async System.Threading.Tasks.Task<CollectionResponseWithTotalSimplePublicObjectForwardPaging> PostCrmV3ObjectsContactsSearchDoSearchAsync(PublicObjectSearchRequest publicObjectSearchRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            HubSpot.Crm.Contacts.Client.ApiResponse<CollectionResponseWithTotalSimplePublicObjectForwardPaging> localVarResponse = await PostCrmV3ObjectsContactsSearchDoSearchWithHttpInfoAsync(publicObjectSearchRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="HubSpot.Crm.Contacts.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicObjectSearchRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CollectionResponseWithTotalSimplePublicObjectForwardPaging)</returns>
        public async System.Threading.Tasks.Task<HubSpot.Crm.Contacts.Client.ApiResponse<CollectionResponseWithTotalSimplePublicObjectForwardPaging>> PostCrmV3ObjectsContactsSearchDoSearchWithHttpInfoAsync(PublicObjectSearchRequest publicObjectSearchRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'publicObjectSearchRequest' is set
            if (publicObjectSearchRequest == null)
            {
                throw new HubSpot.Crm.Contacts.Client.ApiException(400, "Missing required parameter 'publicObjectSearchRequest' when calling SearchApi->PostCrmV3ObjectsContactsSearchDoSearch");
            }


            HubSpot.Crm.Contacts.Client.RequestOptions localVarRequestOptions = new HubSpot.Crm.Contacts.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "*/*"
            };

            var localVarContentType = HubSpot.Crm.Contacts.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = HubSpot.Crm.Contacts.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = publicObjectSearchRequest;

            localVarRequestOptions.Operation = "SearchApi.PostCrmV3ObjectsContactsSearchDoSearch";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (hapikey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("hapikey")))
            {
                localVarRequestOptions.QueryParameters.Add(HubSpot.Crm.Contacts.Client.ClientUtils.ParameterToMultiMap("", "hapikey", this.Configuration.GetApiKeyWithPrefix("hapikey")));
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
            var localVarResponse = await this.AsynchronousClient.PostAsync<CollectionResponseWithTotalSimplePublicObjectForwardPaging>("/crm/v3/objects/contacts/search", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostCrmV3ObjectsContactsSearchDoSearch", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
