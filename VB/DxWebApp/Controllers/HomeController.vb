Imports DxWebApp.Models
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace DxWebApp.Controllers
    Public Class HomeController
        Inherits Controller

        Public Function Index() As ActionResult
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!"

            Dim themeCollection As New ThemesModel()
            If Not String.IsNullOrEmpty(Utils.CurrentTheme) AndAlso Not String.IsNullOrEmpty(Utils.CurrentThemeColor) Then
                themeCollection = New ThemesModel() With { _
                    .Name = "test", _
                    .Theme = DirectCast(System.Enum.Parse(GetType(CommonThemes), Utils.CurrentTheme), CommonThemes), _
                    .ThemeColor = Utils.CurrentThemeColor, _
                    .Font = Utils.CurrentFont _
                }
            Else
                themeCollection = New ThemesModel() With { _
                    .Name = "Moderno", _
                    .Theme = CommonThemes.Moderno, _
                    .ThemeColor = "Blue", _
                    .Font = "12px 'Times New Roman'" _
                }
            End If

            Return View(themeCollection)
        End Function

        <HttpPost> _
        Public Function PostTheme(<ModelBinder(GetType(MyEditorsBinder))> ByVal themeCollection As ThemesModel) As ActionResult
            ViewBag.Message = String.Format("Current theme: {0}, theme color: {1}, font: {2}", themeCollection.Theme, themeCollection.ThemeColor, themeCollection.Font)
            Return View("Index", themeCollection)
        End Function

        Public Function CalendarPartial() As ActionResult
            Return PartialView("CalendarPartial")
        End Function
    End Class
End Namespace