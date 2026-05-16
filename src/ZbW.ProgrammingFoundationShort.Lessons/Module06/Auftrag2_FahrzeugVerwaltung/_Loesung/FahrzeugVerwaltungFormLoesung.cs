namespace ZbW.ProgrammingFoundationShort.Lessons.Module06.Auftrag2_FahrzeugVerwaltung;

/// <summary>
///   Lösung: Auftrag 2 – Fahrzeug-Verwaltung mit Vehicle-Klasse.
/// </summary>
public partial class FahrzeugVerwaltungFormLoesung : Form
{
  private readonly List<Vehicle> _fahrzeuge = new();

  public FahrzeugVerwaltungFormLoesung()
  {
    InitializeComponent();
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    if (!int.TryParse(TxtYear.Text, out int year))
    {
      MessageBox.Show("Bitte ein gültiges Baujahr eingeben.",
        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    if (!decimal.TryParse(TxtPrice.Text, out decimal price) || price < 0)
    {
      MessageBox.Show("Bitte einen gültigen Preis eingeben.",
        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    var fahrzeug = new Vehicle
    {
      Make = TxtMake.Text.Trim(),
      Model = TxtModel.Text.Trim(),
      Year = year,
      Price = price
    };

    _fahrzeuge.Add(fahrzeug);
    AktualisiereListBox();

    TxtMake.Clear(); TxtModel.Clear();
    TxtYear.Clear(); TxtPrice.Clear();
  }

  private void CmdGuenstigstes_Click(object sender, EventArgs e)
  {
    if (_fahrzeuge.Count == 0)
    {
      LblErgebnis.Text = "Keine Fahrzeuge vorhanden.";
      return;
    }

    Vehicle guenstigstes = _fahrzeuge[0];
    for (int i = 1; i < _fahrzeuge.Count; i++)
      if (_fahrzeuge[i].Price < guenstigstes.Price)
        guenstigstes = _fahrzeuge[i];

    LblErgebnis.Text = $"Günstigstes: {guenstigstes.Description()}";
  }

  private void AktualisiereListBox()
  {
    LstFahrzeuge.Items.Clear();
    foreach (var f in _fahrzeuge)
      LstFahrzeuge.Items.Add(f.Description());
  }
}
