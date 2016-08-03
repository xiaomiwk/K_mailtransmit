using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility.通用;
using Aspose.Email;
using Aspose.Email.Mail;
using Aspose.Email.Pop3;

namespace 内外网邮件转发
{
    public partial class F自动转发 : UserControl
    {
        private string _内网发送地址;

        private int _内网发送端口号;

        private bool _内网发送OAuth;

        private string _内网接收地址;

        private int _内网接收端口号;

        private string _内网域名;

        private string _内网转发账号;

        private string _内网转发密码;

        int _内网转外网失败数;


        private string _外网接收地址;

        private int _外网接收端口号;

        private string _外网发送地址;

        private int _外网发送端口号;

        private bool _外网发送useOAuth;

        private string _外网域名;

        int _外网转内网失败数;


        private Dictionary<string, List<string>> _处理不了的外网邮件 = new Dictionary<string, List<string>>();

        private List<string> _处理不了的内网邮件 = new List<string>();

        public F自动转发()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.Text += " " + Assembly.GetEntryAssembly().GetName().Version;
            _内网发送地址 = Utility.存储.H程序配置.获取字符串("内网发送地址");
            _内网发送端口号 = Utility.存储.H程序配置.获取Int32值("内网发送端口号");
            _内网发送OAuth = Utility.存储.H程序配置.获取Bool值("内网发送OAuth");
            _内网接收地址 = Utility.存储.H程序配置.获取字符串("内网接收地址");
            _内网接收端口号 = Utility.存储.H程序配置.获取Int32值("内网接收端口号");
            _内网域名 = Utility.存储.H程序配置.获取字符串("内网域名");
            _内网转发账号 = Utility.存储.H程序配置.获取字符串("内网转发账号");
            _内网转发密码 = Utility.存储.H程序配置.获取字符串("内网转发密码");

            _外网发送地址 = Utility.存储.H程序配置.获取字符串("外网发送地址");
            _外网发送端口号 = Utility.存储.H程序配置.获取Int32值("外网发送端口号");
            _外网发送useOAuth = Utility.存储.H程序配置.获取Bool值("外网发送OAuth");
            _外网接收地址 = Utility.存储.H程序配置.获取字符串("外网接收地址");
            _外网接收端口号 = Utility.存储.H程序配置.获取Int32值("外网接收端口号");
            _外网域名 = Utility.存储.H程序配置.获取字符串("外网域名");

            this.out内网发送.Text = string.Format("{0}: {1}", _内网发送地址, _内网发送端口号);
            this.out内网接收.Text = string.Format("{0}: {1}", _内网接收地址, _内网接收端口号);
            this.out外网发送.Text = string.Format("{0}: {1}", _外网发送地址, _外网发送端口号);
            this.out外网接收.Text = string.Format("{0}: {1}", _外网接收地址, _外网接收端口号);
            this.out内网发送.BackColor = Color.Yellow;
            this.out内网接收.BackColor = Color.Yellow;
            this.out外网发送.BackColor = Color.Yellow;
            this.out外网接收.BackColor = Color.Yellow;

            this.out关联列表.DataSource = 查询邮箱关联();

            if (bool.Parse(ConfigurationManager.AppSettings["开启外网转内网"]))
            {
                new Task(处理外网转内网).Start();
            }
            else
            {
                this.out外网转内网.Text += "  (未开启)";

            }
            if (bool.Parse(ConfigurationManager.AppSettings["开启内网转外网"]))
            {
                new Task(处理内网转外网).Start();
            }
            else
            {
                this.out内网转外网.Text += "  (未开启)";
            }
        }

        private static List<M邮箱关联> 查询邮箱关联()
        {
            var __doc = System.Xml.Linq.XDocument.Load("邮箱关联.xml");
            var __配置列表 = __doc.Element("所有匹配").Elements("匹配").ToList();
            var __所有匹配 = __配置列表.Select(t => new M邮箱关联
                                       {
                                           姓名 = t.Attribute("姓名").Value,
                                           内网账号 = t.Attribute("内网账号").Value,
                                           外网账号 = t.Attribute("外网账号").Value,
                                           外网密码 = t.Attribute("外网密码").Value,
                                       }).ToList();
            return __所有匹配;
        }

