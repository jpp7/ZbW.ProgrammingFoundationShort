namespace ZbW.ProgrammingFoundationShort.Lessons.Module07.Auftrag1_ReferenzExperiment;

/// <summary>
///   Lösung: Wert- vs. Referenztyp Experiment.
/// </summary>
public static class ReferenzExperimentDemoLoesung
{
  public static void Start()
  {
    Console.WriteLine("=== Wert- vs. Referenztyp ===\n");

    // --- Werttyp (int) ---
    Console.WriteLine("-- Werttyp int --");
    int a = 10;
    int b = a; // KOPIE des Wertes
    b = 20;
    Console.WriteLine($"a = {a}"); // 10 → unverändert!
    Console.WriteLine($"b = {b}"); // 20
    Console.WriteLine("→ b ist eine Kopie, a bleibt unverändert\n");

    // --- Referenztyp (Point) ---
    Console.WriteLine("-- Referenztyp Point --");
    var p1 = new Point(1, 2);
    var p2 = p1; // p2 zeigt auf DASSELBE Objekt wie p1
    p2.X = 99;
    Console.WriteLine($"p1 = {p1}"); // Point(99, 2) → auch geändert!
    Console.WriteLine($"p2 = {p2}"); // Point(99, 2)
    Console.WriteLine("→ p1 und p2 zeigen auf dasselbe Objekt im Heap\n");

    // --- Echte Kopie ---
    Console.WriteLine("-- Echte Kopie mit new --");
    var p3 = new Point(p1.X, p1.Y); // neues Objekt
    p3.X = 50;
    Console.WriteLine($"p1 = {p1}"); // unverändert
    Console.WriteLine($"p3 = {p3}"); // 50, 2
    Console.WriteLine("→ p3 ist ein neues Objekt, p1 bleibt unverändert");
  }
}
