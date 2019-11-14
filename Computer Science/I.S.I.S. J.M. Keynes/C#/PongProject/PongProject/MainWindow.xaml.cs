using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
namespace PongProject
{
    
    public partial class MainWindow : Window
    {
        public static bool Online;
        public static bool first = false;
        public static bool pl1=false;
        public static bool pl2=false;
        public login login = new login();
        public session session1;
        public session session2;

        public static double width = System.Windows.SystemParameters.PrimaryScreenWidth;
        public static double height = System.Windows.SystemParameters.PrimaryScreenHeight;





        public MainWindow()
        {
            
            InitializeComponent();
            main.Width = width;
            main.Height = height;
            Sound.PlayFile_menu(true);

        }

        private void Bt_login_Click(object sender, RoutedEventArgs e)
        {

            Online = true;
            grid_MainWindow.Children.Clear();
            
            login.SetValue(Grid.ColumnSpanProperty, 3);
            login.SetValue(Grid.RowSpanProperty, 3);
            
            grid_MainWindow.Children.Add(login);
            
        }

        private void Bt_offline_Click(object sender, RoutedEventArgs e)
        {
            dahs2.CPU = true;
            
            game game = new game();
            game.Show();
            game.WindowState = WindowState.Maximized;
        }

        private void Grid_MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Image finalImage = new Image() { VerticalAlignment = VerticalAlignment.Top, HorizontalAlignment = HorizontalAlignment.Center };
            finalImage.SetValue(Grid.ColumnProperty,1 );
            finalImage.Source = new BitmapImage(
                                    new Uri("pack://application:,,,/Resources/Pong_Logo.png"));
            grid_title.Children.Add(finalImage);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Bt_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Bt_minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Bt_login_MouseEnter(object sender, MouseEventArgs e)
        {
        }
    }

}

