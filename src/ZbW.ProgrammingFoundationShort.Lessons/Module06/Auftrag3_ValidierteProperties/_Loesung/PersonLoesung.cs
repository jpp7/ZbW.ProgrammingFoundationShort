namespace ZbW.ProgrammingFoundationShort.Lessons.Module06.Auftrag3_ValidierteProperties;

/// <summary>
///   Lösung: Person-Klasse mit validierenden Properties.
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
      if (value < 0 || value > 120)
        throw new ArgumentOutOfRangeException(nameof(value), "Alter muss zwischen 0 und 120 liegen.");
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

  public PersonLoesung(string name, int age, string email)
  {
    Name = name;
    Age = age;
    Email = email;
  }

  public override string ToString()
  {
    return $"{Name}, {Age} Jahre, {Email}";
  }
}
