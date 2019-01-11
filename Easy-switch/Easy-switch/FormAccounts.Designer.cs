namespace Steam_easy_switch
{
    partial class FormAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccounts));
            this.flPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.panelOptions = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panelOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // flPanel
            // 
            this.flPanel.AutoSize = true;
            this.flPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.flPanel.Location = new System.Drawing.Point(12, 34);
            this.flPanel.Name = "flPanel";
            this.flPanel.Padding = new System.Windows.Forms.Padding(15);
            this.flPanel.Size = new System.Drawing.Size(659, 222);
            this.flPanel.TabIndex = 2;
            // 
            // pbClose
            // 
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = global::Easy_switch.Properties.Resources.close;
            this.pbClose.Location = new System.Drawing.Point(659, 9);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(10, 10);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 3;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("D-DIN Exp", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(10, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(92, 12);
            this.label.TabIndex = 4;
            this.label.Text = "Account switcher";
            this.label.Click += new System.EventHandler(this.label_Click);
            this.label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelOptions_MouseMove);
            // 
            // panelOptions
            // 
            this.panelOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelOptions.Controls.Add(this.pbClose);
            this.panelOptions.Controls.Add(this.label);
            this.panelOptions.Location = new System.Drawing.Point(2, 0);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(681, 28);
            this.panelOptions.TabIndex = 5;
            this.panelOptions.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelOptions_MouseMove);
            // 
            // FormAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(683, 268);
            this.Controls.Add(this.panelOptions);
            this.Controls.Add(this.flPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(203)))), ((int)(((byte)(216)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account switch";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.panelOptions.ResumeLayout(false);
            this.panelOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flPanel;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panelOptions;
        //private PanelP panel;
        //private System.Windows.Forms.TableLayoutPanel tlPanel;
        //private System.Windows.Forms.Label labelAccountName;
        //private System.Windows.Forms.Label labelPersonaName;
        //private System.Windows.Forms.PictureBox pictureBox;
    }
}

