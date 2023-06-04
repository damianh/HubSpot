/*
 * Accounting Extension
 *
 * These APIs allow you to interact with HubSpot's Accounting Extension. It allows you to: * Specify the URLs that HubSpot will use when making webhook requests to your external accounting system. * Respond to webhook calls made to your external accounting system by HubSpot 
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

using HubSpot.Crm.Accounting.Client;
using HubSpot.Crm.Accounting.Api;
// uncomment below to import models
//using HubSpot.Crm.Accounting.Model;

namespace HubSpot.Crm.Accounting.Test.Api
{
    /// <summary>
    ///  Class for testing UserAccountsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UserAccountsApiTests : IDisposable
    {
        private UserAccountsApi instance;

        public UserAccountsApiTests()
        {
            instance = new UserAccountsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserAccountsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UserAccountsApi
            //Assert.IsType<UserAccountsApi>(instance);
        }

        /// <summary>
        /// Test DeleteCrmV3ExtensionsAccountingUserAccountsAccountIdArchive
        /// </summary>
        [Fact]
        public void DeleteCrmV3ExtensionsAccountingUserAccountsAccountIdArchiveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //instance.DeleteCrmV3ExtensionsAccountingUserAccountsAccountIdArchive(accountId);
        }

        /// <summary>
        /// Test PutCrmV3ExtensionsAccountingUserAccountsReplace
        /// </summary>
        [Fact]
        public void PutCrmV3ExtensionsAccountingUserAccountsReplaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateUserAccountRequestExternal createUserAccountRequestExternal = null;
            //instance.PutCrmV3ExtensionsAccountingUserAccountsReplace(createUserAccountRequestExternal);
        }
    }
}
