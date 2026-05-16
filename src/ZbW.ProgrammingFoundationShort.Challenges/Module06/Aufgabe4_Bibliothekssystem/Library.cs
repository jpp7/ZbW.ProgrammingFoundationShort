namespace ZbW.ProgrammingFoundationShort.Challenges.Module06.Aufgabe4_Bibliothekssystem;

/// <summary>Bibliothek mit Buchverwaltung.</summary>
public class Library
{
  private readonly List<Book> _books = new();

  public int AvailableCount => _books.Count(b => b.IsAvailable);

  public void AddBook(Book book) => _books.Add(book);

  public bool BorrowBook(string isbn)
  {
    var book = _books.Find(b => b.ISBN == isbn);
    if (book == null || !book.IsAvailable) return false;
    book.IsAvailable = false;
    return true;
  }

  public bool ReturnBook(string isbn)
  {
    var book = _books.Find(b => b.ISBN == isbn);
    if (book == null || book.IsAvailable) return false;
    book.IsAvailable = true;
    return true;
  }

  public List<Book> SearchByAuthor(string author)
  {
    return _books.FindAll(b => b.Author.Contains(author, StringComparison.OrdinalIgnoreCase));
  }

  public List<Book> GetAll() => new(_books);
}
