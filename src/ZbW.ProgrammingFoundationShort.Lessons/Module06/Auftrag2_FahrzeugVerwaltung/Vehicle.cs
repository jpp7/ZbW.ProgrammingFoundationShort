namespace ZbW.ProgrammingFoundationShort.Lessons.Module06.Auftrag2_FahrzeugVerwaltung;

// ============================================================
// HILFSKLASSE: Vehicle
// ============================================================

public class Vehicle
{
  public string Make { get; set; }
  public string Model { get; set; }
  public int Year { get; set; }
  public decimal Price { get; set; }

  public Vehicle(string make, string model, int year, decimal price)
  {
    Make = make;
    Model = model;
    Year = year;
    Price = price;
  }

  public int Age => DateTime.Now.Year - Year;

  public string Description()
  {
    return $"{Year} {Make} {Model} – {Price:F2} CHF (Alter: {Age} Jahre)";
  }
}