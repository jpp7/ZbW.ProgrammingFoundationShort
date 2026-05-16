namespace ZbW.ProgrammingFoundationShort.Challenges.Module07.Aufgabe2_EqualsImplementieren;

/// <summary>Produkt mit Equals nach Artikelnummer.</summary>
public class ProductVergleich
{
  public string Name { get; set; } = "";
  public string ArticleNumber { get; set; } = "";
  public decimal Price { get; set; }

  public override bool Equals(object? obj)
  {
    if (obj is ProductVergleich other)
      return ArticleNumber == other.ArticleNumber;
    return false;
  }

  public override int GetHashCode() => ArticleNumber.GetHashCode();

  public override string ToString() => $"[{ArticleNumber}] {Name} ({Price:C})";

  public static ProductVergleich? FindProduct(List<ProductVergleich> list, string articleNumber)
  {
    return list.Find(p => p.ArticleNumber == articleNumber);
  }
}
