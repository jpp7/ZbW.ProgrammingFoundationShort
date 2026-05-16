namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag3_SichererDateiLeser;

partial class SichererDateiLeserForm
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
    LblPfad = new Label();
    TxtPfad = new TextBox();
    CmdLesen = new Button();
    LstZeilen = new ListBox();
    LblStatus = new Label();
    SuspendLayout();

    LblPfad.AutoSize = true;
    LblPfad.Location = new Point(12, 20);
    LblPfad.Text = "Dateipfad:";

    TxtPfad.Location = new Point(90, 17);
    TxtPfad.Name = "TxtPfad";
    TxtPfad.Size = new Size(280, 23);

    CmdLesen.Location = new Point(380, 16);
    CmdLesen.Name = "CmdLesen";
    CmdLesen.Size = new Size(80, 25);
    CmdLesen.Text = "Lesen";
    CmdLesen.Click += CmdLesen_Click;

    LstZeilen.Location = new Point(12, 50);
    LstZeilen.Name = "LstZeilen";
    LstZeilen.Size = new Size(450, 200);

    LblStatus.AutoSize = true;
    LblStatus.Location = new Point(12, 262);
    LblStatus.Name = "LblStatus";
    LblStatus.Text = "";

    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(480, 295);
    Controls.Add(LblPfad);
    Controls.Add(TxtPfad);
    Controls.Add(CmdLesen);
    Controls.Add(LstZeilen);
    Controls.Add(LblStatus);
    Name = "SichererDateiLeserForm";
    Text = "Sicherer Datei-Leser – Auftrag 3";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblPfad;
  private TextBox TxtPfad;
  private Button CmdLesen;
  private ListBox LstZeilen;
  private Label LblStatus;
}
