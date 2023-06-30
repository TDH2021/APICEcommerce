using APICEcommerce.App_Code;
using APICEcommerce.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APICEcommerce.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            if (Session["UserID"] != null)
            {
                if (String.IsNullOrEmpty(Session["UserID"].ToString()) == true)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    //ClsSession.CompanyID = int.Parse(Session["CompanyId"].ToString());
                    //ClsSession.UserID = int.Parse(Session["UserID"].ToString());
                    //ClsSession.EmpId = int.Parse(Session["EmpId"].ToString());
                    //ClsSession.BranchId = int.Parse(Session["BranchId"].ToString());
                    //ClsSession.RoleID = int.Parse(Session["RoleId"].ToString());
                   
                    return View();

                }
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}