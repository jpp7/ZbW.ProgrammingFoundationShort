namespace ZbW.ProgrammingFoundationShort.Challenges.Module04.Aufgabe4_SortierVisualisierung;

/// <summary>
///   Aufgabe 4 – Sortier-Visualisierung (⭐⭐⭐ Schwer)
///   BubbleSort mit Vergleichszähler.
/// </summary>
public partial class SortierVisualisierungForm : Form
{
  public SortierVisualisierungForm()
  {
    InitializeComponent();
  }

  private void CmdSortieren_Click(object sender, EventArgs e)
  {
    int[] zahlen;
    try
    {
      zahlen = InputToArray(TxtEingabe.Text);
    }
    catch (FormatException)
    {
      MessageBox.Show("Bitte kommagetrennte Zahlen eingeben (z.B. 5,3,8,1,9).",
        "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    if (zahlen.Length < 2)
    {
      MessageBox.Show("Bitte mindestens 2 Zahlen eingeben.",
        "Zu wenig", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    TxtErgebnis.Clear();
    TxtErgebnis.AppendText($"Eingabe: {string.Join(", ", zahlen)}\r\n");
    TxtErgebnis.AppendText(new string('-', 40) + "\r\n");

    int vergleiche = BubbleSort(zahlen);

    TxtErgebnis.AppendText($"Sortiert: {string.Join(", ", zahlen)}\r\n");
    TxtErgebnis.AppendText(new string('-', 40) + "\r\n");
    TxtErgebnis.AppendText($"Vergleiche: {vergleiche}\r\n");
    TxtErgebnis.AppendText($"Sortiert korrekt: {IsSorted(zahlen)}\r\n");
  }

  private static int[] InputToArray(string eingabe)
  {
    string[] teile = eingabe.Split(',');
    int[] zahlen = new int[teile.Length];
    for (int i = 0; i < teile.Length; i++)
      zahlen[i] = int.Parse(teile[i].Trim());
    return zahlen;
  }

  private int BubbleSort(int[] arr)
  {
    int vergleiche = 0;
    for (int i = 0; i < arr.Length - 1; i++)
    {
      for (int j = 0; j < arr.Length - 1 - i; j++)
      {
        vergleiche++;
        if (arr[j] > arr[j + 1])
        {
          (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
          TxtErgebnis.AppendText($"  Tausch: [{string.Join(", ", arr)}]\r\n");
        }
      }
    }
    return vergleiche;
  }

  private static bool IsSorted(int[] arr)
  {
    for (int i = 0; i < arr.Length - 1; i++)
      if (arr[i] > arr[i + 1]) return false;
    return true;
  }
}
