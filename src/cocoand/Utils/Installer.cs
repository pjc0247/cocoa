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
        public static async Task Install(InstallationInfo info)
        {
            try
            {
                var task = Net.DownloadAsync(info.uri, info.local);
                await task;

                Logger.Output(task.Status.ToString());

                foreach (var cmd in info.cmds)
                {
                    var bound = info.binder.Bind(cmd);
                    var targ = bound.Split(new char[] { ' ' }, 2);

                    Logger.Output(bound);
                    var result = await OS.Execute(targ[0], targ[1]);
                }

                if (info.isRegistEnvVar)
                {
                    /* TODO : Proops.Resource */
                    if (!await OS.AppendEnvPathAsync(info.path))
                        Logger.Output("failed to modify PATH");
                }
                if(info.envKey.Length > 0)
                {
                    if (!await OS.SetEnvVarAsync(info.envKey, info.path))
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
