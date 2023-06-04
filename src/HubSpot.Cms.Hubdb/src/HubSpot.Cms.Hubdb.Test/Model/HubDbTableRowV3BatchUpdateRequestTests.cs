/*
 * HubDB endpoints
 *
 * HubDB is a relational data store that presents data as rows, columns, and cells in a table, much like a spreadsheet. HubDB tables can be added or modified [in the HubSpot CMS](https://knowledge.hubspot.com/cos-general/how-to-edit-hubdb-tables), but you can also use the API endpoints documented here. For more information on HubDB tables and using their data on a HubSpot site, see the [CMS developers site](https://designers.hubspot.com/docs/tools/hubdb). You can also see the [documentation for dynamic pages](https://designers.hubspot.com/docs/tutorials/how-to-build-dynamic-pages-with-hubdb) for more details about the `useForPages` field.  HubDB tables support `draft` and `published` versions. This allows you to update data in the table, either for testing or to allow for a manual approval process, without affecting any live pages using the existing data. Draft data can be reviewed, and published by a user working in HubSpot or published via the API. Draft data can also be discarded, allowing users to go back to the published version of the data without disrupting it. If a table is set to be `allowed for public access`, you can access the published version of the table and rows without any authentication by specifying the portal id via the query parameter `portalId`.
 *
 * The version of the OpenAPI document: v3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using HubSpot.Cms.Hubdb.Model;
using HubSpot.Cms.Hubdb.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace HubSpot.Cms.Hubdb.Test.Model
{
    /// <summary>
    ///  Class for testing HubDbTableRowV3BatchUpdateRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class HubDbTableRowV3BatchUpdateRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for HubDbTableRowV3BatchUpdateRequest
        //private HubDbTableRowV3BatchUpdateRequest instance;

        public HubDbTableRowV3BatchUpdateRequestTests()
        {
            // TODO uncomment below to create an instance of HubDbTableRowV3BatchUpdateRequest
            //instance = new HubDbTableRowV3BatchUpdateRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of HubDbTableRowV3BatchUpdateRequest
        /// </summary>
        [Fact]
        public void HubDbTableRowV3BatchUpdateRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" HubDbTableRowV3BatchUpdateRequest
            //Assert.IsType<HubDbTableRowV3BatchUpdateRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Path'
        /// </summary>
        [Fact]
        public void PathTest()
        {
            // TODO unit test for the property 'Path'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'ChildTableId'
        /// </summary>
        [Fact]
        public void ChildTableIdTest()
        {
            // TODO unit test for the property 'ChildTableId'
        }
        /// <summary>
        /// Test the property 'Values'
        /// </summary>
        [Fact]
        public void ValuesTest()
        {
            // TODO unit test for the property 'Values'
        }
        /// <summary>
        /// Test the property 'DisplayIndex'
        /// </summary>
        [Fact]
        public void DisplayIndexTest()
        {
            // TODO unit test for the property 'DisplayIndex'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }

    }

}
