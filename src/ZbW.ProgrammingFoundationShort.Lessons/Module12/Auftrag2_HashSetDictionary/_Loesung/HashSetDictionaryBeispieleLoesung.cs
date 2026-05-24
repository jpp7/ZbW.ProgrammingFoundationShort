namespace ZbW.ProgrammingFoundationShort.Lessons.Module12.Auftrag2_HashSetDictionary._Loesung;

public static class HashSetDictionaryBeispieleLoesung
{
  public static List<string> RemoveDuplicatesPreserveOrder(IEnumerable<string> names)
  {
    var seen = new HashSet<string>();
    var result = new List<string>();

    foreach (string name in names)
    {
      if (seen.Add(name))
      {
        result.Add(name);
      }
    }

    return result;
  }

  public static Dictionary<string, int> CountWords(string text)
  {
    var counts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
    string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

    foreach (string word in words)
    {
      if (counts.ContainsKey(word))
      {
        counts[word]++;
      }
      else
      {
        counts[word] = 1;
      }
    }

    return counts;
  }

  public static string RunDemo()
  {
    var names = RemoveDuplicatesPreserveOrder(new[] { "Anna", "Ben", "Anna", "Clara" });
    var counts = CountWords("rot blau rot gruen");

    return $"Namen: {string.Join(", ", names)}{Environment.NewLine}rot: {counts["rot"]}";
  }
}