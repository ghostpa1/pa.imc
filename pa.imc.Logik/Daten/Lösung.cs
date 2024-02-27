using System.ComponentModel.DataAnnotations;

/// <summary>
/// Eine Klasse, die eine Lösung für ein Problem repräsentiert
/// <param name="LösungId">Gibt die LösungsId an oder stellt diese ein</param>
/// <param name="Beschreibung">Gibt die Beschreibung an oder stellt diese ein</param>
/// <param name="Datum">Gibt das Datum an oder stellt dieses ein</param>
/// <param name="MangelId">Gibt die MangelId an oder stellt diese ein</param>
/// <attribut name="Required">Das Attribut stellt sicher, dass das Feld einen Wert hat</attribut>
/// </summary>
public class Lösung
{
    [Required]
    int LösungId { get; set; }

    public string? Beschreibung { get; set; }

    [Required]
    public DateTime Datum { get; set; }

    [Required]
    public int MangelId { get; set; }
}


