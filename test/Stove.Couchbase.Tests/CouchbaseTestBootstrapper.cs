﻿using Stove.Bootstrapping;

namespace Stove.Couchbase.Tests
{
    [DependsOn(
        typeof(StoveCouchbaseBootstrapper)
    )]
    public class CouchbaseTestBootstrapper : StoveBootstrapper
    {
    }
}
