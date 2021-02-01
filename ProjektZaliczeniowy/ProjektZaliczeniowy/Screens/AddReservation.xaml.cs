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

namespace ProjektZaliczeniowy.Screens
{
    /// <summary>
    /// Logika interakcji dla klasy AddReservation.xaml
    /// </summary>
    public partial class AddReservation : Page
    {
        public AddReservation()
        {
            InitializeComponent();
            fillClientsSelect();
            fillComputersSelect();
        }

        private void fillClientsSelect()
        {
            var db = new computerEntities();

            var clients = db.Clients.ToList();

            clientSelect.Items.Clear();

            clientSelect.DisplayMemberPath = "Text";
            clientSelect.SelectedValuePath = "Value";

            foreach (var client in clients)
            {
                clientSelect.Items.Add(
                    new 
                    { 
                        Text = $"{client.ClientName} [{client.ClientGender}] ({client.ClientEmail} | {client.ClientPhone})", 
                        Value = client.ClientID 
                    }
                );
            }
        }

        private void fillComputersSelect()
        {
            var db = new computerEntities();

            var computers = db.Computers.ToList();

            computerSelect.Items.Clear();

            computerSelect.DisplayMemberPath = "Text";
            computerSelect.SelectedValuePath = "Value";

            foreach (var computer in computers)
            {
                computerSelect.Items.Add(
                    new 
                    { 
                        Text = $"{computer.ComputerName} [{computer.ComputerType}] ({computer.ComputerReservationPrice} PLN / {computer.ComputerPrice} PLN)", 
                        Value = computer.ComputerID 
                    }
                );
            }
        }

        private void calculatePrice()
        {
            var db = new computerEntities();

            var computers = db.Computers.ToList();
            var computer = computers.First(c => c.ComputerID == int.Parse(computerSelect.SelectedValue.ToString()));

            if (computer != null)
            {
                reservationPriceInput.Text = computer.ComputerReservationPrice.ToString();
                summaryPriceInput.Text = (computer.ComputerPrice + computer.ComputerReservationPrice).ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var db = new computerEntities();

            var computers = db.Computers.ToList();
            var computer = computers.First(c => c.ComputerID == int.Parse(computerSelect.SelectedValue.ToString()));

            var newSale = new Sales()
            {
                ClientID = int.Parse(clientSelect.SelectedValue.ToString()),
                ComputerID = int.Parse(computerSelect.SelectedValue.ToString()),
                PriceToPay = decimal.Parse(summaryPriceInput.Text),
            };

            db.Sales.Add(newSale);
            computer.ComputerAmount--;

            db.SaveChanges();
        }

        private void computerSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            calculatePrice();
        }
    }
}
