namespace ZbW.ProgrammingFoundationShort.Lessons.Module05.Auftrag3_FilmarchivAuswertung;

/// <summary>
///   Lösung: Auftrag 3 – Filmarchiv-Auswertung ohne LINQ
/// </summary>
public static class FilmarchivAuswertungLoesung
{
  public static void Start()
  {
    var filme = new Dictionary<string, int>
    {
      ["The Shawshank Redemption"] = 1994,
      ["The Dark Knight"] = 2008,
      ["Forrest Gump"] = 1994,
      ["Inception"] = 2010,
      ["The Matrix"] = 1999,
      ["Avengers: Endgame"] = 2019,
      ["Titanic"] = 1997,
      ["Parasite"] = 2019
    };

    Console.WriteLine("=== Filmarchiv-Auswertung ===\n");

    Console.WriteLine("Alle Filme:");
    foreach (KeyValuePair<string, int> film in filme)
    {
      Console.WriteLine($"  {film.Key} ({film.Value})");
    }

    Console.WriteLine("\nFilme ab 2000:");
    foreach (KeyValuePair<string, int> film in filme)
    {
      if (film.Value >= 2000)
      {
        Console.WriteLine($"  {film.Key} ({film.Value})");
      }
    }

    int fruehestes = int.MaxValue;
    int spaetestes = int.MinValue;
    int anzahlNach2010 = 0;

    foreach (KeyValuePair<string, int> film in filme)
    {
      if (film.Value < fruehestes)
      {
        fruehestes = film.Value;
      }

      if (film.Value > spaetestes)
      {
        spaetestes = film.Value;
      }

      if (film.Value > 2010)
      {
        anzahlNach2010++;
      }
    }

    Console.WriteLine($"\nFrühstes Erscheinungsjahr: {fruehestes}");
    Console.WriteLine($"Spätestes Erscheinungsjahr: {spaetestes}");
    Console.WriteLine($"Filme nach 2010: {anzahlNach2010}");
  }
}