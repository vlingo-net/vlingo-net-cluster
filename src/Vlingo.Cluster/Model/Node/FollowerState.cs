// Copyright © 2012-2021 VLINGO LABS. All rights reserved.
//
// This Source Code Form is subject to the terms of the
// Mozilla Public License, v. 2.0. If a copy of the MPL
// was not distributed with this file, You can obtain
// one at https://mozilla.org/MPL/2.0/.

using Vlingo.Xoom.Actors;

namespace Vlingo.Cluster.Model.Node
{
    internal sealed class FollowerState : LiveNodeState
    {
        internal FollowerState(Xoom.Wire.Node.Node node, ILiveNodeMaintainer liveNodeMaintainer, ILogger logger) : base(node, liveNodeMaintainer, Type.Follower, logger)
        {
        }
    }
}