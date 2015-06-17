using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Cocoand.Utils
{
    class OS
    {
        public static bool AppendEnvPath(String value)
        {
            if (value == null)
                throw new ArgumentNullException("value");

            try
            {
                String key = "path";
                String originalValue =
                    Environment.GetEnvironmentVariable(key, EnvironmentVariableTarget.User);

                /* 없으면 새로 만든다 */
                if (originalValue == null)
                    originalValue = "";
                else
                {
                    if (originalValue.IndexOf(value) != -1)
                        return false;

                    if (originalValue.Last() != ';')
                        originalValue += ";";
                }

                return SetEnvVar(key, originalValue + value);
            }
            catch (Exception e)
            {
                Logger.Output(e.ToString());
                return false;
            }
        }
        public static Task<bool> AppendEnvPathAsync(String value)
        {
            return Task.Factory.StartNew(() =>
            {
                return AppendEnvPath(value);
            });
        }
        public static bool SetEnvVar(String key, String value)
        {
            if (key == null)
                throw new ArgumentNullException("key");
            if (value == null)
                throw new ArgumentNullException("value");

            try
            {
                Environment.SetEnvironmentVariable(
                    key, value,
                    EnvironmentVariableTarget.User);

                return true;
            }
            catch (Exception e)
            {
                Logger.Output(e.ToString());
                return false;
            }
        }
        public static Task<bool> SetEnvVarAsync(String key, String value)
        {
            return Task.Factory.StartNew(() =>
            {
                return SetEnvVar(key, value);
            });
        }


        public static Task<bool> ExecuteAsync(String target, String args)
        {
            if (target == null)
                throw new ArgumentNullException("target");
            if (args == null)
                throw new ArgumentNullException("args");

            return Task.Factory.StartNew(() =>
            {
                try
                {
                    var process = new Process();

                    process.StartInfo.FileName = target;
                    process.StartInfo.Arguments = args;
                    //process.StartInfo.UseShellExecute = false;
                    //process.StartInfo.RedirectStandardOutput = true;
                    //process.StartInfo.RedirectStandardError = true;

                    process.Start();
                    process.WaitForExit();



                    /*
                    var stdout = 
                        process.StandardOutput.ReadToEnd();
                    var stderr = 
                        process.StandardOutput.ReadToEnd();

                    Logger.Output(stdout);
                    Logger.Output(stderr);
                     * */

                    Logger.Output(process.ExitCode.ToString());

                    if (process.ExitCode != 0)
                        return false;
                }
                catch (Exception e)
                {
                    Logger.Output(e.ToString());
                    return false;
                }

                return true;
            });
        }
    }
}
