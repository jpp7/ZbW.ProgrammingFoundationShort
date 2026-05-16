namespace ZbW.ProgrammingFoundationShort.Challenges.Module07.Aufgabe3_KontaktmanagerMvc;

/// <summary>Controller für die Kontaktverwaltung (MVC-Muster).</summary>
public class ContactController
{
  private readonly List<Contact> _contacts = new();

  public void Add(Contact contact) => _contacts.Add(contact);

  public bool Remove(Contact contact) => _contacts.Remove(contact);

  public List<Contact> Search(string query)
  {
    return _contacts.FindAll(c =>
      c.FirstName.Contains(query, StringComparison.OrdinalIgnoreCase) ||
      c.LastName.Contains(query, StringComparison.OrdinalIgnoreCase) ||
      c.Email.Contains(query, StringComparison.OrdinalIgnoreCase));
  }

  public List<Contact> GetAll() => new(_contacts);
}
