using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApp.PageService;

namespace TestApp.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Show(int id)
        {
            var model = new PageServiceClient().GetPageByID(id);
            return View(model);
        }
    }
}