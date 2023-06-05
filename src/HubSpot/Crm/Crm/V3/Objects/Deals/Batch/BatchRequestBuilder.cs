using HubSpot.Crm.Crm.V3.Objects.Deals.Batch.Read;
using HubSpot.Crm.Crm.V3.Objects.Deals.Batch.Update;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace HubSpot.Crm.Crm.V3.Objects.Deals.Batch {
    /// <summary>
    /// Builds and executes requests for operations under \crm\v3\objects\deals\batch
    /// </summary>
    public class BatchRequestBuilder : BaseRequestBuilder {
        /// <summary>The read property</summary>
        public ReadRequestBuilder Read { get =>
            new ReadRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The update property</summary>
        public UpdateRequestBuilder Update { get =>
            new UpdateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new BatchRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BatchRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/crm/v3/objects/deals/batch", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new BatchRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BatchRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/crm/v3/objects/deals/batch", rawUrl) {
        }
    }
}
