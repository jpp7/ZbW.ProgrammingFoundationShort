namespace ZbW.ProgrammingFoundationShort.Lessons.Module07.Auftrag3_Kontaktmanager;

/// <summary>Kontaktlogik ohne WinForms-Abhängigkeit.</summary>
public class ContactManager
{
  private readonly List<PersonKontakt> _kontakte = new();

  public bool Add(PersonKontakt kontakt)
  {
    if (_kontakte.Contains(kontakt))
    {
      return false;
    }

    _kontakte.Add(kontakt);
    return true;
  }

  public bool RemoveAt(int index)
  {
    if (index < 0 || index >= _kontakte.Count)
    {
      return false;
    }

    _kontakte.RemoveAt(index);
    return true;
  }

  public List<PersonKontakt> GetAll()
  {
    return new List<PersonKontakt>(_kontakte);
  }
}
