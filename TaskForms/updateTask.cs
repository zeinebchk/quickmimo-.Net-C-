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

namespace quickmimo.TaskForms
{
    public partial class updateTask : Form
    {
        MYTask task;
        //static DBMimoContext dbContext = new DBMimoContext(); // configure la chaîne de connexion dans appsettings ou constructeur
        TaskRepository taskRepo = new TaskRepository(Program.DbContext);
        public updateTask(MYTask t)
        {
            InitializeComponent();
            task = t;
        }

        private void btnupdatestatus_Click(object sender, EventArgs e)
        {
            grpStatus.Visible = true;
        }

        private void btnfileupload_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateTask_Load(object sender, EventArgs e)
        {

            notifDate.Items.Add("avant 5 minutes");
            notifDate.Items.Add("avant 15 minutes");
            notifDate.Items.Add("avant 1 heure");
            notifDate.Items.Add("avant 1 jours");

            comboStatus.Items.Add("A faire");
            comboStatus.Items.Add("En cours");
            comboStatus.Items.Add("Terminé");

            notifDate.SelectedItem = "avant 15 minutes";

            txtTitle.Text = task.title;
            txtdescription.Text = task.description;
            comboStatus.SelectedItem = task.status.Equals("todo") ? "A faire" :
                task.status.Equals("inProgress") ? "En cours" : "Terminé";
            startDatePicker.Value = task.startdate;
            deadlineDate.Value = task.deadline;
            notifDate.SelectedItem = task.RememeberNotification == 1 ? "avant 1 heure" :
            task.RememeberNotification == 24 ? "avant 1 jour" :
            task.RememeberNotification == 5 ? "avant 5 minutes" : "avant 15 minutes";


        }

        private void totdobtn_CheckedChanged(object sender, EventArgs e)
        {
            comboStatus.SelectedItem = "A faire";
        }

        private void inProgressbtn_CheckedChanged(object sender, EventArgs e)
        {
            comboStatus.SelectedItem = "En cours";

        }

        private void donebtn_CheckedChanged(object sender, EventArgs e)
        {
            comboStatus.SelectedItem = "Terminé";

        }

        private void btnInscri_Click(object sender, EventArgs e)
        {

            DateTime startdate = startDatePicker.Value;
            DateTime deadline = deadlineDate.Value;
            if (string.IsNullOrEmpty(txtTitle.Text))
                MessageBox.Show("le titre est obligatoire");

            else if (deadline.CompareTo(startdate) < 0)
                MessageBox.Show("la date d'echecance doit etre superieur a la date de debut");
            else if (deadline.CompareTo(DateTime.Now) < 0)
                MessageBox.Show("la date d'echecance doit etre superieur a la date d'aujourd'hui'");
            else
            {
                try
                {
                    string title = txtTitle.Text;
                    string description = txtdescription.Text;
                    string status =
                       comboStatus.SelectedItem.ToString().Equals("A faire") ?
                       "todo" :
                       comboStatus.SelectedItem.ToString().Equals("En cours") ?
                       "inProgress" :
                       "done";
                    int rememberNotif = notifDate.SelectedItem.Equals("avant 5 minutes") ? 5 :
                        notifDate.SelectedItem.Equals("avant 15 minutes") ? 15 :
                        notifDate.SelectedItem.Equals("avant 1 heure") ? 1 : 24;


                    task.title = title;
                    task.description = description;
                    task.status = status;
                    task.startdate = startdate;
                    task.deadline = deadline;
                    task.RememeberNotification = rememberNotif;
                    // task.user = UserSession.connectedUser;
                    task.userId = UserSession.connectedUser.Id;

                    taskRepo.UpdateTaskStatus(task.Id, status);
                    // MessageBox.Show(task.ToString());
                    taskRepo.updateTask(task);
                    MYTask t = taskRepo.GetMYTaskById(task.Id);
                    if (t != null)
                    {
                        MessageBox.Show("tache modifiée avec succées");
                        this.Close();
                        listeTaches parentForm = new listeTaches();
                        parentForm.ReloadTasks();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lblsupprimer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Êtes-vous sûr de vouloir supprimer cet élément ?",
               "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning
);

            if (result == DialogResult.Yes)
            {
               taskRepo.Delete(task.Id);
                MessageBox.Show("Tache supprimée avec succées");
                this.Close();
                listeTaches parentForm = new listeTaches();
                parentForm.ReloadTasks();
            }
        }
    }
}
