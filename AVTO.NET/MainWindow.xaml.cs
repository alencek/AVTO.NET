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

namespace AVTO.NET
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void DodajOglas(Oglas oglas)
        {
            DockPanel dock = new DockPanel();
            dock.LastChildFill = false;
            Binding bnd = new Binding("Value") { ElementName = "listViewOglasi" };
            BindingOperations.SetBinding(dock, DockPanel.WidthProperty, bnd);

            Border bord = new Border(); //BORDER ZA SLIKO
            bord.BorderThickness = new Thickness(1, 1, 1, 1);
            bord.BorderBrush = Brushes.LightBlue;

            Image slika = new Image(); //SLIKA
            slika.SetValue(BackgroundProperty, Brushes.White);
            slika.Height = 150;
            slika.Width = 150;
            string ImagesPath = oglas.slika;
            slika.Source = new BitmapImage(new Uri(ImagesPath, UriKind.RelativeOrAbsolute));

            bord.Child = slika;
            dock.Children.Add(bord);

            Label opis = new Label();
            opis.Margin = new Thickness(10, 1, 1, 1);
            opis.Content = oglas.znamka + " " + oglas.model + "\nLetnik 1.registracije: " + oglas.letnik + "\n" + oglas.prevozenihKm +"km" ;
            dock.Children.Add(opis);

            Label cena = new Label();
            cena.Background = Brushes.White;
            cena.FontSize = 25;
            cena.Content = oglas.cena+"€";
            cena.Margin = new Thickness(0, 0, 50, 50);
            cena.BorderBrush = Brushes.LightBlue;
            cena.BorderThickness = new Thickness(1, 1, 1, 1);
            cena.HorizontalContentAlignment = HorizontalAlignment.Center;
            cena.SetValue(Label.FontWeightProperty, FontWeights.Bold);
            DockPanel.SetDock(cena, Dock.Right);

            dock.Children.Add(cena);


            listViewOglasi.Margin = new Thickness(0, 10, 0, 10);
            ListViewItem i = new ListViewItem();
            i.Content = dock;
            listViewOglasi.Items.Insert(0, i);
            

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            
            DodajOglas(new Oglas("Ford", "Mustang V8", 150000, 27900, 2005, "images/mustang.jpeg"));


        }

        private void listViewOglasi_Loaded(object sender, RoutedEventArgs e)
        {
            DodajOglas(new Oglas());
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
            DependencyObject obj = (DependencyObject)e.OriginalSource;

            while (obj != null && obj != listViewOglasi)
            {
                if (obj.GetType() == typeof(ListViewItem))
                {
                    
                    MessageBox.Show("");

                    break;
                }
                obj = VisualTreeHelper.GetParent(obj);
            }
        }
    }
}
