using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hotbuns.Controllers;

namespace Hotbuns.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Cookies()
        {
            return View();
        }

        public ActionResult OrderAndDelivery()
        {
            return View();
        }


        public ActionResult Payment()
        {
            return View();
        }


        public ActionResult PrivacyPolicy()
        {
            return View();
        }


        public ActionResult ReturnPolicy()
        {
            return View();
        }


        public ActionResult TermsAndCondition()
        {
            return View();
        }
    }
}