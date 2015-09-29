/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// The output for the <a>DescribeAccountLimits</a> action.
    /// </summary>
    public partial class DescribeAccountLimitsResponse : AmazonWebServiceResponse
    {
        private List<AccountLimit> _accountLimits = new List<AccountLimit>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AccountLimits. 
        /// <para>
        /// An account limit structure that contain a list of AWS CloudFormation account limits
        /// and their values.
        /// </para>
        /// </summary>
        public List<AccountLimit> AccountLimits
        {
            get { return this._accountLimits; }
            set { this._accountLimits = value; }
        }

        // Check to see if AccountLimits property is set
        internal bool IsSetAccountLimits()
        {
            return this._accountLimits != null && this._accountLimits.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A string that identifies the next page of limits. If no additional page exists, this
        /// value is null.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}