using HubSpot.Crm.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace HubSpot.Crm.Crm.V3.Objects.Deals.Item {
    /// <summary>
    /// Builds and executes requests for operations under \crm\v3\objects\deals\{dealId}
    /// </summary>
    public class WithDealItemRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new WithDealItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithDealItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/crm/v3/objects/deals/{dealId}{?properties*,propertiesWithHistory*,associations*,archived*,idProperty*,idProperty*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithDealItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithDealItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/crm/v3/objects/deals/{dealId}{?properties*,propertiesWithHistory*,associations*,archived*,idProperty*,idProperty*}", rawUrl) {
        }
        /// <summary>
        /// Move an Object identified by `{dealId}` to the recycling bin.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<WithDealItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<WithDealItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken);
        }
        /// <summary>
        /// Read an Object identified by `{dealId}`. `{dealId}` refers to the internal object ID by default, or optionally any unique property value as specified by the `idProperty` query param.  Control what is returned via the `properties` query param.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<SimplePublicObjectWithAssociations?> GetAsync(Action<WithDealItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<SimplePublicObjectWithAssociations> GetAsync(Action<WithDealItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<SimplePublicObjectWithAssociations>(requestInfo, SimplePublicObjectWithAssociations.CreateFromDiscriminatorValue, default, cancellationToken);
        }
        /// <summary>
        /// Perform a partial update of an Object identified by `{dealId}`. `{dealId}` refers to the internal object ID by default, or optionally any unique property value as specified by the `idProperty` query param. Provided property values will be overwritten. Read-only and non-existent properties will be ignored. Properties values can be cleared by passing an empty string.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<SimplePublicObject?> PatchAsync(SimplePublicObjectInput body, Action<WithDealItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<SimplePublicObject> PatchAsync(SimplePublicObjectInput body, Action<WithDealItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<SimplePublicObject>(requestInfo, SimplePublicObject.CreateFromDiscriminatorValue, default, cancellationToken);
        }
        /// <summary>
        /// Move an Object identified by `{dealId}` to the recycling bin.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<WithDealItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<WithDealItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new WithDealItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Read an Object identified by `{dealId}`. `{dealId}` refers to the internal object ID by default, or optionally any unique property value as specified by the `idProperty` query param.  Control what is returned via the `properties` query param.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<WithDealItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<WithDealItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new WithDealItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Perform a partial update of an Object identified by `{dealId}`. `{dealId}` refers to the internal object ID by default, or optionally any unique property value as specified by the `idProperty` query param. Provided property values will be overwritten. Read-only and non-existent properties will be ignored. Properties values can be cleared by passing an empty string.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(SimplePublicObjectInput body, Action<WithDealItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(SimplePublicObjectInput body, Action<WithDealItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new WithDealItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class WithDealItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new WithDealItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public WithDealItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Read an Object identified by `{dealId}`. `{dealId}` refers to the internal object ID by default, or optionally any unique property value as specified by the `idProperty` query param.  Control what is returned via the `properties` query param.
        /// </summary>
        public class WithDealItemRequestBuilderGetQueryParameters {
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
            /// <summary>The name of a property whose values are unique for this object type</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? IdProperty { get; set; }
#nullable restore
#else
            public string IdProperty { get; set; }
#endif
            /// <summary>A comma separated list of the properties to be returned in the response. If any of the specified properties are not present on the requested object(s), they will be ignored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? Properties { get; set; }
#nullable restore
#else
            public string[] Properties { get; set; }
#endif
            /// <summary>A comma separated list of the properties to be returned along with their history of previous values. If any of the specified properties are not present on the requested object(s), they will be ignored.</summary>
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
        public class WithDealItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public WithDealItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new WithDealItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new WithDealItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public WithDealItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Perform a partial update of an Object identified by `{dealId}`. `{dealId}` refers to the internal object ID by default, or optionally any unique property value as specified by the `idProperty` query param. Provided property values will be overwritten. Read-only and non-existent properties will be ignored. Properties values can be cleared by passing an empty string.
        /// </summary>
        public class WithDealItemRequestBuilderPatchQueryParameters {
            /// <summary>The name of a property whose values are unique for this object type</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? IdProperty { get; set; }
#nullable restore
#else
            public string IdProperty { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class WithDealItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public WithDealItemRequestBuilderPatchQueryParameters QueryParameters { get; set; } = new WithDealItemRequestBuilderPatchQueryParameters();
            /// <summary>
            /// Instantiates a new WithDealItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public WithDealItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
