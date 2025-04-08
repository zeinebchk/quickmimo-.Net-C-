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
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(196, 662);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(334, 25);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Vous avez pas un compte ? Se connecter\r\n";
            // 
            // btnInscri
            // 
            btnInscri.BackColor = Color.FromArgb(255, 128, 128);
            btnInscri.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInscri.Location = new Point(237, 566);
            btnInscri.Name = "btnInscri";
            btnInscri.Size = new Size(201, 52);
            btnInscri.TabIndex = 9;
            btnInscri.Text = "S'inscrire";
            btnInscri.UseVisualStyleBackColor = false;
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
            label1.Font = new Font("Segoe Script", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 30);
            label1.Name = "label1";
            label1.Size = new Size(540, 114);
            label1.TabIndex = 6;
            label1.Text = "QUICK MIMO";
            // 
            // txtemail
            // 
            this.txtemail.BackColor = Color.FromArgb(255, 255, 192);
            this.txtemail.BorderStyle = BorderStyle.FixedSingle;
            this.txtemail.Font = new Font("Times New Roman", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            this.txtemail.Location = new Point(206, 291);
            this.txtemail.Name = "txtemail";
            this.txtemail.PlaceholderText = "Email";
            this.txtemail.Size = new Size(300, 33);
            this.txtemail.TabIndex = 12;
            // 
            // txtnumTel
            // 
            this.txtnumTel.BackColor = Color.FromArgb(255, 255, 192);
            this.txtnumTel.BorderStyle = BorderStyle.FixedSingle;
            this.txtnumTel.Font = new Font("Times New Roman", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            this.txtnumTel.Location = new Point(206, 354);
            this.txtnumTel.Name = "txtnumTel";
            this.txtnumTel.PlaceholderText = "NUméro de Tèl";
            this.txtnumTel.Size = new Size(300, 33);
            this.txtnumTel.TabIndex = 13;
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
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 255, 192);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Times New Roman", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(206, 483);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Mot de passe";
            textBox1.Size = new Size(300, 33);
            textBox1.TabIndex = 17;
            // 
            // inscription
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(723, 719);
            Controls.Add(textBox1);
            Controls.Add(txtProffession);
            Controls.Add(txtnom);
            Controls.Add(this.txtnumTel);
            Controls.Add(this.txtemail);
            Controls.Add(linkLabel1);
            Controls.Add(btnInscri);
            Controls.Add(txtprenom);
            Controls.Add(label1);
            Name = "inscription";
            Text = "inscription";
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
        private TextBox textBox1;
    }
}