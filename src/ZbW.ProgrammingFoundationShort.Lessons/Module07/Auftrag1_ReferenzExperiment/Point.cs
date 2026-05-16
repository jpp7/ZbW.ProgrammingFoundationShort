namespace ZbW.ProgrammingFoundationShort.Lessons.Module07.Auftrag1_ReferenzExperiment;

/// <summary>Einfache Point-Klasse (Referenztyp) für das Experiment.</summary>
public class Point
{
  public int X { get; set; }
  public int Y { get; set; }

  public Point(int x, int y) { X = x; Y = y; }

  public override string ToString() => $"Point({X}, {Y})";
}
