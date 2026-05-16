namespace ZbW.ProgrammingFoundationShort.Lessons.Module04.Auftrag2_NotenVerwaltung;

// ============================================================
// AUFTRAG 2 – NotenVerwaltung (⭐⭐ Mittel | ~20 Min.)
//
// Verwaltet bis zu 10 Noten in einem double[]-Array.
//
// Anforderungen:
//   - TxtNote: Note (1.0–6.0) eingeben
//   - CmdHinzufuegen: Note ins Array, Button deaktivieren wenn voll
//   - LblNoten: alle Noten anzeigen
//   - LblStats: Average/Best/Worst per privaten Methoden
// ============================================================

public partial class NotenVerwaltungForm : Form
{
  // TODO 1: Felder deklarieren
  //         private double[] _noten = new double[10];
  //         private int _anzahl = 0;

  public NotenVerwaltungForm()
  {
    InitializeComponent();
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    // TODO 2: Note validieren (double.TryParse, 1.0–6.0)

    // TODO 3: Note ins Array: _noten[_anzahl++] = note;

    // TODO 4: Label aktualisieren (alle Noten anzeigen)

    // TODO 5: Wenn voll: CmdHinzufuegen.Enabled = false;

    // TODO 6: Statistik-Labels aktualisieren
  }

  private double GetAverage()
  {
    // TODO: Durchschnitt berechnen
    throw new NotImplementedException();
  }

  private double GetBest()
  {
    // TODO: Höchste Note finden
    throw new NotImplementedException();
  }

  private double GetWorst()
  {
    // TODO: Niedrigste Note finden
    throw new NotImplementedException();
  }
}
