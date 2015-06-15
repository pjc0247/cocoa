using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Cocoand.Utils
{
    class Net
    {
        private class WrappedWebClient : WebClient
        {
            public String uri
            {
                get;
                set;
            }
            public String dst
            {
                get;
                set;
            }

            public WrappedWebClient(String uri, String dst)
            {
                this.uri = uri;
                this.dst = dst;
            }
        }

        public static void OnDownloadProgressChanged(Object sender, DownloadProgressChangedEventArgs args)
        {
            WrappedWebClient wc = sender as WrappedWebClient;

            Logger.Update(
                wc,
                "downloading " + wc.dst + " : " + args.ProgressPercentage.ToString());
        }
        
        public static Task Download(String uri, String dst){
            var wc = new WrappedWebClient(uri, dst);
            wc.DownloadProgressChanged += OnDownloadProgressChanged;
            Logger.Output(
                wc,
                "downloading : ");

            return wc.DownloadFileTaskAsync(uri, dst);
        }
    }
}
