namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag3_SichererDateiLeser;

// ============================================================
// AUFTRAG 3 – SichererDateiLeser (⭐⭐ Mittel | ~15 Min.)
//
// Liest eine Datei mit try-catch-finally ab und zeigt Zeilen an.
//
// Anforderungen:
//   - TxtPfad: Dateipfad eingeben
//   - try: File.ReadAllLines, for-Schleife mit Zeilennummer
//   - catch FileNotFoundException: eigene Meldung
//   - catch Exception: allgemeiner Fehler
//   - finally: LblStatus immer setzen
// ============================================================

public partial class SichererDateiLeserForm : Form
{
  public SichererDateiLeserForm()
  {
    InitializeComponent();
  }

  private void CmdLesen_Click(object sender, EventArgs e)
  {
    LstZeilen.Items.Clear();

    // TODO 1: try-catch-finally starten

    // TODO 2: im try-Block:
    //         string[] zeilen = File.ReadAllLines(TxtPfad.Text);
    //         for-Schleife: LstZeilen.Items.Add($"{i+1}: {zeilen[i]}")

    // TODO 3: catch (FileNotFoundException ex):
    //         MessageBox mit Datei-nicht-gefunden-Meldung

    // TODO 4: catch (Exception ex):
    //         MessageBox mit allgemeiner Fehlermeldung

    // TODO 5: finally:
    //         LblStatus.Text = "Lesevorgang abgeschlossen."
  }
}
