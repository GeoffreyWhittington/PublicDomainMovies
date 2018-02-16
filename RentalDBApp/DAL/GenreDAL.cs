using RentalDBApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace RentalDBApp.DAL
{
    public static class GenreDAL
    {
        private static string _connectionString = "Data Source=LENOVO-PC\\SQLEXPRESS;Integrated Security=True";
        public static List<GENRE> getGenres()
        {
            MovieDatabase db = new MovieDatabase();
            var rows = db.GENREs.ToList();
            return rows;
        }
        //
        public static Genre getgenre(int id)
        {
            //DEFINE VARIABLE CALLED GENRE
            Genre mygenre = new Genre();
            return null;
            //RETURN VARIABLE OF GENRE TYPE
            //RETURN VARIABLE CALLED MYGENRE
        }
        //addgenre method hides code
        public static bool addgenre(Genre model)
        {
            bool successfullyAddedGenre = false;
            //MovieDatabase db = new MovieDatabase();
            //db.MEMBERs.Add(model);
            //db.SaveChanges();
            SqlConnection connect = new SqlConnection(_connectionString);
            try
            {
                connect.Open();
                string sqlcode = "INSERT INTO GENRE (name) " +
                     "VALUES ('" + model.Name + "')";
                SqlCommand sc = new SqlCommand(sqlcode, connect);
                sc.Connection = connect;
                sc.ExecuteNonQuery();
                successfullyAddedGenre = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connect.Close();
            }
            return successfullyAddedGenre;
        }
        public static List<GENRE> browsegenre(string genre)
        {
            MovieDatabase db = new MovieDatabase();
            var rows = db.GENREs.Where(row => row.name.ToLower().Contains(genre.ToLower())).ToList();
            return rows;
           
        }
        public static bool DeleteGenre(int id)
        {
            bool successfullyDeletedGenre = false;
            using (MovieDatabase database = new MovieDatabase())
            {
               
                try
                {
                    //DOESN'T DELETE
                    var genreToDelete = database.GENREs.Where(genre => genre.id == id).FirstOrDefault();
                    database.GENREs.Remove(genreToDelete);
                    database.SaveChanges();
                    successfullyDeletedGenre = true;
                }
                catch (Exception ex)
                {

                }
               
            }
            return successfullyDeletedGenre;
        }
        public static bool UpdateGenre(int id, GENRE genre)
        {
            bool successfullyUpdatedMember = false;
            using (MovieDatabase context = new MovieDatabase())
            {
                var genreToUpdate = context.GENREs.SingleOrDefault(row => row.id == id);
                try
                {
                    context.Database.Connection.Open();
                    context.GENREs.Attach(genreToUpdate);
                    genreToUpdate = genre;
                    context.SaveChanges();
                    successfullyUpdatedMember = true;
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    context.Database.Connection.Close();
                }
            }
            return successfullyUpdatedMember;
        }
    public static bool AddGenre(GENRE genre)
        {
            bool successfullyAddedGenre = false;
            using (MovieDatabase context = new MovieDatabase())
            {
                try
                {
                    context.Database.Connection.Open();
                    context.GENREs.Add(genre);
                    context.SaveChanges();
                    successfullyAddedGenre = true;
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    context.Database.Connection.Close();
                }
            }
            return successfullyAddedGenre;
        }



        //    public static bool updategenre(int id, genre model)
        //    {
        //        bool successfullyupdatedgenre = false;
        //        using (rentaldatabaseentities context = new rentaldatabaseentities())
        //        {
        //            var genretoupdate = context.genres.singleordefault(genre => genre.id == id);
        //            try
        //            {
        //                context.database.connection.open();
        //                context.genres.attach(genretoupdate);
        //                //need to update
        //                context.savechanges();
        //                successfullyupdatedgenre = true;
        //            }
        //            catch (exception ex)
        //            {

        //            }
        //            finally
        //            {
        //                context.database.connection.close();
        //            }
        //        }
        //        return successfullyupdatedgenre;
        //    }
        //    public static bool deletegenre(int id)
        //    {
        //        bool successfullydeletedgenre = false;
        //        using (rentaldatabaseentities context = new rentaldatabaseentities())
        //        {
        //            var genretodelete = context.genres.singleordefault(genre => genre.id == id);
        //            try
        //            {
        //                context.database.connection.open();
        //                context.genres.remove(genretodelete);
        //                context.savechanges();
        //                successfullydeletedgenre = true;
        //            }
        //            catch (exception ex)
        //            {

        //            }
        //            finally
        //            {
        //                context.database.connection.close();
        //            }
        //        }
        //        return successfullydeletedgenre;
        //    }
        //}
    }
}
