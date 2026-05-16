namespace ZbW.ProgrammingFoundationShort.Challenges.Module08.Aufgabe1_MathBibliothek;

public sealed class MathBibliothekForm : Form
{
  private readonly TextBox txtNumber;
  private readonly RadioButton rdoPrime;
  private readonly RadioButton rdoFactorial;
  private readonly RadioButton rdoSquare;
  private readonly Label lblResult;

  public MathBibliothekForm()
  {
    Text = "Math-Bibliothek – Aufgabe 1";
    ClientSize = new Size(360, 190);

    txtNumber = new TextBox { Location = new Point(12, 12), Size = new Size(100, 23), Text = "7" };
    rdoPrime = new RadioButton { Location = new Point(12, 50), Size = new Size(120, 24), Text = "Primzahl", Checked = true };
    rdoFactorial = new RadioButton { Location = new Point(12, 75), Size = new Size(120, 24), Text = "Fakultät" };
    rdoSquare = new RadioButton { Location = new Point(12, 100), Size = new Size(120, 24), Text = "Quadrat" };
    Button cmdCalculate = new Button { Location = new Point(130, 10), Size = new Size(100, 28), Text = "Berechnen" };
    lblResult = new Label { Location = new Point(12, 135), Size = new Size(330, 40) };

    cmdCalculate.Click += CmdCalculate_Click;

    Controls.Add(txtNumber);
    Controls.Add(rdoPrime);
    Controls.Add(rdoFactorial);
    Controls.Add(rdoSquare);
    Controls.Add(cmdCalculate);
    Controls.Add(lblResult);
  }

  private void CmdCalculate_Click(object sender, EventArgs e)
  {
    if (!int.TryParse(txtNumber.Text, out int number))
    {
      lblResult.Text = "Bitte eine ganze Zahl eingeben.";
      return;
    }

    if (rdoPrime.Checked)
      lblResult.Text = MathTools.IsPrime(number) ? $"{number} ist prim." : $"{number} ist nicht prim.";
    else if (rdoFactorial.Checked)
      lblResult.Text = $"{number}! = {MathTools.Factorial(number)}";
    else
      lblResult.Text = $"{number}² = {MathTools.Square(number)}";
  }
}

public static class MathTools
{
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

  public static long Factorial(int number)
  {
    if (number < 0)
      throw new ArgumentOutOfRangeException(nameof(number));

    long result = 1;

    for (int value = 2; value <= number; value++)
      result *= value;

    return result;
  }

  public static int Square(int number)
  {
    return number * number;
  }
}
