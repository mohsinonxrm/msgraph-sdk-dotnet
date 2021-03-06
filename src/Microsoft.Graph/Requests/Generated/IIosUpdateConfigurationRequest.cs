// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IIosUpdateConfigurationRequest.
    /// </summary>
    public partial interface IIosUpdateConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosUpdateConfiguration using POST.
        /// </summary>
        /// <param name="iosUpdateConfigurationToCreate">The IosUpdateConfiguration to create.</param>
        /// <returns>The created IosUpdateConfiguration.</returns>
        System.Threading.Tasks.Task<IosUpdateConfiguration> CreateAsync(IosUpdateConfiguration iosUpdateConfigurationToCreate);        /// <summary>
        /// Creates the specified IosUpdateConfiguration using POST.
        /// </summary>
        /// <param name="iosUpdateConfigurationToCreate">The IosUpdateConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosUpdateConfiguration.</returns>
        System.Threading.Tasks.Task<IosUpdateConfiguration> CreateAsync(IosUpdateConfiguration iosUpdateConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IosUpdateConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified IosUpdateConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified IosUpdateConfiguration.
        /// </summary>
        /// <returns>The IosUpdateConfiguration.</returns>
        System.Threading.Tasks.Task<IosUpdateConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified IosUpdateConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosUpdateConfiguration.</returns>
        System.Threading.Tasks.Task<IosUpdateConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IosUpdateConfiguration using PATCH.
        /// </summary>
        /// <param name="iosUpdateConfigurationToUpdate">The IosUpdateConfiguration to update.</param>
        /// <returns>The updated IosUpdateConfiguration.</returns>
        System.Threading.Tasks.Task<IosUpdateConfiguration> UpdateAsync(IosUpdateConfiguration iosUpdateConfigurationToUpdate);

        /// <summary>
        /// Updates the specified IosUpdateConfiguration using PATCH.
        /// </summary>
        /// <param name="iosUpdateConfigurationToUpdate">The IosUpdateConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosUpdateConfiguration.</returns>
        System.Threading.Tasks.Task<IosUpdateConfiguration> UpdateAsync(IosUpdateConfiguration iosUpdateConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosUpdateConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosUpdateConfigurationRequest Expand(Expression<Func<IosUpdateConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosUpdateConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosUpdateConfigurationRequest Select(Expression<Func<IosUpdateConfiguration, object>> selectExpression);

    }
}
