namespace ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag3_TrafficLightLogger._Loesung;

public sealed class TrafficLightFormLoesung : Form
{
  private readonly System.Windows.Forms.Timer timer;
  private readonly Panel pnlTrafficLight;
  private readonly Label lblState;
  private readonly Button cmdStartStop;
  private readonly Button cmdClear;
  private readonly ListBox lstLog;

  public TrafficLightFormLoesung()
  {
    Text = "TrafficLight Logger – Lösung";
    ClientSize = new Size(460, 340);

    pnlTrafficLight = new Panel { Location = new Point(12, 12), Size = new Size(120, 90), BorderStyle = BorderStyle.FixedSingle };
    lblState = new Label { Location = new Point(145, 12), Size = new Size(290, 45), Font = new Font(Font.FontFamily, 14F, FontStyle.Bold) };
    cmdStartStop = new Button { Location = new Point(145, 70), Size = new Size(120, 30), Text = "Start" };
    cmdClear = new Button { Location = new Point(275, 70), Size = new Size(120, 30), Text = "Log leeren" };
    lstLog = new ListBox { Location = new Point(12, 120), Size = new Size(420, 200) };

    timer = new System.Windows.Forms.Timer();
    timer.Interval = TrafficLightLoesung.ChangeIntervalMs;
    timer.Tick += Timer_Tick;

    cmdStartStop.Click += CmdStartStop_Click;
    cmdClear.Click += CmdClear_Click;

    Controls.Add(pnlTrafficLight);
    Controls.Add(lblState);
    Controls.Add(cmdStartStop);
    Controls.Add(cmdClear);
    Controls.Add(lstLog);

    AppLoggerLoesung.Log("Ampel initialisiert.");
    UpdateView();
  }

  private void Timer_Tick(object sender, EventArgs e)
  {
    TrafficLightLoesung.Change();
    AppLoggerLoesung.Log($"Wechsel zu {TrafficLightLoesung.CurrentColor} um {DateTime.Now:HH:mm:ss}");
    UpdateView();
  }

  private void CmdStartStop_Click(object sender, EventArgs e)
  {
    timer.Enabled = !timer.Enabled;
    cmdStartStop.Text = timer.Enabled ? "Stop" : "Start";
  }

  private void CmdClear_Click(object sender, EventArgs e)
  {
    AppLoggerLoesung.Clear();
    UpdateView();
  }

  private void UpdateView()
  {
    lblState.Text = TrafficLightLoesung.CurrentColor switch
    {
      TrafficLightColorLoesung.Red => "Rot - stopp",
      TrafficLightColorLoesung.Yellow => "Gelb - bereit",
      _ => "Grün - fahren"
    };

    pnlTrafficLight.BackColor = TrafficLightLoesung.CurrentColor switch
    {
      TrafficLightColorLoesung.Red => Color.Red,
      TrafficLightColorLoesung.Yellow => Color.Gold,
      _ => Color.Green
    };

    lstLog.Items.Clear();

    foreach (string message in AppLoggerLoesung.Messages)
      lstLog.Items.Add(message);
  }
}

public enum TrafficLightColorLoesung
{
  Red,
  Yellow,
  Green
}

public static class TrafficLightLoesung
{
  public const int ChangeIntervalMs = 2000;

  public static TrafficLightColorLoesung CurrentColor { get; private set; } = TrafficLightColorLoesung.Red;

  public static void Change()
  {
    CurrentColor = CurrentColor switch
    {
      TrafficLightColorLoesung.Red => TrafficLightColorLoesung.Green,
      TrafficLightColorLoesung.Green => TrafficLightColorLoesung.Yellow,
      _ => TrafficLightColorLoesung.Red
    };
  }
}
