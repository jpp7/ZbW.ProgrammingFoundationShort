namespace ZbW.ProgrammingFoundationShort.Challenges.Module07.Aufgabe2_EqualsImplementieren;

/// <summary>
///   Aufgabe 2 – Equals implementieren (⭐⭐ Mittel)
///   Vergleich zweier Produkte via == und .Equals().
/// </summary>
public partial class EqualsForm : Form
{
  public EqualsForm()
  {
    InitializeComponent();
  }

  private void CmdVergleichen_Click(object sender, EventArgs e)
  {
    var p1 = new ProductVergleich
    {
      ArticleNumber = TxtArtNr1.Text.Trim(),
      Name = TxtName1.Text.Trim(),
      Price = decimal.TryParse(TxtPreis1.Text, out decimal pr1) ? pr1 : 0
    };

    var p2 = new ProductVergleich
    {
      ArticleNumber = TxtArtNr2.Text.Trim(),
      Name = TxtName2.Text.Trim(),
      Price = decimal.TryParse(TxtPreis2.Text, out decimal pr2) ? pr2 : 0
    };

    // == vergleicht Referenzen (immer false bei verschiedenen Objekten)
    bool refgleich = ReferenceEquals(p1, p2);
    // .Equals() vergleicht Artikelnummer
    bool wertgleich = p1.Equals(p2);

    LblErgebnis.Text = $"p1: {p1}\r\np2: {p2}\r\n\r\n" +
                       $"Referenz gleich (==): {refgleich}\r\n" +
                       $"Wert gleich (.Equals): {wertgleich}\r\n" +
                       $"→ Equals vergleicht nach Artikelnummer";
  }
}
