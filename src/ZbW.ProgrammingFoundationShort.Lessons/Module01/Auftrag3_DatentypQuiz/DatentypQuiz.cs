namespace ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag3_DatentypQuiz;

// ============================================================
// AUFTRAG 3 – Datentyp-Quiz (⭐⭐⭐ Erweitert | ~10 Min.)
//
// Erstelle ein Quiz mit 5 Fragen zu C#-Datentypen.
//
// Anforderungen:
//   - Fragen per Console.Write ausgeben
//   - Antwort mit Console.ReadLine() einlesen
//   - Am Ende: $"Resultat: {punkte}/5" ausgeben
//   - Mindestens 1 Frage erwartet eine Zahl (int.TryParse)
//   - Gross-/Kleinschreibung ignorieren: .ToLower()
//   - Bonus: Zeit pro Frage mit Stopwatch messen
// ============================================================

public static class DatentypQuiz
{
  /// <summary>
  ///   Prüft ob eine Antwort (case-insensitiv) korrekt ist.
  /// </summary>
  public static bool IstKorrekt(string gegebeneAntwort, string richtigeAntwort)
  {
    // TODO: Vergleiche gegebeneAntwort.Trim().ToLower() mit richtigeAntwort.ToLower()
    throw new NotImplementedException("TODO: IstKorrekt implementieren");
  }
  // TODO 1: Fragen und Antworten definieren
  //         Tipp: Verwende zwei parallele Arrays oder ein Dictionary
  //
  // Beispiel-Fragen:
  //   "Wie viele Bits hat ein int?"          → Antwort: "32"
  //   "Welcher Typ speichert true/false?"    → Antwort: "bool"
  //   "Was ist der Standardwert von int?"    → Antwort: "0"
  //   "Welcher Typ für genaue Geldbeträge?"  → Antwort: "decimal"
  //   "Max-Wert von byte?"                   → Antwort: "255"

  /// <summary>
  ///   Startet das Quiz auf der Konsole.
  /// </summary>
  public static void Start()
  {
    // TODO 2: Stopwatch starten (Bonus)
    //         var stopwatch = new System.Diagnostics.Stopwatch();
    //         stopwatch.Start();

    // int punkte = 0; // TODO: aktivieren, wenn die Schleife implementiert wird.\r\n
    // TODO 3: Schleife über alle Fragen
    //         for (int i = 0; i < fragen.Length; i++)
    //         {
    //             Console.Write($"Frage {i + 1}: {fragen[i]} ");
    //             string antwort = Console.ReadLine() ?? "";
    //
    //             // Prüfen ob Antwort korrekt ist (ToLower-Vergleich)
    //             // Bei Zahlen-Fragen: int.TryParse verwenden
    //         }

    // TODO 4: Ergebnis ausgeben
    //         Console.WriteLine($"Resultat: {punkte}/5");

    // TODO 5 (Bonus): Stopwatch stoppen und Zeit ausgeben
    //         stopwatch.Stop();
    //         Console.WriteLine($"Zeit: {stopwatch.Elapsed.TotalSeconds:F1} Sekunden");
  }
}

