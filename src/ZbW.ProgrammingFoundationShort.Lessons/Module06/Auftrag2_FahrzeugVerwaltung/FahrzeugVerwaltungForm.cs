namespace ZbW.ProgrammingFoundationShort.Lessons.Module06.Auftrag2_FahrzeugVerwaltung;

// ============================================================
// AUFTRAG 2 – FahrzeugVerwaltung (⭐⭐ Mittel | ~20 Min.)
//
// Verwaltet Fahrzeuge mit einer Klasse Vehicle.
//
// Anforderungen:
//   - Vehicle.cs: Klasse mit Make/Model/Year/Price/Age/Description
//   - TxtMake/Model/Year/Price + CmdHinzufuegen
//   - LstFahrzeuge: alle Fahrzeuge anzeigen
//   - CmdGuenstigstes: günstigstes Fahrzeug in LblErgebnis anzeigen
// ============================================================

public partial class FahrzeugVerwaltungForm : Form
{
  // TODO 1: private List<Vehicle> _fahrzeuge = new();

  public FahrzeugVerwaltungForm()
  {
    InitializeComponent();
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    // TODO 2: Vehicle-Objekt aus Eingabefeldern erstellen
    // TODO 3: Zur Liste hinzufügen, ListBox aktualisieren
  }

  private void CmdGuenstigstes_Click(object sender, EventArgs e)
  {
    // TODO 4: Prüfen ob Liste leer
    // TODO 5: Günstigstes Fahrzeug per Schleife finden
    // TODO 6: LblErgebnis.Text = günstigstes.Description()
  }
}
