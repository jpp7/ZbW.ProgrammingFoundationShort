namespace ZbW.ProgrammingFoundationShort.Lessons.Module07.Auftrag2_EqualsUeberschreiben;

/// <summary>
///   Lösung: == vs .Equals() Demo und HashSet.
/// </summary>
public static class ProductEqualsDemoLoesung
{
  public static void Start()
  {
    Console.WriteLine("=== Equals-Demo ===\n");

    var p1 = new ProductEqualsLoesung { ArticleNumber = "A001", Name = "Schraube M8", Price = 0.50m };
    var p2 = new ProductEqualsLoesung { ArticleNumber = "A001", Name = "Schraube M8 (Kopie)", Price = 0.55m };
    var p3 = new ProductEqualsLoesung { ArticleNumber = "B002", Name = "Mutter M8", Price = 0.30m };

    Console.WriteLine($"p1: {p1}");
    Console.WriteLine($"p2: {p2}");

    // == vergleicht Referenzen
    Console.WriteLine($"\np1 == p2: {p1 == p2}");       // false
    Console.WriteLine($"p1.Equals(p2): {p1.Equals(p2)}"); // true (gleiche Artikelnummer)
    Console.WriteLine($"p1.Equals(p3): {p1.Equals(p3)}"); // false

    // HashSet verwendet GetHashCode + Equals
    var set = new HashSet<ProductEqualsLoesung> { p1, p2, p3 };
    Console.WriteLine($"\nHashSet-Grösse (erwarte 2): {set.Count}");
  }
}
