namespace ZbW.ProgrammingFoundationShort.Challenges.Module12.Aufgabe4_EinfacherCache;

public sealed class EinfacherCacheForm : Form
{
  private readonly TextBox txtKey;
  private readonly TextBox txtValue;
  private readonly ListBox lstOutput;
  private readonly SimpleCache cache = new SimpleCache(3);

  public EinfacherCacheForm()
  {
    Text = "Einfacher Cache – Aufgabe 4";
    ClientSize = new Size(720, 400);

    Controls.Add(new Label { Location = new Point(12, 18), Size = new Size(90, 20), Text = "Key:" });
    Controls.Add(new Label { Location = new Point(12, 55), Size = new Size(90, 20), Text = "Value:" });

    txtKey = new TextBox { Location = new Point(105, 15), Size = new Size(160, 23), Text = "A" };
    txtValue = new TextBox { Location = new Point(105, 52), Size = new Size(160, 23), Text = "Alpha" };
    Button cmdAdd = new Button { Location = new Point(285, 13), Size = new Size(100, 28), Text = "Speichern" };
    Button cmdRead = new Button { Location = new Point(395, 13), Size = new Size(100, 28), Text = "Lesen" };
    Button cmdDemo = new Button { Location = new Point(505, 13), Size = new Size(120, 28), Text = "Demo füllen" };
    lstOutput = new ListBox { Location = new Point(12, 100), Size = new Size(680, 250) };

    cmdAdd.Click += CmdAdd_Click;
    cmdRead.Click += CmdRead_Click;
    cmdDemo.Click += CmdDemo_Click;

    Controls.Add(txtKey);
    Controls.Add(txtValue);
    Controls.Add(cmdAdd);
    Controls.Add(cmdRead);
    Controls.Add(cmdDemo);
    Controls.Add(lstOutput);
  }

  private void CmdAdd_Click(object? sender, EventArgs e)
  {
    cache.Set(txtKey.Text, txtValue.Text);
    ShowCache($"Gespeichert: {txtKey.Text}");
  }

  private void CmdRead_Click(object? sender, EventArgs e)
  {
    string message = cache.TryGet(txtKey.Text, out string? value)
      ? $"Gefunden: {txtKey.Text} = {value}"
      : $"Nicht gefunden: {txtKey.Text}";

    ShowCache(message);
  }

  private void CmdDemo_Click(object? sender, EventArgs e)
  {
    cache.Set("A", "Alpha");
    cache.Set("B", "Beta");
    cache.Set("C", "Gamma");
    cache.Set("D", "Delta");
    ShowCache("Demo: A wurde entfernt, weil der Cache nur 3 Einträge behält.");
  }

  private void ShowCache(string message)
  {
    lstOutput.Items.Clear();
    lstOutput.Items.Add(message);
    lstOutput.Items.Add("Cache-Inhalt:");

    foreach (KeyValuePair<string, string> item in cache.Items)
    {
      lstOutput.Items.Add($"  {item.Key}: {item.Value}");
    }

    lstOutput.Items.Add("Datenstrukturen: Dictionary für schnellen Zugriff, Queue für die Einfüge-Reihenfolge.");
  }
}

public sealed class SimpleCache
{
  private readonly int capacity;
  private readonly Dictionary<string, string> values = new Dictionary<string, string>();
  private readonly Queue<string> insertionOrder = new Queue<string>();

  public SimpleCache(int capacity)
  {
    if (capacity <= 0)
    {
      throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity muss positiv sein.");
    }

    this.capacity = capacity;
  }

  public IReadOnlyDictionary<string, string> Items => values;

  public void Set(string key, string value)
  {
    if (values.ContainsKey(key))
    {
      values[key] = value;
      return;
    }

    if (values.Count >= capacity)
    {
      string oldestKey = insertionOrder.Dequeue();
      values.Remove(oldestKey);
    }

    values[key] = value;
    insertionOrder.Enqueue(key);
  }

  public bool TryGet(string key, out string? value)
  {
    return values.TryGetValue(key, out value);
  }
}
