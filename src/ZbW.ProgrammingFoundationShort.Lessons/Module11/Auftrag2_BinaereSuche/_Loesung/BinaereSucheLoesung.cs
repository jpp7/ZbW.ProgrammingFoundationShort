namespace ZbW.ProgrammingFoundationShort.Lessons.Module11.Auftrag2_BinaereSuche._Loesung;

public static class BinaereSucheLoesung
{
  public static int FindIndex(int[] sortedNumbers, int target)
  {
    int left = 0;
    int right = sortedNumbers.Length - 1;

    while (left <= right)
    {
      int middle = left + (right - left) / 2;

      if (sortedNumbers[middle] == target)
      {
        return middle;
      }

      if (sortedNumbers[middle] < target)
      {
        left = middle + 1;
      }
      else
      {
        right = middle - 1;
      }
    }

    return -1;
  }

  public static string RunDemo()
  {
    int[] numbers = { 1, 4, 7, 10, 13 };
    return $"Index von 10: {FindIndex(numbers, 10)}";
  }
}