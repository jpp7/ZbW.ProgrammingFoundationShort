namespace ZbW.ProgrammingFoundationShort.Challenges.Module06.Aufgabe4_Bibliothekssystem;

/// <summary>Buch mit Ausleihe-Status.</summary>
public class Book
{
  public string Title { get; set; } = "";
  public string Author { get; set; } = "";
  public string ISBN { get; set; } = "";
  public bool IsAvailable { get; set; } = true;

  public override string ToString()
  {
    string status = IsAvailable ? "verfügbar" : "ausgeliehen";
    return $"\"{Title}\" von {Author} (ISBN: {ISBN}) – {status}";
  }
}
