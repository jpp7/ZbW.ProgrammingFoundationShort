namespace ZbW.ProgrammingFoundationShort.Lessons.Module09.Auftrag3_MediaHierarchy;

public abstract class MediaItem
{
  public string Title { get; set; } = "";

  public abstract void PrintInfo();
}

public sealed class Book : MediaItem
{
  public string Author { get; set; } = "";

  public override void PrintInfo()
  {
    // TODO: Buchinformationen mit Console.WriteLine ausgeben.
  }
}

public sealed class Magazine : MediaItem
{
  public int IssueNumber { get; set; }

  public override void PrintInfo()
  {
    // TODO: Magazin-Informationen ausgeben.
  }
}

public sealed class DVD : MediaItem
{
  public int LengthMinutes { get; set; }

  public override void PrintInfo()
  {
    // TODO: DVD-Informationen ausgeben.
  }
}

public static class MediaDemo
{
  public static void Start()
  {
    // TODO 1: List<MediaItem> mit je 2 Book, Magazine und DVD erstellen.
    // TODO 2: PrintAll(media) aufrufen.
  }

  public static void PrintAll(List<MediaItem> items)
  {
    // TODO: foreach über alle Elemente und PrintInfo() aufrufen.
  }
}