namespace ZbW.ProgrammingFoundationShort.Lessons.Module05.Auftrag3_FilmarchivAuswertung;

/// <summary>
///   Lösung: Auftrag 3 – Filmarchiv-Auswertung mit LINQ
/// </summary>
public static class FilmarchivAuswertungLoesung
{
  public static void Start()
  {
    // Filmarchiv: Name → Erscheinungsjahr
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

    // Alle Filme nach 2000
    Console.WriteLine("Filme nach 2000:");
    var nachZweitausend = filme.Where(f => f.Value > 2000).OrderBy(f => f.Value);
    foreach (var film in nachZweitausend)
      Console.WriteLine($"  {film.Key} ({film.Value})");

    // Alphabetisch sortiert
    Console.WriteLine("\nAlphabetisch sortiert:");
    foreach (var film in filme.OrderBy(f => f.Key))
      Console.WriteLine($"  {film.Key} ({film.Value})");

    // Statistiken
    int fruehestes = filme.Min(f => f.Value);
    int spaetestes = filme.Max(f => f.Value);
    int anzahlNach2010 = filme.Count(f => f.Value > 2010);

    Console.WriteLine($"\nFrühstes Erscheinungsjahr: {fruehestes}");
    Console.WriteLine($"Spätestes Erscheinungsjahr: {spaetestes}");
    Console.WriteLine($"Filme nach 2010: {anzahlNach2010}");
  }
}
