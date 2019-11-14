using System;
using System.Collections;
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
using System.Text.RegularExpressions;

namespace Salvataggio_nome_e_cognome
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            StreamReader objReader = new StreamReader("lista_utenti.txt");
            string sLine = objReader.ReadToEnd();
            objReader.Close();
            char[] delimiterChars = { ',', ';', '\n', '\r' };
            string[] utenti = sLine.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < utenti.Length; i++)
            {
                Utenti temp = new Utenti();
                if (i % 2 == 0)
                {
                    temp.last_name = utenti[i];
                    temp.first_name = utenti[i + 1];
                    datagrid.Items.Add(temp);

                }
            }

        }

        private void bt_name_Click(object sender, RoutedEventArgs e)
        {
            string nome = tb_name.Text, cognome = tb_cognome.Text;
            if (nome != "" && cognome != "")
            {
                salvataggio.salva(nome, cognome);
                Utenti temp = new Utenti();
                temp.last_name = cognome;
                temp.first_name = nome;
                datagrid.Items.Add(temp);
                MessageBox.Show("Salvataggio completato");


            }
            else
            {
                MessageBox.Show("Inserisci il nome e cognome nei campi!");
            }
        }
        public class Utenti
        {
            public string first_name { get; set; }
            public string last_name { get; set; }

        }
    }
}
