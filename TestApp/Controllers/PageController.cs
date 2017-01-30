using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApp.PageService;

namespace TestApp.Controllers
{
    public class PageController : Controller
    {
        [Authorize(Users="admin")]
        // GET: Page
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetPages([DataSourceRequest] DataSourceRequest request)
        {
            var sites = new PageServiceClient().GetPages();
            return Json(sites.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }
    }
}