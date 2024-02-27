using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using pa.imc.viewmodel.ViewModels;

namespace pa.imc.Controls
{
    /// <summary>
    /// Interaktionslogik für NeuenRaumAnlegen.xaml
    /// </summary>
    public partial class NeuenRaumAnlegen : UserControl
    {
        public NeuenRaumAnlegen()
        {
            InitializeComponent();
            DataContext = new AddRoomViewModel();
        }

        private void Abbrechen_Click(object sender, RoutedEventArgs e)
        {
            // Schließen des Fensters
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                parentWindow.Close();
            }
        }

        private void Speichern_Click(object sender, RoutedEventArgs e)
        {
            //Window parentWindow = Window.GetWindow(this);
            MessageBox.Show("speichern wurde gecklickt!");
            
        }

        private void RaumNameKurz_LostFocus(object sender, RoutedEventArgs e)
        {
            if (RaumNameKurz != null)
            {
                Speichern.IsEnabled = true;
            }
        }
    }
}







