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
            try
            {
                String key = "path";
                String originalValue =
                    Environment.GetEnvironmentVariable(key, EnvironmentVariableTarget.User);

                if (originalValue.IndexOf(value) != -1)
                    return false;

                if (originalValue.Last() != ';')
                    originalValue += ";";

                return SetEnvVar(key, originalValue + value);
            }
            catch (Exception e)
            {
                Logger.Output(e.ToString());
                return false;
            }
        }
        public static bool SetEnvVar(String key, String value)
        {
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

        public static Task<bool> Execute(String target, String args)
        {
            return Task.Factory.StartNew(() =>
            {
                try
                {
                    var process = new Process();

                    Logger.Output(target);

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

                    //Console::WriteLine(stdout_);
                    //Console::WriteLine(stderr_);
                    //Console::WriteLine(process->ExitCode);
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
