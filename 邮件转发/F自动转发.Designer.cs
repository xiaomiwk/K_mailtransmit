namespace 内外网邮件转发
{
    partial class F自动转发
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.out外网转内网 = new System.Windows.Forms.Label();
            this.out关联列表 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.out外网接收 = new System.Windows.Forms.Label();
            this.out内网发送 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.out内网接收 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.out外网发送 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.out内网转外网 = new System.Windows.Forms.Label();
            this.out外网转内网失败数 = new System.Windows.Forms.Label();
            this.out内网转外网失败数 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.in转发记录 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.out关联列表)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(32, 221);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "邮箱关联";
            // 
            // out外网转内网
            // 
            this.out外网转内网.AutoSize = true;
            this.out外网转内网.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.out外网转内网.ForeColor = System.Drawing.Color.DimGray;
            this.out外网转内网.Location = new System.Drawing.Point(32, 28);
            this.out外网转内网.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.out外网转内网.Name = "out外网转内网";
            this.out外网转内网.Size = new System.Drawing.Size(68, 17);
            this.out外网转内网.TabIndex = 27;
            this.out外网转内网.Text = "外网转内网";
            // 
            // out关联列表
            // 
            this.out关联列表.AllowUserToAddRows = false;
            this.out关联列表.AllowUserToDeleteRows = false;
            this.out关联列表.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.out关联列表.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.out关联列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.out关联列表.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.out关联列表.Location = new System.Drawing.Point(36, 257);
            this.out关联列表.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.out关联列表.Name = "out关联列表";
            this.out关联列表.ReadOnly = true;
            this.out关联列表.RowTemplate.Height = 23;
            this.out关联列表.Size = new System.Drawing.Size(671, 433);
            this.out关联列表.TabIndex = 26;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "姓名";
            this.Column4.HeaderText = "姓名";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "外网账号";
            this.Column1.HeaderText = "外网账号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "外网密码";
            this.Column2.HeaderText = "外网密码";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "内网账号";
            this.Column3.HeaderText = "内网账号";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label4.Location = new System.Drawing.Point(32, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(675, 1);
            this.label4.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label5.Location = new System.Drawing.Point(33, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(675, 1);
            this.label5.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(37, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 19);
            this.label7.TabIndex = 36;
            this.label7.Text = "接收:";
            // 
            // out外网接收
            // 
            this.out外网接收.AutoSize = true;
            this.out外网接收.Location = new System.Drawing.Point(83, 62);
            this.out外网接收.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.out外网接收.Name = "out外网接收";
            this.out外网接收.Size = new System.Drawing.Size(49, 19);
            this.out外网接收.TabIndex = 37;
            this.out外网接收.Text = "XXXXX";
            // 
            // out内网发送
            // 
            this.out内网发送.AutoSize = true;
            this.out内网发送.Location = new System.Drawing.Point(397, 62);
            this.out内网发送.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.out内网发送.Name = "out内网发送";
            this.out内网发送.Size = new System.Drawing.Size(49, 19);
            this.out内网发送.TabIndex = 39;
            this.out内网发送.Text = "XXXXX";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(351, 62);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 19);
            this.label10.TabIndex = 38;
            this.label10.Text = "发送:";
            // 
            // out内网接收
            // 
            this.out内网接收.AutoSize = true;
            this.out内网接收.Location = new System.Drawing.Point(83, 163);
            this.out内网接收.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.out内网接收.Name = "out内网接收";
            this.out内网接收.Size = new System.Drawing.Size(49, 19);
            this.out内网接收.TabIndex = 43;
            this.out内网接收.Text = "XXXXX";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(37, 163);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 19);
            this.label9.TabIndex = 42;
            this.label9.Text = "接收:";
            // 
            // out外网发送
            // 
            this.out外网发送.AutoSize = true;
            this.out外网发送.Location = new System.Drawing.Point(397, 163);
            this.out外网发送.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.out外网发送.Name = "out外网发送";
            this.out外网发送.Size = new System.Drawing.Size(49, 19);
            this.out外网发送.TabIndex = 41;
            this.out外网发送.Text = "XXXXX";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(351, 163);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 19);
            this.label12.TabIndex = 40;
            this.label12.Text = "发送:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.Location = new System.Drawing.Point(32, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(675, 1);
            this.label2.TabIndex = 45;
            // 
            // out内网转外网
            // 
            this.out内网转外网.AutoSize = true;
            this.out内网转外网.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.out内网转外网.ForeColor = System.Drawing.Color.DimGray;
            this.out内网转外网.Location = new System.Drawing.Point(32, 130);
            this.out内网转外网.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.out内网转外网.Name = "out内网转外网";
            this.out内网转外网.Size = new System.Drawing.Size(68, 17);
            this.out内网转外网.TabIndex = 44;
            this.out内网转外网.Text = "内网转外网";
            // 
            // out外网转内网失败数
            // 
            this.out外网转内网失败数.AutoSize = true;
            this.out外网转内网失败数.BackColor = System.Drawing.Color.Red;
            this.out外网转内网失败数.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.out外网转内网失败数.ForeColor = System.Drawing.Color.White;
            this.out外网转内网失败数.Location = new System.Drawing.Point(108, 28);
            this.out外网转内网失败数.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.out外网转内网失败数.Name = "out外网转内网失败数";
            this.out外网转内网失败数.Size = new System.Drawing.Size(41, 19);
            this.out外网转内网失败数.TabIndex = 46;
            this.out外网转内网失败数.Text = "XXXX";
            this.out外网转内网失败数.Visible = false;
            // 
            // out内网转外网失败数
            // 
            this.out内网转外网失败数.AutoSize = true;
            this.out内网转外网失败数.BackColor = System.Drawing.Color.Red;
            this.out内网转外网失败数.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.out内网转外网失败数.ForeColor = System.Drawing.Color.White;
            this.out内网转外网失败数.Location = new System.Drawing.Point(108, 130);
            this.out内网转外网失败数.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.out内网转外网失败数.Name = "out内网转外网失败数";
            this.out内网转外网失败数.Size = new System.Drawing.Size(41, 19);
            this.out内网转外网失败数.TabIndex = 47;
            this.out内网转外网失败数.Text = "XXXX";
            this.out内网转外网失败数.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.in转发记录);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(737, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.groupBox1.Size = new System.Drawing.Size(402, 662);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "转发记录";
            // 
            // in转发记录
            // 
            this.in转发记录.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.in转发记录.Dock = System.Windows.Forms.DockStyle.Fill;
            this.in转发记录.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.in转发记录.ForeColor = System.Drawing.Color.DimGray;
            this.in转发记录.Location = new System.Drawing.Point(10, 36);
            this.in转发记录.Multiline = true;
            this.in转发记录.Name = "in转发记录";
            this.in转发记录.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.in转发记录.Size = new System.Drawing.Size(382, 616);
            this.in转发记录.TabIndex = 0;
            // 
            // F自动转发
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.out内网转外网失败数);
            this.Controls.Add(this.out外网转内网失败数);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.out内网转外网);
            this.Controls.Add(this.out内网接收);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.out外网发送);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.out内网发送);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.out外网接收);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.out外网转内网);
            this.Controls.Add(this.out关联列表);
            this.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "F自动转发";
            this.Size = new System.Drawing.Size(1154, 716);
            ((System.ComponentModel.ISupportInitialize)(this.out关联列表)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label out外网转内网;
        private System.Windows.Forms.DataGridView out关联列表;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label out外网接收;
        private System.Windows.Forms.Label out内网发送;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label out内网接收;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label out外网发送;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label out内网转外网;
        private System.Windows.Forms.Label out外网转内网失败数;
        private System.Windows.Forms.Label out内网转外网失败数;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox in转发记录;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
