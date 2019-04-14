@Html.DevExpress().Calendar(Sub(settings)
                                     settings.Name = "calendar"
                                     settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "CalendarPartial"}
                                     settings.VisibleDate = New DateTime(2011, 10, 1)
                                     settings.ReadOnly = True
                                     settings.Properties.EnableMonthNavigation = False
                                     settings.Properties.EnableYearNavigation = False
                                 End Sub).GetHtml()