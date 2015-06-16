using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Net;

namespace Cocoand.Utils
{
    using Models;
    using CocoaControls;

    class Installer
    {
        public static async Task<bool> Install(
            InstallationInfo info,
            Action<DownloadProgressChangedEventArgs> downloadProgressCallback)
        {
            try
            {
                var task = Net.DownloadAsync(
                    info.uri, info.local, downloadProgressCallback);
                await task;

                Logger.Output(task.Status.ToString());

                /* path 경로 생성 */
                Directory.CreateDirectory(info.path);

                //foreach (var cmd in info.cmds)
                //{
                    var bound = info.binder.Bind(info.cmds);
                    var targ = bound.Split(new char[] { ' ' }, 2);

                    Logger.Output(bound);
                    var result = await OS.ExecuteAsync(targ[0], targ[1]);
                //}

                if (info.isRegistEnvVar)
                {
                    /* TODO : Proops.Resource */
                    if (!await OS.AppendEnvPathAsync(info.path))
                        throw new Exception("failed to modify PATH");
                }
                if(info.envKey.Length > 0)
                {
                    if (!await OS.SetEnvVarAsync(info.envKey, info.path))
                        throw new Exception("failed to modify env var");
                }
            }
            catch (Exception e)
            {
                Logger.Output(e.ToString());

                return false;
            }
            finally
            {
           //     File.Delete(info.local);   
            }

            return true;
        }
    }
}
