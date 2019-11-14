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


namespace iTunes_1._0
{
    /// <summary>
    /// Interaction logic for Song_item.xaml
    /// </summary>
    public partial class Song_item : UserControl
    {
        bool started;
        string c;
        public Song_item(music p)
        {
            InitializeComponent();
            image.Source = new BitmapImage(new Uri(p.image_path));
            lb_title.Content = p.Name;
            lb_artist.Content = p.Artist;
            lb_genere.Content = p.Genere;
            c = p.file_path;
        }
        WMPLib.WindowsMediaPlayer Player;
        private void bt_play_Click(object sender, RoutedEventArgs e)
        {
            if (started == false)
            {
                started = true;
                Player = new WMPLib.WindowsMediaPlayer();
                Player.PlayStateChange +=
                                new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
                Player.MediaError +=
                    new WMPLib._WMPOCXEvents_MediaErrorEventHandler(Player_MediaError);
                Player.URL = c;
                Player.controls.play();
            }
            else
            {
                Player.controls.play();
            }
            
        }
        private void Player_PlayStateChange(int NewState)
        {
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
            {
             //   this.Close();
            }
        }
        private void Player_MediaError(object pMediaObject)
        {
            MessageBox.Show("Cannot play media file.");
           // this.Close();
        }

        private void Bt_pause_Click(object sender, RoutedEventArgs e)
        {
            Player.controls.pause();
        }

        private void Bt_stop_Click(object sender, RoutedEventArgs e)
        {
            Player.controls.stop();
        }
    }
}
