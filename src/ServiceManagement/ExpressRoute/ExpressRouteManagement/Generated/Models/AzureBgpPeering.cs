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
using Microsoft.WindowsAzure.Management.ExpressRoute.Models;

namespace Microsoft.WindowsAzure.Management.ExpressRoute.Models
{
    /// <summary>
    /// Describes a Border Gateway Protocol Peering.
    /// </summary>
    public partial class AzureBgpPeering
    {
        private string _advertisedCommunities;
        
        /// <summary>
        /// Optional. Specifies the communities that will be advertised by the
        /// peer over this BGP peering. Specific to Microsoft type of peering.
        /// </summary>
        public string AdvertisedCommunities
        {
            get { return this._advertisedCommunities; }
            set { this._advertisedCommunities = value; }
        }
        
        private string _advertisedPublicPrefixes;
        
        /// <summary>
        /// Optional. Specifies the public prefixes that will be advertised by
        /// the peer over this BGP peering. Specific to Microsoft type of
        /// peering.
        /// </summary>
        public string AdvertisedPublicPrefixes
        {
            get { return this._advertisedPublicPrefixes; }
            set { this._advertisedPublicPrefixes = value; }
        }
        
        private string _advertisedPublicPrefixesState;
        
        /// <summary>
        /// Optional. Specifies whether the Azure network has been configured
        /// to accept the public prefixes specified as will be advertised by
        /// the peer over this BGP peering. Specific to Mirosoft type of
        /// peering.
        /// </summary>
        public string AdvertisedPublicPrefixesState
        {
            get { return this._advertisedPublicPrefixesState; }
            set { this._advertisedPublicPrefixesState = value; }
        }
        
        private uint _azureAsn;
        
        /// <summary>
        /// Optional. Specifies the numeric identifier of the public autonomous
        /// system (AS) in which the device of Windows Azure is configured.
        /// </summary>
        public uint AzureAsn
        {
            get { return this._azureAsn; }
            set { this._azureAsn = value; }
        }
        
        private uint _customerAutonomousSystemNumber;
        
        /// <summary>
        /// Optional. Specifies the numeric identifier of the public autonomous
        /// system (AS) in which the device of the customer is configured.
        /// </summary>
        public uint CustomerAutonomousSystemNumber
        {
            get { return this._customerAutonomousSystemNumber; }
            set { this._customerAutonomousSystemNumber = value; }
        }
        
        private uint _legacyMode;
        
        /// <summary>
        /// Optional. Specifies the legacy mode. Specific to Microsoft type of
        /// peering.
        /// </summary>
        public uint LegacyMode
        {
            get { return this._legacyMode; }
            set { this._legacyMode = value; }
        }
        
        private uint _peerAsn;
        
        /// <summary>
        /// Optional. Specifies the numeric identifier of the public autonomous
        /// system (AS) in which the device of the service provider is
        /// configured.
        /// </summary>
        public uint PeerAsn
        {
            get { return this._peerAsn; }
            set { this._peerAsn = value; }
        }
        
        private string _primaryAzurePort;
        
        /// <summary>
        /// Optional. Specifies the name of the primary port.
        /// </summary>
        public string PrimaryAzurePort
        {
            get { return this._primaryAzurePort; }
            set { this._primaryAzurePort = value; }
        }
        
        private string _primaryPeerSubnet;
        
        /// <summary>
        /// Optional. Specifies the subnet addresses of the interface to be
        /// used for establishing the BGP session on the primary port.
        /// </summary>
        public string PrimaryPeerSubnet
        {
            get { return this._primaryPeerSubnet; }
            set { this._primaryPeerSubnet = value; }
        }
        
        private string _routingRegistryName;
        
        /// <summary>
        /// Optional. Specifies the Routing Registry to look up to validate the
        /// prefixes specified in AdvertisedPublicPrefixes
        /// </summary>
        public string RoutingRegistryName
        {
            get { return this._routingRegistryName; }
            set { this._routingRegistryName = value; }
        }
        
        private string _secondaryAzurePort;
        
        /// <summary>
        /// Optional. Specifies the name of the secondary port.
        /// </summary>
        public string SecondaryAzurePort
        {
            get { return this._secondaryAzurePort; }
            set { this._secondaryAzurePort = value; }
        }
        
        private string _secondaryPeerSubnet;
        
        /// <summary>
        /// Optional. Specifies the subnet addresses of the interface to be
        /// used for establishing the BGP session on the secondary port.
        /// </summary>
        public string SecondaryPeerSubnet
        {
            get { return this._secondaryPeerSubnet; }
            set { this._secondaryPeerSubnet = value; }
        }
        
        private BgpPeeringState _state;
        
        /// <summary>
        /// Optional. The current state of the BGP session. Possible values are
        /// Disabled, Enabled.
        /// </summary>
        public BgpPeeringState State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        private uint _vlanId;
        
        /// <summary>
        /// Optional. Specifies the identifier that is used to identify the
        /// customer.
        /// </summary>
        public uint VlanId
        {
            get { return this._vlanId; }
            set { this._vlanId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AzureBgpPeering class.
        /// </summary>
        public AzureBgpPeering()
        {
        }
    }
}