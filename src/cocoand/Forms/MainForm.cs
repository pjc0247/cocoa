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
    }
}
