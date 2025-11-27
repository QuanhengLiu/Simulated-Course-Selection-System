using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test1
{
    public partial class 管理员界面 : Form
    {
        public 管理员界面()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
           switch (this.treeView1.SelectedNode.Text)
            {
              
              case"开设课程":
                 开课 f1 = new 开课();
                 f1.TopLevel = false;
                 f1.FormBorderStyle = FormBorderStyle.None;
                 f1.WindowState = FormWindowState.Maximized;
                
                 panel2.Controls.Add(f1);
                 f1.Show();
                 break;
              case"查询课程":
                 查询课程 f2 = new 查询课程();
                 f2.TopLevel = false;
                 f2.FormBorderStyle = FormBorderStyle.None;
                 f2.WindowState = FormWindowState.Maximized;
                
                 panel2.Controls.Add(f2);
                 f2.Show();
                 break;
              case"添加管理员信息":
                 添加管理员信息 f3 = new 添加管理员信息();
                 f3.TopLevel = false;
                 f3.FormBorderStyle = FormBorderStyle.None;
                 f3.WindowState = FormWindowState.Maximized;
                
                 panel2.Controls.Add(f3);
                 f3.Show();
                 break;
              case"修改管理员信息":
                 修改管理员信息 f4 = new 修改管理员信息();
                 f4.TopLevel = false;
                 f4.FormBorderStyle = FormBorderStyle.None;
                 f4.WindowState = FormWindowState.Maximized;
                
                 panel2.Controls.Add(f4);
                 f4.Show();
                 break;
              case"添加学生信息":
                 添加学生信息 f5 = new 添加学生信息();
                 f5.TopLevel = false;
                 f5.FormBorderStyle = FormBorderStyle.None;
                 f5.WindowState = FormWindowState.Maximized;
                
                 panel2.Controls.Add(f5);
                 f5.Show();
                 break;
              case"修改学生信息":
                 modifystuForm f6 = new modifystuForm();
                 f6.TopLevel = false;
                 f6.FormBorderStyle = FormBorderStyle.None;
                 f6.WindowState = FormWindowState.Maximized;
                
                 panel2.Controls.Add(f6);
                 f6.Show();
                 break;
              case "退出系统":
                 Application.Exit();
                 break;
              case "修改密码":
                 密码修改 f7 = new 密码修改();
                 f7.TopLevel = false;
                 f7.FormBorderStyle = FormBorderStyle.None;
                 f7.WindowState = FormWindowState.Maximized;
                 panel2.Controls.Add(f7);
                 f7.Show();
                 break;
             }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //loginForm login = new loginForm();
            //login.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void form_close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
