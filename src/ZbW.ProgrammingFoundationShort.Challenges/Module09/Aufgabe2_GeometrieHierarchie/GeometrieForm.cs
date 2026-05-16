namespace ZbW.ProgrammingFoundationShort.Challenges.Module09.Aufgabe2_GeometrieHierarchie;

public sealed class GeometrieForm : Form
{
  private readonly ListBox lstShapes;
  private readonly Label lblTotal;

  public GeometrieForm()
  {
    Text = "Geometrie-Hierarchie – Aufgabe 2";
    ClientSize = new Size(520, 300);

    Button cmdCalculate = new Button { Location = new Point(12, 12), Size = new Size(120, 28), Text = "Berechnen" };
    lstShapes = new ListBox { Location = new Point(12, 55), Size = new Size(490, 190) };
    lblTotal = new Label { Location = new Point(12, 255), Size = new Size(490, 30) };

    cmdCalculate.Click += CmdCalculate_Click;

    Controls.Add(cmdCalculate);
    Controls.Add(lstShapes);
    Controls.Add(lblTotal);
  }

  private void CmdCalculate_Click(object sender, EventArgs e)
  {
    List<Shape> shapes = new List<Shape>
    {
      new Circle { Color = "Rot", Radius = 5 },
      new Rectangle { Color = "Blau", Width = 4, Height = 3 },
      new Triangle { Color = "Grün", A = 3, B = 4, C = 5 }
    };

    lstShapes.Items.Clear();
    double total = 0;

    foreach (Shape shape in shapes)
    {
      total += shape.Area();
      lstShapes.Items.Add(shape.ToString());
    }

    lblTotal.Text = $"Gesamtfläche: {total:F2}";
  }
}

public abstract class Shape
{
  public string Color { get; set; } = "";
  public abstract double Area();
  public abstract double Perimeter();

  public override string ToString()
  {
    return $"{GetType().Name}, {Color}, Fläche: {Area():F2}, Umfang: {Perimeter():F2}";
  }
}

public sealed class Circle : Shape
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

public sealed class Rectangle : Shape
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

public sealed class Triangle : Shape
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
