// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.Automation;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation
{
    public static partial class ConnectionTypeOperationsExtensions
    {
        /// <summary>
        /// Create a connectiontype.  (see
        /// http://aka.ms/azureautomationsdk/connectiontypeoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IConnectionTypeOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the create or update
        /// connectiontype operation.
        /// </param>
        /// <returns>
        /// The response model for the create or update connection type
        /// operation.
        /// </returns>
        public static ConnectionTypeCreateOrUpdateResponse CreateOrUpdate(this IConnectionTypeOperations operations, string resourceGroupName, string automationAccount, ConnectionTypeCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IConnectionTypeOperations)s).CreateOrUpdateAsync(resourceGroupName, automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create a connectiontype.  (see
        /// http://aka.ms/azureautomationsdk/connectiontypeoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IConnectionTypeOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the create or update
        /// connectiontype operation.
        /// </param>
        /// <returns>
        /// The response model for the create or update connection type
        /// operation.
        /// </returns>
        public static Task<ConnectionTypeCreateOrUpdateResponse> CreateOrUpdateAsync(this IConnectionTypeOperations operations, string resourceGroupName, string automationAccount, ConnectionTypeCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, automationAccount, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Delete the connectiontype.  (see
        /// http://aka.ms/azureautomationsdk/connectiontypeoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IConnectionTypeOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='connectionTypeName'>
        /// Required. The name of connectiontype.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this IConnectionTypeOperations operations, string resourceGroupName, string automationAccount, string connectionTypeName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IConnectionTypeOperations)s).DeleteAsync(resourceGroupName, automationAccount, connectionTypeName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Delete the connectiontype.  (see
        /// http://aka.ms/azureautomationsdk/connectiontypeoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IConnectionTypeOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='connectionTypeName'>
        /// Required. The name of connectiontype.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this IConnectionTypeOperations operations, string resourceGroupName, string automationAccount, string connectionTypeName)
        {
            return operations.DeleteAsync(resourceGroupName, automationAccount, connectionTypeName, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve the connectiontype identified by connectiontype name.
        /// (see http://aka.ms/azureautomationsdk/connectiontypeoperations
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IConnectionTypeOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='connectionTypeName'>
        /// Required. The name of connectiontype.
        /// </param>
        /// <returns>
        /// The response model for the get connection type operation.
        /// </returns>
        public static ConnectionTypeGetResponse Get(this IConnectionTypeOperations operations, string resourceGroupName, string automationAccount, string connectionTypeName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IConnectionTypeOperations)s).GetAsync(resourceGroupName, automationAccount, connectionTypeName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the connectiontype identified by connectiontype name.
        /// (see http://aka.ms/azureautomationsdk/connectiontypeoperations
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IConnectionTypeOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='connectionTypeName'>
        /// Required. The name of connectiontype.
        /// </param>
        /// <returns>
        /// The response model for the get connection type operation.
        /// </returns>
        public static Task<ConnectionTypeGetResponse> GetAsync(this IConnectionTypeOperations operations, string resourceGroupName, string automationAccount, string connectionTypeName)
        {
            return operations.GetAsync(resourceGroupName, automationAccount, connectionTypeName, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve a list of connectiontypes.  (see
        /// http://aka.ms/azureautomationsdk/connectiontypeoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IConnectionTypeOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <returns>
        /// The response model for the list connection type operation.
        /// </returns>
        public static ConnectionTypeListResponse List(this IConnectionTypeOperations operations, string resourceGroupName, string automationAccount)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IConnectionTypeOperations)s).ListAsync(resourceGroupName, automationAccount);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve a list of connectiontypes.  (see
        /// http://aka.ms/azureautomationsdk/connectiontypeoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IConnectionTypeOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <returns>
        /// The response model for the list connection type operation.
        /// </returns>
        public static Task<ConnectionTypeListResponse> ListAsync(this IConnectionTypeOperations operations, string resourceGroupName, string automationAccount)
        {
            return operations.ListAsync(resourceGroupName, automationAccount, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve next list of connectiontypes.  (see
        /// http://aka.ms/azureautomationsdk/connectiontypeoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IConnectionTypeOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The link to retrieve next set of items.
        /// </param>
        /// <returns>
        /// The response model for the list connection type operation.
        /// </returns>
        public static ConnectionTypeListResponse ListNext(this IConnectionTypeOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IConnectionTypeOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve next list of connectiontypes.  (see
        /// http://aka.ms/azureautomationsdk/connectiontypeoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IConnectionTypeOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The link to retrieve next set of items.
        /// </param>
        /// <returns>
        /// The response model for the list connection type operation.
        /// </returns>
        public static Task<ConnectionTypeListResponse> ListNextAsync(this IConnectionTypeOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
    }
}
