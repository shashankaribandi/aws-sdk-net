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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.APIGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.APIGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TestInvokeMethod Request Marshaller
    /// </summary>       
    public class TestInvokeMethodRequestMarshaller : IMarshaller<IRequest, TestInvokeMethodRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((TestInvokeMethodRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(TestInvokeMethodRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.APIGateway");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "POST";

            string uriResourcePath = "/restapis/{restapi_id}/resources/{resource_id}/methods/{http_method}";
            uriResourcePath = uriResourcePath.Replace("{http_method}", publicRequest.IsSetHttpMethod() ? StringUtils.FromString(publicRequest.HttpMethod) : string.Empty);
            uriResourcePath = uriResourcePath.Replace("{resource_id}", publicRequest.IsSetResourceId() ? StringUtils.FromString(publicRequest.ResourceId) : string.Empty);
            uriResourcePath = uriResourcePath.Replace("{restapi_id}", publicRequest.IsSetRestApiId() ? StringUtils.FromString(publicRequest.RestApiId) : string.Empty);
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBody())
                {
                    context.Writer.WritePropertyName("body");
                    context.Writer.Write(publicRequest.Body);
                }

                if(publicRequest.IsSetClientCertificateId())
                {
                    context.Writer.WritePropertyName("clientCertificateId");
                    context.Writer.Write(publicRequest.ClientCertificateId);
                }

                if(publicRequest.IsSetHeaders())
                {
                    context.Writer.WritePropertyName("headers");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestHeadersKvp in publicRequest.Headers)
                    {
                        context.Writer.WritePropertyName(publicRequestHeadersKvp.Key);
                        var publicRequestHeadersValue = publicRequestHeadersKvp.Value;

                            context.Writer.Write(publicRequestHeadersValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPathWithQueryString())
                {
                    context.Writer.WritePropertyName("pathWithQueryString");
                    context.Writer.Write(publicRequest.PathWithQueryString);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}