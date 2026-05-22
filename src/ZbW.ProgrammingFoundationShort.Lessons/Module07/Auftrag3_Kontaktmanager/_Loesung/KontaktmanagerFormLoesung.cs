namespace ZbW.ProgrammingFoundationShort.Lessons.Module07.Auftrag3_Kontaktmanager;

/// <summary>
///   Lösung: Kontaktmanager mit Datenklasse, ContactManager-Logik und schlanker Form.
/// </summary>
public partial class KontaktmanagerFormLoesung : Form
{
  private readonly ContactManager _contactManager = new();

  public KontaktmanagerFormLoesung()
  {
    InitializeComponent();
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    var kontakt = new PersonKontakt
    {
      FirstName = TxtFirstName.Text.Trim(),
      LastName = TxtLastName.Text.Trim(),
      Email = string.IsNullOrWhiteSpace(TxtEmail.Text) ? null : TxtEmail.Text.Trim()
    };

    if (string.IsNullOrEmpty(kontakt.FirstName) || string.IsNullOrEmpty(kontakt.LastName))
    {
      MessageBox.Show("Vor- und Nachname sind erforderlich.",
        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    if (!_contactManager.Add(kontakt))
    {
      MessageBox.Show($"{kontakt.FirstName} {kontakt.LastName} ist bereits vorhanden.",
        "Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Information);
      return;
    }

    AktualisiereListBox();
    TxtFirstName.Clear(); TxtLastName.Clear(); TxtEmail.Clear();
  }

  private void CmdEntfernen_Click(object sender, EventArgs e)
  {
    if (_contactManager.RemoveAt(LstKontakte.SelectedIndex))
    {
      AktualisiereListBox();
    }
  }

  private void AktualisiereListBox()
  {
    LstKontakte.Items.Clear();
    foreach (PersonKontakt kontakt in _contactManager.GetAll())
    {
      LstKontakte.Items.Add(kontakt.ToString());
    }
  }
}
