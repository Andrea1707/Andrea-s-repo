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
using System.Windows.Shapes;

namespace Software_Motorizzazione
{
    /// <summary>
    /// Interaction logic for window_show.xaml
    /// </summary>
    public partial class window_show : Window
    {
        public window_show()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            MainWindow Main = new MainWindow();
            Main.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StreamReader objReader = new StreamReader("lista_veicoli.txt");
            string sLine = objReader.ReadToEnd();
            objReader.Close();
            char[] delimiterChars = { ',', ';', '\n', '\r' };
            string[] utenti = sLine.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < utenti.Length; i++)
            {
                Veicolo temp = new Veicolo();
                if (i % 5 == 0)
                {

                    temp.targa = utenti[i];
                    temp.marca = utenti[i + 1];
                    temp.modello = utenti[i + 2];
                    temp.colore = utenti[i + 3];
                    temp.nominativo = utenti[i + 4];
                    datagrid.Items.Add(temp);

                }
            }

        }
    }
}
   
