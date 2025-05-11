namespace quickmimo
{
    partial class listeTaches
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listeTaches));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            todoPanel = new FlowLayoutPanel();
            panel4 = new Panel();
            inProgressPanel = new FlowLayoutPanel();
            panel = new Panel();
            donePanel = new FlowLayoutPanel();
            panel6 = new Panel();
            btntermine = new Button();
            label2 = new Label();
            panel7 = new Panel();
            btntodo = new Button();
            label3 = new Label();
            panel8 = new Panel();
            btnInProgress = new Button();
            label4 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 246, 207);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1312, 65);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1252, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1069, 12);
            button1.Name = "button1";
            button1.Size = new Size(84, 68);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(244, 53);
            label1.TabIndex = 8;
            label1.Text = "QUICK MIMO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(117, 11, 83);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 591);
            panel1.TabIndex = 2;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Constantia", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.GhostWhite;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(0, 383);
            button6.Name = "button6";
            button6.Size = new Size(246, 68);
            button6.TabIndex = 5;
            button6.Text = "Déconnexion";
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Constantia", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(0, 318);
            button5.Name = "button5";
            button5.Size = new Size(246, 68);
            button5.TabIndex = 4;
            button5.Text = "   Calendrier";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Constantia", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(0, 253);
            button4.Name = "button4";
            button4.Size = new Size(246, 68);
            button4.TabIndex = 3;
            button4.Text = "   Notes";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Constantia", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(0, 188);
            button3.Name = "button3";
            button3.Size = new Size(246, 68);
            button3.TabIndex = 2;
            button3.Text = "    Taches";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Constantia", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(0, 124);
            button2.Name = "button2";
            button2.Size = new Size(246, 68);
            button2.TabIndex = 1;
            button2.Text = "    Dashboard";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(47, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(todoPanel);
            panel3.Location = new Point(319, 230);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 385);
            panel3.TabIndex = 3;
            // 
            // todoPanel
            // 
            todoPanel.AutoScroll = true;
            todoPanel.Dock = DockStyle.Fill;
            todoPanel.FlowDirection = FlowDirection.TopDown;
            todoPanel.Location = new Point(0, 0);
            todoPanel.Name = "todoPanel";
            todoPanel.Size = new Size(300, 385);
            todoPanel.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(inProgressPanel);
            panel4.Location = new Point(669, 234);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 359);
            panel4.TabIndex = 4;
            panel4.Paint += panel4_Paint;
            // 
            // inProgressPanel
            // 
            inProgressPanel.AutoScroll = true;
            inProgressPanel.FlowDirection = FlowDirection.TopDown;
            inProgressPanel.Location = new Point(0, 3);
            inProgressPanel.Name = "inProgressPanel";
            inProgressPanel.Size = new Size(300, 378);
            inProgressPanel.TabIndex = 0;
            // 
            // panel
            // 
            panel.AutoScroll = true;
            panel.Controls.Add(donePanel);
            panel.Location = new Point(998, 231);
            panel.Name = "panel";
            panel.Size = new Size(300, 359);
            panel.TabIndex = 5;
            // 
            // donePanel
            // 
            donePanel.AutoScroll = true;
            donePanel.FlowDirection = FlowDirection.TopDown;
            donePanel.Location = new Point(2, 3);
            donePanel.Name = "donePanel";
            donePanel.Size = new Size(300, 381);
            donePanel.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.YellowGreen;
            panel6.Controls.Add(btntermine);
            panel6.Controls.Add(label2);
            panel6.Font = new Font("Constantia", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel6.Location = new Point(1000, 174);
            panel6.Name = "panel6";
            panel6.Size = new Size(300, 59);
            panel6.TabIndex = 6;
            // 
            // btntermine
            // 
            btntermine.FlatAppearance.BorderSize = 0;
            btntermine.FlatStyle = FlatStyle.Flat;
            btntermine.Image = (Image)resources.GetObject("btntermine.Image");
            btntermine.Location = new Point(239, 14);
            btntermine.Name = "btntermine";
            btntermine.Size = new Size(47, 34);
            btntermine.TabIndex = 3;
            btntermine.UseVisualStyleBackColor = true;
            btntermine.Click += btntermine_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 9);
            label2.Name = "label2";
            label2.Size = new Size(143, 39);
            label2.TabIndex = 0;
            label2.Text = "Terminé";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Crimson;
            panel7.Controls.Add(btntodo);
            panel7.Controls.Add(label3);
            panel7.Font = new Font("Constantia", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel7.Location = new Point(319, 174);
            panel7.Name = "panel7";
            panel7.Size = new Size(300, 59);
            panel7.TabIndex = 7;
            // 
            // btntodo
            // 
            btntodo.FlatAppearance.BorderSize = 0;
            btntodo.FlatStyle = FlatStyle.Flat;
            btntodo.Image = (Image)resources.GetObject("btntodo.Image");
            btntodo.Location = new Point(240, 14);
            btntodo.Name = "btntodo";
            btntodo.Size = new Size(47, 34);
            btntodo.TabIndex = 1;
            btntodo.UseVisualStyleBackColor = true;
            btntodo.Click += btntodo_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 12);
            label3.Name = "label3";
            label3.Size = new Size(116, 39);
            label3.TabIndex = 0;
            label3.Text = "A faire";
            label3.Click += label3_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.DarkOrange;
            panel8.Controls.Add(btnInProgress);
            panel8.Controls.Add(label4);
            panel8.Font = new Font("Constantia", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel8.Location = new Point(669, 174);
            panel8.Name = "panel8";
            panel8.Size = new Size(300, 59);
            panel8.TabIndex = 7;
            // 
            // btnInProgress
            // 
            btnInProgress.FlatAppearance.BorderSize = 0;
            btnInProgress.FlatStyle = FlatStyle.Flat;
            btnInProgress.Image = (Image)resources.GetObject("btnInProgress.Image");
            btnInProgress.Location = new Point(239, 14);
            btnInProgress.Name = "btnInProgress";
            btnInProgress.Size = new Size(47, 34);
            btnInProgress.TabIndex = 2;
            btnInProgress.UseVisualStyleBackColor = true;
            btnInProgress.Click += btnInProgress_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 9);
            label4.Name = "label4";
            label4.Size = new Size(146, 39);
            label4.TabIndex = 0;
            label4.Text = "En cours";
            label4.Click += label4_Click;
            // 
            // listeTaches
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 656);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "listeTaches";
            Text = "listeTaches";
            WindowState = FormWindowState.Maximized;
            Load += listeTaches_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private PictureBox pictureBox2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button6;
        private Panel panel3;
        private VScrollBar vScrollBar1;
        private Panel panel4;
        private VScrollBar vScrollBar2;
        private Panel panel;
        private VScrollBar vScrollBar3;
        private Panel panel6;
        private Label label2;
        private Panel panel7;
        private Label label3;
        private Panel panel8;
        private Label label4;
        private Button btntermine;
        private Button btntodo;
        private Button btnInProgress;
        private ListView lvEnCours;
        private ListView lvTermine;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn task;
        private DataGridViewTextBoxColumn btn;
        private FlowLayoutPanel todoPanel;
        private FlowLayoutPanel inProgressPanel;
        private FlowLayoutPanel donePanel;
    }
}