namespace ZbW.ProgrammingFoundationShort.Challenges.Module06.Aufgabe1_Fahrzeug;

/// <summary>
///   Fahrzeug-Klasse mit Drive()-Methode und Kilometerstand.
/// </summary>
public class Vehicle
{
  public string Make { get; set; } = "";
  public string Model { get; set; } = "";
  public int Year { get; set; }
  public double Mileage { get; private set; }

  public string GetInfo()
  {
    return $"{Year} {Make} {Model} | Kilometerstand: {Mileage:F1} km";
  }

  public void Drive(double km)
  {
    if (km <= 0)
      throw new ArgumentException("Kilometeranzahl muss positiv sein.");
    Mileage += km;
  }
}
