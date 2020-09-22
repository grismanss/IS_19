using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBox1.SelectedIndex -номер выбранной строки -
            //listBox1.Items.Count количество данных в списке
            //если  listBox1.SelectedIndex =-1 означает что ничего в листбокс не выбрано
            if (listBox1.SelectedIndex>=0 && listBox1.SelectedIndex < listBox1.Items.Count)
            {
                // MessageBox.Show("Номер выбранной строки " + (listBox1.SelectedIndex + 1).ToString());

                //написать чтобы сообщение ваводилось не в MessageBox а в Label

                label1.Text = "Номер выбранной строки " + (listBox1.SelectedIndex + 1).ToString();

                //вывести название дисциплины в Label2

                label2.Text = listBox1.Items[listBox1.SelectedIndex].ToString();

                //listBox1 это массив данные в котором мы можем получить по номеру
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);//дадаляем строку по номеру
            }
            else
            {
                MessageBox.Show("Обьект для удаления не выбран");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                listBox1.Items.Add(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Введите наименование дисциплины");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                textBox2.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
                textBox2.Enabled = true;
                button3.Enabled = true;

            }
            else
            {
                MessageBox.Show("Обьект для изменений не выбран");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items[listBox1.SelectedIndex] = textBox2.Text;

            //Реализовать добавление удаление и редактирование для комбо бокс. ТЕма - страны мира!
        }
    }
}
