namespace ZbW.ProgrammingFoundationShort.Lessons.Module05.Auftrag2_WoerterbuchApp;

/// <summary>
///   Lösung: Auftrag 2 – Wörterbuch-App mit Dictionary
/// </summary>
public partial class WoerterbuchAppFormLoesung : Form
{
  private readonly Dictionary<string, string> _woerterbuch = new();

  public WoerterbuchAppFormLoesung()
  {
    InitializeComponent();

    // 5 Wörter vorausfüllen
    _woerterbuch["Hund"] = "Dog";
    _woerterbuch["Katze"] = "Cat";
    _woerterbuch["Haus"] = "House";
    _woerterbuch["Auto"] = "Car";
    _woerterbuch["Buch"] = "Book";

    AktualisiereListBox();
  }

  private void CmdNachschlagen_Click(object sender, EventArgs e)
  {
    string suche = TxtSuche.Text.Trim();
    if (string.IsNullOrEmpty(suche)) return;

    if (_woerterbuch.TryGetValue(suche, out string? uebersetzung))
      LblErgebnis.Text = $"{suche} → {uebersetzung}";
    else
      LblErgebnis.Text = $"Kein Eintrag für \"{suche}\" gefunden.";
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    string key = TxtKeyNeu.Text.Trim();
    string value = TxtValueNeu.Text.Trim();

    if (string.IsNullOrEmpty(key) || string.IsNullOrEmpty(value))
    {
      MessageBox.Show("Bitte beide Felder ausfüllen.",
        "Leere Felder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    if (_woerterbuch.ContainsKey(key))
    {
      var result = MessageBox.Show($"\"{key}\" existiert bereits. Überschreiben?",
        "Duplikat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result != DialogResult.Yes) return;
    }

    _woerterbuch[key] = value;
    AktualisiereListBox();
    TxtKeyNeu.Clear();
    TxtValueNeu.Clear();
  }

  private void AktualisiereListBox()
  {
    LstEintraege.Items.Clear();
    foreach (var kvp in _woerterbuch)
      LstEintraege.Items.Add($"{kvp.Key} → {kvp.Value}");
  }
}
