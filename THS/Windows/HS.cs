using System;
using System.Collections;
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

namespace THS.Windows
{
    public partial class HS : Form
    {
        int handSize = 0, handNumber = 0, boardSize = 0, boardNumber = 0, boardEnemySize = 0, boardEnemyNumber = 0;
        bool enemy = true;

        ArrayList handSizeArray = new ArrayList(10), handNumberArray = new ArrayList(10), boardSizeArray = new ArrayList(10), boardNumberArray = new ArrayList(10), boardEnemySizeArray = new ArrayList(10), boardEnemyNumberArray = new ArrayList(10);

        TcpClient tcpClient;
        StreamReader inputStream;
        StreamWriter outputStream;


        public HS()
        {
            InitializeComponent();
            tcpClient = new TcpClient("127.0.0.1", 1234);
            inputStream = new StreamReader(tcpClient.GetStream());
            outputStream = new StreamWriter(tcpClient.GetStream());
            this.Text = "CONNECTED";
            outputStream.WriteLine("PASS ");
            outputStream.WriteLine("NICK ");
            outputStream.WriteLine("USER ");
            outputStream.Flush();
        }






        private void buttonHandSize_Click(object sender, EventArgs e)
        {
            handSize = int.Parse(((Button)sender).Text);
            foreach (var item in handSizeArray)
            {
                ((Button)item).BackColor = SystemColors.Control;
            }
            handSizeArray.Add(((Button)sender));
            ((Button)sender).BackColor = SystemColors.ControlDarkDark;
        }
        private void buttonHandNumber_Click(object sender, EventArgs e)
        {
            handNumber = int.Parse(((Button)sender).Text);
            foreach (var item in handNumberArray)
            {
                ((Button)item).BackColor = SystemColors.Control;
            }
            handNumberArray.Add(((Button)sender));
            ((Button)sender).BackColor = SystemColors.ControlDarkDark;
        }
        private void buttonBoardSize_Click(object sender, EventArgs e)
        {
            boardSize = int.Parse(((Button)sender).Text);
            buttonHero.BackColor = SystemColors.Control;
            foreach (var item in boardSizeArray)
            {
                ((Button)item).BackColor = SystemColors.Control;
            }
            boardSizeArray.Add(((Button)sender));
            ((Button)sender).BackColor = SystemColors.ControlDarkDark;
        }
        private void buttonBoardNumber_Click(object sender, EventArgs e)
        {
            boardNumber = int.Parse(((Button)sender).Text);
            buttonHero.BackColor = SystemColors.Control;
            foreach (var item in boardNumberArray)
            {
                ((Button)item).BackColor = SystemColors.Control;
            }
            boardNumberArray.Add(((Button)sender));
            ((Button)sender).BackColor = SystemColors.ControlDarkDark;
        }
        private void buttonBoardEnemySize_Click(object sender, EventArgs e)
        {
            boardEnemySize = int.Parse(((Button)sender).Text);
            buttonHeroEnemy.BackColor = SystemColors.Control;
            foreach (var item in boardEnemySizeArray)
            {
                ((Button)item).BackColor = SystemColors.Control;
            }
            boardEnemySizeArray.Add(((Button)sender));
            ((Button)sender).BackColor = SystemColors.ControlDarkDark;
        }
        private void buttonBoardEnemyNumber_Click(object sender, EventArgs e)
        {
            boardEnemyNumber = int.Parse(((Button)sender).Text);
            buttonHeroEnemy.BackColor = SystemColors.Control;
            foreach (var item in boardEnemyNumberArray)
            {
                ((Button)item).BackColor = SystemColors.Control;
            }
            boardEnemyNumberArray.Add(((Button)sender));
            ((Button)sender).BackColor = SystemColors.ControlDarkDark;
        }
        private void buttonHeroEnemy_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                boardEnemySize = -1;
                boardEnemyNumber = -1;
                foreach (var item in boardEnemyNumberArray)
                {
                    ((Button)item).BackColor = SystemColors.Control;
                }
                foreach (var item in boardEnemySizeArray)
                {
                    ((Button)item).BackColor = SystemColors.Control;
                }
                ((Button)sender).BackColor = SystemColors.ControlDarkDark;
            }
            else if (e.Button == MouseButtons.Right)
            {
                ((Button)sender).ForeColor = SystemColors.MenuHighlight;
                buttonHero.ForeColor = SystemColors.ControlText;
                enemy = true;
            }
        }
        private void buttonHero_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                boardSize = -1;
                boardNumber = -1;
                foreach (var item in boardNumberArray)
                {
                    ((Button)item).BackColor = SystemColors.Control;
                }
                foreach (var item in boardSizeArray)
                {
                    ((Button)item).BackColor = SystemColors.Control;
                }
               ((Button)sender).BackColor = SystemColors.ControlDarkDark;
            }
            else if (e.Button == MouseButtons.Right)
            {
                ((Button)sender).ForeColor = SystemColors.MenuHighlight;
                buttonHeroEnemy.ForeColor = SystemColors.ControlText;
                enemy = false;
            }
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {

        }
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            tcpClient = new TcpClient(buttonConnect.Text, 1234);
            inputStream = new StreamReader(tcpClient.GetStream());
            outputStream = new StreamWriter(tcpClient.GetStream());
        }
    }
}
