namespace ZbW.ProgrammingFoundationShort.Lessons.Module06.Auftrag2_FahrzeugVerwaltung;

partial class FahrzeugVerwaltungFormLoesung
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
    LblMake = new Label(); TxtMake = new TextBox();
    LblModel = new Label(); TxtModel = new TextBox();
    LblYear = new Label(); TxtYear = new TextBox();
    LblPrice = new Label(); TxtPrice = new TextBox();
    CmdHinzufuegen = new Button(); LstFahrzeuge = new ListBox();
    CmdGuenstigstes = new Button(); LblErgebnis = new Label();
    SuspendLayout();

    LblMake.AutoSize = true; LblMake.Location = new Point(12, 15); LblMake.Text = "Marke:";
    TxtMake.Location = new Point(80, 12); TxtMake.Name = "TxtMake"; TxtMake.Size = new Size(120, 23);
    LblModel.AutoSize = true; LblModel.Location = new Point(215, 15); LblModel.Text = "Modell:";
    TxtModel.Location = new Point(265, 12); TxtModel.Name = "TxtModel"; TxtModel.Size = new Size(120, 23);
    LblYear.AutoSize = true; LblYear.Location = new Point(12, 45); LblYear.Text = "Baujahr:";
    TxtYear.Location = new Point(80, 42); TxtYear.Name = "TxtYear"; TxtYear.Size = new Size(70, 23);
    LblPrice.AutoSize = true; LblPrice.Location = new Point(165, 45); LblPrice.Text = "Preis (CHF):";
    TxtPrice.Location = new Point(250, 42); TxtPrice.Name = "TxtPrice"; TxtPrice.Size = new Size(100, 23);
    CmdHinzufuegen.Location = new Point(12, 75); CmdHinzufuegen.Name = "CmdHinzufuegen"; CmdHinzufuegen.Size = new Size(120, 25); CmdHinzufuegen.Text = "Hinzufügen"; CmdHinzufuegen.Click += CmdHinzufuegen_Click;
    LstFahrzeuge.Location = new Point(12, 110); LstFahrzeuge.Name = "LstFahrzeuge"; LstFahrzeuge.Size = new Size(420, 150);
    CmdGuenstigstes.Location = new Point(12, 270); CmdGuenstigstes.Name = "CmdGuenstigstes"; CmdGuenstigstes.Size = new Size(140, 25); CmdGuenstigstes.Text = "Günstigstes zeigen"; CmdGuenstigstes.Click += CmdGuenstigstes_Click;
    LblErgebnis.AutoSize = true; LblErgebnis.Location = new Point(12, 305); LblErgebnis.Name = "LblErgebnis"; LblErgebnis.Text = "";

    AutoScaleDimensions = new SizeF(7F, 15F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(450, 340);
    Controls.Add(LblMake); Controls.Add(TxtMake); Controls.Add(LblModel); Controls.Add(TxtModel);
    Controls.Add(LblYear); Controls.Add(TxtYear); Controls.Add(LblPrice); Controls.Add(TxtPrice);
    Controls.Add(CmdHinzufuegen); Controls.Add(LstFahrzeuge); Controls.Add(CmdGuenstigstes); Controls.Add(LblErgebnis);
    Name = "FahrzeugVerwaltungFormLoesung"; Text = "Fahrzeug-Verwaltung – Lösung";
    ResumeLayout(false); PerformLayout();
  }

  private Label LblMake; private TextBox TxtMake;
  private Label LblModel; private TextBox TxtModel;
  private Label LblYear; private TextBox TxtYear;
  private Label LblPrice; private TextBox TxtPrice;
  private Button CmdHinzufuegen; private ListBox LstFahrzeuge;
  private Button CmdGuenstigstes; private Label LblErgebnis;
}
