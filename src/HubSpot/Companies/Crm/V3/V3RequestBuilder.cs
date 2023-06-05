using HubSpot.Companies.Crm.V3.Objects;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace HubSpot.Companies.Crm.V3 {
    /// <summary>
    /// Builds and executes requests for operations under \crm\v3
    /// </summary>
    public class V3RequestBuilder : BaseRequestBuilder {
        /// <summary>The objects property</summary>
        public ObjectsRequestBuilder Objects { get =>
            new ObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new V3RequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public V3RequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/crm/v3", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new V3RequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public V3RequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/crm/v3", rawUrl) {
        }
    }
}
