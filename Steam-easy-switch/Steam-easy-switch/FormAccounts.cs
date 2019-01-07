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
using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Steam_easy_switch
{
    public partial class FormAccounts : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public FormAccounts()
        {
            InitializeComponent();
            load();
        }

        private void panel_Hover(object sender, PanelP.HoverEventArgs e)
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
            PanelP panel = new Steam_easy_switch.PanelP(); 
            System.Windows.Forms.TableLayoutPanel tlPanel = new System.Windows.Forms.TableLayoutPanel();
            System.Windows.Forms.Label labelAccountName = new System.Windows.Forms.Label();
            System.Windows.Forms.Label labelPersonaName = new System.Windows.Forms.Label();
            System.Windows.Forms.PictureBox pictureBox = new System.Windows.Forms.PictureBox();

            // 
            // panel
            // 
             //panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
             panel.Controls.Add(tlPanel);
             panel.Location = new System.Drawing.Point(22, 278);
             panel.Name = "panel";
             panel.Size = new System.Drawing.Size(150, 187);
             panel.TabIndex = 0;
             panel.Hover += new System.EventHandler<Steam_easy_switch.PanelP.HoverEventArgs>(this.panel_Hover);
             panel.Click += new System.EventHandler(this.panel_Click);
             panel.AccountName = accountName;
             panel.Cursor = System.Windows.Forms.Cursors.Hand;
             panel.BackColor = Color.FromArgb(255, 33, 34, 39);

            // 
            // tlPanel
            // 
             tlPanel.ColumnCount = 1;
             tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
             tlPanel.Controls.Add(labelAccountName, 0, 0);
             tlPanel.Controls.Add(labelPersonaName, 0, 4);
             tlPanel.Controls.Add(pictureBox, 0, 2);
             tlPanel.Location = new System.Drawing.Point(3, 3);
             tlPanel.Name = "tlPanel";
             tlPanel.RowCount = 5;
             tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
             tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
             tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
             tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
             tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
             tlPanel.Size = new System.Drawing.Size(142, 179);
             tlPanel.TabIndex = 0;
             tlPanel.Click += new System.EventHandler(this.panel_Click);
             tlPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // labelAccountName
            // 
             labelAccountName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
             labelAccountName.AutoSize = true;
             labelAccountName.Font = new System.Drawing.Font("D-DIN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
             labelAccountName.Location = new System.Drawing.Point(31, 0);
             labelAccountName.Name = "labelAccountName";
             labelAccountName.Size = new System.Drawing.Size(79, 22);
             labelAccountName.TabIndex = 0;
             labelAccountName.Text = accountName;
             labelAccountName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
             labelAccountName.Cursor = System.Windows.Forms.Cursors.Hand;
             labelAccountName.Click += new System.EventHandler(this.panel_Click);
            // 
            // labelPersonaName
            // 
             labelPersonaName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
             labelPersonaName.AutoSize = true;
             labelPersonaName.Font = new System.Drawing.Font("D-DIN Exp", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
             labelPersonaName.Location = new System.Drawing.Point(18, 148);
             labelPersonaName.Name = "labelPersonaName";
             labelPersonaName.Size = new System.Drawing.Size(106, 31);
             labelPersonaName.TabIndex = 3;
             labelPersonaName.Text = personalName;
             labelPersonaName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
             labelPersonaName.Cursor = System.Windows.Forms.Cursors.Hand;
             labelPersonaName.Click += new System.EventHandler(this.panel_Click);
            // 
            // pictureBox
            // 
             pictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
             pictureBox.Image = picture;
             pictureBox.Location = new System.Drawing.Point(11, 28);
             pictureBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
             pictureBox.Name = "pictureBox";
             pictureBox.Size = new System.Drawing.Size(120, 120);
             pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
             pictureBox.TabIndex = 2;
             pictureBox.Click += new System.EventHandler(this.panel_Click);
             pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
             pictureBox.TabStop = false;

             pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;


             return panel;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = e.Graphics;
            System.Drawing.Rectangle gradient_rectangle = new System.Drawing.Rectangle(0, 0, this.Width, this.Height);
            System.Drawing.Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(gradient_rectangle, Color.FromArgb(255, 33, 41, 52), Color.FromArgb(255, 42, 46, 51), 90f);
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void panel_Click(object sender, EventArgs e)
        {
            if(sender is PanelP)
            {
                foreach (Process proc in Process.GetProcessesByName("Steam"))
                {
                     proc.Kill();
                }
                System.Threading.Thread.Sleep(100);

                System.Diagnostics.Process pp = new System.Diagnostics.Process();
                pp.StartInfo.FileName = "Registry_changer.exe";
                pp.StartInfo.Arguments = ((PanelP)sender).AccountName;

                try
                {
                   pp.Start();
                   //Registry.CurrentUser.OpenSubKey("SOFTWARE\\Valve\\Steam",true).SetValue("AutoLoginUser",((PanelP)sender).AccountName);
                   String strSteamInstallPath = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Valve\\Steam").GetValue("InstallPath").ToString();
                   //MessageBox.Show("Open your steam now!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   Process.Start(strSteamInstallPath + "\\steam.exe");
                }
                catch (Win32Exception ee)
                {
                    MessageBox.Show("Error: " + ee.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                pbClose_Click(null, null);
            }
            else
            {
                panel_Click(((Control)sender).Parent, e);
            }

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void panelOptions_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}
