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
    public partial class StartForm : Form
    {
        ClientControl client = new ClientControl();
        public StartForm()
        {
            InitializeComponent();
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            string ip;
            int port;
            ip = IpTextBox.Text.Trim();
            int.TryParse(PortTextBox.Text.Trim(), out port);
            client.Connect(ip, port);
            this.Hide();
            ChatForm chat = new ChatForm();
            chat.ShowDialog();
        }
    }
}
