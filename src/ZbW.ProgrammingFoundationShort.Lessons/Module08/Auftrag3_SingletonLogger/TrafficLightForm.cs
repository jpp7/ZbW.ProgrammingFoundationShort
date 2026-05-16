namespace ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag3_SingletonLogger;

// ============================================================
// AUFTRAG 3 – Enum-gesteuerte TrafficLight mit Singleton-Logger
//
// Anforderungen:
//   - Enum TrafficLightState verwenden
//   - SingletonLogger.Instance für Log-Einträge verwenden
//   - Button "Weiter" schaltet Rot -> Grün -> Gelb -> Rot
//   - Label zeigt aktuellen Zustand
//   - ListBox zeigt alle Log-Meldungen
// ============================================================

public sealed class TrafficLightForm : Form
{
  private TrafficLightState currentState = TrafficLightState.Red;
  private readonly Label lblState;
  private readonly Button cmdNext;
  private readonly Button cmdClear;
  private readonly ListBox lstLog;

  public TrafficLightForm()
  {
    Text = "Singleton Logger – Auftrag 3";
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

    UpdateView();
  }

  private void CmdNext_Click(object sender, EventArgs e)
  {
    // TODO 1: currentState mit switch auf den nächsten Zustand setzen.
    // TODO 2: SingletonLogger.Instance.Log(...) aufrufen.
    // TODO 3: UpdateView() aufrufen.
  }

  private void CmdClear_Click(object sender, EventArgs e)
  {
    SingletonLogger.Instance.Clear();
    UpdateView();
  }

  private void UpdateView()
  {
    lblState.Text = $"Aktueller Zustand: {currentState}";
    lstLog.Items.Clear();

    foreach (string message in SingletonLogger.Instance.Messages)
      lstLog.Items.Add(message);
  }
}
