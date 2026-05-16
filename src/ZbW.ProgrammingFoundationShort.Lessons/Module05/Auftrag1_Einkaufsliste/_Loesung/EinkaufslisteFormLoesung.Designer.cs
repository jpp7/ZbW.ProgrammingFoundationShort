namespace ZbW.ProgrammingFoundationShort.Lessons.Module05.Auftrag1_Einkaufsliste;

partial class EinkaufslisteFormLoesung
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
    LblArtikel = new Label();
    TxtArtikel = new TextBox();
    CmdHinzufuegen = new Button();
    CmdEntfernen = new Button();
    CmdAlleLoeschen = new Button();
    LstArtikel = new ListBox();
    LblAnzahl = new Label();
    SuspendLayout();

    LblArtikel.AutoSize = true;
    LblArtikel.Location = new Point(12, 20);
    LblArtikel.Text = "Artikel:";

    TxtArtikel.Location = new Point(70, 17);
    TxtArtikel.Name = "TxtArtikel";
    TxtArtikel.Size = new Size(180, 23);

    CmdHinzufuegen.Location = new Point(260, 16);
    CmdHinzufuegen.Name = "CmdHinzufuegen";
    CmdHinzufuegen.Size = new Size(100, 25);
    CmdHinzufuegen.Text = "Hinzufügen";
    CmdHinzufuegen.Click += CmdHinzufuegen_Click;

    CmdEntfernen.Location = new Point(70, 50);
    CmdEntfernen.Name = "CmdEntfernen";
    CmdEntfernen.Size = new Size(100, 25);
    CmdEntfernen.Text = "Entfernen";
    CmdEntfernen.Click += CmdEntfernen_Click;

    CmdAlleLoeschen.Location = new Point(180, 50);
    CmdAlleLoeschen.Name = "CmdAlleLoeschen";
    CmdAlleLoeschen.Size = new Size(100, 25);
    CmdAlleLoeschen.Text = "Alle löschen";
    CmdAlleLoeschen.Click += CmdAlleLoeschen_Click;

    LstArtikel.Location = new Point(12, 85);
    LstArtikel.Name = "LstArtikel";
    LstArtikel.Size = new Size(350, 160);

    LblAnzahl.AutoSize = true;
    LblAnzahl.Location = new Point(12, 258);
    LblAnzahl.Name = "LblAnzahl";
    LblAnzahl.Text = "Artikel: 0";

    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(380, 290);
    Controls.Add(LblArtikel);
    Controls.Add(TxtArtikel);
    Controls.Add(CmdHinzufuegen);
    Controls.Add(CmdEntfernen);
    Controls.Add(CmdAlleLoeschen);
    Controls.Add(LstArtikel);
    Controls.Add(LblAnzahl);
    Name = "EinkaufslisteFormLoesung";
    Text = "Einkaufsliste – Lösung";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblArtikel;
  private TextBox TxtArtikel;
  private Button CmdHinzufuegen;
  private Button CmdEntfernen;
  private Button CmdAlleLoeschen;
  private ListBox LstArtikel;
  private Label LblAnzahl;
}
