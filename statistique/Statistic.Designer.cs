namespace quickmimo.statistique
{
    partial class Statistic
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.Button btnTaches;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.FlowLayoutPanel statsPanel;
        private System.Windows.Forms.Label lblTotalTaches;
        private System.Windows.Forms.Label lblTachesTerminees;
        private System.Windows.Forms.Label lblTachesRetard;
        private System.Windows.Forms.Label lblLastUpdate;
        private System.Windows.Forms.TableLayoutPanel chartsPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTasks;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNotes;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnTaches = new System.Windows.Forms.Button();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.statsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTotalTaches = new System.Windows.Forms.Label();
            this.lblTachesTerminees = new System.Windows.Forms.Label();
            this.lblTachesRetard = new System.Windows.Forms.Label();
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.chartsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.chartTasks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartNotes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableMain.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.statsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNotes)).BeginInit();
            this.SuspendLayout();

            // tableMain
            this.tableMain.ColumnCount = 2;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Controls.Add(this.panelSidebar, 0, 0);
            this.tableMain.Controls.Add(this.statsPanel, 1, 0);
            this.tableMain.Controls.Add(this.chartsPanel, 1, 1);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 2;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Size = new System.Drawing.Size(1333, 1055);
            this.tableMain.TabIndex = 0;

            // panelSidebar
            // Version optimisée (les casts en (int) et (byte) sont inutiles) :
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(147, 112, 219); this.panelSidebar.Controls.Add(this.btnRefresh);
            this.panelSidebar.Controls.Add(this.btnTaches);
            this.panelSidebar.Controls.Add(this.btnAccueil);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSidebar.Location = new System.Drawing.Point(3, 3);
            this.panelSidebar.Name = "panelSidebar";
            this.tableMain.SetRowSpan(this.panelSidebar, 2);
            this.panelSidebar.Size = new System.Drawing.Size(261, 1049);
            this.panelSidebar.TabIndex = 0;

            // btnRefresh
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(0, 957);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(261, 92);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Actualiser";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);

            // btnTaches
            this.btnTaches.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaches.FlatAppearance.BorderSize = 0;
            this.btnTaches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaches.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTaches.ForeColor = System.Drawing.Color.White;
            this.btnTaches.Location = new System.Drawing.Point(0, 92);
            this.btnTaches.Name = "btnTaches";
            this.btnTaches.Size = new System.Drawing.Size(261, 92);
            this.btnTaches.TabIndex = 1;
            this.btnTaches.Text = "Tâches";
            this.btnTaches.UseVisualStyleBackColor = true;
            this.btnTaches.Click += new System.EventHandler(this.BtnTaches_Click);

            // btnAccueil
            this.btnAccueil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccueil.FlatAppearance.BorderSize = 0;
            this.btnAccueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccueil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAccueil.ForeColor = System.Drawing.Color.White;
            this.btnAccueil.Location = new System.Drawing.Point(0, 0);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(261, 92);
            this.btnAccueil.TabIndex = 0;
            this.btnAccueil.Text = "Accueil";
            this.btnAccueil.UseVisualStyleBackColor = true;
            this.btnAccueil.Click += new System.EventHandler(this.BtnAccueil_Click);

            // statsPanel
            this.statsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statsPanel.Controls.Add(this.lblTotalTaches);
            this.statsPanel.Controls.Add(this.lblTachesTerminees);
            this.statsPanel.Controls.Add(this.lblTachesRetard);
            this.statsPanel.Controls.Add(this.lblLastUpdate);
            this.statsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statsPanel.Location = new System.Drawing.Point(270, 3);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Padding = new System.Windows.Forms.Padding(27, 31, 27, 31);
            this.statsPanel.Size = new System.Drawing.Size(1060, 148);
            this.statsPanel.TabIndex = 1;

            // lblTotalTaches
            this.lblTotalTaches.BackColor = System.Drawing.Color.White;
            this.lblTotalTaches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalTaches.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalTaches.ForeColor = Color.FromArgb(147, 112, 219); this.lblTotalTaches.Location = new System.Drawing.Point(27, 31);
            this.lblTotalTaches.Margin = new System.Windows.Forms.Padding(13, 15, 13, 15);
            this.lblTotalTaches.Name = "lblTotalTaches";
            this.lblTotalTaches.Size = new System.Drawing.Size(266, 122);
            this.lblTotalTaches.TabIndex = 0;
            this.lblTotalTaches.Text = "📋 Tâches totales\n0";
            this.lblTotalTaches.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblTachesTerminees
            this.lblTachesTerminees.BackColor = System.Drawing.Color.White;
            this.lblTachesTerminees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTachesTerminees.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTachesTerminees.ForeColor = Color.FromArgb(147, 112, 219); this.lblTachesTerminees.Location = new System.Drawing.Point(319, 31);
            this.lblTachesTerminees.Margin = new System.Windows.Forms.Padding(13, 15, 13, 15);
            this.lblTachesTerminees.Name = "lblTachesTerminees";
            this.lblTachesTerminees.Size = new System.Drawing.Size(266, 122);
            this.lblTachesTerminees.TabIndex = 1;
            this.lblTachesTerminees.Text = "✅ Terminées\n0 (0.0%)";
            this.lblTachesTerminees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblTachesRetard
            this.lblTachesRetard.BackColor = System.Drawing.Color.White;
            this.lblTachesRetard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTachesRetard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            // Solution optimisée (les casts en (int) et (byte) sont redondants) :
            this.lblTachesRetard.ForeColor = System.Drawing.Color.FromArgb(147, 112, 219); this.lblTachesRetard.Location = new System.Drawing.Point(611, 31);
            this.lblTachesRetard.Margin = new System.Windows.Forms.Padding(13, 15, 13, 15);
            this.lblTachesRetard.Name = "lblTachesRetard";
            this.lblTachesRetard.Size = new System.Drawing.Size(266, 122);
            this.lblTachesRetard.TabIndex = 2;
            this.lblTachesRetard.Text = "⏳ En retard\n0 (0.0%)";
            this.lblTachesRetard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblLastUpdate
            this.lblLastUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLastUpdate.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblLastUpdate.ForeColor = Color.FromArgb(147, 112, 219); this.lblLastUpdate.Location = new System.Drawing.Point(31, 183);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(333, 31);
            this.lblLastUpdate.TabIndex = 3;
            this.lblLastUpdate.Text = "Dernière mise à jour :";

            // chartsPanel
            this.chartsPanel.ColumnCount = 2;
            this.chartsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.chartsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.chartsPanel.Controls.Add(this.chartTasks, 0, 0);
            this.chartsPanel.Controls.Add(this.chartNotes, 1, 0);
            this.chartsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartsPanel.Location = new System.Drawing.Point(270, 157);
            this.chartsPanel.Name = "chartsPanel";
            this.chartsPanel.RowCount = 1;
            this.chartsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.chartsPanel.Size = new System.Drawing.Size(1060, 895);
            this.chartsPanel.TabIndex = 2;

            // chartTasks
            this.chartTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartTasks.Location = new System.Drawing.Point(3, 3);
            this.chartTasks.Name = "chartTasks";
            this.chartTasks.Size = new System.Drawing.Size(524, 889);
            this.chartTasks.TabIndex = 0;

            // chartNotes
            this.chartNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartNotes.Location = new System.Drawing.Point(533, 3);
            this.chartNotes.Name = "chartNotes";
            this.chartNotes.Size = new System.Drawing.Size(524, 889);
            this.chartNotes.TabIndex = 1;

            // Statistic
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 1055);
            this.Controls.Add(this.tableMain);
            this.Name = "Statistic";
            this.Text = "Statistiques";
            this.Load += new System.EventHandler(this.Statistic_Load);
            this.tableMain.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.statsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNotes)).EndInit();
            this.ResumeLayout(false);
        }
    }
}