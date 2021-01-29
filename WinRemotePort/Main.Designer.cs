namespace WinRemotePort
{
    partial class Main
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cbIsAddPortToFire = new System.Windows.Forms.CheckBox();
            this.btnSavePort = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lbTab1Info = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtNetstatInfo = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(824, 518);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbIsAddPortToFire);
            this.tabPage1.Controls.Add(this.btnSavePort);
            this.tabPage1.Controls.Add(this.txtPort);
            this.tabPage1.Controls.Add(this.lbTab1Info);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(816, 489);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "远程桌面";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "输入要修改的远程桌面端口：";
            // 
            // cbIsAddPortToFire
            // 
            this.cbIsAddPortToFire.AutoSize = true;
            this.cbIsAddPortToFire.Checked = true;
            this.cbIsAddPortToFire.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIsAddPortToFire.Location = new System.Drawing.Point(31, 152);
            this.cbIsAddPortToFire.Margin = new System.Windows.Forms.Padding(4);
            this.cbIsAddPortToFire.Name = "cbIsAddPortToFire";
            this.cbIsAddPortToFire.Size = new System.Drawing.Size(269, 19);
            this.cbIsAddPortToFire.TabIndex = 3;
            this.cbIsAddPortToFire.Text = "是否同时向防火墙添加端口入站规则";
            this.cbIsAddPortToFire.UseVisualStyleBackColor = true;
            // 
            // btnSavePort
            // 
            this.btnSavePort.Location = new System.Drawing.Point(31, 189);
            this.btnSavePort.Margin = new System.Windows.Forms.Padding(4);
            this.btnSavePort.Name = "btnSavePort";
            this.btnSavePort.Size = new System.Drawing.Size(100, 29);
            this.btnSavePort.TabIndex = 2;
            this.btnSavePort.Text = "修改端口";
            this.btnSavePort.UseVisualStyleBackColor = true;
            this.btnSavePort.Click += new System.EventHandler(this.btnSavePort_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(31, 113);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(85, 25);
            this.txtPort.TabIndex = 1;
            // 
            // lbTab1Info
            // 
            this.lbTab1Info.AutoSize = true;
            this.lbTab1Info.ForeColor = System.Drawing.Color.Red;
            this.lbTab1Info.Location = new System.Drawing.Point(28, 21);
            this.lbTab1Info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTab1Info.Name = "lbTab1Info";
            this.lbTab1Info.Size = new System.Drawing.Size(97, 15);
            this.lbTab1Info.TabIndex = 0;
            this.lbTab1Info.Text = "当前远程端口";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtNetstatInfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(816, 489);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "端口情况";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtNetstatInfo
            // 
            this.txtNetstatInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNetstatInfo.Location = new System.Drawing.Point(4, 4);
            this.txtNetstatInfo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNetstatInfo.Name = "txtNetstatInfo";
            this.txtNetstatInfo.Size = new System.Drawing.Size(808, 481);
            this.txtNetstatInfo.TabIndex = 3;
            this.txtNetstatInfo.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTextBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(816, 489);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "正在工作";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(3, 3);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(810, 483);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.richTextBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(816, 489);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "活动连接";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(810, 483);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 518);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Windows远程端口修改器";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox cbIsAddPortToFire;
        private System.Windows.Forms.Button btnSavePort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lbTab1Info;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox txtNetstatInfo;
        private System.Windows.Forms.Label label1; 
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

