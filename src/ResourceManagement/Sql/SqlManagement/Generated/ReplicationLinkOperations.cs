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
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.Azure.Management.Sql;
using Microsoft.Azure.Management.Sql.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Management.Sql
{
    /// <summary>
    /// Represents all the operations for operating on Azure SQL Database
    /// Replication Links.  Contains operations to: Delete and Retrieve
    /// replication links.
    /// </summary>
    internal partial class ReplicationLinkOperations : IServiceOperations<SqlManagementClient>, IReplicationLinkOperations
    {
        /// <summary>
        /// Initializes a new instance of the ReplicationLinkOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal ReplicationLinkOperations(SqlManagementClient client)
        {
            this._client = client;
        }
        
        private SqlManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.Azure.Management.Sql.SqlManagementClient.
        /// </summary>
        public SqlManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Deletes the Azure SQL Database Replication Link with the given id.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server on which the Azure SQL
        /// Database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database that has the
        /// replication link to be dropped.
        /// </param>
        /// <param name='linkId'>
        /// Required. The id of the replication link to be deleted.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public async Task<AzureOperationResponse> DeleteAsync(string resourceGroupName, string serverName, string databaseName, string linkId, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException("resourceGroupName");
            }
            if (serverName == null)
            {
                throw new ArgumentNullException("serverName");
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException("databaseName");
            }
            if (linkId == null)
            {
                throw new ArgumentNullException("linkId");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("serverName", serverName);
                tracingParameters.Add("databaseName", databaseName);
                tracingParameters.Add("linkId", linkId);
                TracingAdapter.Enter(invocationId, this, "DeleteAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/resourceGroups/";
            url = url + Uri.EscapeDataString(resourceGroupName);
            url = url + "/providers/";
            url = url + "Microsoft.Sql";
            url = url + "/servers/";
            url = url + Uri.EscapeDataString(serverName);
            url = url + "/databases/";
            url = url + Uri.EscapeDataString(databaseName);
            url = url + "/replicationLinks/";
            url = url + Uri.EscapeDataString(linkId);
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2014-04-01");
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Delete;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK && statusCode != HttpStatusCode.NoContent)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    AzureOperationResponse result = null;
                    // Deserialize Response
                    result = new AzureOperationResponse();
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Returns information about an Azure SQL Database Replication Link.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server on which the database is
        /// hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database to get the link for.
        /// </param>
        /// <param name='linkId'>
        /// Required. The replication link id to be retrieved.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a Get Azure Sql Database Replication
        /// Link request.
        /// </returns>
        public async Task<ReplicationLinkGetResponse> GetAsync(string resourceGroupName, string serverName, string databaseName, string linkId, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException("resourceGroupName");
            }
            if (serverName == null)
            {
                throw new ArgumentNullException("serverName");
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException("databaseName");
            }
            if (linkId == null)
            {
                throw new ArgumentNullException("linkId");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("serverName", serverName);
                tracingParameters.Add("databaseName", databaseName);
                tracingParameters.Add("linkId", linkId);
                TracingAdapter.Enter(invocationId, this, "GetAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/resourceGroups/";
            url = url + Uri.EscapeDataString(resourceGroupName);
            url = url + "/providers/";
            url = url + "Microsoft.Sql";
            url = url + "/servers/";
            url = url + Uri.EscapeDataString(serverName);
            url = url + "/databases/";
            url = url + Uri.EscapeDataString(databaseName);
            url = url + "/replicationLinks/";
            url = url + Uri.EscapeDataString(linkId);
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2014-04-01");
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    ReplicationLinkGetResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new ReplicationLinkGetResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            ReplicationLink replicationLinkInstance = new ReplicationLink();
                            result.ReplicationLink = replicationLinkInstance;
                            
                            JToken propertiesValue = responseDoc["properties"];
                            if (propertiesValue != null && propertiesValue.Type != JTokenType.Null)
                            {
                                ReplicationLinkProperties propertiesInstance = new ReplicationLinkProperties();
                                replicationLinkInstance.Properties = propertiesInstance;
                                
                                JToken partnerServerValue = propertiesValue["partnerServer"];
                                if (partnerServerValue != null && partnerServerValue.Type != JTokenType.Null)
                                {
                                    string partnerServerInstance = ((string)partnerServerValue);
                                    propertiesInstance.PartnerServer = partnerServerInstance;
                                }
                                
                                JToken partnerDatabaseValue = propertiesValue["partnerDatabase"];
                                if (partnerDatabaseValue != null && partnerDatabaseValue.Type != JTokenType.Null)
                                {
                                    string partnerDatabaseInstance = ((string)partnerDatabaseValue);
                                    propertiesInstance.PartnerDatabase = partnerDatabaseInstance;
                                }
                                
                                JToken partnerLocationValue = propertiesValue["partnerLocation"];
                                if (partnerLocationValue != null && partnerLocationValue.Type != JTokenType.Null)
                                {
                                    string partnerLocationInstance = ((string)partnerLocationValue);
                                    propertiesInstance.PartnerLocation = partnerLocationInstance;
                                }
                                
                                JToken roleValue = propertiesValue["role"];
                                if (roleValue != null && roleValue.Type != JTokenType.Null)
                                {
                                    string roleInstance = ((string)roleValue);
                                    propertiesInstance.Role = roleInstance;
                                }
                                
                                JToken partnerRoleValue = propertiesValue["partnerRole"];
                                if (partnerRoleValue != null && partnerRoleValue.Type != JTokenType.Null)
                                {
                                    string partnerRoleInstance = ((string)partnerRoleValue);
                                    propertiesInstance.PartnerRole = partnerRoleInstance;
                                }
                                
                                JToken startTimeValue = propertiesValue["startTime"];
                                if (startTimeValue != null && startTimeValue.Type != JTokenType.Null)
                                {
                                    DateTime startTimeInstance = ((DateTime)startTimeValue);
                                    propertiesInstance.StartTime = startTimeInstance;
                                }
                                
                                JToken percentCompleteValue = propertiesValue["percentComplete"];
                                if (percentCompleteValue != null && percentCompleteValue.Type != JTokenType.Null)
                                {
                                    string percentCompleteInstance = ((string)percentCompleteValue);
                                    propertiesInstance.PercentComplete = percentCompleteInstance;
                                }
                                
                                JToken replicationStateValue = propertiesValue["replicationState"];
                                if (replicationStateValue != null && replicationStateValue.Type != JTokenType.Null)
                                {
                                    string replicationStateInstance = ((string)replicationStateValue);
                                    propertiesInstance.ReplicationState = replicationStateInstance;
                                }
                            }
                            
                            JToken idValue = responseDoc["id"];
                            if (idValue != null && idValue.Type != JTokenType.Null)
                            {
                                string idInstance = ((string)idValue);
                                replicationLinkInstance.Id = idInstance;
                            }
                            
                            JToken nameValue = responseDoc["name"];
                            if (nameValue != null && nameValue.Type != JTokenType.Null)
                            {
                                string nameInstance = ((string)nameValue);
                                replicationLinkInstance.Name = nameInstance;
                            }
                            
                            JToken typeValue = responseDoc["type"];
                            if (typeValue != null && typeValue.Type != JTokenType.Null)
                            {
                                string typeInstance = ((string)typeValue);
                                replicationLinkInstance.Type = typeInstance;
                            }
                            
                            JToken locationValue = responseDoc["location"];
                            if (locationValue != null && locationValue.Type != JTokenType.Null)
                            {
                                string locationInstance = ((string)locationValue);
                                replicationLinkInstance.Location = locationInstance;
                            }
                            
                            JToken tagsSequenceElement = ((JToken)responseDoc["tags"]);
                            if (tagsSequenceElement != null && tagsSequenceElement.Type != JTokenType.Null)
                            {
                                foreach (JProperty property in tagsSequenceElement)
                                {
                                    string tagsKey = ((string)property.Name);
                                    string tagsValue = ((string)property.Value);
                                    replicationLinkInstance.Tags.Add(tagsKey, tagsValue);
                                }
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Returns information about Azure SQL Database Replication Links.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server in which the Azure SQL
        /// Database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database to retrieve links for.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a List Azure Sql Database Replication
        /// Link request.
        /// </returns>
        public async Task<ReplicationLinkListResponse> ListAsync(string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException("resourceGroupName");
            }
            if (serverName == null)
            {
                throw new ArgumentNullException("serverName");
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException("databaseName");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("serverName", serverName);
                tracingParameters.Add("databaseName", databaseName);
                TracingAdapter.Enter(invocationId, this, "ListAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/resourceGroups/";
            url = url + Uri.EscapeDataString(resourceGroupName);
            url = url + "/providers/";
            url = url + "Microsoft.Sql";
            url = url + "/servers/";
            url = url + Uri.EscapeDataString(serverName);
            url = url + "/databases/";
            url = url + Uri.EscapeDataString(databaseName);
            url = url + "/replicationLinks";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2014-04-01");
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    ReplicationLinkListResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new ReplicationLinkListResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            JToken valueArray = responseDoc["value"];
                            if (valueArray != null && valueArray.Type != JTokenType.Null)
                            {
                                foreach (JToken valueValue in ((JArray)valueArray))
                                {
                                    ReplicationLink replicationLinkInstance = new ReplicationLink();
                                    result.ReplicationLinks.Add(replicationLinkInstance);
                                    
                                    JToken propertiesValue = valueValue["properties"];
                                    if (propertiesValue != null && propertiesValue.Type != JTokenType.Null)
                                    {
                                        ReplicationLinkProperties propertiesInstance = new ReplicationLinkProperties();
                                        replicationLinkInstance.Properties = propertiesInstance;
                                        
                                        JToken partnerServerValue = propertiesValue["partnerServer"];
                                        if (partnerServerValue != null && partnerServerValue.Type != JTokenType.Null)
                                        {
                                            string partnerServerInstance = ((string)partnerServerValue);
                                            propertiesInstance.PartnerServer = partnerServerInstance;
                                        }
                                        
                                        JToken partnerDatabaseValue = propertiesValue["partnerDatabase"];
                                        if (partnerDatabaseValue != null && partnerDatabaseValue.Type != JTokenType.Null)
                                        {
                                            string partnerDatabaseInstance = ((string)partnerDatabaseValue);
                                            propertiesInstance.PartnerDatabase = partnerDatabaseInstance;
                                        }
                                        
                                        JToken partnerLocationValue = propertiesValue["partnerLocation"];
                                        if (partnerLocationValue != null && partnerLocationValue.Type != JTokenType.Null)
                                        {
                                            string partnerLocationInstance = ((string)partnerLocationValue);
                                            propertiesInstance.PartnerLocation = partnerLocationInstance;
                                        }
                                        
                                        JToken roleValue = propertiesValue["role"];
                                        if (roleValue != null && roleValue.Type != JTokenType.Null)
                                        {
                                            string roleInstance = ((string)roleValue);
                                            propertiesInstance.Role = roleInstance;
                                        }
                                        
                                        JToken partnerRoleValue = propertiesValue["partnerRole"];
                                        if (partnerRoleValue != null && partnerRoleValue.Type != JTokenType.Null)
                                        {
                                            string partnerRoleInstance = ((string)partnerRoleValue);
                                            propertiesInstance.PartnerRole = partnerRoleInstance;
                                        }
                                        
                                        JToken startTimeValue = propertiesValue["startTime"];
                                        if (startTimeValue != null && startTimeValue.Type != JTokenType.Null)
                                        {
                                            DateTime startTimeInstance = ((DateTime)startTimeValue);
                                            propertiesInstance.StartTime = startTimeInstance;
                                        }
                                        
                                        JToken percentCompleteValue = propertiesValue["percentComplete"];
                                        if (percentCompleteValue != null && percentCompleteValue.Type != JTokenType.Null)
                                        {
                                            string percentCompleteInstance = ((string)percentCompleteValue);
                                            propertiesInstance.PercentComplete = percentCompleteInstance;
                                        }
                                        
                                        JToken replicationStateValue = propertiesValue["replicationState"];
                                        if (replicationStateValue != null && replicationStateValue.Type != JTokenType.Null)
                                        {
                                            string replicationStateInstance = ((string)replicationStateValue);
                                            propertiesInstance.ReplicationState = replicationStateInstance;
                                        }
                                    }
                                    
                                    JToken idValue = valueValue["id"];
                                    if (idValue != null && idValue.Type != JTokenType.Null)
                                    {
                                        string idInstance = ((string)idValue);
                                        replicationLinkInstance.Id = idInstance;
                                    }
                                    
                                    JToken nameValue = valueValue["name"];
                                    if (nameValue != null && nameValue.Type != JTokenType.Null)
                                    {
                                        string nameInstance = ((string)nameValue);
                                        replicationLinkInstance.Name = nameInstance;
                                    }
                                    
                                    JToken typeValue = valueValue["type"];
                                    if (typeValue != null && typeValue.Type != JTokenType.Null)
                                    {
                                        string typeInstance = ((string)typeValue);
                                        replicationLinkInstance.Type = typeInstance;
                                    }
                                    
                                    JToken locationValue = valueValue["location"];
                                    if (locationValue != null && locationValue.Type != JTokenType.Null)
                                    {
                                        string locationInstance = ((string)locationValue);
                                        replicationLinkInstance.Location = locationInstance;
                                    }
                                    
                                    JToken tagsSequenceElement = ((JToken)valueValue["tags"]);
                                    if (tagsSequenceElement != null && tagsSequenceElement.Type != JTokenType.Null)
                                    {
                                        foreach (JProperty property in tagsSequenceElement)
                                        {
                                            string tagsKey = ((string)property.Name);
                                            string tagsValue = ((string)property.Value);
                                            replicationLinkInstance.Tags.Add(tagsKey, tagsValue);
                                        }
                                    }
                                }
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}