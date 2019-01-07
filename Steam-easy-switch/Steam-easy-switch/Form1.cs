using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void label2_Click(object sender, EventArgs e)
        {

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


    }
}
