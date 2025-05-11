
namespace stickeynotes
{
    partial class NotesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNewNote;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutNotes;
        private EventHandler btnTasks_Click;


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
        // Initialisation des composants et des contrôles
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotesForm));
            headerPanel = new Panel();
            panel1 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            lblTitle = new Label();
            btnNewNote = new Button();
            flowLayoutNotes = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            panel3 = new Panel();
            headerPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(245, 245, 250);
            headerPanel.Controls.Add(panel1);
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Controls.Add(btnNewNote);
            headerPanel.Location = new Point(3, -1);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1874, 62);
            headerPanel.TabIndex = 1;
            headerPanel.Paint += headerPanel_Paint;
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
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 62);
            panel1.TabIndex = 4;
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
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F);
            lblTitle.ForeColor = Color.FromArgb(50, 50, 60);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(194, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QuickMemo";
            lblTitle.Click += lblTitle_Click;
            // 
            // btnNewNote
            // 
            btnNewNote.BackColor = Color.FromArgb(102, 187, 106);
            btnNewNote.FlatAppearance.BorderSize = 0;
            btnNewNote.FlatStyle = FlatStyle.Flat;
            btnNewNote.ForeColor = Color.White;
            btnNewNote.Location = new Point(1290, 4);
            btnNewNote.Name = "btnNewNote";
            btnNewNote.Size = new Size(180, 55);
            btnNewNote.TabIndex = 1;
            btnNewNote.Text = "➕ Nouvelle Note";
            btnNewNote.UseVisualStyleBackColor = false;
            // 
            // flowLayoutNotes
            // 
            flowLayoutNotes.AutoScroll = true;
            flowLayoutNotes.BackColor = Color.WhiteSmoke;
            flowLayoutNotes.Location = new Point(279, 77);
            flowLayoutNotes.Name = "flowLayoutNotes";
            flowLayoutNotes.Size = new Size(1466, 498);
            flowLayoutNotes.TabIndex = 2;
            flowLayoutNotes.Paint += flowLayoutNotes_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(47, 28);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(104, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // button11
            // 
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Constantia", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.ForeColor = SystemColors.ButtonHighlight;
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.Location = new Point(0, 124);
            button11.Name = "button11";
            button11.Size = new Size(246, 68);
            button11.TabIndex = 1;
            button11.Text = "    Dashboard";
            button11.TextImageRelation = TextImageRelation.ImageBeforeText;
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Constantia", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.ForeColor = SystemColors.ButtonHighlight;
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.Location = new Point(0, 188);
            button10.Name = "button10";
            button10.Size = new Size(246, 68);
            button10.TabIndex = 2;
            button10.Text = "    Taches";
            button10.TextImageRelation = TextImageRelation.ImageBeforeText;
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Constantia", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ButtonHighlight;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.Location = new Point(0, 253);
            button9.Name = "button9";
            button9.Size = new Size(246, 68);
            button9.TabIndex = 3;
            button9.Text = "   Notes";
            button9.TextImageRelation = TextImageRelation.ImageBeforeText;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Constantia", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(0, 318);
            button8.Name = "button8";
            button8.Size = new Size(246, 68);
            button8.TabIndex = 4;
            button8.Text = "   Calendrier";
            button8.TextImageRelation = TextImageRelation.ImageBeforeText;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Constantia", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.GhostWhite;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(0, 383);
            button7.Name = "button7";
            button7.Size = new Size(246, 68);
            button7.TabIndex = 5;
            button7.Text = "Déconnexion";
            button7.TextImageRelation = TextImageRelation.ImageBeforeText;
            button7.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(117, 11, 83);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button9);
            panel3.Controls.Add(button10);
            panel3.Controls.Add(button11);
            panel3.Controls.Add(pictureBox3);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(249, 597);
            panel3.TabIndex = 4;
            panel3.Paint += panel3_Paint;
            // 
            // NotesForm
            // 
            ClientSize = new Size(1775, 597);
            Controls.Add(panel3);
            Controls.Add(headerPanel);
            Controls.Add(flowLayoutNotes);
            Name = "NotesForm";
            Text = "QuickMemo";
            WindowState = FormWindowState.Maximized;
            Load += NotesForm_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel panel1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Panel panel3;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


    }

        #endregion
    }
