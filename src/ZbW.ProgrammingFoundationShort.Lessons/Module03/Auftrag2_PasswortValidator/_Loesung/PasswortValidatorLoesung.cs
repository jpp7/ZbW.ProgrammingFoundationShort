namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag2_PasswortValidator;

/// <summary>
///   Lösung: Auftrag 2 – PasswortValidator
///   do-while-Schleife mit LINQ-Validierung.
/// </summary>
public static class PasswortValidatorLoesung
{
  public static void Start()
  {
    Console.WriteLine("=== Passwort-Validator ===");
    string passwort;

    do
    {
      Console.Write("Passwort eingeben: ");
      passwort = Console.ReadLine() ?? "";

      if (!Pruefen(passwort))
      {
        Console.WriteLine("Ungültiges Passwort!");
        if (passwort.Length < 8)
          Console.WriteLine("  - Mindestens 8 Zeichen erforderlich.");
        if (!passwort.Any(char.IsDigit))
          Console.WriteLine("  - Mindestens eine Ziffer erforderlich.");
      }
    } while (!Pruefen(passwort));

    Console.WriteLine($"Passwort '{passwort}' ist gültig!");
  }

  public static bool Pruefen(string passwort)
  {
    return passwort.Length >= 8 && passwort.Any(char.IsDigit);
  }
}
