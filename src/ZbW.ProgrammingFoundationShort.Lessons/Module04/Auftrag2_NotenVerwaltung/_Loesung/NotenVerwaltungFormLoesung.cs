namespace ZbW.ProgrammingFoundationShort.Lessons.Module04.Auftrag2_NotenVerwaltung;

/// <summary>
///   Lösung: Auftrag 2 – Noten-Verwaltung
///   Arrays und Methoden für Notenverwaltung.
/// </summary>
public partial class NotenVerwaltungFormLoesung : Form
{
  private readonly double[] _noten = new double[10];
  private int _anzahl = 0;

  public NotenVerwaltungFormLoesung()
  {
    InitializeComponent();
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    if (!double.TryParse(TxtNote.Text, out double note) || note < 1.0 || note > 6.0)
    {
      MessageBox.Show("Bitte eine gültige Note zwischen 1.0 und 6.0 eingeben.",
        "Ungültige Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    // Note eintragen
    _noten[_anzahl++] = note;
    TxtNote.Clear();

    // Anzeige aktualisieren
    AktualisiereLblNoten();

    // Button deaktivieren wenn Array voll
    if (_anzahl >= _noten.Length)
      CmdHinzufuegen.Enabled = false;
  }

  private void AktualisiereLblNoten()
  {
    var notenText = new System.Text.StringBuilder();
    for (int i = 0; i < _anzahl; i++)
      notenText.Append($"{_noten[i]:F1}  ");
    LblNoten.Text = notenText.ToString();

    LblStats.Text = $"Durchschnitt: {GetAverage():F2}  |  " +
                    $"Beste: {GetBest():F1}  |  Schlechteste: {GetWorst():F1}";
  }

  private double GetAverage()
  {
    double summe = 0;
    for (int i = 0; i < _anzahl; i++)
      summe += _noten[i];
    return summe / _anzahl;
  }

  private double GetBest()
  {
    double best = _noten[0];
    for (int i = 1; i < _anzahl; i++)
      if (_noten[i] > best) best = _noten[i];
    return best;
  }

  private double GetWorst()
  {
    double worst = _noten[0];
    for (int i = 1; i < _anzahl; i++)
      if (_noten[i] < worst) worst = _noten[i];
    return worst;
  }
}
