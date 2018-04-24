Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.ComponentModel


Public Enum CommonThemes
    Aqua
    DevEx
    SoftOrange
    Youthful
End Enum

Public Class ThemesModel
    Public Property Name() As String
    Public Property Theme() As CommonThemes
End Class
