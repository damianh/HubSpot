using HubSpot.Companies.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace HubSpot.Companies.Crm.V3.Objects.Companies.Batch.Read {
    /// <summary>
    /// Builds and executes requests for operations under \crm\v3\objects\companies\batch\read
    /// </summary>
    public class ReadRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new ReadRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReadRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/crm/v3/objects/companies/batch/read{?archived*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ReadRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReadRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/crm/v3/objects/companies/batch/read{?archived*}", rawUrl) {
        }
        /// <summary>
        /// Read a batch of companies by internal ID, or unique property values
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<BatchResponseSimplePublicObject?> PostAsync(BatchReadInputSimplePublicObjectId body, Action<ReadRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<BatchResponseSimplePublicObject> PostAsync(BatchReadInputSimplePublicObjectId body, Action<ReadRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<BatchResponseSimplePublicObject>(requestInfo, BatchResponseSimplePublicObject.CreateFromDiscriminatorValue, default, cancellationToken);
        }
        /// <summary>
        /// Read a batch of companies by internal ID, or unique property values
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(BatchReadInputSimplePublicObjectId body, Action<ReadRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(BatchReadInputSimplePublicObjectId body, Action<ReadRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new ReadRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Read a batch of companies by internal ID, or unique property values
        /// </summary>
        public class ReadRequestBuilderPostQueryParameters {
            /// <summary>Whether to return only results that have been archived.</summary>
            public bool? Archived { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ReadRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public ReadRequestBuilderPostQueryParameters QueryParameters { get; set; } = new ReadRequestBuilderPostQueryParameters();
            /// <summary>
            /// Instantiates a new readRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public ReadRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
