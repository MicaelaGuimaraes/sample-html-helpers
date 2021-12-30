using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleHTMLHelpers.Controllers
{
    public class HTMLHelpersTypesController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BeginFormResult(string name, string email, int age)
        {
            return Content($"<script language='javascript' type='text/javascript'>alert('Name: {name}, Email: {email}, Age: {age}');</script>");
        }
    }
}