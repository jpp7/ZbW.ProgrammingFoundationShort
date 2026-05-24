namespace ZbW.ProgrammingFoundationShort.Lessons.Module12.Auftrag3_PriorityQueue._Loesung;

public sealed record PatientCase(string Name, int Priority);

public static class PriorityQueueBeispieleLoesung
{
  public static List<string> BuildTreatmentOrder(IEnumerable<PatientCase> cases)
  {
    var queue = new PriorityQueue<string, int>();

    foreach (PatientCase patientCase in cases)
    {
      queue.Enqueue(patientCase.Name, patientCase.Priority);
    }

    var treatmentOrder = new List<string>();

    while (queue.Count > 0)
    {
      treatmentOrder.Add(queue.Dequeue());
    }

    return treatmentOrder;
  }

  public static string RunDemo()
  {
    var cases = new[]
    {
      new PatientCase("Kopfschmerzen", 3),
      new PatientCase("Armbruch", 2),
      new PatientCase("Herzinfarkt", 1)
    };

    return string.Join(", ", BuildTreatmentOrder(cases));
  }
}