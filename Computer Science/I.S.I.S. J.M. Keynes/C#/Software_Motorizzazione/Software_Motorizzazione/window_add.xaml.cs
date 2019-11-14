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
using System.Windows.Shapes;

namespace Software_Motorizzazione
{
    /// <summary>
    /// Interaction logic for window_add.xaml
    /// </summary>
    public partial class window_add : Window
    {
        public window_add()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            MainWindow Main = new MainWindow();
            Main.Show();
            this.Close();
        }

        private void bt_add_Click(object sender, RoutedEventArgs e)
        {
            if (tb_targa.Text == null && tb_nominativo.Text == null && tb_modello == null && tb_marca == null && tb_colore == null)
            {
                MessageBox.Show("Inserisci tutti i campi!");
            }
            else
            {
                string targa = tb_targa.Text,
                        marca = tb_marca.Text,
                        modello = tb_modello.Text,
                        colore = tb_colore.Text,
                        nominativo = tb_nominativo.Text;
                Salvataggio.salva(targa, marca, modello, colore, nominativo);
                MessageBox.Show("Salvataggio completato!");
                tb_targa.Text = null;
                tb_marca.Text = null;
                tb_modello.Text = null;
                tb_colore.Text = null;
                tb_nominativo.Text = null;
            }

        }
    }
}
