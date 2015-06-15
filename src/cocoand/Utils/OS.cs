using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Cocoand.Utils
{
    class OS
    {
        public static bool AppendEnvPath(String value)
        {
            String key = "path";
            String originalValue = 
                Environment.GetEnvironmentVariable(key, EnvironmentVariableTarget.User);

            if(originalValue.IndexOf(value) != -1)
                return false;

            Environment.SetEnvironmentVariable(
		        key,
		        originalValue + ";" + value,
		        EnvironmentVariableTarget.User);

            return true;
        }
        public static bool Execute(String target, String args)
        {
            try{
		        var process = new Process();

                process.StartInfo.FileName = target;
                process.StartInfo.Arguments = args;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;

                process.Start();
                process.WaitForExit();
		        
		        var stdout = 
			        process.StandardOutput.ReadToEnd();
		        var stderr = 
			        process.StandardOutput.ReadToEnd();

		        //Console::WriteLine(stdout_);
		        //Console::WriteLine(stderr_);
		        //Console::WriteLine(process->ExitCode);
	        }
	        catch(Exception e){
                Logger.Output(e.ToString());
		        return false;
	        }

            return true;
        }
    }
}
