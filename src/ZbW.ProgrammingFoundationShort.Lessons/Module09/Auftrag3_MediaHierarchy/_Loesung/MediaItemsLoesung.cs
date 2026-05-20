namespace ZbW.ProgrammingFoundationShort.Lessons.Module09.Auftrag3_MediaHierarchy._Loesung;

public abstract class MediaItemLoesung
{
  public string Title { get; set; } = "";

  public abstract void PrintInfo();
}

public sealed class BookLoesung : MediaItemLoesung
{
  public string Author { get; set; } = "";

  public override void PrintInfo()
  {
    Console.WriteLine($"Buch: {Title} von {Author}");
  }
}

public sealed class MagazineLoesung : MediaItemLoesung
{
  public int IssueNumber { get; set; }

  public override void PrintInfo()
  {
    Console.WriteLine($"Magazin: {Title}, Ausgabe {IssueNumber}");
  }
}

public sealed class DVDLoesung : MediaItemLoesung
{
  public int LengthMinutes { get; set; }

  public override void PrintInfo()
  {
    Console.WriteLine($"DVD: {Title}, {LengthMinutes} Minuten");
  }
}

public static class MediaDemoLoesung
{
  public static void Start()
  {
    var media = new List<MediaItemLoesung>
    {
      new BookLoesung { Title = "Clean Code", Author = "Robert C. Martin" },
      new BookLoesung { Title = "The Pragmatic Programmer", Author = "Andrew Hunt" },
      new MagazineLoesung { Title = "c't", IssueNumber = 12 },
      new MagazineLoesung { Title = "dotnetpro", IssueNumber = 5 },
      new DVDLoesung { Title = "Inception", LengthMinutes = 148 },
      new DVDLoesung { Title = "The Matrix", LengthMinutes = 136 }
    };

    PrintAll(media);
  }

  public static void PrintAll(List<MediaItemLoesung> items)
  {
    foreach (MediaItemLoesung item in items)
      item.PrintInfo();
  }
}