namespace ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag2_MathUtils;

partial class MathUtilsForm
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
    LblGolden = new Label();
    LblEingabe = new Label(); TxtEingabe = new TextBox();
    GrpFunktion = new GroupBox();
    RdoPrim = new RadioButton(); RdoFakultaet = new RadioButton(); RdoLinspace = new RadioButton();
    CmdBerechnen = new Button(); LblErgebnis = new Label();
    GrpFunktion.SuspendLayout();
    SuspendLayout();

    LblGolden.AutoSize = true; LblGolden.Location = new Point(12, 12); LblGolden.Name = "LblGolden"; LblGolden.Text = "";
    LblEingabe.AutoSize = true; LblEingabe.Location = new Point(12, 45); LblEingabe.Text = "Eingabe n:";
    TxtEingabe.Location = new Point(100, 42); TxtEingabe.Name = "TxtEingabe"; TxtEingabe.Size = new Size(80, 23);

    GrpFunktion.Location = new Point(12, 75); GrpFunktion.Name = "GrpFunktion"; GrpFunktion.Size = new Size(280, 40); GrpFunktion.Text = "Funktion";
    GrpFunktion.Controls.Add(RdoPrim); GrpFunktion.Controls.Add(RdoFakultaet); GrpFunktion.Controls.Add(RdoLinspace);
    RdoPrim.AutoSize = true; RdoPrim.Checked = true; RdoPrim.Location = new Point(8, 15); RdoPrim.Name = "RdoPrim"; RdoPrim.Text = "Primzahl?";
    RdoFakultaet.AutoSize = true; RdoFakultaet.Location = new Point(100, 15); RdoFakultaet.Name = "RdoFakultaet"; RdoFakultaet.Text = "n!";
    RdoLinspace.AutoSize = true; RdoLinspace.Location = new Point(160, 15); RdoLinspace.Name = "RdoLinspace"; RdoLinspace.Text = "Linspace";

    CmdBerechnen.Location = new Point(12, 125); CmdBerechnen.Name = "CmdBerechnen"; CmdBerechnen.Size = new Size(120, 28); CmdBerechnen.Text = "Berechnen"; CmdBerechnen.Click += CmdBerechnen_Click;
    LblErgebnis.AutoSize = true; LblErgebnis.Location = new Point(12, 165); LblErgebnis.Name = "LblErgebnis"; LblErgebnis.Text = "";

    AutoScaleDimensions = new SizeF(7F, 15F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(360, 210);
    Controls.Add(LblGolden); Controls.Add(LblEingabe); Controls.Add(TxtEingabe);
    Controls.Add(GrpFunktion); Controls.Add(CmdBerechnen); Controls.Add(LblErgebnis);
    Name = "MathUtilsForm"; Text = "MathUtils – Auftrag 2";
    GrpFunktion.ResumeLayout(false); GrpFunktion.PerformLayout();
    ResumeLayout(false); PerformLayout();
  }

  private Label LblGolden;
  private Label LblEingabe; private TextBox TxtEingabe;
  private GroupBox GrpFunktion;
  private RadioButton RdoPrim; private RadioButton RdoFakultaet; private RadioButton RdoLinspace;
  private Button CmdBerechnen; private Label LblErgebnis;
}
