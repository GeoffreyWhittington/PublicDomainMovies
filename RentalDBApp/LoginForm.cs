using System;
using System.Windows.Forms;

namespace RentalDBApp
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
         
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pword = passwordTextBox.Text;
            string email = emailTextBox.Text;
            bool loginMatch = DAL.MemberDAL.searchLoginMatch(pword, email);
            if (emailTextBox.Text == "")
                {
                 MessageBox.Show("EMAIL REQUIRED");
                 emailTextBox.Focus();  
                }
                else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("PASSWORD REQUIRED");
                passwordTextBox.Focus();
            }
            else if (loginMatch == true)
            {
                MessageBox.Show("MEMBER LOGGED IN");
                Visible = false;
                var movieAccesForm = new MovieAccessForm();
                movieAccesForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("TRY AGAIN");
                emailTextBox.Clear();
                passwordTextBox.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var newMainMenuForm = new MainMenuForm();
            newMainMenuForm.Show();
        }
    }
}
            
                
                
