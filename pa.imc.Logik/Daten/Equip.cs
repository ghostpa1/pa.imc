using pa.imc.logik.Daten;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace pa.imc.logik.Daten
{
    public class Equip
    {
        public string? Name { get; set; }
        public string? MangelBeschreibung { get; set; }
        public bool Geprüft {  get; set; }
        public DateTime PrüfDatum {  get; set; }
    }
}