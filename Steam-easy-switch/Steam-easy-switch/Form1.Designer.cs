namespace Steam_easy_switch
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelP1 = new Steam_easy_switch.PanelP();
            this.labelPersonaName = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.panelP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelP1
            // 
            this.panelP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelP1.Controls.Add(this.labelPersonaName);
            this.panelP1.Controls.Add(this.pictureBox);
            this.panelP1.Controls.Add(this.labelAccountName);
            this.panelP1.id64 = ((long)(0));
            this.panelP1.Location = new System.Drawing.Point(43, 32);
            this.panelP1.Name = "panelP1";
            this.panelP1.Size = new System.Drawing.Size(120, 150);
            this.panelP1.TabIndex = 1;
            this.panelP1.Hover += new System.EventHandler<Steam_easy_switch.PanelP.HoverEventArgs>(this.panelP1_Hover);
            // 
            // labelPersonaName
            // 
            this.labelPersonaName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPersonaName.AutoSize = true;
            this.labelPersonaName.Font = new System.Drawing.Font("D-DIN Exp", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonaName.Location = new System.Drawing.Point(12, 119);
            this.labelPersonaName.Margin = new System.Windows.Forms.Padding(0);
            this.labelPersonaName.Name = "labelPersonaName";
            this.labelPersonaName.Size = new System.Drawing.Size(97, 17);
            this.labelPersonaName.TabIndex = 2;
            this.labelPersonaName.Text = "CAPELINHA";
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(19, 29);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(80, 80);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // labelAccountName
            // 
            this.labelAccountName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAccountName.AutoSize = true;
            this.labelAccountName.Font = new System.Drawing.Font("D-DIN", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccountName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(120)))), ((int)(((byte)(127)))));
            this.labelAccountName.Location = new System.Drawing.Point(22, 9);
            this.labelAccountName.Margin = new System.Windows.Forms.Padding(0);
            this.labelAccountName.Name = "labelAccountName";
            this.labelAccountName.Size = new System.Drawing.Size(72, 12);
            this.labelAccountName.TabIndex = 1;
            this.labelAccountName.Text = "mateusoigreja";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(529, 270);
            this.Controls.Add(this.panelP1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(203)))), ((int)(((byte)(216)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelP1.ResumeLayout(false);
            this.panelP1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPersonaName;
        private System.Windows.Forms.Label labelAccountName;
        private System.Windows.Forms.PictureBox pictureBox;
        private PanelP panelP1;
    }
}

