@Code
    ViewData("Title") = "Home Page"
End Code

<h2>@ViewBag.Message</h2>
@Using (Html.BeginForm("PostTheme", "Home", FormMethod.Post, New With {.style = "background-color: #EEE; border: 1px solid black; width: 450px; padding: 4px;"}))
    ViewContext.Writer.Write("<strong>Choose a Theme: </strong><div>")

    @Html.DevExpress().RadioButtonList(
                                                                                                                                                Sub(settings)
                                                                                                                                                    settings.Name = "Theme"
                                                                                                                                                    settings.Properties.ValueType = GetType(DxApp.CommonThemes)
                                                                                                                                                    settings.Properties.Items.Add("Material", DxApp.CommonThemes.Material)
                                                                                                                                                    settings.Properties.Items.Add("MaterialCompact", DxApp.CommonThemes.MaterialCompact)
                                                                                                                                                    settings.Properties.Items.Add("Moderno", DxApp.CommonThemes.Moderno)
                                                                                                                                                    settings.Width = System.Web.UI.WebControls.Unit.Percentage(100)

                                                                                                                                                    settings.Properties.ClientSideEvents.SelectedIndexChanged = "function (s,e) {ASPxClientUtils.SetCookie('theme', s.GetValue());}"
                                                                                                                                                End Sub).Bind(Model.Theme).GetHtml()
    ViewContext.Writer.Write("</div><strong>Choose a Theme Color: </strong><div>")

    @Html.DevExpress().RadioButtonList(
                                                                                                                        Sub(settings)
                                                                                                                            settings.Name = "ThemeColor"
                                                                                                                            settings.Properties.ValueType = GetType(String)
                                                                                                                            settings.Properties.Items.Add("Blue", "Blue")
                                                                                                                            settings.Properties.Items.Add("Green", "Green")
                                                                                                                            settings.Properties.Items.Add("Red", "Red")
                                                                                                                            settings.Width = System.Web.UI.WebControls.Unit.Percentage(100)

                                                                                                                            settings.Properties.ClientSideEvents.SelectedIndexChanged = "function (s,e) {ASPxClientUtils.SetCookie('themeColor', s.GetValue());}"
                                                                                                                        End Sub).Bind(Model.ThemeColor).GetHtml()
    ViewContext.Writer.Write("</div><strong>Choose a Font: </strong><div>")

    @Html.DevExpress().RadioButtonList(
                                                                                                                        Sub(settings)
                                                                                                                            settings.Name = "Font"
                                                                                                                            settings.Properties.ValueType = GetType(String)
                                                                                                                            settings.Properties.Items.Add("12px 'Times New Roman'", "12px 'Times New Roman'")
                                                                                                                            settings.Properties.Items.Add("15px 'Arial Black'", "15px 'Arial Black'")
                                                                                                                            settings.Properties.Items.Add("20px 'Calibri'", "20px 'Calibri'")
                                                                                                                            settings.Width = System.Web.UI.WebControls.Unit.Percentage(100)

                                                                                                                            settings.Properties.ClientSideEvents.SelectedIndexChanged = "function (s,e) {ASPxClientUtils.SetCookie('utilsFont', s.GetValue());}"
                                                                                                                        End Sub).Bind(Model.Font).GetHtml()
    ViewContext.Writer.Write("</div><div>")
    @Html.DevExpress().Button(
                                                                                                            Sub(btnSettings)
                                                                                                                btnSettings.Name = "btn"
                                                                                                                btnSettings.Text = "Change Theme, Color and Font"
                                                                                                                btnSettings.UseSubmitBehavior = True
                                                                                                            End Sub).GetHtml()
    ViewContext.Writer.Write("</div><div>")
    @Html.Partial("CalendarPartial")
    ViewContext.Writer.Write("</div>")

End Using