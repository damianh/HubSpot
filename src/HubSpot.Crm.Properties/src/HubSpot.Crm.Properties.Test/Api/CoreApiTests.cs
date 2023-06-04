/*
 * Properties
 *
 * All HubSpot objects store data in default and custom properties. These endpoints provide access to read and modify object properties in HubSpot.
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

using HubSpot.Crm.Properties.Client;
using HubSpot.Crm.Properties.Api;
// uncomment below to import models
//using HubSpot.Crm.Properties.Model;

namespace HubSpot.Crm.Properties.Test.Api
{
    /// <summary>
    ///  Class for testing CoreApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CoreApiTests : IDisposable
    {
        private CoreApi instance;

        public CoreApiTests()
        {
            instance = new CoreApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CoreApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CoreApi
            //Assert.IsType<CoreApi>(instance);
        }

        /// <summary>
        /// Test DeleteCrmV3PropertiesObjectTypePropertyNameArchive
        /// </summary>
        [Fact]
        public void DeleteCrmV3PropertiesObjectTypePropertyNameArchiveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string objectType = null;
            //string propertyName = null;
            //instance.DeleteCrmV3PropertiesObjectTypePropertyNameArchive(objectType, propertyName);
        }

        /// <summary>
        /// Test GetCrmV3PropertiesObjectTypeGetAll
        /// </summary>
        [Fact]
        public void GetCrmV3PropertiesObjectTypeGetAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string objectType = null;
            //bool? archived = null;
            //string properties = null;
            //var response = instance.GetCrmV3PropertiesObjectTypeGetAll(objectType, archived, properties);
            //Assert.IsType<CollectionResponsePropertyNoPaging>(response);
        }

        /// <summary>
        /// Test GetCrmV3PropertiesObjectTypePropertyNameGetByName
        /// </summary>
        [Fact]
        public void GetCrmV3PropertiesObjectTypePropertyNameGetByNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string objectType = null;
            //string propertyName = null;
            //bool? archived = null;
            //string properties = null;
            //var response = instance.GetCrmV3PropertiesObjectTypePropertyNameGetByName(objectType, propertyName, archived, properties);
            //Assert.IsType<Property>(response);
        }

        /// <summary>
        /// Test PatchCrmV3PropertiesObjectTypePropertyNameUpdate
        /// </summary>
        [Fact]
        public void PatchCrmV3PropertiesObjectTypePropertyNameUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string objectType = null;
            //string propertyName = null;
            //PropertyUpdate propertyUpdate = null;
            //var response = instance.PatchCrmV3PropertiesObjectTypePropertyNameUpdate(objectType, propertyName, propertyUpdate);
            //Assert.IsType<Property>(response);
        }

        /// <summary>
        /// Test PostCrmV3PropertiesObjectTypeCreate
        /// </summary>
        [Fact]
        public void PostCrmV3PropertiesObjectTypeCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string objectType = null;
            //PropertyCreate propertyCreate = null;
            //var response = instance.PostCrmV3PropertiesObjectTypeCreate(objectType, propertyCreate);
            //Assert.IsType<Property>(response);
        }
    }
}
