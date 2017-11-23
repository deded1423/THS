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
                while (true)
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

        private void ButtonConfig_Click(object sender, EventArgs e)
        {
            _configwindow = new Config();
            _configwindow.Show();

            //TcpListener listener = new TcpListener(IPAddress.Parse("192.168.1.241"), 8888);
            //listener.Start();
            //Socket a = listener.AcceptSocket();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
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

        private void THS_FormClosed(object sender, FormClosedEventArgs e)
        {
            IO.CloseDebugFiles();
            if (Directory.Exists(Path.Combine(@"C: \Users\USER\Documents\Visual Studio 2015\Projects\THS\HearthDb", "hsdata")))
            {
                Directory.Delete(Path.Combine(@"C: \Users\USER\Documents\Visual Studio 2015\Projects\THS\HearthDb", "hsdata"));
            }
            //irc.Stop();
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
            ircprocessThread = new Thread(StartIRCProcessing) { Name = "TwitchChatProcesser" };
            ircprocessThread.Start();
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

        public void StartIRCProcessing()
        {
            CommandChat cmd;
            while (true)
            {
                while (irc.Queue.IsEmpty || GameCore == null || GameCore.Game == null)
                {
                    Thread.Sleep(100);
                }
                irc.Queue.TryDequeue(out cmd);
                HSApp.HSCard name, target;
                switch (cmd.Type)
                {
                    case PlayType.Play:
                        if (GameCore.Game.User.GetHandCard(cmd.Name) == null)
                        {
                            IO.LogDebug("FAIL " + cmd.ToString(), IO.DebugFile.Input);
                            continue;
                        }
                        if (cmd.Target == null)
                        {
                            MouseMovement.PlayCard(GameCore.Game.User.Hand.Count, GameCore.Game.User.GetHandCard(cmd.Name).ZonePos - 1);
                        }
                        else
                        {
                            name = GameCore.Game.User.GetHandCard(cmd.Name);
                            var _namepos = name.ZonePos - 1;
                            if ((target = GameCore.Game.User.GetPlayCard(cmd.Target)) != null)
                            {
                                MouseMovement.PlayCardOn(GameCore.Game.User.Hand.Count, _namepos, false, GameCore.Game.GetUserMinions().Count, target.ZonePos - 1);
                            }
                            else if ((target = GameCore.Game.Opponent.GetPlayCard(cmd.Target)) != null)
                            {
                                MouseMovement.PlayCardOn(GameCore.Game.User.Hand.Count, _namepos, true, GameCore.Game.GetOpponentMinions().Count, target.ZonePos - 1);
                            }
                            else if (GameCore.Game.User.EqualsHeroName(cmd.Target))
                            {
                                MouseMovement.PlayCardOn(0, 0, false, 0, 0, true);
                            }
                            else if (GameCore.Game.Opponent.EqualsHeroName(cmd.Target))
                            {
                                MouseMovement.PlayCardOn(0, 0, true, 0, 0, true);
                            }
                        }
                        break;
                    case PlayType.HeroPower:
                        if (cmd.Target == null)
                        {
                            MouseMovement.HeroPower();
                        }
                        else
                        {
                            if ((target = GameCore.Game.User.GetPlayCard(cmd.Target)) != null)
                            {
                                MouseMovement.HeroPower(GameCore.Game.GetUserMinions().Count, target.ZonePos - 1, false);
                            }
                            else if ((target = GameCore.Game.Opponent.GetPlayCard(cmd.Target)) != null)
                            {
                                MouseMovement.HeroPower(GameCore.Game.GetOpponentMinions().Count, target.ZonePos - 1, true);
                            }
                            else if (GameCore.Game.User.EqualsHeroName(cmd.Target))
                            {
                                MouseMovement.HeroPower(false);
                            }
                            else if (GameCore.Game.Opponent.EqualsHeroName(cmd.Target))
                            {
                                MouseMovement.HeroPower(true);
                            }
                        }
                        break;
                    case PlayType.Attack:
                        if (GameCore.Game.User.GetPlayCard(cmd.Name) == null && !GameCore.Game.User.EqualsHeroName(cmd.Name))
                        {
                            IO.LogDebug("FAIL " + cmd.ToString(), IO.DebugFile.Input);
                            continue;
                        }
                        if (GameCore.Game.Opponent.GetPlayCard(cmd.Target) == null && !GameCore.Game.Opponent.EqualsHeroName(cmd.Target))
                        {
                            IO.LogDebug("FAIL " + cmd.ToString(), IO.DebugFile.Input);
                            continue;
                        }
                        if ((name = GameCore.Game.User.GetPlayCard(cmd.Name)) != null)
                        {
                            if ((target = GameCore.Game.Opponent.GetPlayCard(cmd.Target)) != null)
                            {
                                MouseMovement.AttackCard(GameCore.Game.GetUserMinions().Count, name.ZonePos - 1, GameCore.Game.GetOpponentMinions().Count, target.ZonePos - 1);
                            }
                            else if (GameCore.Game.Opponent.EqualsHeroName(cmd.Target))
                            {
                                MouseMovement.AttackCard(GameCore.Game.GetUserMinions().Count, name.ZonePos - 1, 0, 0, true);
                            }
                        }
                        else if ((name = GameCore.Game.User.Hero).Name.ToLower().Equals(cmd.Name) || GameCore.Game.User.EqualsHeroName(cmd.Name))
                        {
                            if ((target = GameCore.Game.Opponent.GetPlayCard(cmd.Target)) != null)
                            {
                                MouseMovement.AttackHero(GameCore.Game.GetOpponentMinions().Count, target.ZonePos - 1);
                            }
                            else if (GameCore.Game.Opponent.EqualsHeroName(cmd.Target))
                            {
                                MouseMovement.AttackHero(0, 0, true);
                            }
                        }
                        break;
                    case PlayType.Incorrect:
                        IO.LogDebug(cmd.ToString());
                        break;
                    case PlayType.Mulligan:
                        char[] mull = cmd.Other.ToCharArray();
                        if (mull.Length == 3)
                        {
                            MouseMovement.Mulligan(mull[0].Equals('0') ? 0 : 1, mull[1].Equals('0') ? 0 : 1, mull[2].Equals('0') ? 0 : 1);
                        }
                        else
                        {
                            MouseMovement.MulliganCoin(mull[0].Equals('0') ? 0 : 1, mull[1].Equals('0') ? 0 : 1, mull[2].Equals('0') ? 0 : 1, mull[3].Equals('0') ? 0 : 1);
                        }
                        break;
                    case PlayType.Discover:
                        MouseMovement.Discover(int.Parse(cmd.Other));
                        break;
                    case PlayType.Choose:
                        MouseMovement.ChooseOne(int.Parse(cmd.Other));
                        break;
                    case PlayType.Queue:
                        MouseMovement.Requeue(int.Parse(cmd.Other));
                        break;
                    case PlayType.Emote:
                        if (cmd.Other.Equals("greetings"))
                        {
                            MouseMovement.Emote(HSPoints.EmoteGreetings);
                        }
                        else if (cmd.Other.Equals("wellplayed"))
                        {
                            MouseMovement.Emote(HSPoints.EmoteWellPlayed);
                        }
                        else if (cmd.Other.Equals("thanks"))
                        {
                            MouseMovement.Emote(HSPoints.EmoteThanks);
                        }
                        else if (cmd.Other.Equals("wow"))
                        {
                            MouseMovement.Emote(HSPoints.EmoteWow);
                        }
                        else if (cmd.Other.Equals("oops"))
                        {
                            MouseMovement.Emote(HSPoints.EmoteOops);
                        }
                        else if (cmd.Other.Equals("threaten"))
                        {
                            MouseMovement.Emote(HSPoints.EmoteThreaten);
                        }

                        break;
                    case PlayType.Concede:
                        MouseMovement.Concede();
                        break;
                    case PlayType.EndTurn:
                        MouseMovement.EndTurn();
                        break;
                    case PlayType.SeeDeck:
                        MouseMovement.SeeDeck();
                        break;
                    case PlayType.Other:
                        break;
                    default:
                        break;
                }
            }
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
