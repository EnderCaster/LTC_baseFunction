/*
 成功其实很简单，不过只有两点：
 想做什么就去做
 定下的计划按时完成
 可惜，绝大多数人做不到以上两点，写在这里，与大家共勉。
 */


using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LTC_baseFunction
{
    public partial class TheOnlyOne : Form
    {
        public enum DesktopLayer
        {
            Progman = 0,
            SHELLDLL = 1,
            FolderView = 2
        }
        private bool textChanged = false;
        private Point mouseOffset;
        private bool isMouseDown = false;
        private string Filename = @".\\Data\\TODO.da";
        private string tmpFilename = @".\\Data\\TODO.da.tmp";
        static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
        static readonly IntPtr HWND_TOP = new IntPtr(0);
        const int SWP_NOSIZE = 0x0001;
        const int SWP_NOMOVE = 0x0002;
        const int SWP_NOZORDER = 0x0004;
        const int SWP_NOREDRAW = 0x0008;
        const int SWP_NOACTIVATE = 0x0010;
        const int SWP_FRAMECHANGED = 0x0020;
        const int SWP_SHOWWINDOW = 0x0040;
        const int SWP_HIDEWINDOW = 0x0080;
        const int SWP_NOCOPYBITS = 0x0100;
        const int SWP_NOOWNERZORDER = 0x0200;
        const int SWP_NOSENDCHANGING = 0x0400;
        const int TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        //构造函数
        public TheOnlyOne()
        {
            InitializeComponent();
            //置于右上角
            //置顶
            Win32Support.SetWindowPos(new HandleRef(this,this.Handle), new HandleRef(this,HWND_TOPMOST), 0, 0, 0, 0, TOPMOST_FLAGS);
            //读取内容
            if (File.Exists(Filename))
            {
                string[] lines = File.ReadAllLines(Filename);
                foreach (string line in lines)
                {
                    text_Main.Text += line;
                    text_Main.Text += Environment.NewLine;
                }
            }
        }

        //使用鼠标移动窗体
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight -
                    SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        //窗口内控件函数说明
        private void Edit_Click(object sender, EventArgs e)
        {
            text_Main.ReadOnly = false;
            Edit.Visible = Edit.Enabled = false;
            submit.Visible = submit.Enabled = true;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (textChanged == true)
            {
                //改写记录文件
                StringReader sr = new StringReader(text_Main.Text);
                if (!Directory.Exists(@".\\Data"))
                {
                    Directory.CreateDirectory(@".\\Data");
                }
                string line = sr.ReadLine();
                FileStream tmpfs = File.Create(tmpFilename);
                StreamWriter tmpfile = new StreamWriter(tmpfs);
                while (line != null)
                {
                    tmpfile.Write(line);
                    if ((line = sr.ReadLine()) != null)
                    {
                        tmpfile.WriteLine();
                    }
                }
                File.Delete(Filename);
                sr.Dispose();
                tmpfile.Dispose();
                File.Move(tmpFilename, Filename);
                //重置为 FALSE
                textChanged = false;
            }
            text_Main.ReadOnly = true;
            Edit.Visible = Edit.Enabled = true;
            submit.Visible = submit.Enabled = false;
        }

        private void text_Main_TextChanged(object sender, EventArgs e)
        {
            textChanged = true;
        }
    }


    //WIN32 API 置顶
    class Win32Support
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow(string className, string windowName);
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetWindow(HandleRef hWnd, int nCmd);
        [DllImport("user32.dll")]
        public static extern IntPtr SetParent(IntPtr child, IntPtr parent);
        [DllImport("user32.dll", EntryPoint = "GetDCEx", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetDCEx(IntPtr hWnd, IntPtr hrgnClip, int flags);
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetWindowPos(HandleRef hWnd, HandleRef hWndInsertAfter, int x, int y, int cx, int cy, int flags);
        [DllImport("user32.dll")]
        public static extern int ReleaseDC(IntPtr window, IntPtr handle);
    }
}
