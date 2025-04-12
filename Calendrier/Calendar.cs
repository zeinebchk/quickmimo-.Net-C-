using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quickmimo.Entities;
using quickmimo.Repositories;

namespace quickmimo.Calendrier
{
    public partial class Calendar : Form
    {
        public static int _year, _month;

        public Calendar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            showDays(DateTime.Now.Month, DateTime.Now.Year);

        }
        private void showDays(int month, int year)
        {
            flowLayoutPanel1.Controls.Clear();
            _year = year;
            _month = month;
            string monthName = new System.Globalization.DateTimeFormatInfo().GetMonthName(month);
            lblmonth.Text = monthName;
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int day = DateTime.DaysInMonth(year, month);
            int week = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < week; i++)
            {
                ucDays uc = new ucDays("");
                flowLayoutPanel1.Controls.Add(uc);

            }
            for (int i = 1; i < day; i++)
            {
                ucDays uc = new ucDays(i + "");
                flowLayoutPanel1.Controls.Add(uc);
            }


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            _month -= 1;
            if (_month < 1)
            {
                _month = 12;
                _year -= 1;
            }
            showDays(_month, _year);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            _month += 1;
            if (_month > 12)
            {
                _month = 1;
                _year += 1;
            }
            showDays(_month, _year);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listeTaches taskList = new listeTaches();
            taskList.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.Show();
            this.Close();
        }
    }
}
