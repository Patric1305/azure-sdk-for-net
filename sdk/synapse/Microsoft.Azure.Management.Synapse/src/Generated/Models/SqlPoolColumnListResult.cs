// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A list of Sql pool columns.
    /// </summary>
    public partial class SqlPoolColumnListResult
    {
        /// <summary>
        /// Initializes a new instance of the SqlPoolColumnListResult class.
        /// </summary>
        public SqlPoolColumnListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlPoolColumnListResult class.
        /// </summary>
        /// <param name="value">Array of results.</param>
        /// <param name="nextLink">Link to retrieve next page of
        /// results.</param>
        public SqlPoolColumnListResult(IList<SqlPoolColumn> value = default(IList<SqlPoolColumn>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets array of results.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<SqlPoolColumn> Value { get; private set; }

        /// <summary>
        /// Gets link to retrieve next page of results.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; private set; }

    }
}
