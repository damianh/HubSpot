/*
 * CRM Objects
 *
 * CRM objects such as companies, contacts, deals, line items, products, tickets, and quotes are standard objects in HubSpot’s CRM. These core building blocks support custom properties, store critical information, and play a central role in the HubSpot application.  ## Supported Object Types  This API provides access to collections of CRM objects, which return a map of property names to values. Each object type has its own set of default properties, which can be found by exploring the [CRM Object Properties API](https://developers.hubspot.com/docs/methods/crm-properties/crm-properties-overview).  |Object Type |Properties returned by default | |- -|- -| | `companies` | `name`, `domain` | | `contacts` | `firstname`, `lastname`, `email` | | `deals` | `dealname`, `amount`, `closedate`, `pipeline`, `dealstage` | | `products` | `name`, `description`, `price` | | `tickets` | `content`, `hs_pipeline`, `hs_pipeline_stage`, `hs_ticket_category`, `hs_ticket_priority`, `subject` |  Find a list of all properties for an object type using the [CRM Object Properties](https://developers.hubspot.com/docs/methods/crm-properties/get-properties) API. e.g. `GET https://api.hubapi.com/properties/v2/companies/properties`. Change the properties returned in the response using the `properties` array in the request body.
 *
 * The version of the OpenAPI document: v3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using HubSpot.Crm.Objects.Model;
using HubSpot.Crm.Objects.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace HubSpot.Crm.Objects.Test.Model
{
    /// <summary>
    ///  Class for testing PublicObjectSearchRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PublicObjectSearchRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PublicObjectSearchRequest
        //private PublicObjectSearchRequest instance;

        public PublicObjectSearchRequestTests()
        {
            // TODO uncomment below to create an instance of PublicObjectSearchRequest
            //instance = new PublicObjectSearchRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PublicObjectSearchRequest
        /// </summary>
        [Fact]
        public void PublicObjectSearchRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" PublicObjectSearchRequest
            //Assert.IsType<PublicObjectSearchRequest>(instance);
        }


        /// <summary>
        /// Test the property 'FilterGroups'
        /// </summary>
        [Fact]
        public void FilterGroupsTest()
        {
            // TODO unit test for the property 'FilterGroups'
        }
        /// <summary>
        /// Test the property 'Sorts'
        /// </summary>
        [Fact]
        public void SortsTest()
        {
            // TODO unit test for the property 'Sorts'
        }
        /// <summary>
        /// Test the property 'Query'
        /// </summary>
        [Fact]
        public void QueryTest()
        {
            // TODO unit test for the property 'Query'
        }
        /// <summary>
        /// Test the property 'Properties'
        /// </summary>
        [Fact]
        public void PropertiesTest()
        {
            // TODO unit test for the property 'Properties'
        }
        /// <summary>
        /// Test the property 'Limit'
        /// </summary>
        [Fact]
        public void LimitTest()
        {
            // TODO unit test for the property 'Limit'
        }
        /// <summary>
        /// Test the property 'After'
        /// </summary>
        [Fact]
        public void AfterTest()
        {
            // TODO unit test for the property 'After'
        }

    }

}
