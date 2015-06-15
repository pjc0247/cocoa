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
    public class Requirements
    {
        public static Requirements Open(String path)
        {
            var requirements = new Requirements();
            var reader = new JsonReader(
                new DataReaderSettings(new DataContractResolverStrategy()));
            var json = File.ReadAllText(path);

            requirements.items =
                reader.Read<List<RequirementInfo>>(json);

            return requirements;
        }

        public List<RequirementInfo> items
        {
            get;
            private set;
        }
    }
}
