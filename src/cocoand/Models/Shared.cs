using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocoand.Models
{
    class Shared
    {
        public static Dictionary<String,InstallationInfo> installations;

        static Shared()
        {
            installations = new Dictionary<String,InstallationInfo>();
        }
    }
}
