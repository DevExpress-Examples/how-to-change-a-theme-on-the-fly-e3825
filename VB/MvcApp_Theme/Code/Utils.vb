Imports Microsoft.VisualBasic
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
Imports DevExpress.Web.ASPxClasses

Public NotInheritable Class Utils
	Private Const CurrentThemeCookieKey As String = "theme", DefaultTheme As String = "Aqua"

	Private Sub New()
	End Sub
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
