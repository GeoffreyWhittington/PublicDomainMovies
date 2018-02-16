﻿using RentalDBApp.DAL;
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
    public partial class MovieAccessForm : Form
    {
        public MovieAccessForm()
        {
            InitializeComponent();
        }

        private void MovieAccessForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teamaDataSet1.MOVIE' table. You can move, or remove it, as needed.
            //this.mOVIETableAdapter.Fill(this.teamaDataSet1.MOVIE);
            DataGridViewLinkColumn col = new DataGridViewLinkColumn();
            col.DataPropertyName = "movie_title";
            col.Name = "movie_title_link";
            movieAccessFormDataGridView.Columns.Insert(0, col);
            var movieTitles = MovieDAL.getmovieS();
            movieAccessFormDataGridView.DataSource = movieTitles;
            movieAccessFormDataGridView.ClearSelection();
        }
            





        private void movieAccessFormDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int position = e.RowIndex;
            MOVIE value = (MOVIE)movieAccessFormDataGridView.Rows[position].DataBoundItem;
            try
            {
                System.Diagnostics.Process.Start(value.movie_title_link);
            }
            catch
            {

            }
        }
        }
}

           
//2. I will use only what I have, columns, rows, e object in the click function, to achieve this.

//Regarding #2, you want to look at defining your list of movies in the class (MovieAccessForm),
//so that you can ALSO use IT in the function! 
//Without that, you're right, those are the only things you have access to in that function.