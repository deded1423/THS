using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using THS.Utils;
using static THS.Input.Methods;

namespace THS.Input
{
    public class HSPoints
    {
        //1600x900

        //GLOBAL
        public static Point OptionsGlobalFriends = new Point(39, 23);
        public static Point OptionsGlobalMenu = new Point(1567, 23);

        //MENU PLAY
        public static Point MenuPlayQueue = new Point(1167, 158);
        public static Point MenuPlayRanked = new Point(1253, 766);
        public static Point MenuPlayCasual = new Point(1086, 765);
        public static Point MenuPlayWild = new Point(1173, 856);
        public static Point MenuPlayCollection = new Point(596, 80);
        public static Point MenuPlayBack = new Point(1322, 70);
        public static Point MenuPlayNextDecks = new Point();
        public static Point[] MenuPlayDeck = new Point[9] {
            new Point(401,658), //1
            new Point(600,656), //2
            new Point(802,657), //3
            new Point(396,468), //4
            new Point(600,476), //5
            new Point(798,473), //6
            new Point(400,279), //7
            new Point(604,278), //8
            new Point(800,276) //9
        };

        //INGAME MENU
        public static Point MenuGameConcede_Restart = new Point(800, 571);
        public static Point MenuGameRestart_Restart = new Point(800, 475);
        public static Point MenuGameOptions_Restart = new Point(800, 379);
        public static Point MenuGameQuit_Restart = new Point(800, 314);
        public static Point MenuGameConcede = new Point(801, 572);
        public static Point MenuGameOptions = new Point(798, 474);
        public static Point MenuGameQuit = new Point(799, 411);
        public static Point MulliganConfirm = new Point(805, 182);
        public static Point Rest = new Point(323, 138);

        //GAME MISC
        public static Point HandNone = new Point(794, 64);
        public static Point HandEnemy = new Point(792, 867);
        public static Point Board = new Point(805, 402);
        public static Point BoardEnemy = new Point(800, 556);
        public static Point Hero = new Point(804, 210);
        public static Point HeroEnemy = new Point(801, 722);
        public static Point Power = new Point(948, 217);
        public static Point PowerEnemy = new Point(942, 702);
        public static Point Weapon = new Point(672, 221);
        public static Point WeaponEnemy = new Point(666, 721);
        public static Point Deck = new Point(1367, 362);
        public static Point DeckEnemy = new Point(1369, 612);
        public static Point EndTurn = new Point(1294, 489);

        //EMOTE
        public static Point EmoteGreetings = new Point(642, 182);
        public static Point EmoteWellPlayed = new Point(640, 259);
        public static Point EmoteThanks = new Point(673, 330);
        public static Point EmoteWow = new Point(933, 331);
        public static Point EmoteOops = new Point(965, 253);
        public static Point EmoteThreaten = new Point(963, 184);
        public static Point EmoteSilence = new Point(666, 815);

        //DISCOVER BOARD HAND CHOOSE ONE
        public static Point ChooseOne_Left = new Point(652, 457);
        public static Point ChooseOne_Right = new Point(953, 456);

        public static Point[] DiscoverThree = new Point[3]{
            new Point(474,479),  //1
            new Point(807,489),  //2
            new Point(1124,478), //3
        };
        public static Point[] DiscoverFour = new Point[4]{
            new Point(484, 473), //1
            new Point(700, 473), //2
            new Point(908, 473), //3
            new Point(1129, 473)  //4
        };
        public static Point[] Mulligan = new Point[3] {
            new Point(517, 473), //1
            new Point(800, 473), //2
            new Point(1093, 473), //3
        };
        public static Point[] Mulligan_Coin = new Point[4]{
            new Point(484, 473), //1
            new Point(700, 473), //2
            new Point(908, 473), //3
            new Point(1129, 473)  //4
        };

