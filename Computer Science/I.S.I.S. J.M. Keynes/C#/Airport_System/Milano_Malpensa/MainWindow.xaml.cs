using System;
using System.Collections.Generic;
using System.IO;
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

namespace Milano_Malpensa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            grid.Children.Clear();
            grid.Children.Add(new form());
            menu_home.Visibility = Visibility.Visible;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            menu_home.Visibility = Visibility.Collapsed;
            Image finalImage = new Image() { VerticalAlignment = VerticalAlignment.Stretch,HorizontalAlignment=HorizontalAlignment.Stretch };
            finalImage.Source = new BitmapImage(
                                    new Uri("pack://application:,,,/Resources/o.jpg"));
            grid.Children.Add(finalImage);
        }

        private void Menu_home_Click(object sender, RoutedEventArgs e)
        {
            grid.Children.Clear();
            menu_home.Visibility = Visibility.Collapsed;
            Image finalImage = new Image() { VerticalAlignment = VerticalAlignment.Stretch, HorizontalAlignment = HorizontalAlignment.Stretch };
            finalImage.Source = new BitmapImage(
                                    new Uri("pack://application:,,,/Resources/o.jpg"));
            grid.Children.Add(finalImage);

        }

        private void Menu_del_Click(object sender, RoutedEventArgs e)
        {
            grid.Children.Clear();
            grid.Children.Add(new Show_delelte());
            menu_home.Visibility = Visibility.Visible;
        }
    }
}
