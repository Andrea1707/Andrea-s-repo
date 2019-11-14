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
using System.Windows.Threading;

namespace Snake
{
    public partial class MainWindow : Window
    {
        DispatcherTimer dt;
        public MainWindow()
        {
            InitializeComponent();
        }
      
        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            dt = new DispatcherTimer();
            dt.Tick += Caricamento;
            dt.Interval = new TimeSpan(0, 0, 0, 1);
            dt.Start();     
        }

        public void Caricamento(object o, EventArgs e)
        {
            dt.Stop();
            gr_contenitore.Children.Clear();
            gr_contenitore.Children.Add(new Menu());
        }

    }
}
