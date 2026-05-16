namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag2_WochentageApp;

/// <summary>
///   Lösung: Auftrag 2 – WochentageApp
///   switch expression und ternärer Operator.
/// </summary>
public partial class WochentageAppFormLoesung : Form
{
  public WochentageAppFormLoesung()
  {
    InitializeComponent();

    // ComboBox befüllen
    CmbWochentag.Items.AddRange(new object[]
    {
      "Montag", "Dienstag", "Mittwoch", "Donnerstag",
      "Freitag", "Samstag", "Sonntag"
    });
    CmbWochentag.SelectedIndex = 0;
  }

  private void CmdAnzeigen_Click(object sender, EventArgs e)
  {
    // Gewählten Tag auswerten (Index 0 = Montag)
    int index = CmbWochentag.SelectedIndex;

    // switch expression → Tagesnummer 1–7
    int tagNummer = index switch
    {
      0 => 1,
      1 => 2,
      2 => 3,
      3 => 4,
      4 => 5,
      5 => 6,
      6 => 7,
      _ => 0
    };

    // Ternärer Operator: Werktag oder Wochenende
    string typ = (tagNummer <= 5) ? "Werktag" : "Wochenende";

    string tagName = CmbWochentag.SelectedItem?.ToString() ?? "";
    LblErgebnis.Text = $"{tagName} ist Tag {tagNummer} der Woche ({typ}).";
  }
}
