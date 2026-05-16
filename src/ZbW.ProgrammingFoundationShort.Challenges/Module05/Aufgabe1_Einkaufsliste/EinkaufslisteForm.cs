namespace ZbW.ProgrammingFoundationShort.Challenges.Module05.Aufgabe1_Einkaufsliste;

/// <summary>
///   Aufgabe 1 – Einkaufsliste (⭐ Einfach)
///   List&lt;string&gt; mit Duplikat-Prüfung.
/// </summary>
public partial class EinkaufslisteForm : Form
{
  private readonly List<string> _artikel = new();

  public EinkaufslisteForm()
  {
    InitializeComponent();
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    string artikel = TxtArtikel.Text.Trim();
    if (string.IsNullOrEmpty(artikel))
    {
      MessageBox.Show("Bitte einen Artikel eingeben.",
        "Leere Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    // Duplikat-Prüfung mit Contains
    if (_artikel.Contains(artikel))
    {
      MessageBox.Show($"\"{artikel}\" ist bereits in der Liste.",
        "Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Information);
      return;
    }

    _artikel.Add(artikel);
    AktualisiereListBox();
    TxtArtikel.Clear();
    TxtArtikel.Focus();
  }

  private void CmdEntfernen_Click(object sender, EventArgs e)
  {
    if (LstArtikel.SelectedIndex < 0)
    {
      MessageBox.Show("Bitte einen Artikel auswählen.",
        "Keine Auswahl", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    string ausgewaehlt = LstArtikel.SelectedItem?.ToString() ?? "";
    _artikel.Remove(ausgewaehlt);
    AktualisiereListBox();
  }

  private void CmdAlleLoeschen_Click(object sender, EventArgs e)
  {
    _artikel.Clear();
    AktualisiereListBox();
  }

  private void AktualisiereListBox()
  {
    LstArtikel.Items.Clear();
    foreach (string a in _artikel)
      LstArtikel.Items.Add(a);
    LblAnzahl.Text = $"Artikel: {_artikel.Count}";
  }
}
