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
    public class RequirementInfo : Config
    {
        [DataMember(Name = "name")]
        public String name
        {
            get;
            protected set;
        }

        [DataMember(Name = "uri")]
        public String uri
        {
            get;
            protected set;
        }
        [DataMember(Name = "local")]
        public String local
        {
            get;
            protected set;
        }
        [DataMember (Name = "path")]
        public String path
        {
            get;
            protected set;
        }
        [DataMember (Name = "optional_if")]
        public String optionalIf
        {
            get;
            protected set;
        }
        [DataMember (Name = "env_key")]
        public String envKey
        {
            get;
            protected set;
        }
        [DataMember(Name = "cmd")]
        public String cmd
        {
            get;
            protected set;
        }

        public new Object this[String key]
        {
            get
            {
                return GetType().GetProperty(key).GetValue(this);
            }
            set
            {
                GetType().GetProperty(key).SetValue(this, value);
            }
        }
        public RequirementInfo()
        {
            this.data = this;
        }
    }
}
