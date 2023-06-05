using HubSpot.Associations.Crm.V3.Associations.Item.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace HubSpot.Associations.Crm.V3.Associations.Item {
    /// <summary>
    /// Builds and executes requests for operations under \crm\v3\associations\{fromObjectType}
    /// </summary>
    public class WithFromObjectTypeItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the HubSpot.Associations.crm.v3.associations.item.item collection</summary>
        public WithToObjectTypeItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("toObjectType", position);
            return new WithToObjectTypeItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new WithFromObjectTypeItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithFromObjectTypeItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/crm/v3/associations/{fromObjectType}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithFromObjectTypeItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithFromObjectTypeItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/crm/v3/associations/{fromObjectType}", rawUrl) {
        }
    }
}
