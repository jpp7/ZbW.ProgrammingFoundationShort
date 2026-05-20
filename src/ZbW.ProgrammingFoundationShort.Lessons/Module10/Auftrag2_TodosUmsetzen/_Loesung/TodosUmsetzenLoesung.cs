namespace ZbW.ProgrammingFoundationShort.Lessons.Module10.Auftrag2_TodosUmsetzen._Loesung;

public static class TodosUmsetzenLoesung
{
  public static string EvaluatePoints(int points)
  {
    if (points < 0 || points > 100)
    {
      return "Ungültig";
    }

    if (points >= 80)
    {
      return "Sehr gut";
    }

    if (points >= 60)
    {
      return "Bestanden";
    }

    return "Nicht bestanden";
  }

  public static string RunDemo()
  {
    int[] testValues = { -5, 50, 60, 85, 120 };
    List<string> lines = new List<string>();

    foreach (int points in testValues)
    {
      lines.Add($"{points}: {EvaluatePoints(points)}");
    }

    return string.Join(Environment.NewLine, lines);
  }
}