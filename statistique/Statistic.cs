using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using quickmimo.Calendrier;
using quickmimo.Entities;
using quickmimo.Repositories;

namespace quickmimo.statistique
{
    public partial class Statistic : Form
    {
        private readonly TaskRepository _taskRepo;
        private readonly NoteRepository _noteRepo;
        private readonly User _userConnected;
        private readonly Color[] _colorPalette =
        {
            Color.SteelBlue, Color.ForestGreen, Color.DarkOrange,
            Color.Crimson, Color.MediumPurple, Color.SaddleBrown,
            Color.Teal, Color.Goldenrod, Color.DeepPink, Color.SlateGray
        };
        private readonly Dictionary<string, Color> _categoryColors = new Dictionary<string, Color>();

        public Statistic()
        {
            InitializeComponent();
            _taskRepo = new TaskRepository(Program.DbContext);
            _noteRepo = new NoteRepository(Program.DbContext);
            _userConnected = UserSession.connectedUser;
            ConfigureUI();
        }

        private void ConfigureUI()
        {
            ConfigureNavbar();
            ConfigureStatsCards();
            InitializeChart(chartTasks, "Statut des Tâches");
            InitializeChart(chartNotes, "Catégories des Notes");
        }

        private void ConfigureNavbar()
        {
            panelSidebar.BackColor = Color.FromArgb(147, 112, 219);

            var buttons = new[] { btnAccueil, btnTaches, btnRefresh };
            foreach (var btn in buttons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.Transparent;
                btn.ForeColor = Color.White;
                btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                btn.Height = 50;
                btn.Dock = DockStyle.Top;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(138, 43, 226);
            }
        }

        private void ConfigureStatsCards()
        {
            statsPanel.FlowDirection = FlowDirection.LeftToRight;
            statsPanel.WrapContents = false;
            statsPanel.AutoScroll = true;

            var cards = new[] { lblTotalTaches, lblTachesTerminees, lblTachesRetard };
            foreach (var card in cards)
            {
                card.BackColor = Color.White;
                card.ForeColor = Color.FromArgb(147, 112, 219);
                card.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                card.TextAlign = ContentAlignment.MiddleCenter;
                card.BorderStyle = BorderStyle.FixedSingle;
                card.Margin = new Padding(10);
                card.Size = new Size(200, 80);
            }

            lblLastUpdate.Anchor = AnchorStyles.Right;
            lblLastUpdate.AutoSize = false;
            lblLastUpdate.Size = new Size(250, 20);
        }

        private void InitializeChart(Chart chart, string title)
        {
            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.Legends.Clear();

            var chartArea = new ChartArea { Name = "ChartArea" };
            chart.ChartAreas.Add(chartArea);

            var series = new Series("Data")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                LabelFormat = "#.##%",
                ChartArea = "ChartArea"
            };
            chart.Series.Add(series);

            var legend = new Legend
            {
                Name = "Legend",
                Docking = Docking.Bottom,
                Font = new Font("Segoe UI", 9)
            };
            chart.Legends.Add(legend);

            chart.Titles.Add(new Title(title)
            {
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(147, 112, 219)
            });
        }

        private async void Statistic_Load(object sender, EventArgs e)
        {
            try
            {
                var loadTasks = Task.Run(() => _taskRepo.GetAllTasksByUser(_userConnected.Id));
                var loadNotes = _noteRepo.GetAllAsync();

                await Task.WhenAll(loadTasks, loadNotes);

                UpdateUI(() =>
                {
                    UpdateTaskStats(loadTasks.Result);
                    UpdateNoteStats(loadNotes.Result);
                    UpdateCharts(loadTasks.Result, loadNotes.Result);
                    lblLastUpdate.Text = $"🕒 Dernière actualisation : {DateTime.Now:HH:mm:ss}";
                });
            }
            catch (Exception ex)
            {
                UpdateUI(() => MessageBox.Show(
                    $"Une erreur est survenue :\n{ex.Message}\n\nVeuillez réessayer.",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                ));
            }
        }

        private void UpdateUI(Action action)
        {
            if (InvokeRequired)
                Invoke(action);
            else
                action();
        }
         
        private void UpdateTaskStats(List<MYTask> tasks)
        {
            int total = tasks.Count;
            int completed = tasks.Count(t => t.status.Equals("done", StringComparison.OrdinalIgnoreCase));
            int overdue = tasks.Count(t => t.deadline < DateTime.Now && !t.status.Equals("done", StringComparison.OrdinalIgnoreCase));

            lblTotalTaches.Text = $"📋 Tâches totales\n{total}";
            lblTachesTerminees.Text = $"✅ Terminées\n{completed} ({CalculatePercentage(completed, total)}%)";
            lblTachesRetard.Text = $"⏳ En retard\n{overdue} ({CalculatePercentage(overdue, total)}%)";
        }

        private string CalculatePercentage(int value, int total)
        {
            return total == 0 ? "0.0" : ((double)value / total * 100).ToString("0.0");
        }

        private void UpdateNoteStats(List<Note> notes)
        {
            // Implémentation optionnelle pour les statistiques des notes
        }

        private void UpdateCharts(List<MYTask> tasks, List<Note> notes)
        {
            UpdateChartData(chartTasks, tasks
                .GroupBy(t => string.IsNullOrEmpty(t.status) ? "Non défini" : t.status)
                .ToDictionary(g => g.Key, g => g.Count()));

            UpdateChartData(chartNotes, notes
                .GroupBy(n => n.Category?.ToString() ?? "Sans catégorie")
                .ToDictionary(g => g.Key, g => g.Count()));
        }

        private void UpdateChartData(Chart chart, Dictionary<string, int> data)
        {
            chart.BeginInit();
            try
            {
                chart.Series["Data"].Points.Clear();
                int total = data.Values.Sum();

                if (total == 0)
                {
                    chart.Series["Data"].Points.Add(new DataPoint
                    {
                        AxisLabel = "Aucune donnée",
                        YValues = new[] { 1.0 },
                        Color = Color.LightGray
                    });
                    return;
                }

                foreach (var item in data)
                {
                    double percentage = (double)item.Value / total * 100;
                    chart.Series["Data"].Points.Add(new DataPoint
                    {
                        AxisLabel = item.Key,
                        YValues = new[] { percentage },
                        Label = $"{percentage:0.0}%",
                        LegendText = $"{item.Key} ({item.Value})",
                        Color = GetCategoryColor(item.Key)
                    });
                }
            }
            finally
            {
                chart.EndInit();
            }
        }

        private Color GetCategoryColor(string category)
        {
            if (!_categoryColors.TryGetValue(category, out var color))
            {
                color = _colorPalette[_categoryColors.Count % _colorPalette.Length];
                _categoryColors[category] = color;
            }
            return color;
        }

        private void BtnAccueil_Click(object sender, EventArgs e)
        {
            Calendar calendarForm = new Calendar();
            calendarForm.Show();
            this.Close(); 
        }

        private void BtnTaches_Click(object sender, EventArgs e)
        {
            listeTaches taskList = new listeTaches();
            taskList.Show();
            this.Close();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Statistic_Load(sender, e);
        }
    }
}