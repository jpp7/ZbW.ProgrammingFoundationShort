namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag2_WochentageApp;

// ============================================================
// AUFTRAG 2 – WochentageApp (⭐⭐ Mittel | ~15 Min.)
//
// Zeige Infos zum gewählten Wochentag.
//
// Anforderungen:
//   - CmbWochentag: ComboBox mit Mo, Di, Mi, Do, Fr, Sa, So
//   - switch expression für Tagesnummer (1=Mo ... 7=So)
//   - Ternären Operator: Werktag oder Wochenende
//   - LblErgebnis: Tagesnummer + Typ anzeigen
// ============================================================

public partial class WochentageAppForm : Form
{
  public WochentageAppForm()
  {
    InitializeComponent();
    // TODO 1: ComboBox-Items befüllen: "Montag","Dienstag","Mittwoch","Donnerstag","Freitag","Samstag","Sonntag"
    //         CmbWochentag.SelectedIndex = 0;
  }

  private void CmdAnzeigen_Click(object sender, EventArgs e)
  {
    // TODO 2: Gewählten Index (0-6) aus CmbWochentag lesen

    // TODO 3: switch expression → Tagesnummer (1–7) bestimmen

    // TODO 4: Ternären Operator → "Werktag" oder "Wochenende"
    //         string typ = (tagNummer <= 5) ? "Werktag" : "Wochenende";

    // TODO 5: LblErgebnis.Text setzen
  }
}
