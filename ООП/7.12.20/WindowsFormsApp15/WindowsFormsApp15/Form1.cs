using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public static string connect_str = "Data Source=DESKTOP-5432H8R\\SQLEXPRESS;Initial Catalog=People;Integrated Security=True";
        public SqlConnection connect = new SqlConnection(connect_str);

        public Form1()
        {
            InitializeComponent();
        }


        public void load()
        {

            dataGridView1.RowCount = 1;


            connect.Open();

            string sr = "select t1.id,t1.Last_name,t1.First_name,t1.First_name2,t1.Data," +
                " t1.Email,t1.Phone, t1.Adress, t2.Naimenovanie as Pol, t3.Naimenovanie as [Nosology]," +
                " t4.Naimenovanie as Kategory from[dbo].[People] t1" +
                " inner join[dbo].[Pol] t2 on t1.Pol = t2.id" +
                " inner join[dbo].[Nosology] t3 on t1.Nosology=t3.id " +
                "inner join[dbo].[Kategory] t4 on t1.Kategory=t4.id";

            SqlCommand comm = new SqlCommand(sr, connect);
            SqlDataReader read = comm.ExecuteReader();

            while (read.Read())
            {
                string[] mas = new string[11];
                mas[0] = read.GetValue(0).ToString();
                mas[1] = read.GetValue(1).ToString();
                mas[2] = read.GetValue(2).ToString();
                mas[3] = read.GetValue(3).ToString();
                mas[4] = read.GetValue(4).ToString();
                mas[5] = read.GetValue(5).ToString();
                mas[6] = read.GetValue(6).ToString();
                mas[7] = read.GetValue(7).ToString();
                mas[8] = read.GetValue(8).ToString();
                mas[9] = read.GetValue(9).ToString();
                mas[10] = read.GetValue(10).ToString();
                dataGridView1.Rows.Add(mas);

            }
            connect.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult rez = MessageBox.Show("Точно удалить запись?", "", MessageBoxButtons.OKCancel);
            if (rez == DialogResult.OK)
            {
                int k = dataGridView1.CurrentCell.RowIndex;

                if (dataGridView1[0, k].Value != null)
                {
                    string str_del = "delete from [dbo].[People] where [id]="
                       + dataGridView1[0, k].Value.ToString();
                    connect.Open();
                    SqlCommand com = new SqlCommand(str_del, connect);
                    com.ExecuteNonQuery();
                    connect.Close();
                    load();
                }
            }
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }

        private void button3_Click(object sender, EventArgs e)
        {  Form2 f = new Form2();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "peopleDataSet2.Nosology". При необходимости она может быть перемещена или удалена.
            f.nosologyTableAdapter.Fill(f.peopleDataSet2.Nosology);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "peopleDataSet1.Kategory". При необходимости она может быть перемещена или удалена.
            f.kategoryTableAdapter.Fill(f.peopleDataSet1.Kategory);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "peopleDataSet.Pol". При необходимости она может быть перемещена или удалена.
            f.polTableAdapter.Fill(f.peopleDataSet.Pol);
            if (f.ShowDialog() == DialogResult.OK)
            {

               

                string s = "insert into [dbo].[People] ([Last_name],[First_name]," +
                    "[First_name2],[Phone],[Email],[Pol],[Data],[Kategory]," +
                    "[Nosology],[Adress]) " +
                    "values('"+f.textBox1.Text+"', '"+f.textBox2.Text
                    +"', '"+f.textBox3.Text+"', '"+f.maskedTextBox1.Text
                    +"', '"+f.textBox4.Text+"', "+
                    f.comboBox1.SelectedValue+", '"+f.dateTimePicker1.Value
                    +"', "+f.comboBox2.SelectedValue+", "+f.comboBox3.SelectedValue
                    +", '"+f.textBox5.Text+"')";
                connect.Open();
   
                SqlCommand com = new SqlCommand(s, connect);
                com.ExecuteNonQuery();
                connect.Close();
                load();

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            int k = dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1[1, k].Value != null)
            {
                f.textBox1.Text = dataGridView1[1, k].Value.ToString();
                f.textBox2.Text = dataGridView1[2, k].Value.ToString();
                f.textBox3.Text = dataGridView1[3, k].Value.ToString();
                f.maskedTextBox1.Text = dataGridView1[6, k].Value.ToString();
                f.textBox4.Text = dataGridView1[5, k].Value.ToString();
                f.dateTimePicker1.Value = Convert.ToDateTime(dataGridView1[4, k].Value);
                f.textBox5.Text = dataGridView1[7, k].Value.ToString();

                f.nosologyTableAdapter.Fill(f.peopleDataSet2.Nosology);
                f.kategoryTableAdapter.Fill(f.peopleDataSet1.Kategory);
                f.polTableAdapter.Fill(f.peopleDataSet.Pol);

                f.comboBox1.Text = dataGridView1[8, k].Value.ToString();
                f.comboBox2.Text = dataGridView1[10, k].Value.ToString();
                f.comboBox3.Text = dataGridView1[9, k].Value.ToString();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    string s = "update [dbo].[People] set [Last_name]='" + f.textBox1.Text
                        + "', [First_name]='" + f.textBox2.Text
                        + "', [First_name2]='" + f.textBox3.Text + "'," +
                        "[Phone]='" + f.maskedTextBox1.Text
                        + "',[Email]='" + f.textBox4.Text + "',[Pol]=" +
                        f.comboBox1.SelectedValue + ",[Data]='" + f.dateTimePicker1.Value
                        + "',[Kategory]=" + f.comboBox2.SelectedValue + ",[Nosology]=" +
                         f.comboBox3.SelectedValue + ",[Adress]='" + f.textBox5.Text + "' where[id] = "
                         + dataGridView1[0, k].Value.ToString();

                    connect.Open();
                    SqlCommand com = new SqlCommand(s, connect);
                    com.ExecuteNonQuery();
                    connect.Close();
                    load();
                }
            }
        }
    }

    
}
