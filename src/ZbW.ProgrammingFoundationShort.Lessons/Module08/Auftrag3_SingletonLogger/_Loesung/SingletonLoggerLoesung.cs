namespace ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag3_SingletonLogger._Loesung;

public sealed class SingletonLoggerLoesung
{
  private static readonly SingletonLoggerLoesung InstanceValue = new SingletonLoggerLoesung();
  private readonly List<string> messages = new List<string>();

  private SingletonLoggerLoesung()
  {
  }

  public static SingletonLoggerLoesung Instance
  {
    get { return InstanceValue; }
  }

  public IReadOnlyList<string> Messages
  {
    get { return messages; }
  }

  public void Log(string message)
  {
    messages.Add($"{DateTime.Now:HH:mm:ss} – {message}");
  }

  public void Clear()
  {
    messages.Clear();
  }
}
