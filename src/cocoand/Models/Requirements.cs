using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization;
using JsonFx.Json;
using JsonFx.Serialization;
using JsonFx.Serialization.Resolvers;

namespace Cocoand.Models
{
    [DataContract]
    class Requirements
    {
        public static Requirements Open(String path)
        {
            var requirements = new Requirements();
            var reader = new JsonReader(
                new DataReaderSettings(new DataContractResolverStrategy()));
            var json = File.ReadAllText(path);

            requirements.items =
                reader.Read<Dictionary<String, RequirementInfo>>(json);

            return requirements;
        }

        public Dictionary<String,RequirementInfo> items
        {
            get;
            private set;
        }
    }
}
