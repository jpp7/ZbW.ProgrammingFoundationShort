namespace ZbW.ProgrammingFoundationShort.Lessons.Module10.Auftrag3_DatenstrukturWahl._Loesung;

public static class DatenstrukturWahlLoesung
{
  public static List<string> CreateTodoList()
  {
    return new List<string>
    {
      "Ablauf planen",
      "TODOs schreiben",
      "Code testen"
    };
  }

  public static Dictionary<string, string> CreatePhoneBook()
  {
    return new Dictionary<string, string>
    {
      ["Ana"] = "079 111 22 33",
      ["Ben"] = "079 444 55 66"
    };
  }

  public static Stack<string> CreateBackHistory()
  {
    Stack<string> history = new Stack<string>();
    history.Push("start.ch");
    history.Push("lernen.zbw.ch");
    history.Push("github.com");
    return history;
  }

  public static string RunDemo()
  {
    List<string> todos = CreateTodoList();
    Dictionary<string, string> phoneBook = CreatePhoneBook();
    Stack<string> history = CreateBackHistory();

    return $"Aufgaben: {string.Join(", ", todos)}{Environment.NewLine}" +
           $"Ana: {phoneBook["Ana"]}{Environment.NewLine}" +
           $"Zurück zu: {history.Pop()}";
  }
}