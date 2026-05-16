namespace ZbW.ProgrammingFoundationShort.Challenges.Module07.Aufgabe1_ReferenzExperiment;

/// <summary>
///   Aufgabe 1 – Referenz-Experiment (⭐⭐ Mittel)
///   Zeigt den Unterschied zwischen Wert- und Referenztypen in WinForms.
/// </summary>
public partial class ReferenzExperimentForm : Form
{
  public ReferenzExperimentForm()
  {
    InitializeComponent();
  }

  private void CmdWerttyp_Click(object sender, EventArgs e)
  {
    // Werttyp: int – Kopie des Wertes
    int a = 10;
    int b = a; // Kopie!
    b = 20;
    LblWerttyp.Text = $"Werttyp:\r\na = {a} (unverändert)\r\nb = {b}\r\n→ b ist KOPIE von a";
  }

  private void CmdReferenztyp_Click(object sender, EventArgs e)
  {
    // Referenztyp: Counter – beide zeigen auf dasselbe Objekt
    var c1 = new Counter(10);
    var c2 = c1; // gleiche Referenz!
    c2.Value = 99;
    LblReferenztyp.Text = $"Referenztyp:\r\nc1 = {c1} (verändert!)\r\nc2 = {c2}\r\n→ c1 und c2 sind GLEICH";
  }

  private void CmdEchteKopie_Click(object sender, EventArgs e)
  {
    // Echte Kopie mit new
    var c1 = new Counter(10);
    var c2 = new Counter(c1.Value); // neues Objekt
    c2.Value = 99;
    LblEchteKopie.Text = $"Echte Kopie:\r\nc1 = {c1} (unverändert)\r\nc2 = {c2}\r\n→ neue Instanz mit 'new'";
  }
}
