Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Http
Imports System.Web.Mvc
Imports System.Web.Routing
Imports DevExpress.Web.Mvc

Namespace DxWebApp
    ' Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    ' visit http://go.microsoft.com/?LinkId=9394801

    Public Class MvcApplication
        Inherits System.Web.HttpApplication

        Protected Sub Application_Start()
            AreaRegistration.RegisterAllAreas()

            GlobalConfiguration.Configure(AddressOf WebApiConfig.Register)
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
            RouteConfig.RegisterRoutes(RouteTable.Routes)

            ModelBinders.Binders.DefaultBinder = New DevExpress.Web.Mvc.DevExpressEditorsBinder()

            AddHandler DevExpress.Web.ASPxWebControl.CallbackError, AddressOf Application_Error
        End Sub

        Protected Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
            Dim exception As Exception = System.Web.HttpContext.Current.Server.GetLastError()
            'TODO: Handle Exception
        End Sub
        Protected Sub Application_PreRequestHandlerExecute(ByVal sender As Object, ByVal e As EventArgs)
            DevExpressHelper.Theme = Utils.CurrentTheme
            DevExpressHelper.GlobalThemeBaseColor = Utils.CurrentThemeColor
            DevExpressHelper.GlobalThemeFont = Utils.CurrentFont
        End Sub
    End Class
End Namespace