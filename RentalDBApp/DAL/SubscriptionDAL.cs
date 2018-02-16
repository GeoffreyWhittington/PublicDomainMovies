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
    class SubscriptionDAL
    {
        private static string _connectionString = "Data Source=198.209.220.125;Initial Catalog=teama;User ID=teama;Password=teama";
        public static List<Subscription> getSubscription()
        {
            return null;
        }
        public static Subscription getsubscription(int number)
        {
            return null;
        }
        public static bool addsubscription(Subscription model)
        {
            bool successfullyAddedSubscription = false;
            SqlConnection connect = new SqlConnection(_connectionString);
            try
            {
                connect.Open();
                string sqlcode = "INSERT INTO SUBSCRIPTION (id,name,cost) " +
                     "VALUES ('" + model.Name + "', '" + model.Cost + "')";
                SqlCommand sc = new SqlCommand(sqlcode, connect);
                sc.Connection = connect;
                sc.ExecuteNonQuery();
                successfullyAddedSubscription = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connect.Close();
            }
            return successfullyAddedSubscription;
        }

        public static void searchsubscription(string name)
        {
            SqlConnection connect = new SqlConnection(_connectionString);
            connect.Open();
            string query = "SELECT * FROM SUBSCRIPTION WHERE Name like '%" + name + "%'";
            SqlCommand sc = new SqlCommand(query, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(sc);
            DataTable table = new DataTable();
            adapter.Fill(table);
            //genreDataGridView.DataSource = table;
        }

    }
}

//        public static bool UpdateSubscription(int id, Subscription model)
//        {
//            bool successfullyAddedSubscription = false;
//            using (RentalDatabaseEntities context = new RentalDatabaseEntities())
//            {
//                var movieToUpdate = context.Movies.SingleOrDefault(movie => movie.movie_number == id);
//                try
//                {
//                    context.Database.Connection.Open();
//                    context.Movies.Attach(movieToUpdate);
//                    //NEED TO UPDATE
//                    context.SaveChanges();
//                    successfullyAddedSubscription = true;
//                }
//                catch (Exception ex)
//                {

//                }
//                finally
//                {
//                    context.Database.Connection.Close();
//                }
//            }
//            return successfullyAddedSubscription;
//        }
//        public static bool DeleteSubscription(int id)
//        {
//            bool successfullyDeletedSubscription = false;
//            using (RentalDatabaseEntities context = new RentalDatabaseEntities())
//            {
//                var subscriptionToDelete = context.Subscriptions.SingleOrDefault(subscription => subscription.id == id);
//                try
//                {
//                    context.Database.Connection.Open();
//                    context.Subscriptions.Remove(subscriptionToDelete);
//                    context.SaveChanges();
//                    successfullyDeletedSubscription = true;
//                }
//                catch (Exception ex)
//                {

//                }
//                finally
//                {
//                    context.Database.Connection.Close();
//                }
//            }
//            return successfullyDeletedSubscription;
//        }
//    }
//}

//}
