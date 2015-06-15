using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cocoand
{
    using Utils;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            Logger.logOutput = (String msg) =>
            {
                return listBox1.Items.Add(msg);
            };
            Logger.logUpdate = (int idx, String msg) =>
            {
                listBox1.Items[idx] = msg;
            };

            Logger.Output("1", "asdf");
            Logger.Update("1", "qwer\r\nqwerewqtwtwer");
            Logger.Output("2", "asdfasdfaf\r\nwqerqwrwx");

            //await Net.Download("http://dl.google.com/android/android-sdk_r24.3.2-windows.zip", "b.html");
            var urls = Config.Open("urls.json");
            var reqs = Models.Requirements.Open("cocoand.json");

            var template = "python helllo {python} DAT";
            urls.binder.Bind(template);
            Logger.Output(template);
            
        }
    }
}
