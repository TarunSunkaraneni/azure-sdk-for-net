// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of restorable dropped managed databases. </summary>
    public partial class RestorableDroppedManagedDatabaseListResult
    {
        /// <summary> Initializes a new instance of RestorableDroppedManagedDatabaseListResult. </summary>
        internal RestorableDroppedManagedDatabaseListResult()
        {
            Value = new ChangeTrackingList<RestorableDroppedManagedDatabase>();
        }

        /// <summary> Initializes a new instance of RestorableDroppedManagedDatabaseListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal RestorableDroppedManagedDatabaseListResult(IReadOnlyList<RestorableDroppedManagedDatabase> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<RestorableDroppedManagedDatabase> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}