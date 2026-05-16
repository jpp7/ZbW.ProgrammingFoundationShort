namespace ZbW.ProgrammingFoundationShort.Challenges.Module06.Aufgabe3_Warenkorb;

/// <summary>Warenkorb mit Produktverwaltung.</summary>
public class ShoppingCart
{
  private readonly List<Product> _items = new();

  public int GetItemCount() => _items.Count;

  public decimal GetTotal()
  {
    decimal total = 0;
    foreach (var item in _items)
      total += item.Total;
    return total;
  }

  public void AddProduct(Product product)
  {
    // Prüfen ob Produkt bereits vorhanden
    var existing = _items.Find(p => p.Name == product.Name);
    if (existing != null)
      existing.Quantity += product.Quantity;
    else
      _items.Add(product);
  }

  public bool RemoveProduct(string name)
  {
    var produkt = _items.Find(p => p.Name == name);
    if (produkt == null) return false;
    _items.Remove(produkt);
    return true;
  }

  public string GetReceipt()
  {
    var sb = new System.Text.StringBuilder();
    sb.AppendLine("========== KASSENBON ==========");
    foreach (var item in _items)
      sb.AppendLine(item.ToString());
    sb.AppendLine(new string('-', 45));
    sb.AppendLine($"{"TOTAL",-20} {"",14} {GetTotal(),10:C}");
    sb.AppendLine($"Anzahl Artikel: {GetItemCount()}");
    return sb.ToString();
  }
}
