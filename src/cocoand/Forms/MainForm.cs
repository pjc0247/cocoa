using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cocoand.Forms
{
    using Utils;
    using Models;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Logger.logOutput = (String msg) =>
            {
                return listBox1.Items.Add(msg);
            };
            Logger.logUpdate = (int idx, String msg) =>
            {
                listBox1.Items[idx] = msg;
            };

            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void configureSetup_Click(object sender, EventArgs e)
        {
            var form = new ConfigureForm();
            form.ShowDialog();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            /*
            var reqs = Models.Requirements.Open("requirements.json");

            var ii = new InstallationInfo(reqs.items[0]);


            Shared.installations[ii.name] = ii;
             * */

            foreach (var pair in Shared.installations)
            {
                Logger.Output(pair.Value.name);
                await Installer.Install(pair.Value);

                Logger.Output("INSTALLLED " + pair.Key);
            }
        }
    }
}
