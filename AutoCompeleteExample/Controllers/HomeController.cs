using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoCompeleteExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DropItems drpItems = new DropItems();
            return View(drpItems);
        }

        [HttpPost]
        public ActionResult Index(DropItems drpItems)
        {
            var tmp = drpItems.ChosenVal;
            return View(drpItems);
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

    public class DropItems
    {
        public DropItems()
        {
            this.Lst = new List<SelectListItem>();
            this.Lst.Add(new SelectListItem() { Text = "option1", Value = "1" });
            this.Lst.Add(new SelectListItem() { Text = "option2", Value = "2" });
            this.Lst.Add(new SelectListItem() { Text = "option3", Value = "3" });
        }
        public List<SelectListItem> Lst { get; set; }
        public string ChosenVal { get; set; }
    }
}