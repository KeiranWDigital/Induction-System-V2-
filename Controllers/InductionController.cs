using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class InductionController : Controller
    {
        // GET: Induction
        public ActionResult Index()
        {

            return View();
        }

        // GET: NewInduction
        public ActionResult NewInduction()
        {

            return View();
        }

        [HttpPost]
        public ActionResult NewInduction(InductionModel Induction)
        { int InductionID = Induction.ID;
            String InductionName = Induction.Name;
            String InductionDescription = Induction.Description;
            AddInduction(Induction);
            return View();
        }

        private SqlConnection con;
        //To Handle connection related activities
        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConnStringDb1"].ToString();
            con = new SqlConnection(constr);

        }
      

    

        //To Add Employee details
        public bool AddInduction(InductionModel obj)
        {

            connection();
            SqlCommand com = new SqlCommand("InductionCreate", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Name", obj.Name);
            com.Parameters.AddWithValue("@Description", obj.Description);
            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
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