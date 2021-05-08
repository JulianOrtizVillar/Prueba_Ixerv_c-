using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginJulianOrtiz.Models;
using System.Data.SqlClient;


namespace LoginJulianOrtiz.Controllers
{
    
    public class AccountController : Controller
    {
        SqlDataReader dr;
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        // GET: Account

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        void connectionString() 
        {
            con.ConnectionString = "data source=JULIANORTIZ; database=LogginJulian; integrated security =SSPI;";
        }

        public ActionResult Verify(Account acc) 
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from tbl_login where username='"+acc.Name+"' and password='"+acc.Password+"'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return View();
            }

            else
            {
                con.Close();
                return View();
            }
            
            
        }
    }
}