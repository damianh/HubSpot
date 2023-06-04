/*
 * Webhooks API
 *
 * Provides a way for apps to subscribe to certain change events in HubSpot. Once configured, apps will receive event payloads containing details about the changes at a specified target URL. There can only be one target URL for receiving event notifications per app.
 *
 * The version of the OpenAPI document: v3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using HubSpot.Webhooks.Webhooks.Model;
using HubSpot.Webhooks.Webhooks.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace HubSpot.Webhooks.Webhooks.Test.Model
{
    /// <summary>
    ///  Class for testing ErrorDetail
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ErrorDetailTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ErrorDetail
        //private ErrorDetail instance;

        public ErrorDetailTests()
        {
            // TODO uncomment below to create an instance of ErrorDetail
            //instance = new ErrorDetail();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ErrorDetail
        /// </summary>
        [Fact]
        public void ErrorDetailInstanceTest()
        {
            // TODO uncomment below to test "IsType" ErrorDetail
            //Assert.IsType<ErrorDetail>(instance);
        }


        /// <summary>
        /// Test the property 'Message'
        /// </summary>
        [Fact]
        public void MessageTest()
        {
            // TODO unit test for the property 'Message'
        }
        /// <summary>
        /// Test the property 'In'
        /// </summary>
        [Fact]
        public void InTest()
        {
            // TODO unit test for the property 'In'
        }
        /// <summary>
        /// Test the property 'Code'
        /// </summary>
        [Fact]
        public void CodeTest()
        {
            // TODO unit test for the property 'Code'
        }
        /// <summary>
        /// Test the property 'SubCategory'
        /// </summary>
        [Fact]
        public void SubCategoryTest()
        {
            // TODO unit test for the property 'SubCategory'
        }
        /// <summary>
        /// Test the property 'Context'
        /// </summary>
        [Fact]
        public void ContextTest()
        {
            // TODO unit test for the property 'Context'
        }

    }

}
