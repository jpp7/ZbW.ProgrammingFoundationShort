namespace ZbW.ProgrammingFoundationShort.Lessons.Module07.Auftrag3_Kontaktmanager;

// ============================================================
// AUFTRAG 3 – Kontaktmanager (⭐⭐⭐ Schwer | ~20 Min.)
//
// Kontaktmanager mit getrennter UI, Logik und Datenklasse.
//
// Anforderungen:
//   - PersonKontakt.cs: Datenklasse mit Equals nach Vor+Nachname, Email nullable
//   - ContactManager.cs: Logikklasse mit Add(), RemoveAt(), GetAll()
//   - Form: Eingaben lesen, ContactManager aufrufen, ListBox aktualisieren
// ============================================================

public partial class KontaktmanagerForm : Form
{
  // TODO 1: private ContactManager _contactManager = new();

  public KontaktmanagerForm()
  {
    InitializeComponent();
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    // TODO 2: PersonKontakt aus Eingabefeldern erstellen
    // TODO 3: _contactManager.Add(kontakt) aufrufen und Duplikat behandeln
    // TODO 4: ListBox über _contactManager.GetAll() aktualisieren
  }

  private void CmdEntfernen_Click(object sender, EventArgs e)
  {
    // TODO 5: Ausgewählten Kontakt über _contactManager.RemoveAt(...) entfernen
  }
}

