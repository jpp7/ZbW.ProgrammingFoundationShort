namespace ZbW.ProgrammingFoundationShort.Lessons.Module06.Auftrag3_ValidierteProperties;

/// <summary>
///   Lösung: PersonDemo – Validierung demonstrieren.
/// </summary>
public static class PersonDemoLoesung
{
  public static void Start()
  {
    Console.WriteLine("=== Person-Demo ===\n");

    var anna = new PersonLoesung("Anna", 25, "anna@mail.ch");
    Console.WriteLine($"Gültige Person: {anna}");

    try
    {
      var invalidAge = new PersonLoesung("Bob", 200, "bob@test.ch");
    }
    catch (ArgumentOutOfRangeException ex)
    {
      Console.WriteLine($"Fehler: {ex.Message}");
    }

    try
    {
      var invalidEmail = new PersonLoesung("Carla", 30, "keine-email");
    }
    catch (ArgumentException ex)
    {
      Console.WriteLine($"Fehler: {ex.Message}");
    }
  }
}
