using Gameloop.Vdf;
using Gameloop.Vdf.Linq;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steam_easy_switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            load();
        }

        private void panelP1_Hover(object sender, PanelP.HoverEventArgs e)
        {
            if (e.Active)
            {
                ((PanelP)sender).BackColor = Color.FromArgb(255,32,38,53);
            }
            else
            {
                ((PanelP)sender).BackColor = Color.FromArgb(255, 33, 34, 39);
            }
        }

        private void load()
        {
            String strSteamInstallPath = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Valve\\Steam").GetValue("InstallPath").ToString();
            Console.WriteLine(strSteamInstallPath);
            VProperty volvo = VdfConvert.Deserialize(File.ReadAllText(strSteamInstallPath + "\\config\\loginusers.vdf"));
            foreach(VToken vt in volvo.Value.ToList()){
                dynamic user = VdfConvert.Deserialize(vt.ToString());
                Int64 steamId = Convert.ToInt64(user.Key);
                String accountName = user.Value.AccountName.ToString();
                String personalName = user.Value.PersonaName.ToString();
                Console.WriteLine(accountName);
                Image picture;

                try
                {
                    picture = Image.FromFile(strSteamInstallPath + "\\config\\avatarcache\\" + steamId + ".png");
                }
                catch (FileNotFoundException E)
                {
                    picture = Steam_easy_switch.Properties.Resources.questionPicture;
                }


                flPanel.Controls.Add(createPanel(picture, accountName, personalName));
                flPanel.Update();
                flPanel.Show();
                                
            }


        }

        private PanelP createPanel(Image picture, String accountName, String personalName)
        {
            System.Windows.Forms.Label labelPersonaName = new System.Windows.Forms.Label();
            System.Windows.Forms.Label labelAccountName = new System.Windows.Forms.Label();
            System.Windows.Forms.PictureBox pictureBox = new System.Windows.Forms.PictureBox();
            PanelP panelP = new Steam_easy_switch.PanelP();

            // 
            // panelP
            // 
            panelP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelP.Controls.Add(this.labelPersonaName);
            panelP.Controls.Add(this.pictureBox);
            panelP.Controls.Add(this.labelAccountName);
            panelP.BackColor = Color.AliceBlue;
            panelP.Name = "panelP";
            panelP.Size = new System.Drawing.Size(120, 150);
            panelP.Hover += new System.EventHandler<Steam_easy_switch.PanelP.HoverEventArgs>(this.panelP1_Hover);
            // 
            // labelPersonaName
            // 
            labelPersonaName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            labelPersonaName.AutoSize = true;
            labelPersonaName.Font = new System.Drawing.Font("D-DIN Exp", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPersonaName.Location = new System.Drawing.Point(12, 119);
            labelPersonaName.Margin = new System.Windows.Forms.Padding(0);
            labelPersonaName.Name = "labelPersonaName";
            labelPersonaName.Size = new System.Drawing.Size(97, 17);
            labelPersonaName.Text = personalName;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBox.Image = picture;
            pictureBox.Location = new System.Drawing.Point(19, 29);
            pictureBox.Margin = new System.Windows.Forms.Padding(0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new System.Drawing.Size(80, 80);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox.TabStop = false;
            // 
            // labelAccountName
            // 
            labelAccountName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            labelAccountName.AutoSize = true;
            labelAccountName.Font = new System.Drawing.Font("D-DIN", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelAccountName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(120)))), ((int)(((byte)(127)))));
            labelAccountName.Location = new System.Drawing.Point(22, 9);
            labelAccountName.Margin = new System.Windows.Forms.Padding(0);
            labelAccountName.Name = "labelAccountName";
            labelAccountName.Size = new System.Drawing.Size(72, 12);
            labelAccountName.Text = accountName;
            

            return panelP;
        }

       


    }
}
