namespace ZbW.ProgrammingFoundationShort.Challenges.Module08.Aufgabe3_ValidierungsFramework;

public sealed class ValidierungsForm : Form
{
  private readonly TextBox txtEmail;
  private readonly TextBox txtPassword;
  private readonly TextBox txtAge;
  private readonly Label lblResult;

  public ValidierungsForm()
  {
    Text = "Validierungs-Framework – Aufgabe 3";
    ClientSize = new Size(460, 230);

    Label lblEmail = new Label { Location = new Point(12, 15), Size = new Size(100, 20), Text = "E-Mail:" };
    Label lblPassword = new Label { Location = new Point(12, 50), Size = new Size(100, 20), Text = "Passwort:" };
    Label lblAge = new Label { Location = new Point(12, 85), Size = new Size(100, 20), Text = "Alter:" };
    txtEmail = new TextBox { Location = new Point(120, 12), Size = new Size(240, 23), Text = "test@zbw.ch" };
    txtPassword = new TextBox { Location = new Point(120, 47), Size = new Size(240, 23), Text = "Passwort1" };
    txtAge = new TextBox { Location = new Point(120, 82), Size = new Size(80, 23), Text = "18" };
    Button cmdValidate = new Button { Location = new Point(120, 120), Size = new Size(110, 28), Text = "Prüfen" };
    lblResult = new Label { Location = new Point(12, 160), Size = new Size(430, 60) };

    cmdValidate.Click += CmdValidate_Click;

    Controls.Add(lblEmail);
    Controls.Add(lblPassword);
    Controls.Add(lblAge);
    Controls.Add(txtEmail);
    Controls.Add(txtPassword);
    Controls.Add(txtAge);
    Controls.Add(cmdValidate);
    Controls.Add(lblResult);
  }

  private void CmdValidate_Click(object sender, EventArgs e)
  {
    List<string> errors = new List<string>();

    if (!Validator.IsEmail(txtEmail.Text))
      errors.Add("E-Mail ist ungültig.");

    if (!Validator.HasMinLength(txtPassword.Text, 8) || !Validator.ContainsDigit(txtPassword.Text))
      errors.Add("Passwort braucht mindestens 8 Zeichen und eine Zahl.");

    if (!int.TryParse(txtAge.Text, out int age) || !Validator.IsBetween(age, 16, 120))
      errors.Add("Alter muss zwischen 16 und 120 liegen.");

    lblResult.Text = errors.Count == 0 ? "Alle Eingaben sind gültig." : string.Join(Environment.NewLine, errors);
  }
}

public static class Validator
{
  public static bool IsEmail(string value)
  {
    return !string.IsNullOrWhiteSpace(value) && value.Contains('@') && value.Contains('.');
  }

  public static bool HasMinLength(string value, int minLength)
  {
    return value != null && value.Length >= minLength;
  }

  public static bool ContainsDigit(string value)
  {
    return value != null && value.Any(char.IsDigit);
  }

  public static bool IsBetween(int value, int min, int max)
  {
    return value >= min && value <= max;
  }
}
