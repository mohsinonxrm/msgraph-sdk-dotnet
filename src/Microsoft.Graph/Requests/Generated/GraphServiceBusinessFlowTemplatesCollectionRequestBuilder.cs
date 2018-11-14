// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type GraphServiceBusinessFlowTemplatesCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceBusinessFlowTemplatesCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceBusinessFlowTemplatesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceBusinessFlowTemplatesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceBusinessFlowTemplatesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceBusinessFlowTemplatesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceBusinessFlowTemplatesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceBusinessFlowTemplatesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IBusinessFlowTemplateRequestBuilder"/> for the specified GraphServiceBusinessFlowTemplate.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceBusinessFlowTemplate.</param>
        /// <returns>The <see cref="IBusinessFlowTemplateRequestBuilder"/>.</returns>
        public IBusinessFlowTemplateRequestBuilder this[string id]
        {
            get
            {
                return new BusinessFlowTemplateRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}