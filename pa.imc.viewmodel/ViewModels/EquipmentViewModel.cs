using pa.imc.logik.Daten;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace pa.imc.viewmodel.ViewModels
{
    public class EquipmentViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<EquipmentCheckBoxViewModel> _equipmentCheckBoxes;
        private ObservableCollection<string> _selectedEquipment;
        private string _filePath = Properties.Resources.AppResourcenPfad + Properties.Resources.AppResourcenEquipmentListe; // "C:/Test/MCH/equipmentliste.xml";

        public ObservableCollection<EquipmentCheckBoxViewModel> EquipmentCheckBoxes
        {
            get { return _equipmentCheckBoxes; }
            set
            {
                _equipmentCheckBoxes = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<string> SelectedEquipment
        {
            get { return _selectedEquipment; }
            set
            {
                _selectedEquipment = value;
                OnPropertyChanged();
            }
        }

        public EquipmentViewModel()
        {
            LoadEquipmentCheckBoxes();
            SelectedEquipment = new ObservableCollection<string>();
        }

        private void LoadEquipmentCheckBoxes()
        {
            XmlController<ObservableCollection<Equip>> controller = new XmlController<ObservableCollection<Equip>>(_filePath);
            var equipmentList = controller.LadenXml();

            EquipmentCheckBoxes = new ObservableCollection<EquipmentCheckBoxViewModel>();

            foreach (var equipment in equipmentList)
            {
                EquipmentCheckBoxes.Add(new EquipmentCheckBoxViewModel(equipment.Name, SelectedEquipment));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class EquipmentCheckBoxViewModel : INotifyPropertyChanged
    {
        private bool _isSelected;
        private string _displayText;
        private ObservableCollection<string> _selectedEquipment;

        public string EquipmentName { get; }

        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                if (_isSelected != value)
                {
                    _isSelected = value;
                    OnPropertyChanged();
                    UpdateSelectedEquipment();
                }
            }
        }

        public string DisplayText
        {
            get { return _displayText; }
            set
            {
                if (_displayText != value)
                {
                    _displayText = value;
                    OnPropertyChanged();
                }
            }
        }

        private void UpdateSelectedEquipment()
        {
            if (IsSelected)
                _selectedEquipment.Add(EquipmentName);
            else
                _selectedEquipment.Remove(EquipmentName);
        }

        public EquipmentCheckBoxViewModel(string equipmentName, ObservableCollection<string> selectedEquipment)
        {
            EquipmentName = equipmentName;
            _selectedEquipment = selectedEquipment;
        }

        private void UpdateDisplayText()
        {
            DisplayText = IsSelected ? "ausgewählt" : "nicht ausgewählt";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
