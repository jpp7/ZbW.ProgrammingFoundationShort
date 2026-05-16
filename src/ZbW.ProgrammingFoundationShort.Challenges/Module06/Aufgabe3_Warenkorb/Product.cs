namespace ZbW.ProgrammingFoundationShort.Challenges.Module06.Aufgabe3_Warenkorb;

/// <summary>Produkt mit Name, Preis und Menge.</summary>
public class Product
{
  public string Name { get; set; } = "";
  public decimal Price { get; set; }
  public int Quantity { get; set; }

  public decimal Total => Price * Quantity;

  public override string ToString()
  {
    return $"{Name,-20} {Quantity,3} × {Price,8:C} = {Total,10:C}";
  }
}
