/*
 * CRM Imports
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

using HubSpot.Crm.Imports.Client;
using HubSpot.Crm.Imports.Api;
// uncomment below to import models
//using HubSpot.Crm.Imports.Model;

namespace HubSpot.Crm.Imports.Test.Api
{
    /// <summary>
    ///  Class for testing PublicImportsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PublicImportsApiTests : IDisposable
    {
        private PublicImportsApi instance;

        public PublicImportsApiTests()
        {
            instance = new PublicImportsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PublicImportsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PublicImportsApi
            //Assert.IsType<PublicImportsApi>(instance);
        }

        /// <summary>
        /// Test GetCrmV3ImportsImportIdErrorsGetErrors
        /// </summary>
        [Fact]
        public void GetCrmV3ImportsImportIdErrorsGetErrorsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long importId = null;
            //string after = null;
            //int? limit = null;
            //var response = instance.GetCrmV3ImportsImportIdErrorsGetErrors(importId, after, limit);
            //Assert.IsType<CollectionResponsePublicImportErrorForwardPaging>(response);
        }
    }
}
