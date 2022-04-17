using System;
using DGE;
using DGE.Core;

namespace Spy;

public static class Program
{
    public static void Main(string[] args)
    {
        DGE.Main.Init();
        DGEModules.RegisterModule(AssemblySpy.module);

        DGE.Main.Run().GetAwaiter().GetResult();
    }
}