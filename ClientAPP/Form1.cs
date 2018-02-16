using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientAPP
{
    public partial class ChatForm : Form
    {
        ClientControl client = new ClientControl();
        string onemsg = "";



        public ChatForm()
        {
            InitializeComponent();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            string msg;
            msg = SendTextBox.Text.Trim();


            if (msg != "")
            {

                client.Send(msg);
                SendTextBox.Text = "";
               
            }
            else
            {
              
            }
        }


        private void ChatForm_Load(object sender, EventArgs e)
        {

            if (client.Connect("183.225.44.140", 22222) == 0)
            {

            }
            else
            {
                if (MessageBox.Show("连接超时，是否重连", "错误", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    client.Connect("192.168.0.104", 22222);
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            ReceiveTextBox.Text = "               " + "欢迎来到XXXX" + Environment.NewLine;
            ReceiveTextBox.Enabled = false;
        }

        private void Updatetime_Tick(object sender, EventArgs e)
        {
            string msg, msgrec;
            msg = msgrec = "";
            msg = SendTextBox.Text.Trim();
            msgrec = client.Received();


            if (msgrec != onemsg)
            {
                ReceiveTextBox.Text += msgrec + Environment.NewLine;
                onemsg = msgrec;
            }
            else
            {
            }

        }
    }
}
