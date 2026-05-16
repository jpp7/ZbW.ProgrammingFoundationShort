namespace ZbW.ProgrammingFoundationShort.Challenges.Module07.Aufgabe3_KontaktmanagerMvc;

/// <summary>Kontaktlogik ohne WinForms-Abhängigkeit.</summary>
public class ContactManager
{
  private readonly List<Contact> _contacts = new();

  public bool Add(Contact contact)
  {
    if (_contacts.Contains(contact))
    {
      return false;
    }

    _contacts.Add(contact);
    return true;
  }

  public bool Remove(string phone)
  {
    Contact? contact = _contacts.Find(c => c.Phone.Equals(phone, StringComparison.OrdinalIgnoreCase));
    return contact is not null && _contacts.Remove(contact);
  }

  public List<Contact> Search(string query)
  {
    return _contacts.FindAll(c =>
      c.FirstName.Contains(query, StringComparison.OrdinalIgnoreCase) ||
      c.LastName.Contains(query, StringComparison.OrdinalIgnoreCase) ||
      c.Email.Contains(query, StringComparison.OrdinalIgnoreCase));
  }

  public List<Contact> GetAll() => new(_contacts);
}
