namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe2_Waehrungsrechner;

/// <summary>
///   Musterlösung: Aufgabe 2 – Währungsrechner (⭐⭐ Mittel)
///   CHF ↔ EUR Konvertierung.
///   Wechselkurs: 1 CHF = 1/ChfEurRate EUR (d. h. 1 EUR = ChfEurRate CHF)
/// </summary>
public partial class WaehrungsrechnerForm : Form
{
  // Wechselkurs: 1 EUR = 1.05 CHF  →  1 CHF = 1/1.05 EUR
  private const double ChfEurRate = 1.05;

  public WaehrungsrechnerForm()
  {
    InitializeComponent();
  }

  private void CmdChfToEur_Click(object sender, EventArgs e)
  {
    if (!double.TryParse(TxtBetrag.Text, out double betrag))
    {
      MessageBox.Show("Bitte einen gültigen Betrag eingeben.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    if (betrag < 0)
    {
      MessageBox.Show("Negative Beträge sind nicht erlaubt.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    double eur = betrag / ChfEurRate;
    LblErgebnis.Text = $"{betrag:F2} CHF = {eur:F2} EUR";
  }

  private void CmdEurToChf_Click(object sender, EventArgs e)
  {
    if (!double.TryParse(TxtBetrag.Text, out double betrag))
    {
      MessageBox.Show("Bitte einen gültigen Betrag eingeben.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    if (betrag < 0)
    {
      MessageBox.Show("Negative Beträge sind nicht erlaubt.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    double chf = betrag * ChfEurRate;
    LblErgebnis.Text = $"{betrag:F2} EUR = {chf:F2} CHF";
  }
}
