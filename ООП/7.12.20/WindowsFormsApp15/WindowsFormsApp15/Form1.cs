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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 1;
           
            string connect_str = "Data Source=DESKTOP-5432H8R\\SQLEXPRESS;Initial Catalog=People;Integrated Security=True";
            SqlConnection connect = new SqlConnection(connect_str);
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
    }
}
