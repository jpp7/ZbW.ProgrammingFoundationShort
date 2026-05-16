namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag1_Notenrechner;

/// <summary>
///   Lösung: Auftrag 1 – Notenrechner
///   if/else-Kette zur Notenberechnung anhand von Punkten.
/// </summary>
public partial class NotenrechnerFormLoesung : Form
{
  public NotenrechnerFormLoesung()
  {
    InitializeComponent();
  }

  private void CmdBerechnen_Click(object sender, EventArgs e)
  {
    // Eingabe lesen und validieren
    if (!int.TryParse(TxtPunkte.Text, out int punkte) || punkte < 0 || punkte > 100)
    {
      MessageBox.Show("Bitte eine gültige Punktzahl zwischen 0 und 100 eingeben.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    // Note per if/else-Kette bestimmen
    int note;
    string bewertung;

    if (punkte >= 90)
    {
      note = 6;
      bewertung = "Sehr gut";
    }
    else if (punkte >= 75)
    {
      note = 5;
      bewertung = "Gut";
    }
    else if (punkte >= 60)
    {
      note = 4;
      bewertung = "Genügend";
    }
    else
    {
      note = 3;
      bewertung = "Ungenügend";
    }

    // Ergebnis anzeigen
    LblNote.Text = $"Note: {note}";
    LblBewertung.Text = $"Bewertung: {bewertung}";
  }
}
