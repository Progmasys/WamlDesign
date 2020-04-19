using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace WamlDesign
{
    public class WamlWindow : Window
    {
        static WamlWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WamlWindow), 
                new FrameworkPropertyMetadata(typeof(WamlWindow)));
        }
    }
}
