using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace 内外网邮件转发
{
    public partial class F主窗口 : Form
    {
        bool _彻底退出 = false;

        public F主窗口()
        {
            InitializeComponent();

            this.Text += " " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.out标题.Text = this.Text;

            var __接收 = new F接收 { Dock = DockStyle.Fill };
            this.uTab1.添加("接收", __接收);

            var __发送 = new F发送 { Dock = DockStyle.Fill };
            this.uTab1.添加("发送", __发送);

            var __自动转发 = new F自动转发 { Dock = DockStyle.Fill };
            this.uTab1.添加("自动转发", __自动转发);

            this.out通知栏.MouseClick += out通知栏_Click;
            this.do退出.Click += do退出_Click;

            this.FormClosing += F主窗口_FormClosing;
        }

        void do退出_Click(object sender, EventArgs e)
        {
            _彻底退出 = true;
            Application.Exit();
        }

        void F主窗口_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_彻底退出)
            {
                return;
            }
            this.Hide();
            e.Cancel = true;
        }

        void out通知栏_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
            }
        }
    }
}
