using pa.imc.viewmodel.ViewModels;
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

namespace pa.imc.Controls
{
    /// <summary>
    /// Interaktionslogik für EquipmentListe.xaml
    /// </summary>
    public partial class EquipmentListe : UserControl
    {
        public EquipmentListe()
        {
            InitializeComponent();
            DataContext = new EquipmentViewModel();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
            if (checkBox != null && checkBox.IsChecked == true)
            {
                // Hier können Sie den Namen der Checkbox ändern
                checkBox.Content = "ausgewählt!";

                DataGridRow row = FindVisualParent<DataGridRow>(checkBox);

                if (row != null)
                {
                    row.Background = Brushes.LightGreen;
                }
            }
            else
            {
                if (checkBox != null && checkBox.IsChecked == false)
                {
                    checkBox.Content = "nicht ausgewählt!";
                    DataGridRow row = FindVisualParent<DataGridRow>(checkBox);

                    if (row != null)
                    {
                        row.Background = Brushes.Transparent;
                    }
                }
            }
        }

        public static T FindVisualParent<T>(UIElement element) where T : UIElement
        {
            UIElement parent = element;
            while (parent != null)
            {
                if (parent is T result)
                {
                    return result;
                }
                parent = VisualTreeHelper.GetParent(parent) as UIElement;
            }
            return null;
        }
    }
}
