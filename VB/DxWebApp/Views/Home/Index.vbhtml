@Code
    ViewData("Title") = "How to change themes on-the-fly "
End Code
<style>
    #myForm {
        background-color: #EEE;
        border: 1px solid black;
        width: 50%;
    }
</style>
@Using Html.BeginForm("PostTheme", "Home", FormMethod.Post, New With {.id = "myForm"})
       @<strong>Choose a Theme: </strong>
       @<div>
       @Html.DevExpress().RadioButtonList(Sub(settings)
                                              settings.Name = "Theme"
                                              settings.Properties.ValueType = GetType(DxWebApp.Models.CommonThemes)
                                              settings.Properties.Items.Add("Material", DxWebApp.Models.CommonThemes.Material)
                                              settings.Properties.Items.Add("iOS", DxWebApp.Models.CommonThemes.iOS)
                                              settings.Properties.Items.Add("Moderno", DxWebApp.Models.CommonThemes.Moderno)
                                              settings.Width = System.Web.UI.WebControls.Unit.Percentage(100)

                                              settings.Properties.ClientSideEvents.SelectedIndexChanged = "function (s,e) {ASPxClientUtils.SetCookie('ex3825_theme', s.GetValue());}"

                                          End Sub).Bind(Model.Theme).GetHtml()
        </div>
        @<strong>Choose a Theme Color: </strong>
        @<div>
        @Html.DevExpress().RadioButtonList(Sub(settings)
                                               settings.Name = "ThemeColor"
                                               settings.Properties.ValueType = GetType(String)
                                               settings.Properties.Items.Add("Blue", "Blue")
                                               settings.Properties.Items.Add("Green", "Green")
                                               settings.Properties.Items.Add("Red", "Red")
                                               settings.Width = System.Web.UI.WebControls.Unit.Percentage(100)
                                               settings.Properties.ClientSideEvents.SelectedIndexChanged = "function (s,e) {ASPxClientUtils.SetCookie('ex3825_themeColor', s.GetValue());}"
                                           End Sub).Bind(Model.ThemeColor).GetHtml()
        </div>
        @<strong>Choose a Font: </strong>
        @<div>
        @Html.DevExpress().RadioButtonList(Sub(settings)
                                               settings.Name = "Font"
                                               settings.Properties.ValueType = GetType(String)
                                               settings.Properties.Items.Add("12px 'Times New Roman'", "12px 'Times New Roman'")
                                               settings.Properties.Items.Add("15px 'Arial Black'", "15px 'Arial Black'")
                                               settings.Properties.Items.Add("20px 'Calibri'", "20px 'Calibri'")
                                               settings.Width = System.Web.UI.WebControls.Unit.Percentage(100)
                                               settings.Properties.ClientSideEvents.SelectedIndexChanged = "function (s,e) {ASPxClientUtils.SetCookie('ex3825_utilsFont', s.GetValue());}"
                                           End Sub).Bind(Model.Font).GetHtml()
        </div>
        @<div>
        @Html.DevExpress().Button(Sub(btnSettings)
                                      btnSettings.Name = "btn"
                                      btnSettings.Text = "Change Theme, Color and Font"
                                      btnSettings.UseSubmitBehavior = True
                                  End Sub).GetHtml()
        </div>
        @<div>
            @Html.Partial("CalendarPartial")
        </div>
End Using