using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PongProject
{
    /// <summary>
    /// Interaction logic for game.xaml
    /// </summary>
    public partial class game : Window
    {
        MediaPlayer Sound1 = new MediaPlayer();
        private ViewModel vm = new ViewModel();
        DispatcherTimer timer = new DispatcherTimer();

        public game()
        {
            InitializeComponent();
            Sound.PlayFile_menu(false);
            DataContext = vm;
            game_pong.Width = MainWindow.width;
            game_pong.Height = MainWindow.height;
            MainCanvas.Width = MainWindow.width - 10;
            MainCanvas.Height = MainWindow.height - 10;
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Start();
            timer.Tick += GameTickCalculation;
            right_result.SetValue(Canvas.LeftProperty, (MainWindow.width / 2) + 40);
            left_result.SetValue(Canvas.LeftProperty, (MainWindow.width / 2) - 100);




            line.Y2 = MainWindow.height;
            line.SetValue(Canvas.RightProperty, MainWindow.width / 2);

            right.SetValue(Canvas.LeftProperty, ((MainWindow.width) -30));
        }

        private double angle = 155;
        private double speed = 10;
        private int padSpeed = 60;
        private int Rest = 0;

        void GameTickCalculation(object sender, EventArgs e)
        {
            if (vm.BallYPosition <= 0)
                angle = angle + (180 - 2 * angle);
            if (vm.BallYPosition >= MainCanvas.ActualHeight - 20)
                angle = angle + (180 - 2 * angle);
            if (dahs2.CPU == true)
            {
                if (vm.BallXPosition > MainWindow.height/2)
                {
                    if (vm.BallYPosition > 0)
                        vm.RightPadPosition = (int)vm.BallYPosition;
                    else if (vm.BallYPosition < 0)
                        vm.RightPadPosition = (int)vm.BallYPosition;
                }
                else
                    vm.BallYPosition = vm.BallYPosition;
            }

            if (CheckCollision())
            {
                ChangeAngle();
                vm.changeBallDirection();

            }

            double radians = (Math.PI / 180) * angle;
            Vector vector = new Vector { X = Math.Sin(radians), Y = -Math.Cos(radians) };
            vm.BallXPosition += vector.X * speed;
            vm.BallYPosition += vector.Y * speed;

            if (vm.BallXPosition >= MainCanvas.ActualWidth - 10)
            {
                vm.LeftResult += 1;

                Sound.PlayFile_osteo();
                
                Rest = 1;
                GameResetBallPosition();

                if (vm.LeftResult == 10)
                {
                    MessageBox.Show("Giocatore 1 ha vinto!");
                    

                    if (dahs2.pl1 == true && dahs2.pl2 == true)
                    {

                        List<Utente> tmp = File_manager.read_list();
                        session session1 = ((MainWindow)Window.GetWindow(Application.Current.MainWindow)).session1;
                        session session2 = ((MainWindow)Window.GetWindow(Application.Current.MainWindow)).session2;
                        List<Utente> tmp_new = new List<Utente>();

                        foreach (Utente p in tmp)
                        {
                            if (p.username == session1.user && p.password == session1.password)
                            {
                                p.vittorie++;
                            }
                            if (p.username == session2.user && p.password == session2.password)
                            {
                                p.sconfitte++;
                            }
                            tmp_new.Add(p);
                        }
                        File_manager.Save_user(tmp_new);

                    }

                    if (dahs2.pl1 == true && dahs2.pl2 == false)
                    {

                        List<Utente> tmp = File_manager.read_list();
                        session session1 = ((MainWindow)Window.GetWindow(Application.Current.MainWindow)).session1;
                       
                        List<Utente> tmp_new = new List<Utente>();

                        foreach (Utente p in tmp)
                        {
                            if (p.username == session1.user && p.password == session1.password)
                            {
                                p.vittorie++;
                            }
                            tmp_new.Add(p);
                        }
                        File_manager.Save_user(tmp_new);

                    }
                    Application.Current.MainWindow.Close();
                    this.Close();
                }
            }
            if (vm.BallXPosition <= -10)
            {
                vm.RightResult += 1;
                Sound.PlayFile_osteo();
                Rest = 2;
                GameResetBallPosition();
                if (vm.RightResult == 10 && MainWindow.Online == false)
                {
                    MessageBox.Show("Mac ha vinto!");
                    Application.Current.MainWindow.Close();
                    this.Close();
                }
                else if (vm.RightResult == 10 && MainWindow.Online == true)
                {
                    MessageBox.Show("Giocatore 2 ha vinto!");

                    

                    if (dahs2.pl1 == true && dahs2.pl2 == true)
                    {

                        List<Utente> tmp = File_manager.read_list();
                        session session1 = ((MainWindow)Window.GetWindow(Application.Current.MainWindow)).session1;
                        session session2 = ((MainWindow)Window.GetWindow(Application.Current.MainWindow)).session2;
                        List<Utente> tmp_new = new List<Utente>();

                        foreach (Utente p in tmp)
                        {
                            if (p.username == session1.user && p.password == session1.password)
                            {
                                p.sconfitte++;
                            }
                            if (p.username == session2.user && p.password == session2.password)
                            {
                                p.vittorie++;
                            }
                            tmp_new.Add(p);
                        }
                        File_manager.Save_user(tmp_new);

                    }

                    Application.Current.MainWindow.Close();
                    this.Close();
                }

                
            }
        }

        private void GameResetBallPosition()
        {
            if (Rest % 2 == 0)
            {
                vm.BallYPosition = MainCanvas.Height / 2;
                vm.BallXPosition = MainCanvas.Width / 2;
            }
            else
            {
                vm.BallYPosition = MainCanvas.Height / 2;
                vm.BallXPosition = MainCanvas.Width / 2;
            }
            Rest = 0;
        }

        private void ChangeAngle()
        {
            if (vm.IsBallDirectionRight)
                angle = 270 - ((vm.BallYPosition + 10) - (vm.RightPadPosition + 40));
            else
                angle = 90 + ((vm.BallYPosition + 10) - (vm.LeftPadPosition + 40));
        }

        private bool CheckCollision()
        {

            if (vm.IsBallDirectionRight)
                return vm.BallXPosition >= MainWindow.width - 40 && (vm.BallYPosition > vm.RightPadPosition - 20 && vm.BallYPosition < vm.RightPadPosition + 80);
            
                

            return vm.BallXPosition <= 20 && (vm.BallYPosition > vm.LeftPadPosition - 20 && vm.BallYPosition < vm.LeftPadPosition + 80);
        }

        private void Game_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.Escape))
            {
                this.WindowState = WindowState.Minimized;
                Application.Current.MainWindow.Close();
                this.Close();
            }
            if (Keyboard.IsKeyDown(Key.W)) vm.LeftPadPosition = verifyBounds(vm.LeftPadPosition, -padSpeed);
            if (Keyboard.IsKeyDown(Key.S)) vm.LeftPadPosition = verifyBounds(vm.LeftPadPosition, padSpeed);
            if (MainWindow.Online == true)
            {
                if (Keyboard.IsKeyDown(Key.Up)) vm.RightPadPosition = verifyBounds(vm.RightPadPosition, -padSpeed);
                if (Keyboard.IsKeyDown(Key.Down)) vm.RightPadPosition = verifyBounds(vm.RightPadPosition, padSpeed);
            }
        }

        private int verifyBounds(int position, int change)
        {
            position += change;

            if (position < 0)
                position = 0;
            if (position > (int)MainCanvas.ActualHeight - 90)
                position = (int)MainCanvas.ActualHeight - 90;

            return position;
        }
    }
}
