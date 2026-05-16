namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag2_WochentageApp;

partial class WochentageAppForm
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
    LblWochentag = new Label();
    CmbWochentag = new ComboBox();
    CmdAnzeigen = new Button();
    LblErgebnis = new Label();
    SuspendLayout();

    // LblWochentag
    LblWochentag.AutoSize = true;
    LblWochentag.Location = new Point(12, 20);
    LblWochentag.Text = "Wochentag:";

    // CmbWochentag
    CmbWochentag.DropDownStyle = ComboBoxStyle.DropDownList;
    CmbWochentag.Location = new Point(120, 17);
    CmbWochentag.Name = "CmbWochentag";
    CmbWochentag.Size = new Size(150, 23);

    // CmdAnzeigen
    CmdAnzeigen.Location = new Point(120, 50);
    CmdAnzeigen.Name = "CmdAnzeigen";
    CmdAnzeigen.Size = new Size(120, 28);
    CmdAnzeigen.Text = "Anzeigen";
    CmdAnzeigen.Click += CmdAnzeigen_Click;

    // LblErgebnis
    LblErgebnis.AutoSize = true;
    LblErgebnis.Location = new Point(12, 90);
    LblErgebnis.Name = "LblErgebnis";
    LblErgebnis.Text = "";

    // WochentageAppForm
    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(320, 130);
    Controls.Add(LblWochentag);
    Controls.Add(CmbWochentag);
    Controls.Add(CmdAnzeigen);
    Controls.Add(LblErgebnis);
    Name = "WochentageAppForm";
    Text = "WochentageApp – Auftrag 2";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblWochentag;
  private ComboBox CmbWochentag;
  private Button CmdAnzeigen;
  private Label LblErgebnis;
}
