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

            /* TODO :  Controller레벨에서 로깅 */
            Logger.Update(
                wc,
                "다운로드 중 ... : {0} ({1}%)",
                wc.dst, args.ProgressPercentage.ToString());
        }
        
        public static Task DownloadAsync(String uri, String dst){
            var wc = new WrappedWebClient(uri, dst);
            wc.DownloadProgressChanged += OnDownloadProgressChanged;
            Logger.Output(
                wc,
                "다운로드 중 ... : {0}", uri);

            return wc.DownloadFileTaskAsync(uri, dst);
        }
        public static async Task<long> QuerySize(String uri)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(uri);
            req.Method = "HEAD";
            HttpWebResponse resp = (HttpWebResponse)(await req.GetResponseAsync());
            Logger.Output(resp.ContentLength.ToString());
            return resp.ContentLength;
        }
    }
}
