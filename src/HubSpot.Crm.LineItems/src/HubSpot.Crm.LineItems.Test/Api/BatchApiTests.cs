/*
 * Line Items
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

using HubSpot.Crm.LineItems.Client;
using HubSpot.Crm.LineItems.Api;
// uncomment below to import models
//using HubSpot.Crm.LineItems.Model;

namespace HubSpot.Crm.LineItems.Test.Api
{
    /// <summary>
    ///  Class for testing BatchApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BatchApiTests : IDisposable
    {
        private BatchApi instance;

        public BatchApiTests()
        {
            instance = new BatchApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BatchApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BatchApi
            //Assert.IsType<BatchApi>(instance);
        }

        /// <summary>
        /// Test PostCrmV3ObjectsLineItemsBatchArchiveArchive
        /// </summary>
        [Fact]
        public void PostCrmV3ObjectsLineItemsBatchArchiveArchiveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BatchInputSimplePublicObjectId batchInputSimplePublicObjectId = null;
            //instance.PostCrmV3ObjectsLineItemsBatchArchiveArchive(batchInputSimplePublicObjectId);
        }

        /// <summary>
        /// Test PostCrmV3ObjectsLineItemsBatchCreateCreate
        /// </summary>
        [Fact]
        public void PostCrmV3ObjectsLineItemsBatchCreateCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BatchInputSimplePublicObjectInputForCreate batchInputSimplePublicObjectInputForCreate = null;
            //var response = instance.PostCrmV3ObjectsLineItemsBatchCreateCreate(batchInputSimplePublicObjectInputForCreate);
            //Assert.IsType<BatchResponseSimplePublicObject>(response);
        }

        /// <summary>
        /// Test PostCrmV3ObjectsLineItemsBatchReadRead
        /// </summary>
        [Fact]
        public void PostCrmV3ObjectsLineItemsBatchReadReadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BatchReadInputSimplePublicObjectId batchReadInputSimplePublicObjectId = null;
            //bool? archived = null;
            //var response = instance.PostCrmV3ObjectsLineItemsBatchReadRead(batchReadInputSimplePublicObjectId, archived);
            //Assert.IsType<BatchResponseSimplePublicObject>(response);
        }

        /// <summary>
        /// Test PostCrmV3ObjectsLineItemsBatchUpdateUpdate
        /// </summary>
        [Fact]
        public void PostCrmV3ObjectsLineItemsBatchUpdateUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BatchInputSimplePublicObjectBatchInput batchInputSimplePublicObjectBatchInput = null;
            //var response = instance.PostCrmV3ObjectsLineItemsBatchUpdateUpdate(batchInputSimplePublicObjectBatchInput);
            //Assert.IsType<BatchResponseSimplePublicObject>(response);
        }
    }
}
