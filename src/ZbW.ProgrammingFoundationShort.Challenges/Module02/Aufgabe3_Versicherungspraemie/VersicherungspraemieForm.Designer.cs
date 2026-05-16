namespace ZbW.ProgrammingFoundationShort.Challenges.Module02.Aufgabe3_Versicherungspraemie;

partial class VersicherungspraemieForm
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
    LblAlter = new Label();
    TxtAlter = new TextBox();
    GrpTyp = new GroupBox();
    RdoBasis = new RadioButton();
    RdoStandard = new RadioButton();
    RdoPremium = new RadioButton();
    ChkUnfall = new CheckBox();
    CmdBerechnen = new Button();
    LblErgebnis = new Label();
    GrpTyp.SuspendLayout();
    SuspendLayout();

    LblAlter.AutoSize = true;
    LblAlter.Location = new Point(12, 20);
    LblAlter.Text = "Alter (Jahre):";

    TxtAlter.Location = new Point(130, 17);
    TxtAlter.Name = "TxtAlter";
    TxtAlter.Size = new Size(80, 23);

    GrpTyp.Location = new Point(12, 50);
    GrpTyp.Name = "GrpTyp";
    GrpTyp.Size = new Size(220, 95);
    GrpTyp.Text = "Versicherungstyp";
    GrpTyp.Controls.Add(RdoBasis);
    GrpTyp.Controls.Add(RdoStandard);
    GrpTyp.Controls.Add(RdoPremium);

    RdoBasis.AutoSize = true;
    RdoBasis.Checked = true;
    RdoBasis.Location = new Point(10, 20);
    RdoBasis.Name = "RdoBasis";
    RdoBasis.Text = "Basis (×1.0)";

    RdoStandard.AutoSize = true;
    RdoStandard.Location = new Point(10, 45);
    RdoStandard.Name = "RdoStandard";
    RdoStandard.Text = "Standard (×1.4)";

    RdoPremium.AutoSize = true;
    RdoPremium.Location = new Point(10, 68);
    RdoPremium.Name = "RdoPremium";
    RdoPremium.Text = "Premium (×1.8)";

    ChkUnfall.AutoSize = true;
    ChkUnfall.Location = new Point(12, 155);
    ChkUnfall.Name = "ChkUnfall";
    ChkUnfall.Text = "Unfallzusatz (+20 CHF)";

    CmdBerechnen.Location = new Point(12, 185);
    CmdBerechnen.Name = "CmdBerechnen";
    CmdBerechnen.Size = new Size(130, 28);
    CmdBerechnen.Text = "Berechnen";
    CmdBerechnen.Click += CmdBerechnen_Click;

    LblErgebnis.AutoSize = true;
    LblErgebnis.Location = new Point(12, 225);
    LblErgebnis.Name = "LblErgebnis";
    LblErgebnis.Text = "";

    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(380, 340);
    Controls.Add(LblAlter);
    Controls.Add(TxtAlter);
    Controls.Add(GrpTyp);
    Controls.Add(ChkUnfall);
    Controls.Add(CmdBerechnen);
    Controls.Add(LblErgebnis);
    Name = "VersicherungspraemieForm";
    Text = "Versicherungsprämie – Aufgabe 3";
    GrpTyp.ResumeLayout(false);
    GrpTyp.PerformLayout();
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblAlter;
  private TextBox TxtAlter;
  private GroupBox GrpTyp;
  private RadioButton RdoBasis;
  private RadioButton RdoStandard;
  private RadioButton RdoPremium;
  private CheckBox ChkUnfall;
  private Button CmdBerechnen;
  private Label LblErgebnis;
}
