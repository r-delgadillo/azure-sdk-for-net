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
using Microsoft.WindowsAzure.Management.StorSimple.Models;

namespace Microsoft.WindowsAzure.Management.StorSimple.Models
{
    /// <summary>
    /// The information on backup policy.
    /// </summary>
    public partial class BackupPolicy : CisBaseObject
    {
        private BackupPolicyCreationType _backupPolicyCreationType;
        
        /// <summary>
        /// Required. The type of the backup policy creation.
        /// </summary>
        public BackupPolicyCreationType BackupPolicyCreationType
        {
            get { return this._backupPolicyCreationType; }
            set { this._backupPolicyCreationType = value; }
        }
        
        private System.DateTime? _lastBackup;
        
        /// <summary>
        /// Optional. The previous backup time.
        /// </summary>
        public System.DateTime? LastBackup
        {
            get { return this._lastBackup; }
            set { this._lastBackup = value; }
        }
        
        private DateTime _nextBackup;
        
        /// <summary>
        /// Optional. The next backup time.
        /// </summary>
        public DateTime NextBackup
        {
            get { return this._nextBackup; }
            set { this._nextBackup = value; }
        }
        
        private long _schedulesCount;
        
        /// <summary>
        /// Required. The count of backup schedules under this backup policy.
        /// </summary>
        public long SchedulesCount
        {
            get { return this._schedulesCount; }
            set { this._schedulesCount = value; }
        }
        
        private string _sSMHostName;
        
        /// <summary>
        /// Required. The name of the StorSimple Manager host.
        /// </summary>
        public string SSMHostName
        {
            get { return this._sSMHostName; }
            set { this._sSMHostName = value; }
        }
        
        private long _volumesCount;
        
        /// <summary>
        /// Required. The count of volumes covered under this backup policy.
        /// </summary>
        public long VolumesCount
        {
            get { return this._volumesCount; }
            set { this._volumesCount = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the BackupPolicy class.
        /// </summary>
        public BackupPolicy()
        {
        }
    }
}
