using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quickmimo.context;
using quickmimo.Entities;
using quickmimo.Repositories;
using quickmimo.TaskForms;

namespace quickmimo
{
    public partial class TaskItem : UserControl
    {
        public event EventHandler OnDetailsClick;
        User userConnected = UserSession.connectedUser;
        static DBMimoContext dbContext = new DBMimoContext(); // configure la chaîne de connexion dans appsettings ou constructeur
        TaskRepository taskRepo = new TaskRepository(dbContext);
        public string TaskName
        {
            get => lblTaskName.Text;
            set => lblTaskName.Text = value;
        }
        public string Taskid { get => lblId.Text; set => lblId.Text = value; }
        public TaskItem()
        {
            InitializeComponent();
        }

        private void TaskItem_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTaskItem_Click(object sender, EventArgs e)
        {
            MYTask t = taskRepo.GetMYTaskById(int.Parse(Taskid));
            if (t != null) {
                updateTask updateForm = new updateTask(t);
                //updateForm.Owner = this;
                updateForm.ShowDialog();
                //update fenetre lo5ra

            }
            //OnDetailsClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
