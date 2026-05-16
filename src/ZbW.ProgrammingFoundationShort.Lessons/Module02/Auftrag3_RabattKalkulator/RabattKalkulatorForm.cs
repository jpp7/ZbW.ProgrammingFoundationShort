namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag3_RabattKalkulator;

// ============================================================
// AUFTRAG 3 – RabattKalkulator (⭐⭐ Mittel | ~15 Min.)
//
// Berechne einen Rabatt anhand von Kundentyp und Lehrling-Status.
//
// Anforderungen:
//   - TxtBetrag: Kaufbetrag einlesen
//   - RadioButtons: Normal (0%), Premium (10%), VIP (20%)
//   - CheckBox: Lehrling (+5% extra Rabatt)
//   - Gesamtrabatt berechnen und Endpreis anzeigen
// ============================================================

public partial class RabattKalkulatorForm : Form
{
  public RabattKalkulatorForm()
  {
    InitializeComponent();
  }

  private void CmdBerechnen_Click(object sender, EventArgs e)
  {
    // TODO 1: Betrag aus TxtBetrag lesen (double.TryParse)
    //         Bei ungültiger Eingabe: MessageBox anzeigen und return

    // TODO 2: Rabatt aus RadioButton ermitteln
    //         RdoNormal = 0%, RdoPremium = 10%, RdoVip = 20%

    // TODO 3: Wenn ChkLehrling.Checked → Rabatt += 5

    // TODO 4: Endpreis berechnen: endpreis = betrag * (1 - rabatt / 100.0)

    // TODO 5: LblErgebnis.Text setzen mit Betrag, Rabatt % und Endpreis
  }
}
