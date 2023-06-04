/*
 * Tickets
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using HubSpot.Crm.Tickets.Client;
using HubSpot.Crm.Tickets.Api;
// uncomment below to import models
//using HubSpot.Crm.Tickets.Model;

namespace HubSpot.Crm.Tickets.Test.Api
{
    /// <summary>
    ///  Class for testing SearchApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SearchApiTests : IDisposable
    {
        private SearchApi instance;

        public SearchApiTests()
        {
            instance = new SearchApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SearchApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SearchApi
            //Assert.IsType<SearchApi>(instance);
        }

        /// <summary>
        /// Test PostCrmV3ObjectsTicketsSearchDoSearch
        /// </summary>
        [Fact]
        public void PostCrmV3ObjectsTicketsSearchDoSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PublicObjectSearchRequest publicObjectSearchRequest = null;
            //var response = instance.PostCrmV3ObjectsTicketsSearchDoSearch(publicObjectSearchRequest);
            //Assert.IsType<CollectionResponseWithTotalSimplePublicObjectForwardPaging>(response);
        }
    }
}
