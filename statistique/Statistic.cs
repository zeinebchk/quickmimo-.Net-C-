using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quickmimo.Repositories;
using System.Windows.Forms.DataVisualization.Charting;
using quickmimo.Calendrier;
using quickmimo.Entities;

namespace quickmimo.statistique
{
    public partial class Statistic : Form
    {
        private readonly TaskRepository _taskRepo =new TaskRepository(Program.DbContext);
        private readonly NoteRepository _noteRepo = new NoteRepository(Program.DbContext);
        User userConnected = UserSession.connectedUser;
        public Statistic()
        {
            InitializeComponent();
            //_taskRepo = taskRepo;
            //_noteRepo = noteRepo;
        }

        private async void Statistics_Load(object sender, EventArgs e)
        {
            List<MYTask> tasks =  _taskRepo.GetAllTasksByUser(userConnected.Id);
            //var notes = await _noteRepo.GetAllAsync();
            MessageBox.Show(tasks[0].title);
            // lblTotalTaches.Text = $"TÂCHES : {tasks.Count}";
            try
            {
                MessageBox.Show(lblTachesTerminees == null ? "lblTachesTerminees NULL" : "lblTachesTerminees OK");
                MessageBox.Show(lblTachesRetard == null ? "lblTachesRetard NULL" : "lblTachesRetard OK");
                MessageBox.Show(chartTasks == null ? "chartTasks NULL" : "chartTasks OK");
              //  lblTachesTerminees.Text = $"TERM.  : {tasks.Count(t => t.status.Equals("done"))}";
               // lblTachesRetard.Text = $"RETARD : {tasks.Count(t => t.deadline < DateTime.Now && !t.status.Equals("done"))}";
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Erreur : " + ex.Message + "\n" + ex.StackTrace);
            }

            UpdatePieChart(chartTasks.Series["Data"],
                tasks.GroupBy(t => string.IsNullOrEmpty(t.status) ? "Non défini" : t.status)
                     .ToDictionary(g => g.Key, g => g.Count()));

            //UpdatePieChart(chartNotes.Series["Data"],
            //    notes.GroupBy(n => n.Category != null ? n.Category.ToString() : "Sans catégorie")
            //         .ToDictionary(g => g.Key, g => g.Count()));
        }

        private void UpdatePieChart(Series series, Dictionary<string, int> data)
        {
            series.Points.Clear();
            if (!data.Any())
            {
                series.Points.Add(new DataPoint
                {
                    AxisLabel = "Pas de données",
                    YValues = new[] { 1d },
                    Label = "Pas de données (100%)",
                    Color = Color.LightGray
                });
                return;
            }
            foreach (var kv in data)
            {
                series.Points.Add(new DataPoint
                {
                    AxisLabel = kv.Key,
                    YValues = new[] { (double)kv.Value },
                    Label = $"{kv.Key} ({kv.Value})",
                    Color = GetStatusColor(kv.Key)
                });
            }
        }

        private Color GetStatusColor(string status) => status.ToUpperInvariant() switch
        {
            "TERMINÉ" => Color.ForestGreen,
            "EN COURS" => Color.DodgerBlue,
            "EN RETARD" => Color.OrangeRed,
            _ => Color.Gray
        };

        private void BtnAccueil_Click(object sender, EventArgs e)
        {
            new Calendar().Show();
            this.Hide();
        }
        private void BtnStats_Click(object sender, EventArgs e) { /* déjà ici */ }
        private void BtnTaches_Click(object sender, EventArgs e)
        {
            new listeTaches().Show();
            this.Hide();
        }
    }
}
