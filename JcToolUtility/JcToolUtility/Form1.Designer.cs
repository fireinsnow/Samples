namespace JcToolUtility
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShuTochuan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIpchuan = new System.Windows.Forms.TextBox();
            this.btnChuanToshuzi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIpShuzi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtShuzi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShuTochuan
            // 
            this.btnShuTochuan.Location = new System.Drawing.Point(21, 149);
            this.btnShuTochuan.Name = "btnShuTochuan";
            this.btnShuTochuan.Size = new System.Drawing.Size(75, 23);
            this.btnShuTochuan.TabIndex = 0;
            this.btnShuTochuan.Text = "数字转串";
            this.btnShuTochuan.UseVisualStyleBackColor = true;
            this.btnShuTochuan.Click += new System.EventHandler(this.btnShuTochuan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "ip串";
            // 
            // txtIpchuan
            // 
            this.txtIpchuan.Location = new System.Drawing.Point(49, 43);
            this.txtIpchuan.Name = "txtIpchuan";
            this.txtIpchuan.Size = new System.Drawing.Size(128, 21);
            this.txtIpchuan.TabIndex = 2;
            // 
            // btnChuanToshuzi
            // 
            this.btnChuanToshuzi.Location = new System.Drawing.Point(102, 149);
            this.btnChuanToshuzi.Name = "btnChuanToshuzi";
            this.btnChuanToshuzi.Size = new System.Drawing.Size(75, 23);
            this.btnChuanToshuzi.TabIndex = 3;
            this.btnChuanToshuzi.Text = "串转数子";
            this.btnChuanToshuzi.UseVisualStyleBackColor = true;
            this.btnChuanToshuzi.Click += new System.EventHandler(this.btnChuanToshuzi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "ip数字";
            // 
            // txtIpShuzi
            // 
            this.txtIpShuzi.Location = new System.Drawing.Point(49, 83);
            this.txtIpShuzi.Name = "txtIpShuzi";
            this.txtIpShuzi.Size = new System.Drawing.Size(128, 21);
            this.txtIpShuzi.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIpShuzi);
            this.groupBox1.Controls.Add(this.btnShuTochuan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIpchuan);
            this.groupBox1.Controls.Add(this.btnChuanToshuzi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 219);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ip相关";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.txtShuzi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(229, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 215);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "时间相关";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "时间";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "数字转时间";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(103, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "时间转数子";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(42, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 21);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // txtShuzi
            // 
            this.txtShuzi.Location = new System.Drawing.Point(43, 39);
            this.txtShuzi.Name = "txtShuzi";
            this.txtShuzi.Size = new System.Drawing.Size(157, 21);
            this.txtShuzi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "数字值";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShuTochuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIpchuan;
        private System.Windows.Forms.Button btnChuanToshuzi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIpShuzi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtShuzi;
        private System.Windows.Forms.Label label3;
    }
}

