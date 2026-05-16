namespace ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag1_StatischerZaehler;

/// <summary>Lösung: StatischerZaehler-Demo.</summary>
public static class StatischerZaehlerDemoLoesung
{
  public static void Start()
  {
    Console.WriteLine($"User zu Beginn: {UserStaticLoesung.UserCount}"); // 0

    var u1 = new UserStaticLoesung("Anna");
    var u2 = new UserStaticLoesung("Bob");
    var u3 = new UserStaticLoesung("Carla");

    Console.WriteLine($"Erstellte User: {UserStaticLoesung.UserCount}"); // 3
    Console.WriteLine($"u1: {u1.Name}, u2: {u2.Name}, u3: {u3.Name}");
    Console.WriteLine("→ UserCount ist statisch: gehört zur Klasse, nicht zum Objekt");
  }
}
