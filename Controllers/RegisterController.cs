using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Mvc;
using MySql.Data.MySqlClient;
using RegistrationForm.Models;
using System.Web.Services.Description;

namespace RegistrationForm.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Register rg)
        {
            MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            string sqlquery = "Insert into UserReg (UserName, Age, Email, UserPassword, Phone, Gender, Status) values(@name,@age,@email,@pass,@phone,@gender,@status)";
            MySqlCommand cmd = new MySqlCommand(sqlquery, con);
            con.Open();
            cmd.Parameters.AddWithValue("@name", rg.Username);
            cmd.Parameters.AddWithValue("@age", rg.Age);
            cmd.Parameters.AddWithValue("@email", rg.Email);
            cmd.Parameters.AddWithValue("@pass", rg.Password);
            cmd.Parameters.AddWithValue("@phone", rg.Phone);
            cmd.Parameters.AddWithValue("@gender", rg.Gender);
            cmd.Parameters.AddWithValue("@status", rg.Status);
            cmd.ExecuteNonQuery();
            ViewData["Message"] = "Record Inserted !!";
            con.Close();
            return View();            
        }
    }
}