        public static Point[] HandTen = new Point[10] {
            new Point(523,29), //1
            new Point(563,26), //2
            new Point(627,43), //3
            new Point(653,43), //4
            new Point(703,51), //5
            new Point(736,51), //6
            new Point(787,43), //7
            new Point(828,43), //8
            new Point(871,35), //9
            new Point(978,25)  //10
        };
        public static Point[] HandNine = new Point[] {
            new Point(524,50), //1
            new Point(600,46), //2
            new Point(629,47), //3
            new Point(678,46), //4
            new Point(736,38), //5
            new Point(804,29), //6
            new Point(832,38), //7
            new Point(887,36), //8
            new Point(959,23)  //9
        };
        public static Point[] HandEight = new Point[] {
            new Point(554,21), //1
            new Point(598,30), //2
            new Point(642,29), //3
            new Point(726,35), //4
            new Point(758,39), //5
            new Point(795,31), //6
            new Point(865,29), //7
            new Point(943,28)  //8
        };
        public static Point[] HandSeven = new Point[] {
            new Point(555,42), //1
            new Point(619,51), //2
            new Point(705,47), //3
            new Point(744,41), //4
            new Point(810,39), //5
            new Point(860,42), //6
            new Point(939,42)  //7
        };
        public static Point[] HandSix = new Point[] {
            new Point(561,38), //1
            new Point(657,40), //2
            new Point(723,34), //3
            new Point(791,36), //4
            new Point(870,32), //5
            new Point(959,32)  //6
        };
        public static Point[] HandFive = new Point[] {
            new Point(583,42), //1
            new Point(688,46), //2
            new Point(775,47), //3
            new Point(871,47), //4
            new Point(967,45)  //5
        };
        public static Point[] HandFour = new Point[] {
            new Point(599,30), //1
            new Point(725,37), //2
            new Point(825,36), //3
            new Point(941,39)  //4
        };
        public static Point[] HandThree = new Point[] {
            new Point(657,34), //1
            new Point(780,38), //2
            new Point(890,34)  //3
        };
        public static Point[] HandTwo = new Point[] {
            new Point(709,44), //1
            new Point(833,36)  //2
        };
        public static Point[] HandOne = new Point[] {
            new Point(764,40)  //1
        };

        public static Point[] BoardSeven = new Point[] {
            new Point(452,410), //1
            new Point(569,410), //2
            new Point(679,410), //3
            new Point(800,410), //4
            new Point(915,410), //5
            new Point(1028,410), //6
            new Point(1151,410)  //7
        };
        public static Point[] BoardSix = new Point[] {
            new Point(509,410), //1
            new Point(629,410), //2
            new Point(744,410), //3
            new Point(861,410), //4
            new Point(973,410), //5
            new Point(1090,410)  //6
        };
        public static Point[] BoardFive = new Point[] {
            new Point(569,410), //1
            new Point(685,410), //2
            new Point(799,410), //3
            new Point(918,410), //4
            new Point(1032,410)  //5
        };
        public static Point[] BoardFour = new Point[] {
            new Point(627,410), //1
            new Point(740,410), //2
            new Point(857,410), //3
            new Point(973,410)  //4
        };
        public static Point[] BoardThree = new Point[] {
            new Point(687,410), //1
            new Point(803,410), //2
            new Point(917,410)  //3
        };
        public static Point[] BoardTwo = new Point[] {
            new Point(744,410), //1
            new Point(861,410)  //2
        };
        public static Point[] BoardOne = new Point[] {
            new Point(800,410)  //1
        };
        public static Point[] BoardEnemySeven = new Point[] {
            new Point(452,564), //1
            new Point(569,564), //2
            new Point(679,564), //3
            new Point(800,564), //4
            new Point(915,564), //5
            new Point(1028,564), //6
            new Point(1151,564)  //7
        };
        public static Point[] BoardEnemySix = new Point[] {
            new Point(509,564), //1
            new Point(629,564), //2
            new Point(744,564), //3
            new Point(861,564), //4
            new Point(973,564), //5
            new Point(1090,564)  //6
        };
        public static Point[] BoardEnemyFive = new Point[] {
            new Point(569,564), //1
            new Point(685,564), //2
            new Point(799,564), //3
            new Point(918,564), //4
            new Point(1032,564)  //5
        };
        public static Point[] BoardEnemyFour = new Point[] {
            new Point(627,564), //1
            new Point(740,564), //2
            new Point(857,564), //3
            new Point(973,564)  //4
        };
        public static Point[] BoardEnemyThree = new Point[] {
            new Point(687,564), //1
            new Point(803,564), //2
            new Point(917,564)  //3
        };
        public static Point[] BoardEnemyTwo = new Point[] {
            new Point(744,564), //1
            new Point(861,564)  //2
        };
        public static Point[] BoardEnemyOne = new Point[] {
            new Point(800,564)  //1
        };
    }
    public class MouseMovement
    {
        public static void Requeue(int deck, bool ranked = false)
        {
            Methods.MoveMouseHs(HSPoints.Board);
            Methods.ClickMouseHS(true);
            Methods.MoveMouseHs(HSPoints.MenuPlayDeck[deck - 1]);
            Methods.ClickMouseHS(true);
            if (ranked)
            {
                Methods.MoveMouseHs(HSPoints.MenuPlayRanked);
                Methods.ClickMouseHS(true);
            }
            else
            {
                Methods.MoveMouseHs(HSPoints.MenuPlayCasual);
                Methods.ClickMouseHS(true);
            }
            Methods.MoveMouseHs(HSPoints.MenuPlayQueue);
            Methods.ClickMouseHS(true);
        }

