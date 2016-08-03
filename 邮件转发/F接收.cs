using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aspose.Email;
using Aspose.Email.Mail;
using Aspose.Email.Pop3;

namespace 内外网邮件转发
{
    public partial class F接收 : UserControl
    {
        public F接收()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.in服务器.Text = "202.195.114.89";
            this.in账号.Text = "zhuanfa";
            this.in密码.Text = "1";

            this.in服务器.Text = "mail.neolink.com.cn";
            this.in账号.Text = "kwang";
            this.in密码.Text = "neolink1";

            this.in配置.Items.AddRange(new[] { "sdlserver1.com", "neolink.com.cn" });
            this.in配置.SelectedIndexChanged += in配置_SelectedIndexChanged;
            this.in配置.DropDownStyle = ComboBoxStyle.DropDownList;
            this.in配置.SelectedIndex = 0;

            this.do接收.Click += do接收_Click;
            this.do全部删除.Click += do全部删除_Click;
            this.out邮件列表.CellDoubleClick += out邮件列表_CellDoubleClick;
            this.out邮件列表.CellClick += out邮件列表_CellClick;
        }

        void in配置_SelectedIndexChanged(object sender, EventArgs e)
        {
            var __当前选择 = (string)this.in配置.SelectedItem;
            switch (__当前选择)
            {
                case "sdlserver1.com":
                    this.in服务器.Text = "202.195.114.89";
                    this.in账号.Text = "zhuanfa";
                    this.in密码.Text = "1";
                    this.in端口号.Text = "110";
                    break;
                case "neolink.com.cn":
                    this.in服务器.Text = "mail.neolink.com.cn";
                    this.in账号.Text = "kwang";
                    this.in密码.Text = "neolink1";
                    this.in端口号.Text = "110";
                    break;
            }
        }

        void out邮件列表_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var __查看命令 = e.ColumnIndex == this.out邮件列表.ColumnCount - 2;
            if (__查看命令)
            {
                var __邮件概要 = this.out邮件列表.Rows[e.RowIndex].Tag as Pop3MessageInfo;
                if (__邮件概要 == null)
                {
                    return;
                }
                查看邮件(__邮件概要);
            }
            var __删除命令 = e.ColumnIndex == this.out邮件列表.ColumnCount - 1;
            if (__删除命令)
            {
                var __邮件概要 = this.out邮件列表.Rows[e.RowIndex].Tag as Pop3MessageInfo;
                if (__邮件概要 == null)
                {
                    return;
                }
                var __pop3 = getPOP3();
                try
                {
                    __pop3.Connect(true);
                    __pop3.DeleteMessage(__邮件概要.SequenceNumber);
                    __pop3.Disconnect();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("删除邮件出错: " + ex.Message);
                }
                finally
                {
                    __pop3.Dispose();
                }
            }
        }

        private void 查看邮件(Pop3MessageInfo __邮件概要)
        {
            var __pop3 = getPOP3();
            try
            {
                __pop3.Connect(true);
                var __缓存路径 = Path.Combine(Environment.CurrentDirectory, "TEMP\\"+__邮件概要.UniqueId + ".eml");
                if (!Directory.Exists(__缓存路径))
                {
                    __pop3.SaveMessage(__邮件概要.SequenceNumber, __缓存路径);
                }
                __pop3.Disconnect();
                Process.Start(__缓存路径);
            }
            catch (Exception ex)
            {
                MessageBox.Show("查看邮件详细内容出错: " + ex.Message);
            }
            finally
            {
                __pop3.Dispose();
            }
        }

        void out邮件列表_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var __邮件概要 = this.out邮件列表.Rows[e.RowIndex].Tag as Pop3MessageInfo;
            if (__邮件概要 == null)
            {
                return;
            }
            查看邮件(__邮件概要);
        }

        void do接收_Click(object sender, EventArgs e)
        {
            var __pop3 = getPOP3();
            try
            {
                __pop3.Connect(true);
                this.out邮件列表.Rows.Clear();
                var __邮件列表 = __pop3.ListMessages();
                for (int i = 0; i < __邮件列表.Count; i++)
                {
                    var __邮件概要 = __邮件列表[i];
                    var __包含附件 = "";
                    if (__邮件概要.Headers != null && __邮件概要.Headers.AllKeys != null
                        && __邮件概要.Headers.AllKeys.Contains("X-Has-Attach") && __邮件概要.Headers["X-Has-Attach"] == "yes")
                    {
                        __包含附件 = "有";
                    }
                    this.out邮件列表.Rows[this.out邮件列表.Rows.Add(i + 1, __邮件概要.Date, __邮件概要.From, __邮件概要.Subject, __包含附件)].Tag = __邮件概要;
                }
                __pop3.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取邮件列表出错: " + ex.Message);
            }
            finally
            {
                __pop3.Dispose();
            }
        }

        private Pop3Client getPOP3()
        {
            var __服务器 = this.in服务器.Text.Trim();
            var __账号 = this.in账号.Text.Trim();
            var __密码 = this.in密码.Text.Trim();
            var __端口号 = int.Parse(this.in端口号.Text.Trim());

            var __pop3 = new Pop3Client(__服务器, __端口号, __账号, __密码);
            return __pop3;
        }

        void do全部删除_Click(object sender, EventArgs e)
        {
            var __pop = getPOP3();
            try
            {
                __pop.Connect(true);
                __pop.DeleteAllMessages();
                __pop.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除所有邮件出错: " + ex.Message);
            }
            finally
            {
                __pop.Dispose();
            }
        }
    }
}
