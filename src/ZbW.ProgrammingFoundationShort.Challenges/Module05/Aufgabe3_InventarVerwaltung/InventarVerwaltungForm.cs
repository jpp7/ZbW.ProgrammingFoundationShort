namespace ZbW.ProgrammingFoundationShort.Challenges.Module05.Aufgabe3_InventarVerwaltung;

/// <summary>
///   Aufgabe 3 – Inventar-Verwaltung (⭐⭐ Mittel)
///   Dictionary&lt;string,int&gt; für Artikel und Mengen.
/// </summary>
public partial class InventarVerwaltungForm : Form
{
  private readonly Dictionary<string, int> _inventar = new();

  public InventarVerwaltungForm()
  {
    InitializeComponent();

    _inventar["Äpfel"] = 50;
    _inventar["Bananen"] = 30;
    _inventar["Orangen"] = 20;
    _inventar["Trauben"] = 15;
    _inventar["Mangos"] = 10;

    AktualisiereListBox();
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    string artikel = TxtArtikel.Text.Trim();
    if (!int.TryParse(TxtMenge.Text, out int menge) || menge <= 0)
    {
      MessageBox.Show("Bitte gültigen Artikel und positive Menge eingeben.",
        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    if (_inventar.ContainsKey(artikel))
      _inventar[artikel] += menge;
    else
      _inventar[artikel] = menge;

    AktualisiereListBox();
    TxtArtikel.Clear();
    TxtMenge.Clear();
  }

  private void CmdEntfernen_Click(object sender, EventArgs e)
  {
    string artikel = TxtArtikel.Text.Trim();
    if (string.IsNullOrEmpty(artikel) || !_inventar.ContainsKey(artikel))
    {
      MessageBox.Show($"Artikel \"{artikel}\" nicht gefunden.",
        "Nicht gefunden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    _inventar.Remove(artikel);
    AktualisiereListBox();
    TxtArtikel.Clear();
  }

  private void CmdSuchen_Click(object sender, EventArgs e)
  {
    string artikel = TxtArtikel.Text.Trim();
    if (_inventar.TryGetValue(artikel, out int menge))
      LblGesamt.Text = $"Lagerbestand \"{artikel}\": {menge} Stück";
    else
      LblGesamt.Text = $"\"{artikel}\" nicht im Lager.";
  }

  private void CmdAlleAnzeigen_Click(object sender, EventArgs e)
  {
    AktualisiereListBox();
  }

  private void AktualisiereListBox()
  {
    LstInventar.Items.Clear();
    int gesamt = 0;
    foreach (var kvp in _inventar)
    {
      LstInventar.Items.Add($"{kvp.Key,-20} {kvp.Value,6} Stück");
      gesamt += kvp.Value;
    }
    LblGesamt.Text = $"Gesamtbestand: {gesamt} Stück ({_inventar.Count} Artikel)";
  }
}
