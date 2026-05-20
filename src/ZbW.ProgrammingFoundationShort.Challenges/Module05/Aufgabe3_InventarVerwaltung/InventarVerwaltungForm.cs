namespace ZbW.ProgrammingFoundationShort.Challenges.Module05.Aufgabe3_InventarVerwaltung;

/// <summary>
///   Aufgabe 3 – Inventar-Verwaltung (⭐⭐⭐ Anspruchsvoll)
///   Dictionary&lt;string,int&gt; für Artikel und Mengen.
/// </summary>
public partial class InventarVerwaltungForm : Form
{
  private readonly Dictionary<string, int> _inventar = new();

  public InventarVerwaltungForm()
  {
    InitializeComponent();

    LstInventar.DrawMode = DrawMode.OwnerDrawFixed;
    LstInventar.DrawItem += LstInventar_DrawItem;

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
    if (string.IsNullOrEmpty(artikel) || !int.TryParse(TxtMenge.Text, out int menge) || menge <= 0)
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

    if (!int.TryParse(TxtMenge.Text, out int menge) || menge <= 0)
    {
      MessageBox.Show("Bitte eine positive Menge zum Entfernen eingeben.",
        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    _inventar[artikel] = Math.Max(0, _inventar[artikel] - menge);
    AktualisiereListBox();
    TxtArtikel.Clear();
    TxtMenge.Clear();
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
      LstInventar.Items.Add(new InventoryListItem(kvp.Key, kvp.Value));
      gesamt += kvp.Value;
    }
    LblGesamt.Text = $"Gesamtbestand: {gesamt} Stück ({_inventar.Count} Artikel)";
  }

  private void LstInventar_DrawItem(object? sender, DrawItemEventArgs e)
  {
    if (e.Index < 0) return;

    e.DrawBackground();
    var item = (InventoryListItem)LstInventar.Items[e.Index];
    Color color = item.Quantity == 0 ? Color.Red : e.ForeColor;

    using var brush = new SolidBrush(color);
    e.Graphics.DrawString(item.ToString(), e.Font ?? Font, brush, e.Bounds);
    e.DrawFocusRectangle();
  }

  private sealed class InventoryListItem
  {
    public InventoryListItem(string article, int quantity)
    {
      Article = article;
      Quantity = quantity;
    }

    public string Article { get; }
    public int Quantity { get; }

    public override string ToString()
    {
      return $"{Article,-20} {Quantity,6} Stück";
    }
  }
}