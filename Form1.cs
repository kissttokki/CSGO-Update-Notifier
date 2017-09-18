using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace CSUN_JJaery
{
    public partial class Form1 : Form
    {
        public bool IsCancel = false;
        public static Thread mainthread;
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.Visible = false;
            this.notifyIcon1.Visible = true;
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
        }
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        private string FilePath = Application.StartupPath + "/CSUN.ini";
        // ini파일에 쓰기
        private void Writeini(string section, string key,string value)
        {
            WritePrivateProfileString(section, key, value,  FilePath);
        }


        // ini파일에서 읽기
        private string Readini(string section, string key)
        {
            StringBuilder temp = new StringBuilder(255);
            int ret = GetPrivateProfileString(section, key, "", temp, 255, FilePath);
            return temp.ToString();
        }
        

        private void FirstSetting()
        {
            Writeini("Setting", "activated", "1");
            시작ToolStripMenuItem.Checked = true;
            ChangeTimer(분ToolStripMenuItem, 10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            if (Readini("Setting", "activated") == "")
            {
                FirstSetting();
            }
            시작ToolStripMenuItem.Checked = Readini("Setting", "activated") == "1" ? true : false;

            if (Readini("Setting", "timer") != "")
            {
                var timer = Convert.ToInt32(Readini("Setting", "timer"));

                switch (timer)
                {
                    case 10:
                        분ToolStripMenuItem.Checked = true;
                        break;
                    case 30:
                        분ToolStripMenuItem1.Checked = true;
                        break;
                    case 60:
                        분ToolStripMenuItem2.Checked = true;
                        break;
                    case 1440:
                        하루ToolStripMenuItem.Checked = true;
                        break;
                }
                mainthread = new Thread(() =>
                {
                    while (true)
                    {
                        Thread.Sleep(timer * 60000);
                        Check();
                    }
                });
            }
            CheckParsing();
            if (mainthread != null)
                mainthread.Start();
            
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void 시작ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Writeini("Setting", "activated", 시작ToolStripMenuItem.Checked ? "1" : "0");
            시작ToolStripMenuItem.DropDown.AutoClose = false;
            if (시작ToolStripMenuItem.Checked)
                CheckParsing();
        }

        private void contextMenuStrip1_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            e.Cancel = IsCancel;
            IsCancel = false;
        }

        private void 분ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTimer((ToolStripMenuItem)sender, 10);
        }

        private void 분ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangeTimer((ToolStripMenuItem)sender, 30);
        }

        private void 분ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ChangeTimer((ToolStripMenuItem)sender, 60);
        }

        private void 하루ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTimer((ToolStripMenuItem)sender, 1440);
        }

        private void ChangeTimer(ToolStripMenuItem item, int timer)
        {
            if(mainthread != null)
                mainthread.Abort();
            mainthread = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(timer * 60000);
                    Check();
                }
            });
            mainthread.Start();
            CheckParsing();

            분ToolStripMenuItem.Checked = false;
            분ToolStripMenuItem1.Checked = false;
            분ToolStripMenuItem2.Checked = false;
            하루ToolStripMenuItem.Checked = false;

            item.Checked = true;
            Writeini("Setting", "timer", timer.ToString());
        }

        private void 지금바로체크ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = Readini("Updator", "recentlyKey");
            CheckParsing();
            if (temp == Readini("Updator", "recentlyKey"))
                MessageBox.Show("새로 추가된 릴리즈 노트가 없습니다.");
        }
        delegate void SetCheckCallback();
        private void Check()
        {
            if (this.webBrowser1.InvokeRequired)
            {
                SetCheckCallback d = new SetCheckCallback(CheckParsing);
                this.Invoke(d);
            }
            else
            {
                CheckParsing();
            }
        }

        public void CheckParsing()
        {

            if (!시작ToolStripMenuItem.Checked)
                return;
            
            webBrowser1.Navigate("http://blog.counter-strike.net/index.php/category/updates/");

            while (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }

                var str = webBrowser1.DocumentText.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
                string recentlyTitle = "";
                string title = "";

                for (int i = 0; i < str.Length - 1; i++)
                {
                    if (str[i].Contains("<div class=\"inner_post\">"))
                    {
                        var startpos = str[i + 1].IndexOf("/\">") + 3;
                        var lenght = str[i + 1].IndexOf("</a>") - str[i + 1].IndexOf("/\">") - 3;
                        recentlyTitle = str[i + 1].Substring(startpos, lenght);
                        title = recentlyTitle;
                    }
                }
            recentlyTitle = SHA256Hash(recentlyTitle);

                if (Readini("Updator", "recentlyKey") != recentlyTitle)
                {
                    Writeini("Updator", "recentlyKey", recentlyTitle);

                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.BalloonTipTitle = "새로운 게시글이 등록되었습니다.";
                    notifyIcon1.BalloonTipText = string.Format("제목 : {0}" , title);
                    notifyIcon1.ShowBalloonTip(60000);
                MessageBox.Show("새로운 게시글이 등록되었습니다. \r\n" + string.Format("제목 : {0}", title));
            }
                
            
        }
        public string SHA256Hash(string Data)
        {
            SHA256 sha = new SHA256Managed();
            byte[] hash = sha.ComputeHash(Encoding.ASCII.GetBytes(Data));

            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte b in hash)
            {
                stringBuilder.AppendFormat("{0:x2}", b);
            }
            return stringBuilder.ToString();
        }
        
    }
}
