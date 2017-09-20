using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using Point = THS.Input.Methods.Point;
namespace THS.Input
{
    public class Methods
    {
        [StructLayout(LayoutKind.Sequential)]
        struct WINDOWINFO
        {
            public uint cbSize;
            public RECT rcWindow;
            public RECT rcClient;
            public uint dwStyle;
            public uint dwExStyle;
            public uint dwWindowStatus;
            public uint cxWindowBorders;
            public uint cyWindowBorders;
            public ushort atomWindowType;
            public ushort wCreatorVersion;

            public WINDOWINFO(Boolean? filler) : this()   // Allows automatic initialization of "cbSize" with "new WINDOWINFO(null/true/false)".
            {
                cbSize = (UInt32)(Marshal.SizeOf(typeof(WINDOWINFO)));
            }

        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Point
        {
            public int X;
            public int Y;
            public Point(int x, int y) { X = x; Y = y; }
        }

        [Flags]
        public enum MouseEventFlags : uint
        {
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004,
            MIDDLEDOWN = 0x00000020,
            MIDDLEUP = 0x00000040,
            MOVE = 0x00000001,
            ABSOLUTE = 0x00008000,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010,
            WHEEL = 0x00000800,
            XDOWN = 0x00000080,
            XUP = 0x00000100
        }
        
        private delegate bool EnumWindowsDel(IntPtr hWnd, int lParam);

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool GetWindowInfo(IntPtr hwnd, ref WINDOWINFO pwi);


        [DllImport("user32.dll")]
        private static extern bool EnumWindows(EnumWindowsDel enumFunc, int lParam);

        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll")]
        private static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern short GetKeyState(int nVirtKey);

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out Point lpPoint);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData,
        int dwExtraInfo);

        public static Point[] GetWindowCoords(string screen)
        {

            WINDOWINFO info = new WINDOWINFO();
            bool chk = false;
            EnumWindows(new EnumWindowsDel(delegate (IntPtr hWnd, int lParam)
            {
                int length = GetWindowTextLength(hWnd);
                if (length == 0) return true;
                StringBuilder builder = new StringBuilder(length);
                GetWindowText(hWnd, builder, length + 1);
                var Title = builder.ToString();
                if (!Title.Equals(screen)) return true;
                var Handle = hWnd;
                info.cbSize = (uint)Marshal.SizeOf(info);
                GetWindowInfo(Handle, ref info);
                chk = true;
                return true;
            }), 0);
            if (chk)
            {
                return new Point[2]{
                    new Point(info.rcClient.Left, info.rcClient.Bottom),
                    new Point((info.rcClient.Right - info.rcClient.Left), (info.rcClient.Bottom - info.rcClient.Top))};
            }
            else
            {
                return null;
            }
        }
        public static Point GetMouseInfo()
        {
            Point cursor;
            GetCursorPos(out cursor);
            return cursor;
        }
        public static Point GetMouseInfoFromWindow(string screen)
        {
            Point[] screenCoords = GetWindowCoords(screen);
            if (screenCoords == null)
            {
                return new Point(-1, -1);
            }
            Point screenOrigin = screenCoords[0];
            Point screenSize = screenCoords[1];
            Point mouseCoord = GetMouseInfo();
            if (((mouseCoord.X > screenOrigin.X) && (mouseCoord.X < screenOrigin.X + screenSize.X)) &&
                ((mouseCoord.Y < screenOrigin.Y) && (mouseCoord.Y > screenOrigin.Y - screenSize.Y)))
            {
                Point foo = new Point();
                foo.X = mouseCoord.X - screenOrigin.X;
                foo.Y = screenOrigin.Y - mouseCoord.Y;
                return new Point(foo.X, foo.Y);
            }
            else
            {
                return new Point(-1, -1);
            }
        }
        public static void MoveMouse(Point coord)
        {
            //Movimiento es relativo (arreglarlo)
            Point oldMouse = GetMouseInfo();
            mouse_event((uint)MouseEventFlags.MOVE, coord.X - oldMouse.X, coord.Y - oldMouse.Y, 0, 0);
        }

        public static void MoveMouseRel(Point coord, string screen)
        {
            Point oldMouse = GetMouseInfoFromWindow(screen);
            Point[] screenInfo = GetWindowCoords(screen);
            if (screenInfo[1].X < coord.X && screenInfo[1].Y < coord.Y && coord.X < 0 && coord.Y < 0) return;
            MoveMouse(new Point(coord.X + screenInfo[0].X, screenInfo[0].Y- coord.Y));
        }
    }
}