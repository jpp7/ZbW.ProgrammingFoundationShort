namespace ZbW.ProgrammingFoundationShort.Challenges.Module11.Aufgabe1_WortUmkehren;

public sealed class WortUmkehrenForm : Form
{
  private readonly TextBox txtWord;
  private readonly Label lblIterative;
  private readonly Label lblRecursive;
  private readonly Label lblReflection;

  public WortUmkehrenForm()
  {
    Text = "Wort umkehren – Aufgabe 1";
    ClientSize = new Size(560, 240);

    Controls.Add(new Label { Location = new Point(12, 18), Size = new Size(80, 20), Text = "Wort:" });

    txtWord = new TextBox { Location = new Point(95, 15), Size = new Size(180, 23), Text = "Algorithmus" };
    Button cmdReverse = new Button { Location = new Point(290, 13), Size = new Size(110, 28), Text = "Umkehren" };
    lblIterative = new Label { Location = new Point(12, 65), Size = new Size(520, 25) };
    lblRecursive = new Label { Location = new Point(12, 100), Size = new Size(520, 25) };
    lblReflection = new Label { Location = new Point(12, 140), Size = new Size(520, 70) };

    cmdReverse.Click += CmdReverse_Click;

    Controls.Add(txtWord);
    Controls.Add(cmdReverse);
    Controls.Add(lblIterative);
    Controls.Add(lblRecursive);
    Controls.Add(lblReflection);
  }

  private void CmdReverse_Click(object? sender, EventArgs e)
  {
    string word = txtWord.Text;
    lblIterative.Text = $"Iterativ: {ReverseIterative(word)}";
    lblRecursive.Text = $"Rekursiv: {ReverseRecursive(word)}";
    lblReflection.Text = "Reflexion: Im Alltag ist die iterative Variante meist einfacher zu debuggen. " +
                         "Rekursion zeigt aber gut das Prinzip: ein Zeichen plus das kleinere Restproblem.";
  }

  public static string ReverseIterative(string text)
  {
    char[] result = new char[text.Length];

    for (int i = 0; i < text.Length; i++)
    {
      result[i] = text[text.Length - 1 - i];
    }

    return new string(result);
  }

  public static string ReverseRecursive(string text)
  {
    if (text.Length <= 1)
    {
      return text;
    }

    return ReverseRecursive(text[1..]) + text[0];
  }
}
