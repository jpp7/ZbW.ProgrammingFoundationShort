namespace ZbW.ProgrammingFoundationShort.Lessons.Module07.Auftrag3_Kontaktmanager;

/// <summary>Kontakt-Klasse mit null-sicheren Operatoren und Equals.</summary>
public class PersonKontakt
{
  public string FirstName { get; set; } = "";
  public string LastName { get; set; } = "";
  public string? Email { get; set; } // nullable

  // TODO: Equals nach FirstName + LastName vergleichen
  // TODO: GetHashCode
  // TODO: ToString mit ?. und ?? für Email

  public override bool Equals(object? obj)
  {
    if (obj is PersonKontakt other)
      return FirstName == other.FirstName && LastName == other.LastName;
    return false;
  }

  public override int GetHashCode() => HashCode.Combine(FirstName, LastName);

  public override string ToString()
  {
    // ?. und ?? Operatoren
    return $"{FirstName} {LastName} – {Email ?? "(keine E-Mail)"}";
  }
}
