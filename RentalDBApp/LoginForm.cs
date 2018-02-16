using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (loginMatch == true)
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
    }
}
