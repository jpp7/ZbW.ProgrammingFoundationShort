namespace ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag3_SingletonLogger._Loesung;

public sealed class AppLoggerLoesung
{
  private static readonly AppLoggerLoesung InstanceValue = new AppLoggerLoesung();
  private readonly List<string> messages = new List<string>();

  private AppLoggerLoesung()
  {
  }

  public static AppLoggerLoesung Instance
  {
    get { return InstanceValue; }
  }

  public IReadOnlyList<string> Messages
  {
    get { return messages; }
  }

  public void Log(string message)
  {
    messages.Add($"{DateTime.Now:HH:mm:ss} - {message}");
  }

  public void Clear()
  {
    messages.Clear();
  }
}
