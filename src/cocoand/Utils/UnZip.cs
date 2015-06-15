using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace Cocoand.Utils
{
    class UnZip
    {
        public static void Extract(String src, String dst)
        {
            Logger.Output(
                src + dst,
                "unzip : " + src + " / " + dst);

            /* fixme : progress */
            ZipFile.ExtractToDirectory(src, dst);

            Logger.Output(
                src + dst,
                "unzip : " + src + " / " + dst + " (done)");
        }
    }
}
