using HubSpot.Crm.Crm.V3.Objects.Deals;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace HubSpot.Crm.Crm.V3.Objects {
    /// <summary>
    /// Builds and executes requests for operations under \crm\v3\objects
    /// </summary>
    public class ObjectsRequestBuilder : BaseRequestBuilder {
        /// <summary>The deals property</summary>
        public DealsRequestBuilder Deals { get =>
            new DealsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ObjectsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ObjectsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/crm/v3/objects", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ObjectsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ObjectsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/crm/v3/objects", rawUrl) {
        }
    }
}
