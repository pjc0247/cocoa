using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocoand.Models
{
    class InstallationInfo : RequirementInfo
    {
        public bool isSelected
        {
            get;
            private set;
        }
        public bool isRegistEnvVar
        {
            get;
            private set;
        }

        public InstallationInfo()
            : base()
        {

        }
    }
}
