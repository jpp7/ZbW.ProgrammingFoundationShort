namespace ZbW.ProgrammingFoundationShort.Lessons.Module09.Auftrag3_PrintableInterface._Loesung;

public interface IPrintableLoesung
{
  void PrintInfo();
}

public sealed class BookLoesung : IPrintableLoesung
{
  public string Title { get; set; } = "";
  public string Author { get; set; } = "";

  public void PrintInfo()
  {
    Console.WriteLine($"Buch: {Title} von {Author}");
  }
}

public sealed class MagazineLoesung : IPrintableLoesung
{
  public string Title { get; set; } = "";
  public int IssueNumber { get; set; }

  public void PrintInfo()
  {
    Console.WriteLine($"Magazin: {Title}, Ausgabe {IssueNumber}");
  }
}

public sealed class DVDLoesung : IPrintableLoesung
{
  public string Title { get; set; } = "";
  public int LengthMinutes { get; set; }

  public void PrintInfo()
  {
    Console.WriteLine($"DVD: {Title}, {LengthMinutes} Minuten");
  }
}

public static class PrintableDemoLoesung
{
  public static void PrintAll(List<IPrintableLoesung> items)
  {
    foreach (IPrintableLoesung item in items)
      item.PrintInfo();
  }
}
