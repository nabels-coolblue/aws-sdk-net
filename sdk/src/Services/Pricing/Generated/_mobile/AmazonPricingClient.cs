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
 * Do not modify this file. This file is generated from the pricing-2017-10-15.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Pricing.Model;
using Amazon.Pricing.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Pricing
{
    /// <summary>
    /// Implementation for accessing Pricing
    ///
    /// AWS Price List Service API (AWS Price List Service) is a centralized and convenient
    /// way to programmatically query Amazon Web Services for services, products, and pricing
    /// information. The AWS Price List Service uses standardized product attributes such
    /// as <code>Location</code>, <code>Storage Class</code>, and <code>Operating System</code>,
    /// and provides prices at the SKU level. You can use the AWS Price List Service to build
    /// cost control and scenario planning tools, reconcile billing data, forecast future
    /// spend for budgeting purposes, and provide cost benefit analysis that compare your
    /// internal workloads with AWS.
    /// 
    ///  
    /// <para>
    /// Use <code>GetServices</code> without a service code to retrieve the service codes
    /// for all AWS services, then <code>GetServices</code> with a service code to retreive
    /// the attribute names for that service. After you have the service code and attribute
    /// names, you can use <code>GetAttributeValues</code> to see what values are available
    /// for an attribute. With the service code and an attribute name and value, you can use
    /// <code>GetProducts</code> to find specific products that you're interested in, such
    /// as an <code>AmazonEC2</code> instance, with a <code>Provisioned IOPS</code> <code>volumeType</code>.
    /// </para>
    ///  
    /// <para>
    /// Service Endpoint
    /// </para>
    ///  
    /// <para>
    /// AWS Price List Service API provides the following two endpoints:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// https://api.pricing.us-east-1.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// https://api.pricing.ap-south-1.amazonaws.com
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonPricingClient : AmazonServiceClient, IAmazonPricing
    {
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonPricingClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonPricingClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPricingConfig()) { }

        /// <summary>
        /// Constructs AmazonPricingClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonPricingClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPricingConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPricingClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonPricingClient Configuration Object</param>
        public AmazonPricingClient(AmazonPricingConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonPricingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPricingClient(AWSCredentials credentials)
            : this(credentials, new AmazonPricingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPricingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPricingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPricingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPricingClient with AWS Credentials and an
        /// AmazonPricingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPricingClient Configuration Object</param>
        public AmazonPricingClient(AWSCredentials credentials, AmazonPricingConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPricingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPricingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPricingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPricingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPricingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPricingConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPricingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPricingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPricingClient Configuration Object</param>
        public AmazonPricingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPricingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPricingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPricingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPricingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPricingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPricingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPricingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPricingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPricingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPricingClient Configuration Object</param>
        public AmazonPricingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPricingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 


        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  DescribeServices

        internal virtual DescribeServicesResponse DescribeServices(DescribeServicesRequest request)
        {
            var marshaller = new DescribeServicesRequestMarshaller();
            var unmarshaller = DescribeServicesResponseUnmarshaller.Instance;

            return Invoke<DescribeServicesRequest,DescribeServicesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/DescribeServices">REST API Reference for DescribeServices Operation</seealso>
        public virtual Task<DescribeServicesResponse> DescribeServicesAsync(DescribeServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeServicesRequestMarshaller();
            var unmarshaller = DescribeServicesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeServicesRequest,DescribeServicesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetAttributeValues

        internal virtual GetAttributeValuesResponse GetAttributeValues(GetAttributeValuesRequest request)
        {
            var marshaller = new GetAttributeValuesRequestMarshaller();
            var unmarshaller = GetAttributeValuesResponseUnmarshaller.Instance;

            return Invoke<GetAttributeValuesRequest,GetAttributeValuesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAttributeValues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAttributeValues operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/GetAttributeValues">REST API Reference for GetAttributeValues Operation</seealso>
        public virtual Task<GetAttributeValuesResponse> GetAttributeValuesAsync(GetAttributeValuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetAttributeValuesRequestMarshaller();
            var unmarshaller = GetAttributeValuesResponseUnmarshaller.Instance;

            return InvokeAsync<GetAttributeValuesRequest,GetAttributeValuesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetProducts

        internal virtual GetProductsResponse GetProducts(GetProductsRequest request)
        {
            var marshaller = new GetProductsRequestMarshaller();
            var unmarshaller = GetProductsResponseUnmarshaller.Instance;

            return Invoke<GetProductsRequest,GetProductsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetProducts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProducts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/GetProducts">REST API Reference for GetProducts Operation</seealso>
        public virtual Task<GetProductsResponse> GetProductsAsync(GetProductsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetProductsRequestMarshaller();
            var unmarshaller = GetProductsResponseUnmarshaller.Instance;

            return InvokeAsync<GetProductsRequest,GetProductsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}