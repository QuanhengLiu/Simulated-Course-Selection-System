using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class 选课须知 : Form
    {
        public 选课须知()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 获取文本框中的内容
            string inputText = textBox1.Text.Trim();

            // 定义正确的文本内容
            string correctText = "我已知晓教育部令第41号关于真实、完整地记载、出具学生学业成绩的相关规定，以及学生手册上与选课、成绩相关的所有规定，仔细阅读了学校本学期选课通知，将按要求完成选课并及时核对结果，认真修读包括本人自选及教务员、管理员代理选的所有课程，经常查看我的课表及各类相关通知，主动避免各种失误，并愿意承担相应后果。";

            // 判断文本框内容是否与预期一致
            if (inputText == correctText)
            {
                // 如果一致，关闭窗体
                this.Close();
            }
            else
            {
                // 如果不一致，弹出提示框
                MessageBox.Show("请检查输入内容");
            }
        }
    }
}
