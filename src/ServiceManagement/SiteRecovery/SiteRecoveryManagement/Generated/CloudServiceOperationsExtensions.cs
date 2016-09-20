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
using Microsoft.WindowsAzure.Management.RecoveryServices;
using Microsoft.WindowsAzure.Management.RecoveryServices.Models;

namespace Microsoft.WindowsAzure.Management.RecoveryServices
{
    public static partial class CloudServiceOperationsExtensions
    {
        /// <summary>
        /// Creates a Cloud services
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.RecoveryServices.ICloudServiceOperations.
        /// </param>
        /// <param name='cloudServiceName'>
        /// Required. The cloud service name.
        /// </param>
        /// <param name='cloudService'>
        /// Required. Parameters supplied to the Create cloud service operation.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse BeginCreating(this ICloudServiceOperations operations, string cloudServiceName, CloudServiceCreateArgs cloudService)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICloudServiceOperations)s).BeginCreatingAsync(cloudServiceName, cloudService);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Creates a Cloud services
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.RecoveryServices.ICloudServiceOperations.
        /// </param>
        /// <param name='cloudServiceName'>
        /// Required. The cloud service name.
        /// </param>
        /// <param name='cloudService'>
        /// Required. Parameters supplied to the Create cloud service operation.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> BeginCreatingAsync(this ICloudServiceOperations operations, string cloudServiceName, CloudServiceCreateArgs cloudService)
        {
            return operations.BeginCreatingAsync(cloudServiceName, cloudService, CancellationToken.None);
        }
        
        /// <summary>
        /// Create a cloud service.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.RecoveryServices.ICloudServiceOperations.
        /// </param>
        /// <param name='cloudServiceName'>
        /// Required. The cloud service name.
        /// </param>
        /// <param name='cloudService'>
        /// Required. Parameters supplied to the Create cloud service operation.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public static RecoveryServicesOperationStatusResponse Create(this ICloudServiceOperations operations, string cloudServiceName, CloudServiceCreateArgs cloudService)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICloudServiceOperations)s).CreateAsync(cloudServiceName, cloudService);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create a cloud service.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.RecoveryServices.ICloudServiceOperations.
        /// </param>
        /// <param name='cloudServiceName'>
        /// Required. The cloud service name.
        /// </param>
        /// <param name='cloudService'>
        /// Required. Parameters supplied to the Create cloud service operation.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public static Task<RecoveryServicesOperationStatusResponse> CreateAsync(this ICloudServiceOperations operations, string cloudServiceName, CloudServiceCreateArgs cloudService)
        {
            return operations.CreateAsync(cloudServiceName, cloudService, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve a list of Cloud services
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.RecoveryServices.ICloudServiceOperations.
        /// </param>
        /// <returns>
        /// The response model for the list cloud service operation.
        /// </returns>
        public static CloudServiceListResponse List(this ICloudServiceOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICloudServiceOperations)s).ListAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve a list of Cloud services
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.RecoveryServices.ICloudServiceOperations.
        /// </param>
        /// <returns>
        /// The response model for the list cloud service operation.
        /// </returns>
        public static Task<CloudServiceListResponse> ListAsync(this ICloudServiceOperations operations)
        {
            return operations.ListAsync(CancellationToken.None);
        }
    }
}