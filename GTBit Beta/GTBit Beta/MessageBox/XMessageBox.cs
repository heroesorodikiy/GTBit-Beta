using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTBit_Beta
{
    public partial class XMessageBox : Form
    {
        public XMessageBox()
        {
            InitializeComponent();
        }

        private void XMessageBox_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
