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
using System.Windows.Shapes;

namespace AVTO.NET
{
    /// <summary>
    /// Interaction logic for DodajOglas.xaml
    /// </summary>
    public partial class DodajOglas : Window
    {
        public DodajOglas()
        {
            InitializeComponent();
          
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Oglas o = new Oglas("Fordosaki", "Mustang V8", 150000, 27900, 2005, "images/mustang.jpeg", "Alen", "Bracko", "Slovenske Konjice", 040138840);
            ((MainWindow)Application.Current.MainWindow).DodajNovOglas(o);
        }
    }
}
