using System;
using System.Windows.Forms;
using RentalDBApp.DAL;
using System.Collections.Generic;

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
            mainMenuDataGridView.DefaultCellStyle.SelectionBackColor = mainMenuDataGridView.DefaultCellStyle.BackColor;
            mainMenuDataGridView.DefaultCellStyle.SelectionForeColor = mainMenuDataGridView.DefaultCellStyle.ForeColor;
            try
            {
                List<MOVIE> movieTitles = MovieDAL.getmovieS();
                mainMenuDataGridView.DataSource = movieTitles;
            }


            catch (Exception ex)
            {
                MessageBox.Show("Movie load failed.");
                //this.Close();
                //Application.Run(new MainMenuForm());
            }

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
           



            
