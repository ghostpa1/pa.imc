using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace pa.imc.logik.Daten
{
    public class Raum
    {
        [Required]
        public int RaumId { get; set; }

        public string RaumName { get; set; } = string.Empty;

        public string LangName {  get; set; } = string.Empty;

        public ObservableCollection<Equip>? Ausstattung { get; set; }

        public Raum()
        {
            Ausstattung = new ObservableCollection<Equip>();
        }

        public Raum(int raumId, string raumName, string langName, ObservableCollection<Equip> ausstattung)
        {
            RaumId = raumId;
            RaumName = raumName;
            LangName = langName;
            Ausstattung = ausstattung;
        }
    }
}
