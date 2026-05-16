using System.Diagnostics;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module10.Aufgabe3_SortierAnalyse;

public sealed class SortierAnalyseForm : Form
{
  private readonly TextBox txtSize;
  private readonly ListBox lstResults;

  public SortierAnalyseForm()
  {
    Text = "Sortier-Analyse – Aufgabe 3";
    ClientSize = new Size(620, 330);

    txtSize = new TextBox { Location = new Point(12, 12), Size = new Size(100, 23), Text = "1000" };
    Button cmdRandom = new Button { Location = new Point(125, 10), Size = new Size(130, 28), Text = "Zufällig testen" };
    Button cmdSorted = new Button { Location = new Point(265, 10), Size = new Size(150, 28), Text = "Sortiert testen" };
    lstResults = new ListBox { Location = new Point(12, 55), Size = new Size(590, 250) };

    cmdRandom.Click += (sender, args) => RunAnalysis(false);
    cmdSorted.Click += (sender, args) => RunAnalysis(true);

    Controls.Add(txtSize);
    Controls.Add(cmdRandom);
    Controls.Add(cmdSorted);
    Controls.Add(lstResults);
  }

  private void RunAnalysis(bool sortedInput)
  {
    int size = Math.Clamp(int.Parse(txtSize.Text), 100, 50000);
    int[] numbers = SortAlgorithms.GenerateRandom(size);

    if (sortedInput)
      Array.Sort(numbers);

    lstResults.Items.Clear();

    Stopwatch stopwatch = Stopwatch.StartNew();
    SortAlgorithms.BubbleSort(numbers, out int bubbleComparisons);
    stopwatch.Stop();
    lstResults.Items.Add($"Bubble Sort | Vergleiche: {bubbleComparisons} | Zeit: {stopwatch.ElapsedMilliseconds} ms");

    stopwatch.Restart();
    SortAlgorithms.SelectionSort(numbers, out int selectionComparisons);
    stopwatch.Stop();
    lstResults.Items.Add($"Selection Sort | Vergleiche: {selectionComparisons} | Zeit: {stopwatch.ElapsedMilliseconds} ms");

    stopwatch.Restart();
    SortAlgorithms.SystemSort(numbers);
    stopwatch.Stop();
    lstResults.Items.Add($"Array.Sort | Vergleiche: n/a | Zeit: {stopwatch.ElapsedMilliseconds} ms");
  }
}

public static class SortAlgorithms
{
  public static int[] GenerateRandom(int size)
  {
    Random random = new Random(42);
    int[] numbers = new int[size];

    for (int index = 0; index < numbers.Length; index++)
      numbers[index] = random.Next(1, 100000);

    return numbers;
  }

  public static int[] BubbleSort(int[] numbers, out int comparisons)
  {
    int[] result = numbers.ToArray();
    comparisons = 0;

    for (int outer = 0; outer < result.Length - 1; outer++)
    {
      bool swapped = false;

      for (int inner = 0; inner < result.Length - outer - 1; inner++)
      {
        comparisons++;

        if (result[inner] > result[inner + 1])
        {
          int temp = result[inner];
          result[inner] = result[inner + 1];
          result[inner + 1] = temp;
          swapped = true;
        }
      }

      if (!swapped)
        break;
    }

    return result;
  }

  public static int[] SelectionSort(int[] numbers, out int comparisons)
  {
    int[] result = numbers.ToArray();
    comparisons = 0;

    for (int outer = 0; outer < result.Length - 1; outer++)
    {
      int minIndex = outer;

      for (int inner = outer + 1; inner < result.Length; inner++)
      {
        comparisons++;

        if (result[inner] < result[minIndex])
          minIndex = inner;
      }

      int temp = result[outer];
      result[outer] = result[minIndex];
      result[minIndex] = temp;
    }

    return result;
  }

  public static int[] SystemSort(int[] numbers)
  {
    int[] result = numbers.ToArray();
    Array.Sort(result);
    return result;
  }
}
