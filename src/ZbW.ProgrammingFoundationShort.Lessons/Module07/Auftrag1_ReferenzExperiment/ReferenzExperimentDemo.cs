namespace ZbW.ProgrammingFoundationShort.Lessons.Module07.Auftrag1_ReferenzExperiment;

// ============================================================
// AUFTRAG 1 – ReferenzExperiment (⭐⭐ Mittel | ~15 Min.)
//
// Zeige den Unterschied zwischen Wert- und Referenztypen.
//
// Anforderungen:
//   - int (Werttyp) kopieren und Kopie ändern
//   - Point (Referenztyp) zuweisen und zeigen wie beide zeigen
// ============================================================

public static class ReferenzExperimentDemo
{
  public static void Start()
  {
    // TODO 1: Werttyp-Experiment
    //         int a = 10; int b = a; b = 20;
    //         → a ist immer noch 10

    // TODO 2: Referenztyp-Experiment
    //         Point p1 = new Point(1, 2); Point p2 = p1;
    //         p2.X = 99;
    //         → p1.X ist jetzt auch 99 (beide zeigen auf gleiches Objekt)

    // TODO 3: Ausgaben kommentieren (warum ist a unverändert aber p1.X sich änderte?)
  }
}
