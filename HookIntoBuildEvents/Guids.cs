// Guids.cs
// MUST match guids.h
using System;

namespace Company.HookIntoBuildEvents
{
    static class GuidList
    {
        public const string guidHookIntoBuildEventsPkgString = "535cbb18-71d2-4190-9c04-b8077c87799d";
        public const string guidHookIntoBuildEventsCmdSetString = "c50fb76f-d8d6-41d3-8668-04aa1987d599";

        public static readonly Guid guidHookIntoBuildEventsCmdSet = new Guid(guidHookIntoBuildEventsCmdSetString);
    };
}