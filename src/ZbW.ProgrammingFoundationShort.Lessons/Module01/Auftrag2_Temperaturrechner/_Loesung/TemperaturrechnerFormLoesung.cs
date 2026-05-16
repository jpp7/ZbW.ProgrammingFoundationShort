namespace ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag2_Temperaturrechner;

/// <summary>
/// Musterlösung: Auftrag 2 – Temperaturrechner
/// </summary>
public partial class TemperaturrechnerFormLoesung : Form
{
  private const double AbsoluteZero = -273.15;

  public TemperaturrechnerFormLoesung()
  {
    InitializeComponent();
  }

  private void CmdCelsiusToFahrenheit_Click(object sender, EventArgs e)
  {
    if (!double.TryParse(TxtCelsius.Text, out double celsius))
    {
      MessageBox.Show("Bitte einen gültigen Celsius-Wert eingeben.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    if (celsius < AbsoluteZero)
    {
      MessageBox.Show($"Warnung: {celsius} °C liegt unter dem absoluten Nullpunkt ({AbsoluteZero} °C).",
        "Physikalisch unmöglich", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    double fahrenheit = celsius * 9.0 / 5.0 + 32;
    TxtFahrenheit.Text = $"{fahrenheit:F2}";
  }

  private void CmdFahrenheitToCelsius_Click(object sender, EventArgs e)
  {
    if (!double.TryParse(TxtFahrenheit.Text, out double fahrenheit))
    {
      MessageBox.Show("Bitte einen gültigen Fahrenheit-Wert eingeben.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    double celsius = (fahrenheit - 32) * 5.0 / 9.0;

    if (celsius < AbsoluteZero)
    {
      MessageBox.Show($"Warnung: Ergebnis {celsius:F2} °C liegt unter dem absoluten Nullpunkt.",
        "Physikalisch unmöglich", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    TxtCelsius.Text = $"{celsius:F2}";
  }
}
