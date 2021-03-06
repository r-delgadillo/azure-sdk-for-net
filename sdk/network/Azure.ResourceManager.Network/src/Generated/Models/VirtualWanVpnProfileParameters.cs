// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Virtual Wan Vpn profile parameters Vpn profile generation. </summary>
    public partial class VirtualWanVpnProfileParameters
    {
        /// <summary> Initializes a new instance of VirtualWanVpnProfileParameters. </summary>
        public VirtualWanVpnProfileParameters()
        {
        }

        /// <summary> Initializes a new instance of VirtualWanVpnProfileParameters. </summary>
        /// <param name="vpnServerConfigurationResourceId"> VpnServerConfiguration partial resource uri with which VirtualWan is associated to. </param>
        /// <param name="authenticationMethod"> VPN client authentication method. </param>
        internal VirtualWanVpnProfileParameters(string vpnServerConfigurationResourceId, AuthenticationMethod? authenticationMethod)
        {
            VpnServerConfigurationResourceId = vpnServerConfigurationResourceId;
            AuthenticationMethod = authenticationMethod;
        }

        /// <summary> VpnServerConfiguration partial resource uri with which VirtualWan is associated to. </summary>
        public string VpnServerConfigurationResourceId { get; set; }
        /// <summary> VPN client authentication method. </summary>
        public AuthenticationMethod? AuthenticationMethod { get; set; }
    }
}
