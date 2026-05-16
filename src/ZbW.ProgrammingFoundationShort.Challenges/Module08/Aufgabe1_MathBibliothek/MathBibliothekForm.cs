namespace ZbW.ProgrammingFoundationShort.Challenges.Module08.Aufgabe1_MathBibliothek;

public sealed class MathBibliothekForm : Form
{
  private readonly TextBox txtNumber;
  private readonly TextBox txtSecondNumber;
  private readonly RadioButton rdoCircleArea;
  private readonly RadioButton rdoCircleCircumference;
  private readonly RadioButton rdoRectangleArea;
  private readonly RadioButton rdoPrime;
  private readonly RadioButton rdoFactorial;
  private readonly Label lblResult;

  public MathBibliothekForm()
  {
    Text = "Math-Bibliothek – Aufgabe 1";
    ClientSize = new Size(420, 260);

    txtNumber = new TextBox { Location = new Point(120, 12), Size = new Size(100, 23), Text = "5" };
    txtSecondNumber = new TextBox { Location = new Point(120, 45), Size = new Size(100, 23), Text = "3" };
    rdoCircleArea = new RadioButton { Location = new Point(12, 85), Size = new Size(150, 24), Text = "Kreisfläche", Checked = true };
    rdoCircleCircumference = new RadioButton { Location = new Point(12, 110), Size = new Size(150, 24), Text = "Kreisumfang" };
    rdoRectangleArea = new RadioButton { Location = new Point(12, 135), Size = new Size(150, 24), Text = "Rechteckfläche" };
    rdoPrime = new RadioButton { Location = new Point(190, 85), Size = new Size(120, 24), Text = "Primzahl" };
    rdoFactorial = new RadioButton { Location = new Point(190, 110), Size = new Size(120, 24), Text = "Fakultät" };
    Button cmdCalculate = new Button { Location = new Point(240, 10), Size = new Size(100, 28), Text = "Berechnen" };
    lblResult = new Label { Location = new Point(12, 180), Size = new Size(390, 60) };

    cmdCalculate.Click += CmdCalculate_Click;

    Controls.Add(new Label { Location = new Point(12, 15), Size = new Size(100, 20), Text = "Wert 1:" });
    Controls.Add(new Label { Location = new Point(12, 48), Size = new Size(100, 20), Text = "Wert 2:" });
    Controls.Add(txtNumber);
    Controls.Add(txtSecondNumber);
    Controls.Add(rdoCircleArea);
    Controls.Add(rdoCircleCircumference);
    Controls.Add(rdoRectangleArea);
    Controls.Add(rdoPrime);
    Controls.Add(rdoFactorial);
    Controls.Add(cmdCalculate);
    Controls.Add(lblResult);
  }

  private void CmdCalculate_Click(object sender, EventArgs e)
  {
    if (!double.TryParse(txtNumber.Text, out double firstValue))
    {
      lblResult.Text = "Bitte Wert 1 als Zahl eingeben.";
      return;
    }

    if (rdoCircleArea.Checked)
      lblResult.Text = $"Kreisfläche: {MathHelper.CircleArea(firstValue):F2}";
    else if (rdoCircleCircumference.Checked)
      lblResult.Text = $"Kreisumfang: {MathHelper.CircleCircumference(firstValue):F2}";
    else if (rdoRectangleArea.Checked)
    {
      if (!double.TryParse(txtSecondNumber.Text, out double secondValue))
      {
        lblResult.Text = "Bitte Wert 2 als Zahl eingeben.";
        return;
      }

      lblResult.Text = $"Rechteckfläche: {MathHelper.RectangleArea(firstValue, secondValue):F2}";
    }
    else if (rdoPrime.Checked)
    {
      int number = (int)firstValue;
      lblResult.Text = MathHelper.IsPrime(number) ? $"{number} ist prim." : $"{number} ist nicht prim.";
    }
    else if (rdoFactorial.Checked)
    {
      int number = (int)firstValue;
      lblResult.Text = $"{number}! = {MathHelper.Factorial(number)}";
    }
  }
}

public static class MathHelper
{
  public const double Pi = 3.14159265358979;

  public static double CircleArea(double radius)
  {
    return Pi * radius * radius;
  }

  public static double CircleCircumference(double radius)
  {
    return 2 * Pi * radius;
  }

  public static double RectangleArea(double width, double height)
  {
    return width * height;
  }

  public static bool IsPrime(int number)
  {
    if (number < 2)
      return false;

    for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
    {
      if (number % divisor == 0)
        return false;
    }

    return true;
  }

  public static int Factorial(int number)
  {
    if (number < 0)
      throw new ArgumentOutOfRangeException(nameof(number));

    int result = 1;

    for (int value = 2; value <= number; value++)
      result *= value;

    return result;
  }
}
