using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace WamlDesign
{
    public class WamlChromeButton : Button
    {
        public WamlChromeButton()
        { 
        
        }

        public WamlChromeButtonMode Mode { get; set; }

        protected override void OnClick()
        {
            var parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                switch (Mode)
                {
                    case WamlChromeButtonMode.Close:
                        SystemCommands.CloseWindow(parentWindow);
                        break;
                    case WamlChromeButtonMode.Minimize:
                        SystemCommands.MinimizeWindow(parentWindow);
                        break;
                    case WamlChromeButtonMode.Maximize:
                        SystemCommands.MaximizeWindow(parentWindow);
                        break;
                    case WamlChromeButtonMode.Restore:
                        SystemCommands.RestoreWindow(parentWindow);
                        break;
                }
            }
            base.OnClick();
        }
    }
}
