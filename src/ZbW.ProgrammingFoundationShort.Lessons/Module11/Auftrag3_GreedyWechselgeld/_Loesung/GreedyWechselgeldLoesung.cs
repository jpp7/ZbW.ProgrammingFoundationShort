namespace ZbW.ProgrammingFoundationShort.Lessons.Module11.Auftrag3_GreedyWechselgeld._Loesung;

public static class GreedyWechselgeldLoesung
{
  public static List<int> MakeChange(int amount, int[] coins)
  {
    if (amount < 0)
    {
      throw new ArgumentOutOfRangeException(nameof(amount), "Betrag darf nicht negativ sein.");
    }

    int[] sortedCoins = coins
      .Where(coin => coin > 0)
      .OrderByDescending(coin => coin)
      .ToArray();

    var result = new List<int>();
    int rest = amount;

    foreach (int coin in sortedCoins)
    {
      while (rest >= coin)
      {
        result.Add(coin);
        rest -= coin;
      }
    }

    if (rest != 0)
    {
      throw new InvalidOperationException("Der Betrag kann mit diesen Muenzen nicht exakt gebildet werden.");
    }

    return result;
  }

  public static string RunDemo()
  {
    int[] coins = { 100, 50, 20, 10, 5, 2, 1 };
    return string.Join(", ", MakeChange(87, coins));
  }
}