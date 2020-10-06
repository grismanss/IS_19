using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = Convert.ToInt32(numericUpDown1.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount= Convert.ToInt32(numericUpDown2.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 1;
            dataGridView1.RowCount = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int n = Convert.ToInt32(numericUpDown1.Value);//сстроки
            int m = Convert.ToInt32(numericUpDown2.Value);//столбцы
            for (int i=0; i<n; i++)
            {
                for (int j=0; j<m; j++)
                {
                    int k = r.Next(-50, 50);
                    dataGridView1[j, i].Value = k.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(numericUpDown1.Value);//сстроки
            int m = Convert.ToInt32(numericUpDown2.Value);//столбцы
            int[,] A = new int[n, m];
            int[] B = new int[n * m];
            int k = 0;//счетик для B
            //Получение данных из DAtaGRId
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = Convert.ToInt32(dataGridView1[j, i].Value);
                }
            }

            //сам алгоритм по задаче
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (A[i, j] < 0)
                    {
                        B[k] = A[i, j];
                        k++;
                    }
                }
            }


            //Выыод массива B
            dataGridView2.RowCount = 1;
            dataGridView2.ColumnCount = k;
            for (int i = 0; i < k; i++)
            {
                dataGridView2[i, 0].Value = B[i].ToString();

            }
        }
    }
}
