namespace ZbW.ProgrammingFoundationShort.Challenges.Module05.Aufgabe2_Woerterbuch;

/// <summary>
///   Aufgabe 2 – Wörterbuch (⭐⭐ Mittel)
///   Dictionary Deutsch→Englisch mit Suche und Eintrag-Verwaltung.
/// </summary>
public partial class WoerterbuchForm : Form
{
  private readonly Dictionary<string, string> _woerterbuch = new();

  public WoerterbuchForm()
  {
    InitializeComponent();

    _woerterbuch["Hund"] = "Dog";
    _woerterbuch["Katze"] = "Cat";
    _woerterbuch["Haus"] = "House";
    _woerterbuch["Auto"] = "Car";
    _woerterbuch["Buch"] = "Book";
  }

  private void CmdUebersetzen_Click(object sender, EventArgs e)
  {
    string suche = TxtSuche.Text.Trim();
    if (string.IsNullOrEmpty(suche)) return;

    if (_woerterbuch.TryGetValue(suche, out string? uebersetzung))
      LblErgebnis.Text = $"{suche} = {uebersetzung}";
    else
      LblErgebnis.Text = $"\"{suche}\" nicht gefunden.";
  }

  private void CmdEintragHinzufuegen_Click(object sender, EventArgs e)
  {
    string dt = TxtDeutsch.Text.Trim();
    string en = TxtEnglisch.Text.Trim();

    if (string.IsNullOrEmpty(dt) || string.IsNullOrEmpty(en))
    {
      MessageBox.Show("Bitte beide Felder ausfüllen.",
        "Leere Felder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    _woerterbuch[dt] = en;
    LblErgebnis.Text = $"Eintrag hinzugefügt: {dt} → {en}";
    TxtDeutsch.Clear();
    TxtEnglisch.Clear();
  }

  private void CmdAlleAnzeigen_Click(object sender, EventArgs e)
  {
    TxtAusgabe.Clear();
    foreach (var kvp in _woerterbuch.OrderBy(k => k.Key))
      TxtAusgabe.AppendText($"{kvp.Key,-20} → {kvp.Value}\r\n");
  }
}
