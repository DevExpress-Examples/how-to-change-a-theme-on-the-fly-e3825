using System;

namespace DxWebApp.Models {
    public enum CommonThemes {
        Moderno,
        Material,
        MaterialCompact
    }

    public class ThemesModel {
        public String Name { get; set; }
        public CommonThemes Theme { get; set; }
        public string ThemeColor { get; set; }
        public string Font { get; set; }
    }
}