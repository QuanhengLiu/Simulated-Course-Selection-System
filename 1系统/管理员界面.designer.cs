namespace test1
{
    partial class 管理员界面
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("添加管理员信息");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("修改管理员信息");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("信息管理", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("开设课程");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("查询课程");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("课程管理", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("添加学生信息");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("修改学生信息");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("学生管理", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("修改密码");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("退出系统");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(管理员界面));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.LineColor = System.Drawing.Color.LightGray;
            this.treeView1.Location = new System.Drawing.Point(6, 20);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "addMan";
            treeNode1.Text = "添加管理员信息";
            treeNode2.Name = "modifyMan";
            treeNode2.Text = "修改管理员信息";
            treeNode3.Name = "manMan";
            treeNode3.Text = "信息管理";
            treeNode4.Name = "addCL";
            treeNode4.Text = "开设课程";
            treeNode5.Name = "searchCL";
            treeNode5.Text = "查询课程";
            treeNode6.Name = "classMan";
            treeNode6.Text = "课程管理";
            treeNode7.Name = "addStu";
            treeNode7.Text = "添加学生信息";
            treeNode8.Name = "modifyStu";
            treeNode8.Text = "修改学生信息";
            treeNode9.Name = "studentMan";
            treeNode9.Text = "学生管理";
            treeNode10.Name = "节点0";
            treeNode10.Text = "修改密码";
            treeNode11.Name = "节点0";
            treeNode11.Text = "退出系统";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9,
            treeNode10,
            treeNode11});
            this.treeView1.Size = new System.Drawing.Size(1722, 906);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(270, 56);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1260, 776);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // 管理员界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2564, 1144);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "管理员界面";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1.tongji.edu.cn（教务版）";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_close);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel2;
    }
}

