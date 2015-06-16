namespace Cocoand.Forms
{
    partial class BuildStatusForm
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
            this.logs = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.run = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logs
            // 
            this.logs.BackColor = System.Drawing.Color.White;
            this.logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logs.Location = new System.Drawing.Point(0, 0);
            this.logs.Multiline = true;
            this.logs.Name = "logs";
            this.logs.ReadOnly = true;
            this.logs.Size = new System.Drawing.Size(542, 424);
            this.logs.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.run);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 39);
            this.panel1.TabIndex = 3;
            // 
            // run
            // 
            this.run.Dock = System.Windows.Forms.DockStyle.Right;
            this.run.Location = new System.Drawing.Point(392, 0);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(75, 39);
            this.run.TabIndex = 4;
            this.run.Text = "실행";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // close
            // 
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.Location = new System.Drawing.Point(467, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 39);
            this.close.TabIndex = 3;
            this.close.Text = "닫기";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // BuildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 424);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logs);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuildForm";
            this.ShowIcon = false;
            this.Text = "빌드";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Button close;
    }
}