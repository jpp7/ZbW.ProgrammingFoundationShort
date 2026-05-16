namespace ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag1_Taschenrechner;

// ============================================================
// AUFTRAG 1 – Taschenrechner (⭐ Einfach | ~10 Min.)
//
// Erstelle eine Konsolen-App, die zwei Zahlen und eine Operation
// einliest und das Resultat ausgibt.
//
// Anforderungen:
//   - Zahlen mit double.TryParse aus Console.ReadLine() einlesen
//   - Operationen: +, −, ×, ÷ (Eingabe: "+", "-", "*", "/")
//   - Bei Division durch 0: Fehlermeldung ausgeben
//   - Resultat mit 2 Nachkommastellen: $"{result:F2}"
//
// Tipp: Starte Program.cs mit Application.Run(null) und rufe
//        Taschenrechner.Start() auf — oder lege eine eigene
//        Konsolen-App an und rufe Start() direkt auf.
// ============================================================

public static class Taschenrechner
{
  /// <summary>
  ///   Berechnet das Ergebnis zweier Zahlen für eine gegebene Operation.
  /// </summary>
  /// <param name="zahl1">Linker Operand.</param>
  /// <param name="zahl2">Rechter Operand.</param>
  /// <param name="operation">Operator als Zeichen: +, -, *, /</param>
  /// <returns>Das berechnete Ergebnis.</returns>
  /// <exception cref="DivideByZeroException">Wird geworfen bei Division durch 0.</exception>
  /// <exception cref="ArgumentException">Wird geworfen bei ungültigem Operator.</exception>
  public static double Berechnen(double zahl1, double zahl2, string operation)
  {
    // TODO: Implementiere die Berechnung
    //       Verwende switch (operation) mit den Fällen +, -, *, /
    //       Wirf DivideByZeroException wenn zahl2 == 0 und operation == "/"
    //       Wirf ArgumentException bei unbekanntem Operator

    throw new NotImplementedException("TODO: Berechnen implementieren");
  }

  /// <summary>
  ///   Startet den interaktiven Taschenrechner auf der Konsole.
  /// </summary>
  public static void Start()
  {
    // TODO 1: Erste Zahl einlesen
    //         Console.Write("Erste Zahl: ");
    //         string input1 = Console.ReadLine();
    //         double zahl1 = ...

    // TODO 2: Zweite Zahl einlesen (gleiche Technik wie TODO 1)

    // TODO 3: Operation einlesen (+, -, *, /)

    // TODO 4: Berechnung durchführen (switch oder if/else)
    //         Achtung: Division durch 0 abfangen!

    // TODO 5: Ergebnis ausgeben: $"{result:F2}"
  }
}
