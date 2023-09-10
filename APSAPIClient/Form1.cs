using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APSAPIClient
{
    public partial class Form1 : Form
    {
        NetworkStream nwStream;
        bool listening;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            TcpClient client = new TcpClient(textBoxIP.Text, int.Parse(textBoxPort.Text));
            nwStream = client.GetStream();
            listening = true;
            Task.Run(() =>
            {
                while (listening)
                {
                    byte[] bytesToRead = new byte[client.ReceiveBufferSize];
                    int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
                    Invoke((MethodInvoker)delegate () {
                        textBoxFeedback.Text += Encoding.ASCII.GetString(bytesToRead, 0, bytesRead);
                    });
                }
                client.Close();
            });
            buttonDisconnect.Enabled = true;
            buttonDisplayTest.Enabled = true;
            buttonFireTimerWithID.Enabled = true;
            buttonSend.Enabled = true;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            SendCommand(textBoxCommand.Text);
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            listening = false;
        }

        private void buttonDisplayTest_Click(object sender, EventArgs e)
        {
            SendCommand("DisplayTest");
        }

        private void buttonOpenStart_Presentation_Click(object sender, EventArgs e)
        {
            string command = "OpenStart_Presentation";
            string slideNum = "2";
            string isFullscreen = "1";
            string filePath = @"C:\1.pptx";

            if (!File.Exists(filePath))
            {
                MessageBox.Show(string.Format("Please make sure {0} is exist or change the path from the code", filePath));
                return;
            }
            
            SendCommand(string.Format("{0}^{1}^{2}^{3}", command, slideNum, isFullscreen, filePath));

        }

        private void SendCommand(string command)
        {
            Console.WriteLine("Sending : " + command);
            byte[] bytesToSend = Encoding.ASCII.GetBytes(string.Format("{0}$", command));
            nwStream.Write(bytesToSend, 0, bytesToSend.Length);
        }

    }
}