        public static void SelectCardHand(int handSize, int numberCard)
        {
            switch (handSize)
            {
                case 0:
                    Methods.MoveMouseHs(HSPoints.HandNone);
                    Methods.ClickMouseHS(true);
                    break;
                case 1:
                    Methods.MoveMouseHs(HSPoints.HandOne[numberCard]);
                    Methods.ClickMouseHS(true);
                    break;
                case 2:
                    Methods.MoveMouseHs(HSPoints.HandTwo[numberCard]);
                    Methods.ClickMouseHS(true);
                    break;
                case 3:
                    Methods.MoveMouseHs(HSPoints.HandThree[numberCard]);
                    Methods.ClickMouseHS(true);
                    break;
                case 4:
                    Methods.MoveMouseHs(HSPoints.HandFour[numberCard]);
                    Methods.ClickMouseHS(true);
                    break;
                case 5:
                    Methods.MoveMouseHs(HSPoints.HandFive[numberCard]);
                    Methods.ClickMouseHS(true);
                    break;
                case 6:
                    Methods.MoveMouseHs(HSPoints.HandSix[numberCard]);
                    Methods.ClickMouseHS(true);
                    break;
                case 7:
                    Methods.MoveMouseHs(HSPoints.HandSeven[numberCard]);
                    Methods.ClickMouseHS(true);
                    break;
                case 8:
                    Methods.MoveMouseHs(HSPoints.HandEight[numberCard]);
                    Methods.ClickMouseHS(true);
                    break;
                case 9:
                    Methods.MoveMouseHs(HSPoints.HandNine[numberCard]);
                    Methods.ClickMouseHS(true);
                    break;
                case 10:
                    Methods.MoveMouseHs(HSPoints.HandTen[numberCard]);
                    Methods.ClickMouseHS(true);
                    break;
                default:
                    break;
            }
        }
        public static void SelectBoard(int boardSize, int boardNumber)
        {
            switch (boardSize)
            {
                case 0:
                    Methods.MoveMouseHs(HSPoints.Board);
                    Methods.ClickMouseHS(true);
                    break;
                case 1:
                    Methods.MoveMouseHs(HSPoints.BoardOne[boardNumber]);
                    Methods.ClickMouseHS(true);
                    break;
                case 2:
                    Methods.MoveMouseHs(HSPoints.BoardTwo[boardNumber]);
                    Methods.ClickMouseHS(true);
                    break;
                case 3:
                    Methods.MoveMouseHs(HSPoints.BoardThree[boardNumber]);
                    Methods.ClickMouseHS(true);
                    break;
                case 4:
                    Methods.MoveMouseHs(HSPoints.BoardFour[boardNumber]);
                    Methods.ClickMouseHS(true);
                    break;
                case 5:
                    Methods.MoveMouseHs(HSPoints.BoardFive[boardNumber]);
                    Methods.ClickMouseHS(true);
                    break;
                case 6:
                    Methods.MoveMouseHs(HSPoints.BoardSix[boardNumber]);
                    Methods.ClickMouseHS(true);
                    break;
                case 7:
                    Methods.MoveMouseHs(HSPoints.BoardSeven[boardNumber]);
                    Methods.ClickMouseHS(true);
                    break;
                default:
                    break;
            }
        }
        public static void SelectBoardEnemy(int boardSize, int boardNumber)
        {
            switch (boardSize)
            {
                case 0:
                    Methods.MoveMouseHs(HSPoints.BoardEnemy);
                    Methods.ClickMouseHS(true);
                    break;
                case 1:
                    Methods.MoveMouseHs(HSPoints.BoardEnemyOne[boardNumber]);
                    Methods.ClickMouseHS(true);
                    break;
                case 2:
                    Methods.MoveMouseHs(HSPoints.BoardEnemyTwo[boardNumber]);
                    Methods.ClickMouseHS(true);
                    break;
                case 3:
                    Methods.MoveMouseHs(HSPoints.BoardEnemyThree[boardNumber]);
                    Methods.ClickMouseHS(true);
                    break;
                case 4:
                    Methods.MoveMouseHs(HSPoints.BoardEnemyFour[boardNumber]);
                    Methods.ClickMouseHS(true);
                    break;
                case 5:
                    Methods.MoveMouseHs(HSPoints.BoardEnemyFive[boardNumber]);
                    Methods.ClickMouseHS(true);
                    break;
                case 6:
                    Methods.MoveMouseHs(HSPoints.BoardEnemySix[boardNumber]);
                    Methods.ClickMouseHS(true);
                    break;
                case 7:
                    Methods.MoveMouseHs(HSPoints.BoardEnemySeven[boardNumber]);
                    Methods.ClickMouseHS(true);
                    break;
                default:
                    break;
            }
        }

