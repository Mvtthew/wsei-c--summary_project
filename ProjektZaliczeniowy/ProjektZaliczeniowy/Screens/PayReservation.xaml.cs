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
    /// Logika interakcji dla klasy PayReservation.xaml
    /// </summary>
    public partial class PayReservation : Page
    {
        public PayReservation()
        {
            InitializeComponent();
            fillReservationsSelect();
        }

        private void fillReservationsSelect()
        {
            reservationSelect.Items.Clear();
            reservationSelect.DisplayMemberPath = "Text";
            reservationSelect.SelectedValuePath = "Value";

            var db = new computerEntities();

            var reservations = db.Sales.Join(db.Clients, ep => ep.ClientID, e => e.ClientID, (ep, e) => new { ep, e }).Join(db.Computers, ep => ep.ep.ComputerID, e => e.ComputerID, (ep, e) => new { ep, e }).Where(r => r.ep.ep.Payed == null).ToList();

            foreach (var reservation in reservations)
            {
                reservationSelect.Items.Add(
                    new 
                    {
                        Value = reservation.ep.ep.ReservationID,
                        Text = $"{reservation.ep.e.ClientName} - {reservation.e.ComputerName} [{reservation.e.ComputerType}] ({reservation.e.ComputerPrice} PLN)",
                    }
                );
            }
        }

        private void showPrice()
        {
            var db = new computerEntities();

            var reservationID = int.Parse(reservationSelect.SelectedValue.ToString());

            var reservation = db.Sales.First(r => r.ReservationID == reservationID);

            reservationPriceInput.Text = reservation.PriceToPay.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var db = new computerEntities();

            var reservationID = int.Parse(reservationSelect.SelectedValue.ToString());

            var reservation = db.Sales.First(r => r.ReservationID == reservationID);

            if (reservation != null)
            {
                reservation.Payed = true;
                db.SaveChanges();
            }
        }

        private void reservationSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            showPrice();
        }
    }
}
