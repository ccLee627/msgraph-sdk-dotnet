// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IDirectoryObjectGetMemberGroupsRequest.
    /// </summary>
    public partial interface IDirectoryObjectGetMemberGroupsRequest : IBaseRequest
    {

        /// <summary>
        /// Gets the request body.
        /// </summary>
        DirectoryObjectGetMemberGroupsRequestBody RequestBody { get; }

        /// <summary>
        /// Issues the POST request.
        /// </summary>
        System.Threading.Tasks.Task<IDirectoryObjectGetMemberGroupsCollectionPage> PostAsync();

        /// <summary>
        /// Issues the POST request.
        /// </summary>
        /// /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>TheIDirectoryObjectGetMemberGroupsCollectionPage</returns>
        System.Threading.Tasks.Task<IDirectoryObjectGetMemberGroupsCollectionPage> PostAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryObjectGetMemberGroupsRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryObjectGetMemberGroupsRequest Select(string value);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryObjectGetMemberGroupsRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryObjectGetMemberGroupsRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryObjectGetMemberGroupsRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryObjectGetMemberGroupsRequest OrderBy(string value);
    }
}
