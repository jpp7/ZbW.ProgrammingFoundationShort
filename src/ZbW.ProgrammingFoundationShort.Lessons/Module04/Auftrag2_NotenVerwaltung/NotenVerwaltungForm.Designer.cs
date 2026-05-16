namespace ZbW.ProgrammingFoundationShort.Lessons.Module04.Auftrag2_NotenVerwaltung;

partial class NotenVerwaltungForm
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
    LblNoteInput = new Label();
    TxtNote = new TextBox();
    CmdHinzufuegen = new Button();
    LblNotenLabel = new Label();
    LblNoten = new Label();
    LblStats = new Label();
    SuspendLayout();

    LblNoteInput.AutoSize = true;
    LblNoteInput.Location = new Point(12, 20);
    LblNoteInput.Text = "Note (1.0–6.0):";

    TxtNote.Location = new Point(140, 17);
    TxtNote.Name = "TxtNote";
    TxtNote.Size = new Size(80, 23);

    CmdHinzufuegen.Location = new Point(235, 16);
    CmdHinzufuegen.Name = "CmdHinzufuegen";
    CmdHinzufuegen.Size = new Size(110, 25);
    CmdHinzufuegen.Text = "Hinzufügen";
    CmdHinzufuegen.Click += CmdHinzufuegen_Click;

    LblNotenLabel.AutoSize = true;
    LblNotenLabel.Location = new Point(12, 55);
    LblNotenLabel.Text = "Noten:";

    LblNoten.AutoSize = true;
    LblNoten.Location = new Point(12, 72);
    LblNoten.Name = "LblNoten";
    LblNoten.Text = "(noch keine Noten)";

    LblStats.AutoSize = true;
    LblStats.Location = new Point(12, 130);
    LblStats.Name = "LblStats";
    LblStats.Text = "";

    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(380, 200);
    Controls.Add(LblNoteInput);
    Controls.Add(TxtNote);
    Controls.Add(CmdHinzufuegen);
    Controls.Add(LblNotenLabel);
    Controls.Add(LblNoten);
    Controls.Add(LblStats);
    Name = "NotenVerwaltungForm";
    Text = "Noten-Verwaltung – Auftrag 2";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblNoteInput;
  private TextBox TxtNote;
  private Button CmdHinzufuegen;
  private Label LblNotenLabel;
  private Label LblNoten;
  private Label LblStats;
}
