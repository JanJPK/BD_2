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
using BD2.Models;

namespace BD2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TabLogin.IsSelected = true;
            //using (var context = new ShopContext())
            //{
            //    context.Manufacturers.Add(new Manufacturer(1, "UVZ", "Uralvagonzavod", "Russia"));
            //    context.Manufacturers.Add(new Manufacturer(2, "KhPZ", "Kharkiv Locomotive Factory", "Russia"));
            //    context.Manufacturers.Add(new Manufacturer(3, "KMZ", " Kurganmashzavod", "Russia"));
            //    context.Manufacturers.Add(new Manufacturer(4, "FIMMF", "First Inner Mongolia Machinery Factory", "China"));
            //    context.Manufacturers.Add(new Manufacturer(5, "ROF", "Royal Ordnance Factory", "United Kingdom"));
            //    context.SaveChanges();
            //} 
        }
    }
}
