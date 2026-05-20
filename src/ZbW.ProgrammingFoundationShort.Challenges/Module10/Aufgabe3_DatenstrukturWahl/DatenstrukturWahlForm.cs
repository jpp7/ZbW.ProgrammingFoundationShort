namespace ZbW.ProgrammingFoundationShort.Challenges.Module10.Aufgabe3_DatenstrukturWahl;

public sealed class DatenstrukturWahlForm : Form
{
  private readonly ListBox lstOutput;
  private readonly Stack<string> history = new Stack<string>();

  public DatenstrukturWahlForm()
  {
    Text = "Datenstruktur wählen – Aufgabe 3";
    ClientSize = new Size(620, 360);

    Button cmdList = new Button { Location = new Point(12, 12), Size = new Size(150, 30), Text = "List Beispiel" };
    Button cmdDictionary = new Button { Location = new Point(172, 12), Size = new Size(150, 30), Text = "Dictionary Beispiel" };
    Button cmdStack = new Button { Location = new Point(332, 12), Size = new Size(150, 30), Text = "Stack Beispiel" };
    lstOutput = new ListBox { Location = new Point(12, 60), Size = new Size(580, 270) };

    cmdList.Click += (_, _) => ShowListExample();
    cmdDictionary.Click += (_, _) => ShowDictionaryExample();
    cmdStack.Click += (_, _) => ShowStackExample();

    Controls.Add(cmdList);
    Controls.Add(cmdDictionary);
    Controls.Add(cmdStack);
    Controls.Add(lstOutput);
  }

  private void ShowListExample()
  {
    List<string> todos = new List<string> { "Ablauf planen", "TODOs schreiben", "Code testen" };
    lstOutput.Items.Clear();
    lstOutput.Items.Add("List<T>: mehrere Werte flexibel speichern");

    foreach (string todo in todos)
    {
      lstOutput.Items.Add(todo);
    }
  }

  private void ShowDictionaryExample()
  {
    Dictionary<string, string> phoneBook = new Dictionary<string, string>
    {
      ["Ana"] = "079 111 22 33",
      ["Ben"] = "079 444 55 66"
    };

    lstOutput.Items.Clear();
    lstOutput.Items.Add("Dictionary<K,V>: Schlüssel führt zum Wert");
    lstOutput.Items.Add($"Ana: {phoneBook["Ana"]}");
    lstOutput.Items.Add($"Ben: {phoneBook["Ben"]}");
  }

  private void ShowStackExample()
  {
    if (history.Count == 0)
    {
      history.Push("start.ch");
      history.Push("lernen.zbw.ch");
      history.Push("github.com");
    }

    lstOutput.Items.Clear();
    lstOutput.Items.Add("Stack<T>: zuletzt hinein, zuerst heraus");

    while (history.Count > 0)
    {
      lstOutput.Items.Add($"Zurück zu: {history.Pop()}");
    }
  }
}