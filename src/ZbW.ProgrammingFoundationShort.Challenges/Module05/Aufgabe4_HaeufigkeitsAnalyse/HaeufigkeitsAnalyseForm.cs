namespace ZbW.ProgrammingFoundationShort.Challenges.Module05.Aufgabe4_HaeufigkeitsAnalyse;

/// <summary>
///   Aufgabe 4 – Häufigkeits-Analyse (⭐⭐⭐ Schwer)
///   Buchstabenhäufigkeit mit Dictionary und ASCII-Balken.
/// </summary>
public partial class HaeufigkeitsAnalyseForm : Form
{
  public HaeufigkeitsAnalyseForm()
  {
    InitializeComponent();
  }

  private void CmdAnalysieren_Click(object sender, EventArgs e)
  {
    string text = TxtEingabe.Text;
    if (string.IsNullOrWhiteSpace(text))
    {
      MessageBox.Show("Bitte einen Text eingeben.",
        "Kein Text", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    var haeufigkeit = CountLetters(text);
    var sortiert = SortByFrequency(haeufigkeit);

    TxtErgebnis.Clear();
    TxtErgebnis.AppendText($"Analysierter Text: {text.Length} Zeichen\r\n");
    TxtErgebnis.AppendText("Top-5 Buchstaben:\r\n");
    TxtErgebnis.AppendText(new string('-', 35) + "\r\n");

    int top = Math.Min(5, sortiert.Count);
    for (int i = 0; i < top; i++)
    {
      var kvp = sortiert[i];
      string balken = new string('█', kvp.Value);
      TxtErgebnis.AppendText($"{kvp.Key}: {balken} ({kvp.Value})\r\n");
    }
  }

  private static Dictionary<char, int> CountLetters(string text)
  {
    var result = new Dictionary<char, int>();
    foreach (char c in text.ToLower())
    {
      if (char.IsLetter(c))
      {
        if (result.ContainsKey(c))
          result[c]++;
        else
          result[c] = 1;
      }
    }
    return result;
  }

  private static List<KeyValuePair<char, int>> SortByFrequency(Dictionary<char, int> haeufigkeit)
  {
    var liste = new List<KeyValuePair<char, int>>(haeufigkeit);
    liste.Sort((a, b) => b.Value.CompareTo(a.Value));
    return liste;
  }
}
