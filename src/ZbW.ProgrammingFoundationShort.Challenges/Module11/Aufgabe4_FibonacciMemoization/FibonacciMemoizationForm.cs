namespace ZbW.ProgrammingFoundationShort.Challenges.Module11.Aufgabe4_FibonacciMemoization;

public sealed class FibonacciMemoizationForm : Form
{
  private readonly NumericUpDown numN;
  private readonly ListBox lstOutput;

  public FibonacciMemoizationForm()
  {
    Text = "Fibonacci mit Memoization – Aufgabe 4";
    ClientSize = new Size(680, 360);

    Controls.Add(new Label { Location = new Point(12, 18), Size = new Size(80, 20), Text = "n:" });

    numN = new NumericUpDown { Location = new Point(95, 15), Size = new Size(80, 23), Minimum = 0, Maximum = 45, Value = 35 };
    Button cmdCompare = new Button { Location = new Point(195, 13), Size = new Size(140, 28), Text = "Vergleichen" };
    lstOutput = new ListBox { Location = new Point(12, 60), Size = new Size(640, 250) };

    cmdCompare.Click += CmdCompare_Click;

    Controls.Add(numN);
    Controls.Add(cmdCompare);
    Controls.Add(lstOutput);
  }

  private void CmdCompare_Click(object? sender, EventArgs e)
  {
    int n = (int)numN.Value;

    CountedResult slow = FibonacciRecursiveSlow(n);
    CountedResult memoized = FibonacciMemoized(n);

    lstOutput.Items.Clear();
    lstOutput.Items.Add($"Fibonacci({n}) = {memoized.Value}");
    lstOutput.Items.Add($"Naive Rekursion: {slow.Calls:N0} Aufrufe");
    lstOutput.Items.Add($"Memoization: {memoized.Calls:N0} Aufrufe");
    lstOutput.Items.Add("Merksatz: Memoization speichert bereits berechnete Teilprobleme.");
  }

  public static CountedResult FibonacciRecursiveSlow(int n)
  {
    long calls = 0;
    long value = Calculate(n);
    return new CountedResult(value, calls);

    long Calculate(int value)
    {
      calls++;

      if (value <= 1)
      {
        return value;
      }

      return Calculate(value - 1) + Calculate(value - 2);
    }
  }

  public static CountedResult FibonacciMemoized(int n)
  {
    long calls = 0;
    Dictionary<int, long> cache = new Dictionary<int, long>();
    long value = Calculate(n);
    return new CountedResult(value, calls);

    long Calculate(int value)
    {
      calls++;

      if (value <= 1)
      {
        return value;
      }

      if (cache.TryGetValue(value, out long cached))
      {
        return cached;
      }

      long result = Calculate(value - 1) + Calculate(value - 2);
      cache[value] = result;
      return result;
    }
  }
}

public readonly record struct CountedResult(long Value, long Calls);
