using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public static Point MulliganFirst = new Point(517, 473);
        public static Point MulliganSecond = new Point(800, 473);
        public static Point MulliganThird = new Point(1093, 473);
        public static Point MulliganConfirm = new Point(805, 182);
        public static Point MulliganFirst_Coin = new Point(484, 473);
        public static Point MulliganSecond_Coin = new Point(700, 473);
        public static Point MulliganThird_Coin = new Point(908, 473);
        public static Point MulliganFourth_Coin = new Point(1129, 473);
        public static Point MulliganConfirm_Coin = new Point(805, 182);

        public static Point ChooseOne_Left = new Point();
        public static Point ChooseOne_Right = new Point();

        public static Point[] DiscoverThree = new Point[3]{
            new Point(), //1
            new Point(), //2
            new Point(), //3
        };
        public static Point[] DiscoverFour = new Point[4]{
            new Point(), //1
            new Point(), //2
            new Point(), //3
            new Point()  //4
        };
        public static Point[] Mulligan = new Point[3] {
            new Point(), //1
            new Point(), //2
            new Point(), //3
        };
        public static Point[] Mulligan_Coin = new Point[4]{
            new Point(), //1
            new Point(), //2
            new Point(), //3
            new Point()  //4
        };

        public static Point[] HandTen = new Point[10] {
            new Point(), //1
            new Point(), //2
            new Point(), //3
            new Point(), //4
            new Point(), //5
            new Point(), //6
            new Point(), //7
            new Point(), //8
            new Point(), //9
            new Point() //10
        };
        public static Point[] HandNine = new Point[] {
            new Point(), //1
            new Point(), //2
            new Point(), //3
            new Point(), //4
            new Point(), //5
            new Point(), //6
            new Point(), //7
            new Point(), //8
            new Point()  //9
        };
        public static Point[] HandEight = new Point[] {
            new Point(), //1
            new Point(), //2
            new Point(), //3
            new Point(), //4
            new Point(), //5
            new Point(), //6
            new Point(), //7
            new Point()  //8
        };
        public static Point[] HandSeven = new Point[] {
            new Point(), //1
            new Point(), //2
            new Point(), //3
            new Point(), //4
            new Point(), //5
            new Point(), //6
            new Point()  //7
        };
        public static Point[] HandSix = new Point[] {
            new Point(), //1
            new Point(), //2
            new Point(), //3
            new Point(), //4
            new Point(), //5
            new Point()  //6
        };
        public static Point[] HandFive = new Point[] {
            new Point(), //1
            new Point(), //2
            new Point(), //3
            new Point(), //4
            new Point()  //5
        };
        public static Point[] HandFour = new Point[] {
            new Point(), //1
            new Point(), //2
            new Point(), //3
            new Point()  //4
        };
        public static Point[] HandThree = new Point[] {
            new Point(), //1
            new Point(), //2
            new Point()  //3
        };
        public static Point[] HandTwo = new Point[] {
            new Point(), //1
            new Point()  //2
        };
        public static Point[] HandOne = new Point[] {
            new Point()  //1
        };

        public static Point[] BoardSeven = new Point[] {
            new Point(), //1
            new Point(), //2
            new Point(), //3
            new Point(), //4
            new Point(), //5
            new Point(), //6
            new Point()  //7
        };
        public static Point[] BoardSix = new Point[] {
            new Point(), //1
            new Point(), //2
            new Point(), //3
            new Point(), //4
            new Point(), //5
            new Point()  //6
        };
        public static Point[] BoardFive = new Point[] {
            new Point(), //1
            new Point(), //2
            new Point(), //3
            new Point(), //4
            new Point()  //5
        };
        public static Point[] BoardFour = new Point[] {
            new Point(), //1
            new Point(), //2
            new Point(), //3
            new Point()  //4
        };
        public static Point[] BoardThree = new Point[] {
            new Point(), //1
            new Point(), //2
            new Point()  //3
        };
        public static Point[] BoardTwo = new Point[] {
            new Point(), //1
            new Point()  //2
        };
        public static Point[] BoardOne = new Point[] {
            new Point()  //1
        };
        public static Point[] BoardEnemySeven = new Point[] {
            new Point(), //1
            new Point(), //2
            new Point(), //3
            new Point(), //4
            new Point(), //5
            new Point(), //6
            new Point()  //7
        };
        public static Point[] BoardEnemySix = new Point[] {
            new Point(), //1
            new Point(), //2
            new Point(), //3
            new Point(), //4
            new Point(), //5
            new Point()  //6
        };
        public static Point[] BoardEnemyFive = new Point[] {
            new Point(), //1
            new Point(), //2
            new Point(), //3
            new Point(), //4
            new Point()  //5
        };
        public static Point[] BoardEnemyFour = new Point[] {
            new Point(), //1
            new Point(), //2
            new Point(), //3
            new Point()  //4
        };
        public static Point[] BoardEnemyThree = new Point[] {
            new Point(), //1
            new Point(), //2
            new Point()  //3
        };
        public static Point[] BoardEnemyTwo = new Point[] {
            new Point(), //1
            new Point()  //2
        };
        public static Point[] BoardEnemyOne = new Point[] {
            new Point()  //1
        };
    }
    class MouseMovement
    {
        public static void SelectCardHand(int handSize, int numberCard)
        {
            switch (handSize)
            {
                default:
                    break;
            }
        }
    }
}
