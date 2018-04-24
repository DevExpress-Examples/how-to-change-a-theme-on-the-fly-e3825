Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports System.IO
Imports System.Reflection
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Configuration
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxClasses.Internal

Public NotInheritable Class Utils

    Private Sub New()
    End Sub
    Private Const CurrentThemeCookieKey As String = "theme", DefaultTheme As String = "Aqua"

    Private Shared ReadOnly Property Context() As HttpContext
        Get
            Return HttpContext.Current
        End Get
    End Property

    Private Shared ReadOnly Property Request() As HttpRequest
        Get
            Return Context.Request
        End Get
    End Property

    Public Shared ReadOnly Property CurrentTheme() As String
        Get
            If Request.Cookies(CurrentThemeCookieKey) IsNot Nothing Then
                Return HttpUtility.UrlDecode(Request.Cookies(CurrentThemeCookieKey).Value)
            End If
            Return DefaultTheme
        End Get
    End Property
End Class
