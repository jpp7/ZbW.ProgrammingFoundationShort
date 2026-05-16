namespace ZbW.ProgrammingFoundationShort.Challenges.Module06.Aufgabe4_Bibliothekssystem;

/// <summary>
///   Aufgabe 4 – Bibliothekssystem (⭐⭐⭐ Schwer)
/// </summary>
public partial class BibliothekForm : Form
{
  private readonly Library _library = new();

  public BibliothekForm()
  {
    InitializeComponent();

    // Demo-Bücher vorab laden
    _library.AddBook(new Book { Title = "Clean Code", Author = "Robert C. Martin", ISBN = "978-0132350884" });
    _library.AddBook(new Book { Title = "The Pragmatic Programmer", Author = "David Thomas", ISBN = "978-0201616224" });
    _library.AddBook(new Book { Title = "Design Patterns", Author = "Gang of Four", ISBN = "978-0201633610" });

    AktualisiereListe();
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    var book = new Book
    {
      Title = TxtTitle.Text.Trim(),
      Author = TxtAuthor.Text.Trim(),
      ISBN = TxtISBN.Text.Trim()
    };

    if (string.IsNullOrEmpty(book.Title) || string.IsNullOrEmpty(book.Author))
    {
      MessageBox.Show("Bitte Titel und Autor eingeben.",
        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    _library.AddBook(book);
    AktualisiereListe();
    TxtTitle.Clear(); TxtAuthor.Clear(); TxtISBN.Clear();
  }

  private void CmdLeihen_Click(object sender, EventArgs e)
  {
    string isbn = TxtISBN.Text.Trim();
    bool erfolg = _library.BorrowBook(isbn);
    LblStatus.Text = erfolg
      ? $"Buch {isbn} ausgeliehen."
      : $"Buch {isbn} nicht verfügbar oder nicht gefunden.";
    AktualisiereListe();
  }

  private void CmdZurueckgeben_Click(object sender, EventArgs e)
  {
    string isbn = TxtISBN.Text.Trim();
    bool erfolg = _library.ReturnBook(isbn);
    LblStatus.Text = erfolg
      ? $"Buch {isbn} zurückgegeben."
      : $"Buch {isbn} war nicht ausgeliehen oder nicht gefunden.";
    AktualisiereListe();
  }

  private void CmdSuchen_Click(object sender, EventArgs e)
  {
    var result = _library.SearchByAuthor(TxtAuthor.Text.Trim());
    LstBuecher.Items.Clear();
    foreach (var book in result)
      LstBuecher.Items.Add(book.ToString());
    LblStatus.Text = $"{result.Count} Treffer für Autor \"{TxtAuthor.Text.Trim()}\"";
  }

  private void AktualisiereListe()
  {
    LstBuecher.Items.Clear();
    foreach (var book in _library.GetAll())
      LstBuecher.Items.Add(book.ToString());
    LblStatus.Text = $"Bücher: {_library.GetAll().Count} gesamt, {_library.AvailableCount} verfügbar";
  }
}
