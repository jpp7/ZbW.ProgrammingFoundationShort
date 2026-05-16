namespace ZbW.ProgrammingFoundationShort.Challenges.Module10.Aufgabe1_SuchVergleich;

public sealed class SuchVergleichForm : Form
{
  private readonly TextBox txtNumbers;
  private readonly TextBox txtTarget;
  private readonly Label lblResult;

  public SuchVergleichForm()
  {
    Text = "Such-Vergleich – Aufgabe 1";
    ClientSize = new Size(560, 220);

    txtNumbers = new TextBox { Location = new Point(12, 12), Size = new Size(520, 23), Text = "3,1,7,5,9,2,8,4,6" };
    txtTarget = new TextBox { Location = new Point(12, 50), Size = new Size(80, 23), Text = "8" };
    Button cmdLinear = new Button { Location = new Point(105, 48), Size = new Size(110, 28), Text = "Linear Suchen" };
    Button cmdBinary = new Button { Location = new Point(225, 48), Size = new Size(110, 28), Text = "Binär Suchen" };
    lblResult = new Label { Location = new Point(12, 95), Size = new Size(520, 100) };

    cmdLinear.Click += CmdLinear_Click;
    cmdBinary.Click += CmdBinary_Click;

    Controls.Add(txtNumbers);
    Controls.Add(txtTarget);
    Controls.Add(cmdLinear);
    Controls.Add(cmdBinary);
    Controls.Add(lblResult);
  }

  private void CmdLinear_Click(object sender, EventArgs e)
  {
    ShowComparison("Linear");
  }

  private void CmdBinary_Click(object sender, EventArgs e)
  {
    ShowComparison("Binär");
  }

  private void ShowComparison(string selectedAlgorithm)
  {
    int[] numbers = ParseNumbers();
    int target = int.Parse(txtTarget.Text);
    int linearIndex = SearchAlgorithms.LinearSearch(numbers, target, out int linearComparisons);
    int[] sorted = numbers.ToArray();
    Array.Sort(sorted);
    int binaryIndex = SearchAlgorithms.BinarySearch(sorted, target, out int binaryComparisons);

    lblResult.Text = $"{selectedAlgorithm} gewählt\r\n" +
                     $"Linear: Index {linearIndex}, {linearComparisons} Vergleiche | Binär: Index {binaryIndex}, {binaryComparisons} Vergleiche\r\n" +
                     $"Sortiert: {string.Join(", ", sorted)}";
  }

  private int[] ParseNumbers()
  {
    return txtNumbers.Text.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(value => int.Parse(value.Trim())).ToArray();
  }
}

public static class SearchAlgorithms
{
  public static int LinearSearch(int[] numbers, int target, out int comparisons)
  {
    comparisons = 0;

    for (int index = 0; index < numbers.Length; index++)
    {
      comparisons++;

      if (numbers[index] == target)
        return index;
    }

    return -1;
  }

  public static int BinarySearch(int[] numbers, int target, out int comparisons)
  {
    comparisons = 0;
    int left = 0;
    int right = numbers.Length - 1;

    while (left <= right)
    {
      comparisons++;
      int middle = left + (right - left) / 2;

      if (numbers[middle] == target)
        return middle;

      if (numbers[middle] < target)
        left = middle + 1;
      else
        right = middle - 1;
    }

    return -1;
  }
}
