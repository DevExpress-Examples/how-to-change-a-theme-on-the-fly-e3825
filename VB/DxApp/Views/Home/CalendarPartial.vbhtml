@Html.DevExpress().Calendar(
                Sub(settings)
                    settings.Name = "calendar"
                    settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "CalendarPartial"}
                    settings.VisibleDate = New DateTime(2011, 10, 1)
                    settings.ReadOnly = True
                    settings.Properties.EnableMonthNavigation = False
                    settings.Properties.EnableYearNavigation = False

                    settings.Properties.DayStyle.Paddings.PaddingBottom = System.Web.UI.WebControls.Unit.Pixel(30)
                    settings.Properties.DayStyle.Paddings.PaddingRight = System.Web.UI.WebControls.Unit.Pixel(30)
                    settings.Properties.DayStyle.Border.BorderColor = System.Drawing.Color.Black
                    settings.Properties.DayStyle.Border.BorderWidth = System.Web.UI.WebControls.Unit.Pixel(1)
                    settings.Properties.DayStyle.Border.BorderStyle = System.Web.UI.WebControls.BorderStyle.Solid

                End Sub).GetHtml()