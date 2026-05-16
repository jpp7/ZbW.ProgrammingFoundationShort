namespace ZbW.ProgrammingFoundationShort.Lessons.Module06.Auftrag2_FahrzeugVerwaltung;

// ============================================================
// HILFSKLASSE: Vehicle
// ============================================================

public class Vehicle
{
  public string Make { get; set; } = "";
  public string Model { get; set; } = "";
  public int Year { get; set; }
  public decimal Price { get; set; }

  // TODO: Age-Property (berechnete Property: DateTime.Now.Year - Year)
  public int Age => DateTime.Now.Year - Year;

  // TODO: Description()-Methode: $"{Year} {Make} {Model} ({Price:C})"
  public string Description()
  {
    return $"{Year} {Make} {Model} – {Price:C} (Alter: {Age} Jahre)";
  }
}
