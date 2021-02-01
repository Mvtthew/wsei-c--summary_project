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
    /// Logika interakcji dla klasy AddClient.xaml
    /// </summary>
    public partial class AddClient : Page
    {
        public AddClient()
        {
            InitializeComponent();
            fillGenderSelect();
        }

        private void fillGenderSelect()
        {
            clientGenderSelect.Items.Clear();

            clientGenderSelect.Items.Add("F");
            clientGenderSelect.Items.Add("M");
            clientGenderSelect.Items.Add("O");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            errorText.Text = "";

            var db = new computerEntities();

            if (clientNameInput.Text == "")
            {
                errorText.Text = "Podaj imię i nazwisko.";
                return;
            }
            if (clientEmailInput.Text == "")
            {
                errorText.Text = "Podaj e-mail.";
                return;
            }
            if (clientPhoneInput.Text == "")
            {
                errorText.Text = "Podaj numer telefonu.";
                return;
            }
            if (clientGenderSelect.SelectedItem == null)
            {
                errorText.Text = "Wybierz płeć.";
                return;
            }

            var clientName = clientNameInput.Text;
            var clientEmail = clientEmailInput.Text;
            var clientPhone = clientPhoneInput.Text;
            var clientGender = clientGenderSelect.SelectedItem.ToString();

            var newClient = new Clients()
            {
                ClientName = clientName,
                ClientEmail = clientEmail,
                ClientPhone = clientPhone,
                ClientGender = clientGender
            };

            db.Clients.Add(newClient);

            db.SaveChanges();

        }
    }
}
