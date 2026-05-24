namespace ZbW.ProgrammingFoundationShort.Lessons.Module11.Auftrag1_IterationRekursion._Loesung;

public static class IterationRekursionLoesung
{
  public static long FactorialIterative(int n)
  {
    if (n < 0)
    {
      throw new ArgumentOutOfRangeException(nameof(n), "n darf nicht negativ sein.");
    }

    long result = 1;

    for (int i = 2; i <= n; i++)
    {
      result *= i;
    }

    return result;
  }

  public static long FactorialRecursive(int n)
  {
    if (n < 0)
    {
      throw new ArgumentOutOfRangeException(nameof(n), "n darf nicht negativ sein.");
    }

    if (n <= 1)
    {
      return 1;
    }

    return n * FactorialRecursive(n - 1);
  }

  public static long FibonacciRecursiveSlow(int n)
  {
    if (n < 0)
    {
      throw new ArgumentOutOfRangeException(nameof(n), "n darf nicht negativ sein.");
    }

    if (n <= 1)
    {
      return n;
    }

    return FibonacciRecursiveSlow(n - 1) + FibonacciRecursiveSlow(n - 2);
  }

  public static string RunDemo()
  {
    return string.Join(Environment.NewLine, new[]
    {
      $"5! iterativ = {FactorialIterative(5)}",
      $"5! rekursiv = {FactorialRecursive(5)}",
      $"Fib(10) rekursiv = {FibonacciRecursiveSlow(10)}"
    });
  }
}