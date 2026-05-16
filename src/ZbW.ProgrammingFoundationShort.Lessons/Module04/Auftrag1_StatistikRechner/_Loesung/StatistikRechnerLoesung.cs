namespace ZbW.ProgrammingFoundationShort.Lessons.Module04.Auftrag1_StatistikRechner;

/// <summary>
///   Lösung: Auftrag 1 – StatistikRechner
///   Arrays und Methoden für Minimum, Maximum, Durchschnitt.
/// </summary>
public static class StatistikRechnerLoesung
{
  public static void Start()
  {
    int[] zahlen = new int[5];

    Console.WriteLine("=== Statistik-Rechner ===");
    Console.WriteLine("5 Zahlen eingeben:");

    for (int i = 0; i < zahlen.Length; i++)
    {
      Console.Write($"  Zahl {i + 1}: ");
      while (!int.TryParse(Console.ReadLine(), out zahlen[i]))
        Console.Write("  Ungültig. Nochmal: ");
    }

    Console.WriteLine($"\nMinimum:     {Minimum(zahlen)}");
    Console.WriteLine($"Maximum:     {Maximum(zahlen)}");
    Console.WriteLine($"Durchschnitt:{Average(zahlen):F2}");
  }

  public static int Minimum(int[] zahlen)
  {
    int min = zahlen[0];
    for (int i = 1; i < zahlen.Length; i++)
      if (zahlen[i] < min)
        min = zahlen[i];
    return min;
  }

  public static int Maximum(int[] zahlen)
  {
    int max = zahlen[0];
    for (int i = 1; i < zahlen.Length; i++)
      if (zahlen[i] > max)
        max = zahlen[i];
    return max;
  }

  public static double Average(int[] zahlen)
  {
    int summe = 0;
    for (int i = 0; i < zahlen.Length; i++)
      summe += zahlen[i];
    return (double)summe / zahlen.Length;
  }
}
