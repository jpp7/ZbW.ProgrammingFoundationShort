namespace ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag3_SingletonLogger;

public sealed class AppLogger
{
  private static readonly AppLogger InstanceValue = new AppLogger();
  private readonly List<string> messages = new List<string>();

  private AppLogger()
  {
  }

  public static AppLogger Instance
  {
    get { return InstanceValue; }
  }

  public IReadOnlyList<string> Messages
  {
    get { return messages; }
  }

  public void Log(string message)
  {
    // TODO: Zeitstempel und Meldung in messages speichern.
  }

  public void Clear()
  {
    messages.Clear();
  }
}
