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
    public partial class RentalForm : Form
    {
        public int Member_Number { get; private set; }
        public RentalForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var member_number = memberTextBox.Text;
            //var id = idTextBox.Text;
            Rental model = new Rental
            {
                Member_Number = int.Parse(member_number)
            };
            bool success = RentalDAL.addrental(model);
           // MessageBox.Show("Genre successfully added.");
            //  MESSAGE BOX HERE DEPENDENT ON SUCCESS
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            Member_Number = int.Parse(memberTextBox.Text);
            RentalDAL.searchrental(Member_Number.ToString());
         }
    }
}
