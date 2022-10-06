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

namespace Wpf_Cherednichenko_PR3_MultiEdit
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tb1_LostFocus(object sender, RoutedEventArgs e)
        {
            (sender as FrameworkElement).Style = (Style)Resources["style2"];
        }

        private void tb1_SelectionChanged(object sender, RoutedEventArgs e)
        {
            (sender as FrameworkElement).Style = (Style)Resources["style1"];
        }

    }
}
