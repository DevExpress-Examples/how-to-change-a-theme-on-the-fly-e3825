Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace MvcApp_Theme.Controllers
    Public Class HomeController
        Inherits Controller

        Public Function Index() As ActionResult
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!"
            Dim themeCollection As New ThemesModel() With { _
                .Name = "Aqua", _
                .Theme = CommonThemes.Aqua _
            }

            Return View(themeCollection)
        End Function

        <HttpPost> _
        Public Function PostTheme(<ModelBinder(GetType(MyEditorsBinder))> ByVal themeCollection As ThemesModel) As ActionResult
            ViewBag.Message = String.Format("Current theme: {0}", themeCollection.Theme)
            Return View("Index", themeCollection)
        End Function

        Public Function CalendarPartial() As ActionResult
            Return PartialView("CalendarPartial")
        End Function
    End Class
End Namespace
