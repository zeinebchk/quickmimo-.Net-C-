namespace quickmimo
{
    partial class TaskItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskItem));
            lblTaskName = new Label();
            btnTaskItem = new PictureBox();
            lblId = new Label();
            ((System.ComponentModel.ISupportInitialize)btnTaskItem).BeginInit();
            SuspendLayout();
            // 
            // lblTaskName
            // 
            lblTaskName.AutoSize = true;
            lblTaskName.Font = new Font("Constantia", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTaskName.Location = new Point(14, 9);
            lblTaskName.Name = "lblTaskName";
            lblTaskName.Size = new Size(65, 27);
            lblTaskName.TabIndex = 0;
            lblTaskName.Text = "label1";
            lblTaskName.Click += label1_Click;
            // 
            // btnTaskItem
            // 
            btnTaskItem.Image = (Image)resources.GetObject("btnTaskItem.Image");
            btnTaskItem.Location = new Point(260, 6);
            btnTaskItem.Name = "btnTaskItem";
            btnTaskItem.Size = new Size(37, 30);
            btnTaskItem.SizeMode = PictureBoxSizeMode.StretchImage;
            btnTaskItem.TabIndex = 1;
            btnTaskItem.TabStop = false;
            btnTaskItem.Click += btnTaskItem_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(94, 11);
            lblId.Name = "lblId";
            lblId.Size = new Size(59, 25);
            lblId.TabIndex = 2;
            lblId.Text = "label1";
            lblId.Visible = false;
            // 
            // TaskItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblId);
            Controls.Add(btnTaskItem);
            Controls.Add(lblTaskName);
            Name = "TaskItem";
            Size = new Size(300, 43);
            Load += TaskItem_Load;
            ((System.ComponentModel.ISupportInitialize)btnTaskItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTaskName;
        private PictureBox btnTaskItem;
        private Label lblId;
    }
}
