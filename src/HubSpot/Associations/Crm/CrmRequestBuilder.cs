using HubSpot.Associations.Crm.V3;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace HubSpot.Associations.Crm {
    /// <summary>
    /// Builds and executes requests for operations under \crm
    /// </summary>
    public class CrmRequestBuilder : BaseRequestBuilder {
        /// <summary>The v3 property</summary>
        public V3RequestBuilder V3 { get =>
            new V3RequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new CrmRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CrmRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/crm", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new CrmRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CrmRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/crm", rawUrl) {
        }
    }
}
