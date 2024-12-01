using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace G24W1401WPFMenu {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            ItemWhite.IsEnabled = false;
            ItemWhite.IsChecked = true;
        }

        private void SetRed(object sender, RoutedEventArgs e) {
            //MenuItem item = (MenuItem)sender;
            //item.IsChecked = true;

            BackPanel.Background = Brushes.Red;

            ItemRed.IsChecked = true;
            ItemGreen.IsChecked = false;
            ItemBlue.IsChecked = false;

            ItemWhite.IsEnabled = true;
            ItemWhite.IsChecked = false;
        }

        private void SetGreen(object sender, RoutedEventArgs e) {
            SolidColorBrush brush = new SolidColorBrush(Color.FromRgb(0, 255, 0));
            BackPanel.Background = brush;

            ItemRed.IsChecked = false;
            ItemGreen.IsChecked = true;
            ItemBlue.IsChecked = false;

            ItemWhite.IsEnabled = true;
            ItemWhite.IsChecked = false;
        }

        private void SetBlue(object sender, RoutedEventArgs e) {
            SolidColorBrush brush = new SolidColorBrush(Color.FromArgb(255, 0, 0, 255));
            BackPanel.Background = brush;

            ItemRed.IsChecked = false;
            ItemGreen.IsChecked = false;
            ItemBlue.IsChecked = true;

            ItemWhite.IsEnabled = true;
            ItemWhite.IsChecked = false;
        }

        private void SetWhite(object sender, RoutedEventArgs e) {
            SolidColorBrush brush = new SolidColorBrush(Colors.White);
            BackPanel.Background = brush;

            ItemRed.IsChecked = false;
            ItemGreen.IsChecked = false;
            ItemBlue.IsChecked = false;

            ItemWhite.IsEnabled = false;
            ItemWhite.IsChecked = true;
        }
    }
}