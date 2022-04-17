using EnderEngine;
using System;
using System.Collections.Generic;
using System.Text;

namespace DGE.Core
{
    public static class AssemblySpy
    {

        /// <summary>
        /// The name of the Assembly
        /// </summary>
        public const string NAME = "TheSpy";
        /// <summary>
        /// The current version of the Engine in that format : Major.Minor.Fix/Small.Revision/SmallExtra
        /// </summary>
        public const string VERSION = "0.0.0.0";

        public static readonly DGEModule module = new DGEModule(NAME, VERSION, Init);

        internal static Logger logger = new Logger("TheSpy");

        /// <summary>
        /// Init function for the assembly (DGEModule)
        /// </summary>
        private static void Init()
        {

        }
    }
}