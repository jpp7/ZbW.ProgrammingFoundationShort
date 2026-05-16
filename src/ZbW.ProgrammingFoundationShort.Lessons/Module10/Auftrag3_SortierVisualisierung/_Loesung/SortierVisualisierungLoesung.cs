using System.Text;

namespace ZbW.ProgrammingFoundationShort.Lessons.Module10.Auftrag3_SortierVisualisierung._Loesung;

public static class SortierVisualisierungLoesung
{
  public static string BubbleSortSteps(int[] numbers)
  {
    int[] values = numbers.ToArray();
    int comparisons = 0;
    int swaps = 0;
    StringBuilder builder = new StringBuilder();

    for (int outer = 0; outer < values.Length - 1; outer++)
    {
      for (int inner = 0; inner < values.Length - outer - 1; inner++)
      {
        comparisons++;

        if (values[inner] > values[inner + 1])
        {
          int temp = values[inner];
          values[inner] = values[inner + 1];
          values[inner + 1] = temp;
          swaps++;
          builder.AppendLine($"Tausch {swaps}: {string.Join(", ", values)}");
        }
      }
    }

    int[] systemSorted = numbers.ToArray();
    Array.Sort(systemSorted);

    builder.AppendLine($"Vergleiche: {comparisons}");
    builder.AppendLine($"Tausche: {swaps}");
    builder.AppendLine($"Sortiert: {string.Join(", ", values)}");
    builder.AppendLine($"Array.Sort: {string.Join(", ", systemSorted)}");
    return builder.ToString();
  }
}