        public static void SelectHero()
        {
            Methods.MoveMouseHs(HSPoints.Hero);
            Methods.ClickMouseHS(true);
        }
        public static void SelectHeroEnemy()
        {

            Methods.MoveMouseHs(HSPoints.HeroEnemy);
            Methods.ClickMouseHS(true);
        }

        public static void SelectPower()
        {
            Methods.MoveMouseHs(HSPoints.Power);
            Methods.ClickMouseHS(true);
        }
        public static void SelectPowerEnemy()
        {
            Methods.MoveMouseHs(HSPoints.PowerEnemy);
            Methods.ClickMouseHS(true);
        }

        public static void RestMouse()
        {
            Random rng = new Random();
            Methods.MoveMouseHs(new Point(HSPoints.Rest.X + rng.Next(100), HSPoints.Rest.Y + rng.Next(100)));
            //Methods.MoveMouseHs(HSPoints.Rest);
        }
        public static void PlayCard(int handSize, int handNumber)
        {
            IO.LogDebug("Play Card handSize " + handSize + ", handNumber " + (handNumber + 1), IO.DebugFile.Input);
            SelectCardHand(handSize, handNumber);
            Thread.Sleep(200);
            SelectBoard(0, 0);
            Thread.Sleep(100);
            RestMouse();
        }
        public static void PlayCardOn(int handSize, int handNumber, bool enemy, int boardSize, int boardNumber, bool hero = false)
        {
            SelectCardHand(handSize, handNumber);
            Thread.Sleep(200);
            Methods.MoveMouseHs(HSPoints.Power);
            Methods.ClickMouseHS(true);
            Thread.Sleep(200);
            if (enemy)
            {
                if (hero)
                {
                    IO.LogDebug("Play Card On handSize " + handSize + ", handNumber " + (handNumber + 1) + " Enemy Hero", IO.DebugFile.Input);
                    SelectHeroEnemy();
                    Thread.Sleep(100);
                    RestMouse();
                    return;
                }
                IO.LogDebug("Play Card On handSize " + handSize + ", handNumber " + (handNumber + 1) + ", enemy " + enemy + ", boardSize " + boardSize + ", boardNumber " + (boardNumber + 1), IO.DebugFile.Input);
                SelectBoardEnemy(boardSize, boardNumber);
            }
            else
            {
                if (hero)
                {
                    IO.LogDebug("Play Card On handSize " + handSize + ", handNumber" + handNumber + 1 + " Hero", IO.DebugFile.Input);
                    SelectHero();
                    Thread.Sleep(100);
                    RestMouse();
                    return;
                }
                IO.LogDebug("Play Card On handSize " + handSize + ", handNumber " + (handNumber + 1) + ", enemy " + enemy + ", boardSize " + boardSize + ", boardNumber " + (boardNumber + 1), IO.DebugFile.Input);
                SelectBoard(boardSize, boardNumber);
            }
            Thread.Sleep(100);
            RestMouse();
        }
        public static void AttackCard(int boardSize, int boardNumber, int boardEnemySize, int boardEnemyNumber, bool hero = false)
        {
            SelectBoard(boardSize, boardNumber);
            Thread.Sleep(200);
            if (hero)
            {
                IO.LogDebug("Attack boardSize " + boardSize + ",  boardNumber" + (boardNumber + 1) + " Hero ", IO.DebugFile.Input);
                SelectHeroEnemy();
                Thread.Sleep(100);
                RestMouse();
                return;
            }
            IO.LogDebug("Attack boardSize " + boardSize + ",  boardNumber" + (boardNumber + 1) + ", boardEnemySize " + boardEnemySize + ", boardEnemyNumber " + (boardEnemyNumber + 1), IO.DebugFile.Input);
            SelectBoardEnemy(boardEnemySize, boardEnemyNumber);
            Thread.Sleep(100);
            RestMouse();
        }
        public static void AttackHero(int boardEnemySize, int boardEnemyNumber, bool hero = false)
        {
            SelectHero();
            Thread.Sleep(200);
            if (hero)
            {
                IO.LogDebug("Attack with hero to hero", IO.DebugFile.Input);
                SelectHeroEnemy();
                Thread.Sleep(100);
                RestMouse();
                return;
            }
            IO.LogDebug("Attack with hero  boardEnemySize " + boardEnemySize + ", boardEnemyNumber " + (boardEnemyNumber + 1), IO.DebugFile.Input);
            SelectBoardEnemy(boardEnemySize, boardEnemyNumber);
            Thread.Sleep(100);
            RestMouse();
        }
        public static void Mulligan(int first, int second, int third)
        {
            IO.LogDebug("Mulligan first " + first + ",  second" + second + ", third " + third, IO.DebugFile.Input);
            if (first == 1)
            {
                MoveMouseHs(HSPoints.Mulligan[0]);
                Methods.ClickMouseHS(true);
            }

            if (second == 1)
            {
                MoveMouseHs(HSPoints.Mulligan[1]);
                Methods.ClickMouseHS(true);
            }

            if (third == 1)
            {
                MoveMouseHs(HSPoints.Mulligan[2]);
                Methods.ClickMouseHS(true);
            }

            MoveMouseHs(HSPoints.MulliganConfirm);
            Methods.ClickMouseHS(true);
            Thread.Sleep(100);
            RestMouse();
        }

