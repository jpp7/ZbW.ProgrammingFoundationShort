namespace ZbW.ProgrammingFoundationShort.Lessons.Module09.Auftrag2_AbstractShape;

public abstract class Shape
{
  public string Color { get; set; } = "";

  public abstract double Area();

  public abstract double Perimeter();

  public virtual string Describe()
  {
    // TODO: Farbe, Fläche und Umfang ausgeben.
    return "";
  }
}

public sealed class Circle : Shape
{
  public double Radius { get; set; }

  public override double Area()
  {
    // TODO: Kreisfläche berechnen.
    return 0;
  }

  public override double Perimeter()
  {
    // TODO: Kreisumfang berechnen.
    return 0;
  }
}

public sealed class Rectangle : Shape
{
  public double Width { get; set; }
  public double Height { get; set; }

  public override double Area()
  {
    // TODO: Rechteckfläche berechnen.
    return 0;
  }

  public override double Perimeter()
  {
    // TODO: Rechteckumfang berechnen.
    return 0;
  }
}

public sealed class Triangle : Shape
{
  public double A { get; set; }
  public double B { get; set; }
  public double C { get; set; }

  public override double Area()
  {
    // TODO: Heron-Formel verwenden.
    return 0;
  }

  public override double Perimeter()
  {
    // TODO: Umfang berechnen.
    return 0;
  }
}
