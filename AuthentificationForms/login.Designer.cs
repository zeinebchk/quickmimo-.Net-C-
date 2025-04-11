namespace quickmimo
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            label1 = new Label();
            txtmail = new TextBox();
            txtPassword = new TextBox();
            btnlogin = new Button();
            linkLabel1 = new LinkLabel();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(179, 54);
            label1.Name = "label1";
            label1.Size = new Size(540, 114);
            label1.TabIndex = 0;
            label1.Text = "QUICK MIMO";
            label1.Click += label1_Click;
            // 
            // txtmail
            // 
            txtmail.BackColor = Color.FromArgb(255, 255, 192);
            txtmail.BorderStyle = BorderStyle.FixedSingle;
            txtmail.Font = new Font("Times New Roman", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtmail.Location = new Point(340, 230);
            txtmail.Name = "txtmail";
            txtmail.PlaceholderText = "Email";
            txtmail.Size = new Size(300, 33);
            txtmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(255, 255, 192);
            txtPassword.Font = new Font("Times New Roman", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(340, 296);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Mot de passe";
            txtPassword.Size = new Size(300, 33);
            txtPassword.TabIndex = 2;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(255, 128, 128);
            btnlogin.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.Location = new Point(355, 357);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(201, 52);
            btnlogin.TabIndex = 3;
            btnlogin.Text = "Se connecter";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(315, 431);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(310, 25);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Vous n'avez pas un compte ? S'inscire\r\n";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "note-collante-removebg-preview.png");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.note_collante_removebg_preview;
            pictureBox1.Location = new Point(112, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.note_collante_removebg_preview;
            pictureBox2.Location = new Point(737, 76);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(969, 573);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(btnlogin);
            Controls.Add(txtPassword);
            Controls.Add(txtmail);
            Controls.Add(label1);
            Name = "login";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtmail;
        private TextBox txtPassword;
        private Button btnlogin;
        private LinkLabel linkLabel1;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
