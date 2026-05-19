namespace ZbW.ProgrammingFoundationShort.Lessons.Module06.Auftrag3_ValidierteProperties;

// ============================================================
// HILFSKLASSE: Person mit validierenden Properties
// ============================================================

public class Person
{
  private string _name = "";
  private int _age;
  private string _email = "";

  // TODO: Name-Property mit Validierung (nicht leer)
  public string Name
  {
    get => _name;
    set
    {
      // TODO: if empty -> throw ArgumentException
      _name = value;
    }
  }

  // TODO: Age-Property mit Validierung (0-120)
  public int Age
  {
    get => _age;
    set
    {
      // TODO: if < 0 || > 120 -> throw ArgumentOutOfRangeException
      _age = value;
    }
  }

  // TODO: Email-Property mit Validierung (enthält @)
  public string Email
  {
    get => _email;
    set
    {
      // TODO: if !Contains("@") -> throw ArgumentException
      _email = value;
    }
  }

  // TODO: Konstruktor mit name, age und email ergänzen.

  public override string ToString()
  {
    return $"{Name}, {Age} Jahre, {Email}";
  }
}
