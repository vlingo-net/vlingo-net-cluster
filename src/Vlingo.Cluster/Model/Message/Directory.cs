// Copyright © 2012-2018 Vaughn Vernon. All rights reserved.
//
// This Source Code Form is subject to the terms of the
// Mozilla Public License, v. 2.0. If a copy of the MPL
// was not distributed with this file, You can obtain
// one at https://mozilla.org/MPL/2.0/.

using Vlingo.Wire.Node;

namespace Vlingo.Cluster.Model.Message
{
    public class Directory : OperationalMessage
    {
        public static Directory From(string content)
        {
            return null;
        }
        
        public Directory(Id id) : base(id)
        {
        }
    }
}