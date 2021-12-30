using SampleHTMLHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleHTMLHelpers.Controllers
{
    public class HTMLHelpersCustomController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}