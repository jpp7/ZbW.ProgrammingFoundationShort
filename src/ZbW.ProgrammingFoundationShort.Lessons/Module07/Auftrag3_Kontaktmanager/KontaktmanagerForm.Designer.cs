namespace ZbW.ProgrammingFoundationShort.Lessons.Module07.Auftrag3_Kontaktmanager;

partial class KontaktmanagerForm
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
    LblFirst = new Label(); TxtFirstName = new TextBox();
    LblLast = new Label(); TxtLastName = new TextBox();
    LblEmail = new Label(); TxtEmail = new TextBox();
    CmdHinzufuegen = new Button(); CmdEntfernen = new Button();
    LstKontakte = new ListBox();
    SuspendLayout();

    LblFirst.AutoSize = true; LblFirst.Location = new Point(12, 15); LblFirst.Text = "Vorname:";
    TxtFirstName.Location = new Point(90, 12); TxtFirstName.Name = "TxtFirstName"; TxtFirstName.Size = new Size(130, 23);
    LblLast.AutoSize = true; LblLast.Location = new Point(235, 15); LblLast.Text = "Nachname:";
    TxtLastName.Location = new Point(310, 12); TxtLastName.Name = "TxtLastName"; TxtLastName.Size = new Size(130, 23);
    LblEmail.AutoSize = true; LblEmail.Location = new Point(12, 45); LblEmail.Text = "E-Mail:";
    TxtEmail.Location = new Point(90, 42); TxtEmail.Name = "TxtEmail"; TxtEmail.Size = new Size(200, 23);

    CmdHinzufuegen.Location = new Point(12, 75); CmdHinzufuegen.Name = "CmdHinzufuegen"; CmdHinzufuegen.Size = new Size(110, 25); CmdHinzufuegen.Text = "Hinzufügen"; CmdHinzufuegen.Click += CmdHinzufuegen_Click;
    CmdEntfernen.Location = new Point(130, 75); CmdEntfernen.Name = "CmdEntfernen"; CmdEntfernen.Size = new Size(110, 25); CmdEntfernen.Text = "Entfernen"; CmdEntfernen.Click += CmdEntfernen_Click;

    LstKontakte.Location = new Point(12, 110); LstKontakte.Name = "LstKontakte"; LstKontakte.Size = new Size(440, 160);

    AutoScaleDimensions = new SizeF(7F, 15F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(470, 285);
    Controls.Add(LblFirst); Controls.Add(TxtFirstName); Controls.Add(LblLast); Controls.Add(TxtLastName);
    Controls.Add(LblEmail); Controls.Add(TxtEmail);
    Controls.Add(CmdHinzufuegen); Controls.Add(CmdEntfernen); Controls.Add(LstKontakte);
    Name = "KontaktmanagerForm"; Text = "Kontaktmanager – Auftrag 3";
    ResumeLayout(false); PerformLayout();
  }

  private Label LblFirst; private TextBox TxtFirstName;
  private Label LblLast; private TextBox TxtLastName;
  private Label LblEmail; private TextBox TxtEmail;
  private Button CmdHinzufuegen; private Button CmdEntfernen;
  private ListBox LstKontakte;
}
