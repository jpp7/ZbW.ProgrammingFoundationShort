namespace ZbW.ProgrammingFoundationShort.Challenges.Module08.Aufgabe3_ValidierungsFramework;

public sealed class ValidierungsForm : Form
{
  private readonly TextBox txtEmail;
  private readonly TextBox txtAge;
  private readonly TextBox txtName;
  private readonly TextBox txtPhone;
  private readonly Label lblResult;

  public ValidierungsForm()
  {
    Text = "Validierungs-Framework – Aufgabe 3";
    ClientSize = new Size(500, 270);

    Label lblName = new Label { Location = new Point(12, 15), Size = new Size(100, 20), Text = "Name:" };
    Label lblEmail = new Label { Location = new Point(12, 50), Size = new Size(100, 20), Text = "E-Mail:" };
    Label lblAge = new Label { Location = new Point(12, 85), Size = new Size(100, 20), Text = "Alter:" };
    Label lblPhone = new Label { Location = new Point(12, 120), Size = new Size(100, 20), Text = "Telefon:" };
    txtName = new TextBox { Location = new Point(120, 12), Size = new Size(240, 23), Text = "Anna" };
    txtEmail = new TextBox { Location = new Point(120, 47), Size = new Size(240, 23), Text = "test@zbw.ch" };
    txtAge = new TextBox { Location = new Point(120, 82), Size = new Size(80, 23), Text = "18" };
    txtPhone = new TextBox { Location = new Point(120, 117), Size = new Size(160, 23), Text = "+41791234567" };
    Button cmdValidate = new Button { Location = new Point(120, 155), Size = new Size(110, 28), Text = "Prüfen" };
    lblResult = new Label { Location = new Point(12, 195), Size = new Size(460, 60) };

    cmdValidate.Click += CmdValidate_Click;

    Controls.Add(lblName);
    Controls.Add(lblEmail);
    Controls.Add(lblAge);
    Controls.Add(lblPhone);
    Controls.Add(txtName);
    Controls.Add(txtEmail);
    Controls.Add(txtAge);
    Controls.Add(txtPhone);
    Controls.Add(cmdValidate);
    Controls.Add(lblResult);
  }

  private void CmdValidate_Click(object sender, EventArgs e)
  {
    List<string> errors = new List<string>();
    ResetColors();

    if (!Validator.IsNotEmpty(txtName.Text))
    {
      MarkInvalid(txtName);
      errors.Add("Name darf nicht leer sein.");
    }

    if (!Validator.IsValidEmail(txtEmail.Text))
    {
      MarkInvalid(txtEmail);
      errors.Add("E-Mail ist ungültig.");
    }

    if (!int.TryParse(txtAge.Text, out int age) || !Validator.IsInRange(age, 16, 120))
    {
      MarkInvalid(txtAge);
      errors.Add("Alter muss zwischen 16 und 120 liegen.");
    }

    if (!Validator.IsValidSwissPhone(txtPhone.Text))
    {
      MarkInvalid(txtPhone);
      errors.Add("Telefonnummer ist ungültig.");
    }

    lblResult.Text = errors.Count == 0 ? "Alle Eingaben sind gültig." : string.Join(Environment.NewLine, errors);
  }

  private void ResetColors()
  {
    txtName.BackColor = SystemColors.Window;
    txtEmail.BackColor = SystemColors.Window;
    txtAge.BackColor = SystemColors.Window;
    txtPhone.BackColor = SystemColors.Window;
  }

  private void MarkInvalid(TextBox textBox)
  {
    textBox.BackColor = Color.LightCoral;
  }
}

public static class Validator
{
  public static bool IsNotEmpty(string value)
  {
    return !string.IsNullOrWhiteSpace(value);
  }

  public static bool IsValidEmail(string email)
  {
    if (string.IsNullOrWhiteSpace(email))
      return false;

    int atIndex = email.IndexOf('@');
    int dotIndex = email.IndexOf('.', atIndex + 1);
    return atIndex > 0 && dotIndex > atIndex + 1 && dotIndex < email.Length - 1;
  }

  public static bool IsInRange(int value, int min, int max)
  {
    return value >= min && value <= max;
  }

  public static bool IsPositive(double value)
  {
    return value > 0;
  }

  public static bool IsValidSwissPhone(string phone)
  {
    if (string.IsNullOrWhiteSpace(phone))
      return false;

    string digits = new string(phone.Where(char.IsDigit).ToArray());
    bool validPrefix = phone.StartsWith("+41", StringComparison.Ordinal) || phone.StartsWith("0", StringComparison.Ordinal);
    return validPrefix && digits.Length >= 10 && digits.Length <= 12;
  }

  public static string Validate(string value, params Func<string, bool>[] checks)
  {
    foreach (Func<string, bool> check in checks)
    {
      if (!check(value))
        return "Wert ist ungültig.";
    }

    return "";
  }
}
