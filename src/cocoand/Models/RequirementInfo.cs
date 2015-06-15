using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Cocoand.Models
{
    using Utils;

    [DataContract]
    class RequirementInfo : Config
    {
        [DataMember(Name = "uri")]
        public String uri
        {
            get;
            private set;
        }
        [DataMember(Name = "local")]
        public String local
        {
            get;
            private set;
        }
        [DataMember (Name = "path")]
        public String path
        {
            get;
            private set;
        }
        [DataMember (Name = "optional_if")]
        public String optionalIf
        {
            get;
            private set;
        }
        [DataMember (Name = "env_key")]
        public String envKey
        {
            get;
            private set;
        }
        [DataMember(Name = "cmd")]
        public String cmd
        {
            get;
            private set;
        }
    }
}
