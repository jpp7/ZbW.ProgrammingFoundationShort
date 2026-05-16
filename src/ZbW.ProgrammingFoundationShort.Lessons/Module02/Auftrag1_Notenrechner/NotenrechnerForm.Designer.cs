namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag1_Notenrechner;

partial class NotenrechnerForm
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
    LblPunkte = new Label();
    TxtPunkte = new TextBox();
    CmdBerechnen = new Button();
    LblNote = new Label();
    LblBewertung = new Label();
    SuspendLayout();

    // LblPunkte
    LblPunkte.AutoSize = true;
    LblPunkte.Location = new Point(12, 20);
    LblPunkte.Text = "Punkte (0–100):";

    // TxtPunkte
    TxtPunkte.Location = new Point(140, 17);
    TxtPunkte.Name = "TxtPunkte";
    TxtPunkte.Size = new Size(80, 23);

    // CmdBerechnen
    CmdBerechnen.Location = new Point(140, 50);
    CmdBerechnen.Name = "CmdBerechnen";
    CmdBerechnen.Size = new Size(130, 28);
    CmdBerechnen.Text = "Note berechnen";
    CmdBerechnen.Click += CmdBerechnen_Click;

    // LblNote
    LblNote.AutoSize = true;
    LblNote.Location = new Point(12, 90);
    LblNote.Name = "LblNote";
    LblNote.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
    LblNote.Text = "";

    // LblBewertung
    LblBewertung.AutoSize = true;
    LblBewertung.Location = new Point(12, 118);
    LblBewertung.Name = "LblBewertung";
    LblBewertung.Text = "";

    // NotenrechnerForm
    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(320, 150);
    Controls.Add(LblPunkte);
    Controls.Add(TxtPunkte);
    Controls.Add(CmdBerechnen);
    Controls.Add(LblNote);
    Controls.Add(LblBewertung);
    Name = "NotenrechnerForm";
    Text = "Notenrechner – Auftrag 1";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblPunkte;
  private TextBox TxtPunkte;
  private Button CmdBerechnen;
  private Label LblNote;
  private Label LblBewertung;
}
