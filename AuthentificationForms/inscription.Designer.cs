


namespace quickmimo
{
    partial class inscription
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
            linkLabel1 = new LinkLabel();
            btnInscri = new Button();
            txtprenom = new TextBox();
            label1 = new Label();
            txtnom = new TextBox();
            txtProffession = new TextBox();
            txtPassword = new TextBox();
            txtnum = new TextBox();
            txtmail = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(172, 672);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(334, 25);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Vous avez pas un compte ? Se connecter\r\n";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnInscri
            // 
            btnInscri.BackColor = Color.FromArgb(255, 128, 128);
            btnInscri.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInscri.Location = new Point(226, 568);
            btnInscri.Name = "btnInscri";
            btnInscri.Size = new Size(201, 52);
            btnInscri.TabIndex = 9;
            btnInscri.Text = "S'inscrire";
            btnInscri.UseVisualStyleBackColor = false;
            btnInscri.Click += btnInscri_Click;
            // 
            // txtprenom
            // 
            txtprenom.BackColor = Color.FromArgb(255, 255, 192);
            txtprenom.BorderStyle = BorderStyle.FixedSingle;
            txtprenom.Font = new Font("Times New Roman", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtprenom.Location = new Point(206, 226);
            txtprenom.Name = "txtprenom";
            txtprenom.PlaceholderText = "Prénom";
            txtprenom.Size = new Size(300, 33);
            txtprenom.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 28F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(136, 38);
            label1.Name = "label1";
            label1.Size = new Size(420, 89);
            label1.TabIndex = 6;
            label1.Text = "QUICK MIMO";
            // 
            // txtnom
            // 
            txtnom.BackColor = Color.FromArgb(255, 255, 192);
            txtnom.BorderStyle = BorderStyle.FixedSingle;
            txtnom.Font = new Font("Times New Roman", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtnom.Location = new Point(206, 165);
            txtnom.Name = "txtnom";
            txtnom.PlaceholderText = "Nom";
            txtnom.Size = new Size(300, 33);
            txtnom.TabIndex = 14;
            txtnom.TextChanged += textBox4_TextChanged;
            // 
            // txtProffession
            // 
            txtProffession.BackColor = Color.FromArgb(255, 255, 192);
            txtProffession.BorderStyle = BorderStyle.FixedSingle;
            txtProffession.Font = new Font("Times New Roman", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtProffession.Location = new Point(206, 419);
            txtProffession.Name = "txtProffession";
            txtProffession.PlaceholderText = "Proffession";
            txtProffession.Size = new Size(300, 33);
            txtProffession.TabIndex = 16;
            txtProffession.TextChanged += textBox6_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(255, 255, 192);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Times New Roman", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPassword.HideSelection = false;
            txtPassword.Location = new Point(206, 483);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Mot de passe";
            txtPassword.Size = new Size(300, 33);
            txtPassword.TabIndex = 17;
            // 
            // txtnum
            // 
            txtnum.BackColor = Color.FromArgb(255, 255, 192);
            txtnum.BorderStyle = BorderStyle.FixedSingle;
            txtnum.Font = new Font("Times New Roman", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtnum.Location = new Point(206, 353);
            txtnum.Name = "txtnum";
            txtnum.PlaceholderText = "Numéro de téléphone";
            txtnum.Size = new Size(300, 33);
            txtnum.TabIndex = 18;
            // 
            // txtmail
            // 
            txtmail.BackColor = Color.FromArgb(255, 255, 192);
            txtmail.BorderStyle = BorderStyle.FixedSingle;
            txtmail.Font = new Font("Times New Roman", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtmail.Location = new Point(206, 288);
            txtmail.Name = "txtmail";
            txtmail.PlaceholderText = "email";
            txtmail.Size = new Size(300, 33);
            txtmail.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.note_collante_removebg_preview;
            pictureBox1.Location = new Point(67, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.note_collante_removebg_preview;
            pictureBox2.Location = new Point(562, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // inscription
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(703, 773);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtmail);
            Controls.Add(txtnum);
            Controls.Add(txtPassword);
            Controls.Add(txtProffession);
            Controls.Add(txtnom);
            Controls.Add(linkLabel1);
            Controls.Add(btnInscri);
            Controls.Add(txtprenom);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "inscription";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "inscription";
            WindowState = FormWindowState.Maximized;
            Load += inscription_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel linkLabel1;
        private Button btnInscri;
        private TextBox txtprenom;
        private Label label1;
        private TextBox txtemail;
        private TextBox txtnumTel;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox txtnom;
        private TextBox textBox5;
        private TextBox txtProffession;
        private TextBox txtPassword;
        private TextBox txtnum;
        private TextBox txtmail;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}