using System;

namespace Cassandra.IntegrationTests
{
    [AttributeUsage(AttributeTargets.Method)]
    public class NeedSomeFixAttribute : Attribute
    {
    }
}