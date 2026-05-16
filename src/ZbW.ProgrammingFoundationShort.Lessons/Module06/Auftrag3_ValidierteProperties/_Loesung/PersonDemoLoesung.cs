namespace ZbW.ProgrammingFoundationShort.Lessons.Module06.Auftrag3_ValidierteProperties;

/// <summary>
///   Lösung: PersonDemo – Validierung und Equals demonstrieren.
/// </summary>
public static class PersonDemoLoesung
{
  public static void Start()
  {
    Console.WriteLine("=== Person-Demo ===\n");

    // Gültige Person
    var p1 = new PersonLoesung { Name = "Anna", Age = 25, Email = "anna@mail.ch" };
    Console.WriteLine($"Person 1: {p1}");

    // Ungültiges Alter
    try
    {
      var p2 = new PersonLoesung { Name = "Bob", Age = 200, Email = "bob@test.ch" };
    }
    catch (ArgumentOutOfRangeException ex)
    {
      Console.WriteLine($"Fehler: {ex.Message}");
    }

    // Ungültige E-Mail
    try
    {
      var p3 = new PersonLoesung { Name = "Carla", Age = 30, Email = "keine-email" };
    }
    catch (ArgumentException ex)
    {
      Console.WriteLine($"Fehler: {ex.Message}");
    }

    // Equals testen
    var pA = new PersonLoesung { Name = "Anna", Age = 30, Email = "anna@mail.ch" };
    var pB = new PersonLoesung { Name = "Anna", Age = 25, Email = "anna@mail.ch" };
    Console.WriteLine($"\np1.Equals(pA): {p1.Equals(pA)} (erwarte: true, Alter irrelevant)");
    Console.WriteLine($"p1.Equals(pB): {p1.Equals(pB)} (erwarte: true)");
  }
}
