namespace ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag3_TrafficLightLogger;

public static class AppLogger
{
  private static readonly List<string> messages = new List<string>();

  public static IReadOnlyList<string> Messages
  {
    get { return messages; }
  }

  public static void Log(string message)
  {
    // TODO: Zeitstempel und Meldung in messages speichern.
  }

  public static void Clear()
  {
    messages.Clear();
  }
}