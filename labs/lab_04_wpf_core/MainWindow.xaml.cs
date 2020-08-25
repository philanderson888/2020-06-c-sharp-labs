using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab_04_wpf_core
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // windows
            InitializeComponent();
            LabelDisplay.Content = "00";
        }

        static int firstNumber = 0;
        static int secondNumber = 0;

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonEquals_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            LabelDisplay.Content = "Don't double click";
        }
    }
}
