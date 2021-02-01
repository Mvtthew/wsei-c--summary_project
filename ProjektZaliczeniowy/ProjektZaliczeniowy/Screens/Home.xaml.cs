using ProjektZaliczeniowy.Screens;
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

namespace ProjektZaliczeniowy
{
    /// <summary>
    /// Logika interakcji dla klasy Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void GoToComputerAdd(object sender, RoutedEventArgs e)
        {
            var addComputer = new AddComputer();
            NavigationService.Navigate(addComputer);
        }
        
        private void GoToModelAdd(object sender, RoutedEventArgs e)
        {
            var addModel = new AddModel();
            NavigationService.Navigate(addModel);
        }
        
        private void GoToClientAdd(object sender, RoutedEventArgs e)
        {
            var addClient = new AddClient();
            NavigationService.Navigate(addClient);
        }

        private void GoToReservationAdd(object sender, RoutedEventArgs e)
        {
            var addReservation = new AddReservation();
            NavigationService.Navigate(addReservation);
        }
        
        private void GoToReservationPay(object sender, RoutedEventArgs e)
        {
            var payReservation = new PayReservation();
            NavigationService.Navigate(payReservation);
        }
    }
}
