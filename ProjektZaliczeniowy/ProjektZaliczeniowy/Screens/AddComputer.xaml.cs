﻿using System;
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
                var computerModels = db.Models.Where(m => m.ModelType == selectedType).ToList();
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
            var computerName = computerNameInput.Text;

            var newComputer = new Computers() {
                ComputerModelId = computerModelId,
                ComputerName = computerName,
                ComputerPrice = computerPrice,
                ComputerType = computerType
            };

            db.Computers.Add(newComputer);
        }

        private void computerTypeSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            fillComputerModels();
        }
    }
}
