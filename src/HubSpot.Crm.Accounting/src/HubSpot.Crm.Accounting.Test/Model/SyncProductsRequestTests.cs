/*
 * Accounting Extension
 *
 * These APIs allow you to interact with HubSpot's Accounting Extension. It allows you to: * Specify the URLs that HubSpot will use when making webhook requests to your external accounting system. * Respond to webhook calls made to your external accounting system by HubSpot 
 *
 * The version of the OpenAPI document: v3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using HubSpot.Crm.Accounting.Model;
using HubSpot.Crm.Accounting.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace HubSpot.Crm.Accounting.Test.Model
{
    /// <summary>
    ///  Class for testing SyncProductsRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SyncProductsRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SyncProductsRequest
        //private SyncProductsRequest instance;

        public SyncProductsRequestTests()
        {
            // TODO uncomment below to create an instance of SyncProductsRequest
            //instance = new SyncProductsRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SyncProductsRequest
        /// </summary>
        [Fact]
        public void SyncProductsRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" SyncProductsRequest
            //Assert.IsType<SyncProductsRequest>(instance);
        }


        /// <summary>
        /// Test the property 'AccountId'
        /// </summary>
        [Fact]
        public void AccountIdTest()
        {
            // TODO unit test for the property 'AccountId'
        }
        /// <summary>
        /// Test the property 'Products'
        /// </summary>
        [Fact]
        public void ProductsTest()
        {
            // TODO unit test for the property 'Products'
        }

    }

}
