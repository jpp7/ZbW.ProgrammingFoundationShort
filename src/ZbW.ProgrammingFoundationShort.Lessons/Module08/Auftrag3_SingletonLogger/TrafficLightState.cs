namespace ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag3_SingletonLogger;

public enum TrafficLightColor
{
  Red,
  Yellow,
  Green
}

public static class TrafficLight
{
  public const int ChangeIntervalMs = 2000;

  public static TrafficLightColor CurrentColor { get; private set; } = TrafficLightColor.Red;

  public static void Change()
  {
    // TODO: Red -> Green -> Yellow -> Red wechseln.
  }
}