        public static void MulliganCoin(int first, int second, int third, int fourth)
        {
            IO.LogDebug("Mulligan Coin first " + first + ",  second" + second + ", third " + third + ", fourth " + fourth, IO.DebugFile.Input);
            if (first == 1)
            {
                MoveMouseHs(HSPoints.Mulligan_Coin[0]);
                Methods.ClickMouseHS(true);
            }
            if (second == 1)
            {
                MoveMouseHs(HSPoints.Mulligan_Coin[1]);
                Methods.ClickMouseHS(true);
            }
            if (third == 1)
            {
                MoveMouseHs(HSPoints.Mulligan_Coin[2]);
                Methods.ClickMouseHS(true);
            }
            if (fourth == 1)
            {
                MoveMouseHs(HSPoints.Mulligan_Coin[3]);
                Methods.ClickMouseHS(true);
            }
            MoveMouseHs(HSPoints.MulliganConfirm);
            Methods.ClickMouseHS(true);
            Thread.Sleep(100);
            RestMouse();
        }

        public static void ChooseOne(int card)
        {
            IO.LogDebug("ChooseOne card " + ++card, IO.DebugFile.Input);
            if (card == 1)
            {
                MoveMouseHs(HSPoints.ChooseOne_Left);
                Methods.ClickMouseHS(true);
            }
            else
            {
                MoveMouseHs(HSPoints.ChooseOne_Right);
                Methods.ClickMouseHS(true);
            }
            Thread.Sleep(100);
            RestMouse();
        }

