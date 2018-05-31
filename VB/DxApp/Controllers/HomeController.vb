Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Public Function Index() As ActionResult
        ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!"

        Dim themeCollection As New ThemesModel()
        If Not String.IsNullOrEmpty(Utils.CurrentTheme) AndAlso Not String.IsNullOrEmpty(Utils.CurrentThemeColor) Then
            themeCollection = New ThemesModel() With {
                    .Name = "test",
                    .Theme = DirectCast(System.Enum.Parse(GetType(CommonThemes), Utils.CurrentTheme), CommonThemes),
                    .ThemeColor = Utils.CurrentThemeColor,
                    .Font = Utils.CurrentFont
                }
        Else
            themeCollection = New ThemesModel() With {
                    .Name = "Moderno",
                    .Theme = CommonThemes.Moderno,
                    .ThemeColor = "Blue",
                    .Font = "12px 'Times New Roman'"
                }
        End If

        Return View(themeCollection)
    End Function

    <HttpPost>
    Public Function PostTheme(<ModelBinder(GetType(MyEditorsBinder))> ByVal themeCollection As ThemesModel) As ActionResult
        ViewBag.Message = String.Format("Current theme: {0}, theme color: {1}, font: {2}", themeCollection.Theme, themeCollection.ThemeColor, themeCollection.Font)
        Return View("Index", themeCollection)
    End Function

    Public Function CalendarPartial() As ActionResult
        Return PartialView("CalendarPartial")
    End Function
End Class