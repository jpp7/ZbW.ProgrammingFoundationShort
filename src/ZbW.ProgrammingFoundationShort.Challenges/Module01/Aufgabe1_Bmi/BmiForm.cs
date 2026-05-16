namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe1_Bmi;

/// <summary>
///   Musterlösung: Aufgabe 1 – Body-Mass-Index (⭐ Einfach)
///   WinForms-App zur Berechnung des BMI.
///   Formel: BMI = Gewicht / (Grösse * Grösse)
/// </summary>
public partial class BmiForm : Form
{
  public BmiForm()
  {
    InitializeComponent();
  }

  private void CmdBerechnen_Click(object sender, EventArgs e)
  {
    // Gewicht einlesen und validieren
    if (!double.TryParse(TxtGewicht.Text, out double gewicht) || gewicht <= 0)
    {
      MessageBox.Show("Bitte ein gültiges Gewicht eingeben (z. B. 75).",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    // Grösse einlesen und validieren
    if (!double.TryParse(TxtGroesse.Text, out double groesse) || groesse <= 0)
    {
      MessageBox.Show("Bitte eine gültige Grösse eingeben (z. B. 1.78).",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    // BMI berechnen
    double bmi = gewicht / (groesse * groesse);

    // Kategorie bestimmen
    string kategorie = bmi switch
    {
      < 18.5 => "Untergewicht",
      < 25.0 => "Normalgewicht",
      < 30.0 => "Übergewicht",
      _ => "Adipositas"
    };

    LblErgebnis.Text = $"Ihr BMI beträgt: {bmi:F2} ({kategorie})";
  }
}
