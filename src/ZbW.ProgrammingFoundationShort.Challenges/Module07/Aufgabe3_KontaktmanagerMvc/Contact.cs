namespace ZbW.ProgrammingFoundationShort.Challenges.Module07.Aufgabe3_KontaktmanagerMvc;

/// <summary>Kontakt mit allen Feldern und optionalem Geburtstag.</summary>
public class Contact
{
  public string FirstName { get; set; } = "";
  public string LastName { get; set; } = "";
  public string Phone { get; set; } = "";
  public string Email { get; set; } = "";
  public DateTime? Birthday { get; set; }

  public override string ToString()
  {
    string bday = Birthday.HasValue ? $" | Geb: {Birthday:dd.MM.yyyy}" : "";
    return $"{FirstName} {LastName} | {Phone} | {Email}{bday}";
  }
}
