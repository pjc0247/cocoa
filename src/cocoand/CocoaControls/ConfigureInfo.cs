using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cocoand.CocoaControls
{
    using Models;
    using Utils;

    public partial class ConfigureInfo : UserControl
    {
        private RequirementInfo _info;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Models.RequirementInfo info
        {
            set
            {
                _info = value;
                RefreshData();
            }
            get
            {
                return _info;
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public long contentSize
        {
            get;
            private set;
        }

        [Category("RequirementsInfo")]
        [DefaultValue(true)]
        public bool isSelected
        {
            get
            {
                return isSelectedBox.Checked;
            }
            set
            {
                isSelectedBox.Checked = value;
            }
        }
        [Category("RequirementsInfo")]
        [DefaultValue(true)]
        public bool isRegistEnvVar
        {
            get
            {
                return isRegistEnvVarBox.Checked;
            }
            set
            {
                isRegistEnvVarBox.Checked = value;
            }
        }


        public ConfigureInfo()
        {
            InitializeComponent();
        }

        private void ConfigureInfo_Load(object sender, EventArgs e)
        {

        }
        private async void RefreshData()
        {
            group.Text = info.name;
            path.Text = info.path;
            isRegistEnvVarBox.Checked = info.envKey.Length != 0;

            contentSize = await Net.QuerySize(info.uri);
            contentSizeLabel.Text =
                String.Format(
                    "size : {0}mb", contentSize.ToString());
        }

        private void isSelected_CheckedChanged(object sender, EventArgs e)
        {
            infoPanel.Enabled = isSelectedBox.Checked;
        }
    }
}
