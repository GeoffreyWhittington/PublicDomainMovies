using System;
using System.Windows.Forms;
using RentalDBApp.DAL;


namespace RentalDBApp
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            
            var movieTitles = MovieDAL.getmovieS();
            mainMenuDataGridView.DataSource = movieTitles;
            mainMenuDataGridView.ClearSelection();

        }

           

        private void signUpButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            var signUpForm = new signUpForm();
            signUpForm.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private void mainMenuDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
           



            
