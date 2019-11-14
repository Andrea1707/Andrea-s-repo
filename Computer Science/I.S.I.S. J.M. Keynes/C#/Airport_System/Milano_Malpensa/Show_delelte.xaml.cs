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

namespace Milano_Malpensa
{
    /// <summary>
    /// Interaction logic for Show_delelte.xaml
    /// </summary>
    public partial class Show_delelte : UserControl
    {
        public Show_delelte()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            List<Passeggero> a = Gestione_file.Read();
            foreach(Passeggero p in a)
            {
                Passeggero_item li = new Passeggero_item(p);
                lv_box.Items.Add(li);
            }
        }

        private void Bt_delete_Click(object sender, RoutedEventArgs e)
        {
            lv_box.SelectedIndex.ToString();
        }
    }
}
