namespace ZbW.ProgrammingFoundationShort.Challenges.Module03.Aufgabe1_Multiplikationstabelle;

/// <summary>
///   Aufgabe 1 – Multiplikationstabelle (⭐ Einfach)
///   Generiert eine Multiplikationstabelle mit for-Schleife.
/// </summary>
public partial class MultiplikationstabelleForm : Form
{
  public MultiplikationstabelleForm()
  {
    InitializeComponent();
  }

  private void CmdAnzeigen_Click(object sender, EventArgs e)
  {
    if (!int.TryParse(TxtZahl.Text, out int zahl) || zahl < 1 || zahl > 10)
    {
      MessageBox.Show("Bitte eine Zahl zwischen 1 und 10 eingeben.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    TxtAusgabe.Clear();

    if (ChkRueckwaerts.Checked)
    {
      // Rückwärts: 10 nach 1
      for (int i = 10; i >= 1; i--)
        TxtAusgabe.AppendText($"{zahl} × {i,2} = {zahl * i,3}\r\n");
    }
    else
    {
      // Vorwärts: 1 nach 10
      for (int i = 1; i <= 10; i++)
        TxtAusgabe.AppendText($"{zahl} × {i,2} = {zahl * i,3}\r\n");
    }
  }
}
