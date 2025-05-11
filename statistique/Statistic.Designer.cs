using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.ComponentModel;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace quickmimo.statistique
{
    partial class Statistic
    {
    private IContainer components = null;

    private TableLayoutPanel tableMain;
    private Panel panelSidebar;
    private System.Windows.Forms.Button btnAccueil, btnStats, btnTaches;
    private FlowLayoutPanel statsPanel;
    private Label lblTotalTaches, lblTachesTerminees, lblTachesRetard;
    private TableLayoutPanel chartsPanel;
    private Chart chartTasks, chartNotes;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

        private void InitializeComponent()
        {
            tableMain = new TableLayoutPanel();
            panelSidebar = new Panel();
            rightLayout = new TableLayoutPanel();
            statsPanel = new FlowLayoutPanel();
            chartsPanel = new TableLayoutPanel();
            tableMain.SuspendLayout();
            rightLayout.SuspendLayout();
            SuspendLayout();
            // 
            // tableMain
            // 
            tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableMain.Controls.Add(panelSidebar, 0, 0);
            tableMain.Controls.Add(rightLayout, 1, 0);
            tableMain.Location = new Point(0, 0);
            tableMain.Name = "tableMain";
            tableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableMain.Size = new Size(200, 100);
            tableMain.TabIndex = 0;
            // 
            // panelSidebar
            // 
            panelSidebar.Location = new Point(3, 3);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(194, 94);
            panelSidebar.TabIndex = 0;
            // 
            // rightLayout
            // 
            rightLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            rightLayout.Controls.Add(statsPanel, 0, 0);
            rightLayout.Controls.Add(chartsPanel, 0, 1);
            rightLayout.Location = new Point(203, 3);
            rightLayout.Name = "rightLayout";
            rightLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            rightLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            rightLayout.Size = new Size(1, 94);
            rightLayout.TabIndex = 1;
            // 
            // statsPanel
            // 
            statsPanel.Location = new Point(3, 3);
            statsPanel.Name = "statsPanel";
            statsPanel.Size = new Size(14, 54);
            statsPanel.TabIndex = 0;
            // 
            // chartsPanel
            // 
            chartsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            chartsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            chartsPanel.Location = new Point(3, 63);
            chartsPanel.Name = "chartsPanel";
            chartsPanel.Size = new Size(14, 28);
            chartsPanel.TabIndex = 1;
            // 
            // Statistic
            // 
            ClientSize = new Size(1000, 700);
            Controls.Add(tableMain);
            Name = "Statistic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Statistiques";
            WindowState = FormWindowState.Maximized;
            Load += Statistics_Load;
            tableMain.ResumeLayout(false);
            rightLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        // helper pour boutons
        //private Button CreateSidebarButton(string text)
        //{
        //    return new Button
        //    {
        //        Text = text,
        //        Dock = DockStyle.Top,
        //        Height = 50,
        //        BackColor = Color.Gray,
        //        FlatStyle = FlatStyle.Flat,
        //        ForeColor = Color.White,
        //        Font = new Font("Segoe UI", 10F, FontStyle.Bold),
        //        Margin = new Padding(5)
        //    };
        //}

        // helper pour labels
        private Label CreateStatLabel(Color color)
    {
        return new Label
        {
            AutoSize = true,
            Font = new Font("Segoe UI", 12F, FontStyle.Bold),
            ForeColor = color,
            Margin = new Padding(20, 15, 20, 0),
            Padding = new Padding(5)
        };
    }

    // helper pour charts
    private Chart CreateChart(string title)
    {
        var chart = new Chart { Dock = DockStyle.Fill };
        var area = new ChartArea("MainArea");
        area.AxisX.MajorGrid.Enabled = false;
        area.AxisY.MajorGrid.Enabled = false;
        area.Area3DStyle.Enable3D = true;
        chart.ChartAreas.Add(area);

        var legend = new Legend("MainLegend") { Title = title };
        chart.Legends.Add(legend);

        var series = new Series("Data")
        {
            ChartType = SeriesChartType.Pie,
            ChartArea = "MainArea",
            Legend = "MainLegend"
        };
        chart.Series.Add(series);
        chart.Titles.Add(title);
        return chart;
        }

        private TableLayoutPanel rightLayout;
    }
}