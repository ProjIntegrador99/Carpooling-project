using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Login.Models;
using System.Data.SqlClient;

namespace Login.Controllers
{
    public class AccountController : Controller
    {

		SqlConnection conection = new SqlConnection();
		SqlCommand comand = new SqlCommand();
		SqlDataReader reader;

        // GET: Account
		[HttpGet]
        public ActionResult Login()
        {
            return View();
        }

		void conecctionString()
		{
			conection.ConnectionString = "data source= (localdb)\\mssqllocaldb; database= Accounts; integrated security = SSPI;";
		}

		[HttpPost]
		public ActionResult Verify(Account acount)
		{
			conecctionString();
			conection.Open();
			comand.Connection = conection;
			comand.CommandText = "select * from Accounts where email= '"+ acount.Email + "' and password = '"+ acount.Password + "'";
			reader = comand.ExecuteReader();

			if (reader.Read())
			{
				conection.Close();
				return View("Menu");
			}
			else
			{
				conection.Close();
				return View("Error");
			}

			
		}
    }
}