namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag3_SichererDateiLeser;

/// <summary>
///   Lösung: Auftrag 3 – SichererDateiLeser
///   try-catch-finally mit File.ReadAllLines.
/// </summary>
public partial class SichererDateiLeserFormLoesung : Form
{
  public SichererDateiLeserFormLoesung()
  {
    InitializeComponent();
  }

  private void CmdLesen_Click(object sender, EventArgs e)
  {
    LstZeilen.Items.Clear();

    try
    {
      // Datei einlesen
      string[] zeilen = File.ReadAllLines(TxtPfad.Text);

      // Zeilen mit Nummer in ListBox laden
      for (int i = 0; i < zeilen.Length; i++)
      {
        LstZeilen.Items.Add($"{i + 1,4}: {zeilen[i]}");
      }

      LblStatus.Text = $"{zeilen.Length} Zeile(n) geladen.";
    }
    catch (FileNotFoundException)
    {
      MessageBox.Show($"Datei nicht gefunden:\r\n{TxtPfad.Text}",
        "Datei nicht gefunden", MessageBoxButtons.OK, MessageBoxIcon.Error);
      LblStatus.Text = "Fehler: Datei nicht gefunden.";
    }
    catch (Exception ex)
    {
      MessageBox.Show($"Fehler beim Lesen: {ex.Message}",
        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
      LblStatus.Text = "Fehler beim Lesen.";
    }
    finally
    {
      // finally wird immer ausgeführt
      LblStatus.Text += " | Lesevorgang abgeschlossen.";
    }
  }
}
