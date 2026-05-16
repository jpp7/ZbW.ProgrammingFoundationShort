using System.Diagnostics;
using System.Text;

namespace ZbW.ProgrammingFoundationShort.Lessons.Module10.Auftrag1_SucheVergleichen._Loesung;

public static class SucheVergleichenLoesung
{
  public static int LinearSearch(int[] numbers, int target)
  {
    for (int index = 0; index < numbers.Length; index++)
    {
      if (numbers[index] == target)
        return index;
    }

    return -1;
  }

  public static int BinarySearch(int[] numbers, int target)
  {
    int left = 0;
    int right = numbers.Length - 1;

    while (left <= right)
    {
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

  public static string RunDemo()
  {
    Random random = new Random(42);
    int[] numbers = Enumerable.Range(0, 10000).Select(_ => random.Next(1, 100001)).ToArray();
    int target = numbers[7500];

    Stopwatch stopwatch = Stopwatch.StartNew();
    int linearIndex = LinearSearch(numbers, target);
    stopwatch.Stop();
    long linearTicks = stopwatch.ElapsedTicks;

    int[] sorted = numbers.ToArray();
    Array.Sort(sorted);

    stopwatch.Restart();
    int binaryIndex = BinarySearch(sorted, target);
    stopwatch.Stop();

    StringBuilder builder = new StringBuilder();
    builder.AppendLine($"Suchwert: {target}");
    builder.AppendLine($"Linear: Index {linearIndex}, {linearTicks} Ticks");
    builder.AppendLine($"Binär: Index {binaryIndex}, {stopwatch.ElapsedTicks} Ticks");
    return builder.ToString();
  }
}
