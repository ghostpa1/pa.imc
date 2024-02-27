using pa.imc.logik.Daten;
using pa.imc.viewmodel.Commands;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;

namespace pa.imc.viewmodel.ViewModels
{
    public class AddRoomViewModel : INotifyPropertyChanged
    {
        private string _pfad = Properties.Resources.AppResourcenPfad + Properties.Resources.AppResourcenRaumLIste;

        public ObservableCollection<Raum> Raumliste { get; } = new ObservableCollection<Raum>();

        public ICommand AddRoomCommand { get; }
        public ICommand SaveRoomCommand { get; }

#pragma warning disable CS8618 // Ein Non-Nullable-Feld muss beim Beenden des Konstruktors einen Wert ungleich NULL enthalten. Erwägen Sie die Deklaration als Nullable.
        public AddRoomViewModel()
#pragma warning restore CS8618 // Ein Non-Nullable-Feld muss beim Beenden des Konstruktors einen Wert ungleich NULL enthalten. Erwägen Sie die Deklaration als Nullable.
        {
            AddRoomCommand = new RelayCommand(AddRoom);
            SaveRoomCommand = new RelayCommand(SaveRoom);

            XmlController<ObservableCollection<Raum>> xmlController = new XmlController<ObservableCollection<Raum>>(_pfad);

            Raumliste = xmlController.LadenXml();

            if (Raumliste == null)
            {
                Raumliste = new ObservableCollection<Raum>();
            }
        }

        private void AddRoom(object parameter)
        {
            // Hier Logik zum Hinzufügen eines Raums implementieren
            // Beispiel:
            Raumliste.Add(new Raum(1, "Neuer Raum", "", new ObservableCollection<Equip>()));
        }

        public void SaveRoom(object parameter)
        {
            // Hier Logik zum Speichern eines Raums implementieren
            Debug.Print("Juhu, der Code wurde erreicht!");
        }


        private Raum _selectedRaum;

        public Raum SelectedRaum
        {
            get { return _selectedRaum; }
            set
            {
                _selectedRaum = value;
                OnPropertyChanged(nameof(SelectedRaum));
            }
        }


        private bool _isAddingRoom;

        public event PropertyChangedEventHandler? PropertyChanged;

        public bool IsAddingRoom
        {
            get { return _isAddingRoom; }
            set
            {
                _isAddingRoom = value;
                OnPropertyChanged(nameof(IsAddingRoom));
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
