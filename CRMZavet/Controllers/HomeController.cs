using CRMZavet.BLL.DTO;
using CRMZavet.BLL.Interfaces;
using CRMZavet.DAL.Entities;
using CRMZavet.DAL.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CRMZavet.Controllers
{
    public class HomeController : Controller
    {
        IDetailOnProduct _detailOn;
        public HomeController(IDetailOnProduct detailOn)
        {
            _detailOn = detailOn;
        }

        public ActionResult Index()
        {
            IEnumerable<DetailDTO> d = _detailOn.GetDetail(1);
            return View(d);
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