namespace ZbW.ProgrammingFoundationShort.Challenges.Module09.Aufgabe2_GeometrieHierarchie;

public sealed class GeometrieForm : Form
{
  private readonly RadioButton rdoCircle;
  private readonly RadioButton rdoRectangle;
  private readonly RadioButton rdoTriangle;
  private readonly TextBox txtColor;
  private readonly TextBox txtA;
  private readonly TextBox txtB;
  private readonly TextBox txtC;
  private readonly List<Shape> shapes = new List<Shape>();
  private readonly ListBox lstShapes;
  private readonly Label lblTotal;

  public GeometrieForm()
  {
    Text = "Geometrie-Hierarchie – Aufgabe 2";
    ClientSize = new Size(620, 360);

    rdoCircle = new RadioButton { Location = new Point(120, 12), Size = new Size(70, 24), Text = "Kreis", Checked = true };
    rdoRectangle = new RadioButton { Location = new Point(195, 12), Size = new Size(90, 24), Text = "Rechteck" };
    rdoTriangle = new RadioButton { Location = new Point(290, 12), Size = new Size(90, 24), Text = "Dreieck" };
    txtColor = new TextBox { Location = new Point(120, 45), Size = new Size(120, 23), Text = "Rot" };
    txtA = new TextBox { Location = new Point(120, 78), Size = new Size(80, 23), Text = "5" };
    txtB = new TextBox { Location = new Point(120, 111), Size = new Size(80, 23), Text = "4" };
    txtC = new TextBox { Location = new Point(120, 144), Size = new Size(80, 23), Text = "3" };
    Button cmdCalculate = new Button { Location = new Point(120, 180), Size = new Size(120, 28), Text = "Hinzufügen" };
    lstShapes = new ListBox { Location = new Point(300, 45), Size = new Size(300, 240) };
    lblTotal = new Label { Location = new Point(300, 300), Size = new Size(300, 30) };

    cmdCalculate.Click += CmdCalculate_Click;

    Controls.Add(new Label { Location = new Point(12, 15), Size = new Size(100, 20), Text = "Form:" });
    Controls.Add(new Label { Location = new Point(12, 48), Size = new Size(100, 20), Text = "Farbe:" });
    Controls.Add(new Label { Location = new Point(12, 81), Size = new Size(100, 20), Text = "Radius / A:" });
    Controls.Add(new Label { Location = new Point(12, 114), Size = new Size(100, 20), Text = "Breite / B:" });
    Controls.Add(new Label { Location = new Point(12, 147), Size = new Size(100, 20), Text = "Höhe / C:" });
    Controls.Add(rdoCircle);
    Controls.Add(rdoRectangle);
    Controls.Add(rdoTriangle);
    Controls.Add(txtColor);
    Controls.Add(txtA);
    Controls.Add(txtB);
    Controls.Add(txtC);
    Controls.Add(cmdCalculate);
    Controls.Add(lstShapes);
    Controls.Add(lblTotal);
  }

  private void CmdCalculate_Click(object sender, EventArgs e)
  {
    if (!double.TryParse(txtA.Text, out double a) || !double.TryParse(txtB.Text, out double b) || !double.TryParse(txtC.Text, out double c))
    {
      lblTotal.Text = "Bitte gültige Zahlen eingeben.";
      return;
    }

    Shape shape;

    if (rdoCircle.Checked)
      shape = new Circle { Color = txtColor.Text, Radius = a };
    else if (rdoRectangle.Checked)
      shape = new Rectangle { Color = txtColor.Text, Width = a, Height = b };
    else
      shape = new Triangle { Color = txtColor.Text, A = a, B = b, C = c };

    shapes.Add(shape);

    lstShapes.Items.Clear();
    double total = 0;

    foreach (Shape existingShape in shapes)
    {
      total += existingShape.Area();
      lstShapes.Items.Add(existingShape.ToString());
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
