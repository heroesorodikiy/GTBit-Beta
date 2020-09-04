using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GTBit_Beta
{
    public partial class XAbout : Form
    {
        public XAbout()
        {
            InitializeComponent();
        }


        private void XAbout_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/7sPy6bE");
        }
    }
}
