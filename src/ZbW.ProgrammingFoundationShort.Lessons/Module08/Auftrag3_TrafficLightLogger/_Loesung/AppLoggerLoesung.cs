namespace ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag3_TrafficLightLogger._Loesung;

public static class AppLoggerLoesung
{
  private static readonly List<string> messages = new List<string>();

  public static IReadOnlyList<string> Messages
  {
    get { return messages; }
  }

  public static void Log(string message)
  {
    messages.Add($"{DateTime.Now:HH:mm:ss} - {message}");
  }

  public static void Clear()
  {
    messages.Clear();
  }
}