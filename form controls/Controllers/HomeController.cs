using form_controls.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace form_controls.Controllers
{
    public class HomeController : Controller
    {
        LibraryEntities DB = new LibraryEntities();
        // GET: Home
        public ActionResult Index()
        {
            var members = DB.members.ToList();
            return View(members);
        }
    }
}