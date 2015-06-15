using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocoand.Utils
{
    class Logger
    {
        public static Func<String,int> logOutput
        {
            get;
            set;
        }
        public static Action<int, String> logUpdate
        {
            get;
            set;
        }

        private static Dictionary<Object, int> logs = new Dictionary<Object, int>();

        public static void Output(Object id, String log)
        {
            var idx = 0;

            if (logOutput != null)
            {
                var delim = new string[] { Environment.NewLine };
                foreach (var line in log.Split(delim, StringSplitOptions.RemoveEmptyEntries))
                    idx = logOutput(line);
            }
            else
                Console.WriteLine(log);

            if(id != null)
                logs[id] = idx;
        }
        public static void Output(String log)
        {
            Output(null, log);
        }
        public static void Update(Object id, String log)
        {
            var idx = logs[id];

            if (logUpdate != null)
                logUpdate(idx, log);
            else
                Console.WriteLine(log);
        }
    }
}
