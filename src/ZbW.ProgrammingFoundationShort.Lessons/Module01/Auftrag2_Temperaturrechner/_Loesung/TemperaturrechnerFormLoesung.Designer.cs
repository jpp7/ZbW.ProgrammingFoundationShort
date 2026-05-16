namespace ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag2_Temperaturrechner;

partial class TemperaturrechnerFormLoesung
{
  private System.ComponentModel.IContainer components = null;

  protected override void Dispose(bool disposing)
  {
    if (disposing && (components != null))
      components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    LblCelsius = new Label();
    TxtCelsius = new TextBox();
    CmdCelsiusToFahrenheit = new Button();
    LblFahrenheit = new Label();
    TxtFahrenheit = new TextBox();
    CmdFahrenheitToCelsius = new Button();
    SuspendLayout();

    LblCelsius.AutoSize = true;
    LblCelsius.Location = new Point(12, 20);
    LblCelsius.Text = "Celsius:";

    TxtCelsius.Location = new Point(120, 17);
    TxtCelsius.Name = "TxtCelsius";
    TxtCelsius.Size = new Size(120, 23);

    CmdCelsiusToFahrenheit.Location = new Point(260, 16);
    CmdCelsiusToFahrenheit.Name = "CmdCelsiusToFahrenheit";
    CmdCelsiusToFahrenheit.Size = new Size(140, 25);
    CmdCelsiusToFahrenheit.Text = "→ Fahrenheit";
    CmdCelsiusToFahrenheit.Click += CmdCelsiusToFahrenheit_Click;

    LblFahrenheit.AutoSize = true;
    LblFahrenheit.Location = new Point(12, 60);
    LblFahrenheit.Text = "Fahrenheit:";

    TxtFahrenheit.Location = new Point(120, 57);
    TxtFahrenheit.Name = "TxtFahrenheit";
    TxtFahrenheit.Size = new Size(120, 23);

    CmdFahrenheitToCelsius.Location = new Point(260, 56);
    CmdFahrenheitToCelsius.Name = "CmdFahrenheitToCelsius";
    CmdFahrenheitToCelsius.Size = new Size(140, 25);
    CmdFahrenheitToCelsius.Text = "→ Celsius";
    CmdFahrenheitToCelsius.Click += CmdFahrenheitToCelsius_Click;

    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(430, 100);
    Controls.Add(LblCelsius);
    Controls.Add(TxtCelsius);
    Controls.Add(CmdCelsiusToFahrenheit);
    Controls.Add(LblFahrenheit);
    Controls.Add(TxtFahrenheit);
    Controls.Add(CmdFahrenheitToCelsius);
    Name = "TemperaturrechnerFormLoesung";
    Text = "Temperaturrechner – Musterlösung";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblCelsius;
  private TextBox TxtCelsius;
  private Button CmdCelsiusToFahrenheit;
  private Label LblFahrenheit;
  private TextBox TxtFahrenheit;
  private Button CmdFahrenheitToCelsius;
}
