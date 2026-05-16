namespace ZbW.ProgrammingFoundationShort.Lessons.Module09.Auftrag3_PrintableInterface;

public interface IPrintable
{
  void PrintInfo();
}

public sealed class Book : IPrintable
{
  public string Title { get; set; } = "";
  public string Author { get; set; } = "";

  public void PrintInfo()
  {
    // TODO: Buchinformationen mit Console.WriteLine ausgeben.
  }
}

public sealed class Magazine : IPrintable
{
  public string Title { get; set; } = "";
  public int IssueNumber { get; set; }

  public void PrintInfo()
  {
    // TODO: Magazin-Informationen ausgeben.
  }
}

public sealed class DVD : IPrintable
{
  public string Title { get; set; } = "";
  public int LengthMinutes { get; set; }

  public void PrintInfo()
  {
    // TODO: DVD-Informationen ausgeben.
  }
}

public static class PrintableDemo
{
  public static void PrintAll(List<IPrintable> items)
  {
    // TODO: foreach über alle Elemente und PrintInfo() aufrufen.
  }
}
