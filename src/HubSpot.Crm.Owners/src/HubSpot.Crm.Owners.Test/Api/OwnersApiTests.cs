/*
 * CRM Owners
 *
 * HubSpot uses **owners** to assign CRM objects to specific people in your organization. The endpoints described here are used to get a list of the owners that are available for an account. To assign an owner to an object, set the hubspot_owner_id property using the appropriate CRM object update or create a request.  If teams are available for your HubSpot tier, these endpoints will also indicate which team(s) an owner can access, as well as which team is the owner's primary team.
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

using HubSpot.Crm.Owners.Client;
using HubSpot.Crm.Owners.Api;
// uncomment below to import models
//using HubSpot.Crm.Owners.Model;

namespace HubSpot.Crm.Owners.Test.Api
{
    /// <summary>
    ///  Class for testing OwnersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OwnersApiTests : IDisposable
    {
        private OwnersApi instance;

        public OwnersApiTests()
        {
            instance = new OwnersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OwnersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' OwnersApi
            //Assert.IsType<OwnersApi>(instance);
        }

        /// <summary>
        /// Test GetCrmV3OwnersGetPage
        /// </summary>
        [Fact]
        public void GetCrmV3OwnersGetPageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string email = null;
            //string after = null;
            //int? limit = null;
            //bool? archived = null;
            //var response = instance.GetCrmV3OwnersGetPage(email, after, limit, archived);
            //Assert.IsType<CollectionResponsePublicOwnerForwardPaging>(response);
        }

        /// <summary>
        /// Test GetCrmV3OwnersOwnerIdGetById
        /// </summary>
        [Fact]
        public void GetCrmV3OwnersOwnerIdGetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int ownerId = null;
            //string idProperty = null;
            //bool? archived = null;
            //var response = instance.GetCrmV3OwnersOwnerIdGetById(ownerId, idProperty, archived);
            //Assert.IsType<PublicOwner>(response);
        }
    }
}
