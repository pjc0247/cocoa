namespace Cocoand.Forms
{
    partial class ConfigureForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.configPanel = new System.Windows.Forms.Panel();
            this.ok = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // configPanel
            // 
            this.configPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.configPanel.Location = new System.Drawing.Point(0, 0);
            this.configPanel.Margin = new System.Windows.Forms.Padding(5);
            this.configPanel.Name = "configPanel";
            this.configPanel.Padding = new System.Windows.Forms.Padding(5);
            this.configPanel.Size = new System.Drawing.Size(315, 10);
            this.configPanel.TabIndex = 2;
            // 
            // ok
            // 
            this.ok.Dock = System.Windows.Forms.DockStyle.Right;
            this.ok.Location = new System.Drawing.Point(200, 10);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(115, 29);
            this.ok.TabIndex = 3;
            this.ok.Text = "적용";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // close
            // 
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.Location = new System.Drawing.Point(85, 10);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(115, 29);
            this.close.TabIndex = 4;
            this.close.Text = "취소";
            this.close.UseVisualStyleBackColor = true;
            // 
            // ConfigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 39);
            this.Controls.Add(this.close);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.configPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConfigureForm";
            this.Text = "설치 구성";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CocoaControls.ConfigureInfo configureInfo1;
        private System.Windows.Forms.Panel configPanel;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button close;
    }
}

