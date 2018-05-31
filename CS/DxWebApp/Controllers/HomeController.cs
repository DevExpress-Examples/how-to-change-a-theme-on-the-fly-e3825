using DxWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DxWebApp.Controllers
{
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!";

            ThemesModel themeCollection = new ThemesModel();
            if(!string.IsNullOrEmpty(Utils.CurrentTheme) && !string.IsNullOrEmpty(Utils.CurrentThemeColor))
                themeCollection = new ThemesModel() { Name = "test", Theme = (CommonThemes)Enum.Parse(typeof(CommonThemes), Utils.CurrentTheme), ThemeColor = Utils.CurrentThemeColor, Font = Utils.CurrentFont };
            else
                themeCollection = new ThemesModel() { Name = "Moderno", Theme = CommonThemes.Moderno, ThemeColor = "Blue", Font = "12px 'Times New Roman'" };

            return View(themeCollection);
        }

        [HttpPost]
        public ActionResult PostTheme([ModelBinder(typeof(MyEditorsBinder))] ThemesModel themeCollection) {
            ViewBag.Message = String.Format("Current theme: {0}, theme color: {1}, font: {2}", themeCollection.Theme, themeCollection.ThemeColor, themeCollection.Font);
            return View("Index", themeCollection);
        }

        public ActionResult CalendarPartial() {
            return PartialView("CalendarPartial");
        }
    }
}