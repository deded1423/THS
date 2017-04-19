using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THS.Utils;

namespace THS.Windows
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
            TextHearthstonePath.Text = ConfigFile.HearthstonePath;
            TextTwitchLoginName.Text = ConfigFile.TwitchLoginName;
            TextTwitchLoginOauth.Text = ConfigFile.TwitchLoginOauth;
            CheckBoxTCP.Checked = ConfigFile.SendTCP;
            TextTCPIP.Text = ConfigFile.TCPIP;
            TextTCPPort.Text = ConfigFile.TCPPort;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ButtonConfigAccept_Click(object sender, EventArgs e)
        {
            ConfigFile.HearthstonePath = TextHearthstonePath.Text;
            ConfigFile.TwitchLoginName = TextTwitchLoginName.Text;
            ConfigFile.TwitchLoginOauth = TextTwitchLoginOauth.Text;
            ConfigFile.SendTCP = CheckBoxTCP.Checked;
            ConfigFile.TCPIP = TextTCPIP.Text;
            ConfigFile.TCPPort = TextTCPPort.Text;
            ConfigFile.saveConfigFile();
            this.Dispose(true);
        }

        private void ButtonConfigCancel_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }
    }
}
