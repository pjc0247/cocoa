using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocoand.Utils
{
    using Models;

    class Installer
    {
        public static async void Install(RequirementInfo info)
        {
            try
            {
                await Net.Download(info.uri, info.local);

                OS.Execute(info.cmd, "");
            }
            catch (Exception e)
            {
                Logger.Output(e.ToString());
            }

            return;
        }
    }
}
