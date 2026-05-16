namespace ZbW.ProgrammingFoundationShort.Lessons.Module07.Auftrag2_EqualsUeberschreiben;

/// <summary>
///   Lösung: ProductEquals mit korrektem Equals/GetHashCode.
/// </summary>
public class ProductEqualsLoesung
{
  public string ArticleNumber { get; set; } = "";
  public string Name { get; set; } = "";
  public decimal Price { get; set; }

  public override bool Equals(object? obj)
  {
    if (obj is ProductEqualsLoesung other)
      return ArticleNumber == other.ArticleNumber;
    return false;
  }

  public override int GetHashCode() => ArticleNumber.GetHashCode();

  public override string ToString() => $"[{ArticleNumber}] {Name} – {Price:C}";
}
