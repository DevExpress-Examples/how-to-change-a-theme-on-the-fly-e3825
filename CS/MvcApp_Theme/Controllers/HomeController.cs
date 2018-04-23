using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace MvcApp_Theme.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!";
            ThemesModel themeCollection = new ThemesModel() { Name = "Aqua", Theme = CommonThemes.Aqua };

            return View(themeCollection);
        }

        [HttpPost]
        public ActionResult PostTheme([ModelBinder(typeof(MyEditorsBinder))] ThemesModel themeCollection) {
            ViewBag.Message = String.Format("Current theme: {0}", themeCollection.Theme);
            return View("Index", themeCollection);
        }

        public ActionResult CalendarPartial() {
            return PartialView("CalendarPartial");
        }
    }
}
