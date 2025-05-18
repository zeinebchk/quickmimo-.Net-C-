namespace quickmimo.Calendrier
{
    partial class ucDays
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblTaskTitle = new Label();
            checkBox1 = new CheckBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTaskTitle);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(124, 64);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lblTaskTitle
            // 
            lblTaskTitle.AutoSize = true;
            lblTaskTitle.Font = new Font("Constantia", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTaskTitle.Location = new Point(28, 33);
            lblTaskTitle.Margin = new Padding(2, 0, 2, 0);
            lblTaskTitle.Name = "lblTaskTitle";
            lblTaskTitle.Size = new Size(0, 21);
            lblTaskTitle.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(2, 3);
            checkBox1.Margin = new Padding(2, 2, 2, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 1;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 0;
            label1.Text = "00";
            // 
            // ucDays
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ucDays";
            Padding = new Padding(1);
            Size = new Size(126, 66);
            Load += ucDay_load;
            Click += panel1_click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox checkBox1;
        private Label label1;
        private Label lblTaskTitle;
    }
}
