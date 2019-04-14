Imports System
Imports System.ComponentModel
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc

Namespace DxWebApp.Models
    Public Class MyEditorsBinder
        Inherits DevExpressEditorsBinder

        Protected Overrides Function GetPropertyValue(ByVal controllerContext As ControllerContext, ByVal bindingContext As ModelBindingContext, ByVal propertyDescriptor As PropertyDescriptor, ByVal propertyBinder As IModelBinder) As Object
            If propertyDescriptor.PropertyType Is GetType(CommonThemes) Then
                Dim tc As TypeConverter = propertyDescriptor.Converter
                Return tc.ConvertFrom(EditorExtension.GetValue(Of String)(propertyDescriptor.Name))
            End If

            Return MyBase.GetPropertyValue(controllerContext, bindingContext, propertyDescriptor, propertyBinder)
        End Function
    End Class
End Namespace