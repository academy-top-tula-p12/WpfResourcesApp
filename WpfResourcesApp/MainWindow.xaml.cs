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

namespace WpfResourcesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

            

            var solidWhite = new SolidColorBrush() { Color = Colors.White };
            this.Resources.Add("solidWhite", solidWhite);
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["brush"] = new SolidColorBrush() { Color = Colors.Green };
        }
    }
}