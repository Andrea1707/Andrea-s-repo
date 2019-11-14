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

namespace PongProject
{
    /// <summary>
    /// Interaction logic for Game_dashboard.xaml
    /// </summary>
    public partial class Game_dashboard : UserControl
    {
        public Game_dashboard()
        {
            InitializeComponent();
            login a = new login();
            //Margin = "10,32,0,32"
            a.tb_username.Margin = new Thickness(10, 32, 0, 32);
            a.tb_password.Margin = new Thickness(10, 32, 0, 32);
            a.Username.Margin = new Thickness(10, 32, 0, 32);
            a.password.Margin = new Thickness(10, 32, 0, 32);
            a.bt_login.Margin = new Thickness(0, 0, 0, 0);
            a.bt_register.Margin = new Thickness(0, 0, 0, 0);
            a.bt_login.VerticalAlignment = VerticalAlignment.Center;
            a.bt_login.HorizontalAlignment = HorizontalAlignment.Center;
            grid_Game_dashboard.Children.Add(a);
        }


        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (MainWindow.pl1 == true)
            {
                grid_Game_dashboard_2.Children.Clear();
                dahs2 btpl1 = new dahs2();
                grid_Game_dashboard_2.Children.Add(btpl1);
            }
        } 
    }
}


