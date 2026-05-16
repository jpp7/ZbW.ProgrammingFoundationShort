namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag3_RabattKalkulator;

partial class RabattKalkulatorForm
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
    LblBetrag = new Label();
    TxtBetrag = new TextBox();
    GrpKundentyp = new GroupBox();
    RdoNormal = new RadioButton();
    RdoPremium = new RadioButton();
    RdoVip = new RadioButton();
    ChkLehrling = new CheckBox();
    CmdBerechnen = new Button();
    LblErgebnis = new Label();
    GrpKundentyp.SuspendLayout();
    SuspendLayout();

    // LblBetrag
    LblBetrag.AutoSize = true;
    LblBetrag.Location = new Point(12, 20);
    LblBetrag.Text = "Betrag (CHF):";

    // TxtBetrag
    TxtBetrag.Location = new Point(130, 17);
    TxtBetrag.Name = "TxtBetrag";
    TxtBetrag.Size = new Size(100, 23);

    // GrpKundentyp
    GrpKundentyp.Location = new Point(12, 50);
    GrpKundentyp.Name = "GrpKundentyp";
    GrpKundentyp.Size = new Size(220, 95);
    GrpKundentyp.Text = "Kundentyp";
    GrpKundentyp.Controls.Add(RdoNormal);
    GrpKundentyp.Controls.Add(RdoPremium);
    GrpKundentyp.Controls.Add(RdoVip);

    // RdoNormal
    RdoNormal.AutoSize = true;
    RdoNormal.Checked = true;
    RdoNormal.Location = new Point(10, 20);
    RdoNormal.Name = "RdoNormal";
    RdoNormal.Text = "Normal (0%)";

    // RdoPremium
    RdoPremium.AutoSize = true;
    RdoPremium.Location = new Point(10, 45);
    RdoPremium.Name = "RdoPremium";
    RdoPremium.Text = "Premium (10%)";

    // RdoVip
    RdoVip.AutoSize = true;
    RdoVip.Location = new Point(10, 68);
    RdoVip.Name = "RdoVip";
    RdoVip.Text = "VIP (20%)";

    // ChkLehrling
    ChkLehrling.AutoSize = true;
    ChkLehrling.Location = new Point(12, 155);
    ChkLehrling.Name = "ChkLehrling";
    ChkLehrling.Text = "Lehrling (+5%)";

    // CmdBerechnen
    CmdBerechnen.Location = new Point(12, 185);
    CmdBerechnen.Name = "CmdBerechnen";
    CmdBerechnen.Size = new Size(130, 28);
    CmdBerechnen.Text = "Berechnen";
    CmdBerechnen.Click += CmdBerechnen_Click;

    // LblErgebnis
    LblErgebnis.AutoSize = true;
    LblErgebnis.Location = new Point(12, 225);
    LblErgebnis.Name = "LblErgebnis";
    LblErgebnis.Text = "";

    // RabattKalkulatorForm
    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(360, 270);
    Controls.Add(LblBetrag);
    Controls.Add(TxtBetrag);
    Controls.Add(GrpKundentyp);
    Controls.Add(ChkLehrling);
    Controls.Add(CmdBerechnen);
    Controls.Add(LblErgebnis);
    Name = "RabattKalkulatorForm";
    Text = "Rabatt-Kalkulator – Auftrag 3";
    GrpKundentyp.ResumeLayout(false);
    GrpKundentyp.PerformLayout();
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblBetrag;
  private TextBox TxtBetrag;
  private GroupBox GrpKundentyp;
  private RadioButton RdoNormal;
  private RadioButton RdoPremium;
  private RadioButton RdoVip;
  private CheckBox ChkLehrling;
  private Button CmdBerechnen;
  private Label LblErgebnis;
}
