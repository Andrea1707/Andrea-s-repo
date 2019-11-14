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
    /// Interaction logic for window_find.xaml
    /// </summary>
    public partial class window_find : Window
    {
        public window_find()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            MainWindow Main = new MainWindow();
            Main.Show();
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (rd_nominativo.IsChecked == true)
            {


            }

            if (rd_targa.IsChecked == true)
            {



            }

        }


    }
}
