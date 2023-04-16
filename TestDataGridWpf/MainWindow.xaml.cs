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
using TestDataGridWpf.Classes;
using TestDataGridWpf.Models;

namespace TestDataGridWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SignInWindow signInWindow = new SignInWindow(this);
            signInWindow.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<User> users = DataAccess.GetUsers();
            usersDataGrid.ItemsSource = users;

            petsDataGrid.ItemsSource = users.First().Pets;
        }

        private void usersDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var user = usersDataGrid.SelectedItem as User;
            if (user != null)
            {
                petsDataGrid.ItemsSource = user.Pets;
            }
        }

        private void petsDataGrid_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {

        }

        private void petsDataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            var result = MessageBox.Show("Save?", "Saving", MessageBoxButton.OKCancel);
            

            if (result == MessageBoxResult.OK)
            {

            }
            else
            {

            }
        }
    }
}
