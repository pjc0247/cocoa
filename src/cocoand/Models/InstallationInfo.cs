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
            protected set;
        }
        public bool isRegistEnvVar
        {
            get;
            protected set;
        }

        public InstallationInfo()
            : base()
        {

        }
        public InstallationInfo(
            RequirementInfo info)
            : base()
        {
            uri = info.uri;
            local = info.local;
            path = info.path;
            optionalIf = info.optionalIf;
            envKey = info.envKey;
            cmd = info.cmd;
        }
    }
}
