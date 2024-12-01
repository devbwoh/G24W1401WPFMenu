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

            // WPF에서 제공하는 기본 명령 중 하나인 "열기" 바인딩 생성
            CommandBinding bind = new CommandBinding(ApplicationCommands.Open);

            // 명령이 실행될 때 호출될 이벤트 핸들러 지정
            // 내가 만든 OpenDocument 메서드
            bind.Executed += OpenDocument;

            // CommandBindings: 현재 UI 요소에 대한 명령과 이벤트 바인딩 목록을 포함하는 컬렉션
            // 앞서 생성한 bind를 CommandBindings 컬렉션에 추가하여 명령과 이벤트 연결
            CommandBindings.Add(bind);
        }

        private void OpenDocument(object sender, RoutedEventArgs e) {
            // Configure open file dialog box
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.FileName = "이미지"; // Default file name
            dialog.DefaultExt = ".jpg"; // Default file extension
            dialog.Filter = "Images (.jpg)|*.jpg"; // Filter files by extension

            // Show open file dialog box
            bool? result = dialog.ShowDialog();

            // Process open file dialog box results
            if (result != true)
                return;

            // Open document
            string filename = dialog.FileName;

            MessageBox.Show(filename);
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