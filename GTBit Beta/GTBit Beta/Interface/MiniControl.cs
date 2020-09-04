using System;
using System.Drawing;
using System.Windows.Forms;

namespace GTBit_Beta
{
    public partial class MiniControl : Form
    {
        MainForm ownerForm;

        public MiniControl()
        {
            InitializeComponent();
        }

        public event EventHandler RecordEvent;
        public event EventHandler PlayEvent;

        private void MiniControl_Load(object sender, EventArgs e)
        {
            ownerForm = (MainForm)this.Owner;

            this.SetDesktopLocation(0, 0);
            this.Size = new Size(this.Width, 35);

            this.Hide();
        }

        private Color getColor()
        {
            return ownerForm.BackColor;
        }

        public void updateStyle()
        {
            this.BackColor = getColor();

            if (MCbuttonRecord.Text == "Record")
                MCbuttonRecord.ForeColor = getColor();

            if (MCbuttonPlay.Text == "Play")
                MCbuttonPlay.ForeColor = getColor();
        }

        public void updateButtons()
        {
            if (ownerForm.buttonRecord.Text == "Stop")
            {
                MCbuttonRecord.Text = "Stop";
                MCbuttonRecord.ForeColor = Color.White;
            }
            else
            {
                MCbuttonRecord.Text = "Record";
                MCbuttonRecord.ForeColor = getColor();
            }
            if (ownerForm.buttonPlay.Text == "Stop")
            {
                MCbuttonPlay.Text = "Stop";
                MCbuttonPlay.ForeColor = Color.White;
            }
            else
            {
                MCbuttonPlay.Text = "Play";
                MCbuttonPlay.ForeColor = getColor();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            RecordEvent?.Invoke(this, EventArgs.Empty);
            updateButtons();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            PlayEvent?.Invoke(this, EventArgs.Empty);
            updateButtons();
        }
    }
}
