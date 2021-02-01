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
    /// Logika interakcji dla klasy AddComputer.xaml
    /// </summary>
    public partial class AddComputer : Page
    {
        public AddComputer()
        {
            InitializeComponent();
            fillComputerTypes();
        }

        private void fillComputerTypes()
        {
            computerTypeSelect.Items.Clear();

            computerTypeSelect.Items.Add("P");
            computerTypeSelect.Items.Add("L");
        }

        private void fillComputerModels()
        {
            computerModelSelect.Items.Clear();

            computerModelSelect.DisplayMemberPath = "Text";
            computerModelSelect.SelectedValuePath = "Value";

            if (computerTypeSelect.SelectedValue != null)
            {
                var selectedType = computerTypeSelect.SelectedValue.ToString();
                var db = new computerEntities();
                var computerModels = db.Models.ToList();
                foreach(var computerModel in computerModels)
                {
                    computerModelSelect.Items.Add(new { Text = computerModel.ModelName, Value = computerModel.ModelID });
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var db = new computerEntities();

            var computerModelId = int.Parse(computerModelSelect.SelectedValue.ToString());
            var computerType = computerTypeSelect.SelectedValue.ToString();
            var computerPrice = decimal.Parse(computerPriceInput.Text);
            var computerReservationPrice = decimal.Parse(computerReservationPriceInput.Text);
            var computerName = computerNameInput.Text;
            var computerAmount = int.Parse(computerAmountInput.Text);

            var newComputer = new Computers() {
                ComputerModelId = computerModelId,
                ComputerName = computerName,
                ComputerReservationPrice = computerReservationPrice,
                ComputerPrice = computerPrice,
                ComputerType = computerType,
                ComputerAmount = computerAmount
            };

            db.Computers.Add(newComputer);

            db.SaveChanges();
        }

        private void computerTypeSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            fillComputerModels();
        }

        private void computerModelSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
