namespace ZbW.ProgrammingFoundationShort.Lessons.Module07.Auftrag3_Kontaktmanager;

// ============================================================
// AUFTRAG 3 – Kontaktmanager (⭐⭐⭐ Schwer | ~20 Min.)
//
// Kontaktmanager mit Duplikat-Prüfung via Equals.
//
// Anforderungen:
//   - PersonKontakt.cs: Equals nach Vor+Nachname, Email nullable
//   - List<PersonKontakt>.Contains() für Duplikat-Prüfung
//   - TxtFirstName/TxtLastName/TxtEmail, CmdHinzufuegen/CmdEntfernen
// ============================================================

public partial class KontaktmanagerForm : Form
{
  // TODO 1: private List<PersonKontakt> _kontakte = new();

  public KontaktmanagerForm()
  {
    InitializeComponent();
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    // TODO 2: PersonKontakt aus Eingabefeldern erstellen
    // TODO 3: _kontakte.Contains(kontakt) → Duplikat prüfen
    // TODO 4: _kontakte.Add(kontakt); ListBox aktualisieren
  }

  private void CmdEntfernen_Click(object sender, EventArgs e)
  {
    // TODO 5: Ausgewählten Kontakt entfernen
  }
}
