using HubSpot.Crm.Crm.V3.Objects.Deals.Batch;
using HubSpot.Crm.Crm.V3.Objects.Deals.Item;
using HubSpot.Crm.Crm.V3.Objects.Deals.Search;
using HubSpot.Crm.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace HubSpot.Crm.Crm.V3.Objects.Deals {
    /// <summary>
    /// Builds and executes requests for operations under \crm\v3\objects\deals
    /// </summary>
    public class DealsRequestBuilder : BaseRequestBuilder {
        /// <summary>The batch property</summary>
        public BatchRequestBuilder Batch { get =>
            new BatchRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The search property</summary>
        public SearchRequestBuilder Search { get =>
            new SearchRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the HubSpot.Crm.crm.v3.objects.deals.item collection</summary>
        public WithDealItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("dealId", position);
            return new WithDealItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new DealsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DealsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/crm/v3/objects/deals{?limit*,after*,properties*,propertiesWithHistory*,associations*,archived*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new DealsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DealsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/crm/v3/objects/deals{?limit*,after*,properties*,propertiesWithHistory*,associations*,archived*}", rawUrl) {
        }
        /// <summary>
        /// Read a page of deals. Control what is returned via the `properties` query param.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CollectionResponseSimplePublicObjectWithAssociationsForwardPaging?> GetAsync(Action<DealsRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<CollectionResponseSimplePublicObjectWithAssociationsForwardPaging> GetAsync(Action<DealsRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<CollectionResponseSimplePublicObjectWithAssociationsForwardPaging>(requestInfo, CollectionResponseSimplePublicObjectWithAssociationsForwardPaging.CreateFromDiscriminatorValue, default, cancellationToken);
        }
        /// <summary>
        /// Create a deal with the given properties and return a copy of the object, including the ID. Documentation and examples for creating standard deals is provided.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<SimplePublicObject?> PostAsync(SimplePublicObjectInputForCreate body, Action<DealsRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<SimplePublicObject> PostAsync(SimplePublicObjectInputForCreate body, Action<DealsRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<SimplePublicObject>(requestInfo, SimplePublicObject.CreateFromDiscriminatorValue, default, cancellationToken);
        }
        /// <summary>
        /// Read a page of deals. Control what is returned via the `properties` query param.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<DealsRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<DealsRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new DealsRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Create a deal with the given properties and return a copy of the object, including the ID. Documentation and examples for creating standard deals is provided.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(SimplePublicObjectInputForCreate body, Action<DealsRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(SimplePublicObjectInputForCreate body, Action<DealsRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new DealsRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Read a page of deals. Control what is returned via the `properties` query param.
        /// </summary>
        public class DealsRequestBuilderGetQueryParameters {
            /// <summary>The paging cursor token of the last successfully read resource will be returned as the `paging.next.after` JSON property of a paged response containing more results.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? After { get; set; }
#nullable restore
#else
            public string After { get; set; }
#endif
            /// <summary>Whether to return only results that have been archived.</summary>
            public bool? Archived { get; set; }
            /// <summary>A comma separated list of object types to retrieve associated IDs for. If any of the specified associations do not exist, they will be ignored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? Associations { get; set; }
#nullable restore
#else
            public string[] Associations { get; set; }
#endif
            /// <summary>The maximum number of results to display per page.</summary>
            public int? Limit { get; set; }
            /// <summary>A comma separated list of the properties to be returned in the response. If any of the specified properties are not present on the requested object(s), they will be ignored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? Properties { get; set; }
#nullable restore
#else
            public string[] Properties { get; set; }
#endif
            /// <summary>A comma separated list of the properties to be returned along with their history of previous values. If any of the specified properties are not present on the requested object(s), they will be ignored. Usage of this parameter will reduce the maximum number of objects that can be read by a single request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? PropertiesWithHistory { get; set; }
#nullable restore
#else
            public string[] PropertiesWithHistory { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class DealsRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public DealsRequestBuilderGetQueryParameters QueryParameters { get; set; } = new DealsRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new dealsRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public DealsRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class DealsRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new dealsRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public DealsRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
