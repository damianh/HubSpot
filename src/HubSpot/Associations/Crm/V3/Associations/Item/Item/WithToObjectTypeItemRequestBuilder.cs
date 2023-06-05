using HubSpot.Associations.Crm.V3.Associations.Item.Item.Batch;
using HubSpot.Associations.Crm.V3.Associations.Item.Item.Types;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace HubSpot.Associations.Crm.V3.Associations.Item.Item {
    /// <summary>
    /// Builds and executes requests for operations under \crm\v3\associations\{fromObjectType}\{toObjectType}
    /// </summary>
    public class WithToObjectTypeItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The batch property</summary>
        public BatchRequestBuilder Batch { get =>
            new BatchRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The types property</summary>
        public TypesRequestBuilder Types { get =>
            new TypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new WithToObjectTypeItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithToObjectTypeItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/crm/v3/associations/{fromObjectType}/{toObjectType}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithToObjectTypeItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithToObjectTypeItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/crm/v3/associations/{fromObjectType}/{toObjectType}", rawUrl) {
        }
    }
}
