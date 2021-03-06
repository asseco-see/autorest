// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsLro.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Defines headers for putAsyncNoRetrycanceled operation.
    /// </summary>
    public partial class LROsPutAsyncNoRetrycanceledHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LROsPutAsyncNoRetrycanceledHeaders class.
        /// </summary>
        public LROsPutAsyncNoRetrycanceledHeaders() { }

        /// <summary>
        /// Initializes a new instance of the
        /// LROsPutAsyncNoRetrycanceledHeaders class.
        /// </summary>
        public LROsPutAsyncNoRetrycanceledHeaders(string azureAsyncOperation = default(string), string location = default(string))
        {
            AzureAsyncOperation = azureAsyncOperation;
            Location = location;
        }

        /// <summary>
        /// Location to poll for result status: will be set to
        /// /lro/putasync/noretry/canceled/operationResults/200
        /// </summary>
        [JsonProperty(PropertyName = "Azure-AsyncOperation")]
        public string AzureAsyncOperation { get; set; }

        /// <summary>
        /// Location to poll for result status: will be set to
        /// /lro/putasync/noretry/canceled/operationResults/200
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

    }
}
