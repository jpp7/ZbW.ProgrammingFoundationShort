namespace ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag1_StatischerZaehler;

/// <summary>Lösung: User mit statischem Zähler.</summary>
public class UserLoesung
{
  private static int _userCount = 0;

  public static int UserCount => _userCount;

  public string Name { get; set; }

  public UserLoesung(string name)
  {
    _userCount++;
    Name = name;
  }
}