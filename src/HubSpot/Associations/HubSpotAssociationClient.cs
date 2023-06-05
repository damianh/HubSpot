using HubSpot.Associations.Crm;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace HubSpot.Associations {
    /// <summary>
    /// The main entry point of the SDK, exposes the configuration and the fluent API.
    /// </summary>
    public class HubSpotAssociationClient : BaseRequestBuilder {
        /// <summary>The crm property</summary>
        public CrmRequestBuilder Crm { get =>
            new CrmRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new HubSpotAssociationClient and sets the default values.
        /// </summary>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public HubSpotAssociationClient(IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}", new Dictionary<string, object>()) {
            ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<TextSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<FormSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<TextParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<FormParseNodeFactory>();
            if (string.IsNullOrEmpty(RequestAdapter.BaseUrl)) {
                RequestAdapter.BaseUrl = "https://api.hubapi.com";
            }
            PathParameters.TryAdd("baseurl", RequestAdapter.BaseUrl);
        }
    }
}
