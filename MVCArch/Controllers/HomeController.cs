using MVCArch.Business;
using MVCArch.Infrastructure.Utilities;
using MVCArch.Data;
using MVCArch.Models;
using MVCArch.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCArch.Controllers
{
    public class HomeController : Controller
    {
        WorldEventBL eventBL;
        BasicViewModel vm = new BasicViewModel();
        public ActionResult Index()
        {
            eventBL = new WorldEventBL(new WorldEvents(), new Extension());
            vm.homeVM = eventBL.GetEvents();
            return View(vm);
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