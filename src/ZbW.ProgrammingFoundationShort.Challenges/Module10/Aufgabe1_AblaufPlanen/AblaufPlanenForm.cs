namespace ZbW.ProgrammingFoundationShort.Challenges.Module10.Aufgabe1_AblaufPlanen;

public sealed class AblaufPlanenForm : Form
{
  private readonly TextBox txtFlowchart;
  private readonly TextBox txtTodos;

  public AblaufPlanenForm()
  {
    Text = "Ablauf planen – Aufgabe 1";
    ClientSize = new Size(760, 520);

    Label lblRules = new Label
    {
      Location = new Point(12, 12),
      Size = new Size(720, 75),
      Text = "Problem: Eintrittspreis berechnen\r\n" +
             "Alter < 0: ungültig | unter 6: gratis | 6-15: Kinderpreis | 16-64: Normalpreis | ab 65: Seniorenpreis"
    };

    Button cmdTemplate = new Button { Location = new Point(12, 95), Size = new Size(170, 30), Text = "Vorlage einfügen" };
    txtFlowchart = new TextBox
    {
      Location = new Point(12, 135),
      Size = new Size(350, 360),
      Multiline = true,
      ScrollBars = ScrollBars.Vertical
    };
    txtTodos = new TextBox
    {
      Location = new Point(380, 135),
      Size = new Size(360, 360),
      Multiline = true,
      ScrollBars = ScrollBars.Vertical
    };

    cmdTemplate.Click += CmdTemplate_Click;

    Controls.Add(lblRules);
    Controls.Add(cmdTemplate);
    Controls.Add(txtFlowchart);
    Controls.Add(txtTodos);
  }

  private void CmdTemplate_Click(object? sender, EventArgs e)
  {
    txtFlowchart.Text = "Start\r\n  |\r\nAlter einlesen\r\n  |\r\nAlter gültig?\r\n  |-- nein --> Ungültig --> Ende\r\n  |\r\n ja\r\n  |\r\nPreisgruppe bestimmen\r\n  |\r\nErgebnis anzeigen\r\n  |\r\nEnde";
    txtTodos.Text = "static string GetTicketType(int age)\r\n{\r\n    // TODO: Ungültiges Alter prüfen\r\n    // TODO: Gratis prüfen\r\n    // TODO: Kinderpreis prüfen\r\n    // TODO: Normalpreis prüfen\r\n    // TODO: Seniorenpreis zurückgeben\r\n}";
  }
}