/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class OrganizationStatus
    {
        private List<AccountStatus> _accountStatusList = new List<AccountStatus>();
        private string _organizationAwsServiceAccessStatus;
        private string _organizationId;
        private string _slrDeploymentStatus;

        /// <summary>
        /// Gets and sets the property AccountStatusList.
        /// </summary>
        public List<AccountStatus> AccountStatusList
        {
            get { return this._accountStatusList; }
            set { this._accountStatusList = value; }
        }

        // Check to see if AccountStatusList property is set
        internal bool IsSetAccountStatusList()
        {
            return this._accountStatusList != null && this._accountStatusList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationAwsServiceAccessStatus.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public string OrganizationAwsServiceAccessStatus
        {
            get { return this._organizationAwsServiceAccessStatus; }
            set { this._organizationAwsServiceAccessStatus = value; }
        }

        // Check to see if OrganizationAwsServiceAccessStatus property is set
        internal bool IsSetOrganizationAwsServiceAccessStatus()
        {
            return this._organizationAwsServiceAccessStatus != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationId.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }

        // Check to see if OrganizationId property is set
        internal bool IsSetOrganizationId()
        {
            return this._organizationId != null;
        }

        /// <summary>
        /// Gets and sets the property SLRDeploymentStatus.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public string SLRDeploymentStatus
        {
            get { return this._slrDeploymentStatus; }
            set { this._slrDeploymentStatus = value; }
        }

        // Check to see if SLRDeploymentStatus property is set
        internal bool IsSetSLRDeploymentStatus()
        {
            return this._slrDeploymentStatus != null;
        }

    }
}