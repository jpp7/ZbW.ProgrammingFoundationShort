namespace ZbW.ProgrammingFoundationShort.Lessons.Module04.Auftrag3_MatrixMultiplikation;

// ============================================================
// AUFTRAG 3 – MatrixMultiplikation (⭐⭐⭐ Schwer | ~20 Min.)
//
// Multipliziert zwei 2×2-Matrizen.
//
// Anforderungen:
//   - Methode int[,] Multiply(int[,] a, int[,] b)
//   - Formel: c[i,j] = Summe(a[i,k] * b[k,j])
//   - Start() mit zwei Beispielmatrizen und Ausgabe
// ============================================================

public static class MatrixRechner
{
  public static void Start()
  {
    // TODO 1: Zwei 2×2-Matrizen definieren
    //         int[,] a = { {1, 2}, {3, 4} };
    //         int[,] b = { {5, 6}, {7, 8} };

    // TODO 2: Multiply aufrufen und Ergebnis ausgeben
  }

  public static int[,] Multiply(int[,] a, int[,] b)
  {
    // TODO: 2×2 Matrix-Multiplikation implementieren
    //       int[,] result = new int[2, 2];
    //       for i in 0..1: for j in 0..1: for k in 0..1: result[i,j] += a[i,k]*b[k,j]
    throw new NotImplementedException("TODO: Multiply implementieren");
  }
}
