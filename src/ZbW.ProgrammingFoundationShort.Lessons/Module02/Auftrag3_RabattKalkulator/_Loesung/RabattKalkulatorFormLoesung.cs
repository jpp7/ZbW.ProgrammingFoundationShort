namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag3_RabattKalkulator;

/// <summary>
///   Lösung: Auftrag 3 – Rabatt-Kalkulator
///   Rabattberechnung mit RadioButtons, CheckBox und if/else.
/// </summary>
public partial class RabattKalkulatorFormLoesung : Form
{
  public RabattKalkulatorFormLoesung()
  {
    InitializeComponent();
  }

  private void CmdBerechnen_Click(object sender, EventArgs e)
  {
    // Betrag validieren
    if (!double.TryParse(TxtBetrag.Text, out double betrag) || betrag <= 0)
    {
      MessageBox.Show("Bitte einen gültigen positiven Betrag eingeben.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    // Rabatt aus RadioButton
    int rabatt = 0;
    if (RdoPremium.Checked)
      rabatt = 10;
    else if (RdoVip.Checked)
      rabatt = 20;

    // Lehrlings-Bonus
    if (ChkLehrling.Checked)
      rabatt += 5;

    // Endpreis berechnen
    double endpreis = betrag * (1 - rabatt / 100.0);

    // Ergebnis anzeigen
    LblErgebnis.Text = $"Betrag: {betrag:F2} CHF\r\n" +
                       $"Rabatt: {rabatt}%\r\n" +
                       $"Endpreis: {endpreis:F2} CHF";
  }
}
