namespace ZbW.ProgrammingFoundationShort.Challenges.Module08.Aufgabe4_StatischerLogger;

public sealed class StatischerLoggerForm : Form
{
  private readonly TextBox txtMessage;
  private readonly TextBox txtLog;
  private readonly ComboBox cmbFilter;

  public StatischerLoggerForm()
  {
    Text = "Statischer Logger – Aufgabe 4";
    ClientSize = new Size(560, 360);

    txtMessage = new TextBox { Location = new Point(12, 12), Size = new Size(300, 23), Text = "Neue Meldung" };
    Button cmdInfo = new Button { Location = new Point(320, 10), Size = new Size(60, 27), Text = "Info" };
    Button cmdWarning = new Button { Location = new Point(385, 10), Size = new Size(75, 27), Text = "Warning" };
    Button cmdError = new Button { Location = new Point(465, 10), Size = new Size(60, 27), Text = "Error" };
    Button cmdClear = new Button { Location = new Point(12, 45), Size = new Size(80, 27), Text = "Leeren" };
    cmbFilter = new ComboBox { Location = new Point(105, 47), Size = new Size(130, 23), DropDownStyle = ComboBoxStyle.DropDownList };
    txtLog = new TextBox { Location = new Point(12, 85), Size = new Size(520, 250), Multiline = true, ScrollBars = ScrollBars.Vertical };

    cmbFilter.Items.AddRange(new object[] { "Alle", "Info", "Warning", "Error" });
    cmbFilter.SelectedIndex = 0;

    cmdInfo.Click += (sender, args) => AddLog(LogLevel.Info);
    cmdWarning.Click += (sender, args) => AddLog(LogLevel.Warning);
    cmdError.Click += (sender, args) => AddLog(LogLevel.Error);
    cmdClear.Click += (sender, args) =>
    {
      AppLogger.Clear();
      RefreshLog();
    };
    cmbFilter.SelectedIndexChanged += (sender, args) => RefreshLog();

    Controls.Add(txtMessage);
    Controls.Add(cmdInfo);
    Controls.Add(cmdWarning);
    Controls.Add(cmdError);
    Controls.Add(cmdClear);
    Controls.Add(cmbFilter);
    Controls.Add(txtLog);
  }

  private void AddLog(LogLevel level)
  {
    AppLogger.Log(txtMessage.Text, level);
    RefreshLog();
  }

  private void RefreshLog()
  {
    LogLevel? filter = cmbFilter.SelectedItem?.ToString() switch
    {
      "Info" => LogLevel.Info,
      "Warning" => LogLevel.Warning,
      "Error" => LogLevel.Error,
      _ => null
    };

    List<string> entries = AppLogger.GetLogs(filter);
    txtLog.Text = string.Join(Environment.NewLine, entries);
  }
}

public enum LogLevel
{
  Info,
  Warning,
  Error
}

public static class AppLogger
{
  private static readonly List<string> LogEntries = new List<string>();

  public static void Log(string message, LogLevel level)
  {
    LogEntries.Add($"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] [{level.ToString().ToUpperInvariant()}] {message}");
  }

  public static List<string> GetLogs(LogLevel? level = null)
  {
    if (level == null)
      return LogEntries.ToList();

    string levelText = $"[{level.Value.ToString().ToUpperInvariant()}]";
    return LogEntries.Where(entry => entry.Contains(levelText)).ToList();
  }

  public static void Clear()
  {
    LogEntries.Clear();
  }
}
