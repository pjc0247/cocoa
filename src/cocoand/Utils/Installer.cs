using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocoand.Utils
{
    using Models;
    using CocoaControls;

    class Installer
    {
        public static async void Install(InstallationInfo info)
        {
            try
            {
                var cmd = info.binder.Bind(info.cmd);
                Logger.Output(cmd);

                var task =  Net.Download(info.uri, info.local);
                await task;

                var targ = cmd.Split(new char[]{' '}, 2);

                OS.Execute(targ[0], targ[1]);

                if (info.isRegistEnvVar)
                {
                    /* TODO : Proops.Resource */
                    if (!OS.AppendEnvPath(info.path))
                        Logger.Output("failed to modify PATH");
                }
                if(info.envKey.Length > 0)
                {
                    if (!OS.SetEnvVar(info.envKey, info.path))
                        Logger.Output("failed to modify env var");
                }
            }
            catch (Exception e)
            {
                Logger.Output(e.ToString());
            }

            return;
        }
    }
}
