namespace ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag1_Taschenrechner;

/// <summary>
/// Musterlösung: Auftrag 1 – Taschenrechner
/// </summary>
public static class TaschenrechnerLoesung
{
  public static void Start()
  {
    Console.Write("Erste Zahl: ");
    if (!double.TryParse(Console.ReadLine(), out double zahl1))
    {
      Console.WriteLine("Ungültige Zahl.");
      return;
    }

    Console.Write("Zweite Zahl: ");
    if (!double.TryParse(Console.ReadLine(), out double zahl2))
    {
      Console.WriteLine("Ungültige Zahl.");
      return;
    }

    Console.Write("Operation (+, -, *, /): ");
    string operation = Console.ReadLine() ?? "";

    try
    {
      double result = Berechnen(zahl1, zahl2, operation);
      Console.WriteLine($"Ergebnis: {result:F2}");
    }
    catch (DivideByZeroException)
    {
      Console.WriteLine("Fehler: Division durch 0 ist nicht erlaubt.");
    }
    catch (ArgumentException ex)
    {
      Console.WriteLine($"Fehler: {ex.Message}");
    }
  }

  public static double Berechnen(double zahl1, double zahl2, string operation)
  {
    switch (operation)
    {
      case "+": return zahl1 + zahl2;
      case "-": return zahl1 - zahl2;
      case "*": return zahl1 * zahl2;
      case "/":
        if (zahl2 == 0)
          throw new DivideByZeroException("Divisor darf nicht 0 sein.");
        return zahl1 / zahl2;
      default:
        throw new ArgumentException($"Unbekannter Operator: '{operation}'");
    }
  }
}
