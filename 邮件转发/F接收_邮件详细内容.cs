using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 内外网邮件转发
{
    public partial class F接收_邮件详细内容 : UserControl
    {
        public F接收_邮件详细内容()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.in抄送.Text = "";
            this.in发件人.Text = "";
            this.in附件.Text = "";
            this.in内容.Text = "";
            this.in时间.Text = "";
            this.in收件人.Text = "";

            this.do保存.Click += do保存_Click;
            this.do关闭.Click += do关闭_Click;
            this.do删除.Click += do删除_Click;
            this.do下载.Click += do下载_Click;
        }

        void do下载_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void do删除_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void do关闭_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void do保存_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
