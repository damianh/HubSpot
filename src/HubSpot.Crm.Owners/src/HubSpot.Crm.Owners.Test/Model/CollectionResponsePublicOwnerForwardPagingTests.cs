/*
 * CRM Owners
 *
 * HubSpot uses **owners** to assign CRM objects to specific people in your organization. The endpoints described here are used to get a list of the owners that are available for an account. To assign an owner to an object, set the hubspot_owner_id property using the appropriate CRM object update or create a request.  If teams are available for your HubSpot tier, these endpoints will also indicate which team(s) an owner can access, as well as which team is the owner's primary team.
 *
 * The version of the OpenAPI document: v3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using HubSpot.Crm.Owners.Model;
using HubSpot.Crm.Owners.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace HubSpot.Crm.Owners.Test.Model
{
    /// <summary>
    ///  Class for testing CollectionResponsePublicOwnerForwardPaging
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CollectionResponsePublicOwnerForwardPagingTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CollectionResponsePublicOwnerForwardPaging
        //private CollectionResponsePublicOwnerForwardPaging instance;

        public CollectionResponsePublicOwnerForwardPagingTests()
        {
            // TODO uncomment below to create an instance of CollectionResponsePublicOwnerForwardPaging
            //instance = new CollectionResponsePublicOwnerForwardPaging();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CollectionResponsePublicOwnerForwardPaging
        /// </summary>
        [Fact]
        public void CollectionResponsePublicOwnerForwardPagingInstanceTest()
        {
            // TODO uncomment below to test "IsType" CollectionResponsePublicOwnerForwardPaging
            //Assert.IsType<CollectionResponsePublicOwnerForwardPaging>(instance);
        }


        /// <summary>
        /// Test the property 'Results'
        /// </summary>
        [Fact]
        public void ResultsTest()
        {
            // TODO unit test for the property 'Results'
        }
        /// <summary>
        /// Test the property 'Paging'
        /// </summary>
        [Fact]
        public void PagingTest()
        {
            // TODO unit test for the property 'Paging'
        }

    }

}
