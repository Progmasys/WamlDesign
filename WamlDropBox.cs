using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WamlDesign
{
    public class WamlDropBox : Button
    {
        static WamlDropBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WamlDropBox), new FrameworkPropertyMetadata(typeof(WamlDropBox)));
        }

        public static readonly DependencyProperty MenuProperty =
            DependencyProperty.Register("Menu", typeof(ContextMenu), typeof(WamlDropBox), new PropertyMetadata(null));

        public ContextMenu Menu
        {
            get { return (ContextMenu)GetValue(MenuProperty); }
            set { SetValue(MenuProperty, value); }
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            if (GetTemplateChild("PART_ArrowDown") is FrameworkElement downArrowPart)
            {
                downArrowPart.PreviewMouseDown += DownArrowPart_PreviewMouseDown;
            }

            PreviewMouseLeftButtonDown += FluentSplitButton_PreviewMouseLeftButtonDown;
        }

        private void DownArrowPart_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            ShowContextMenu();
            e.Handled = true;
        }

        private void FluentSplitButton_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ShowContextMenu();
            e.Handled = true;
        }

        private void ShowContextMenu()
        {
            var menu = Menu;
            if (menu != null)
            {
                menu.PlacementTarget = this;
                menu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
                menu.IsOpen = true;
            }
        }
    }
}
