// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataShare.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A ShareSynchronization data transfer object.
    /// </summary>
    public partial class ShareSynchronization
    {
        /// <summary>
        /// Initializes a new instance of the ShareSynchronization class.
        /// </summary>
        public ShareSynchronization()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ShareSynchronization class.
        /// </summary>
        /// <param name="consumerEmail">Email of the user who created the
        /// synchronization</param>
        /// <param name="consumerName">Name of the user who created the
        /// synchronization</param>
        /// <param name="consumerTenantName">Tenant name of the consumer who
        /// created the synchronization</param>
        /// <param name="durationMs">synchronization duration</param>
        /// <param name="endTime">End time of synchronization</param>
        /// <param name="message">message of synchronization</param>
        /// <param name="startTime">start time of synchronization</param>
        /// <param name="status">Raw Status</param>
        /// <param name="synchronizationId">Synchronization id</param>
        /// <param name="synchronizationMode">Synchronization mode. Possible
        /// values include: 'Incremental', 'FullSync'</param>
        public ShareSynchronization(string consumerEmail = default(string), string consumerName = default(string), string consumerTenantName = default(string), int? durationMs = default(int?), System.DateTime? endTime = default(System.DateTime?), string message = default(string), System.DateTime? startTime = default(System.DateTime?), string status = default(string), string synchronizationId = default(string), string synchronizationMode = default(string))
        {
            ConsumerEmail = consumerEmail;
            ConsumerName = consumerName;
            ConsumerTenantName = consumerTenantName;
            DurationMs = durationMs;
            EndTime = endTime;
            Message = message;
            StartTime = startTime;
            Status = status;
            SynchronizationId = synchronizationId;
            SynchronizationMode = synchronizationMode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets email of the user who created the synchronization
        /// </summary>
        [JsonProperty(PropertyName = "consumerEmail")]
        public string ConsumerEmail { get; set; }

        /// <summary>
        /// Gets or sets name of the user who created the synchronization
        /// </summary>
        [JsonProperty(PropertyName = "consumerName")]
        public string ConsumerName { get; set; }

        /// <summary>
        /// Gets or sets tenant name of the consumer who created the
        /// synchronization
        /// </summary>
        [JsonProperty(PropertyName = "consumerTenantName")]
        public string ConsumerTenantName { get; set; }

        /// <summary>
        /// Gets or sets synchronization duration
        /// </summary>
        [JsonProperty(PropertyName = "durationMs")]
        public int? DurationMs { get; set; }

        /// <summary>
        /// Gets or sets end time of synchronization
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets message of synchronization
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets start time of synchronization
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets raw Status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets synchronization id
        /// </summary>
        [JsonProperty(PropertyName = "synchronizationId")]
        public string SynchronizationId { get; set; }

        /// <summary>
        /// Gets synchronization mode. Possible values include: 'Incremental',
        /// 'FullSync'
        /// </summary>
        [JsonProperty(PropertyName = "synchronizationMode")]
        public string SynchronizationMode { get; private set; }

    }
}
