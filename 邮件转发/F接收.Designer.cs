namespace 内外网邮件转发
{
    partial class F接收
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label21 = new System.Windows.Forms.Label();
            this.out邮件列表 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.in服务器 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.in密码 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.in账号 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.do接收 = new Utility.WindowsForm.U按钮();
            this.do全部删除 = new Utility.WindowsForm.U按钮();
            this.in端口号 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.in配置 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.out邮件列表)).BeginInit();
            this.SuspendLayout();
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.DimGray;
            this.label21.Location = new System.Drawing.Point(35, 208);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 19);
            this.label21.TabIndex = 21;
            this.label21.Text = "邮件列表";
            // 
            // out邮件列表
            // 
            this.out邮件列表.AllowUserToAddRows = false;
            this.out邮件列表.AllowUserToDeleteRows = false;
            this.out邮件列表.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.out邮件列表.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.out邮件列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.out邮件列表.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.out邮件列表.Location = new System.Drawing.Point(39, 246);
            this.out邮件列表.Name = "out邮件列表";
            this.out邮件列表.ReadOnly = true;
            this.out邮件列表.RowTemplate.Height = 23;
            this.out邮件列表.Size = new System.Drawing.Size(1081, 405);
            this.out邮件列表.TabIndex = 20;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "#";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 60;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "时间";
            this.Column6.HeaderText = "时间";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 120;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "发件人";
            this.Column1.HeaderText = "发件人";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "主题";
            this.Column2.HeaderText = "主题";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "附件";
            this.Column3.HeaderText = "附件";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Text = "详细";
            this.Column4.UseColumnTextForButtonValue = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Text = "删除";
            this.Column5.UseColumnTextForButtonValue = true;
            // 
            // in服务器
            // 
            this.in服务器.Location = new System.Drawing.Point(121, 77);
            this.in服务器.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.in服务器.Name = "in服务器";
            this.in服务器.Size = new System.Drawing.Size(186, 24);
            this.in服务器.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(39, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "服务器：";
            // 
            // in密码
            // 
            this.in密码.Location = new System.Drawing.Point(916, 74);
            this.in密码.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.in密码.Name = "in密码";
            this.in密码.PasswordChar = '*';
            this.in密码.Size = new System.Drawing.Size(164, 24);
            this.in密码.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(850, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "密码：";
            // 
            // in账号
            // 
            this.in账号.Location = new System.Drawing.Point(607, 74);
            this.in账号.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.in账号.Name = "in账号";
            this.in账号.Size = new System.Drawing.Size(186, 24);
            this.in账号.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(538, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "账号：";
            // 
            // do接收
            // 
            this.do接收.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(164)))), ((int)(((byte)(221)))));
            this.do接收.FlatAppearance.BorderSize = 0;
            this.do接收.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.do接收.ForeColor = System.Drawing.Color.White;
            this.do接收.Location = new System.Drawing.Point(39, 132);
            this.do接收.Name = "do接收";
            this.do接收.Size = new System.Drawing.Size(100, 26);
            this.do接收.TabIndex = 23;
            this.do接收.Text = "接收";
            this.do接收.UseVisualStyleBackColor = false;
            this.do接收.大小 = new System.Drawing.Size(100, 26);
            this.do接收.颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(164)))), ((int)(((byte)(221)))));
            // 
            // do全部删除
            // 
            this.do全部删除.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.do全部删除.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(164)))), ((int)(((byte)(221)))));
            this.do全部删除.FlatAppearance.BorderSize = 0;
            this.do全部删除.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.do全部删除.ForeColor = System.Drawing.Color.White;
            this.do全部删除.Location = new System.Drawing.Point(39, 669);
            this.do全部删除.Name = "do全部删除";
            this.do全部删除.Size = new System.Drawing.Size(100, 26);
            this.do全部删除.TabIndex = 24;
            this.do全部删除.Text = "全部删除";
            this.do全部删除.UseVisualStyleBackColor = false;
            this.do全部删除.大小 = new System.Drawing.Size(100, 26);
            this.do全部删除.颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(164)))), ((int)(((byte)(221)))));
            // 
            // in端口号
            // 
            this.in端口号.Location = new System.Drawing.Point(430, 75);
            this.in端口号.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.in端口号.Name = "in端口号";
            this.in端口号.Size = new System.Drawing.Size(69, 24);
            this.in端口号.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(351, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "端口号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(39, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 60;
            this.label5.Text = "模板：";
            // 
            // in配置
            // 
            this.in配置.FormattingEnabled = true;
            this.in配置.Location = new System.Drawing.Point(121, 29);
            this.in配置.Name = "in配置";
            this.in配置.Size = new System.Drawing.Size(186, 27);
            this.in配置.TabIndex = 59;
            // 
            // F接收
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.in配置);
            this.Controls.Add(this.in端口号);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.do全部删除);
            this.Controls.Add(this.do接收);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.out邮件列表);
            this.Controls.Add(this.in服务器);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.in密码);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.in账号);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "F接收";
            this.Size = new System.Drawing.Size(1154, 716);
            ((System.ComponentModel.ISupportInitialize)(this.out邮件列表)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView out邮件列表;
        private System.Windows.Forms.TextBox in服务器;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox in密码;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox in账号;
        private System.Windows.Forms.Label label1;
        private Utility.WindowsForm.U按钮 do接收;
        private Utility.WindowsForm.U按钮 do全部删除;
        private System.Windows.Forms.TextBox in端口号;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox in配置;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
    }
}
