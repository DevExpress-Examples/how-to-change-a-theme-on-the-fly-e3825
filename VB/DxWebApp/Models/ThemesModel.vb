Imports System

Namespace DxWebApp.Models
    Public Enum CommonThemes
        Moderno
        Material
        iOS
    End Enum

    Public Class ThemesModel
        Public Property Name() As String
        Public Property Theme() As CommonThemes
        Public Property ThemeColor() As String
        Public Property Font() As String
    End Class
End Namespace