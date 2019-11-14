using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
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
using System.Windows.Threading;

namespace Snake
{
    /// <summary>
    /// Interaction logic for Gioco.xaml
    /// </summary>
    public partial class Gioco : UserControl
    {
        Serpente s = new Serpente();
        MainWindow mainwindow;
        Cibo c;        
        Window Padre;
        DispatcherTimer spinTimer;
        SoundPlayer player;

       
        public int punti = 0;
        public Gioco(MainWindow mw)
        {
            InitializeComponent();
            mainwindow = mw;
        }
        private void GestioneTasti(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {   //UTILIZZA FRECCETTE PER MUOVERTI
                case Key.Up:
                    if(s.direzioneY != 1)
                        s.CambiaDirezione(0, -1);
                    break;
                case Key.Down:
                    if (s.direzioneY != -1)
                        s.CambiaDirezione(0, 1);
                    break;
                case Key.Left:
                    if (s.direzioneX != 1)
                        s.CambiaDirezione(-1, 0);
                    break;
                case Key.Right:
                    if (s.direzioneX != -1)
                        s.CambiaDirezione(1, 0);
                    break;
            }
            //s.Muoviserpente();
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            Padre = Window.GetWindow(this);
            Padre.KeyDown += GestioneTasti;

            //aggiungo la pallina-cibo
            c = new Cibo(cv_Gioco.ActualWidth, cv_Gioco.ActualHeight);
            c.Sposta();
            cv_Gioco.Children.Add(c.DisegnaCibo());
            //aggiungo il serpente                       
            for (int cont = 0; cont < 5; cont++)
            {
                s.Cresci();
            }      
            //cv_Gioco.Children.Add(P_Rossa);  //Aggiungo pallina
            spinTimer = new DispatcherTimer();
            spinTimer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            spinTimer.Tick += new EventHandler(spinTimer_Tick);
            spinTimer.Start();
        }
        int tik = 0 ;
        int tempo=0;        
        public void spinTimer_Tick(object sender, object e)
        {
            lb_punt.Content = "Punteggio: " + punti;
            tik++;
            if (tik % 10 == 0)
            {
                lb_timer.Content = "Tempo : " + tempo;
                tempo++;
            }           
            //ad ogni tick faccio muovere il serpente
            cv_Gioco.Children.Clear();
            s.MuoviSerpente();
            if (s.Ssss[0].X > cv_Gioco.ActualWidth - 20 || 
                s.Ssss[0].X < 0 || 
                s.Ssss[0].Y > cv_Gioco.ActualHeight - 20 || 
                s.Ssss[0].Y < 0)
            {
                spinTimer.Stop();
                Stream Fail = Application.GetResourceStream(new Uri("pack://application:,,,/Resources/Fail.wav")).Stream;
                player = new SoundPlayer(Fail);

                player.Load();
                player.Play();
             
                s = new Serpente();

                gr_gioco.Children.Clear();
                gr_gioco.Children.Add(new Dati(punti, mainwindow));
               
            }
            if (
                s.Ssss[0].X < c.P_Rossa.X+20.5 && 
                s.Ssss[0].X > c.P_Rossa.X &&
              
                s.Ssss[0].Y > c.P_Rossa.Y && 
                s.Ssss[0].Y < c.P_Rossa.Y+20.5 
                ||
              
                s.Ssss[0].X+20 < c.P_Rossa.X + 20.5 &&
                s.Ssss[0].X+20 > c.P_Rossa.X &&
                s.Ssss[0].Y+20 > c.P_Rossa.Y && 
                s.Ssss[0].Y+20 < c.P_Rossa.Y + 20.5)
            {
                Stream Eat = Application.GetResourceStream(new Uri("pack://application:,,,/Resources/Eat.wav")).Stream;
                player = new SoundPlayer(Eat);
                player.Load();
                player.Play();                                
                s.Cresci();
                s.Cresci();
                punti++;
                lb_punt.Content = punti;
                c.Sposta();
            }      
            for(int cont = 1; cont < s.Ssss.Count; cont ++)
            {
                if(s.Ssss[0].X == s.Ssss[cont].X && s.Ssss[0].Y == s.Ssss[cont].Y)
                {
                    spinTimer.Stop();
                    Stream Fail = Application.GetResourceStream(new Uri("pack://application:,,,/Resources/Fail.wav")).Stream;
                    player = new SoundPlayer(Fail);

                    player.Load();
                    player.Play();

                    s = new Serpente();

                    gr_gioco.Children.Clear();
                    gr_gioco.Children.Add(new Dati(punti, mainwindow));
                }
            }
            Render();
        }
         
        private void Render()
        {       
            //diesegno cibo
            cv_Gioco.Children.Add(c.DisegnaCibo());
            //disegno serpente
            foreach (Ellipse e in s.DisegnaSerpente())
                cv_Gioco.Children.Add(e);
        }

        private void bt_esci_Click(object sender, RoutedEventArgs e)
        {
            mainwindow.gr_contenitore.Children.Clear();
            mainwindow.gr_contenitore.Children.Add(new Menu());
        }
    }
}
