namespace ZbW.ProgrammingFoundationShort.Lessons.Module04.Auftrag3_MatrixMultiplikation;

/// <summary>
///   Lösung: Auftrag 3 – Matrix-Multiplikation
///   2×2-Matrizen multiplizieren mit geschachtelten Schleifen.
/// </summary>
public static class MatrixRechnerLoesung
{
  public static void Start()
  {
    int[,] a = { { 1, 2 }, { 3, 4 } };
    int[,] b = { { 5, 6 }, { 7, 8 } };

    Console.WriteLine("Matrix A:");
    PrintMatrix(a);
    Console.WriteLine("Matrix B:");
    PrintMatrix(b);

    int[,] result = Multiply(a, b);
    Console.WriteLine("A × B =");
    PrintMatrix(result);
    // Erwartetes Ergebnis: [[19,22],[43,50]]
  }

  public static int[,] Multiply(int[,] a, int[,] b)
  {
    int[,] result = new int[2, 2];
    for (int i = 0; i < 2; i++)
      for (int j = 0; j < 2; j++)
        for (int k = 0; k < 2; k++)
          result[i, j] += a[i, k] * b[k, j];
    return result;
  }

  private static void PrintMatrix(int[,] m)
  {
    Console.WriteLine($"  | {m[0, 0],4} {m[0, 1],4} |");
    Console.WriteLine($"  | {m[1, 0],4} {m[1, 1],4} |");
  }
}
