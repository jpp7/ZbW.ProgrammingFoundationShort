namespace ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag3_DatentypQuiz;

/// <summary>
/// Musterlösung: Auftrag 3 – Datentyp-Quiz
/// </summary>
public static class DatentypQuizLoesung
{
  private static readonly string[] Fragen =
  {
    "Wie viele Bits hat ein int?",
    "Welcher Typ speichert true/false?",
    "Was ist der Standardwert von int?",
    "Welcher Typ eignet sich für genaue Geldbeträge?",
    "Was ist der Maximalwert von byte?"
  };

  private static readonly string[] Antworten =
  {
    "32",
    "bool",
    "0",
    "decimal",
    "255"
  };

  public static void Start()
  {
    var stopwatch = new System.Diagnostics.Stopwatch();
    stopwatch.Start();

    int punkte = 0;

    for (int i = 0; i < Fragen.Length; i++)
    {
      Console.Write($"Frage {i + 1}: {Fragen[i]} ");
      string antwort = Console.ReadLine() ?? "";

      if (IstKorrekt(antwort, Antworten[i]))
      {
        Console.WriteLine("  Richtig!");
        punkte++;
      }
      else
      {
        Console.WriteLine($"  Falsch. Richtige Antwort: {Antworten[i]}");
      }
    }

    stopwatch.Stop();
    Console.WriteLine($"\nResultat: {punkte}/5");
    Console.WriteLine($"Zeit: {stopwatch.Elapsed.TotalSeconds:F1} Sekunden");
  }

  public static bool IstKorrekt(string gegebeneAntwort, string richtigeAntwort)
  {
    return gegebeneAntwort.Trim().ToLower() == richtigeAntwort.ToLower();
  }
}
