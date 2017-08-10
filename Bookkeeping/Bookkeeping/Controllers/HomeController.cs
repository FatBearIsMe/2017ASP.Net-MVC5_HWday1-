using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookkeeping.Models;
using PagedList;

namespace Bookkeeping.Controllers
{
    public class HomeController : Controller
    {
        private RecordDataEntities db = new RecordDataEntities();
        public ActionResult Index(int? page)
        {
            ViewBag.RecordId = 1;

            var searchString = db.RecordDatas.ToList();
            searchString = db.RecordDatas.ToList();

            return View(searchString.ToPagedList(pageNumber: page ?? 1, pageSize: 10));
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