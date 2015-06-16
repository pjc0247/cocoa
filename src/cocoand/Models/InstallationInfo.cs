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
        public long size
        {
            get;
            internal set;
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
            name = info.name;
            local = info.local;
            path = info.path;
            optionalIf = info.optionalIf;
            envKey = info.envKey;
            cmds = info.cmds;

            size = 0;
            isRegistEnvVar = true;
            isSelected = true;
        }
    }
}
