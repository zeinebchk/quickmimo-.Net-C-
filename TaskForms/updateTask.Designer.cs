namespace quickmimo.TaskForms
{
    partial class updateTask
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
            label5 = new Label();
            startDatePicker = new DateTimePicker();
            notifDate = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            deadlineDate = new DateTimePicker();
            label2 = new Label();
            comboStatus = new ComboBox();
            panel1 = new Panel();
            txtdescription = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtTitle = new TextBox();
            btnUpdate = new Button();
            label1 = new Label();
            btnupdatestatus = new Button();
            btnAnnuler = new Button();
            lblsupprimer = new Button();
            grpStatus = new GroupBox();
            donebtn = new RadioButton();
            inProgressbtn = new RadioButton();
            totdobtn = new RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpStatus.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 471);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(119, 27);
            label5.TabIndex = 57;
            label5.Text = "Date début";
            // 
            // startDatePicker
            // 
            startDatePicker.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            startDatePicker.Format = DateTimePickerFormat.Custom;
            startDatePicker.Location = new Point(24, 516);
            startDatePicker.Margin = new Padding(4, 3, 4, 3);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.ShowUpDown = true;
            startDatePicker.Size = new Size(387, 34);
            startDatePicker.TabIndex = 56;
            // 
            // notifDate
            // 
            notifDate.FormattingEnabled = true;
            notifDate.Location = new Point(255, 726);
            notifDate.Margin = new Padding(5, 3, 5, 3);
            notifDate.Name = "notifDate";
            notifDate.Size = new Size(236, 35);
            notifDate.TabIndex = 55;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 729);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(189, 27);
            label4.TabIndex = 54;
            label4.Text = "Définir un rappel  ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 583);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(169, 27);
            label3.TabIndex = 53;
            label3.Text = "Date d'échéance";
            // 
            // deadlineDate
            // 
            deadlineDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            deadlineDate.Format = DateTimePickerFormat.Custom;
            deadlineDate.Location = new Point(24, 640);
            deadlineDate.Margin = new Padding(4, 3, 4, 3);
            deadlineDate.Name = "deadlineDate";
            deadlineDate.Size = new Size(387, 34);
            deadlineDate.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 402);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 27);
            label2.TabIndex = 51;
            label2.Text = "Dans la liste";
            // 
            // comboStatus
            // 
            comboStatus.FormattingEnabled = true;
            comboStatus.Location = new Point(202, 393);
            comboStatus.Margin = new Padding(5, 3, 5, 3);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(209, 35);
            comboStatus.TabIndex = 50;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtdescription);
            panel1.Location = new Point(17, 204);
            panel1.Margin = new Padding(5, 3, 5, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 155);
            panel1.TabIndex = 49;
            // 
            // txtdescription
            // 
            txtdescription.Dock = DockStyle.Fill;
            txtdescription.Location = new Point(0, 0);
            txtdescription.Margin = new Padding(5, 3, 5, 3);
            txtdescription.Multiline = true;
            txtdescription.Name = "txtdescription";
            txtdescription.PlaceholderText = "Déscription...";
            txtdescription.Size = new Size(468, 155);
            txtdescription.TabIndex = 33;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.note_collante_removebg_preview;
            pictureBox2.Location = new Point(576, 29);
            pictureBox2.Margin = new Padding(5, 3, 5, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(112, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 48;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.note_collante_removebg_preview;
            pictureBox1.Location = new Point(43, 29);
            pictureBox1.Margin = new Padding(5, 3, 5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(192, 192, 255);
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Font = new Font("Times New Roman", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(17, 137);
            txtTitle.Margin = new Padding(5, 3, 5, 3);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Titre";
            txtTitle.Size = new Size(394, 33);
            txtTitle.TabIndex = 46;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 128, 128);
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(541, 774);
            btnUpdate.Margin = new Padding(5, 3, 5, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(213, 54);
            btnUpdate.TabIndex = 45;
            btnUpdate.Text = "Valider";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnInscri_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 18F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(166, 49);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(388, 57);
            label1.TabIndex = 44;
            label1.Text = "Détail  d'une tache";
            // 
            // btnupdatestatus
            // 
            btnupdatestatus.BackColor = Color.FromArgb(255, 128, 128);
            btnupdatestatus.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdatestatus.Location = new Point(541, 531);
            btnupdatestatus.Margin = new Padding(5, 3, 5, 3);
            btnupdatestatus.Name = "btnupdatestatus";
            btnupdatestatus.Size = new Size(213, 54);
            btnupdatestatus.TabIndex = 58;
            btnupdatestatus.Text = "Déplacer vers ";
            btnupdatestatus.UseVisualStyleBackColor = false;
            btnupdatestatus.Click += btnupdatestatus_Click;
            // 
            // btnAnnuler
            // 
            btnAnnuler.BackColor = Color.FromArgb(255, 128, 128);
            btnAnnuler.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnnuler.Location = new Point(541, 691);
            btnAnnuler.Margin = new Padding(5, 3, 5, 3);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(213, 54);
            btnAnnuler.TabIndex = 59;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = false;
            btnAnnuler.Click += btnfileupload_Click;
            // 
            // lblsupprimer
            // 
            lblsupprimer.BackColor = Color.FromArgb(255, 128, 128);
            lblsupprimer.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsupprimer.Location = new Point(541, 604);
            lblsupprimer.Margin = new Padding(5, 3, 5, 3);
            lblsupprimer.Name = "lblsupprimer";
            lblsupprimer.Size = new Size(213, 54);
            lblsupprimer.TabIndex = 60;
            lblsupprimer.Text = "Supprimer";
            lblsupprimer.UseVisualStyleBackColor = false;
            lblsupprimer.Click += lblsupprimer_Click;
            // 
            // grpStatus
            // 
            grpStatus.Controls.Add(donebtn);
            grpStatus.Controls.Add(inProgressbtn);
            grpStatus.Controls.Add(totdobtn);
            grpStatus.Location = new Point(541, 363);
            grpStatus.Margin = new Padding(4, 3, 4, 3);
            grpStatus.Name = "grpStatus";
            grpStatus.Padding = new Padding(4, 3, 4, 3);
            grpStatus.Size = new Size(213, 172);
            grpStatus.TabIndex = 61;
            grpStatus.TabStop = false;
            grpStatus.Visible = false;
            // 
            // donebtn
            // 
            donebtn.AutoSize = true;
            donebtn.Location = new Point(29, 133);
            donebtn.Margin = new Padding(4, 3, 4, 3);
            donebtn.Name = "donebtn";
            donebtn.Size = new Size(118, 31);
            donebtn.TabIndex = 2;
            donebtn.TabStop = true;
            donebtn.Text = "Tèrminé";
            donebtn.UseVisualStyleBackColor = true;
            donebtn.CheckedChanged += donebtn_CheckedChanged;
            // 
            // inProgressbtn
            // 
            inProgressbtn.AutoSize = true;
            inProgressbtn.Location = new Point(27, 81);
            inProgressbtn.Margin = new Padding(4, 3, 4, 3);
            inProgressbtn.Name = "inProgressbtn";
            inProgressbtn.Size = new Size(120, 31);
            inProgressbtn.TabIndex = 1;
            inProgressbtn.TabStop = true;
            inProgressbtn.Text = "En cours";
            inProgressbtn.UseVisualStyleBackColor = true;
            inProgressbtn.CheckedChanged += inProgressbtn_CheckedChanged;
            // 
            // totdobtn
            // 
            totdobtn.AutoSize = true;
            totdobtn.Location = new Point(27, 33);
            totdobtn.Margin = new Padding(4, 3, 4, 3);
            totdobtn.Name = "totdobtn";
            totdobtn.Size = new Size(101, 31);
            totdobtn.TabIndex = 0;
            totdobtn.TabStop = true;
            totdobtn.Text = "A faire";
            totdobtn.UseVisualStyleBackColor = true;
            totdobtn.CheckedChanged += totdobtn_CheckedChanged;
            // 
            // updateTask
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(792, 875);
            Controls.Add(grpStatus);
            Controls.Add(lblsupprimer);
            Controls.Add(btnAnnuler);
            Controls.Add(btnupdatestatus);
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
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Font = new Font("Constantia", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "updateTask";
            Text = "updateTask";
            Load += updateTask_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpStatus.ResumeLayout(false);
            grpStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DateTimePicker startDatePicker;
        private ComboBox notifDate;
        private Label label4;
        private Label label3;
        private DateTimePicker deadlineDate;
        private Label label2;
        private ComboBox comboStatus;
        private Panel panel1;
        private TextBox txtdescription;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox txtTitle;
        private Button btnUpdate;
        private Label label1;
        private Button btnupdatestatus;
        private Button btnAnnuler;
        private Button lblsupprimer;
        private GroupBox grpStatus;
        private RadioButton donebtn;
        private RadioButton inProgressbtn;
        private RadioButton totdobtn;
    }
}