using System.Diagnostics;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module10.Aufgabe4_RekursionsVisualisierung;

public sealed class RekursionsVisualisierungForm : Form
{
  private readonly TextBox txtN;
  private readonly ListBox lstResults;

  public RekursionsVisualisierungForm()
  {
    Text = "Rekursions-Visualisierung – Aufgabe 4";
    ClientSize = new Size(560, 300);

    txtN = new TextBox { Location = new Point(12, 12), Size = new Size(80, 23), Text = "20" };
    Button cmdCalculate = new Button { Location = new Point(105, 10), Size = new Size(110, 28), Text = "Berechnen" };
    lstResults = new ListBox { Location = new Point(12, 55), Size = new Size(520, 220) };

    cmdCalculate.Click += CmdCalculate_Click;

    Controls.Add(txtN);
    Controls.Add(cmdCalculate);
    Controls.Add(lstResults);
  }

  private void CmdCalculate_Click(object sender, EventArgs e)
  {
    int n = Math.Clamp(int.Parse(txtN.Text), 1, 40);
    lstResults.Items.Clear();

    if (n > 35)
      lstResults.Items.Add("Warnung: Rekursive Variante sehr langsam!");

    Stopwatch stopwatch = Stopwatch.StartNew();
    Fibonacci.CallCount = 0;
    int recursive = Fibonacci.FibonacciRecursive(n);
    stopwatch.Stop();
    lstResults.Items.Add($"Rekursiv: {recursive}, Aufrufe: {Fibonacci.CallCount}, Zeit: {stopwatch.ElapsedMilliseconds} ms");

    stopwatch.Restart();
    int iterative = Fibonacci.FibonacciIterative(n);
    stopwatch.Stop();
    lstResults.Items.Add($"Iterativ: {iterative}, Zeit: {stopwatch.ElapsedMilliseconds} ms");

    stopwatch.Restart();
    long memo = Fibonacci.FibonacciMemo(n, new Dictionary<int, long>());
    stopwatch.Stop();
    lstResults.Items.Add($"Memoization: {memo}, Zeit: {stopwatch.ElapsedMilliseconds} ms");
  }
}

public static class Fibonacci
{
  public static int CallCount { get; set; }

  public static int FibonacciRecursive(int n)
  {
    CallCount++;

    if (n <= 1)
      return n;

    return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
  }

  public static int FibonacciIterative(int n)
  {
    if (n <= 1)
      return n;

    int previous = 0;
    int current = 1;

    for (int index = 2; index <= n; index++)
    {
      int next = previous + current;
      previous = current;
      current = next;
    }

    return current;
  }

  public static long FibonacciMemo(int n, Dictionary<int, long> memo)
  {
    if (n <= 1)
      return n;

    if (memo.TryGetValue(n, out long cached))
      return cached;

    long result = FibonacciMemo(n - 1, memo) + FibonacciMemo(n - 2, memo);
    memo[n] = result;
    return result;
  }
}
