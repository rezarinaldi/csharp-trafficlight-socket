using System;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TrafficColorSocket_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            Thread thr = new Thread(listenSocket);
            if (txtIPServer.Text != "" && txtPortServer.Text != "")
            {
                thr.Start();
                btnListen.Enabled = false;
                txtIPServer.Enabled = false;
                txtPortServer.Enabled = false;
            }
            else
            {
                MessageBox.Show("Lengkapi port dan alamat IP terlebih dahulu !!!");
            }
        }

        private void listenSocket()
        {
            varGlobal.port = Int16.Parse(txtPortServer.Text); // konversi dari string ke integer
            varGlobal.alamatIPServer = txtIPServer.Text;
            SocketTCP.StartListening();
        }

        private void timerServer_Tick(object sender, EventArgs e)
        {
            if (varGlobal.terimapesandiserver.Length > 1)
            {
                string[] data = varGlobal.terimapesandiserver.Trim().Split(',');
                StringBuilder sb = new StringBuilder();
                sb.Append(data[0]).Append(" Light ").Append(data[1]);
                changer(data);
                txtStatusLabel.Text = sb.ToString();
            }
        }

        private void changer(string[] tmp)
        {
            Color color = Color.Gray;
            if (tmp[1].Equals("On"))
            {
                color = chooserColor(tmp[0]);
            }
            switch (tmp[0])
            {
                case "Red":
                    redPanel.BackColor = color;
                    break;
                case "Yellow":
                    yellowPanel.BackColor = color;
                    break;
                case "Green":
                    greenPanel.BackColor = color;
                    break;
            }
        }

        private Color chooserColor(String choose)
        {
            switch (choose)
            {
                case "Red":
                    return Color.Red;
                case "Yellow":
                    return Color.Yellow;
                case "Green":
                    return Color.Green;
                default:
                    return Color.Black;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
