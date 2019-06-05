using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleApp.Models;
using MVCSampleApp.ViewModels;

namespace MVCSampleApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (NewsletterEntities db = new NewsletterEntities())
                {
                    var signup = new SignUp
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        EmailAddress = emailAddress
                    };

                    db.SignUps.Add(signup);
                    db.SaveChanges();
                }
                return View("Success");

                //string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress) VALUES (@FirstName, @LastName, @EmailAddress)";

                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{
                //    SqlCommand command = new SqlCommand(queryString, connection);
                //    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                //    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                //    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);

                //    command.Parameters["@FirstName"].Value = firstName;
                //    command.Parameters["@LastName"].Value = lastName;
                //    command.Parameters["@EmailAddress"].Value = emailAddress;

                //    connection.Open();
                //    command.ExecuteNonQuery();
                //    connection.Close();
                //}
            }
        }

        //public ActionResult Admin()
        //{


        //string queryString = @"select Id, FirstName, LastName, EmailAddress, SocialSecurity from SignUps";
        //List<NewsletterSignUp> signups = new List<NewsletterSignUp>();

        //using (SqlConnection connection = new SqlConnection(connectionString))
        //{
        //    SqlCommand command = new SqlCommand(queryString, connection);
        //    connection.Open();
        //    SqlDataReader reader = command.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        var signup = new NewsletterSignUp
        //        {
        //            Id = Convert.ToInt32(reader["Id"]),
        //            FirstName = reader["FirstName"].ToString(),
        //            LastName = reader["LastName"].ToString(),
        //            EmailAddress = reader["EmailAddress"].ToString(),
        //            SocialSecurity = reader["SocialSecurity"].ToString()
        //        };

        //        signups.Add(signup);
        //    }
        //}
        //var signupVms = new List<SignUpVm>();
        //foreach (var signup in signups)
        //{
        //    var signupVm = new SignUpVm
        //    {
        //        FirstName = signup.FirstName,
        //        LastName = signup.LastName,
        //        EmailAddress = signup.EmailAddress
        //    };
        //    signupVms.Add(signupVm);
        //}

        //return View(signupVms);
        //}
    }
}