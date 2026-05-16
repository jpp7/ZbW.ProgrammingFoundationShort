namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag2_PasswortValidator;

// ============================================================
// AUFTRAG 2 – PasswortValidator (⭐⭐ Mittel | ~15 Min.)
//
// Validiert ein Passwort und fordert erneute Eingabe per do-while.
//
// Anforderungen:
//   - do-while-Schleife: solange Passwort ungültig
//   - Validierung: Length >= 8 && Any(IsDigit)
//   - Fehlermeldung: was fehlt
// ============================================================

public static class PasswortValidator
{
  public static void Start()
  {
    // TODO 1: do-while Schleife starten
    //         string passwort;
    //         do {
    //           Console.Write("Passwort eingeben: ");
    //           passwort = Console.ReadLine() ?? "";
    //           if (!Pruefen(passwort)) Console.WriteLine("Ungültig: ...");
    //         } while (!Pruefen(passwort));

    // TODO 2: Erfolgsmeldung ausgeben
  }

  public static bool Pruefen(string passwort)
  {
    // TODO: Length >= 8 UND mindestens eine Ziffer
    //       passwort.Length >= 8 && passwort.Any(char.IsDigit)
    throw new NotImplementedException("TODO: Pruefen implementieren");
  }
}
