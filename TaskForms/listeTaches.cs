using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quickmimo.context;
using quickmimo.Entities;
using quickmimo.Repositories;
using quickmimo.TaskForms;
using quickmimo.Calendrier;
using Calendar = quickmimo.Calendrier.Calendar;

namespace quickmimo
{
    public partial class listeTaches : Form
    {
        User userConnected = UserSession.connectedUser;
        //static DBMimoContext dbContext = new DBMimoContext(); // configure la chaîne de connexion dans appsettings ou constructeur
        TaskRepository taskRepo = new TaskRepository(Program.DbContext);
        public listeTaches()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void listeTaches_Load(object sender, EventArgs e)
        {
            //List<MYTask> todoTasks = new List<MYTask>();
            //todoTasks = taskRepo.getTodoTasks(userConnected.Id);
            //List<MYTask> inProgressTasks = new List<MYTask>();
            //inProgressTasks = taskRepo.getInProgressTasks(userConnected.Id);
            //List<MYTask> doneTasks = new List<MYTask>();
            //doneTasks = taskRepo.getDoneTasks(userConnected.Id);

            //foreach (MYTask task in todoTasks)
            //{
            //    TaskItem taskItem = new TaskItem();
            //    taskItem.TaskName = task.title;
            //    taskItem.Taskid=task.Id.ToString();
            //    todoPanel.Controls.Add(taskItem);
            //}
            //foreach (MYTask task in inProgressTasks)
            //{
            //    TaskItem taskItem = new TaskItem();
            //    taskItem.TaskName = task.title;
            //    taskItem.Taskid = task.Id.ToString();
            //    inProgressPanel.Controls.Add(taskItem);
            //}
            //foreach (MYTask task in doneTasks)
            //{
            //    TaskItem taskItem = new TaskItem();
            //    taskItem.TaskName = task.title;
            //    taskItem.Taskid = task.Id.ToString();
            //    donePanel.Controls.Add(taskItem);
            //}
            ReloadTasks();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btntodo_Click(object sender, EventArgs e)
        {
            AddTaskForm addtaskForm = new AddTaskForm("todo");
            addtaskForm.Owner = this;
            addtaskForm.ShowDialog();

        }

        private void btnInProgress_Click(object sender, EventArgs e)
        {
            AddTaskForm addtaskForm = new AddTaskForm("inProgress");
            addtaskForm.Owner = this;
            addtaskForm.ShowDialog();
        }

        private void btntermine_Click(object sender, EventArgs e)
        {
            AddTaskForm addtaskForm = new AddTaskForm("done ");
            addtaskForm.Owner = this;
            addtaskForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            login deconnexion = new login();
            deconnexion.Show();
            UserSession.connectedUser = null;
            this.Hide();
        }
        public void ReloadTasks()
        {
            todoPanel.Controls.Clear();
            inProgressPanel.Controls.Clear();
            donePanel.Controls.Clear();

            List<MYTask> todoTasks = taskRepo.getTodoTasks(userConnected.Id);
            List<MYTask> inProgressTasks = taskRepo.getInProgressTasks(userConnected.Id);
            List<MYTask> doneTasks = taskRepo.getDoneTasks(userConnected.Id);

            foreach (MYTask task in todoTasks)
            {
                TaskItem taskItem = new TaskItem();
                taskItem.TaskName = task.title;
                taskItem.Taskid = task.Id.ToString();
                todoPanel.Controls.Add(taskItem);
            }
            foreach (MYTask task in inProgressTasks)
            {
                TaskItem taskItem = new TaskItem();
                taskItem.TaskName = task.title;
                taskItem.Taskid = task.Id.ToString();
                inProgressPanel.Controls.Add(taskItem);
            }
            foreach (MYTask task in doneTasks)
            {
                TaskItem taskItem = new TaskItem();
                taskItem.TaskName = task.title;
                taskItem.Taskid = task.Id.ToString();
                donePanel.Controls.Add(taskItem);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Calendar calendarForm = new Calendar();
            calendarForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listeTaches taskList = new listeTaches();
            taskList.Show();
            this.Close();
        }
    }
}
