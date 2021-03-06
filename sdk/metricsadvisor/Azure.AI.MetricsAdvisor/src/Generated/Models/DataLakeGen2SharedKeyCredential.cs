// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The DataLakeGen2SharedKeyCredential. </summary>
    internal partial class DataLakeGen2SharedKeyCredential : DataSourceCredential
    {
        /// <summary> Initializes a new instance of DataLakeGen2SharedKeyCredential. </summary>
        /// <param name="dataSourceCredentialName"> Name of data source credential. </param>
        /// <param name="parameters"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSourceCredentialName"/> or <paramref name="parameters"/> is null. </exception>
        public DataLakeGen2SharedKeyCredential(string dataSourceCredentialName, DataLakeGen2SharedKeyParam parameters) : base(dataSourceCredentialName)
        {
            if (dataSourceCredentialName == null)
            {
                throw new ArgumentNullException(nameof(dataSourceCredentialName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            Parameters = parameters;
            DataSourceCredentialType = DataSourceCredentialType.DataLakeGen2SharedKey;
        }

        /// <summary> Initializes a new instance of DataLakeGen2SharedKeyCredential. </summary>
        /// <param name="dataSourceCredentialType"> Type of data source credential. </param>
        /// <param name="dataSourceCredentialId"> Unique id of data source credential. </param>
        /// <param name="dataSourceCredentialName"> Name of data source credential. </param>
        /// <param name="dataSourceCredentialDescription"> Description of data source credential. </param>
        /// <param name="parameters"> . </param>
        internal DataLakeGen2SharedKeyCredential(DataSourceCredentialType dataSourceCredentialType, Guid? dataSourceCredentialId, string dataSourceCredentialName, string dataSourceCredentialDescription, DataLakeGen2SharedKeyParam parameters) : base(dataSourceCredentialType, dataSourceCredentialId, dataSourceCredentialName, dataSourceCredentialDescription)
        {
            Parameters = parameters;
            DataSourceCredentialType = dataSourceCredentialType;
        }

        public DataLakeGen2SharedKeyParam Parameters { get; set; }
    }
}
