using HubSpot.Companies.Crm.V3.Objects.Companies.Batch.Create;
using HubSpot.Companies.Crm.V3.Objects.Companies.Batch.Read;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace HubSpot.Companies.Crm.V3.Objects.Companies.Batch {
    /// <summary>
    /// Builds and executes requests for operations under \crm\v3\objects\companies\batch
    /// </summary>
    public class BatchRequestBuilder : BaseRequestBuilder {
        /// <summary>The create property</summary>
        public CreateRequestBuilder Create { get =>
            new CreateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The read property</summary>
        public ReadRequestBuilder Read { get =>
            new ReadRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new BatchRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BatchRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/crm/v3/objects/companies/batch", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new BatchRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BatchRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/crm/v3/objects/companies/batch", rawUrl) {
        }
    }
}
