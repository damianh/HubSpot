/*
 * Accounting Extension
 *
 * These APIs allow you to interact with HubSpot's Accounting Extension. It allows you to: * Specify the URLs that HubSpot will use when making webhook requests to your external accounting system. * Respond to webhook calls made to your external accounting system by HubSpot 
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
using HubSpot.Crm.Accounting.Client;
using HubSpot.Crm.Accounting.Client.Auth;
using HubSpot.Crm.Accounting.Model;

namespace HubSpot.Crm.Accounting.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettingsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get URL settings
        /// </summary>
        /// <remarks>
        /// Returns the URL settings for an accounting app with the specified ID.
        /// </remarks>
        /// <exception cref="HubSpot.Crm.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AccountingAppSettings</returns>
        AccountingAppSettings GetCrmV3ExtensionsAccountingSettingsAppIdGetById(int appId, int operationIndex = 0);

        /// <summary>
        /// Get URL settings
        /// </summary>
        /// <remarks>
        /// Returns the URL settings for an accounting app with the specified ID.
        /// </remarks>
        /// <exception cref="HubSpot.Crm.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AccountingAppSettings</returns>
        ApiResponse<AccountingAppSettings> GetCrmV3ExtensionsAccountingSettingsAppIdGetByIdWithHttpInfo(int appId, int operationIndex = 0);
        /// <summary>
        /// Add/Update URL Settings
        /// </summary>
        /// <remarks>
        /// Add/Update the URL settings for an accounting app with the specified ID.  All URLs must use the &#x60;https&#x60; protocol.
        /// </remarks>
        /// <exception cref="HubSpot.Crm.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="accountingAppSettings"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void PutCrmV3ExtensionsAccountingSettingsAppIdReplace(int appId, AccountingAppSettings accountingAppSettings, int operationIndex = 0);

        /// <summary>
        /// Add/Update URL Settings
        /// </summary>
        /// <remarks>
        /// Add/Update the URL settings for an accounting app with the specified ID.  All URLs must use the &#x60;https&#x60; protocol.
        /// </remarks>
        /// <exception cref="HubSpot.Crm.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="accountingAppSettings"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PutCrmV3ExtensionsAccountingSettingsAppIdReplaceWithHttpInfo(int appId, AccountingAppSettings accountingAppSettings, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettingsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get URL settings
        /// </summary>
        /// <remarks>
        /// Returns the URL settings for an accounting app with the specified ID.
        /// </remarks>
        /// <exception cref="HubSpot.Crm.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccountingAppSettings</returns>
        System.Threading.Tasks.Task<AccountingAppSettings> GetCrmV3ExtensionsAccountingSettingsAppIdGetByIdAsync(int appId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get URL settings
        /// </summary>
        /// <remarks>
        /// Returns the URL settings for an accounting app with the specified ID.
        /// </remarks>
        /// <exception cref="HubSpot.Crm.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccountingAppSettings)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountingAppSettings>> GetCrmV3ExtensionsAccountingSettingsAppIdGetByIdWithHttpInfoAsync(int appId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Add/Update URL Settings
        /// </summary>
        /// <remarks>
        /// Add/Update the URL settings for an accounting app with the specified ID.  All URLs must use the &#x60;https&#x60; protocol.
        /// </remarks>
        /// <exception cref="HubSpot.Crm.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="accountingAppSettings"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PutCrmV3ExtensionsAccountingSettingsAppIdReplaceAsync(int appId, AccountingAppSettings accountingAppSettings, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Add/Update URL Settings
        /// </summary>
        /// <remarks>
        /// Add/Update the URL settings for an accounting app with the specified ID.  All URLs must use the &#x60;https&#x60; protocol.
        /// </remarks>
        /// <exception cref="HubSpot.Crm.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="accountingAppSettings"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PutCrmV3ExtensionsAccountingSettingsAppIdReplaceWithHttpInfoAsync(int appId, AccountingAppSettings accountingAppSettings, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettingsApi : ISettingsApiSync, ISettingsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SettingsApi : ISettingsApi
    {
        private HubSpot.Crm.Accounting.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SettingsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SettingsApi(string basePath)
        {
            this.Configuration = HubSpot.Crm.Accounting.Client.Configuration.MergeConfigurations(
                HubSpot.Crm.Accounting.Client.GlobalConfiguration.Instance,
                new HubSpot.Crm.Accounting.Client.Configuration { BasePath = basePath }
            );
            this.Client = new HubSpot.Crm.Accounting.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new HubSpot.Crm.Accounting.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = HubSpot.Crm.Accounting.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SettingsApi(HubSpot.Crm.Accounting.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = HubSpot.Crm.Accounting.Client.Configuration.MergeConfigurations(
                HubSpot.Crm.Accounting.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new HubSpot.Crm.Accounting.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new HubSpot.Crm.Accounting.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = HubSpot.Crm.Accounting.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SettingsApi(HubSpot.Crm.Accounting.Client.ISynchronousClient client, HubSpot.Crm.Accounting.Client.IAsynchronousClient asyncClient, HubSpot.Crm.Accounting.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = HubSpot.Crm.Accounting.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public HubSpot.Crm.Accounting.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public HubSpot.Crm.Accounting.Client.ISynchronousClient Client { get; set; }

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
        public HubSpot.Crm.Accounting.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public HubSpot.Crm.Accounting.Client.ExceptionFactory ExceptionFactory
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
        /// Get URL settings Returns the URL settings for an accounting app with the specified ID.
        /// </summary>
        /// <exception cref="HubSpot.Crm.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AccountingAppSettings</returns>
        public AccountingAppSettings GetCrmV3ExtensionsAccountingSettingsAppIdGetById(int appId, int operationIndex = 0)
        {
            HubSpot.Crm.Accounting.Client.ApiResponse<AccountingAppSettings> localVarResponse = GetCrmV3ExtensionsAccountingSettingsAppIdGetByIdWithHttpInfo(appId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get URL settings Returns the URL settings for an accounting app with the specified ID.
        /// </summary>
        /// <exception cref="HubSpot.Crm.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AccountingAppSettings</returns>
        public HubSpot.Crm.Accounting.Client.ApiResponse<AccountingAppSettings> GetCrmV3ExtensionsAccountingSettingsAppIdGetByIdWithHttpInfo(int appId, int operationIndex = 0)
        {
            HubSpot.Crm.Accounting.Client.RequestOptions localVarRequestOptions = new HubSpot.Crm.Accounting.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "*/*"
            };

            var localVarContentType = HubSpot.Crm.Accounting.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = HubSpot.Crm.Accounting.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("appId", HubSpot.Crm.Accounting.Client.ClientUtils.ParameterToString(appId)); // path parameter

            localVarRequestOptions.Operation = "SettingsApi.GetCrmV3ExtensionsAccountingSettingsAppIdGetById";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (hapikey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("hapikey")))
            {
                localVarRequestOptions.QueryParameters.Add(HubSpot.Crm.Accounting.Client.ClientUtils.ParameterToMultiMap("", "hapikey", this.Configuration.GetApiKeyWithPrefix("hapikey")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<AccountingAppSettings>("/crm/v3/extensions/accounting/settings/{appId}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCrmV3ExtensionsAccountingSettingsAppIdGetById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get URL settings Returns the URL settings for an accounting app with the specified ID.
        /// </summary>
        /// <exception cref="HubSpot.Crm.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccountingAppSettings</returns>
        public async System.Threading.Tasks.Task<AccountingAppSettings> GetCrmV3ExtensionsAccountingSettingsAppIdGetByIdAsync(int appId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            HubSpot.Crm.Accounting.Client.ApiResponse<AccountingAppSettings> localVarResponse = await GetCrmV3ExtensionsAccountingSettingsAppIdGetByIdWithHttpInfoAsync(appId, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get URL settings Returns the URL settings for an accounting app with the specified ID.
        /// </summary>
        /// <exception cref="HubSpot.Crm.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccountingAppSettings)</returns>
        public async System.Threading.Tasks.Task<HubSpot.Crm.Accounting.Client.ApiResponse<AccountingAppSettings>> GetCrmV3ExtensionsAccountingSettingsAppIdGetByIdWithHttpInfoAsync(int appId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            HubSpot.Crm.Accounting.Client.RequestOptions localVarRequestOptions = new HubSpot.Crm.Accounting.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "*/*"
            };

            var localVarContentType = HubSpot.Crm.Accounting.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = HubSpot.Crm.Accounting.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("appId", HubSpot.Crm.Accounting.Client.ClientUtils.ParameterToString(appId)); // path parameter

            localVarRequestOptions.Operation = "SettingsApi.GetCrmV3ExtensionsAccountingSettingsAppIdGetById";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (hapikey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("hapikey")))
            {
                localVarRequestOptions.QueryParameters.Add(HubSpot.Crm.Accounting.Client.ClientUtils.ParameterToMultiMap("", "hapikey", this.Configuration.GetApiKeyWithPrefix("hapikey")));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<AccountingAppSettings>("/crm/v3/extensions/accounting/settings/{appId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCrmV3ExtensionsAccountingSettingsAppIdGetById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Add/Update URL Settings Add/Update the URL settings for an accounting app with the specified ID.  All URLs must use the &#x60;https&#x60; protocol.
        /// </summary>
        /// <exception cref="HubSpot.Crm.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="accountingAppSettings"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void PutCrmV3ExtensionsAccountingSettingsAppIdReplace(int appId, AccountingAppSettings accountingAppSettings, int operationIndex = 0)
        {
            PutCrmV3ExtensionsAccountingSettingsAppIdReplaceWithHttpInfo(appId, accountingAppSettings);
        }

        /// <summary>
        /// Add/Update URL Settings Add/Update the URL settings for an accounting app with the specified ID.  All URLs must use the &#x60;https&#x60; protocol.
        /// </summary>
        /// <exception cref="HubSpot.Crm.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="accountingAppSettings"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public HubSpot.Crm.Accounting.Client.ApiResponse<Object> PutCrmV3ExtensionsAccountingSettingsAppIdReplaceWithHttpInfo(int appId, AccountingAppSettings accountingAppSettings, int operationIndex = 0)
        {
            // verify the required parameter 'accountingAppSettings' is set
            if (accountingAppSettings == null)
            {
                throw new HubSpot.Crm.Accounting.Client.ApiException(400, "Missing required parameter 'accountingAppSettings' when calling SettingsApi->PutCrmV3ExtensionsAccountingSettingsAppIdReplace");
            }

            HubSpot.Crm.Accounting.Client.RequestOptions localVarRequestOptions = new HubSpot.Crm.Accounting.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "*/*"
            };

            var localVarContentType = HubSpot.Crm.Accounting.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = HubSpot.Crm.Accounting.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("appId", HubSpot.Crm.Accounting.Client.ClientUtils.ParameterToString(appId)); // path parameter
            localVarRequestOptions.Data = accountingAppSettings;

            localVarRequestOptions.Operation = "SettingsApi.PutCrmV3ExtensionsAccountingSettingsAppIdReplace";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (hapikey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("hapikey")))
            {
                localVarRequestOptions.QueryParameters.Add(HubSpot.Crm.Accounting.Client.ClientUtils.ParameterToMultiMap("", "hapikey", this.Configuration.GetApiKeyWithPrefix("hapikey")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put<Object>("/crm/v3/extensions/accounting/settings/{appId}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PutCrmV3ExtensionsAccountingSettingsAppIdReplace", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Add/Update URL Settings Add/Update the URL settings for an accounting app with the specified ID.  All URLs must use the &#x60;https&#x60; protocol.
        /// </summary>
        /// <exception cref="HubSpot.Crm.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="accountingAppSettings"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PutCrmV3ExtensionsAccountingSettingsAppIdReplaceAsync(int appId, AccountingAppSettings accountingAppSettings, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await PutCrmV3ExtensionsAccountingSettingsAppIdReplaceWithHttpInfoAsync(appId, accountingAppSettings, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Add/Update URL Settings Add/Update the URL settings for an accounting app with the specified ID.  All URLs must use the &#x60;https&#x60; protocol.
        /// </summary>
        /// <exception cref="HubSpot.Crm.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the accounting app. This is the identifier of the application created in your HubSpot developer portal.</param>
        /// <param name="accountingAppSettings"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<HubSpot.Crm.Accounting.Client.ApiResponse<Object>> PutCrmV3ExtensionsAccountingSettingsAppIdReplaceWithHttpInfoAsync(int appId, AccountingAppSettings accountingAppSettings, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'accountingAppSettings' is set
            if (accountingAppSettings == null)
            {
                throw new HubSpot.Crm.Accounting.Client.ApiException(400, "Missing required parameter 'accountingAppSettings' when calling SettingsApi->PutCrmV3ExtensionsAccountingSettingsAppIdReplace");
            }


            HubSpot.Crm.Accounting.Client.RequestOptions localVarRequestOptions = new HubSpot.Crm.Accounting.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "*/*"
            };

            var localVarContentType = HubSpot.Crm.Accounting.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = HubSpot.Crm.Accounting.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("appId", HubSpot.Crm.Accounting.Client.ClientUtils.ParameterToString(appId)); // path parameter
            localVarRequestOptions.Data = accountingAppSettings;

            localVarRequestOptions.Operation = "SettingsApi.PutCrmV3ExtensionsAccountingSettingsAppIdReplace";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (hapikey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("hapikey")))
            {
                localVarRequestOptions.QueryParameters.Add(HubSpot.Crm.Accounting.Client.ClientUtils.ParameterToMultiMap("", "hapikey", this.Configuration.GetApiKeyWithPrefix("hapikey")));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PutAsync<Object>("/crm/v3/extensions/accounting/settings/{appId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PutCrmV3ExtensionsAccountingSettingsAppIdReplace", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
