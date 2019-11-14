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

namespace Snake
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : UserControl
    {
        MainWindow mainwindow;

        public Menu()
        {
            InitializeComponent();
        }

        private void bt_Esci_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Close();
        }

        private void bt_Avvia_Click(object sender, RoutedEventArgs e)
        {

            mainwindow.gr_contenitore.Children.Clear();
            mainwindow.gr_contenitore.Children.Add(new Gioco(mainwindow));
        }

        private void bt_Classifica_Click(object sender, RoutedEventArgs e)
        {
            mainwindow.gr_contenitore.Children.Clear();
            mainwindow.gr_contenitore.Children.Add(new Classifica(mainwindow));
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            mainwindow = ((MainWindow)Window.GetWindow(this));
        }
    }
}
