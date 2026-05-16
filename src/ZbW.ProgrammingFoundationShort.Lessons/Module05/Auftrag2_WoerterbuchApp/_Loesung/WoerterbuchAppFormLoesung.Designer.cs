namespace ZbW.ProgrammingFoundationShort.Lessons.Module05.Auftrag2_WoerterbuchApp;

partial class WoerterbuchAppFormLoesung
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
    LblSuche = new Label();
    TxtSuche = new TextBox();
    CmdNachschlagen = new Button();
    LblErgebnis = new Label();
    LblNeuKey = new Label();
    TxtKeyNeu = new TextBox();
    LblNeuValue = new Label();
    TxtValueNeu = new TextBox();
    CmdHinzufuegen = new Button();
    LstEintraege = new ListBox();
    SuspendLayout();

    LblSuche.AutoSize = true; LblSuche.Location = new Point(12, 20); LblSuche.Text = "Suche (Deutsch):";
    TxtSuche.Location = new Point(140, 17); TxtSuche.Name = "TxtSuche"; TxtSuche.Size = new Size(130, 23);
    CmdNachschlagen.Location = new Point(280, 16); CmdNachschlagen.Name = "CmdNachschlagen"; CmdNachschlagen.Size = new Size(110, 25); CmdNachschlagen.Text = "Nachschlagen"; CmdNachschlagen.Click += CmdNachschlagen_Click;
    LblErgebnis.AutoSize = true; LblErgebnis.Location = new Point(12, 52); LblErgebnis.Name = "LblErgebnis"; LblErgebnis.Text = "";
    LblNeuKey.AutoSize = true; LblNeuKey.Location = new Point(12, 85); LblNeuKey.Text = "Deutsch:";
    TxtKeyNeu.Location = new Point(90, 82); TxtKeyNeu.Name = "TxtKeyNeu"; TxtKeyNeu.Size = new Size(120, 23);
    LblNeuValue.AutoSize = true; LblNeuValue.Location = new Point(220, 85); LblNeuValue.Text = "Englisch:";
    TxtValueNeu.Location = new Point(290, 82); TxtValueNeu.Name = "TxtValueNeu"; TxtValueNeu.Size = new Size(120, 23);
    CmdHinzufuegen.Location = new Point(12, 115); CmdHinzufuegen.Name = "CmdHinzufuegen"; CmdHinzufuegen.Size = new Size(120, 25); CmdHinzufuegen.Text = "Hinzufügen"; CmdHinzufuegen.Click += CmdHinzufuegen_Click;
    LstEintraege.Location = new Point(12, 150); LstEintraege.Name = "LstEintraege"; LstEintraege.Size = new Size(400, 160);

    AutoScaleDimensions = new SizeF(7F, 15F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(430, 325);
    Controls.Add(LblSuche); Controls.Add(TxtSuche); Controls.Add(CmdNachschlagen); Controls.Add(LblErgebnis);
    Controls.Add(LblNeuKey); Controls.Add(TxtKeyNeu); Controls.Add(LblNeuValue); Controls.Add(TxtValueNeu);
    Controls.Add(CmdHinzufuegen); Controls.Add(LstEintraege);
    Name = "WoerterbuchAppFormLoesung"; Text = "Wörterbuch-App – Lösung";
    ResumeLayout(false); PerformLayout();
  }

  private Label LblSuche; private TextBox TxtSuche; private Button CmdNachschlagen; private Label LblErgebnis;
  private Label LblNeuKey; private TextBox TxtKeyNeu; private Label LblNeuValue; private TextBox TxtValueNeu;
  private Button CmdHinzufuegen; private ListBox LstEintraege;
}
