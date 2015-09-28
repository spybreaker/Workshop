using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Workshop.DAL;
using Workshop.DAL.Models;
using System.Data.Entity;


namespace Workshop.Controllers
{
    public class Home : Controller
    {
        WorkshopEntities workshopEntity = new WorkshopEntities();
        public ActionResult Index()
        {
            return View();

        }
    }
}