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
        public struct POINT
        {
            public int X;
            public int Y;

            public static implicit operator Point(POINT point)
            {
                return new Point(point.X, point.Y);
            }
        }

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool GetWindowInfo(IntPtr hwnd, ref WINDOWINFO pwi);

        private delegate bool EnumWindowsDel(IntPtr hWnd, int lParam);

        [DllImport("USER32.DLL")]
        private static extern bool EnumWindows(EnumWindowsDel enumFunc, int lParam);

        [DllImport("USER32.DLL")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("USER32.DLL")]
        private static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("USER32.DLL")]
        private static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("USER32.DLL")]
        public static extern bool GetCursorPos(out POINT lpPoint);

        [DllImport("USER32.DLL")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("USER32.DLL")]
        private static extern int GetWindowThreadProcessId(IntPtr handle, out uint processId);

        public static void GetWindowInfo(THS.Windows.THS window, string screen)
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
                window.SetText(window.LabelScreenOrigin, info.rcClient.Left + "," + info.rcClient.Bottom);
                window.SetText(window.LabelScreenSize, (info.rcClient.Right - info.rcClient.Left) + "," + (info.rcClient.Bottom - info.rcClient.Top));
            }
            else
            {
                window.SetText(window.LabelScreenOrigin, "N/A");
                window.SetText(window.LabelScreenSize, "N/A");
            }
        }
        public static void GetMouseInfo(THS.Windows.THS window)
        {
            POINT cursor;
            GetCursorPos(out cursor);
            window.SetText(window.LabelMouse, cursor.X + "," + cursor.Y);
        }
    }
}