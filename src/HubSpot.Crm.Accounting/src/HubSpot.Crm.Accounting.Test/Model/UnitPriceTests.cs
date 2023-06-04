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
    ///  Class for testing UnitPrice
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UnitPriceTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UnitPrice
        //private UnitPrice instance;

        public UnitPriceTests()
        {
            // TODO uncomment below to create an instance of UnitPrice
            //instance = new UnitPrice();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UnitPrice
        /// </summary>
        [Fact]
        public void UnitPriceInstanceTest()
        {
            // TODO uncomment below to test "IsType" UnitPrice
            //Assert.IsType<UnitPrice>(instance);
        }


        /// <summary>
        /// Test the property 'Amount'
        /// </summary>
        [Fact]
        public void AmountTest()
        {
            // TODO unit test for the property 'Amount'
        }
        /// <summary>
        /// Test the property 'TaxIncluded'
        /// </summary>
        [Fact]
        public void TaxIncludedTest()
        {
            // TODO unit test for the property 'TaxIncluded'
        }

    }

}
