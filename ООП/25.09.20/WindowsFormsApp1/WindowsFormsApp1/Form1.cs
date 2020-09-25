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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString());
            MessageBox.Show(dateTimePicker1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            monthCalendar1.AddBoldedDate(new DateTime(2020, 09, 21));
            monthCalendar1.AddBoldedDate(new DateTime(2020, 09, 22));
            monthCalendar1.AddAnnuallyBoldedDate(new DateTime(2020, 09, 9));
            monthCalendar1.AddMonthlyBoldedDate(new DateTime(2020, 09, 1));
            /*  =!= */

            monthCalendar1.TodayDate = new DateTime(2020, 09, 22);
            monthCalendar1.ShowTodayCircle = true;
            monthCalendar1.ShowToday = false;
            monthCalendar1.SelectionStart = new DateTime(2020, 09, 1);
            monthCalendar1.SelectionEnd = new DateTime(2020, 09, 11);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void vbcvbcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xvbcvbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("нажато создать");
        }
    }
}
