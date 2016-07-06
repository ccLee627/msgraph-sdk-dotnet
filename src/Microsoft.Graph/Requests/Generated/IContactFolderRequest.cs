// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IContactFolderRequest.
    /// </summary>
    public partial interface IContactFolderRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ContactFolder using PUT.
        /// </summary>
        /// <param name="contactFolderToCreate">The ContactFolder to create.</param>
        /// <returns>The created ContactFolder.</returns>
        System.Threading.Tasks.Task<ContactFolder> CreateAsync(ContactFolder contactFolderToCreate);        /// <summary>
        /// Creates the specified ContactFolder using PUT.
        /// </summary>
        /// <param name="contactFolderToCreate">The ContactFolder to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ContactFolder.</returns>
        System.Threading.Tasks.Task<ContactFolder> CreateAsync(ContactFolder contactFolderToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ContactFolder.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ContactFolder.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ContactFolder.
        /// </summary>
        /// <returns>The ContactFolder.</returns>
        System.Threading.Tasks.Task<ContactFolder> GetAsync();

        /// <summary>
        /// Gets the specified ContactFolder.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ContactFolder.</returns>
        System.Threading.Tasks.Task<ContactFolder> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ContactFolder using PATCH.
        /// </summary>
        /// <param name="contactFolderToUpdate">The ContactFolder to update.</param>
        /// <returns>The updated ContactFolder.</returns>
        System.Threading.Tasks.Task<ContactFolder> UpdateAsync(ContactFolder contactFolderToUpdate);

        /// <summary>
        /// Updates the specified ContactFolder using PATCH.
        /// </summary>
        /// <param name="contactFolderToUpdate">The ContactFolder to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated ContactFolder.</returns>
        System.Threading.Tasks.Task<ContactFolder> UpdateAsync(ContactFolder contactFolderToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IContactFolderRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IContactFolderRequest Select(string value);

    }
}
