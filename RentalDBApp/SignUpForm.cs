using RentalDBApp.DAL;
using RentalDBApp.Models;
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
    public partial class signUpForm : Form
    {

        public signUpForm()
        {
            InitializeComponent();
        }

        public object MemberBindingSource { get; private set; }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            var first_name = firstNameTextBox.Text;
            var last_name = lastNameTextBox.Text;
            var pass_word = passwordTextBox.Text;
            var email_contact = emailTextBox.Text;
            MEMBER model = new MEMBER
            {
                first_name = first_name,
                last_name = last_name,
                pass_word = pass_word,
                email_contact = email_contact
            };
            MemberDAL.addmember(model);
            MessageBox.Show("Member Successfully Added.");
            this.Hide();
            var newLogInForm = new LoginForm();
            newLogInForm.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
       
    }

