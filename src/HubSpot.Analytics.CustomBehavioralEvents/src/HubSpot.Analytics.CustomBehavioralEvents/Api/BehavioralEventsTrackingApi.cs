/*
 * Custom Behavioral Events API
 *
 * HTTP API for triggering instances of custom behavioral events
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
using HubSpot.Analytics.CustomBehavioralEvents.Client;
using HubSpot.Analytics.CustomBehavioralEvents.Client.Auth;
using HubSpot.Analytics.CustomBehavioralEvents.Model;

namespace HubSpot.Analytics.CustomBehavioralEvents.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBehavioralEventsTrackingApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Sends Custom Behavioral Event
        /// </summary>
        /// <remarks>
        /// Endpoint to send an instance of a behavioral event
        /// </remarks>
        /// <exception cref="HubSpot.Analytics.CustomBehavioralEvents.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="behavioralEventHttpCompletionRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void PostEventsV3Send(BehavioralEventHttpCompletionRequest behavioralEventHttpCompletionRequest, int operationIndex = 0);

        /// <summary>
        /// Sends Custom Behavioral Event
        /// </summary>
        /// <remarks>
        /// Endpoint to send an instance of a behavioral event
        /// </remarks>
        /// <exception cref="HubSpot.Analytics.CustomBehavioralEvents.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="behavioralEventHttpCompletionRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostEventsV3SendWithHttpInfo(BehavioralEventHttpCompletionRequest behavioralEventHttpCompletionRequest, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBehavioralEventsTrackingApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Sends Custom Behavioral Event
        /// </summary>
        /// <remarks>
        /// Endpoint to send an instance of a behavioral event
        /// </remarks>
        /// <exception cref="HubSpot.Analytics.CustomBehavioralEvents.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="behavioralEventHttpCompletionRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostEventsV3SendAsync(BehavioralEventHttpCompletionRequest behavioralEventHttpCompletionRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Sends Custom Behavioral Event
        /// </summary>
        /// <remarks>
        /// Endpoint to send an instance of a behavioral event
        /// </remarks>
        /// <exception cref="HubSpot.Analytics.CustomBehavioralEvents.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="behavioralEventHttpCompletionRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostEventsV3SendWithHttpInfoAsync(BehavioralEventHttpCompletionRequest behavioralEventHttpCompletionRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBehavioralEventsTrackingApi : IBehavioralEventsTrackingApiSync, IBehavioralEventsTrackingApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BehavioralEventsTrackingApi : IBehavioralEventsTrackingApi
    {
        private HubSpot.Analytics.CustomBehavioralEvents.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BehavioralEventsTrackingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BehavioralEventsTrackingApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BehavioralEventsTrackingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BehavioralEventsTrackingApi(string basePath)
        {
            this.Configuration = HubSpot.Analytics.CustomBehavioralEvents.Client.Configuration.MergeConfigurations(
                HubSpot.Analytics.CustomBehavioralEvents.Client.GlobalConfiguration.Instance,
                new HubSpot.Analytics.CustomBehavioralEvents.Client.Configuration { BasePath = basePath }
            );
            this.Client = new HubSpot.Analytics.CustomBehavioralEvents.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new HubSpot.Analytics.CustomBehavioralEvents.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = HubSpot.Analytics.CustomBehavioralEvents.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BehavioralEventsTrackingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BehavioralEventsTrackingApi(HubSpot.Analytics.CustomBehavioralEvents.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = HubSpot.Analytics.CustomBehavioralEvents.Client.Configuration.MergeConfigurations(
                HubSpot.Analytics.CustomBehavioralEvents.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new HubSpot.Analytics.CustomBehavioralEvents.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new HubSpot.Analytics.CustomBehavioralEvents.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = HubSpot.Analytics.CustomBehavioralEvents.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BehavioralEventsTrackingApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public BehavioralEventsTrackingApi(HubSpot.Analytics.CustomBehavioralEvents.Client.ISynchronousClient client, HubSpot.Analytics.CustomBehavioralEvents.Client.IAsynchronousClient asyncClient, HubSpot.Analytics.CustomBehavioralEvents.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = HubSpot.Analytics.CustomBehavioralEvents.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public HubSpot.Analytics.CustomBehavioralEvents.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public HubSpot.Analytics.CustomBehavioralEvents.Client.ISynchronousClient Client { get; set; }

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
        public HubSpot.Analytics.CustomBehavioralEvents.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public HubSpot.Analytics.CustomBehavioralEvents.Client.ExceptionFactory ExceptionFactory
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
        /// Sends Custom Behavioral Event Endpoint to send an instance of a behavioral event
        /// </summary>
        /// <exception cref="HubSpot.Analytics.CustomBehavioralEvents.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="behavioralEventHttpCompletionRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void PostEventsV3Send(BehavioralEventHttpCompletionRequest behavioralEventHttpCompletionRequest, int operationIndex = 0)
        {
            PostEventsV3SendWithHttpInfo(behavioralEventHttpCompletionRequest);
        }

        /// <summary>
        /// Sends Custom Behavioral Event Endpoint to send an instance of a behavioral event
        /// </summary>
        /// <exception cref="HubSpot.Analytics.CustomBehavioralEvents.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="behavioralEventHttpCompletionRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public HubSpot.Analytics.CustomBehavioralEvents.Client.ApiResponse<Object> PostEventsV3SendWithHttpInfo(BehavioralEventHttpCompletionRequest behavioralEventHttpCompletionRequest, int operationIndex = 0)
        {
            // verify the required parameter 'behavioralEventHttpCompletionRequest' is set
            if (behavioralEventHttpCompletionRequest == null)
            {
                throw new HubSpot.Analytics.CustomBehavioralEvents.Client.ApiException(400, "Missing required parameter 'behavioralEventHttpCompletionRequest' when calling BehavioralEventsTrackingApi->PostEventsV3Send");
            }

            HubSpot.Analytics.CustomBehavioralEvents.Client.RequestOptions localVarRequestOptions = new HubSpot.Analytics.CustomBehavioralEvents.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "*/*"
            };

            var localVarContentType = HubSpot.Analytics.CustomBehavioralEvents.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = HubSpot.Analytics.CustomBehavioralEvents.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = behavioralEventHttpCompletionRequest;

            localVarRequestOptions.Operation = "BehavioralEventsTrackingApi.PostEventsV3Send";
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
                localVarRequestOptions.QueryParameters.Add(HubSpot.Analytics.CustomBehavioralEvents.Client.ClientUtils.ParameterToMultiMap("", "hapikey", this.Configuration.GetApiKeyWithPrefix("hapikey")));
            }
            // authentication (private_apps_legacy) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("private-app-legacy")))
            {
                localVarRequestOptions.HeaderParameters.Add("private-app-legacy", this.Configuration.GetApiKeyWithPrefix("private-app-legacy"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/events/v3/send", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostEventsV3Send", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Sends Custom Behavioral Event Endpoint to send an instance of a behavioral event
        /// </summary>
        /// <exception cref="HubSpot.Analytics.CustomBehavioralEvents.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="behavioralEventHttpCompletionRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostEventsV3SendAsync(BehavioralEventHttpCompletionRequest behavioralEventHttpCompletionRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await PostEventsV3SendWithHttpInfoAsync(behavioralEventHttpCompletionRequest, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Sends Custom Behavioral Event Endpoint to send an instance of a behavioral event
        /// </summary>
        /// <exception cref="HubSpot.Analytics.CustomBehavioralEvents.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="behavioralEventHttpCompletionRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<HubSpot.Analytics.CustomBehavioralEvents.Client.ApiResponse<Object>> PostEventsV3SendWithHttpInfoAsync(BehavioralEventHttpCompletionRequest behavioralEventHttpCompletionRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'behavioralEventHttpCompletionRequest' is set
            if (behavioralEventHttpCompletionRequest == null)
            {
                throw new HubSpot.Analytics.CustomBehavioralEvents.Client.ApiException(400, "Missing required parameter 'behavioralEventHttpCompletionRequest' when calling BehavioralEventsTrackingApi->PostEventsV3Send");
            }


            HubSpot.Analytics.CustomBehavioralEvents.Client.RequestOptions localVarRequestOptions = new HubSpot.Analytics.CustomBehavioralEvents.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "*/*"
            };

            var localVarContentType = HubSpot.Analytics.CustomBehavioralEvents.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = HubSpot.Analytics.CustomBehavioralEvents.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = behavioralEventHttpCompletionRequest;

            localVarRequestOptions.Operation = "BehavioralEventsTrackingApi.PostEventsV3Send";
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
                localVarRequestOptions.QueryParameters.Add(HubSpot.Analytics.CustomBehavioralEvents.Client.ClientUtils.ParameterToMultiMap("", "hapikey", this.Configuration.GetApiKeyWithPrefix("hapikey")));
            }
            // authentication (private_apps_legacy) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("private-app-legacy")))
            {
                localVarRequestOptions.HeaderParameters.Add("private-app-legacy", this.Configuration.GetApiKeyWithPrefix("private-app-legacy"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/events/v3/send", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostEventsV3Send", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
