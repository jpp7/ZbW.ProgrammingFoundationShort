namespace ZbW.ProgrammingFoundationShort.Lessons.Module12.Auftrag1_StackQueue._Loesung;

public static class StackQueueBeispieleLoesung
{
  public static Stack<string> CreateUndoStack()
  {
    var undo = new Stack<string>();
    undo.Push("Text geschrieben");
    undo.Push("Titel formatiert");
    undo.Push("Bild eingefuegt");
    return undo;
  }

  public static List<string> ProcessTickets(string[] tickets)
  {
    var queue = new Queue<string>(tickets);
    var processed = new List<string>();

    while (queue.Count > 0)
    {
      processed.Add(queue.Dequeue());
    }

    return processed;
  }

  public static string RunDemo()
  {
    var undo = CreateUndoStack();
    var tickets = ProcessTickets(new[] { "T-100", "T-101", "T-102" });

    return $"Undo zuerst: {undo.Peek()}{Environment.NewLine}Tickets: {string.Join(", ", tickets)}";
  }
}