using System.Windows;
using System.Windows.Controls;

namespace WamlDesign
{
    public class WamlSpinner : Control
    {
        public static readonly DependencyProperty SpinnerSizeProperty =
          DependencyProperty.Register("SpinnerSize", typeof(WamlSpinnerSize), typeof(WamlSpinner), new PropertyMetadata(WamlSpinnerSize.Normal));

        public static readonly DependencyProperty SpinnerGeometryProperty =
          DependencyProperty.Register("SpinnerGeometry", typeof(Rect), typeof(WamlSpinner), new PropertyMetadata(new Rect(0, 20, 20, 20)));

        public static readonly DependencyProperty LabelProperty =
           DependencyProperty.Register("Label", typeof(string), typeof(WamlSpinner));

        public static readonly DependencyProperty SpinnerPositionProperty =
           DependencyProperty.Register("SpinnerPosition", typeof(Dock), typeof(WamlSpinner));

        public WamlSpinnerSize SpinnerSize
        {
            get { return (WamlSpinnerSize)GetValue(SpinnerSizeProperty); }
            set { SetValue(SpinnerSizeProperty, value); }
        }

        public Rect SpinnerGeometry
        {
            get { return (Rect)GetValue(SpinnerGeometryProperty); }
            set { SetValue(SpinnerGeometryProperty, value); }
        }

        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        public Dock SpinnerPosition
        {
            get { return (Dock)GetValue(SpinnerPositionProperty); }
            set { SetValue(SpinnerPositionProperty, value); }
        }

        static WamlSpinner() { }
    }
}
