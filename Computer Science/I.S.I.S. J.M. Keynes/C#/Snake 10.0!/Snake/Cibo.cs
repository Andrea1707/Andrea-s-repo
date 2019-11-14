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
    public class Cibo
    {
        private double canvas_width, canvas_height;
        public Cibo()
        {

        }
        public Cibo(double l, double h)
        {
            canvas_width = l;
            canvas_height = h;
        }
        
        public Point P_Rossa = new Point();
        //int altezza = 1270; // 1160/5 px
        //int larghezza = 720; //550/5
        public Ellipse DisegnaCibo() //ritorna la pallina
        {
            

            Ellipse PP_rossa = new Ellipse();
            PP_rossa.Width = 20;
            PP_rossa.Height = 20;
            ImageBrush ib = new ImageBrush();
            ib.ImageSource = new BitmapImage(new Uri(@"pack://application:,,/Resources/mela.png"));
            PP_rossa.Fill = ib;
            Canvas.SetLeft(PP_rossa, P_Rossa.X);
            Canvas.SetTop(PP_rossa, P_Rossa.Y);
            return PP_rossa;
        }

        public Point GetRosso()
        {
            return P_Rossa;
        }

        public void Sposta() // sposta la pallina rossa in un punto a caso
        {
            P_Rossa.X = new Random().Next(20, (int)canvas_width - 20);
            P_Rossa.Y = new Random().Next(20, (int)canvas_height - 20);
        }
    }
}
