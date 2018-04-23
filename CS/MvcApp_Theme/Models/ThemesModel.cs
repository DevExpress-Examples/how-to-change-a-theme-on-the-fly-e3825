using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;


public enum CommonThemes {
    Aqua,
    DevEx,
    SoftOrange,
    Youthful
}

public class ThemesModel {
    public String Name { get; set; }
    public CommonThemes Theme { get; set; }
}
