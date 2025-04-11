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
    public partial class AddTaskForm : Form
    {
        public string panelName;// configure la chaîne de connexion dans appsettings ou constructeur
        TaskRepository taskRepo = new TaskRepository(Program.DbContext);
        public AddTaskForm(string name)
        {

            InitializeComponent();
            panelName = name;
        }

        private void AddTaskForm_Load(object sender, EventArgs e)
        {

            MessageBox.Show(panelName);
            MessageBox.Show(UserSession.connectedUser.Id.ToString());
            comboStatus.Items.Add("A faire");
            comboStatus.Items.Add("En cours");
            comboStatus.Items.Add("Terminé");
            if (panelName.Equals("todo"))
                comboStatus.SelectedItem = "A faire";
            else if (panelName.Equals("inProgress"))
                comboStatus.SelectedItem = "En cours";
            else
                comboStatus.SelectedItem = "Terminé";
            deadlineDate.Value = DateTime.Now;
            startDatePicker.Value = DateTime.Now.AddDays(-1);


            notifDate.Items.Add("avant 5 minutes");
            notifDate.Items.Add("avant 15 minutes");
            notifDate.Items.Add("avant 1 heure");
            notifDate.Items.Add("avant 1 jours");

            notifDate.SelectedItem = "avant 15 minute";







        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInscri_Click(object sender, EventArgs e)

        {
          

            DateTime startdate = startDatePicker.Value;
            DateTime deadline = deadlineDate.Value;
            if (string.IsNullOrEmpty(txtTitle.Text))
                MessageBox.Show("le titre est obligatoire");

            else if (deadline.CompareTo(startdate) < 0)
                MessageBox.Show("la date d'echecance doit etre superieur a la date de debut");
                
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


                MYTask task = new MYTask();

                task.title = title;
                task.description = description;
                task.status = status;
                task.startdate = startdate;
                task.deadline = deadline;
                task.RememeberNotification = rememberNotif;
                // task.user = UserSession.connectedUser;
                task.userId = UserSession.connectedUser.Id;

                // MessageBox.Show(task.ToString());
                taskRepo.Add(task);
                // MYTask t = taskRepo.GetMYTaskById(task.Id);
                // if (t != null)
                
                    MessageBox.Show("tache ajouté avec succées");
                    this.Close();
                        if (this.Owner is listeTaches parentForm)
                        {
                            parentForm.ReloadTasks();
                        }
                }
            
                catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
            }

        }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
