using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using DevExpress.Web.Internal;
using DevExpress.Web;

public static class Utils {
    const string
        CurrentThemeCookieKey = "theme",
        CurrentThemeColorCookieKey = "themeColor",
        CurrentFontCookieKey = "utilsFont",
        DefaultTheme = "Moderno",
        DefaultThemeColor = "Blue",
        DefaultFont = "12px 'Times New Roman'";

    static HttpContext Context {
        get { return HttpContext.Current; }
    }

    static HttpRequest Request {
        get { return Context.Request; }
    }

    public static string CurrentTheme {
        get {
            if(Request.Cookies[CurrentThemeCookieKey] != null)
                return HttpUtility.UrlDecode(Request.Cookies[CurrentThemeCookieKey].Value);
            return DefaultTheme;
        }
    }
    public static string CurrentThemeColor {
        get {
            if(Request.Cookies[CurrentThemeColorCookieKey] != null)
                return HttpUtility.UrlDecode(Request.Cookies[CurrentThemeColorCookieKey].Value);
            return DefaultThemeColor;
        }
    }
    public static string CurrentFont {
        get {
            if(Request.Cookies[CurrentFontCookieKey] != null)
                return HttpUtility.UrlDecode(Request.Cookies[CurrentFontCookieKey].Value);
            return DefaultFont;
        }
    }
}