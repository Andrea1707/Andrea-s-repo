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
    /// Logica di interazione per Dati.xaml
    /// </summary>
    public partial class Dati : UserControl
    {
        int punti;
        MainWindow mainwindow;

        public Dati(int p, MainWindow mw)
        {
            InitializeComponent();
            punti = p;
            mainwindow = mw;
        }

        private void bt_invia_Click(object sender, RoutedEventArgs e)
        {
            if (!tbx_name.Text.Equals(""))
            {
                string Nome = tbx_name.Text;

                GestioneFile.SalvaXML(new Punteggio(Nome, punti, DateTime.Now));
            }

            mainwindow.gr_contenitore.Children.Clear();
            mainwindow.gr_contenitore.Children.Add(new Menu());
        }

        private void bt_indietro_Click(object sender, RoutedEventArgs e)
        {
            mainwindow.gr_contenitore.Children.Clear();
            mainwindow.gr_contenitore.Children.Add(new Menu());
        }

       
    }
}
