using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static THS.Input.Methods;

namespace THS.Input
{
    public class HSPoints
    {
        //1600x900
        public static Point OptionsFriends = new Point(39, 23);
        public static Point OptionsMenu = new Point(1567, 23);
        public static Point MenuConcede_Restart = new Point(800, 571);
        public static Point MenuRestart_Restart = new Point(800, 475);
        public static Point MenuOptions_Restart = new Point(800, 379);
        public static Point MenuQuit_Restart = new Point(800, 314);
        public static Point MulliganConfirm = new Point(805, 182);

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
        public static void SelectCardHand(int handSize, int numberCard)
        {
            switch (handSize)
            {
                case 0:
                    Methods.MoveMouseHs(HSPoints.HandNone);
                    Methods.ClickMouse(true);
                    break;
                case 1:
                    Methods.MoveMouseHs(HSPoints.HandOne[numberCard]);
                    Methods.ClickMouse(true);
                    break;
                case 2:
                    Methods.MoveMouseHs(HSPoints.HandTwo[numberCard]);
                    Methods.ClickMouse(true);
                    break;
                case 3:
                    Methods.MoveMouseHs(HSPoints.HandThree[numberCard]);
                    Methods.ClickMouse(true);
                    break;
                case 4:
                    Methods.MoveMouseHs(HSPoints.HandFour[numberCard]);
                    Methods.ClickMouse(true);
                    break;
                case 5:
                    Methods.MoveMouseHs(HSPoints.HandFive[numberCard]);
                    Methods.ClickMouse(true);
                    break;
                case 6:
                    Methods.MoveMouseHs(HSPoints.HandSix[numberCard]);
                    Methods.ClickMouse(true);
                    break;
                case 7:
                    Methods.MoveMouseHs(HSPoints.HandSeven[numberCard]);
                    Methods.ClickMouse(true);
                    break;
                case 8:
                    Methods.MoveMouseHs(HSPoints.HandEight[numberCard]);
                    Methods.ClickMouse(true);
                    break;
                case 9:
                    Methods.MoveMouseHs(HSPoints.HandNine[numberCard]);
                    Methods.ClickMouse(true);
                    break;
                case 10:
                    Methods.MoveMouseHs(HSPoints.HandTen[numberCard]);
                    Methods.ClickMouse(true);
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
                    Methods.ClickMouse(true);
                    break;
                case 1:
                    Methods.MoveMouseHs(HSPoints.BoardOne[boardNumber]);
                    Methods.ClickMouse(true);
                    break;
                case 2:
                    Methods.MoveMouseHs(HSPoints.BoardTwo[boardNumber]);
                    Methods.ClickMouse(true);
                    break;
                case 3:
                    Methods.MoveMouseHs(HSPoints.BoardThree[boardNumber]);
                    Methods.ClickMouse(true);
                    break;
                case 4:
                    Methods.MoveMouseHs(HSPoints.BoardFour[boardNumber]);
                    Methods.ClickMouse(true);
                    break;
                case 5:
                    Methods.MoveMouseHs(HSPoints.BoardFive[boardNumber]);
                    Methods.ClickMouse(true);
                    break;
                case 6:
                    Methods.MoveMouseHs(HSPoints.BoardSix[boardNumber]);
                    Methods.ClickMouse(true);
                    break;
                case 7:
                    Methods.MoveMouseHs(HSPoints.BoardSeven[boardNumber]);
                    Methods.ClickMouse(true);
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
                    Methods.ClickMouse(true);
                    break;
                case 1:
                    Methods.MoveMouseHs(HSPoints.BoardEnemyOne[boardNumber]);
                    Methods.ClickMouse(true);
                    break;
                case 2:
                    Methods.MoveMouseHs(HSPoints.BoardEnemyTwo[boardNumber]);
                    Methods.ClickMouse(true);
                    break;
                case 3:
                    Methods.MoveMouseHs(HSPoints.BoardEnemyThree[boardNumber]);
                    Methods.ClickMouse(true);
                    break;
                case 4:
                    Methods.MoveMouseHs(HSPoints.BoardEnemyFour[boardNumber]);
                    Methods.ClickMouse(true);
                    break;
                case 5:
                    Methods.MoveMouseHs(HSPoints.BoardEnemyFive[boardNumber]);
                    Methods.ClickMouse(true);
                    break;
                case 6:
                    Methods.MoveMouseHs(HSPoints.BoardEnemySix[boardNumber]);
                    Methods.ClickMouse(true);
                    break;
                case 7:
                    Methods.MoveMouseHs(HSPoints.BoardEnemySeven[boardNumber]);
                    Methods.ClickMouse(true);
                    break;
                default:
                    break;
            }
        }

        public static void SelectHero()
        {

            Methods.MoveMouseHs(HSPoints.Hero);
            Methods.ClickMouse(true);
        }
        public static void SelectHeroEnemy()
        {

            Methods.MoveMouseHs(HSPoints.HeroEnemy);
            Methods.ClickMouse(true);
        }
        public static void PlayCard(int handSize, int handNumber)
        {
            SelectCardHand(handSize, handNumber);
            Thread.Sleep(500);
            SelectBoard(0, 0);
        }
        public static void PlayCardOn(int handSize, int handNumber, bool enemy, int boardSize, int boardNumber, bool hero = false)
        {
            SelectCardHand(handSize, handNumber);
            Thread.Sleep(500);
            if (enemy)
            {
                if (hero)
                {
                    SelectHeroEnemy();
                    return;
                }
                SelectBoardEnemy(boardSize, boardNumber);
            }
            else
            {
                if (hero)
                {
                    SelectHero();
                    return;
                }
                SelectBoard(boardSize, boardNumber);
            }
        }
        public static void AttackCard(int boardSize, int boardNumber, int boardEnemySize, int boardEnemyNumber, bool hero = false)
        {

            SelectBoard(boardSize, boardNumber);
            Thread.Sleep(500);
            if (hero)
            {
                SelectHeroEnemy();
                return;
            }
            SelectBoardEnemy(boardEnemySize, boardEnemyNumber);
        }
    }
}
