using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aspose.Email.Mail;

namespace 内外网邮件转发
{
    public partial class F发送 : UserControl
    {
        public F发送()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.in附件.Text = "e:\\Msg1234.eml";
            this.in内容.Text = "收到订单11aaa";
            this.in主题.Text = "主题...";

            this.do发送.Click += do发送_Click;
            this.do添加.Click += do添加_Click;

            this.in配置.Items.AddRange(new[] { "sdlserver1.com", "neolink.com.cn" });
            this.in配置.SelectedIndexChanged += in配置_SelectedIndexChanged;
            this.in配置.DropDownStyle = ComboBoxStyle.DropDownList;
            this.in配置.SelectedIndex = 0;
        }

        void in配置_SelectedIndexChanged(object sender, EventArgs e)
        {
            var __当前选择 = (string)this.in配置.SelectedItem;
            this.inssl.Checked = false;
            switch (__当前选择)
            {
                case "sdlserver1.com":
                    this.in服务器.Text = "202.195.114.89";
                    this.in端口号.Text = "25";
                    this.inuseOAuth.Checked = true;
                    this.in账号.Text = "wangkai";
                    this.in密码.Text = "1";
                    this.in收件人.Text = "wangkai@sdlserver1.com";
                    this.in抄送.Text = "";
                    this.in域名.Text = "sdlserver1.com";
                    break;
                case "neolink.com.cn":
                    this.in服务器.Text = "mail.neolink.com.cn";
                    this.in端口号.Text = "25";
                    this.inuseOAuth.Checked = false;
                    this.in账号.Text = "kwang";
                    this.in密码.Text = "neolink1";
                    this.in收件人.Text = "kwang@neolink.com.cn";
                    this.in抄送.Text = "";
                    this.in域名.Text = "neolink.com.cn";
                    break;
            }
        }

        void do添加_Click(object sender, EventArgs e)
        {
            var __对话框 = new OpenFileDialog();
            if (__对话框.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(this.in附件.Text.Trim()))
                {
                    this.in附件.Text = string.Join(";", __对话框.FileNames);
                }
                else
                {
                    this.in附件.Text =this.in附件.Text + ";" + string.Join(";", __对话框.FileNames);
                }
            }
        }

        void do发送_Click(object sender, EventArgs e)
        {
            var __smtp = new SmtpClient(this.in服务器.Text, int.Parse(this.in端口号.Text), this.in账号.Text, this.in密码.Text, this.inuseOAuth.Checked);
            __smtp.EnableSsl = this.inssl.Checked;
            var __邮件 = new MailMessage
            {
                Subject = this.in主题.Text,
                IsBodyHtml = true,
                HtmlBody = this.in内容.Text,
                From = this.in账号.Text + "@" + this.in域名.Text,
                To = this.in收件人.Text,//__邮件.To.Add(this.in收件人.Text);
            };

            if (!string.IsNullOrEmpty(this.in抄送.Text.Trim()))
            {
                __邮件.CC = this.in抄送.Text;
            }

            var __附件列表 = this.in附件.Text.Trim();
            if (!string.IsNullOrEmpty(__附件列表))
            {
                __附件列表.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList().ForEach(q => __邮件.AddAttachment(new Attachment(q)));
                __邮件.Headers["X-Has-Attach"] = "yes";
            }
            try
            {
                __smtp.Send(__邮件);
            }
            catch (Exception ex)
            {
                MessageBox.Show("发送失败: " + ex.Message);
            }
            finally
            {
                __smtp.Dispose();
            }
        }

    }
}
