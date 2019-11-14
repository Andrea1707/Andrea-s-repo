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

namespace Snake
{
    /// <summary>
    /// Interaction logic for Classifica.xaml
    /// </summary>
    public partial class Classifica : UserControl
    {
        MainWindow mainwindow;

        public Classifica(MainWindow mw)
        {
            InitializeComponent();
            mainwindow = mw;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e) 
        {
            if (File.Exists(GestioneFile.percorso))
            {
                List<Punteggio> Mylist = GestioneFile.LeggiXml();
                Mylist.Reverse();
                lv_classifica.ItemsSource = Mylist;
            }

        }

        private void bt_indietro_Click(object sender, RoutedEventArgs e)
        {
            mainwindow.gr_contenitore.Children.Clear();
            mainwindow.gr_contenitore.Children.Add(new Menu());
        }
    }
}
