using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using THS.Utils;
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
        private static extern bool GetCursorPos(out Point lpPoint);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);

        [DllImport("user32.dll")]
        private static extern bool AttachThreadInput(uint idAttach, uint idAttachTo, bool fAttach);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool BringWindowToTop(IntPtr hWnd);

        [DllImport("kernel32.dll")]
        private static extern uint GetCurrentThreadId();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, uint nCmdShow);




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
        public static void MoveMouse(Point coord, float speed)
        {
            double x = -1, y = -1, perc = 0, inc;
            Point oldMouse = GetMouseInfo();
            int iterations = 100;
            inc = Math.Sqrt(Math.Pow(Math.Abs(coord.X - oldMouse.X), 2) + Math.Pow(Math.Abs(coord.Y - oldMouse.Y), 2)) / speed;
            while (Math.Abs(coord.X - x) > 1 || Math.Abs(coord.Y - y) > 1)
            {
                Point currMouse = GetMouseInfo();
                x = oldMouse.X * (1 - perc) + coord.X * perc;
                y = oldMouse.Y * (1 - perc) + coord.Y * perc;
                mouse_event((uint)MouseEventFlags.MOVE, (int)Math.Ceiling(x - currMouse.X), (int)Math.Ceiling(y - currMouse.Y), 0, 0);
                perc += (1 / (float)iterations);
                Thread.Sleep((int)Math.Ceiling(1000 * inc / iterations));
            }
            //mouse_event((uint)MouseEventFlags.MOVE, coord.X - oldMouse.X, coord.Y - oldMouse.Y, 0, 0);
        }

        public static void MoveMouseRel(Point coord, string screen)
        {
            Point oldMouse = GetMouseInfoFromWindow(screen);
            Point[] screenInfo = GetWindowCoords(screen);
            if (screenInfo[1].X < coord.X && screenInfo[1].Y < coord.Y && coord.X < 0 && coord.Y < 0) return;
            MoveMouse(new Point(coord.X + screenInfo[0].X, screenInfo[0].Y - coord.Y), 500f);
        }
        public static void MoveMouseHs(Point coord)
        {
            Point oldMouse = GetMouseInfoFromWindow("Hearthstone");
            Point[] screenInfo = GetWindowCoords("Hearthstone");
            if (oldMouse.X == -1 || (screenInfo[1].X < coord.X && screenInfo[1].Y < coord.Y && coord.X < 0 && coord.Y < 0)) return;
            MoveMouse(new Point(coord.X + screenInfo[0].X, screenInfo[0].Y - coord.Y), 2000f);
        }
        public static void ClickMouseHS(bool left)
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
                if (!Title.Equals("Hearthstone")) return true;
                var Handle = hWnd;
                info.cbSize = (uint)Marshal.SizeOf(info);
                ForceForegroundWindow(Handle);
                chk = true;
                return true;
            }), 0);
            if (!chk)
            {
                IO.LogDebug("CLICK NO HEARTSTONE", IO.DebugFile.Input);
                return;
            }



            if (left)
            {
                mouse_event((uint)MouseEventFlags.LEFTDOWN, 0, 0, 0, 0);
                mouse_event((uint)MouseEventFlags.LEFTUP, 0, 0, 0, 0);
            }
            else
            {
                mouse_event((uint)MouseEventFlags.RIGHTDOWN, 0, 0, 0, 0);
                mouse_event((uint)MouseEventFlags.RIGHTUP, 0, 0, 0, 0);
            }

        }
        private static void ForceForegroundWindow(IntPtr hWnd)

        {

            uint foreThread = GetWindowThreadProcessId(GetForegroundWindow(), IntPtr.Zero);

            uint appThread = GetCurrentThreadId();

            const uint SW_SHOW = 5;

            if (foreThread != appThread)

            {

                AttachThreadInput(foreThread, appThread, true);

                BringWindowToTop(hWnd);

                ShowWindow(hWnd, SW_SHOW);

                AttachThreadInput(foreThread, appThread, false);

            }

            else

            {

                BringWindowToTop(hWnd);

                ShowWindow(hWnd, SW_SHOW);

            }

        }
    }
}