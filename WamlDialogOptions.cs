using System.Windows;

namespace WamlDesign
{
    public class WamlDialogOptions
    {
        public string OkButtonContent { get; set; }

        public string CancelButtonContent { get; set; }

        public string DeleteButtonContent { get; set; }

        public Visibility OkButtonVisibility { get; set; } = Visibility.Visible;

        public Visibility CancelButtonVisibility { get; set; } = Visibility.Collapsed;

        public Visibility DeleteButtonVisibility { get; set; } = Visibility.Collapsed;
    }
}
