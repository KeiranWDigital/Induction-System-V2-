using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
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
            
            return View();
        }
    }
}