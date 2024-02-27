using System.Diagnostics;
using System.Xml.Serialization;

public class XmlController<T> where T : new()
{
    public string Pfad { get; set; }

    public XmlController(string pfad)
    {
        Pfad = pfad;
    }

    public void SpeichernXml(T daten)
    {
        XmlSerializer schreiber = new XmlSerializer(typeof(T));
        try
        {
            using (System.IO.FileStream fs = new System.IO.FileStream(Pfad, System.IO.FileMode.Create))
            {
                schreiber.Serialize(fs, daten);
            }
        }
        catch (IOException ex)
        {
            //ToDo: hübscher machen
            Console.WriteLine("Fehler beim Speichern der Datei: " + ex.Message);
        }
    }

    public T LadenXml()
    {
        return LadenXml(Pfad);
    }

    public T LadenXml(string pfad)
    {
        if (System.IO.File.Exists(pfad))
        {
            XmlSerializer leser = new XmlSerializer(typeof(T));
            using (System.IO.FileStream fs = new System.IO.FileStream(pfad, System.IO.FileMode.Open))
            {
#pragma warning disable CS8600 // Das NULL-Literal oder ein möglicher NULL-Wert wird in einen Non-Nullable-Typ konvertiert.
#pragma warning disable CS8603 // Mögliche Nullverweisrückgabe.
                return (T)leser.Deserialize(fs);
#pragma warning restore CS8603 // Mögliche Nullverweisrückgabe.
#pragma warning restore CS8600 // Das NULL-Literal oder ein möglicher NULL-Wert wird in einen Non-Nullable-Typ konvertiert.
            }
        }
        else
        {
            throw new System.IO.FileNotFoundException("Die XML-Datei wurde nicht gefunden.", pfad);
        }
    }
}
