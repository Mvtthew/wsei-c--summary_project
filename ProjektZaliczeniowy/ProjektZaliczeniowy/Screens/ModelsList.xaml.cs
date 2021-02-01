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
    /// Logika interakcji dla klasy ClientsList.xaml
    /// </summary>
    public partial class ModelsList : Page
    {
        public ModelsList()
        {
            InitializeComponent();
            fillModelsList();
        }

        private void fillModelsList()
        {
            var db = new computerEntities();

            modelsDataGrid.ItemsSource = db.Models.ToList();
        }
    }
}
