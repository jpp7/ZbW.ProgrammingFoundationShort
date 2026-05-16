namespace ZbW.ProgrammingFoundationShort.Lessons.Module07.Auftrag2_EqualsUeberschreiben;

/// <summary>Produkt-Klasse mit überschriebenem Equals für Artikelnummer-Vergleich.</summary>
public class ProductEquals
{
  public string ArticleNumber { get; set; } = "";
  public string Name { get; set; } = "";
  public decimal Price { get; set; }

  // TODO: Equals überschreiben (nach ArticleNumber vergleichen)
  // TODO: GetHashCode überschreiben
  // TODO: ToString überschreiben

  public override bool Equals(object? obj)
  {
    // TODO: if (obj is ProductEquals other) return ArticleNumber == other.ArticleNumber;
    throw new NotImplementedException("TODO: Equals implementieren");
  }

  public override int GetHashCode()
  {
    // TODO: return ArticleNumber.GetHashCode();
    throw new NotImplementedException("TODO: GetHashCode implementieren");
  }

  public override string ToString()
  {
    // TODO: $"[{ArticleNumber}] {Name} – {Price:C}"
    throw new NotImplementedException("TODO: ToString implementieren");
  }
}
