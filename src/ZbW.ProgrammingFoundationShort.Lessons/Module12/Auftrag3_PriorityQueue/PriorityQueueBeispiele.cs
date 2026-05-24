namespace ZbW.ProgrammingFoundationShort.Lessons.Module12.Auftrag3_PriorityQueue;

public sealed record PatientCase(string Name, int Priority);

public static class PriorityQueueBeispiele
{
  public static List<string> BuildTreatmentOrder(IEnumerable<PatientCase> cases)
  {
    // TODO: Faelle in eine PriorityQueue einfuegen.
    // TODO: Kleinere Priority-Zahl bedeutet wichtiger.
    // TODO: Namen in Behandlungsreihenfolge zurueckgeben.
    return new List<string>();
  }
}