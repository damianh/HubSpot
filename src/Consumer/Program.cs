using HubSpot.Crm;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

var authProvider   = new AnonymousAuthenticationProvider();
var requestAdapter = new HttpClientRequestAdapter(authProvider);
var crmClient = new HubSpotCrmClient(requestAdapter);

var result = await crmClient.Crm.V3.Objects.Deals.GetAsync();
result.Results.ForEach(x => Console.WriteLine(x.Id));