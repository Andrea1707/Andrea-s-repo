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

namespace Milano_Malpensa
{
    /// <summary>
    /// Interaction logic for form.xaml
    /// </summary>
    public partial class form : UserControl
    {
        public form()
        {
            InitializeComponent();
        }

        private void Bt_add_Click(object sender, RoutedEventArgs date)
        {
            
            if (tb_firstname.Text.Equals("Fisrt name") && tb_lastname.Text.Equals("Last name") && tb_nationality.Text.Equals("Nationality") && Date_picker.SelectedDate.Equals(null))
            {
                MessageBox.Show("Riempi tutti i campi");

            }
            else
            {
                string c = tb_lastname.Text;
                string d = tb_firstname.Text;
                DateTime? g = Date_picker.SelectedDate;
                string f = tb_nationality.Text;

                if (!File.Exists("Lista_passeggeri.xml"))
                {
                    List<Passeggero> b = new List<Passeggero>();
                    b.Add(new Passeggero(c, d, g, f));
                    Gestione_file.Save(b);
                }
                else
                {

                    List<Passeggero> a = Gestione_file.Read();
                    a.Add(new Passeggero(c, d, g, f));
                    Gestione_file.Save(a);
                }
                MessageBox.Show("Utente salvato correttamente!");
                tb_lastname.Text = "Last name";
                tb_firstname.Text = "First name";
                tb_nationality.Text = "Nationality";
                Date_picker.SelectedDate = null;

            }
        }
    }
}

