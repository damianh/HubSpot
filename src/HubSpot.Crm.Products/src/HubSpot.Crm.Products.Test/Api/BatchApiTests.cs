/*
 * Products
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

using HubSpot.Crm.Products.Client;
using HubSpot.Crm.Products.Api;
// uncomment below to import models
//using HubSpot.Crm.Products.Model;

namespace HubSpot.Crm.Products.Test.Api
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
        /// Test PostCrmV3ObjectsProductsBatchArchiveArchive
        /// </summary>
        [Fact]
        public void PostCrmV3ObjectsProductsBatchArchiveArchiveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BatchInputSimplePublicObjectId batchInputSimplePublicObjectId = null;
            //instance.PostCrmV3ObjectsProductsBatchArchiveArchive(batchInputSimplePublicObjectId);
        }

        /// <summary>
        /// Test PostCrmV3ObjectsProductsBatchCreateCreate
        /// </summary>
        [Fact]
        public void PostCrmV3ObjectsProductsBatchCreateCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BatchInputSimplePublicObjectInputForCreate batchInputSimplePublicObjectInputForCreate = null;
            //var response = instance.PostCrmV3ObjectsProductsBatchCreateCreate(batchInputSimplePublicObjectInputForCreate);
            //Assert.IsType<BatchResponseSimplePublicObject>(response);
        }

        /// <summary>
        /// Test PostCrmV3ObjectsProductsBatchReadRead
        /// </summary>
        [Fact]
        public void PostCrmV3ObjectsProductsBatchReadReadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BatchReadInputSimplePublicObjectId batchReadInputSimplePublicObjectId = null;
            //bool? archived = null;
            //var response = instance.PostCrmV3ObjectsProductsBatchReadRead(batchReadInputSimplePublicObjectId, archived);
            //Assert.IsType<BatchResponseSimplePublicObject>(response);
        }

        /// <summary>
        /// Test PostCrmV3ObjectsProductsBatchUpdateUpdate
        /// </summary>
        [Fact]
        public void PostCrmV3ObjectsProductsBatchUpdateUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BatchInputSimplePublicObjectBatchInput batchInputSimplePublicObjectBatchInput = null;
            //var response = instance.PostCrmV3ObjectsProductsBatchUpdateUpdate(batchInputSimplePublicObjectBatchInput);
            //Assert.IsType<BatchResponseSimplePublicObject>(response);
        }
    }
}
