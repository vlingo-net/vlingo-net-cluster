// Copyright © 2012-2018 Vaughn Vernon. All rights reserved.
//
// This Source Code Form is subject to the terms of the
// Mozilla Public License, v. 2.0. If a copy of the MPL
// was not distributed with this file, You can obtain
// one at https://mozilla.org/MPL/2.0/.

using Vlingo.Wire.Node;

namespace Vlingo.Cluster.Model.Message
{
    public class Ping : OperationalMessage
    {
        public static Ping From(string content)
        {
            return null;
        }
        
        public Ping(Id id) : base(id)
        {
        }
    }
}