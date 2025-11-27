namespace test1
{
    partial class 登陆
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(登陆));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxrole = new System.Windows.Forms.ComboBox();
            this.textBoxpasswd = new System.Windows.Forms.TextBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1368, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 32);
            this.button2.TabIndex = 17;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(900, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 39);
            this.button1.TabIndex = 16;
            this.button1.Text = "登  录";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxrole
            // 
            this.comboBoxrole.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.comboBoxrole.FormattingEnabled = true;
            this.comboBoxrole.Items.AddRange(new object[] {
            "管理员",
            "学生"});
            this.comboBoxrole.Location = new System.Drawing.Point(620, 12);
            this.comboBoxrole.Name = "comboBoxrole";
            this.comboBoxrole.Size = new System.Drawing.Size(225, 43);
            this.comboBoxrole.TabIndex = 15;
            // 
            // textBoxpasswd
            // 
            this.textBoxpasswd.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.textBoxpasswd.Location = new System.Drawing.Point(900, 278);
            this.textBoxpasswd.Name = "textBoxpasswd";
            this.textBoxpasswd.PasswordChar = '*';
            this.textBoxpasswd.Size = new System.Drawing.Size(285, 47);
            this.textBoxpasswd.TabIndex = 14;
            // 
            // textBoxname
            // 
            this.textBoxname.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.textBoxname.Location = new System.Drawing.Point(900, 225);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(285, 47);
            this.textBoxname.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.label4.Location = new System.Drawing.Point(490, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "身  份";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.label3.Location = new System.Drawing.Point(822, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 35);
            this.label3.TabIndex = 11;
            this.label3.Text = "密  码";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.label2.Location = new System.Drawing.Point(822, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "用户名";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // 登陆
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1492, 808);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxrole);
            this.Controls.Add(this.textBoxpasswd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "登陆";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1.tongji.edu.cn";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxrole;
        private System.Windows.Forms.TextBox textBoxpasswd;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;

    }
}