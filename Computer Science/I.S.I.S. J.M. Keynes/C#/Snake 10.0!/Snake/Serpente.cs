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
using System.Windows.Threading;

namespace Snake
{

    public class Serpente
    {
        public List<Point> Ssss = new List<Point>(); // serpente
        
        int altezza = 232;
        int larghezza = 110;


        public int direzioneX = 0; //moltiplicatore per la direzione
        public int direzioneY = -1;
        public void CambiaDirezione(int x, int y)
        {
            direzioneX = x;
            direzioneY = y;
        }

        public Serpente(Canvas cv_Gioco) //aggiunge il punto su cui si creerà il serpente
        {
            Point p = new Point((altezza / 2) * 5, (larghezza / 2) * 5);
            Ssss.Add(p);
        }
        public Serpente()
        {
            Point p = new Point((altezza / 2) * 5, (larghezza / 2) * 5);
            Ssss.Add(p);
        }
      
        public void Cresci() // aggiuinge alla fine della lista un altro punto
        {
            Point p = new Point(Ssss[Ssss.Count - 1].X, Ssss[Ssss.Count - 1].Y);
            Ssss.Add(p);
        }

        void MuoviTesta() //muove la testa di 5pixel in base la direzione
        {
            Ssss[0] = new Point(Ssss.ToArray()[0].X += (direzioneX * 20), Ssss.ToArray()[0].Y += (direzioneY * 20));
        }

        public void MuoviSerpente() //muove tutto il serpende seguendo l'ultima posizione della testa
        {
            for (int i = Ssss.Count - 1; i > 0; i--)
            {
                Ssss[i] = new Point(Ssss.ToArray()[i - 1].X, Ssss.ToArray()[i - 1].Y);
            }

            MuoviTesta();
        }

        //public bool Ricevi_red(Point cibo) // se il punto della testa è in coincidenza del cibo, mangia la pallina
        //{
        //    if (!Ssss.Contains(cibo))
        //        return false;
        //    else
        //    {
        //        Cresci();
        //        return true;
        //    }
        //}

        public List<Ellipse> DisegnaSerpente() // mette gli ellissi su ogni punto del serpente 
        { 
            List<Ellipse> ssssss = new List<Ellipse>();           
            foreach (Point p in Ssss)
            {
                Ellipse e = new Ellipse();
                e.Width = 20;
                e.Height = 20;
                Color color = (Color)ColorConverter.ConvertFromString("#8CC73D");
                SolidColorBrush myBrush = new SolidColorBrush(color);
                e.Fill = myBrush;
                Canvas.SetTop(e, p.Y);
                Canvas.SetLeft(e, p.X);
                ssssss.Add(e);
            }
            ImageBrush ib = new ImageBrush();
            ib.ImageSource = new BitmapImage(new Uri(@"pack://application:,,/Resources/sksk.png"));
            ssssss[0].Fill = ib; 
            return ssssss;
        }
    }
}
