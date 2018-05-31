Public NotInheritable Class Utils

    Private Sub New()
    End Sub
    Private Const CurrentThemeCookieKey As String = "theme", CurrentThemeColorCookieKey As String = "themeColor", CurrentFontCookieKey As String = "utilsFont", DefaultTheme As String = "Moderno", DefaultThemeColor As String = "Blue", DefaultFont As String = "12px 'Times New Roman'"

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
    Public Shared ReadOnly Property CurrentThemeColor() As String
        Get
            If Request.Cookies(CurrentThemeColorCookieKey) IsNot Nothing Then
                Return HttpUtility.UrlDecode(Request.Cookies(CurrentThemeColorCookieKey).Value)
            End If
            Return DefaultThemeColor
        End Get
    End Property
    Public Shared ReadOnly Property CurrentFont() As String
        Get
            If Request.Cookies(CurrentFontCookieKey) IsNot Nothing Then
                Return HttpUtility.UrlDecode(Request.Cookies(CurrentFontCookieKey).Value)
            End If
            Return DefaultFont
        End Get
    End Property
End Class