using Microsoft.Win32;
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

namespace iTunes_1._0
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add : UserControl
    {
        public Add()
        {
            InitializeComponent();
        }
        string img_pah = "";
        string file_path = "";
        private void bt_add_Click(object sender, RoutedEventArgs e)
        {
         
            if (tb_artist.Text == null && tb_genere.Text == null && tb_title.Text == null&&file_path==""&&img_pah=="")
            {
                MessageBox.Show("Insert all the requirements");
            }else
            {
                List<music> tmp = File_manager.read_list();
                string artist = tb_artist.Text;
                string genere = tb_genere.Text;
                string title = tb_title.Text;
                string path = file_path;
                tmp.Add(new music(img_pah, title, artist, genere,path));
                File_manager.Save_music(tmp);
                MessageBox.Show("Song added!");

            }
        }

        private void bt_img_up_Click(object sender, RoutedEventArgs e)
        {
            
            OpenFileDialog a = new OpenFileDialog();
            a.ShowDialog();
            img_pah = a.FileName;
            lb_image_path.Content = img_pah;
        }

        private void bt_file_add_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog a = new OpenFileDialog();
            a.ShowDialog();
                file_path = a.FileName;
                lb_file_path.Content = file_path;
        }
    }
}
