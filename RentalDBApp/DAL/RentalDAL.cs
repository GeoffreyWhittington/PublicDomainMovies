using RentalDBApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalDBApp.DAL
{
    class RentalDAL
    {
        private static string _connectionString = "Data Source=198.209.220.125;Initial Catalog=teama;User ID=teama;Password=teama";
        public static List<Rental> getRental()
        {
            return null;
        }
        public static Rental getrental(int number)
        {
            return null;
        }
        public static bool addrental(Rental model)
        {
            bool successfullyAddedRental = false;
            SqlConnection connect = new SqlConnection(_connectionString);
            try
            {
                connect.Open();
                string sqlcode = "INSERT INTO RENTAL (movie_number, member_number, media_checkout, media_return_date) " +
                     "VALUES ('" + model.Movie_Number + "', '" + model.Member_Number+ "', '" + model.Media_Checkout + "', '" + model.Media_Return_Date + "')";
                SqlCommand sc = new SqlCommand(sqlcode, connect);
                sc.Connection = connect;
                sc.ExecuteNonQuery();
                successfullyAddedRental = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connect.Close();
            }
            return successfullyAddedRental;
        }

        public static void searchrental(string member_number)
        {
            SqlConnection connect = new SqlConnection(_connectionString);
            connect.Open();
            string query = "SELECT * FROM RENTAL WHERE Member_Number like '%" + member_number+ "%'";
            SqlCommand sc = new SqlCommand(query, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(sc);
            DataTable table = new DataTable();
            adapter.Fill(table);
            //genreDataGridView.DataSource = table;
        }
        
    }
}

//        public static bool UpdateRental(int id, Rental model)
//        {
//            bool successfullyUpdatedRental = false;
//            using (RentalDatabaseEntities context = new RentalDatabaseEntities())
//            {
//                var rentalToUpdate = context.Rentals.SingleOrDefault(movie => movie.movie_number == id);
//                try
//                {
//                    context.Database.Connection.Open();
//                    context.Rentals.Attach(rentalToUpdate);
//                    //NEED TO UPDATE
//                    context.SaveChanges();
//                    successfullyUpdatedRental = true;
//                }
//                catch (Exception ex)
//                {

//                }
//                finally
//                {
//                    context.Database.Connection.Close();
//                }
//            }
//            return successfullyUpdatedRental;
//        }
//        public static bool DeleteRental(int movieNumber, int memberNumber, DateTime mediaCheckoutDate)
//        {
//            bool successfullyDeletedRental = false;
//            using (RentalDatabaseEntities context = new RentalDatabaseEntities())
//            {
//                var rentalToDelete = context.Rentals.SingleOrDefault(rental => rental.movie_number == movieNumber && rental.member_number == memberNumber && rental.media_checkout_date == mediaCheckoutDate);
//                try
//                {
//                    context.Database.Connection.Open();
//                    context.Rentals.Remove(rentalToDelete);
//                    context.SaveChanges();
//                    successfullyDeletedRental = true;
//                }
//                catch (Exception ex)
//                {

//                }
//                finally
//                {
//                    context.Database.Connection.Close();
//                }
//            }
//            return successfullyDeletedRental;
//        }
//    }
//}

//}
