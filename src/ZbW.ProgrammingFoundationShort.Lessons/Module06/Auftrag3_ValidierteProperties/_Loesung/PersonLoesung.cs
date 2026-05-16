namespace ZbW.ProgrammingFoundationShort.Lessons.Module06.Auftrag3_ValidierteProperties;

/// <summary>
///   Lösung: Person-Klasse mit validierenden Properties und Equals.
/// </summary>
public class PersonLoesung
{
  private string _name = "";
  private int _age;
  private string _email = "";

  public string Name
  {
    get => _name;
    set
    {
      if (string.IsNullOrWhiteSpace(value))
        throw new ArgumentException("Name darf nicht leer sein.");
      _name = value.Trim();
    }
  }

  public int Age
  {
    get => _age;
    set
    {
      if (value < 0 || value > 150)
        throw new ArgumentOutOfRangeException(nameof(value), "Alter muss zwischen 0 und 150 liegen.");
      _age = value;
    }
  }

  public string Email
  {
    get => _email;
    set
    {
      if (!value.Contains('@'))
        throw new ArgumentException("E-Mail muss ein @-Zeichen enthalten.");
      _email = value;
    }
  }

  public override bool Equals(object? obj)
  {
    if (obj is PersonLoesung other)
      return Name == other.Name && Email == other.Email;
    return false;
  }

  public override int GetHashCode()
  {
    return HashCode.Combine(Name, Email);
  }

  public override string ToString()
  {
    return $"{Name}, {Age} Jahre, {Email}";
  }
}
