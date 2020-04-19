using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace WamlDesign.Styles
{
    public static class WamlBrushes
    {
        static WamlBrushes()
        {
            NeutralGray160.Freeze();
        }

        public static SolidColorBrush NeutralGray160 { get; } = new SolidColorBrush(Color.FromRgb(50, 49, 48));
    }
}
