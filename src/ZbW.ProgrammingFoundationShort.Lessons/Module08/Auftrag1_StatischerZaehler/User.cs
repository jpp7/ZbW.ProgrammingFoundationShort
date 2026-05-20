namespace ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag1_StatischerZaehler;

/// <summary>User-Klasse mit statischem Zähler.</summary>
public class User
{
  // TODO: private static int _userCount = 0;
  // TODO: public static int UserCount => _userCount;

  public string Name { get; set; } = "";

  public User(string name)
  {
    // TODO: _userCount++;
    Name = name;
  }
}