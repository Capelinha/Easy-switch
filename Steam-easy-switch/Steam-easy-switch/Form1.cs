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

        private void Form1_Load(object sender, EventArgs e)
        {
            String strSteamInstallPath = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Valve\\Steam").GetValue("InstallPath").ToString();
            Console.WriteLine(strSteamInstallPath);
            VProperty volvo = VdfConvert.Deserialize(File.ReadAllText(strSteamInstallPath + "\\config\\loginusers.vdf"));
            foreach(VToken vt in volvo.Value.ToList()){
                dynamic user = VdfConvert.Deserialize(vt.ToString());
                Int64 steamId = Convert.ToInt64(user.Key);
                String accountName = user.Value.AccountName.ToString();
                String personalName = user.Value.PersonaName.ToString();

                try
                {
                    Image picture = Image.FromFile(strSteamInstallPath + "\\config\\avatarcache\\" + steamId + ".png");
                }
                catch (FileNotFoundException E)
                {
                    Image picture = Steam_easy_switch.Properties.Resources.questionPicture;
                }
                                
            }


        }


    }
}