        public static void Discover(int card)
        {
            IO.LogDebug("Discover card " + card + 1, IO.DebugFile.Input);
            MoveMouseHs(HSPoints.DiscoverThree[card]);
            Methods.ClickMouseHS(true);
            Thread.Sleep(100);
            RestMouse();
        }

        public static void EndTurn()
        {
            Methods.MoveMouseHs(HSPoints.EndTurn);
            Methods.ClickMouseHS(true);
            IO.LogDebug("End Turn", IO.DebugFile.Input);
            Thread.Sleep(100);
            RestMouse();
        }

        public static void HeroPower()
        {
            SelectPower();
            IO.LogDebug("Hero Power", IO.DebugFile.Input);
            Thread.Sleep(100);
            RestMouse();
        }

        public static void HeroPower(bool enemy)
        {
            SelectPower();
            Thread.Sleep(200);
            if (enemy)
            {
                SelectHeroEnemy();
                IO.LogDebug("Hero Power enemy " + enemy, IO.DebugFile.Input);
            }
            else
            {
                SelectHero();
                IO.LogDebug("Hero Power enemy " + enemy, IO.DebugFile.Input);
            }
            Thread.Sleep(100);
            RestMouse();
        }

        public static void HeroPower(int boardSize, int boardNumber, bool enemy)
        {
            SelectPower();
            Thread.Sleep(200);
            if (enemy)
            {
                SelectBoardEnemy(boardSize, boardNumber);
                IO.LogDebug("Hero Power enemy " + enemy + ", boardSize " + boardSize + ", boardNumber" + (boardNumber + 1), IO.DebugFile.Input);
            }
            else
            {
                SelectBoard(boardSize, boardNumber);
                IO.LogDebug("Hero Power enemy " + enemy + ", boardSize " + boardSize + ", boardNumber" + (boardNumber + 1), IO.DebugFile.Input);
            }
            Thread.Sleep(100);
            RestMouse();
        }

        public static void Emote(Point emote)
        {
            Methods.MoveMouseHs(HSPoints.Hero);
            Methods.ClickMouseHS(false);
            Thread.Sleep(200);
            MoveMouseHs(emote);
            Methods.ClickMouseHS(true);
            RestMouse();
        }
        public static void Silence()
        {
            Methods.MoveMouseHs(HSPoints.HeroEnemy);
            Methods.ClickMouseHS(false);
            Methods.MoveMouseHs(HSPoints.EmoteSilence);
            Methods.ClickMouseHS(true);
        }

        public static void SeeDeck()
        {
            Methods.MoveMouseHs(HSPoints.Deck);
            Thread.Sleep(3000);
            RestMouse();
        }
        public static void Concede()
        {
            Methods.MoveMouseHs(HSPoints.OptionsGlobalMenu);
            Methods.ClickMouseHS(true);
            Thread.Sleep(200);
            Methods.MoveMouseHs(HSPoints.MenuGameConcede);
            Methods.ClickMouseHS(true);
        }

    }
}