        void 处理外网转内网()
        {
            bool __第一次 = true;
            bool __连接状态 = true;
            while (true)
            {
                if (__第一次)
                {
                    __第一次 = false;
                }
                else
                {
                    System.Threading.Thread.Sleep(Utility.存储.H程序配置.获取Int32值("检测周期") * 1000);
                }

                //判断内网连接状态
                var __内网连接状态 = 检测TCP连通(_内网发送地址, _内网发送端口号);
                this.Invoke(new Action(() =>
                {
                    this.out内网发送.BackColor = __内网连接状态 ? Color.Green : Color.Red;
                    this.out内网发送.ForeColor = Color.White;
                }));

                //判断外网连接状态
                var __外网连接状态 = 检测TCP连通(_外网接收地址, _外网接收端口号);
                this.Invoke(new Action(() =>
                {
                    this.out外网接收.BackColor = __外网连接状态 ? Color.Green : Color.Red;
                    this.out外网接收.ForeColor = Color.White;
                }));

                if (__连接状态 != (__内网连接状态 && __外网连接状态))
                {
                    H调试.记录(string.Format("内网连接正常: {0}; 外网连接正常: {1} ", __内网连接状态, __外网连接状态));
                    __连接状态 = __内网连接状态 && __外网连接状态;
                }
                if (!__连接状态)
                {
                    continue;
                }

                //接收外网邮件
                var __所有关联 = 查询邮箱关联();
                foreach (var __关联 in __所有关联)
                {
                    var __外网账号 = __关联.外网账号;
                    var __外网密码 = __关联.外网密码;
                    var __内网账号 = __关联.内网账号;

                    if (!_处理不了的外网邮件.ContainsKey(__外网账号))
                    {
                        _处理不了的外网邮件[__外网账号] = new List<string>();
                    }
                    using (var __pop3 = new Pop3Client(_外网接收地址, _外网接收端口号, __外网账号, __外网密码))
                    {
                        try
                        {
                            __pop3.Connect(true);
                        }
                        catch (Exception ex)
                        {
                            H调试.记录(string.Format("连接外网 [{0}] 失败, 账号:{1}, 失败原因: {2}", _外网接收地址, __外网账号, ex.Message));
                            continue;
                        }
                        var __邮件列表 = __pop3.ListMessages();
                        var __smtp = new SmtpClient(_内网发送地址, _内网发送端口号, _内网转发账号, _内网转发密码, _内网发送OAuth);
                        for (var i = 0; i < __邮件列表.Count; i++)
                        {
                            var __邮件概要 = __邮件列表[i];
                            if (_处理不了的外网邮件[__外网账号].Contains(__邮件概要.UniqueId))
                            {
                                continue;
                            }
                            MailMessage __邮件;
                            try
                            {
                                __邮件 = __pop3.FetchMessage(__邮件概要.SequenceNumber);
                            }
                            catch (Exception ex)
                            {
                                H调试.记录(string.Format("解析 [{0}] 的邮件失败, {1}", __外网账号, ex.Message), TraceEventType.Error);
                                _内网转外网失败数++;
                                _处理不了的外网邮件[__外网账号].Add(__邮件概要.UniqueId);
                                continue;
                            }
                            try
                            {
                                __邮件.To = __内网账号 + "@" + _内网域名;
                                __邮件.From.Address = _内网转发账号 + "@" + _内网域名;
                                __邮件.CC.Clear();
                                __邮件.Bcc.Clear();
                                __smtp.Send(__邮件);
                                __pop3.DeleteMessage(__邮件概要.SequenceNumber);
                                var __内容 = string.Format("外->内转发 [{0}] 的 [{1}] 的邮件成功", __外网账号, __邮件.Subject);
                                H调试.记录(__内容);
                                记录(__内容);
                            }
                            catch (Exception ex)
                            {
                                var __内容 = string.Format("外->内转发 [{0}] 的 [{1}] 的邮件失败, {2}", __外网账号, __邮件.Subject, ex.Message);
                                H调试.记录(__内容, TraceEventType.Error);
                                记录(__内容);
                                _外网转内网失败数++;
                                continue;
                            }
                        }
                        __smtp.Dispose();
                        __pop3.Disconnect();
                    }
                }
                this.Invoke(new Action(() =>
                {
                    if (_外网转内网失败数 > 0)
                    {
                        this.out外网转内网失败数.Visible = true;
                        this.out外网转内网失败数.Text = string.Format("共 [{0}] 封邮件转发失败", _外网转内网失败数);
                    }
                    else
                    {
                        this.out外网转内网失败数.Visible = false;
                    }
                }));
            }
        }

