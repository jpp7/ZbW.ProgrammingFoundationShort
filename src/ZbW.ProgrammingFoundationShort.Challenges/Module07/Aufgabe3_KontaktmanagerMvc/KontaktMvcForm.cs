namespace ZbW.ProgrammingFoundationShort.Challenges.Module07.Aufgabe3_KontaktmanagerMvc;

/// <summary>
///   Aufgabe 3 – Kontaktmanager MVC (⭐⭐⭐ Schwer)
/// </summary>
public partial class KontaktMvcForm : Form
{
  private readonly ContactController _controller = new();

  public KontaktMvcForm()
  {
    InitializeComponent();
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    var contact = new Contact
    {
      FirstName = TxtFirst.Text.Trim(),
      LastName = TxtLast.Text.Trim(),
      Phone = TxtPhone.Text.Trim(),
      Email = TxtEmail.Text.Trim(),
      Birthday = DateTime.TryParse(TxtBirthday.Text, out DateTime bday) ? bday : null
    };

    if (string.IsNullOrEmpty(contact.FirstName) || string.IsNullOrEmpty(contact.LastName))
    {
      MessageBox.Show("Vor- und Nachname sind erforderlich.",
        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    _controller.Add(contact);
    AktualisiereAusgabe();
    TxtFirst.Clear(); TxtLast.Clear(); TxtPhone.Clear(); TxtEmail.Clear(); TxtBirthday.Clear();
  }

  private void CmdSuchen_Click(object sender, EventArgs e)
  {
    var result = _controller.Search(TxtSuche.Text.Trim());
    TxtAusgabe.Clear();
    foreach (var c in result)
      TxtAusgabe.AppendText(c + "\r\n");
  }

  private void CmdAlleAnzeigen_Click(object sender, EventArgs e)
  {
    AktualisiereAusgabe();
  }

  private void AktualisiereAusgabe()
  {
    TxtAusgabe.Clear();
    foreach (var c in _controller.GetAll())
      TxtAusgabe.AppendText(c + "\r\n");
  }
}
