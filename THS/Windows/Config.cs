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
        }

        private void ButtonConfigAccept_Click(object sender, EventArgs e)
        {
            ConfigFile.HearthstonePath = TextHearthstonePath.Text;
            ConfigFile.TwitchLoginName = TextTwitchLoginName.Text;
            ConfigFile.TwitchLoginOauth = TextTwitchLoginOauth.Text;
            ConfigFile.SaveConfigFile();
            this.Dispose(true);
        }

        private void ButtonConfigCancel_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }
        
    }
}
