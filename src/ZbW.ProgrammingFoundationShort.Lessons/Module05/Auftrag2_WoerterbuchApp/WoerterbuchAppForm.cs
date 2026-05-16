namespace ZbW.ProgrammingFoundationShort.Lessons.Module05.Auftrag2_WoerterbuchApp;

// ============================================================
// AUFTRAG 2 – WoerterbuchApp (⭐⭐ Mittel | ~15 Min.)
//
// Übersetzungs-App mit Dictionary<string,string>.
//
// Anforderungen:
//   - 5 Wörter vorausfüllen (Deutsch → Englisch)
//   - TxtSuche + CmdNachschlagen: TryGetValue für Übersetzung
//   - TxtKeyNeu + TxtValueNeu + CmdHinzufuegen: ContainsKey-Prüfung
//   - LstEintraege: alle Einträge anzeigen
// ============================================================

public partial class WoerterbuchAppForm : Form
{
  // TODO 1: private Dictionary<string, string> _woerterbuch = new();

  public WoerterbuchAppForm()
  {
    InitializeComponent();
    // TODO 2: 5 Wörter vorab einfügen (z.B. Hund → Dog, Katze → Cat...)
    // TODO 3: AktualisiereListBox() aufrufen
  }

  private void CmdNachschlagen_Click(object sender, EventArgs e)
  {
    // TODO 4: TryGetValue für TxtSuche.Text
    //         Gefunden: LblErgebnis anzeigen
    //         Nicht gefunden: "Kein Eintrag für..."
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    // TODO 5: Leere Felder prüfen
    // TODO 6: ContainsKey-Prüfung → Überschreiben bestätigen
    // TODO 7: _woerterbuch[key] = value;
    // TODO 8: AktualisiereListBox()
  }

  private void AktualisiereListBox()
  {
    // TODO 9: LstEintraege befüllen aus _woerterbuch
  }
}
