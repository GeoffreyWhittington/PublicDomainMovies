using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            //DAL TO PULL LIST OF MOVIE TITLES
            //GET WHAT I WANT

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
    }
}