        void 处理内网转外网()
        {
            bool __第一次 = true;
            bool __连接状态 = true;
            while (true)
            {
                if (__第一次)
                {
                    __第一次 = false;
                }
                else
                {
                    System.Threading.Thread.Sleep(Utility.存储.H程序配置.获取Int32值("检测周期") * 1000);
                }

                //判断内网连接状态
                var __内网连接状态 = 检测TCP连通(_内网接收地址, _内网接收端口号);
                this.Invoke(new Action(() =>
                {
                    this.out内网接收.BackColor = __内网连接状态 ? Color.Green : Color.Red;
                    this.out内网接收.ForeColor = Color.White;
                }));

                //判断外网连接状态
                var __外网连接状态 = 检测TCP连通(_外网发送地址, _外网发送端口号);
                this.Invoke(new Action(() =>
                {
                    this.out外网发送.BackColor = __外网连接状态 ? Color.Green : Color.Red;
                    this.out外网发送.ForeColor = Color.White;
                }));

                if (__连接状态 != (__内网连接状态 && __外网连接状态))
                {
                    H调试.记录(string.Format("内网连接正常: {0}; 外网连接正常: {1} ", __内网连接状态, __外网连接状态));
                    __连接状态 = __内网连接状态 && __外网连接状态;
                }
                if (!__连接状态)
                {
                    continue;
                }

                //接收内网邮件
                var __内网转发账号 = Utility.存储.H程序配置.获取字符串("内网转发账号");
                var __内网转发密码 = Utility.存储.H程序配置.获取字符串("内网转发密码");
                var __所有关联 = 查询邮箱关联();
                var __pop3 = new Pop3Client(_内网接收地址, _内网接收端口号, __内网转发账号, __内网转发密码);
                var __邮件列表 = new List<MailMessage>();
                Pop3MessageInfoCollection __邮件概要列表;
                try
                {
                    __pop3.Connect(true);
                    __邮件概要列表 = __pop3.ListMessages();
                    for (var i = 0; i < __邮件概要列表.Count; i++)
                    {
                        var __邮件概要 = __邮件概要列表[i];
                        if (_处理不了的内网邮件.Contains(__邮件概要.UniqueId))
                        {
                            continue;
                        }
                        try
                        {
                            var __邮件 = __pop3.FetchMessage(__邮件概要.SequenceNumber);
                            __邮件.MessageId = __邮件概要.UniqueId;
                            __邮件列表.Add(__pop3.FetchMessage(__邮件概要.SequenceNumber));
                        }
                        catch (Exception ex)
                        {
                            H调试.记录(string.Format("解析 [{0}] 的邮件失败, {1}", __内网转发账号, ex.Message), TraceEventType.Error);
                            _内网转外网失败数++;
                            _处理不了的内网邮件.Add(__邮件概要.UniqueId);
                        }
                    }
                    __pop3.Disconnect();
                }
                catch (Exception ex)
                {
                    H调试.记录(string.Format("连接内网 [{0}]失败, {1}", _内网接收地址, ex.Message));
                    continue;
                }
                finally
                {
                    __pop3.Dispose();
                }

                var __待删除列表 = new List<int>();
                for (var i = 0; i < __邮件列表.Count; i++)
                {
                    var __邮件 = __邮件列表[i];
                    //转发到外网
                    string __内网账号 = string.Empty;
                    try
                    {
                        //设置发件人
                        __内网账号 = __邮件.From[0].Address;
                        __内网账号 = __内网账号.Substring(0, __内网账号.IndexOf('@'));
                        var __匹配 = __所有关联.Find(q => q.内网账号 == __内网账号);
                        if (__匹配 != null)
                        {
                            __邮件.From = new MailAddress(__匹配.外网账号 + "@" + _外网域名, __匹配.姓名); //__匹配.姓名

                        }
                        else
                        {
                            H调试.记录(string.Format("[{0}] 未配置外网账号", __内网账号), TraceEventType.Error);
                            __待删除列表.Add(i);
                            continue;
                        }

                        //设置收件人
                        foreach (var __收件人 in __邮件.To)
                        {
                            __收件人.Address = __收件人.DisplayName.Trim('\"');
                        }
                        foreach (var __收件人 in __邮件.CC)
                        {
                            __收件人.Address = __收件人.DisplayName.Trim('\"');
                        }
                        foreach (var __收件人 in __邮件.Bcc)
                        {
                            __收件人.Address = __收件人.DisplayName.Trim('\"');
                        }
                        var __smtp = new SmtpClient(_外网发送地址, _外网发送端口号, __匹配.外网账号, __匹配.外网密码, _外网发送useOAuth);
                        __smtp.Send(__邮件);
                        __smtp.Dispose();
                        __待删除列表.Add(i);

                        var __内容 = string.Format("内->外转发 [{0}] 的 [{1}] 邮件成功", __内网账号, __邮件.Subject);
                        H调试.记录(__内容);
                        记录(__内容);
                    }
                    catch (Exception ex)
                    {
                        _内网转外网失败数++;
                        _处理不了的内网邮件.Add(__邮件.MessageId);
                        __待删除列表.Add(i);
                        var __smtp = new SmtpClient(_内网发送地址, _内网发送端口号, __内网转发账号, __内网转发密码, _内网发送OAuth);
                        __smtp.Send(__内网转发账号 + "@" + _内网域名, __内网账号 + "@" + _内网域名, string.Format("转发失败: {0}", __邮件.Subject), string.Format("失败原因: {0}", ex.Message));
                        __smtp.Dispose();

                        var __内容 = string.Format("内->外转发 [{0}] 的 [{1}] 邮件失败, {2}", __内网账号, __邮件.Subject, ex.Message);
                        H调试.记录(__内容, TraceEventType.Error);
                        记录(__内容);
                    }
                }
                __pop3.Connect(true);
                __待删除列表.ForEach(q => __pop3.DeleteMessage(__邮件概要列表[q].SequenceNumber));
                __pop3.Disconnect();

                this.Invoke(new Action(() =>
                    {
                        if (_内网转外网失败数 > 0)
                        {
                            this.out内网转外网失败数.Visible = true;
                            this.out内网转外网失败数.Text = string.Format("共 [{0}] 封邮件转发失败", _内网转外网失败数);
                        }
                        else
                        {
                            this.out内网转外网失败数.Visible = false;
                        }
                    }));
            }
        }

        private bool 检测TCP连通(string __主机名, int __端口号)
        {
            using (var __连接 = new TcpClient())
            {
                try
                {
                    __连接.Connect(__主机名, __端口号);
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return true;
        }

        private void 记录(string __内容)
        {
            this.Invoke(new Action(() =>
            {
                if (this.in转发记录.Text.Length > 10000)
                {
                    this.in转发记录.Text = this.in转发记录.Text.Substring(0, 5000) + "  ......";
                }
                var __描述 = new StringBuilder();
                __描述.AppendLine(DateTime.Now.ToLongTimeString());
                __描述.AppendLine(__内容);
                __描述.AppendLine();
                __描述.AppendLine(this.in转发记录.Text);
                this.in转发记录.Text = __描述.ToString();
            }));
        }
    }
}
