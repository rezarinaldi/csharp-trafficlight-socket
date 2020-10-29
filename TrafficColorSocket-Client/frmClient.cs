using System;
using System.Windows.Forms;

namespace TrafficColorSocket_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rBMerahOn_CheckedChanged(object sender, EventArgs e)
        {
            if (rBMerahOn.Checked.Equals(true))
            {
                varGlobal.alamatIPServer = txtIPClient.Text;
                varGlobal.port = Int16.Parse(txtPortClient.Text);
                SocketTCP.StartClient("Red,On,");
            }
        }

        private void rBMerahOff_CheckedChanged(object sender, EventArgs e)
        {
            if (rBMerahOff.Checked.Equals(true))
            {
                varGlobal.alamatIPServer = txtIPClient.Text;
                varGlobal.port = Int16.Parse(txtPortClient.Text);
                SocketTCP.StartClient("Red,Off,");
            }
        }

        private void rBKuningOn_CheckedChanged(object sender, EventArgs e)
        {
            varGlobal.alamatIPServer = txtIPClient.Text;
            varGlobal.port = Int16.Parse(txtPortClient.Text);
            SocketTCP.StartClient("Yellow,On,");
        }

        private void rBKuningOff_CheckedChanged(object sender, EventArgs e)
        {
            varGlobal.alamatIPServer = txtIPClient.Text;
            varGlobal.port = Int16.Parse(txtPortClient.Text);
            SocketTCP.StartClient("Yellow,Off,");
        }

        private void rBHijauOn_CheckedChanged(object sender, EventArgs e)
        {
            varGlobal.alamatIPServer = txtIPClient.Text;
            varGlobal.port = Int16.Parse(txtPortClient.Text);
            SocketTCP.StartClient("Green,On,");
        }

        private void rBHijauOff_CheckedChanged(object sender, EventArgs e)
        {
            varGlobal.alamatIPServer = txtIPClient.Text;
            varGlobal.port = Int16.Parse(txtPortClient.Text);
            SocketTCP.StartClient("Green,Off,");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
