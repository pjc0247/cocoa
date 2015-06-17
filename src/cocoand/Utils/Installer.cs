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

                /* path 경로 생성 */
                Directory.CreateDirectory(info.path);

                foreach (var cmd in info.cmds)
                {
                    var bound = info.binder.Bind(cmd);
                    var targ = bound.Split(new char[] { ' ' }, 2);

                    var result = await OS.ExecuteAsync(targ[0], targ[1]);
                }

                if (info.isRegistEnvVar)
                {
                    Logger.Output("PATH에 경로를 등록합니다.");

                    /* TODO : Proops.Resource */
                    if (!await OS.AppendEnvPathAsync(info.path))
                        throw new Exception("failed to modify PATH");
                }
                if(info.envKey.Length > 0)
                {
                    Logger.Output("환경 변수를 등록합니다.");

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
                Logger.Output("설치 데이터 클린");
                File.Delete(info.local);   
            }

            return true;
        }
    }
}
