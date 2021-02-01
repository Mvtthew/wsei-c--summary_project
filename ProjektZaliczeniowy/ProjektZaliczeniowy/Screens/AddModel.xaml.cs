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
    /// Logika interakcji dla klasy AddModel.xaml
    /// </summary>
    public partial class AddModel : Page
    {
        public AddModel()
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var db = new computerEntities();

            var modelName = modelNameInput.Text;
            var modelType = computerTypeSelect.SelectedValue.ToString();

            var newModel = new Models() { 
                ModelName = modelName,
                ModelType = modelType
            };

            db.Models.Add(newModel);

            db.SaveChanges();
        }
    }
}
