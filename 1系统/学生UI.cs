using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sunny.UI;
using System.Data.SqlClient;

namespace test1
{
    public partial class 学生UI : UIForm
    {
        int stuid = 0;
        public 学生UI()
        {
            InitializeComponent();
        }

        private void 学生UI_Load(object sender, EventArgs e)
        {
            //首先得到用户的id
            string stuxuehao = 登陆.getStudent();
            SqlConnection conn = new SqlConnection(登陆.connectionString);
            conn.Open();
            string sql = "select stuid from student where stuxuehao = '" + stuxuehao + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            String id1 = cmd.ExecuteScalar().ToString();
            int stuid = 0;
            int.TryParse(id1, out stuid);
            //用到两个数据库的连接操作

            sql = "select class.claid as 课程id,class.claname as 课程名称,class.teacher as 教师姓名,class.term as 学期," +
                "sctime.sctime as 上课时间,sctime.location as 上课地点 from sc,sctime,class where class.claid=sc.claid and sc.claid=sctime.claid and sc.stuid=" + stuid;
            SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp1.Fill(ds);
            //载入基本信息
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
            textBox4.Text = 登陆.getStudent();
            textBox5.Text = 登陆.getStudent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            while (dataGridView3.Rows.Count != 0)
            {
                dataGridView3.DataSource = null;
            }
            if (comboBoxterm.Text == "" && textBoxclass.Text == "")
            {
                MessageBox.Show("请输入查询信息！");
            }
            else if (comboBoxterm.Text != "" && textBoxclass.Text == "")
            {
                SqlConnection conn = new SqlConnection(登陆.connectionString);
                conn.Open();
                string sql = "select claid as 课程id,claname as 课程名,term as 学期,teacher as 老师 from class where term = '" + comboBoxterm.SelectedItem.ToString() + "'";
                SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adp1.Fill(ds);
                //载入基本信息
                dataGridView3.DataSource = ds.Tables[0].DefaultView;
                conn.Close();
            }
            else if (textBoxclass.Text != "" && comboBoxterm.Text == "")
            {

                SqlConnection conn = new SqlConnection(登陆.connectionString);
                conn.Open();
                //textBox1.Text.Trim()  textBox2.Text.Trim()
                string sql = "select claid as 课程id,claname as 课程名,term as 学期,teacher as 老师 from class  where claname = '" + textBoxclass.Text + "'";
                SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adp1.Fill(ds);
                //载入基本信息
                dataGridView3.DataSource = ds.Tables[0].DefaultView;
                conn.Close();


            }
            else if (textBoxclass.Text != "" && comboBoxterm.Text != "")
            {

                SqlConnection conn = new SqlConnection(登陆.connectionString);
                conn.Open();
                //textBox1.Text.Trim()  textBox2.Text.Trim()
                string sql = "select claid as 课程id,claname as 课程名,term as 学期,teacher as 老师 from class  where claname = '" + textBoxclass.Text + "'and term ='" + comboBoxterm.SelectedItem.ToString() + "'";
                SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adp1.Fill(ds);
                //载入基本信息
                dataGridView3.DataSource = ds.Tables[0].DefaultView;
                conn.Close();
            }
        }
        private void dataGridView3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView3.SelectedCells.Count != 0)
            {
                string claid = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
                SqlConnection conn = new SqlConnection(登陆.connectionString);
                conn.Open();
                string sql = "select sctime as 上课时间,location as 上课地点 from sctime where claid=" + claid;
                SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adp1.Fill(ds);
                //载入基本信息
                dataGridView2.DataSource = ds.Tables[0].DefaultView;
                conn.Close();
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string passwd = textBox2.Text;
            string quepasswd = textBox3.Text;
            SqlConnection conn = new SqlConnection(登陆.connectionString);
            conn.Open();
            if (passwd == "" || quepasswd == "")
            {
                MessageBox.Show("请将信息填写完整!");
            }
            else
            {
                if (quepasswd != passwd)
                {
                    MessageBox.Show("两次输入的密码不一致!");
                }
                else
                {
                    
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        string sql = "update student set stupasswd ='" + passwd + "' where stuxuehao = '" + textBox4.Text + "'";
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("修改密码成功！");

                    


                }
                conn.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string flags = "1";
            //得到stuid
            string stuxuehao = textBox5.Text;
            SqlConnection conn = new SqlConnection(登陆.connectionString);
            conn.Open();
            string sql = "select stuid from student where stuxuehao = '" + stuxuehao + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            String id1 = cmd.ExecuteScalar().ToString();

            int.TryParse(id1, out stuid);
            //得到课程的id
            int claid = 0;
            int.TryParse(textBoxid.Text, out claid);
            //查询你在该时间是否有课
            sql = "select sctime from sctime where claid =" + claid;
            SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow dr = ds.Tables[0].Rows[i];
                string time = dr[0].ToString();//第一列
                sql = "select * from sc,sctime,class where class.claid = sc.claid and class.claid = sctime.claid and sctime = '" + time + "' and sc.stuid =" + stuid;
                SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
                DataSet ds1 = new DataSet();
                adp1.Fill(ds1);
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    flags = "2";
                    MessageBox.Show("课程上课时间冲突！");
                    break;
                }
            }
            if (flags == "1")
            {
                sql = "insert into sc(claid,stuid) values(" + claid + "," + stuid + ")";
                cmd.CommandText = sql;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("选课成功！");

                }

            }
            if (listBox1.Items.Count > 0)
            {//清空所有项
                listBox1.Items.Clear();
            }
            sql = "select class.claname  from sc,class where sc.claid = class.claid and stuid=" + stuid;
            SqlDataAdapter adp2 = new SqlDataAdapter(sql, conn);
            DataSet ds2 = new DataSet();
            adp2.Fill(ds2);
            foreach (DataRow row in ds2.Tables[0].Rows)
            {
                listBox1.Items.Add(row[0].ToString());
            }
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (dataGridView4.Rows.Count != 0)
            {
                dataGridView4.DataSource = null;
            }
            string term = comboBox1.SelectedItem.ToString();
            Console.WriteLine(term);
            SqlConnection conn = new SqlConnection(登陆.connectionString);
            conn.Open();
            string sql = "select claid as 课程id,claname as 课程 from class where term='" + term + "'";
            SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp1.Fill(ds);
            //载入基本信息
            dataGridView4.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }
        private void mos_click(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxid.Text = dataGridView4.SelectedRows[0].Cells[0].Value.ToString();
            textBox1.Text = dataGridView4.SelectedRows[0].Cells[1].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string claname = listBox1.SelectedItem.ToString();
            SqlConnection conn = new SqlConnection(登陆.connectionString);
            conn.Open();
            string sql = "select claid from class where claname = '" + claname + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            String id1 = cmd.ExecuteScalar().ToString();
            int claid = 0;
            int.TryParse(id1, out claid);
            sql = "delete from  sc  where  claid = " + claid + " and stuid = " + stuid;
            cmd.CommandText = sql;
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("删除成功！");
                if (listBox1.Items.Count > 0)
                {//清空所有项
                    listBox1.Items.Clear();
                }
                sql = "select class.claname  from sc,class where sc.claid = class.claid and stuid=" + stuid;
                SqlDataAdapter adp2 = new SqlDataAdapter(sql, conn);
                DataSet ds2 = new DataSet();
                adp2.Fill(ds2);
                foreach (DataRow row in ds2.Tables[0].Rows)
                {
                    listBox1.Items.Add(row[0].ToString());
                }

            }

            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // 定义一个布尔标志，标记是否是第一次选择标签
        private bool isFirstSelection = true;

        private void uiTabControlMenu1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 只在第一次选择标签时执行
            if (isFirstSelection)
            {
                选课须知 mainframe = new 选课须知();
                mainframe.BringToFront();
                mainframe.Show();

                // 设置标志为 false，表示不再执行这个操作
                isFirstSelection = false;
            }
        }

        private void uiTabControlMenu1_Selected(object sender, TabControlEventArgs e)
        {

        }
    }
}
