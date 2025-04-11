using quickmimo.context;
using quickmimo.Entities;
using quickmimo.Repositories;
using quickmimo.Services;

namespace quickmimo
{
    public partial class login : Form
    {
        static DBMimoContext dbContext = new DBMimoContext(); // configure la chaîne de connexion dans appsettings ou constructeur
        UserRepository userRepo = new UserRepository(dbContext);
        public UserService userService = new UserService();
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            inscription inscriptionForm = new inscription(); // Crée une nouvelle instance de la fenêtre AccueilForm
            inscriptionForm.Show(); // Affiche la fenêtre AccueilForm

            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtmail.Text.Length == 0 ||
               txtPassword.Text.Length == 0
               )
            {
                MessageBox.Show("Veuiller remplir tous les champs ");
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
                    string email = txtmail.Text;
                    string password = txtPassword.Text;
                    var founduser = userRepo.GetUserByEmail(email);
                    if (founduser != null)
                    {
                        if (userService.VerifyPassword(password,founduser.password))
                        {
                            UserSession user = new UserSession(founduser);
                            listeTaches dashboardForm = new listeTaches(); // Crée une nouvelle instance de la fenêtre AccueilForm
                            dashboardForm.Show(); // Affiche la fenêtre AccueilForm

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Mot de passe incorrecte!");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Vous n'avez pas de compte,s'il vous plais crées un");

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
        
}
