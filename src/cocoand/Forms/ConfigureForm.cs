using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Cocoand.Forms
{
    using Utils;
    using Models;
    using CocoaControls;

    public partial class ConfigureForm : Form
    {
        private List<ConfigureInfo> configureControls;

        public ConfigureForm()
        {
            InitializeComponent();

            configureControls = new List<ConfigureInfo>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //await Net.Download("http://dl.google.com/android/android-sdk_r24.3.2-windows.zip", "b.html");
            //var urls = Config.Open("requirements.json");
            var reqs = Models.Requirements.Open("requirements.json");

            var template = "python helllo #(python) DAT";

            Logger.Output(reqs.items[0].binder.Bind("path #(path)"));

            Logger.Output(template);

            var offset = 0;
            var margin = 10;
            var width = 0;
            foreach(var requirement in reqs.items)
            {
                var control = new ConfigureInfo();
                control.Location = new Point(1, offset);
                control.info = requirement;
                configPanel.Controls.Add(control);

                width = control.Size.Width + control.Margin.Size.Width;
                offset += control.Size.Height + margin;

                configureControls.Add(control);
            }
            
            configPanel.Size = new Size(width, configPanel.Size.Height + offset);

            ClientSize = new Size(width, configPanel.Size.Height + 20);
        }

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            foreach (var configureControl in configureControls)
            {
                var key = configureControl.info.name;
                var info = new InstallationInfo(configureControl.info);
                info.size = configureControl.contentSize;

                Shared.installations[key] = info;
            }

            Close();
        }
    }
}
