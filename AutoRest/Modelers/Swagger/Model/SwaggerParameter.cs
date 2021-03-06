// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using Newtonsoft.Json;

namespace Microsoft.Rest.Modeler.Swagger.Model
{
    /// <summary>
    /// Describes a single operation parameter.
    /// https://github.com/wordnik/swagger-spec/blob/master/versions/2.0.md#parameterObject
    /// </summary>
    [Serializable]
    public class SwaggerParameter : SwaggerObject
    {
        private bool _isRequired;
        public string Name { get; set; }

        public ParameterLocation In { get; set; }

        [JsonProperty(PropertyName = "$ref")]
        public string Reference { get; set; }

        [JsonProperty(PropertyName = "required")]
        public override bool IsRequired
        {
            get { return (_isRequired) || In == ParameterLocation.Path; }
            set { _isRequired = value; }
        }

        /// <summary>
        /// The schema defining the type used for the body parameter.
        /// </summary>
        public Schema Schema { get; set; }
    }
}
