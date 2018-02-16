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
    class VendorDAL
    {
        private static string _connectionString = "Data Source=198.209.220.125;Initial Catalog=teama;User ID=teama;Password=teama";
        public static List<Vendor> getVendor()
        {
            return null;
        }
        public static Vendor getsubscription(int number)
        {
            return null;
        }
        public static bool addvendor(Vendor model)
        {
            bool successfullyAddedVendor = false;
            SqlConnection connect = new SqlConnection(_connectionString);
            try
            {
                connect.Open();
                string sqlcode = "INSERT INTO VENDOR (vendor_name,vendor_rep,vendor_rep_email,vendor_rep_phone) " +
                     "VALUES ('" + model.Vendor_Name + "', '" + model.Vendor_Rep + "', '" + model.Vendor_Rep_Email + "', '" + model.Vendor_Rep_Phone + "')";
                SqlCommand sc = new SqlCommand(sqlcode, connect);
                sc.Connection = connect;
                sc.ExecuteNonQuery();
                successfullyAddedVendor= true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connect.Close();
            }
            return successfullyAddedVendor;
        }

        public static void searchvendor(string vendor_name)
        {
            SqlConnection connect = new SqlConnection(_connectionString);
            connect.Open();
            string query = "SELECT * FROM VENDOR WHERE Name like '%" + vendor_name + "%'";
            SqlCommand sc = new SqlCommand(query, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(sc);
            DataTable table = new DataTable();
            adapter.Fill(table);
            //genreDataGridView.DataSource = table;
        }

    }
}
