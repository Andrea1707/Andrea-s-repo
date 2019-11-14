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
    /// Interaction logic for pokdedex.xaml
    /// </summary>
    public partial class pokdedex : UserControl
    {
        public pokdedex()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            List<Pokemon> ele = GestioneFile.LeggiXML_pokemon();
            foreach ( Pokemon p in ele)
            {
                ListitemPokedex li = new ListitemPokedex(p);
                lv_poke.Items.Add(li);
            }
        }
    }
}
