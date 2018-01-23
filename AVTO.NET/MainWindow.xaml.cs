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
using System.Collections.ObjectModel;

namespace AVTO.NET
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Oglas> oglasi;
        public MainWindow()
        {
            InitializeComponent();
            oglasi = new ObservableCollection<Oglas>() {
                new Oglas("Ford", "Mustang V8", 150000, 27900, 2005, "images/mustang.jpeg", "Alen", "Bracko", "Slovenske Konjice", 040138840),
                new Oglas("Ford", "Mondeo", 200000, 7500, 2004, "/images/mondeo.jpg", "alen", "bracko", "licenca", 040138840)
            };
            listViewOglasi.ItemsSource = oglasi;

        }


        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            
           oglasi.Add(new Oglas());


        }

       

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            if(listViewOglasi.SelectedIndex >= 0) { 
            listViewOglasi.Items.RemoveAt(listViewOglasi.SelectedIndex);
            }
        }

        private void listViewOglasi_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selected = listViewOglasi.SelectedItem as Oglas;
            MessageBox.Show("Znamka: " + selected.znamka);
        }
    }
}
