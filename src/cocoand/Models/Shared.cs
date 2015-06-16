using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocoand.Models
{
    class Shared
    {
        public static List<InstallationInfo> installations;

        static Shared()
        {
            installations = new List<InstallationInfo>();
        }
    }
}
