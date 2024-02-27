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
using System.Windows.Shapes;
using pa.imc.Controls;
using pa.imc.logik.Daten;
using pa.imc.viewmodel.ViewModels;

namespace pa.imc
{
    /// <summary>
    /// Interaktionslogik für AddRoomWindow.xaml
    /// </summary>
    public partial class AddRoomWindow : Window
    {
        public AddRoomWindow()
        {
            InitializeComponent();
            DataContext = new AddRoomViewModel();
        }

    }
}
