Imports Microsoft.VisualBasic
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
	Private privateName As String
	Public Property Name() As String
		Get
			Return privateName
		End Get
		Set(ByVal value As String)
			privateName = value
		End Set
	End Property
	Private privateTheme As CommonThemes
	Public Property Theme() As CommonThemes
		Get
			Return privateTheme
		End Get
		Set(ByVal value As CommonThemes)
			privateTheme = value
		End Set
	End Property
End Class
