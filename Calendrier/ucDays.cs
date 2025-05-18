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
    public partial class ucDays : UserControl

    {
        TaskRepository taskRepo = new TaskRepository(Program.DbContext);
        string _day, weekday, date;
        public ucDays(string day)
        {
            InitializeComponent();
            _day = day;
            label1.Text = _day;
            checkBox1.Hide();
            //MessageBox.Show(_day);
            //panel1.BackColor = Color.Red;
            date = Calendar._month + "/" + _day + "/" + Calendar._year;
            if (_day != null && _day != "")
            {
                string date2 = $"{Calendar._year}-{Calendar._month:D2}-{_day.PadLeft(2, '0')}"; // Format ISO
                DateTime datetoCompare = DateTime.Parse(date2);
                DateOnly dateonly = DateOnly.FromDateTime(datetoCompare);
                List<MYTask> tasks = new List<MYTask>();
                tasks = DaysOfEvent();
                foreach (var task in tasks)
                {
                    if (DateOnly.FromDateTime(task.deadline).CompareTo(dateonly) == 0)
                    {
                        panel1.BackColor = Color.Red;
                        lblTaskTitle.Text = task.title;
                    }
                }
            }


        }

        private void ucDay_load(object sender, EventArgs e)
        {
            sundays();
        }
        private void sundays()
        {
            try
            {
                DateTime day = DateTime.Parse(date);
                weekday = day.ToString("ddd");
                if (weekday.Equals("Sun"))
                {
                    label1.ForeColor = Color.FromArgb(255, 128, 128);
                }
                else
                {
                    label1.ForeColor = Color.FromArgb(64, 64, 64);
                }

            }
            catch (Exception ex)
            {

            }
        }


        private void panel1_click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                checkBox1.Checked = true;
                this.BackColor = Color.FromArgb(255, 150, 79);
            }
            else
            {
                checkBox1.Checked = false;
                this.BackColor = Color.White;
            }
        }
        public List<MYTask> DaysOfEvent()
        {
            List<MYTask> tasks = new List<MYTask>();
            tasks = taskRepo.GetAllTasksByUser(UserSession.connectedUser.Id);
            return tasks;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
