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

namespace Software_Motorizzazione
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

        private void menu_add_Click(object sender, RoutedEventArgs e)
        {
            window_add add = new window_add();
            add.Show();
            this.Close();
        }

        private void menu_show_Click(object sender, RoutedEventArgs e)
        {
            window_show show = new window_show();
            show.Show();
            this.Close();

        }

        private void menu_find_Click(object sender, RoutedEventArgs e)
        {
            window_find find = new window_find();
            find.Show();
            this.Close();
        }
    }
}
