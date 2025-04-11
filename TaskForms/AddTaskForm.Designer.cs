namespace quickmimo.TaskForms
{
    partial class AddTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtTitle = new TextBox();
            btnInscri = new Button();
            label1 = new Label();
            txtdescription = new TextBox();
            panel1 = new Panel();
            comboStatus = new ComboBox();
            label2 = new Label();
            deadlineDate = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            notifDate = new ComboBox();
            label5 = new Label();
            startDatePicker = new DateTimePicker();
            btnAnnuler = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.note_collante_removebg_preview;
            pictureBox2.Location = new Point(440, 35);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(86, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.note_collante_removebg_preview;
            pictureBox1.Location = new Point(13, 35);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(192, 192, 255);
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Font = new Font("Times New Roman", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(64, 147);
            txtTitle.Margin = new Padding(4, 3, 4, 3);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Titre";
            txtTitle.Size = new Size(360, 33);
            txtTitle.TabIndex = 26;
            // 
            // btnInscri
            // 
            btnInscri.BackColor = Color.FromArgb(255, 128, 128);
            btnInscri.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInscri.Location = new Point(285, 770);
            btnInscri.Margin = new Padding(4, 3, 4, 3);
            btnInscri.Name = "btnInscri";
            btnInscri.Size = new Size(241, 50);
            btnInscri.TabIndex = 24;
            btnInscri.Text = "Valider";
            btnInscri.UseVisualStyleBackColor = false;
            btnInscri.Click += btnInscri_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 18F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(325, 57);
            label1.TabIndex = 22;
            label1.Text = "Créer une tache";
            label1.Click += label1_Click;
            // 
            // txtdescription
            // 
            txtdescription.Dock = DockStyle.Fill;
            txtdescription.Location = new Point(0, 0);
            txtdescription.Margin = new Padding(4, 3, 4, 3);
            txtdescription.Multiline = true;
            txtdescription.Name = "txtdescription";
            txtdescription.PlaceholderText = "Déscription...";
            txtdescription.Size = new Size(360, 144);
            txtdescription.TabIndex = 33;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtdescription);
            panel1.Location = new Point(64, 213);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 144);
            panel1.TabIndex = 34;
            // 
            // comboStatus
            // 
            comboStatus.FormattingEnabled = true;
            comboStatus.Location = new Point(206, 386);
            comboStatus.Margin = new Padding(4, 3, 4, 3);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(218, 32);
            comboStatus.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 386);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 24);
            label2.TabIndex = 36;
            label2.Text = "Dans la liste";
            // 
            // deadlineDate
            // 
            deadlineDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            deadlineDate.Format = DateTimePickerFormat.Custom;
            deadlineDate.Location = new Point(64, 618);
            deadlineDate.Name = "deadlineDate";
            deadlineDate.Size = new Size(360, 32);
            deadlineDate.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 559);
            label3.Name = "label3";
            label3.Size = new Size(154, 24);
            label3.TabIndex = 38;
            label3.Text = "Date d'échéance";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 692);
            label4.Name = "label4";
            label4.Size = new Size(171, 24);
            label4.TabIndex = 40;
            label4.Text = "Définir un rappel  ";
            // 
            // notifDate
            // 
            notifDate.FormattingEnabled = true;
            notifDate.Location = new Point(242, 689);
            notifDate.Margin = new Padding(4, 3, 4, 3);
            notifDate.Name = "notifDate";
            notifDate.Size = new Size(182, 32);
            notifDate.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 438);
            label5.Name = "label5";
            label5.Size = new Size(107, 24);
            label5.TabIndex = 43;
            label5.Text = "Date début";
            // 
            // startDatePicker
            // 
            startDatePicker.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            startDatePicker.Format = DateTimePickerFormat.Custom;
            startDatePicker.Location = new Point(64, 489);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.ShowUpDown = true;
            startDatePicker.Size = new Size(360, 32);
            startDatePicker.TabIndex = 42;
            // 
            // btnAnnuler
            // 
            btnAnnuler.BackColor = Color.FromArgb(255, 128, 128);
            btnAnnuler.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnnuler.Location = new Point(36, 770);
            btnAnnuler.Margin = new Padding(4, 3, 4, 3);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(135, 50);
            btnAnnuler.TabIndex = 44;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = false;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // AddTaskForm
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(566, 864);
            Controls.Add(btnAnnuler);
            Controls.Add(label5);
            Controls.Add(startDatePicker);
            Controls.Add(notifDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(deadlineDate);
            Controls.Add(label2);
            Controls.Add(comboStatus);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtTitle);
            Controls.Add(btnInscri);
            Controls.Add(label1);
            Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddTaskForm";
            Text = "AddTaskForm";
            Load += AddTaskForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox txtTitle;
        private Button btnInscri;
        private Label label1;
        private TextBox txtdescription;
        private Panel panel1;
        private ComboBox comboStatus;
        private Label label2;
        private DateTimePicker deadlineDate;
        private Label label3;
        private Label label4;
        private ComboBox notifDate;
        private Label label5;
        private DateTimePicker startDatePicker;
        private Button btnAnnuler;
    }
}