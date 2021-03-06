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
    /// The interface IDeviceComplianceUserOverviewRequest.
    /// </summary>
    public partial interface IDeviceComplianceUserOverviewRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceComplianceUserOverview using POST.
        /// </summary>
        /// <param name="deviceComplianceUserOverviewToCreate">The DeviceComplianceUserOverview to create.</param>
        /// <returns>The created DeviceComplianceUserOverview.</returns>
        System.Threading.Tasks.Task<DeviceComplianceUserOverview> CreateAsync(DeviceComplianceUserOverview deviceComplianceUserOverviewToCreate);        /// <summary>
        /// Creates the specified DeviceComplianceUserOverview using POST.
        /// </summary>
        /// <param name="deviceComplianceUserOverviewToCreate">The DeviceComplianceUserOverview to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceComplianceUserOverview.</returns>
        System.Threading.Tasks.Task<DeviceComplianceUserOverview> CreateAsync(DeviceComplianceUserOverview deviceComplianceUserOverviewToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceComplianceUserOverview.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceComplianceUserOverview.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceComplianceUserOverview.
        /// </summary>
        /// <returns>The DeviceComplianceUserOverview.</returns>
        System.Threading.Tasks.Task<DeviceComplianceUserOverview> GetAsync();

        /// <summary>
        /// Gets the specified DeviceComplianceUserOverview.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceComplianceUserOverview.</returns>
        System.Threading.Tasks.Task<DeviceComplianceUserOverview> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceComplianceUserOverview using PATCH.
        /// </summary>
        /// <param name="deviceComplianceUserOverviewToUpdate">The DeviceComplianceUserOverview to update.</param>
        /// <returns>The updated DeviceComplianceUserOverview.</returns>
        System.Threading.Tasks.Task<DeviceComplianceUserOverview> UpdateAsync(DeviceComplianceUserOverview deviceComplianceUserOverviewToUpdate);

        /// <summary>
        /// Updates the specified DeviceComplianceUserOverview using PATCH.
        /// </summary>
        /// <param name="deviceComplianceUserOverviewToUpdate">The DeviceComplianceUserOverview to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceComplianceUserOverview.</returns>
        System.Threading.Tasks.Task<DeviceComplianceUserOverview> UpdateAsync(DeviceComplianceUserOverview deviceComplianceUserOverviewToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceUserOverviewRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceUserOverviewRequest Expand(Expression<Func<DeviceComplianceUserOverview, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceUserOverviewRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceUserOverviewRequest Select(Expression<Func<DeviceComplianceUserOverview, object>> selectExpression);

    }
}
