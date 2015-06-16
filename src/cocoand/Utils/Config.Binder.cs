using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Linq;

namespace Cocoand.Utils
{
    public partial class Config
    {
        public class Binder
        {
            private static readonly Regex escaper;

            private Config target
            {
                get;
                set;
            }

            static Binder()
            {
                escaper = new Regex("#\\(([^\\(\\)]+)\\)");
            }
            
            public Binder(Config target)
            {
                this.target = target;
            }

            public String Bind(String template)
            {
                String result = template;
                var matches = escaper.Matches(template);

                foreach (Match val in matches)
                {
                    var key = val.Groups[1].Value;
                    result = result.Replace(val.Value, (String)target.data[key]);
                }

                return result;
            }
        }
    }
}
