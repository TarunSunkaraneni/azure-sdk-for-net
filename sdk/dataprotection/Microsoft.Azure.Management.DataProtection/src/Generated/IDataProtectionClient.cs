// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Open API 2.0 Specs for Azure Data Protection service
    /// </summary>
    public partial interface IDataProtectionClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// The subscription Id.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// Client Api Version.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IBackupVaultsOperations.
        /// </summary>
        IBackupVaultsOperations BackupVaults { get; }

        /// <summary>
        /// Gets the IOperationResultOperations.
        /// </summary>
        IOperationResultOperations OperationResult { get; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the IBackupPoliciesOperations.
        /// </summary>
        IBackupPoliciesOperations BackupPolicies { get; }

        /// <summary>
        /// Gets the IBackupInstancesOperations.
        /// </summary>
        IBackupInstancesOperations BackupInstances { get; }

        /// <summary>
        /// Gets the IRecoveryPointsOperations.
        /// </summary>
        IRecoveryPointsOperations RecoveryPoints { get; }

        /// <summary>
        /// Gets the IRecoveryPointOperations.
        /// </summary>
        IRecoveryPointOperations RecoveryPoint { get; }

        /// <summary>
        /// Gets the IJobsOperations.
        /// </summary>
        IJobsOperations Jobs { get; }

        /// <summary>
        /// Gets the IFindRestorableTimeRangesOperations.
        /// </summary>
        IFindRestorableTimeRangesOperations FindRestorableTimeRanges { get; }

        /// <summary>
        /// Gets the IJobOperations.
        /// </summary>
        IJobOperations Job { get; }

        /// <summary>
        /// Gets the IExportJobsOperations.
        /// </summary>
        IExportJobsOperations ExportJobs { get; }

        /// <summary>
        /// Gets the IExportJobsOperationResultOperations.
        /// </summary>
        IExportJobsOperationResultOperations ExportJobsOperationResult { get; }

        /// <summary>
        /// Gets the operation status for a resource.
        /// </summary>
        /// <param name='location'>
        /// </param>
        /// <param name='operationId'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<OperationResource>> GetOperationStatusWithHttpMessagesAsync(string location, string operationId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='vaultName'>
        /// The name of the backup vault.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the backup vault is present.
        /// </param>
        /// <param name='operationId'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<BackupVaultResource>> GetOperationResultPatchWithHttpMessagesAsync(string vaultName, string resourceGroupName, string operationId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Validates if a feature is supported
        /// </summary>
        /// <param name='location'>
        /// </param>
        /// <param name='parameters'>
        /// Feature support request object
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<FeatureValidationResponseBase>> CheckFeatureSupportWithHttpMessagesAsync(string location, FeatureValidationRequestBase parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
