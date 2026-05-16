namespace ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag2_MathUtils;

// ============================================================
// AUFTRAG 2 – MathUtils (⭐⭐ Mittel | ~20 Min.)
//
// Nutzt die statische MathUtils-Klasse.
//
// Anforderungen:
//   - MathUtils.cs: static class mit IsPrime/Factorial/GenerateLinspace
//   - TxtEingabe + RadioButtons für Funktion
//   - CmdBerechnen → Methode aufrufen, LblErgebnis setzen
// ============================================================

public partial class MathUtilsForm : Form
{
  public MathUtilsForm()
  {
    InitializeComponent();
    LblGolden.Text = $"Goldener Schnitt: {MathUtils.GoldenRatio:F6}";
  }

  private void CmdBerechnen_Click(object sender, EventArgs e)
  {
    // TODO 1: Eingabe lesen (int)

    // TODO 2: Je nach RadioButton:
    //         RdoPrim: MathUtils.IsPrime(n)
    //         RdoFakultaet: MathUtils.Factorial(n)
    //         RdoLinspace: MathUtils.GenerateLinspace(0, n, 5)

    // TODO 3: Ergebnis in LblErgebnis anzeigen
  }
}
