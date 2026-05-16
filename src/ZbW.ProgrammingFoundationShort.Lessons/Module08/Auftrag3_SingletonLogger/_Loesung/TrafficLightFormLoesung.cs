namespace ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag3_SingletonLogger._Loesung;

public sealed class TrafficLightFormLoesung : Form
{
  private TrafficLightStateLoesung currentState = TrafficLightStateLoesung.Red;
  private readonly Label lblState;
  private readonly Button cmdNext;
  private readonly Button cmdClear;
  private readonly ListBox lstLog;

  public TrafficLightFormLoesung()
  {
    Text = "Singleton Logger – Lösung";
    ClientSize = new Size(420, 300);

    lblState = new Label { Location = new Point(12, 12), Size = new Size(390, 32), Font = new Font(Font.FontFamily, 14F, FontStyle.Bold) };
    cmdNext = new Button { Location = new Point(12, 55), Size = new Size(120, 30), Text = "Weiter" };
    cmdClear = new Button { Location = new Point(145, 55), Size = new Size(120, 30), Text = "Log leeren" };
    lstLog = new ListBox { Location = new Point(12, 100), Size = new Size(390, 180) };

    cmdNext.Click += CmdNext_Click;
    cmdClear.Click += CmdClear_Click;

    Controls.Add(lblState);
    Controls.Add(cmdNext);
    Controls.Add(cmdClear);
    Controls.Add(lstLog);

    SingletonLoggerLoesung.Instance.Log("Ampel gestartet.");
    UpdateView();
  }

  private void CmdNext_Click(object sender, EventArgs e)
  {
    currentState = currentState switch
    {
      TrafficLightStateLoesung.Red => TrafficLightStateLoesung.Green,
      TrafficLightStateLoesung.Green => TrafficLightStateLoesung.Yellow,
      _ => TrafficLightStateLoesung.Red
    };

    SingletonLoggerLoesung.Instance.Log($"Zustand gewechselt zu {currentState}.");
    UpdateView();
  }

  private void CmdClear_Click(object sender, EventArgs e)
  {
    SingletonLoggerLoesung.Instance.Clear();
    UpdateView();
  }

  private void UpdateView()
  {
    lblState.Text = $"Aktueller Zustand: {currentState}";
    lstLog.Items.Clear();

    foreach (string message in SingletonLoggerLoesung.Instance.Messages)
      lstLog.Items.Add(message);
  }
}

public enum TrafficLightStateLoesung
{
  Red,
  Yellow,
  Green
}
