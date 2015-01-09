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
using Microsoft.Azure;

namespace Microsoft.WindowsAzure.Management.StorSimple.Models
{
    /// <summary>
    /// This is the Task Response for all Async Calls
    /// </summary>
    public partial class TaskResponse : AzureOperationResponse
    {
        private string _taskId;
        
        /// <summary>
        /// Required. The TaskId of the Async Task Submitted
        /// </summary>
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the TaskResponse class.
        /// </summary>
        public TaskResponse()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the TaskResponse class with required
        /// arguments.
        /// </summary>
        public TaskResponse(string taskId)
            : this()
        {
            if (taskId == null)
            {
                throw new ArgumentNullException("taskId");
            }
            this.TaskId = taskId;
        }
    }
}
