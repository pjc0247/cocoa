using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Windows;

namespace Cocoand.Forms
{
    using Utils;
    using Models;

    public partial class MainForm : Form
    {
        private int progressCommitted
        {
            get;
            set;
        }
        private int progressCurrent
        {
            get;
            set;
        }

        public MainForm()
        {
            InitializeComponent();

            progressCommitted = 0;
            progressCurrent = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Logger.logOutput = (String msg) =>
            {
                var task = new Func<int>(delegate()
                {
                    var idx = logs.Items.Add(msg);
                    var visibleItems = logs.ClientSize.Height / logs.ItemHeight;
                    logs.TopIndex = Math.Max(logs.Items.Count - visibleItems + 1, 0);

                    return idx;
                });

                if (this.logs.InvokeRequired)
                    return (int)this.logs.Invoke(task);
                else 
                    return task();
            };
            Logger.logUpdate = (int idx, String msg) =>
            {

                this.logs.Invoke(new Action(delegate()
                {
                    logs.Items[idx] = msg;
                }));
            };

            logs.Visible = false;

            ClientSize = new Size(ClientSize.Width, ClientSize.Height - logs.Size.Height);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void configureSetup_Click(object sender, EventArgs e)
        {
            var form = new ConfigureForm();
            form.ShowDialog();
        }

        private void DownloadProgressCallback(DownloadProgressChangedEventArgs args)
        {
            progressCurrent = Convert.ToInt32(args.BytesReceived);

            progress.Value = progressCommitted + progressCurrent;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            /*
            var reqs = Models.Requirements.Open("requirements.json");

            var ii = new InstallationInfo(reqs.items[0]);


            Shared.installations[ii.name] = ii;
             * */

            var totalSize = 
                Shared.installations.AsEnumerable()
                .Sum(i=>i.Value.size);

            progress.Maximum = Convert.ToInt32(totalSize);
            progress.Minimum = 0;

            foreach (var pair in Shared.installations)
            {
                Logger.Output(pair.Value.name);
                var result =
                    await Installer.Install(pair.Value, DownloadProgressCallback);

                if (result)
                    Logger.Output("설치 완료 : " + pair.Key);
                else
                    Logger.Output("설치 실패 : " + pair.Key);

                progressCommitted += progressCurrent;
            }
            Logger.Output("작업 종료");
        }

        private void showLogs_Click(object sender, EventArgs e)
        {
            if (logs.Visible)
            {
                ClientSize = new Size(ClientSize.Width, ClientSize.Height - logs.Size.Height);
            }
            else
            {
                ClientSize = new Size(ClientSize.Width, ClientSize.Height + logs.Size.Height);
            }

            logs.Visible ^= true;
        }
    }
}
