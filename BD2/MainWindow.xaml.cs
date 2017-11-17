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
        private static readonly string defaultUsername = "USERNAME";
        private static readonly string defaultPassword = "XXXXX";
        private static readonly string defaultSearchMessage = "Search by model name...";
        private static readonly string defaultYearOlderThan = "Older than...";
        private static readonly string defaultYearNewerThan = "Newer than...";

        private static ViewModel vm;

        public MainWindow()
        {
            InitializeComponent();
            vm = new ViewModel();
            DataContext = vm;
                
            TextBoxUsername.Text = defaultUsername;
            PasswordBoxUserPassword.Password = defaultPassword;
            TextBoxBrowseSearch.Text = defaultSearchMessage;
            TextBoxBrowseSearchOlderThan.Text = defaultYearOlderThan;
            TextBoxBrowseSearchNewerThan.Text = defaultYearNewerThan;

            //TabLogin.IsSelected = true;
            TabBrowse.IsSelected = true;

            using (var context = new ShopContext())
            {
                PopulateDatabase(context);
                //    context.Manufacturers.Add(new Manufacturer(1, "UVZ", "Uralvagonzavod", "Russia"));
                //    context.Manufacturers.Add(new Manufacturer(2, "KhPZ", "Kharkiv Locomotive Factory", "Russia"));
                //    context.Manufacturers.Add(new Manufacturer(3, "KMZ", " Kurganmashzavod", "Russia"));
                //    context.Manufacturers.Add(new Manufacturer(4, "FIMMF", "First Inner Mongolia Machinery Factory", "China"));
                //    context.Manufacturers.Add(new Manufacturer(5, "ROF", "Royal Ordnance Factory", "United Kingdom"));
                //    context.SaveChanges();
            }
        }

        #region TextBox Got/Lost Focus
        private void TextBoxUsername_GotFocus(object sender, RoutedEventArgs e)
        {
            if(TextBoxUsername.Text == defaultUsername)
            {
                TextBoxUsername.Text = "";
            }
        }

        private void TextBoxUsername_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxUsername.Text))
            {
                TextBoxUsername.Text = defaultUsername;
            }
        }

        private void PasswordBoxUserPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordBoxUserPassword.Password == defaultPassword)
            {
                PasswordBoxUserPassword.Password = "";
            }    
        }
        private void PasswordBoxUserPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordBoxUserPassword.Password))
            {
                PasswordBoxUserPassword.Password = defaultPassword;
            }
        }

        private void TextBoxBrowseSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TextBoxBrowseSearch.Text == defaultSearchMessage)
            {
                TextBoxBrowseSearch.Text = "";
            }
        }

        private void TextBoxBrowseSearch_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxBrowseSearch.Text))
            {
                TextBoxBrowseSearch.Text = defaultSearchMessage;
            }
        }

        private void TextBoxBrowseSearchOlderThan_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TextBoxBrowseSearchOlderThan.Text == defaultYearOlderThan)
            {
                TextBoxBrowseSearchOlderThan.Text = "";
            }
        }

        private void TextBoxBrowseSearchOlderThan_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxBrowseSearchOlderThan.Text))
            {
                TextBoxBrowseSearchOlderThan.Text = defaultYearOlderThan;
            }
        }

        private void TextBoxBrowseSearchNewerThan_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TextBoxBrowseSearchNewerThan.Text == defaultYearNewerThan)
            {
                TextBoxBrowseSearchNewerThan.Text = "";
            }
        }

        private void TextBoxBrowseSearchNewerThan_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxBrowseSearchNewerThan.Text))
            {
                TextBoxBrowseSearchNewerThan.Text = defaultYearNewerThan;
            }
        }
        #endregion

        #region Database test

        private void PopulateDatabase(ShopContext context)
        {
            context.Manufacturers.Add(new Manufacturer(1, "UVZ", "Uralvagonzavod", "Russia"));
            context.Manufacturers.Add(new Manufacturer(2, "KhPZ", "Kharkiv Locomotive Factory", "Russia"));
            context.Manufacturers.Add(new Manufacturer(3, "KMZ", " Kurganmashzavod", "Russia"));
            context.Manufacturers.Add(new Manufacturer(4, "FIMMF", "First Inner Mongolia Machinery Factory", "China"));
            context.Manufacturers.Add(new Manufacturer(5, "ROF", "Royal Ordnance Factory", "United Kingdom"));

            context.SaveChanges();
        }
        #endregion
    }
}
