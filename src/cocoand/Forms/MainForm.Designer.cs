namespace Cocoand.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.configureSetup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.logs = new System.Windows.Forms.ListBox();
            this.showLogs = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // configureSetup
            // 
            this.configureSetup.Location = new System.Drawing.Point(329, 39);
            this.configureSetup.Name = "configureSetup";
            this.configureSetup.Size = new System.Drawing.Size(121, 32);
            this.configureSetup.TabIndex = 2;
            this.configureSetup.Text = "설치 구성";
            this.configureSetup.UseVisualStyleBackColor = true;
            this.configureSetup.Click += new System.EventHandler(this.configureSetup_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 68);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(329, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "빌드";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // logs
            // 
            this.logs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logs.FormattingEnabled = true;
            this.logs.HorizontalScrollbar = true;
            this.logs.ItemHeight = 18;
            this.logs.Location = new System.Drawing.Point(0, 292);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(714, 400);
            this.logs.TabIndex = 5;
            // 
            // showLogs
            // 
            this.showLogs.Location = new System.Drawing.Point(583, 253);
            this.showLogs.Name = "showLogs";
            this.showLogs.Size = new System.Drawing.Size(131, 33);
            this.showLogs.TabIndex = 6;
            this.showLogs.Text = "로그 표시";
            this.showLogs.UseVisualStyleBackColor = true;
            this.showLogs.Click += new System.EventHandler(this.showLogs_Click);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(12, 205);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(690, 25);
            this.progress.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 692);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.showLogs);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.configureSetup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button configureSetup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox logs;
        private System.Windows.Forms.Button showLogs;
        private System.Windows.Forms.ProgressBar progress;
    }
}