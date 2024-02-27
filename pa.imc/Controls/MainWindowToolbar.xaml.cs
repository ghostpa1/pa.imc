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
using pa.imc;

namespace pa.imc.Controls
{
    /// <summary>
    /// Interaktionslogik für MainWindowToolbar.xaml
    /// </summary>
    public partial class MainWindowToolbar : UserControl
    {
        public MainWindowToolbar()
        {
            InitializeComponent();
        }

        private void ColorSchemeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (ColorSchemeComboBox.SelectedIndex)
            {
                case 0: // Hell
                    Resources["ActiveBackgroundBrush"] = Resources["LightBackgroundBrush"];
                    Resources["ActiveForegroundBrush"] = Resources["LightForegroundBrush"];
                    break;
                case 1: // Dunkel
                    Resources["ActiveBackgroundBrush"] = Resources["DarkBackgroundBrush"];
                    Resources["ActiveForegroundBrush"] = Resources["DarkForegroundBrush"];
                    break;
                case 2: // Blau
                    Resources["ActiveBackgroundBrush"] = Resources["BlueBackgroundBrush"];
                    Resources["ActiveForegroundBrush"] = Resources["BlueForegroundBrush"];
                    break;
                default:
                    break;
            }
        }

        private void Neuen_Raum_Anlegen_Click(object sender, RoutedEventArgs e)
        {
            // Öffnen Sie ein neues Fenster zum Hinzufügen eines Raums
            AddRoomWindow addRoomWindow = new AddRoomWindow();
            addRoomWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            addRoomWindow.ShowDialog();
        }
    }
}
