namespace Cocoand.CocoaControls
{
    partial class ConfigureInfo
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.group = new System.Windows.Forms.GroupBox();
            this.isSelectedBox = new System.Windows.Forms.CheckBox();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.browse = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.TextBox();
            this.isRegistEnvVarBox = new System.Windows.Forms.CheckBox();
            this.contentSizeLabel = new System.Windows.Forms.Label();
            this.group.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // group
            // 
            this.group.Controls.Add(this.infoPanel);
            this.group.Controls.Add(this.isSelectedBox);
            this.group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group.Location = new System.Drawing.Point(0, 0);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(621, 144);
            this.group.TabIndex = 3;
            this.group.TabStop = false;
            this.group.Text = "KEY";
            // 
            // isSelectedBox
            // 
            this.isSelectedBox.AutoSize = true;
            this.isSelectedBox.Location = new System.Drawing.Point(19, 27);
            this.isSelectedBox.Name = "isSelectedBox";
            this.isSelectedBox.Size = new System.Drawing.Size(130, 22);
            this.isSelectedBox.TabIndex = 10;
            this.isSelectedBox.Text = "설치 활성화";
            this.isSelectedBox.UseVisualStyleBackColor = true;
            this.isSelectedBox.CheckedChanged += new System.EventHandler(this.isSelected_CheckedChanged);
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.contentSizeLabel);
            this.infoPanel.Controls.Add(this.isRegistEnvVarBox);
            this.infoPanel.Controls.Add(this.label1);
            this.infoPanel.Controls.Add(this.browse);
            this.infoPanel.Controls.Add(this.path);
            this.infoPanel.Location = new System.Drawing.Point(6, 55);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(609, 84);
            this.infoPanel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "설치 경로";
            // 
            // browse
            // 
            this.browse.AutoSize = true;
            this.browse.Location = new System.Drawing.Point(471, 27);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(127, 28);
            this.browse.TabIndex = 11;
            this.browse.Text = "찾아보기";
            this.browse.UseVisualStyleBackColor = true;
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(13, 27);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(452, 28);
            this.path.TabIndex = 10;
            // 
            // isRegistEnvVarBox
            // 
            this.isRegistEnvVarBox.AutoSize = true;
            this.isRegistEnvVarBox.Location = new System.Drawing.Point(13, 61);
            this.isRegistEnvVarBox.Name = "isRegistEnvVarBox";
            this.isRegistEnvVarBox.Size = new System.Drawing.Size(154, 22);
            this.isRegistEnvVarBox.TabIndex = 13;
            this.isRegistEnvVarBox.Text = "환경 변수 등록";
            this.isRegistEnvVarBox.UseVisualStyleBackColor = true;
            // 
            // contentSizeLabel
            // 
            this.contentSizeLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.contentSizeLabel.Location = new System.Drawing.Point(274, 61);
            this.contentSizeLabel.Name = "contentSizeLabel";
            this.contentSizeLabel.Size = new System.Drawing.Size(324, 23);
            this.contentSizeLabel.TabIndex = 15;
            this.contentSizeLabel.Text = "SIZE";
            this.contentSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConfigureInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.group);
            this.Name = "ConfigureInfo";
            this.Size = new System.Drawing.Size(621, 144);
            this.Load += new System.EventHandler(this.ConfigureInfo_Load);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.CheckBox isSelectedBox;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.CheckBox isRegistEnvVarBox;
        private System.Windows.Forms.Label contentSizeLabel;
    }
}
