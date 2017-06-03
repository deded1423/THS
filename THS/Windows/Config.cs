using System;
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
            CheckBoxSendTCP.Checked = ConfigFile.SendTCP;
            TextSendTCPIP.Text = ConfigFile.SendTCPIP;
            TextSendTCPPort.Text = ConfigFile.SendTCPPort;
            CheckBoxReceiveTCP.Checked = ConfigFile.ReceiveTCP;
            TextReceiveTCPIP.Text = ConfigFile.ReceiveTCPIP;
            TextReceiveTCPPort.Text = ConfigFile.ReceiveTCPPort;
        }

        private void ButtonConfigAccept_Click(object sender, EventArgs e)
        {
            ConfigFile.HearthstonePath = TextHearthstonePath.Text;
            ConfigFile.TwitchLoginName = TextTwitchLoginName.Text;
            ConfigFile.TwitchLoginOauth = TextTwitchLoginOauth.Text;
            ConfigFile.SendTCP = CheckBoxSendTCP.Checked;
            ConfigFile.SendTCPIP = TextSendTCPIP.Text;
            ConfigFile.SendTCPPort = TextSendTCPPort.Text;
            ConfigFile.ReceiveTCP = CheckBoxReceiveTCP.Checked;
            ConfigFile.ReceiveTCPIP = TextReceiveTCPIP.Text;
            ConfigFile.ReceiveTCPPort = TextReceiveTCPPort.Text;
            ConfigFile.saveConfigFile();
            this.Dispose(true);
        }

        private void ButtonConfigCancel_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void CheckBoxSendTCP_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxReceiveTCP.Checked = false;
        }

        private void CheckBoxReceiveTCP_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxSendTCP.Checked = false;
        }
    }
}
