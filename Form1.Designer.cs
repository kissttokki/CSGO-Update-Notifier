namespace CSUN_JJaery
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.jJaeryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.시작ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.주기설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.분ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.분ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.분ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.하루ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.지금바로체크ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "JJaery의 CSGO Server 알리미";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jJaeryToolStripMenuItem,
            this.toolStripMenuItem2,
            this.시작ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.주기설정ToolStripMenuItem,
            this.지금바로체크ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.종료ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 154);
            this.contextMenuStrip1.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.contextMenuStrip1_Closing);
            // 
            // jJaeryToolStripMenuItem
            // 
            this.jJaeryToolStripMenuItem.Enabled = false;
            this.jJaeryToolStripMenuItem.Name = "jJaeryToolStripMenuItem";
            this.jJaeryToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.jJaeryToolStripMenuItem.Text = "Made by JJaery";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 6);
            // 
            // 시작ToolStripMenuItem
            // 
            this.시작ToolStripMenuItem.Checked = true;
            this.시작ToolStripMenuItem.CheckOnClick = true;
            this.시작ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.시작ToolStripMenuItem.Name = "시작ToolStripMenuItem";
            this.시작ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.시작ToolStripMenuItem.Text = "활성화";
            this.시작ToolStripMenuItem.Click += new System.EventHandler(this.시작ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 6);
            // 
            // 주기설정ToolStripMenuItem
            // 
            this.주기설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.분ToolStripMenuItem,
            this.분ToolStripMenuItem1,
            this.분ToolStripMenuItem2,
            this.하루ToolStripMenuItem});
            this.주기설정ToolStripMenuItem.Name = "주기설정ToolStripMenuItem";
            this.주기설정ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.주기설정ToolStripMenuItem.Text = "주기설정";
            // 
            // 분ToolStripMenuItem
            // 
            this.분ToolStripMenuItem.CheckOnClick = true;
            this.분ToolStripMenuItem.Name = "분ToolStripMenuItem";
            this.분ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.분ToolStripMenuItem.Text = "10분";
            this.분ToolStripMenuItem.Click += new System.EventHandler(this.분ToolStripMenuItem_Click);
            // 
            // 분ToolStripMenuItem1
            // 
            this.분ToolStripMenuItem1.CheckOnClick = true;
            this.분ToolStripMenuItem1.Name = "분ToolStripMenuItem1";
            this.분ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.분ToolStripMenuItem1.Text = "30분";
            this.분ToolStripMenuItem1.Click += new System.EventHandler(this.분ToolStripMenuItem1_Click);
            // 
            // 분ToolStripMenuItem2
            // 
            this.분ToolStripMenuItem2.CheckOnClick = true;
            this.분ToolStripMenuItem2.Name = "분ToolStripMenuItem2";
            this.분ToolStripMenuItem2.Size = new System.Drawing.Size(100, 22);
            this.분ToolStripMenuItem2.Text = "60분";
            this.분ToolStripMenuItem2.Click += new System.EventHandler(this.분ToolStripMenuItem2_Click);
            // 
            // 하루ToolStripMenuItem
            // 
            this.하루ToolStripMenuItem.CheckOnClick = true;
            this.하루ToolStripMenuItem.Name = "하루ToolStripMenuItem";
            this.하루ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.하루ToolStripMenuItem.Text = "하루";
            this.하루ToolStripMenuItem.Click += new System.EventHandler(this.하루ToolStripMenuItem_Click);
            // 
            // 지금바로체크ToolStripMenuItem
            // 
            this.지금바로체크ToolStripMenuItem.Name = "지금바로체크ToolStripMenuItem";
            this.지금바로체크ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.지금바로체크ToolStripMenuItem.Text = "지금 바로 체크";
            this.지금바로체크ToolStripMenuItem.Click += new System.EventHandler(this.지금바로체크ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 6);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(331, 308);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(68, 85);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Url = new System.Uri("http://w", System.UriKind.Absolute);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 426);
            this.Controls.Add(this.webBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jJaeryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 시작ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주기설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 분ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 분ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 분ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 하루ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 지금바로체크ToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}

