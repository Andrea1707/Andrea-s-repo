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

namespace Pokededex
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if(!File.Exists("pokemon.xml"))
            {
                GestioneFile.SaveXml_Pokemon(Utility.GeneraPokemon());
            }

            gr_contenitore.Children.Add(new pokdedex());
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {


        }

        private void mi_show_Click(object sender, RoutedEventArgs e)
        {
            gr_contenitore.Children.Clear();
            gr_contenitore.Children.Add(new pokdedex());
            

        }

        private void mi_login_Click(object sender, RoutedEventArgs e)
        {
            gr_contenitore.Children.Clear();
            gr_contenitore.Children.Add(new Pokedex.Login());
            string users = "users.xml";
            if (!File.Exists(users))
            {


            }

        }
    }
}
