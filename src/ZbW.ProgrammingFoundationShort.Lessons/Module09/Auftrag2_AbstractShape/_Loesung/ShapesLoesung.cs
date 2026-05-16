using System.Text;

namespace ZbW.ProgrammingFoundationShort.Lessons.Module09.Auftrag2_AbstractShape._Loesung;

public abstract class ShapeLoesung
{
  public string Color { get; set; } = "";

  public abstract double Area();

  public abstract double Perimeter();

  public virtual string Describe()
  {
    return $"{GetType().Name}, Farbe: {Color}, Fläche: {Area():F2}, Umfang: {Perimeter():F2}";
  }
}

public sealed class CircleLoesung : ShapeLoesung
{
  public double Radius { get; set; }

  public override double Area()
  {
    return Math.PI * Radius * Radius;
  }

  public override double Perimeter()
  {
    return 2 * Math.PI * Radius;
  }
}

public sealed class RectangleLoesung : ShapeLoesung
{
  public double Width { get; set; }
  public double Height { get; set; }

  public override double Area()
  {
    return Width * Height;
  }

  public override double Perimeter()
  {
    return 2 * (Width + Height);
  }
}

public sealed class TriangleLoesung : ShapeLoesung
{
  public double A { get; set; }
  public double B { get; set; }
  public double C { get; set; }

  public override double Area()
  {
    double s = Perimeter() / 2;
    return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
  }

  public override double Perimeter()
  {
    return A + B + C;
  }
}

public static class ShapeDemoLoesung
{
  public static string RunDemo()
  {
    List<ShapeLoesung> shapes = new List<ShapeLoesung>
    {
      new CircleLoesung { Color = "Rot", Radius = 5 },
      new CircleLoesung { Color = "Blau", Radius = 2 },
      new RectangleLoesung { Color = "Grün", Width = 4, Height = 3 },
      new RectangleLoesung { Color = "Gelb", Width = 8, Height = 2 },
      new TriangleLoesung { Color = "Orange", A = 3, B = 4, C = 5 },
      new TriangleLoesung { Color = "Violett", A = 5, B = 5, C = 6 }
    };

    StringBuilder builder = new StringBuilder();
    double totalArea = 0;

    foreach (ShapeLoesung shape in shapes)
    {
      builder.AppendLine(shape.Describe());
      totalArea += shape.Area();
    }

    builder.AppendLine($"Gesamtfläche: {totalArea:F2}");
    return builder.ToString();
  }
}
