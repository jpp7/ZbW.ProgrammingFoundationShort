namespace ZbW.ProgrammingFoundationShort.Challenges.Module08.Aufgabe4_StatischerLogger;

public sealed class StatischerLoggerForm : Form
{
  private readonly TextBox txtMessage;
  private readonly ListBox lstLog;

  public StatischerLoggerForm()
  {
    Text = "Statischer Logger – Aufgabe 4";
    ClientSize = new Size(460, 300);

    txtMessage = new TextBox { Location = new Point(12, 12), Size = new Size(300, 23), Text = "Neue Meldung" };
    Button cmdInfo = new Button { Location = new Point(320, 10), Size = new Size(60, 27), Text = "Info" };
    Button cmdError = new Button { Location = new Point(385, 10), Size = new Size(60, 27), Text = "Error" };
    Button cmdClear = new Button { Location = new Point(12, 45), Size = new Size(80, 27), Text = "Leeren" };
    lstLog = new ListBox { Location = new Point(12, 85), Size = new Size(430, 190) };

    cmdInfo.Click += (sender, args) => AddLog("INFO");
    cmdError.Click += (sender, args) => AddLog("ERROR");
    cmdClear.Click += (sender, args) =>
    {
      StaticLogger.Clear();
      RefreshLog();
    };

    Controls.Add(txtMessage);
    Controls.Add(cmdInfo);
    Controls.Add(cmdError);
    Controls.Add(cmdClear);
    Controls.Add(lstLog);
  }

  private void AddLog(string level)
  {
    StaticLogger.Log(level, txtMessage.Text);
    RefreshLog();
  }

  private void RefreshLog()
  {
    lstLog.Items.Clear();

    foreach (string entry in StaticLogger.Entries)
      lstLog.Items.Add(entry);
  }
}

public static class StaticLogger
{
  private static readonly List<string> LogEntries = new List<string>();

  public static IReadOnlyList<string> Entries
  {
    get { return LogEntries; }
  }

  public static void Log(string level, string message)
  {
    LogEntries.Add($"{DateTime.Now:HH:mm:ss} [{level}] {message}");
  }

  public static void Clear()
  {
    LogEntries.Clear();
  }
}
