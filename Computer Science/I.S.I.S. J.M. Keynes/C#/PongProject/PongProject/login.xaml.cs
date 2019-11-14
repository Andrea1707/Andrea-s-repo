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
using System.Threading;

namespace PongProject
{
    
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : UserControl
    {
        public bool login_state = false;

        public login()
        {
            InitializeComponent();
            
        }
        
        private void Bt_register_Click(object sender, RoutedEventArgs e)
        {
            bool errore = false;
            string a = tb_username.Text;
            string b = tb_password.Password;

            Utente utente = new Utente(a, b);
            if (File.Exists("user_list.xml"))
            {
               List<Utente> tmp= File_manager.read_list();
                foreach (Utente p in tmp)
                {
                    if (p.username == a)
                    {
                        MessageBox.Show("Username gia' presente nel sistema!");
                        errore = true;

                    }
                }
            }
            if (errore == false)
            {

                if (!File.Exists("user_list.xml"))
                {
                    List<Utente> c = new List<Utente>();
                    c.Add(utente);
                    File_manager.Save_user(c);
                    MessageBox.Show("Utente creato!");
                }
                else
                {

                    List<Utente> c = File_manager.read_list();
                    c.Add(utente);
                    File_manager.Save_user(c);
                    MessageBox.Show("Utente creato!");
                }
            }
            
            tb_username.Text = null;
            tb_password.Password = null;

            

        }

        private void Bt_login_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists("user_list.xml"))
            {

                List<Utente> a = File_manager.read_list();
                foreach (Utente p in a)
                {
                    if (p.username == tb_username.Text && p.password == tb_password.Password)
                    {
                        if (MainWindow.pl1 == false)
                        {
                            login_state = true;
                            ((MainWindow)Window.GetWindow(this)).session1 = new session(p.username, p.password);
                            MainWindow.pl1 = true;
                            grid_login.Children.Clear();
                            var game_dash = new Game_dashboard();
                            game_dash.SetValue(Grid.ColumnSpanProperty, 2);
                            game_dash.SetValue(Grid.RowSpanProperty, 4);

                            grid_login.Children.Add(game_dash);


                        }
                        else
                        {
                            login_state = true;
                            ((MainWindow)Window.GetWindow(this)).session2 = new session(p.username, p.password);

                            dahs2 dahs = new dahs2();

                            ((login)((Game_dashboard)((login)(((MainWindow)Window.GetWindow(this)).grid_MainWindow.Children[0])).grid_login.Children[0]).grid_Game_dashboard.Children[0]).grid_login.Children.Clear();

                            ((Game_dashboard)((login)(((MainWindow)Window.GetWindow(this)).grid_MainWindow.Children[0])).grid_login.Children[0]).grid_Game_dashboard.Children.Add(dahs);
                        }
                    }
                    
                }
                if (login_state == false)
                {
                    MessageBox.Show("Credeziali errate.");
                }
            }
            else
            {
                MessageBox.Show("Nessun player registrato.");
            }
            

        }
    }
}
