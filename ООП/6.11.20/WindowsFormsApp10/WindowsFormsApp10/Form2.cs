using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                int k = 0;
                try
                {
                    if (textBox1.Text.Trim() == ""){
                        textBox1.Focus();
                        throw new Exception("Числитель не заполнен!");
                       
                    }
                    if (textBox2.Text.Trim() == "")
                    {
                        textBox2.Focus();
                        throw new Exception("Знаменатель не заполнен!");

                    }

                    int a = Convert.ToInt32(textBox1.Text);
                    k++;
                    int b = Convert.ToInt32(textBox2.Text);

                }
                catch (FormatException)
                {
                    e.Cancel = true;
                    if (k == 0)
                    {
                        MessageBox.Show("Числитель должен быть числом!");
                        textBox1.Focus();
                    }
                    else {
                        MessageBox.Show("Знаменатель должен быть числом!");
                        textBox2.Focus();
                    }
                }
                catch(Exception E)
                {
                    e.Cancel = true;
                    MessageBox.Show(E.Message);
                }
            }
        }
    }
}
