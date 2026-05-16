namespace ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag3_SingletonLogger;

// ============================================================
// AUFTRAG 3 – Enum-gesteuerte TrafficLight mit Singleton-Logger
//
// Anforderungen:
//   - Enum TrafficLightColor verwenden
//   - Klasse TrafficLight mit CurrentColor, Change() und ChangeIntervalMs
//   - Timer wechselt alle 2 Sekunden die Farbe
//   - Panel und Label zeigen aktuellen Zustand
//   - AppLogger.Instance für Log-Einträge verwenden
//   - ListBox zeigt alle Log-Meldungen
// ============================================================

public sealed class TrafficLightForm : Form
{
  private readonly System.Windows.Forms.Timer timer;
  private readonly Panel pnlTrafficLight;
  private readonly Label lblState;
  private readonly Button cmdStartStop;
  private readonly Button cmdClear;
  private readonly ListBox lstLog;

  public TrafficLightForm()
  {
    Text = "Singleton Logger – Auftrag 3";
    ClientSize = new Size(460, 340);

    pnlTrafficLight = new Panel { Location = new Point(12, 12), Size = new Size(120, 90), BorderStyle = BorderStyle.FixedSingle };
    lblState = new Label { Location = new Point(145, 12), Size = new Size(290, 45), Font = new Font(Font.FontFamily, 14F, FontStyle.Bold) };
    cmdStartStop = new Button { Location = new Point(145, 70), Size = new Size(120, 30), Text = "Start" };
    cmdClear = new Button { Location = new Point(275, 70), Size = new Size(120, 30), Text = "Log leeren" };
    lstLog = new ListBox { Location = new Point(12, 120), Size = new Size(420, 200) };

    timer = new System.Windows.Forms.Timer();
    timer.Interval = TrafficLight.ChangeIntervalMs;
    timer.Tick += Timer_Tick;

    cmdStartStop.Click += CmdStartStop_Click;
    cmdClear.Click += CmdClear_Click;

    Controls.Add(pnlTrafficLight);
    Controls.Add(lblState);
    Controls.Add(cmdStartStop);
    Controls.Add(cmdClear);
    Controls.Add(lstLog);

    UpdateView();
  }

  private void Timer_Tick(object sender, EventArgs e)
  {
    // TODO 1: TrafficLight.Change() aufrufen.
    // TODO 2: AppLogger.Instance.Log(...) aufrufen.
    // TODO 3: UpdateView() aufrufen.
  }

  private void CmdStartStop_Click(object sender, EventArgs e)
  {
    // TODO: Timer starten/stoppen und Buttontext aktualisieren.
  }

  private void CmdClear_Click(object sender, EventArgs e)
  {
    AppLogger.Instance.Clear();
    UpdateView();
  }

  private void UpdateView()
  {
    lblState.Text = $"Aktuelle Farbe: {TrafficLight.CurrentColor}";
    pnlTrafficLight.BackColor = Color.Gray;
    lstLog.Items.Clear();

    foreach (string message in AppLogger.Instance.Messages)
      lstLog.Items.Add(message);
  }
}
