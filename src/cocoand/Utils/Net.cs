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
            public Action<DownloadProgressChangedEventArgs> downloadProgressCallback
            {
                get;
                set;
            }

            public WrappedWebClient(
                String uri, String dst,
                Action<DownloadProgressChangedEventArgs> downloadProgressCallback)
            {
                this.uri = uri;
                this.dst = dst;
                this.downloadProgressCallback = downloadProgressCallback;
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

            if (wc.downloadProgressCallback != null)
                wc.downloadProgressCallback(args);
        }

        public static Task DownloadAsync(
            String uri, String dst,
            Action<DownloadProgressChangedEventArgs> downloadProgressCallback)
        {
            var wc = new WrappedWebClient(
                uri, dst, downloadProgressCallback);
            wc.DownloadProgressChanged += OnDownloadProgressChanged;
            Logger.Output(
                wc,
                "다운로드 중 ... : {0}", dst);

            return wc.DownloadFileTaskAsync(uri, dst);
        }
        public static async Task<long> QuerySize(String uri)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(uri);
            req.Method = "HEAD";
            HttpWebResponse resp = (HttpWebResponse)(await req.GetResponseAsync());
            return resp.ContentLength;
        }
    }
}
