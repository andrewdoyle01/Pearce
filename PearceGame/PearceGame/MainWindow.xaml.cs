using System.Windows;

namespace PearceGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string butt { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            butt = textBox.Text;
        }

        private void change(object sender, RoutedEventArgs e)
        {
            button.Content = password.Password;
        }

        private void buttonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("HELLO");
        }
    }
}
