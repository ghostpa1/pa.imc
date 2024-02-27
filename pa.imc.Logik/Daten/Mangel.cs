using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace pa.imc.logik.Daten
{
    public class Mangel : INotifyPropertyChanged
    {
        private int _mangelId;
        private string _beschreibung = "";
        private string _status = "";
        private int _raumId;
        private DateTime _datum;

        [Required]
        public int MangelId
        {
            get { return _mangelId; }
            set
            {
                _mangelId = value;
                OnPropertyChanged(nameof(MangelId));
            }
        }

        [Required]
        public string Beschreibung
        {
            get { return _beschreibung; }
            set
            {
                _beschreibung = value;
                OnPropertyChanged(nameof(Beschreibung));
            }
        }

        public string Status
        {
            get { return _status; }
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }

        [Required]
        public int RaumId
        {
            get { return _raumId; }
            set
            {
                _raumId = value;
                OnPropertyChanged(nameof(RaumId));
            }
        }

        public DateTime Datum
        {
            get { return _datum; }
            set
            {
                _datum = value;
                OnPropertyChanged(nameof(Datum));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
