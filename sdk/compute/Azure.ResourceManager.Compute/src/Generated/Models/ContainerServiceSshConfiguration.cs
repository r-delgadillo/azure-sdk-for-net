// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> SSH configuration for Linux-based VMs running on Azure. </summary>
    public partial class ContainerServiceSshConfiguration
    {
        /// <summary> Initializes a new instance of ContainerServiceSshConfiguration. </summary>
        /// <param name="publicKeys"> the list of SSH public keys used to authenticate with Linux-based VMs. </param>
        public ContainerServiceSshConfiguration(IEnumerable<ContainerServiceSshPublicKey> publicKeys)
        {
            if (publicKeys == null)
            {
                throw new ArgumentNullException(nameof(publicKeys));
            }

            PublicKeys = publicKeys.ToList();
        }

        /// <summary> Initializes a new instance of ContainerServiceSshConfiguration. </summary>
        /// <param name="publicKeys"> the list of SSH public keys used to authenticate with Linux-based VMs. </param>
        internal ContainerServiceSshConfiguration(IList<ContainerServiceSshPublicKey> publicKeys)
        {
            PublicKeys = publicKeys ?? new List<ContainerServiceSshPublicKey>();
        }

        /// <summary> the list of SSH public keys used to authenticate with Linux-based VMs. </summary>
        public IList<ContainerServiceSshPublicKey> PublicKeys { get; }
    }
}
