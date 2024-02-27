using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using pa.imc.logik.Daten;

namespace pa.imc.viewmodel.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string _pfad = Properties.Resources.AppResourcenPfad + Properties.Resources.AppResourcenRaumLIste; // "C:/Test/MCH/raumliste.xml";

        private Raum? _ausgewählterRaum;
        public Raum? AusgewählterRaum
        {
            get { return _ausgewählterRaum; }
            set
            {
                _ausgewählterRaum = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Raum> Raumliste { get; }


        public MainViewModel()
        {
            // Hier könntest du die Raumliste initialisieren
            XmlController<ObservableCollection<Raum>> xmlController = new XmlController<ObservableCollection<Raum>>(_pfad);

            Raumliste = xmlController.LadenXml();

            if (Raumliste == null)
            {
                Raumliste = new ObservableCollection<Raum>();
            }
            // Den ersten Raum auswählen, wenn die Raumliste nicht leer ist
            if (Raumliste.Count > 0)
            {
                AusgewählterRaum = Raumliste[0];
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
