using RentalDBApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalDBApp.DAL
{
    public static class MemberDAL
    {
       // private static string _connectionString = "Data Source=198.209.220.125;Initial Catalog=teama;User ID=teama;Password=teama";
        public static List<Member> getmember()
        {
            return null;
        }
        public static Member getmember(int number)
        {
            return null;
        }

        public static void addmember(MEMBER model)
        {
            MovieDatabase db = new MovieDatabase();
            try
            {
                db.MEMBERs.Add(model);
                db.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        internal static void searchMember(string last_Name)
        {
            throw new NotImplementedException();
        }

        public static bool searchLoginMatch(string pass_word, string email_contact)
        {
            //email and password match?
            MovieDatabase db = new MovieDatabase();
            var rows = db.MEMBERs
                .Where(row => row.pass_word == pass_word && row.email_contact == email_contact)
                .ToList();
            int numberRows = rows.Count;
            if (numberRows == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}


       

