namespace ZbW.ProgrammingFoundationShort.Challenges.Module05.Aufgabe4_HaeufigkeitsAnalyse;

/// <summary>
///   Aufgabe 4 – Häufigkeits-Analyse (⭐⭐⭐⭐ Bonus)
///   Buchstabenhäufigkeit mit Dictionary, params-Formatierung und Vergleichswerten.
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

    Dictionary<char, int> haeufigkeit = CountLetters(text);
    List<KeyValuePair<char, int>> sortiert = SortByFrequency(haeufigkeit);
    KeyValuePair<char, int>[] topFive = sortiert.Take(5).ToArray();

    TxtErgebnis.Clear();
    TxtErgebnis.AppendText($"Analysierter Text: {text.Length} Zeichen\r\n");
    TxtErgebnis.AppendText("Top-5 Buchstaben:\r\n");
    TxtErgebnis.AppendText(new string('-', 35) + "\r\n");
    TxtErgebnis.AppendText(FormatOutput(topFive));
    TxtErgebnis.AppendText("\r\nDeutsch häufig: e, n, i, s, r, a ...\r\n");
  }

  private static Dictionary<char, int> CountLetters(string text)
  {
    var result = new Dictionary<char, int>();
    foreach (char raw in text.ToLowerInvariant())
    {
      if (raw < 'a' || raw > 'z')
        continue;

      if (result.ContainsKey(raw))
        result[raw]++;
      else
        result[raw] = 1;
    }
    return result;
  }

  private static List<KeyValuePair<char, int>> SortByFrequency(Dictionary<char, int> dict)
  {
    var liste = new List<KeyValuePair<char, int>>(dict);
    liste.Sort((a, b) => b.Value.CompareTo(a.Value));
    return liste;
  }

  private static string FormatOutput(params KeyValuePair<char, int>[] entries)
  {
    var builder = new System.Text.StringBuilder();

    foreach (KeyValuePair<char, int> entry in entries)
    {
      string balken = new string('█', Math.Min(entry.Value, 40));
      builder.AppendLine($"{entry.Key}: {balken} ({entry.Value})");
    }

    return builder.ToString();
  }
}