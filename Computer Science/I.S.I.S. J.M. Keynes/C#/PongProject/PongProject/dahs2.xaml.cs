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
using System.Threading;

namespace PongProject
{
    /// <summary>
    /// Interaction logic for dahs2.xaml
    /// </summary>
    public partial class dahs2 : UserControl
    {
        public static bool CPU;
        public static bool pl1;
        public static bool pl2;


        public dahs2()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            {
                List<Utente> a = File_manager.read_list();

                if (MainWindow.first == true)
                {
                    bt_pl1_ready.Visibility = Visibility.Hidden;

                    rb_1vs1.Visibility = Visibility.Hidden;
                    rb_1vsCPU.Visibility = Visibility.Hidden;
                    lb_mod.Visibility = Visibility.Hidden;
                    session session_2 = ((MainWindow)Window.GetWindow(this)).session2;

                    foreach (Utente p in a)
                    {
                        if (p.username == session_2.user && p.password == session_2.password)
                        {
                            lb_name.Content = p.username;

                            lb_stat_win.Content = "W: " + p.vittorie.ToString();

                            lb_stat_lose.Content = "L: " + p.sconfitte.ToString();

                            MainWindow.pl2 = true;
                            
                        }
                    }
                }

                if (MainWindow.first == false)
                {
                    MainWindow.first = true;
                    if (MainWindow.pl1 == true)
                    {
                        session session_1 = ((MainWindow)Window.GetWindow(this)).session1;

                        foreach (Utente p in a)
                        {
                            if (p.username == session_1.user && p.password == session_1.password)
                            {
                                lb_name.Content = p.username;

                                lb_stat_win.Content = "W: " + p.vittorie.ToString();

                                lb_stat_lose.Content = "L: " + p.sconfitte.ToString();
                                
                               
                            }
                        }
                    }

                }


            }
        }



        private void Bt_pl1_ready_Click(object sender, RoutedEventArgs e)
        {
            if (rb_1vsCPU.IsChecked == true && MainWindow.pl1 == true && MainWindow.pl2 == true)
            {
                MessageBox.Show("Impossibile giocare con la CPU e 2 giocatori!");
            }
            else
            {


                if (rb_1vs1.IsChecked == true)
                {
                    CPU = false;
                    if (MainWindow.pl1 == true && MainWindow.pl2 == true)
                    {
                        pl1 = true;
                        pl2 = true;

                    }
                    if (MainWindow.pl1 == true && MainWindow.pl2 == false)
                    {
                        pl1 = true;
                        pl2 = false;

                    }
                }
                if (rb_1vsCPU.IsChecked == true)
                {
                    pl1 = true;
                    CPU = true;
                }


                game game = new game();
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
                bt_pl1_ready.Visibility = Visibility.Hidden;
                
                Sound.PlayFile_menu(false);
                game.Show();

            }
        }
    }
}


