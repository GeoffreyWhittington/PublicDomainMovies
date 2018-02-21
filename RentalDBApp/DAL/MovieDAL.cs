using RentalDBApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace RentalDBApp.DAL
{
    class MovieDAL
    { 
        private static string _connectionString = "Data Source=198.209.220.125;Initial Catalog=teama;User ID=teama;Password=teama";
        public static List<Movie> getmovie()
        {
            return null;
        }
        
        public static Movie getmovie(int number)
        {
            return null;
        }
        public static bool addmovie(Movie model)
        {
            bool successfullyAddedMovie = false;
            SqlConnection connect = new SqlConnection(_connectionString);
            try
            {
                connect.Open();
                string sqlcode = "INSERT INTO MOVIE (movie_title, description, movie_year_made, genre_id, movie_rating, movie_title_link) " +
                     "VALUES ('" + model.Movie_Title + "', '" + model.Description + "', '" + model.Movie_Year_Made + "', '" + model.Genre_Id + "', '" + model.Movie_Rating + "', '" + model.Movie_Title_Link + "')";
                SqlCommand sc = new SqlCommand(sqlcode, connect);
                sc.Connection = connect;
                sc.ExecuteNonQuery();
                successfullyAddedMovie = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connect.Close();
            }
            return successfullyAddedMovie;
        }

        public static List<MOVIE> getmovieS()
        {
            MovieDatabase db = new MovieDatabase();
            var rows = db.MOVIEs.ToList();
            return rows;

        }

        public static List<MOVIE> browsemovie(string movie)
        {
            MovieDatabase db = new MovieDatabase();
            var rows = db.MOVIEs.Where(row => row.movie_title.ToLower().Contains(movie.ToLower())).ToList();
            return rows;
        }

        internal static void searchMovie(string movie_Title, object genre_Id)
        {
            throw new NotImplementedException();
        }

        public static void searchMovie(string movie_title)
        {
            SqlConnection connect = new SqlConnection(_connectionString);
            connect.Open();
            string query = "SELECT * FROM MOVIE WHERE Movie_Title like '%" + movie_title + "%'";
            SqlCommand sc = new SqlCommand(query, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(sc);
            DataTable table = new DataTable();
            adapter.Fill(table);
            
        }
        public static void searchMovie_Id(int movie_id)
        {
            SqlConnection connect = new SqlConnection(_connectionString);
            connect.Open();
            string query = "SELECT * FROM MOVIE WHERE Movie_Id like '%" +movie_id + "%'";
            SqlCommand sc = new SqlCommand(query, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(sc);
            DataTable table = new DataTable();
            adapter.Fill(table);
            //genreDataGridView.DataSource = table;
        }
    }
}

//        public static bool UpdateMovie(int id, Movie model)
//        {
//            bool successfullyUpdatedMovie = false;
//            using (RentalDatabaseEntities context = new RentalDatabaseEntities())
//            {
//                var movieToUpdate = context.Movies.SingleOrDefault(movie => movie.movie_number == id);
//                try
//                {
//                    context.Database.Connection.Open();
//                    context.Movies.Attach(movieToUpdate);
//                    //NEED TO UPDATE
//                    context.SaveChanges();
//                    successfullyUpdatedMovie = true;
//                }
//                catch (Exception ex)
//                {

//                }
//                finally
//                {
//                    context.Database.Connection.Close();
//                }
//            }
//            return successfullyUpdatedMovie;
//        }
//        public static bool DeleteMovie(int id)
//        {
//            bool successfullyDeletedMovie = false;
//            using (RentalDatabaseEntities context = new RentalDatabaseEntities())
//            {
//                var movieToDelete = context.Movies.SingleOrDefault(movie => movie.movie_number == id);
//                try
//                {
//                    context.Database.Connection.Open();
//                    context.Movies.Remove(movieToDelete);
//                    context.SaveChanges();
//                    successfullyDeletedMovie = true;
//                }
//                catch (Exception ex)
//                {

//                }
//                finally
//                {
//                    context.Database.Connection.Close();
//                }
//            }
//            return successfullyDeletedMovie;
//        }





//    }
//}
//}
