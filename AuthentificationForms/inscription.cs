using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using quickmimo.context;
using quickmimo.Entities;
using quickmimo.Repositories;
using quickmimo.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace quickmimo
{
    public partial class inscription : Form
    {
        static DBMimoContext dbContext = new DBMimoContext(); // configure la chaîne de connexion dans appsettings ou constructeur
        UserRepository userRepo = new UserRepository(dbContext);
       public UserService userService = new UserService();
        public inscription()
        {

            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInscri_Click(object sender, EventArgs e)
        {
            if (txtmail.Text.Length == 0 ||
                txtnom.Text.Length == 0 ||
                txtprenom.Text.Length == 0 ||
                txtnum.Text.Length == 0 ||
                txtProffession.Text.Length == 0 ||
                txtPassword.Text.Length == 0
                )
            {
                MessageBox.Show("Veuiller remplir tous les champs ");
                return;
            }
            else if (!userService.validateNumTel(txtnum.Text))
            {
                MessageBox.Show("Veuiller saisir un numero de téléphone valide ");
                return;
            }
            else if (!userService.validateEmail(txtmail.Text))
            {
                MessageBox.Show("Veuiller saisir un email  valide ");
                return;
            }
            else if (!userService.validatePassword(txtPassword.Text))
            {
                MessageBox.Show("le mot d epasse doit contenir des chiffres et au moins une lettre majuscules ");
                return;
            }
            else
            {
                try
                {
                    string firstname = txtnom.Text;
                    string lastname = txtprenom.Text;
                    int telNumber = int.Parse(txtnum.Text);
                    string email = txtmail.Text;
                    string password = txtPassword.Text;
                    string proffession = txtProffession.Text;
                    var founduser = userRepo.GetUserByEmail(email);
                    if (founduser != null)
                    {
                        MessageBox.Show("Utilisateur existz deja !");
                        return;

                    }
                    else
                    {
                        string hashedPWD = userService.HashPassword(password);
                        User user = new User(firstname, lastname, telNumber, email, hashedPWD, proffession);
                        userRepo.Add(user);
                        var addedUser = userRepo.GetUserByEmail(email); // Chercher l'utilisateur par email
                        if (addedUser != null)
                        {
                            MessageBox.Show("Utilisateur ajouté avec succès !");
                            login loginForm = new login(); // Crée une nouvelle instance de la fenêtre AccueilForm
                            loginForm.Show(); // Affiche la fenêtre AccueilForm

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Erreur d'ajout de l'utilisateur.");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

     

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            login loginForm = new login(); // Crée une nouvelle instance de la fenêtre AccueilForm
            loginForm.Show(); // Affiche la fenêtre AccueilForm

            this.Hide();
        }

        private void inscription_Load(object sender, EventArgs e)
        {

        }
    }
}
