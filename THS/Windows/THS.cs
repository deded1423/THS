using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using THS.Twitch_Integration;
using THS.Utils;
using THS.Input;
using System.IO;
using System.Diagnostics;
using System.Linq;
using HearthDb.Enums;
using THS.HSApp.Dictionaries;
using static THS.Input.Methods;

namespace THS.Windows
{

    public partial class THS : Form
    {
        //TODO: Cambiar todo esto para que este en otra clase??
        //TODO: Mirar que el programa cierra bien (Procesos y Files)
        //TODO: Cerrar bien el programa
        //TWITCH SHIT
        Queue<string> chat = new Queue<string>();
        static IrcClient irc;
        Thread _ircThread, ircprocessThread, manageThread;
        List<CommandChat> list = new List<CommandChat>();
        bool _stop = false;

        //UI SHIT
        private Config _configwindow;

        //IMPORT SHIT
        public static HSApp.HSCore GameCore;

        public int a = 0;
        public Dictionary<string, HearthDb.Card> all;

        public THS()
        {
            InitializeComponent();
            IO.OpenDebugFiles();
            ConfigFile.readConfigFile();
            irc = new IrcClient();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //var decks = Reflection.GetDecks();
            SetupTestButtons();

            manageThread = new Thread(() =>
            {
                while (!_stop)
                {
                    var num0 = Methods.GetKeyState(0x60);
                    var num1 = Methods.GetKeyState(0x61);
                    var num2 = Methods.GetKeyState(0x62);
                    var num3 = Methods.GetKeyState(0x63);
                    var num4 = Methods.GetKeyState(0x64);
                    var num5 = Methods.GetKeyState(0x65);
                    var num6 = Methods.GetKeyState(0x66);
                    var num7 = Methods.GetKeyState(0x67);
                    var num8 = Methods.GetKeyState(0x68);
                    var num9 = Methods.GetKeyState(0x69);
                    int index = 0;

                    if (num0 < 0)
                    {
                        //Select Action Menu
                        listViewActions.Invoke(new Action(() =>
                        {
                            if (listViewActions.SelectedItems.Count == 1)
                            {
                                //irc.SendChatMessage(listViewActions.SelectedItems[0].Text);&& irc != null
                                var cmd = new CommandChat(listViewActions.SelectedItems[0].Text.ToLower());

                                if (cmd.Type != PlayType.Incorrect)
                                {
                                    if (irc == null) return;
                                    irc.Queue.Enqueue(cmd);
                                    IO.LogDebug(cmd.ToString(), IO.DebugFile.Twitch, false);
                                }
                                else
                                {
                                    IO.LogDebug(listViewActions.SelectedItems[0].Text.ToLower(), IO.DebugFile.Twitch);
                                }
                            }
                        }));
                    }

                    if (num1 < 0)
                    {
                        //Select Discover 1
                        if (irc == null) return;
                        var cmd = new CommandChat("Discover 1");
                        irc.Queue.Enqueue(cmd);
                        IO.LogDebug(cmd.ToString(), IO.DebugFile.Twitch, false);
                    }

                    if (num2 < 0)
                    {
                        listViewActions.Invoke(new Action(() =>
                        {
                            if (listViewActions.SelectedItems.Count == 1 && listViewActions.Items.Count >= 2 && listViewActions.SelectedItems[0].Index < listViewActions.Items.Count - 1)
                            {
                                index = listViewActions.SelectedItems[0].Index;
                                listViewActions.SelectedItems[0].Selected = false;
                                listViewActions.Items[index + 1].Selected = true;
                            }
                        }));
                    }

                    if (num3 < 0)
                    {
                        //Select Choose 1
                        if (irc == null) return;
                        var cmd = new CommandChat("Choose 1");
                        irc.Queue.Enqueue(cmd);
                        IO.LogDebug(cmd.ToString(), IO.DebugFile.Twitch, false);
                    }

                    if (num4 < 0)
                    {
                        //Select Discover 2
                        if (irc == null) return;
                        var cmd = new CommandChat("Discover 2");
                        irc.Queue.Enqueue(cmd);
                        IO.LogDebug(cmd.ToString(), IO.DebugFile.Twitch, false);
                    }

                    if (num5 < 0)
                    {
                        buttonActions_Click(null, null);
                        listViewActions.Invoke(new Action(() =>
                        {
                            if (listViewActions.Items.Count >= 1)
                            {
                                listViewActions.Items[0].Selected = true;
                            }
                        }));
                    }

                    if (num3 < 0)
                    {
                        //Select Choose 2
                        if (irc == null) return;
                        var cmd = new CommandChat("Choose 2");
                        irc.Queue.Enqueue(cmd);
                        IO.LogDebug(cmd.ToString(), IO.DebugFile.Twitch, false);
                    }

                    if (num7 < 0)
                    {
                        //Select Discover 3
                        if (irc == null) return;
                        var cmd = new CommandChat("Discover 3");
                        irc.Queue.Enqueue(cmd);
                        IO.LogDebug(cmd.ToString(), IO.DebugFile.Twitch, false);
                    }

                    if (num8 < 0)
                    {
                        listViewActions.Invoke(new Action(() =>
                        {
                            if (listViewActions.SelectedItems.Count == 1 && listViewActions.Items.Count >= 2 && listViewActions.SelectedItems[0].Index >= 1)
                            {
                                index = listViewActions.SelectedItems[0].Index;
                                listViewActions.SelectedItems[0].Selected = false;
                                listViewActions.Items[index - 1].Selected = true;
                            }
                        }));
                    }
                    Thread.Sleep(100);
                }
            })
            { Name = "Input" };
            manageThread.Start();
        }
        private void THS_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Directory.Exists(Path.Combine(@"C: \Users\USER\Documents\Visual Studio 2015\Projects\THS\HearthDb", "hsdata")))
            {
                Directory.Delete(Path.Combine(@"C: \Users\USER\Documents\Visual Studio 2015\Projects\THS\HearthDb", "hsdata"));
            }
            _stop = true;
            GameCore.Stop();
            irc.Stop();
            Thread.Sleep(50);
            IO.CloseDebugFiles();
        }

        private void ButtonConfig_Click(object sender, EventArgs e)
        {
            _configwindow = new Config();
            _configwindow.Show();
        }
        private void ButtonStartHS_Click(object sender, EventArgs e)
        {
            if (ButtonStart.Text.Equals("Start"))
            {
                if (Process.GetProcessesByName("Hearthstone").Length != 0 || checkBoxHs.Checked)
                {
                    GameCore = new HSApp.HSCore(irc, this);
                    GameCore.Start();
                    ButtonStart.Text = "Stop";
                    Text = "THS";
                    if (DateTime.Compare(File.GetLastWriteTime(Path.Combine(ConfigFile.HearthstonePath, "Logs", "LoadingScreen.log")), File.GetLastWriteTime(Path.Combine(ConfigFile.HearthstonePath, "Logs", "Power.log"))) > 0)
                    {
                        IO.LogDebug("Delete Power.log");
                        if (!checkBoxDeletePower.Checked)
                        {
                            File.Delete(Path.Combine(ConfigFile.HearthstonePath, "Logs", "Power.log"));
                        }
                    }
                    Point[] screenCoords = GetWindowCoords("Hearthstone");
                    if (!checkBoxHs.Checked && (screenCoords[1].X != 1599 || screenCoords[1].Y != 900))
                    {
                        ButtonStart.Text = "Stop - \nWrong Resolution";
                    }
                }
                else
                {
                    Text = "THS - No Hearthstone";
                }
            }
            else
            {
                GameCore.Stop();
                ButtonStart.Text = "Start";
            }
        }
        private void buttonStartTCP_Click(object sender, EventArgs e)
        {

            if (buttonStartTCP.Text.Equals("Start Tcp"))
            {
                StartIRC();
                buttonStartTCP.Text = "Stop Tcp";
            }
            else
            {
                buttonStartTCP.Text = "Start Tcp";
            }
        }
        private void buttonTest_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Equals(buttonTest1))
            {
                PrintCards();
            }
            else if (((Button)sender).Equals(buttonTest2))
            {
                GameCore.Game.Debug();
            }
            else if (((Button)sender).Equals(buttonTest3))
            {

            }
            else if (((Button)sender).Equals(buttonTest4))
            {

            }
            else if (((Button)sender).Equals(buttonTest5))
            {

            }
            else if (((Button)sender).Equals(buttonTest6))
            {

            }
            else if (((Button)sender).Equals(buttonTest7))
            {

            }
            else if (((Button)sender).Equals(buttonTest8))
            {

            }
        }
        private void buttonActions_Click(object sender, EventArgs e)
        {
            listViewActions.Invoke(new Action(() =>
            {
                listViewActions.BeginUpdate();
                listViewActions.Items.Clear();
                if (GameCore == null)
                {
                    listViewActions.EndUpdate();
                    return;
                }
                foreach (var action in GameCore.Game.GetActions())
                {
                    var a = new string[1];
                    a[0] = action;
                    listViewActions.Items.Add(new ListViewItem(a));
                }
                listViewActions.EndUpdate();
            }));
        }
        private void buttonProcessIRC_Click(object sender, EventArgs e)
        {
            ircprocessThread = new Thread(irc.StartIRCProcessing) { Name = "TwitchChatProcesser" };
            ircprocessThread.Start();
            buttonProcessIRC.Text = "Started";

        }

        private void StartIRC()
        {
            if (checkBoxTCP.Checked)
            {
                irc.StartConnection("irc.freenode.net", 6667, "THStone1", "none");
                _ircThread = new Thread(irc.StartTwitchChat) { Name = "TwitchChatReader" };
                _ircThread.Start("THS");
            }
            else
            {
                irc.StartConnection("irc.twitch.tv", 6667, ConfigFile.TwitchLoginName, ConfigFile.TwitchLoginOauth);
                _ircThread = new Thread(irc.StartTwitchChat) { Name = "TwitchChatReader" };
                _ircThread.Start("deded1423");
            }
        }
        private void SetupTestButtons()
        {
            buttonTest1.Text = "Print Cards";
            buttonTest2.Text = "Debug";
            buttonTest3.Text = "";
            buttonTest4.Text = "";
            buttonTest5.Text = "";
            buttonTest6.Text = "";
            buttonTest7.Text = "";
            buttonTest8.Text = "";
        }
        public void UpdateUI()
        {
            listViewUserHand.Invoke(new Action(() =>
            {
                listViewUserHand.BeginUpdate();
                listViewUserHand.Items.Clear();
                foreach (var card in GameCore.Game.User.Hand)
                {
                    string[] arr = new string[6];
                    arr[0] = card.Id.ToString();
                    arr[1] = card.CardDB?.Name;
                    arr[2] = card.CardType.ToString();
                    arr[3] = card.TrueHealth.ToString();
                    arr[4] = card.Attack.ToString();
                    arr[5] = card.ManaCost.ToString();
                    listViewUserHand.Items.Add(new ListViewItem(arr));
                }
                listViewUserHand.EndUpdate();
            }));

            listViewOpponentHand.Invoke(new Action(() =>
            {
                listViewOpponentHand.BeginUpdate();
                listViewOpponentHand.Items.Clear();
                foreach (var card in GameCore.Game.Opponent.Hand)
                {
                    string[] arr = new string[6];
                    arr[0] = card.Id.ToString();
                    arr[1] = card.CardDB?.Name;
                    arr[2] = card.CardType.ToString();
                    arr[3] = card.TrueHealth.ToString();
                    arr[4] = card.Attack.ToString();
                    arr[5] = card.ManaCost.ToString();
                    listViewOpponentHand.Items.Add(new ListViewItem(arr));
                }
                listViewOpponentHand.EndUpdate();
            }));

            listViewUserBoard.Invoke(new Action(() =>
            {
                listViewUserBoard.BeginUpdate();
                listViewUserBoard.Items.Clear();
                foreach (var card in GameCore.Game.User.Play)
                {
                    string[] arr = new string[6];
                    arr[0] = card.Id.ToString();
                    arr[1] = card.CardDB?.Name;
                    arr[2] = card.CardType.ToString();
                    arr[3] = card.TrueHealth.ToString();
                    arr[4] = card.Attack.ToString();
                    arr[5] = card.ManaCost.ToString();
                    listViewUserBoard.Items.Add(new ListViewItem(arr));
                }
                listViewUserBoard.EndUpdate();
            }));

            listViewOpponentBoard.Invoke(new Action(() =>
            {
                listViewOpponentBoard.BeginUpdate();
                listViewOpponentBoard.Items.Clear();
                foreach (var card in GameCore.Game.Opponent.Play)
                {
                    string[] arr = new string[6];
                    arr[0] = card.Id.ToString();
                    arr[1] = card.CardDB?.Name;
                    arr[2] = card.CardType.ToString();
                    arr[3] = card.TrueHealth.ToString();
                    arr[4] = card.Attack.ToString();
                    arr[5] = card.ManaCost.ToString();
                    listViewOpponentBoard.Items.Add(new ListViewItem(arr));
                }
                listViewOpponentBoard.EndUpdate();
            }));

            listViewUserGraveyard.Invoke(new Action(() =>
            {
                listViewUserGraveyard.BeginUpdate();
                listViewUserGraveyard.Items.Clear();
                foreach (var card in GameCore.Game.User.Graveyard)
                {
                    string[] arr = new string[6];
                    arr[0] = card.Id.ToString();
                    arr[1] = card.CardDB?.Name;
                    arr[2] = card.CardType.ToString();
                    arr[3] = card.TrueHealth.ToString();
                    arr[4] = card.Attack.ToString();
                    arr[5] = card.ManaCost.ToString();
                    listViewUserGraveyard.Items.Add(new ListViewItem(arr));
                }
                listViewUserGraveyard.EndUpdate();
            }));

            listViewOpponentGraveyard.Invoke(new Action(() =>
            {
                listViewOpponentGraveyard.BeginUpdate();
                listViewOpponentGraveyard.Items.Clear();
                foreach (var card in GameCore.Game.Opponent.Graveyard)
                {
                    string[] arr = new string[6];
                    arr[0] = card.Id.ToString();
                    arr[1] = card.CardDB?.Name;
                    arr[2] = card.CardType.ToString();
                    arr[3] = card.TrueHealth.ToString();
                    arr[4] = card.Attack.ToString();
                    arr[5] = card.ManaCost.ToString();
                    listViewOpponentGraveyard.Items.Add(new ListViewItem(arr));
                }
                listViewOpponentGraveyard.EndUpdate();
            }));
        }
        void PrintCards()
        {

            var mycards = CardDict.Dict;
            var cards = HearthDb.Cards.All;
            all = HearthDb.Cards.All.DeepClone();

            all = all.Where(item => !item.Value.Type.Equals(CardType.ENCHANTMENT)).ToDictionary(t => t.Key, t => t.Value);
            cards = cards.Where(item => !item.Value.Type.Equals(CardType.ENCHANTMENT)).ToDictionary(t => t.Key, t => t.Value);

            var CORE = cards.Where(item => item.Value.Set.Equals(CardSet.CORE)).ToDictionary(t => t.Key, t => t.Value);
            aaa(CORE, "CORE");
            var EXPERT1 = cards.Where(item => item.Value.Set.Equals(CardSet.EXPERT1)).ToDictionary(t => t.Key, t => t.Value);
            aaa(EXPERT1, "EXPERT1");
            var HOF = cards.Where(item => item.Value.Set.Equals(CardSet.HOF)).ToDictionary(t => t.Key, t => t.Value);
            aaa(HOF, "HOF");
            var NAXX = cards.Where(item => item.Value.Set.Equals(CardSet.NAXX)).ToDictionary(t => t.Key, t => t.Value);
            aaa(NAXX, "NAXX");
            var GVG = cards.Where(item => item.Value.Set.Equals(CardSet.GVG)).ToDictionary(t => t.Key, t => t.Value);
            aaa(GVG, "GVG");
            var BRM = cards.Where(item => item.Value.Set.Equals(CardSet.BRM)).ToDictionary(t => t.Key, t => t.Value);
            aaa(BRM, "BRM");
            var TGT = cards.Where(item => item.Value.Set.Equals(CardSet.TGT)).ToDictionary(t => t.Key, t => t.Value);
            aaa(TGT, "TGT");
            var LOE = cards.Where(item => item.Value.Set.Equals(CardSet.LOE)).ToDictionary(t => t.Key, t => t.Value);
            aaa(LOE, "LOE");
            var KARA = cards.Where(item => item.Value.Set.Equals(CardSet.KARA)).ToDictionary(t => t.Key, t => t.Value);
            aaa(KARA, "KARA");
            var KARA_RESERVE = cards.Where(item => item.Value.Set.Equals(CardSet.KARA_RESERVE)).ToDictionary(t => t.Key, t => t.Value);
            aaa(KARA_RESERVE, "KARA_RESERVE");
            var GANGS = cards.Where(item => item.Value.Set.Equals(CardSet.GANGS)).ToDictionary(t => t.Key, t => t.Value);
            aaa(GANGS, "GANGS");
            var GANGS_RESERVE = cards.Where(item => item.Value.Set.Equals(CardSet.GANGS_RESERVE)).ToDictionary(t => t.Key, t => t.Value);
            aaa(GANGS_RESERVE, "GANGS_RESERVE");
            var OG = cards.Where(item => item.Value.Set.Equals(CardSet.OG)).ToDictionary(t => t.Key, t => t.Value);
            aaa(OG, "OG");
            var OG_RESERVE = cards.Where(item => item.Value.Set.Equals(CardSet.OG_RESERVE)).ToDictionary(t => t.Key, t => t.Value);
            aaa(OG_RESERVE, "OG_RESERVE");
            var UNGORO = cards.Where(item => item.Value.Set.Equals(CardSet.UNGORO)).ToDictionary(t => t.Key, t => t.Value);
            aaa(UNGORO, "UNGORO");
            var ICECROWN = cards.Where(item => item.Value.Set.Equals(CardSet.ICECROWN)).ToDictionary(t => t.Key, t => t.Value);
            aaa(ICECROWN, "ICECROWN");

            var HERO_SKINS = cards.Where(item => item.Value.Set.Equals(CardSet.HERO_SKINS)).ToDictionary(t => t.Key, t => t.Value);
            aaa(HERO_SKINS, "HERO_SKINS");
            var MISSIONS = cards.Where(item => item.Value.Set.Equals(CardSet.MISSIONS)).ToDictionary(t => t.Key, t => t.Value);
            aaa(MISSIONS, "MISSIONS");
            var TB = cards.Where(item => item.Value.Set.Equals(CardSet.TB)).ToDictionary(t => t.Key, t => t.Value);
            aaa(TB, "TB");
            var CREDITS = cards.Where(item => item.Value.Set.Equals(CardSet.CREDITS)).ToDictionary(t => t.Key, t => t.Value);
            aaa(CREDITS, "CREDITS");
        }
        void aaa(Dictionary<string, HearthDb.Card> dict, string name)
        {
            a += dict.Count;
            foreach (var _class in Enum.GetValues(typeof(CardClass)))
            {
                if (!Directory.Exists(Path.Combine(GlobalConstants.LogPath, "Test", Enum.GetName(typeof(CardClass), _class))))
                {
                    Directory.CreateDirectory(Path.Combine(GlobalConstants.LogPath, "Test", Enum.GetName(typeof(CardClass), _class)));
                }

                StreamWriter writer;
                if (!File.Exists(Path.Combine(GlobalConstants.LogPath, "Test", Enum.GetName(typeof(CardClass), _class), name + ".txt")))
                {
                    writer = new StreamWriter(new FileStream(Path.Combine(GlobalConstants.LogPath, "Test", Enum.GetName(typeof(CardClass), _class), name + ".txt"), FileMode.CreateNew));
                }
                else
                {
                    writer = new StreamWriter(Path.Combine(GlobalConstants.LogPath, "Test", Enum.GetName(typeof(CardClass), _class), name + ".txt"));
                }
                foreach (var item in dict)
                {
                    if (item.Value.Class.Equals(_class))
                    {
                        all.Remove(item.Key);
                        writer.WriteLine("//" + item.Value.ToString());
                        writer.WriteLine("foo = new CardBase();");
                        writer.WriteLine("foo.PlayFunc = Play.Minion;");
                        writer.WriteLine("Dict.Add(\"" + item.Value.Id + "\", foo);");
                        writer.Flush();
                    }
                }
            }
        }
    }
}
