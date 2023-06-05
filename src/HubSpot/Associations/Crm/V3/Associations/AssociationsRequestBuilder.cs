using HubSpot.Associations.Crm.V3.Associations.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace HubSpot.Associations.Crm.V3.Associations {
    /// <summary>
    /// Builds and executes requests for operations under \crm\v3\associations
    /// </summary>
    public class AssociationsRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the HubSpot.Associations.crm.v3.associations.item collection</summary>
        public WithFromObjectTypeItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("fromObjectType", position);
            return new WithFromObjectTypeItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new AssociationsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AssociationsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/crm/v3/associations", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new AssociationsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AssociationsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/crm/v3/associations", rawUrl) {
        }
    }
}
