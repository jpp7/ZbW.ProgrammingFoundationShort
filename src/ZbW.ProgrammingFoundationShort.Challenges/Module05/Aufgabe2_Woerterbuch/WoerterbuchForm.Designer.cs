namespace ZbW.ProgrammingFoundationShort.Challenges.Module05.Aufgabe2_Woerterbuch;

partial class WoerterbuchForm
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
    LblSuche = new Label(); TxtSuche = new TextBox(); CmdUebersetzen = new Button();
    LblDeutsch = new Label(); TxtDeutsch = new TextBox();
    LblEnglisch = new Label(); TxtEnglisch = new TextBox();
    CmdEintragHinzufuegen = new Button(); CmdAlleAnzeigen = new Button();
    TxtAusgabe = new TextBox(); LblErgebnis = new Label();
    SuspendLayout();

    LblSuche.AutoSize = true; LblSuche.Location = new Point(12, 15); LblSuche.Text = "Suche:";
    TxtSuche.Location = new Point(70, 12); TxtSuche.Name = "TxtSuche"; TxtSuche.Size = new Size(150, 23);
    CmdUebersetzen.Location = new Point(230, 11); CmdUebersetzen.Name = "CmdUebersetzen"; CmdUebersetzen.Size = new Size(100, 25); CmdUebersetzen.Text = "Übersetzen"; CmdUebersetzen.Click += CmdUebersetzen_Click;

    LblDeutsch.AutoSize = true; LblDeutsch.Location = new Point(12, 50); LblDeutsch.Text = "Deutsch:";
    TxtDeutsch.Location = new Point(80, 47); TxtDeutsch.Name = "TxtDeutsch"; TxtDeutsch.Size = new Size(120, 23);
    LblEnglisch.AutoSize = true; LblEnglisch.Location = new Point(215, 50); LblEnglisch.Text = "Englisch:";
    TxtEnglisch.Location = new Point(280, 47); TxtEnglisch.Name = "TxtEnglisch"; TxtEnglisch.Size = new Size(120, 23);

    CmdEintragHinzufuegen.Location = new Point(12, 80); CmdEintragHinzufuegen.Name = "CmdEintragHinzufuegen"; CmdEintragHinzufuegen.Size = new Size(130, 25); CmdEintragHinzufuegen.Text = "Eintrag hinzufügen"; CmdEintragHinzufuegen.Click += CmdEintragHinzufuegen_Click;
    CmdAlleAnzeigen.Location = new Point(155, 80); CmdAlleAnzeigen.Name = "CmdAlleAnzeigen"; CmdAlleAnzeigen.Size = new Size(110, 25); CmdAlleAnzeigen.Text = "Alle anzeigen"; CmdAlleAnzeigen.Click += CmdAlleAnzeigen_Click;

    LblErgebnis.AutoSize = true; LblErgebnis.Location = new Point(12, 118); LblErgebnis.Name = "LblErgebnis"; LblErgebnis.Text = "";

    TxtAusgabe.Location = new Point(12, 138); TxtAusgabe.Multiline = true; TxtAusgabe.Name = "TxtAusgabe"; TxtAusgabe.ReadOnly = true;
    TxtAusgabe.Font = new Font("Courier New", 9F); TxtAusgabe.ScrollBars = ScrollBars.Vertical; TxtAusgabe.Size = new Size(400, 130);

    AutoScaleDimensions = new SizeF(7F, 15F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(430, 285);
    Controls.Add(LblSuche); Controls.Add(TxtSuche); Controls.Add(CmdUebersetzen);
    Controls.Add(LblDeutsch); Controls.Add(TxtDeutsch); Controls.Add(LblEnglisch); Controls.Add(TxtEnglisch);
    Controls.Add(CmdEintragHinzufuegen); Controls.Add(CmdAlleAnzeigen); Controls.Add(LblErgebnis); Controls.Add(TxtAusgabe);
    Name = "WoerterbuchForm"; Text = "Wörterbuch – Aufgabe 2";
    ResumeLayout(false); PerformLayout();
  }

  private Label LblSuche; private TextBox TxtSuche; private Button CmdUebersetzen;
  private Label LblDeutsch; private TextBox TxtDeutsch;
  private Label LblEnglisch; private TextBox TxtEnglisch;
  private Button CmdEintragHinzufuegen; private Button CmdAlleAnzeigen;
  private TextBox TxtAusgabe; private Label LblErgebnis;
}
