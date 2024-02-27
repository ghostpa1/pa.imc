using pa.imc;
using System.Configuration;
using System.Data;
using System.Windows;

namespace pa.IMC
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Zentriert das Hauptfenster
            MainWindow mainWindow = new MainWindow();
            mainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            mainWindow.Show();

            // Hier kannst du weitere Fenster deiner App zentriert öffnen
            // Beispiel: MyOtherWindow otherWindow = new MyOtherWindow();
            // otherWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            // otherWindow.Show();
        }
    }

}
