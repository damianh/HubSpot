using HubSpot.Associations.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace HubSpot.Associations.Crm.V3.Associations.Item.Item.Batch.Read {
    /// <summary>
    /// Builds and executes requests for operations under \crm\v3\associations\{fromObjectType}\{toObjectType}\batch\read
    /// </summary>
    public class ReadRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new ReadRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReadRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/crm/v3/associations/{fromObjectType}/{toObjectType}/batch/read", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ReadRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReadRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/crm/v3/associations/{fromObjectType}/{toObjectType}/batch/read", rawUrl) {
        }
        /// <summary>
        /// Get the IDs of all `{toObjectType}` objects associated with those specified in the request body.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<BatchResponsePublicAssociationMulti?> PostAsync(BatchInputPublicObjectId body, Action<ReadRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<BatchResponsePublicAssociationMulti> PostAsync(BatchInputPublicObjectId body, Action<ReadRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<BatchResponsePublicAssociationMulti>(requestInfo, BatchResponsePublicAssociationMulti.CreateFromDiscriminatorValue, default, cancellationToken);
        }
        /// <summary>
        /// Get the IDs of all `{toObjectType}` objects associated with those specified in the request body.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(BatchInputPublicObjectId body, Action<ReadRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(BatchInputPublicObjectId body, Action<ReadRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
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
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ReadRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
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
