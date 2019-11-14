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

namespace Pokededex
{
    /// <summary>
    /// Interaction logic for ListitemPokedex.xaml
    /// </summary>
    public partial class ListitemPokedex : UserControl
    {
        public ListitemPokedex(Pokemon p)
        {
            InitializeComponent();
            img_poke.Source = new BitmapImage(new Uri(p.Path_name));
            lb_nome.Content = p.Nome;
            lb_forza.Content = p.Forza;
            lb_tipo.Content = p.Tipo;
        }
    }
}
