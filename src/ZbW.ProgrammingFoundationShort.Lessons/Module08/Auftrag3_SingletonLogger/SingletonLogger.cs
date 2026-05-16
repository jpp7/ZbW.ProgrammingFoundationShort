namespace ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag3_SingletonLogger;

public sealed class SingletonLogger
{
  private static readonly SingletonLogger InstanceValue = new SingletonLogger();
  private readonly List<string> messages = new List<string>();

  private SingletonLogger()
  {
  }

  public static SingletonLogger Instance
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
